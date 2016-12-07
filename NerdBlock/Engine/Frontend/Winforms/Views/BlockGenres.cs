﻿using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using NerdBlock.Properties;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockGenres : ViewBase
    {
        public BlockGenres()
        {
            InitializeComponent();

            //Inputs - 3 DONE
            Inputs.Add(new TextBoxInput("Genre.Title", txtTitle));
            Inputs.Add(new TextBoxInput("Genre.Description", txtDescription));

            //Outputs - 1
            Outputs.Add(new DataGridOutput("Series", dgvGenres));

            //Controls - 2 DONE
            btnAdd.Click += (X, Y) => AttemptAction("insert_genre");
            btnViewSeries.Click += (X, Y) =>
            {
                ViewManager.CurrentMap.SetInput("TargetGenre", dgvGenres.SelectedRows[0]);
                AttemptAction("goto_blockseries");
            };
        }
    }
}
