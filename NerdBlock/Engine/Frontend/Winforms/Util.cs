using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    public static class Util
    {
        public static Control[] Where(this Control.ControlCollection collection, Predicate<Control> search)
        {
            List<Control> results = new List<Control>();

            __WhereInternal(collection, search, results);

            return results.ToArray();
        }

        private static void __WhereInternal(Control.ControlCollection collection, Predicate<Control> search, List<Control> results)
        {
            for (int index = 0; index < collection.Count; index++)
            {
                if (search.Invoke(collection[index]))
                    results.Add(collection[index]);

                __WhereInternal(collection[index].Controls, search, results);
            }
        }
    }
}
