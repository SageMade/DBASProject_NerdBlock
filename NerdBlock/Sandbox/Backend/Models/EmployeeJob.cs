using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend.Models
{
    [DataModel("tblemployeejob")]
    public class EmployeeJob
    {
        [DataField("employeeid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblemployee", "employeeid")]
        public Employee EmployeeId { get; set; }

        [DataField("roleid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblemployeerole", "roleid")]
        public EmployeeRole RoleId { get; set; }
    }
}
