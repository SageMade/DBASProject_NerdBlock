using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
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
        [AuthAttrib("General Manager", "Planning")]
        public void ShowAdd()
        {
            ViewManager.Show("Blocks");
        }

        /// <summary>
        /// Handles moving to the blocks add view
        /// </summary>
        [BusinessAction("insert_genre")]
        [AuthAttrib("General Manager", "Planning")]
        public void InsertGenre()
        {
            Genre genre = new Genre();
            genre.Title = ViewManager.CurrentMap.GetInput<string>("Genre.Title");
            genre.Description = ViewManager.CurrentMap.GetInput<string>("Genre.Description");

            if (DataAccess.Insert(genre))
            {
                ViewManager.ShowFlash("Genre Added", FlashMessageType.Good);
                LogicManager.TryPerformAction("goto_blocks_genres");
            }
            else
            {
                ViewManager.ShowFlash("Failed to add genre", FlashMessageType.Bad);
            }        
        }

        /// <summary>
        /// Handles going to the block series page
        /// </summary>
        [BusinessAction("goto_blocks_genres")]
        [AuthAttrib("General Manager", "Planning", "Public Relations")]
        public void ShowGenres()
        {
            ViewManager.CurrentMap.SetOutput("Series", DataAccess.Execute(Resources.SelectGenreTalliesQuery));
            ViewManager.Show("BlockGenres");
        }

        /// <summary>
        /// Handles going to the block series page
        /// </summary>
        [BusinessAction("goto_block_packing")]
        [AuthAttrib("General Manager", "Floor Worker")]
        public void ShowPacking()
        {
            ViewManager.Show("FloorWorkerContentView");
        }

        /// <summary>
        /// Handles going to the block queries page
        /// </summary>
        [BusinessAction("goto_blocks_queries")]
        [AuthAttrib("General Manager", "Planning", "Public Relations")]
        public void ShowQueries()
        {
            ViewManager.Show("BlockQueries");
        }

        /// <summary>
        /// Handles going to the block series page
        /// </summary>
        [BusinessAction("goto_blocks_series")]
        [AuthAttrib("General Manager", "Planning", "Public Relations")]
        public void ShowSeries()
        {
            ViewManager.Show("BlockSeries");
        }
    }
}
