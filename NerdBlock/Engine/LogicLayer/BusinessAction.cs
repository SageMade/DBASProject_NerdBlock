using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer
{
    public class BusinessAction : Attribute
    {
        public string Name { get; set; }

        public BusinessAction() { }

        public BusinessAction(string name) { Name = name; }
    }
}
