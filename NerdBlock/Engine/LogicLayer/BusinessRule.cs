using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer
{
    public abstract class BusinessRule
    {
        public string DebugName { get; set; }

        public abstract bool CanPerform(string actionName, ref string reason);
    }
}
