using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Handles actions related to products
    /// </summary>
    [BusinessActionContainer]
    public class OrderActions
    {
        /// <summary>
        /// Show the order add view
        /// </summary>
        [BusinessAction("goto_order_add")]
        [AuthAttrib("Shipper", "General Manager")]
        public void ShowSearch()
        {
            ViewManager.Show("AddOrder");
        }

        /// <summary>
        /// Show the order search page
        /// </summary>
        [BusinessAction("goto_order_search")]
        [AuthAttrib("Shipper", "General Manager", "Floor Worker", "Public Relations")]
        public void ShowUpdate()
        {
            ViewManager.Show("OrderPage");
        }

        /// <summary>
        /// Show the order search page
        /// </summary>
        [BusinessAction("order_insert")]
        [AuthAttrib("Shipper", "General Manager")]
        public void InsertOrder()
        {
            IoMap map = ViewManager.CurrentMap;
            List<OrderLineitem> items = Session.Get<List<OrderLineitem>>("WorkingOrderItems");

            Supplier supplier = map.GetInput<Supplier>("Order.Supplier");
            
            string error = "";

            if (supplier == null)
                error += "You must select a supplier\n";
            if (items == null || items.Count == 0)
                error += "You must enter at least one item";

            if (error == "")
            {
                Order order = new Order();
                order.SupplierId = supplier;
                order.OrderedBy = Auth.User as Employee;
                order.DateOrdered = DateTime.Now;

                if (DataAccess.Insert(order))
                {
                    order = DataAccess.Match(order)[0];

                    bool failed = false;

                    for (int index = 0; index < items.Count; index++)
                    {
                        items[index].OrderId = order;

                        DataAccess.Insert(items[index].ProductId);
                        items[index].ProductId = DataAccess.Match(items[index].ProductId).FirstOrDefault();

                        if (!DataAccess.Insert(items[index]))
                            failed = true;
                    }

                    if (!failed)
                    {
                        Session.Set("WorkingOrderItems", new List<OrderLineitem>());
                        ViewManager.CurrentMap.Reset();
                        ViewManager.ShowFlash("Added order", FlashMessageType.Good);
                        ViewManager.Show("AddOrder");
                    }
                    else
                    {
                        ViewManager.ShowFlash("Failed to add order:\n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                        ViewManager.Show("AddOrder");
                    }
                }
                else
                {
                    ViewManager.ShowFlash("Failed to add order:\n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                    ViewManager.Show("AddOrder");
                }
            }
            else
            {
                ViewManager.ShowFlash("Failed to add order:\n" + error, FlashMessageType.Bad);
                ViewManager.Show("AddOrder");
            }
        }

        /// <summary>
        /// Handles inserting an item on the current working order
        /// </summary>
        [BusinessAction("order_insert_item")]
        [AuthAttrib("Shipper", "General Manager")]
        public void InsertOrderItem()
        {
            IoMap map = ViewManager.CurrentMap;
            
            string productName = map.GetInput<string>("Product.Name");
            string productDescription = map.GetInput<string>("Product.Description");
            string widthText = map.GetInput<string>("Product.Width");
            string depthText = map.GetInput<string>("Product.Depth");
            string heightText = map.GetInput<string>("Product.Height");
            string quantityText = map.GetInput<string>("Product.QuantityOrdered");
            string costText = map.GetInput<string>("Product.BatchCost");

            string error = "";

            if (string.IsNullOrWhiteSpace(productName))
                error += "You must enter a product name\n";
            if (string.IsNullOrWhiteSpace(productDescription))
                error += "You must enter a product description\n";

            if (string.IsNullOrWhiteSpace(widthText))
                error += "You must enter a product width\n";
            if (string.IsNullOrWhiteSpace(heightText))
                error += "You must enter a product height\n";
            if (string.IsNullOrWhiteSpace(depthText))
                error += "You must enter a product depth\n";

            decimal width, height, depth, cost;
            width = height = depth = cost = 0;

            int quantity = 0;

            if (error == "")
            {
                if (!decimal.TryParse(widthText, out width))
                    error += "Product width must be numeric\n";
                if (!decimal.TryParse(heightText, out depth))
                    error += "Product height must be numeric\n";
                if (!decimal.TryParse(depthText, out height))
                    error += "Product depth must be numeric\n";

                if (!decimal.TryParse(costText, out cost))
                    error += "Product cost must be numeric\n";

                if (!int.TryParse(quantityText, out quantity))
                    error += "Quantity must be an integer\n";
            }

            if (error == "")
            {
                if (Session.Get<List<OrderLineitem>>("WorkingOrderItems") == null)
                    Session.Set("WorkingOrderItems", new List<OrderLineitem>());

                List<OrderLineitem> items = Session.Get<List<OrderLineitem>>("WorkingOrderItems");

                Product product = new Product();
                product.Name = productName;
                product.Description = productDescription;
                product.Width = width;
                product.Height = height;
                product.Depth = depth;
                product.NumDamaged = 0;

                OrderLineitem item = new OrderLineitem();
                item.Quantity = quantity;
                item.BatchCost = cost;
                item.ProductId = product;

                items.Add(item);

                map.SetInput("Product.Name", "");
                map.SetInput("Product.Description", "");
                map.SetInput("Product.Width", "");
                map.SetInput("Product.Depth", "");
                map.SetInput("Product.Height", "");
                map.SetInput("Product.QuantityOrdered", "");
                map.SetInput("Product.BatchCost", "");
                
                ViewManager.Show("AddOrder", map);
            }
            else
            {
                ViewManager.ShowFlash("Could not add product: \n" + error, FlashMessageType.Bad);
                ViewManager.Show("AddOrder", map);
            }

        }
                
        /// <summary>
        /// Show the order edit page
        /// </summary>
        [BusinessAction("goto_order_edit")]
        [AuthAttrib("Shipper", "General Manager")]
        public void ShowEdit()
        {
            ViewManager.Show("ViewEditOrder");
        }

    }
}
