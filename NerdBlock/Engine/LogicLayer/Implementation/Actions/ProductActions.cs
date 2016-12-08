using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Frontend;
using Model = NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Handles actions related to products
    /// </summary>
    [BusinessActionContainer]
    public class ProductActions
    {
        /// <summary>
        /// Show the inventory search view
        /// </summary>
        [BusinessAction("goto_inventory_search")]
        [AuthAttrib("General Manager", "Shipper", "Floor Worker", "Public Relations")]
        public void ShowSearch()
        {
            ViewManager.Show("Inventory");
        }

        /// <summary>
        /// Show the inventory update view
        /// </summary>
        [BusinessAction("goto_inventory_update")]
        [AuthAttrib("General Manager", "Shipper", "Floor Worker")]
        public void ShowUpdate()
        {
            ViewManager.Show("ProductInfo");
        }

        /// <summary>
        /// Show the inventory update view
        /// </summary>
        [BusinessAction("goto_inventory_add")]
        [AuthAttrib("General Manager", "Shipper")]
        public void ShowAdd()
        {
            ViewManager.Show("AddProduct");
        }

        /// <summary>
        /// Show the inventory lost and damaged view
        /// </summary>
        [BusinessAction("goto_inventory_lost_damaged")]
        [AuthAttrib("General Manager", "Shipper")]
        public void ShowLostDamaged()
        {
            ViewManager.Show("LostDamagedItems");
        }

        /// <summary>
        /// Show the inventory overstock view
        /// </summary>
        [BusinessAction("goto_inventory_overstock")]
        [AuthAttrib("General Manager", "Shipper")]
        public void ShowOverstock()
        {
            ViewManager.Show("ExtraProductShipped");
        }


        /// <summary>
        /// Show the inventory overstock view
        /// </summary>
        [BusinessAction("insert_product")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertProduct()
        {
            IoMap map = ViewManager.CurrentMap;

            string productName = map.GetInput<string>("ProductName");
            string productWidth = map.GetInput<string>("Width");
            string productHeight = map.GetInput<string>("Height");
            string productDepth = map.GetInput<string>("Depth");
            string productDescription = map.GetInput<string>("Description");

            decimal width, height, depth;
            width = height = depth = 0;

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
        }
    }
}
