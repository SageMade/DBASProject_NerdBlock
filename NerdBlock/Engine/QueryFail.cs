using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine
{
    public class QueryFail
    {
        public QueryFailReason Reason { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
    }
}
