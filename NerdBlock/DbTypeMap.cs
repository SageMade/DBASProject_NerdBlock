using System;
using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;

namespace NerdBlock
{
    public static class DbTypeMap
    {
        private static Dictionary<Type, NpgsqlDbType> myTypes;

        static DbTypeMap()
        {
            myTypes = new Dictionary<Type, NpgsqlDbType>()
            {
                { typeof(bool), NpgsqlDbType.Boolean },
                { typeof(short), NpgsqlDbType.Smallint },
                { typeof(int), NpgsqlDbType.Integer },
                { typeof(long), NpgsqlDbType.Bigint },
                { typeof(float), NpgsqlDbType.Real },
                { typeof(double), NpgsqlDbType.Double },
                { typeof(decimal), NpgsqlDbType.Numeric },
                { typeof(string), NpgsqlDbType.Varchar },
            };
        }

        public static object GetNpgsqlType(Type fieldType)
        {
            throw new NotImplementedException();
        }
    }
}