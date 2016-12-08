using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using NerdBlock.Engine.Backend;
using NerdBlock.Properties;
using System.Linq;

using Model = NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockSeries : ViewBase
    {
        public BlockSeries()
        {
            InitializeComponent();
            //Input - DONE
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));

            //Output - 2
            Outputs.Add(new ModelPopulatedComboBox<Genre>("Block.Genre", cbGenre));
            Outputs.Add(new DataGridOutput("Data", dgvData));

            cbGenre.SelectedIndexChanged += CbGenre_SelectedIndexChanged;

            //Controls - 1 DONE
            btnBlocks.Click += (X, Y) =>
            {
                if (dgvData.SelectedRows.Count > 0)
                {
                    ViewManager.CurrentMap.SetInput("Block.Series", DataAccess.FromPrimaryKey<Model.BlockSeries>(dgvData.SelectedRows[0].Cells["clmSeriesId"].Value));
                    AttemptAction("goto_blocks_queries");
                }
            };
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            Outputs.First(X => X.Name == "Block.Genre").Fill(map);
            cbGenre.SelectedIndex = cbGenre.Items.Count > 0 ? 0 : -1;

            Genre genre = cbGenre.Items.Count == 0 ? DataAccess.SelectAll<Genre>().FirstOrDefault() : cbGenre.SelectedItem as Genre;

            if (genre != null)
                map.SetOutput("Data", DataAccess.Execute(Resources.SelectSeriesInfoQuery, new [] { new QueryParam("genreId", QueryParamType.Integer) }, new object[] { genre.GenreId }));
        }

        private void CbGenre_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Genre genre = cbGenre.Items.Count == 0 ? DataAccess.SelectAll<Genre>().FirstOrDefault() : cbGenre.SelectedItem as Genre;

            if (genre != null)
            {
                // Get the input as a queryresult
                IQueryResult result = DataAccess.Execute(Resources.SelectSeriesInfoQuery, new[] { new QueryParam("genreId", QueryParamType.Integer) }, new object[] { genre.GenreId });
                // Generate a binding source for the query
                BindingSource bs = new BindingSource();
                bs.DataSource = result.Source.Tables[0];
                // Set the control's binding to the generated binding source
                dgvData.DataSource = bs;
            }
        }
    }
}
