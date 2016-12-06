using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using System;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Stores actions related to employees
    /// </summary>
    [BusinessActionContainer]
    public class EmployeeActions
    {
        /// <summary>
        /// Handles inserting a new employee into the database, assumes that there is valid employee information in the context
        /// </summary>
        [BusinessAction("insert_employee")]
        [AuthAttrib("Human Resources")]
        public void Insert()
        {
            Employee employee = new Employee();
            employee.FirstName = Context.GetValue<string>("FirstName");
            employee.LastName = Context.GetValue<string>("LastName");
            employee.SIN = Context.GetValue<string>("SIN");
            employee.Email = Context.GetValue<string>("Email");
            employee.Phone = long.Parse(Context.GetValue<string>("Phone").Replace(" ", "").Replace("-",""));
            employee.DateJoined = DateTime.Now;
            employee.FooBar = Context.GetValue<string>("FooBar");

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


            employee.Role = Context.GetValue<EmployeeRole>("Role");

            if (DataAccess.Insert(employee))
            {
                ViewManager.ShowFlash("Employee added", FlashMessageType.Good);

                ViewManager.Show("AddEmployee");
            }
            else
            {
                ViewManager.ShowFlash("Failed to add employee:\n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
            }
        }

        /// <summary>
        /// Handles showing the employee add view
        /// </summary>
        [BusinessAction("goto_employee_add")]
        [AuthAttrib("Human Resources")]
        public void ShowAdd()
        {
            ViewManager.Show("AddEmployee");
        }

        /// <summary>
        /// Handles showing the employee search view
        /// </summary>
        [BusinessAction("goto_employee_search")]
        [AuthAttrib("Human Resources", "General Manager")]
        public void ShowSearch()
        {
            Context.Values["AllEmployees"] = DataAccess.SelectAll<Employee>();
            ViewManager.Show("EmployeeSearch");
        }

        /// <summary>
        /// Handles showing the employee update view
        /// </summary>
        [BusinessAction("goto_employee_update")]
        [AuthAttrib("Human Resources")]
        public void ShowUpdate()
        {
            ViewManager.Show("ViewEditEmployee");
        }
    }
}
