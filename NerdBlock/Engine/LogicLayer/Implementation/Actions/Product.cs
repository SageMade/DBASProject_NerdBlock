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
    public class Product
    {
        [BusinessAction("goto_inventory_search")]
        public void ShowSearch()
        {
            ViewManager.Show("Inventory");
        }

        [BusinessAction("goto_inventory_update")]
        public void ShowUpdate()
        {
            ViewManager.Show("ProductInfo");
        }

        [BusinessAction("goto_inventory_lost_damaged")]
        public void ShowLostDamaged()
        {
            ViewManager.Show("LostDamagedItems");
        }
    }
}
