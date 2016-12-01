using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

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
            Inputs.Add(new CheckBoxInput("Genre.IsActive", chbInitialActive));

            //Outputs - 1
            Outputs.Add(new ListViewOutput("Series", lstSeries));
            //Need to add output for lstSeries.

            //Controls - 2 DONE
            btnAdd.Click += (X, Y) => AttemptAction("insert_genre");
            btnViewSeries.Click += (X, Y) =>
            {
                Context.SetValue("TargetGenre", lstSeries.SelectedItem);
                AttemptAction("goto_blockseries");
            };

        }
    }
}
