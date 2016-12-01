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
    public class ListViewOutput : IOutput
    {
        private ListBox myView;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set { __SetValue(value); }
        }

        public ListViewOutput(string name, ListBox view)
        {
            Name = name;
            myView = view;
        }

        private void __SetValue(object value)
        {
            if (value is IQueryResult)
            {
                IQueryResult result = value as IQueryResult;
                myView.Items.Clear();

                while(result.HasRow())
                {
                    ListViewItem item = new ListViewItem();

                    for (int index = 0; index < result.Row.ItemArray.Length; index++)
                        item.SubItems.Add(result.Row[index]?.ToString());

                    myView.Items.Add(item);

                    result.MoveNext();
                }
            }
            else if (value is Array)
            {
                Array collection = value as Array;
                myView.Items.Clear();

                if (collection.Length > 0)
                {
                    Type itemType = collection.GetValue(0).GetType();
                    PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    for (int index = 0; index < collection.Length; index++)
                    {
                        string line = "";

                        for (int pIndex = 0; pIndex < properties.Length; pIndex++)
                            line += properties[pIndex].GetValue(collection.GetValue(index))?.ToString() + "    ";

                        myView.Items.Add(line);
                    }
                }
            }
        }
    }
}
