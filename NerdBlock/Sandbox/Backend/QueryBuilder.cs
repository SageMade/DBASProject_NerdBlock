﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend
{
    public class QueryBuilder
    {
        public IQuery BuildInsertStatement(PropertyInfo[] properties)
        {
            string sql = "";
            List<string> otherStatements = new List<string>();

            for (int index = 0; index < properties.Length; index++)
            {
                PropertyInfo currentProperty = properties[index];
                DataField dataAttrib = currentProperty.GetCustomAttribute<DataField>();

                bool isAutoGen = currentProperty.GetCustomAttribute<AutoGenerated>() != null;
                bool isPrimaryKey = currentProperty.GetCustomAttribute<PrimaryKey>() != null;

                ForeignKey foreignKey = currentProperty.GetCustomAttribute<ForeignKey>();

                if (!isAutoGen)
                {
                    if (foreignKey != null)
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
