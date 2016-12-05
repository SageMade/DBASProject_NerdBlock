using NerdBlock.Engine.Frontend;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Stores actions related to customers
    /// </summary>
    [BusinessActionContainer]
    public class Customer
    {
        /// <summary>
        /// Show the customer search page
        /// </summary>
        [BusinessAction("goto_customer_search")]
        public void ShowSearch()
        {
            ViewManager.Show("CustomerSearchList");
        }
    }
}
