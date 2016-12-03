using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Stores actions related to blocks
    /// </summary>
    [BusinessActionContainer]
    public class Blocks
    {
        /// <summary>
        /// Handles moving to the blocks add view
        /// </summary>
        [BusinessAction("goto_blocks_add")]
        public void ShowAdd()
        {
            ViewManager.Show("Blocks");
        }

        /// <summary>
        /// Handles going to the block series page
        /// </summary>
        [BusinessAction("goto_blocks_genres")]
        public void ShowGenres()
        {
            Context.Values["Series"] = DataAccess.Execute(Resources.SelectGenreTalliesQuery);
            ViewManager.Show("BlockGenres");
        }

        /// <summary>
        /// Handles going to the block queries page
        /// </summary>
        [BusinessAction("goto_block_queries")]
        public void ShowQueries()
        {
            ViewManager.Show("BlockQueries");
        }

        /// <summary>
        /// Handles going to the block series page
        /// </summary>
        [BusinessAction("goto_block_series")]
        public void ShowSeries()
        {
            ViewManager.Show("BlockSeries");
        }
    }
}
