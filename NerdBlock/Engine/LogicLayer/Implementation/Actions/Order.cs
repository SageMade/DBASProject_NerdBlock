using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using System.Collections.Generic;

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
            List<OrderLineitem> items = Session.Get<List<OrderLineitem>>("WorkingOrderItems");

            ViewManager.Show("OrderPage");
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
