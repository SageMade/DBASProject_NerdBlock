using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class ListViewOutput : IOutput
    {
        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
