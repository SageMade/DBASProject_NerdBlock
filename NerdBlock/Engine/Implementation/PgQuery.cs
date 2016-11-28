using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using System.Text.RegularExpressions;

namespace NerdBlock.Engine.Implementation
{
    public class PgQuery : IQuery
    {
        private NpgsqlCommand myCommand;
        private bool isSelect;

        public object QueryObject
        {
            get { return myCommand; }
        }

        public string SqlSource
        {
            get { return myCommand.CommandText; }
        }

        public int ParameterCount
        {
            get { return myCommand.Parameters.Count; }
        }

        public bool HasResults
        {
            get { return isSelect; }
        }

        public PgQuery(IDatabase database, bool hasReturn, string query)
        {
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            myCommand.Prepare();
            isSelect = hasReturn;
        }
        public PgQuery(IDatabase database, bool hasReturn, string query, params object[] commandParams)
        {
            query = string.Format(query, commandParams);
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            
            myCommand.Prepare();
            isSelect = hasReturn;
        }

        public PgQuery(IDatabase database, NpgsqlParameter[] sqlParams, bool hasReturn, string query, params object[] commandParams)
        {
            query = string.Format(query, commandParams);
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            myCommand.Parameters.AddRange(sqlParams);
            myCommand.Prepare();
            isSelect = hasReturn;
        }


        public PgQuery(string query)
        {
            myCommand = new NpgsqlCommand(query);
        }
        public PgQuery(string query, params object[] commandParams)
        {
            myCommand = new NpgsqlCommand(string.Format(query, commandParams));
        }

        public void SetParameter(int index, object value)
        {
            myCommand.Parameters[index].Value = value;
        }
    }
}
