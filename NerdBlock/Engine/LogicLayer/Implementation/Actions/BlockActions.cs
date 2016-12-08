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
            ViewManager.Show("AddBlocks");
        }

        /// <summary>
        /// Handles showing the block edit view
        /// </summary>
        [BusinessAction("goto_edit_block")]
        [AuthAttrib("General Manager", "Planning")]
        public void ShowEdit()
        {
            ViewManager.Show("ViewEditBlock");
        }

        /// <summary>
        /// Handles showing the block series add view
        /// </summary>
        [BusinessAction("goto_add_series")]
        [AuthAttrib("General Manager", "Planning")]
        public void ShowAddSeries()
        {
            ViewManager.Show("AddSeries");
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
                ViewManager.Show("AddBlocks", map);
            }
            else
            {

                if (Session.Get<List<Product>>("AddingProducts") == null)
                {
                    ViewManager.ShowFlash("Please select at least one product to order", FlashMessageType.Neutral);
                    return;
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


                        List<Product> products = Session.Get<List<Product>>("AddingProducts");

                        for (int index = 0; index < products.Count; index++)
                        {
                            BlockItem item = new BlockItem();
                            item.BlockId = block;
                            item.ProducId = products[index];
                            item.Quantity = 1;

                            DataAccess.Insert(item);
                        }
                        Session.Set<List<Product>>("AddingProducts", null);
                        ViewManager.ShowFlash(string.Format("Block added with ID: {0}", block.BlockId), FlashMessageType.Good);
                        Logger.Log(LogLevel.Info, "Added block with ID {0}", block.BlockId);
                        ViewManager.Show("AddBlocks", map);
                    }
                    else
                    {
                        ViewManager.ShowFlash("Failed to add block: \n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                        Logger.Log(LogLevel.Error, DataAccess.Database.LastFailReason.Message);
                        ViewManager.Show("AddBlocks", map);
                    }
                }
            }
        }

        /// <summary>
        /// Handles inserting a new block series into the database
        /// </summary>
        [BusinessAction("insert_series")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertSeries()
        {
            IoMap map = ViewManager.CurrentMap;

            string name = map.GetInput<string>("Name");
            string priceText = map.GetInput<string>("Price");
            string volumeText = map.GetInput<string>("Volume");
            Genre genre = map.GetInput<Genre>("Block.Genre");

            string error = "";

            if (string.IsNullOrWhiteSpace(name))
                error += "You must enter a series name\n";
            if (string.IsNullOrWhiteSpace(priceText))
                error += "You must enter a price\n";
            if (string.IsNullOrWhiteSpace(volumeText))
                error += "You must enter a block volume\n";
            if (genre == null)
                error += "You must select a genre\n";

            decimal price = -1;
            int volume = -1;

            if (error == "")
            {
                if (!decimal.TryParse(priceText, out price) || price <= 0)
                    error += "Price must be numeric and greater than 0\n";
                if (!int.TryParse(volumeText, out volume) || volume <= 0)
                    error += "Volume must be an integer greater than 0\n";
            }
            
            if (error == "")
            {
                BlockSeries series = new BlockSeries();
                series.StartDate = DateTime.Now;
                series.GenreId = genre;
                series.BlockVolume = volume;
                series.SubscriptionPrice = price;
                series.Title = name;


                if (DataAccess.Insert(series))
                {
                    map.Reset();
                    map.SetInput("Block.Genre", genre);
                    ViewManager.Show("BlockSeries");
                    ViewManager.ShowFlash("Successfully added the series", FlashMessageType.Good);
                }
                else
                {
                    ViewManager.ShowFlash("Cannot add series:\n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                }
            }
            else
                ViewManager.ShowFlash("Cannot add series:\n" + error, FlashMessageType.Bad);
        }

        /// <summary>
        /// Handles updating a single block
        /// </summary>
        [BusinessAction("update_block")]
        [AuthAttrib("General Manager", "Planner")]
        public void Update()
        {
            IoMap map = ViewManager.CurrentMap;

            string msg = "";
            if (!Validate(ref msg))
            {
                ViewManager.ShowFlash(string.Format("Error Adding Block:\n{0}", msg), FlashMessageType.Bad);
                ViewManager.Show("ViewEditBlock", map);
            }
            else
            {

                if (Session.Get<List<Product>>("AddingProducts") == null)
                {
                    ViewManager.ShowFlash("Please select at least one product to order", FlashMessageType.Neutral);
                    return;
                }
                else
                {
                    Block block = map.GetInput<Block>("Block");

                    if (block != null)
                    {
                        block.Title = map.GetInput<string>("Block.Title");
                        block.SeriesId = map.GetInput<BlockSeries>("Block.Series");
                        block.ShipByDate = map.GetInput<DateTime>("Block.ShipByDate");
                        block.Description = map.GetInput<string>("Block.Description");

                        if (DataAccess.Update(block) > 0)
                        {
                            map.Reset();
                            block = DataAccess.Match(block)[0];
                            
                            List<Product> products = Session.Get<List<Product>>("AddingProducts");

                            for (int index = 0; index < products.Count; index++)
                            {
                                BlockItem item = new BlockItem();
                                item.BlockId = block;
                                item.ProducId = products[index];

                                if (DataAccess.Match(item).Length > 0)
                                {
                                    item.Quantity = 1;

                                    DataAccess.Update(item);
                                }
                                else
                                {
                                    item.Quantity = 1;
                                    DataAccess.Insert(item);
                                }
                            }

                            Session.Set<List<Product>>("AddingProducts", null);
                            ViewManager.ShowFlash(string.Format("Block updated with ID: {0}", block.BlockId), FlashMessageType.Good);
                            Logger.Log(LogLevel.Info, "Updated block with ID {0}", block.BlockId);
                            map.Reset();
                            ViewManager.Show("BlockQueries", map);
                        }
                        else
                        {
                            ViewManager.ShowFlash("Failed to add block: \n" + DataAccess.Database.LastFailReason.Message, FlashMessageType.Bad);
                            Logger.Log(LogLevel.Error, DataAccess.Database.LastFailReason.Message);
                            ViewManager.Show("ViewEditBlock", map);
                        }
                    }
                    else
                    {
                        ViewManager.ShowFlash("Failed to add block: \nNo block selected", FlashMessageType.Bad);
                        ViewManager.Show("ViewEditBlock", map);
                    }
                }
            }
        }


        [BusinessAction("insert_block_item")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertProduct()
        {
            IoMap map = ViewManager.CurrentMap;

            if (Session.Get<List<Product>>("AddingProducts") == null)
            { 
                Session.Set("AddingProducts", new List<Product>());
            }

            List<Product> items = Session.Get<List<Product>>("AddingProducts");

            if (map.HasInput<Product>("ProductToAdd"))
            {
                items.Add(map.GetInput<Product>("ProductToAdd"));
                map.SetInput<Product>("ProductToAdd", null);

                ViewManager.Show("AddBlocks", map);
            }
            else
                ViewManager.ShowFlash("Please select a product to add", FlashMessageType.Neutral);
        }

        [BusinessAction("insert_block_item_edit")]
        [AuthAttrib("General Manager", "Planner")]
        public void InsertProductEdit()
        {
            IoMap map = ViewManager.CurrentMap;

            if (Session.Get<List<Product>>("AddingProducts") == null)
            {
                Session.Set("AddingProducts", new List<Product>());
            }

            List<Product> items = Session.Get<List<Product>>("AddingProducts");

            if (map.HasInput<Product>("ProductToAdd"))
            {
                items.Add(map.GetInput<Product>("ProductToAdd"));
                map.SetInput<Product>("ProductToAdd", null);

                ViewManager.Show("ViewEditBlock", map);
            }
            else
                ViewManager.ShowFlash("Please select a product to add", FlashMessageType.Neutral);
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
