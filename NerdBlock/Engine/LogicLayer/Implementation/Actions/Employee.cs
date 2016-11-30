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
            employee.LastName = Context.GetValue<string>("LastName");
            employee.SIN = Context.GetValue<string>("SIN");
            employee.Email = Context.GetValue<string>("Email");
            employee.Phone = long.Parse(Context.GetValue<string>("Phone").Replace(" ", "").Replace("-",""));
            employee.DateJoined = DateTime.Now;

            Address address = new Address();
            address.StreetAddress = Context.GetValue<string>("Address.StreetAddress");
            address.Country = Context.GetValue<string>("Address.Country");
            address.State = Context.GetValue<string>("Address.State");
            address.PostalCode= Context.GetValue<string>("Address.PostalCode");
            address.City = Context.GetValue<string>("Address.City");

            int aptNum = -1;
            if (int.TryParse(Context.GetValue<string>("Address.AptNum"), out aptNum))
                address.ApartmentNumber = aptNum;
            else
                address.ApartmentNumber = null;

            employee.HomeAddress = address;

            DataAccess.Insert(employee);

            ViewManager.ShowFlash("Employee added", FlashMessageType.Good);
            
            ViewManager.Show("AddEmployee");
        }

        [BusinessAction("goto_employee_add")]
        public void ShowAdd()
        {
            ViewManager.Show("AddEmployee");
        }

        [BusinessAction("goto_employee_search")]
        public void ShowSearch()
        {
            ViewManager.Show("EmployeeSearch");
        }
    }
}
