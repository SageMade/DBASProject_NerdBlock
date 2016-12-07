﻿using NerdBlock.Engine.Frontend;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Handles actions related to products
    /// </summary>
    [BusinessActionContainer]
    public class Order
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
    }
}
