using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox
{
    public struct QueryParam
    {
        public string Name { get; set; }
        public QueryParamType Type { get; set; }

        public QueryParam(string name, QueryParamType type)
        {
            Name = name;
            Type = type;
        }
    }
}
