using System;
using System.Collections.Generic;
using NerdBlock.Engine.Implementation;

namespace NerdBlock.Engine
{
    public static class QueryTable
    {
        private static Dictionary<string, IQuery> myKnownQueries;
        private static IDatabase myDatabase;

        public static IDatabase Database
        {
            get { return myDatabase; }
            set { myDatabase = value; }
        }

        static QueryTable()
        {
            myKnownQueries = new Dictionary<string, IQuery>();
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
    }
}