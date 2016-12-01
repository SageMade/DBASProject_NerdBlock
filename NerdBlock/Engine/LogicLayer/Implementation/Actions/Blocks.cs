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
    public class Blocks
    {
        [BusinessAction("goto_blocks_add")]
        public void ShowAdd()
        {
            ViewManager.Show("Blocks");
        }

        [BusinessAction("goto_blocks_genres")]
        public void ShowGenres()
        {
            ViewManager.Show("BlockGenres");
        }

        [BusinessAction("goto_block_queries")]
        public void ShowQueries()
        {
            ViewManager.Show("BlockQueries");
        }

        [BusinessAction("goto_block_series")]
        public void ShowSeries()
        {
            ViewManager.Show("BlockSeries");
        }
    }
}
