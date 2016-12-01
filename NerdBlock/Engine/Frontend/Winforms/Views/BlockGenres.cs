using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Implementation;
using NerdBlock.Engine.LogicLayer;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockGenres : ViewBase
    {
        public BlockGenres()
        {
            InitializeComponent();

            //Inputs
            Inputs.Add(new TextBoxInput("Genre.Title", txtTitle));
            Inputs.Add(new TextBoxInput("Genre.Description", txtDescription));
            Inputs.Add(new CheckBoxInput("Genre.IsActive", chbInitialActive));

            //Outputs
            //Need to add output for lstSeries.

            //Controls
            btnAdd.Click += (X, Y) => AttemptAction("insert_genre");
            btnViewSeries.Click += (X, Y) =>
            {
                Context.SetValue("TargetGenre", lstSeries.SelectedItem);
                AttemptAction("goto_blockseries");
            };

        }
    }
}
