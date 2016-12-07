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
        /// Show the inventory overstock view
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
            string contactPhone = map.GetInput<string>("Contact.Phone");
            string contactEmail = map.GetInput<string>("Contact.Email");

            decimal width, height, depth;
            width = height = depth = 0;

            /*
            string error = "";

            if (productName == null || string.IsNullOrWhiteSpace(productName))
                error += "You must enter a product name\n";

            if (productWidth == null || string.IsNullOrWhiteSpace(productWidth))
                error += "You must enter a product width\n";
            if (productHeight == null || string.IsNullOrWhiteSpace(productHeight))
                error += "You must enter a product height\n";
            if (productDepth == null || string.IsNullOrWhiteSpace(productDepth))
                error += "You must enter a product depth\n";

            if (productDescription == null || string.IsNullOrWhiteSpace(productDescription))
                error += "You must enter a product description\n";

            if (error == "")
            {
                if (!decimal.TryParse(productWidth, out width))
                    error += "Width must be numeric\n";
                if (!decimal.TryParse(productWidth, out height))
                    error += "Width must be numeric\n";
                if (!decimal.TryParse(productWidth, out depth))
                    error += "Width must be numeric\n";
            }

            if (error == "")
            {
                Model.Product item = new Model.Product()
                {
                    Name = productName,
                    Description = productDescription,
                    Width = width,
                    Height = height,
                    Depth = depth
                };

                if (DataAccess.Insert(item))
                {
                    ViewManager.ShowFlash("Product has been added", FlashMessageType.Good);
                }
                else
                {
                    ViewManager.ShowFlash("Failed to add product: " + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                }
            }
            else
            {
                ViewManager.ShowFlash(error, FlashMessageType.Bad);
                return;
            }
            */
        }
    }
}
