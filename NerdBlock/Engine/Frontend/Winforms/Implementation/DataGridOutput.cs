using NerdBlock.Engine.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class DataGridOutput : IOutput
    {
        private DataGridView myView;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set { __SetValue(value); }
        }

        public DataGridOutput(string name, DataGridView view)
        {
            Name = name;
            myView = view;
        }

        private void __SetValue(object value)
        {
            if (value is IQueryResult)
            {
                IQueryResult result = value as IQueryResult;
                BindingSource bs = new BindingSource();
                bs.DataSource = result.Source.Tables[0];
                myView.DataSource = bs;
            }
            else if (value is Array)
            {
                Array collection = value as Array;
                myView.Rows.Clear();

                if (collection.Length > 0)
                {
                    Type itemType = collection.GetValue(0).GetType();
                    PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    for (int iIndex = 0; iIndex < collection.Length; iIndex++)
                    {
                        for (int index = 0; index < myView.Columns.Count; index++)
                        {
                            DataGridViewRow row = myView.Rows[myView.Rows.Add()];

                            PropertyInfo pInfo = properties.Where(X => X.Name.ToLower().Equals(myView.Columns[index].DataPropertyName.ToLower())).FirstOrDefault();

                            if (pInfo != null)
                            {
                                row.Cells[myView.Columns[index].Name].Value = pInfo.GetValue(collection.GetValue(iIndex));
                            }
                        }
                    }
                }
            }
        }
    }
}
