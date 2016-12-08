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
    public class SupplierActions
    {
        /// <summary>
        /// Show the add supplier view
        /// </summary>
        [BusinessAction("goto_add_supplier")]
        [AuthAttrib("General Manager", "Planner")]
        public void ShowAddSupplier()
        {
            ViewManager.Show("AddSupplier");
        }

        /// <summary>
        /// Handles inserting a supplier
        /// </summary>
        [BusinessAction("insert_supplier")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertProduct()
        {
            IoMap map = ViewManager.CurrentMap;

            string companyName = map.GetInput<string>("Company.Name");
            string companyPhone = map.GetInput<string>("Company.Phone");

            string contactFirstName = map.GetInput<string>("Contact.FirstName");
            string contactLastName = map.GetInput<string>("Contact.LastName");
            string contactEmail = map.GetInput<string>("Contact.Email");
                        
            string error = "";

            if (companyName == null || string.IsNullOrWhiteSpace(companyName))
                error += "You must enter a company name\n";
            if (companyPhone == null || string.IsNullOrWhiteSpace(companyPhone))
                error += "You must enter a company phone number\n";

            if (string.IsNullOrWhiteSpace(contactFirstName))
                error += "You must enter a contact first name\n";
            if (string.IsNullOrWhiteSpace(contactLastName))
                error += "You must enter a contact last name\n";
            if (string.IsNullOrWhiteSpace(contactEmail))
                error += "You must enter a contact email address\n";

            Validations.ValidateAddressFromMap(map, "Address", ref error);
            companyPhone = Validations.ValidatePhone(companyPhone, ref error);

            if (error == "")
            {
                Supplier supplier = new Supplier();
                supplier.Company = companyName;
                supplier.Phone = long.Parse(companyPhone);
                supplier.ContactFirstName = contactFirstName;
                supplier.ContactLastName = contactLastName;
                supplier.ContactEmail = contactEmail;

                Address address = new Address();
                address.StreetAddress = map.GetInput<string>("Address.Street");
                address.Country = map.GetInput<string>("Address.Country");
                address.State = map.GetInput<string>("Address.State");
                address.PostalCode = map.GetInput<string>("Address.PostalCode");
                address.City = map.GetInput<string>("Address.City");

                int aptNum = -1;
                if (int.TryParse(map.GetInput<string>("Address.AptNum"), out aptNum))
                    address.ApartmentNumber = aptNum;
                else
                    address.ApartmentNumber = null;

                supplier.Address = address;

                if (DataAccess.Insert(supplier))
                {
                    map.Reset();
                    ViewManager.ShowFlash("Supplier has been added.", FlashMessageType.Good);
                    ViewManager.Show("AddSupplier");
                }
                else
                {
                    ViewManager.ShowFlash("Failed to add supplier: \n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                    return;
                }
            }
            else
            {
                ViewManager.ShowFlash("Failed to add supplier: \n" + error, FlashMessageType.Bad);
                return;
            }
        }
    }
}
