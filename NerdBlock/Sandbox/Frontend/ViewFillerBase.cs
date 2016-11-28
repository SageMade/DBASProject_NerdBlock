using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend
{
    public class ViewFillerBase : IViewFillable
    {
        private Dictionary<string, IFillable> myFillers;

        public IFillable this[int index]
        {
            get { return myFillers.Values.ElementAt(index); }
        }

        public IFillable this[string name]
        {
            get { return myFillers[name]; }
        }

        public int FillableCount
        {
            get { return myFillers.Count; }
        }

        public ViewFillerBase()
        {
            myFillers = new Dictionary<string, IFillable>();
        }

        public void AddFiller(string name, IFillable filler)
        {
            myFillers.Add(name, filler);
        }
        
        public void FillFrom(object value)
        {
            foreach (KeyValuePair<string, IFillable> kvp in myFillers)
            {
                kvp.Value.Fill(value);
            }
        }
    }
}
