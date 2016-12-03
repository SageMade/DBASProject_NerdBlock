using NerdBlock.Engine.Frontend;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Handles actions related to products
    /// </summary>
    [BusinessActionContainer]
    public class Product
    {
        /// <summary>
        /// Show the inventory search view
        /// </summary>
        [BusinessAction("goto_inventory_search")]
        public void ShowSearch()
        {
            ViewManager.Show("Inventory");
        }

        /// <summary>
        /// Show the inventory update view
        /// </summary>
        [BusinessAction("goto_inventory_update")]
        public void ShowUpdate()
        {
            ViewManager.Show("ProductInfo");
        }

        /// <summary>
        /// Show the inventory lost and damaged view
        /// </summary>
        [BusinessAction("goto_inventory_lost_damaged")]
        public void ShowLostDamaged()
        {
            ViewManager.Show("LostDamagedItems");
        }

        /// <summary>
        /// Show the inventory overstock view
        /// </summary>
        [BusinessAction("goto_inventory_overstock")]
        public void ShowOverstock()
        {
            ViewManager.Show("ExtraProductShipped");
        }
    }
}
