using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;
using System;
using System.Collections.Generic;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Stores actions related to blocks
    /// </summary>
    [BusinessActionContainer]
    public class BlockActions
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

            if (string.IsNullOrWhiteSpace(genre.Title))
            {
                ViewManager.ShowFlash("Cannot insert genre, you must enter a title", FlashMessageType.Bad);
            }
            else
            {
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

        /// <summary>
        /// Handles inserting a new block into the database, assumes that there is valid block information in the context
        /// </summary>
        [BusinessAction("insert_block")]
        [AuthAttrib("General Manager", "Planner")]
        public void Insert()
        {
            IoMap map = ViewManager.CurrentMap;

            string msg = "";
            if (!Validate(ref msg))
            {
                ViewManager.ShowFlash(string.Format("Error Adding Block:\n{0}", msg), FlashMessageType.Bad);
                ViewManager.Show("Blocks", map);
            }
            else
            {
                Block block = new Block();
                block.Title = map.GetInput<string>("Block.Title");
                block.SeriesId = map.GetInput<BlockSeries>("Block.Series");
                block.ShipByDate = map.GetInput<DateTime>("Block.ShipByDate");
                block.Description = map.GetInput<string>("Block.Description");

                if (DataAccess.Insert(block))
                {
                    map.Reset();
                    block = DataAccess.Match(block)[0];
                    ViewManager.ShowFlash(string.Format("Block added with ID: {0}", block.BlockId), FlashMessageType.Good);
                    Logger.Log(LogLevel.Info, "Added block with ID {0}", block.BlockId);
                    ViewManager.Show("Blocks", map);
                }
                else
                {
                    ViewManager.ShowFlash("Failed to add block: \n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                    Logger.Log(LogLevel.Error, DataAccess.Database.LastFailReason.Message);
                    ViewManager.Show("Blocks", map);
                }
            }

        }

        [BusinessAction("insert_product")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertProduct()
        {
            IoMap map = ViewManager.CurrentMap;

            if (Session.Get<List<Product>>("AddingProduct") == null)
            { 
                Session.Set("AddingProduct", new List<Product>());

                List<Product> items = Session.Get<List<Product>>("AddingProduct");
            }

            else
            {
                ViewManager.ShowFlash("Could not add product", FlashMessageType.Bad);
                ViewManager.Show("Blocks", map);
            }
            


        }

        public static bool Validate(ref string reason)
        {
            bool result = true;

            IoMap map = ViewManager.CurrentMap;

            string title = map.GetInput<string>("Block.Title");
            DateTime shipDate = map.GetInput<DateTime>("Block.ShipByDate");
            string description = map.GetInput<string>("Block.Description");
            BlockSeries series = map.GetInput<BlockSeries>("Block.Series");

            if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
            {
                result = false;
                reason += "Title must be at least 3 characters" + Environment.NewLine;
            }

            if (shipDate == default(DateTime))
            {
                result = false;
                reason += "Ship Date must be filled" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                result = false;
                reason += "Description must be filled" + Environment.NewLine;
            }

            if (series == null)
            {
                result = false;
                reason += "A series must be selected" + Environment.NewLine;
            }

            return result;
        }
    }
}
