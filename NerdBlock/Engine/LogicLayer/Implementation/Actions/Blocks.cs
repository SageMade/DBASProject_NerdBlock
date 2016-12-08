﻿using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;
using System;

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
        /// Add Block
        /// </summary>
        [BusinessAction("insert_block")]
        [AuthAttrib("General Manager", "Planner")]
        public void Add()
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
                block.Title = map.GetInput<string>("Title");
                block.SeriesId = map.GetInput<BlockSeries>("Series");
                block.ShipByDate = map.GetInput<DateTime>("ShipByDate");
                block.Description = map.GetInput<string>("Description");

                if (DataAccess.Insert(block))
                {
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

        public static bool Validate(ref string reason)
        {
            bool result = true;

            IoMap map = ViewManager.CurrentMap;

            string title = map.GetInput<string>("Title");
            string shipDate = map.GetInput<string>("ShipByDate");
            string description = map.GetInput<string>("Description");

            if (string.IsNullOrWhiteSpace(title) || title.Length < 3)
            {
                result = false;
                reason += "Title must be at least 3 characters" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(shipDate))
            {
                result = false;
                reason += "Ship Date must be filled" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                result = false;
                reason += "Description must be filled" + Environment.NewLine;
            }

            return result;
        }
    }
}
