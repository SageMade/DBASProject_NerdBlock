using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.Backend
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

        public static IQueryResult ExecuteQuery(string query, QueryParam[] qParams, object[] parameters)
        {
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            return Database.Execute(dbQuery, parameters);
        }

        public static IQueryResult ExecuteQuery(string query)
        {
            IQuery dbQuery = Database.PrepareQuery(query);
            return Database.Execute(dbQuery);
        }

        private static ModelDataAccess<T> __GetDataAccess<T>() where T : new()
        {
            if (!myDataAccessors.ContainsKey(typeof(T)))
                myDataAccessors.Add(typeof(T), new ModelDataAccess<T>());

            return myDataAccessors[typeof(T)] as ModelDataAccess<T>;
        }

        public static int Update<T>(T value, bool updateNullValues = true, bool updateChildren = true) where T : new()
        {
            return __GetDataAccess<T>().Update(value, updateNullValues, updateChildren);
        }

        public static int UpdateWeak(Type modelType, object value, bool updateNullValues = true, bool updateChildren = true)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Update", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (int)mi.Invoke(null, new object[] { value, updateNullValues, updateChildren });
        }

        public static int Delete<T>(T model, bool deleteChildren = false) where T : new()
        {
            return __GetDataAccess<T>().Delete(model, deleteChildren);
        }

        public static int DeleteWeak(Type modelType, object model, bool deleteChildren = false)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Delete", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (int)mi.Invoke(null, new object[] { model, deleteChildren });
        }

        public static T[] Match<T>(T match) where T : new()
        {
            return __GetDataAccess<T>().GetMatches(match);
        }

        public static object[] MatchWeak(Type modelType, object match)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Match", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (object[])mi.Invoke(null, new object[] { match });
        }

        public static bool Exists<T>(T match, bool matchNull = false) where T : new()
        {
            return __GetDataAccess<T>().Exists(match, matchNull);
        }

        public static bool ExistsWeak(Type modelType, object match, bool matchNull = false)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Exists", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (bool)mi.Invoke(null, new object[] { match, matchNull });
        }

        public static bool Insert<T>(T model) where T : new()
        {
            return __GetDataAccess<T>().Insert(model);
        }

        public static bool InsertWeak(Type modelType, object model)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("Insert", BindingFlags.Static | BindingFlags.Public);
            mi = mi.MakeGenericMethod(modelType);
            return (bool)mi.Invoke(null, new[] { model });
        }

        public static ValueType[] SelectAll<ValueType>() where ValueType : new()
        {
            return __GetDataAccess<ValueType>().SelectAll();
        }

        public static int ExecuteStatement(string query, QueryParam[] qParams, params object[] parameters)
        {
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            IQueryResult result = Database.Execute(dbQuery, parameters);

            return result.NumRows;
        }

        public static object GetPrimaryKey<T>(T value) where T : new()
        {
            return __GetDataAccess<T>().GetPrimaryKey(value);
        }

        public static object GetPrimaryKeyWeak(Type propertyType, object value)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("GetPrimaryKey", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(propertyType);
            return mi.Invoke(null, new object[] { value });
        }

        public static T FromPrimaryKey<T>(object value) where T : new()
        {
            return __GetDataAccess<T>().GetFromPrimaryKey(value);
        }

        public static object FromPrimaryKeyWeak(Type propertyType, object value)
        {
            MethodInfo mi = typeof(DataAccess).GetMethod("FromPrimaryKey", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(propertyType);
            return mi.Invoke(null, new object[] { value });
        }
    }
}
