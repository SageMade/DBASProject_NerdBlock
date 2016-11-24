using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend
{
    public class ModelDataAccess<T>
    {
        IQuery mySelectAllQuery;
        IQuery myInsertQuery;
        IQuery myUpdateQuery;
        IQuery myDeleteQuery;

        PropertyInfo[] myModelProperties;
        PropertyInfo[] myForeignKeyProperties;

        public ModelDataAccess()
        {
        }

        public void Insert(T model)
        {
            string insertLeft, insertRight;
            insertLeft = insertRight = "";

            for(int index = 0; index < myModelProperties.Length; index ++)
            {
                object value = myModelProperties[index].GetValue(model);
            }

            QueryTable.Database.Execute(myInsertQuery);
        }
    }
}
