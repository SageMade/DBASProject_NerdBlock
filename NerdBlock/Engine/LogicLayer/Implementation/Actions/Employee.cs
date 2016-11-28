using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    [BusinessActionContainer]
    public class EmployeeActions
    {
        [BusinessAction("insert_employee")]
        public void Insert()
        {
            Employee employee = new Employee();
            employee.FirstName = Context.GetValue<string>("FirstName");
            employee.FirstName = Context.GetValue<string>("LastName");
            employee.SIN = Context.GetValue<string>("SIN");
            employee.Phone = long.Parse(Context.GetValue<string>("Phone").Replace(" ", "").Replace("-",""));
            employee.DateJoined = DateTime.Now;
            employee.Email = null;

            Address address = new Address();
            address.StreetAddress = Context.GetValue<string>("StreetAddress");
            address.Country = Context.GetValue<string>("Country");
            address.State = Context.GetValue<string>("State");
            address.PostalCode= Context.GetValue<string>("PostalCode");

            employee.HomeAddress = address;

            DataAccess.Insert(employee);

            ViewManager.Show("AddEmployee");
        }
    }
}
