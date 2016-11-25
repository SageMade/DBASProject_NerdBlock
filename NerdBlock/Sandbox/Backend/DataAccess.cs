using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend
{
    public static class DataAccess
    {
        private static Dictionary<string, IQuery> myKnownQueries;
        private static Dictionary<Type, object> myDataAccessors;
        private static IDatabase myDatabase;

        public static IDatabase Database
        {
            get { return myDatabase; }
            set { myDatabase = value; }
        }

        static DataAccess()
        {
            myKnownQueries = new Dictionary<string, IQuery>();
            myDataAccessors = new Dictionary<Type, object>();
        }

        public static void RegisterQuery(string name, IQuery query)
        {
            myKnownQueries.Add(name, query);
        }

        public static IQueryResult Execute(string queryName)
        {
            if (myKnownQueries.ContainsKey(queryName))
                return myDatabase.Execute(myKnownQueries[queryName]);
            else
                throw new KeyNotFoundException(string.Format("No query by the name of \"{0}\" found", queryName));
        }

        public static IQueryResult Execute(string queryName, params object[] parameters)
        {
            if (myKnownQueries.ContainsKey(queryName))
            {
                IQuery query = myKnownQueries[queryName];

                if (parameters.Length != query.ParameterCount)
                    throw new ArgumentException("Parameter count mismatch");

                for (int index = 0; index < query.ParameterCount; index++)
                    query.SetParameter(index, parameters[index]);

                return myDatabase.Execute(myKnownQueries[queryName]);
            }
            else
                throw new KeyNotFoundException(string.Format("No query by the name of \"{0}\" found", queryName));
        }

        private static ModelDataAccess<T> __GetDataAccess<T>() where T : new()
        {
            if (!myDataAccessors.ContainsKey(typeof(T)))
                myDataAccessors.Add(typeof(T), new ModelDataAccess<T>());

            return myDataAccessors[typeof(T)] as ModelDataAccess<T>;
        }

        internal static T[] Match<T>(T match) where T : new()
        {
            return __GetDataAccess<T>().GetMatches(match);
        }

        public static bool Exists<T>(T match, bool matchNull = false) where T : new()
        {
            ModelDataAccess<T> da = __GetDataAccess<T>();
            return da.Exists(match, matchNull);
        }

        public static bool Exists(Type modelType, object match, bool matchNull = false)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Exists", BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (bool)mi.Invoke(null, new[] { match, matchNull });
        }

        public static void Insert<T>(T model) where T : new()
        {
            __GetDataAccess<T>().Insert(model);
        }

        public static void Insert(Type modelType, object model)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Insert", BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            mi.Invoke(null, new[] { model });
        }

        public static int ExecuteStatement(string query, QueryParam[] qParams, params object[] parameters)
        {
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            IQueryResult result = Database.Execute(dbQuery, parameters);

            return result.NumRows;
        }

        internal static object GetPrimaryKey(Type propertyType, object value)
        {
            throw new NotImplementedException();
        }

        internal static IQueryResult ExecuteQuery(string query, QueryParam[] qParams, object[] parameters)
        {
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            return Database.Execute(dbQuery, parameters);
        }
    }
}
