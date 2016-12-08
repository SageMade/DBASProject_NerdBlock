using System;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;
using System.Linq;
using NerdBlock.Engine.Backend;
using NerdBlock.Properties;

using Model = NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockQueries : ViewBase
    {
        public BlockQueries()
        {
            InitializeComponent();

            //Input - 3 DONE
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));
            Inputs.Add(new ComboBoxValueInput("Block.Series", cbSeries));

            //Output - 3
            Outputs.Add(new ModelPopulatedComboBox<Genre>("Block.Genre", cbGenre));
            Outputs.Add(new ModelPopulatedComboBox<Model.BlockSeries>("Block.Series", cbSeries));
            Outputs.Add(new DataGridOutput("Data", dgvData));

            //Controls - 2 DONE
            btnAdd.Click += (X, Y) =>
            {
                AttemptAction("goto_blocks_add");
            };

            btnEdit.Click += (X, Y) =>
            {
                if (dgvData.SelectedRows.Count > 0)
                {
                    ViewManager.CurrentMap.SetInput("Block.Input", DataAccess.FromPrimaryKey<Block>(dgvData.SelectedRows[0].Cells["BlockId"].Value));
                    AttemptAction("goto_edit_block");
                }
            };

            cbSeries.SelectedIndexChanged += SeriesFieldChanged;
            cbGenre.SelectedIndexChanged += GenreFieldChanged;
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            Outputs.First(X => X.Name == "Block.Genre").Fill(map);
            Outputs.First(X => X.Name == "Block.Series").Fill(map);

            cbGenre.SelectedIndex = cbGenre.Items.Count > 0 ? 0 : -1;
            cbSeries.SelectedIndex = cbSeries.Items.Count > 0 ? 0 : -1;

            Genre genre = cbGenre.Items.Count == 0 ? DataAccess.SelectAll<Genre>().FirstOrDefault() : cbGenre.SelectedItem as Genre;
            Model.BlockSeries series = cbSeries.Items.Count == 0 ? DataAccess.SelectAll<Model.BlockSeries>().FirstOrDefault() : cbSeries.SelectedItem as Model.BlockSeries;

            if (genre != null && series != null)
                map.SetOutput("Data", DataAccess.Execute(
                    Resources.SelectBlockInfoQuery, 
                    new[] { new QueryParam("seriesId", QueryParamType.Integer)}, 
                    new object[] { series.SeriesId }));
        }

        private void GenreFieldChanged(object sender, EventArgs e)
        {
            Genre genre = cbGenre.Items.Count == 0 ? DataAccess.SelectAll<Genre>().FirstOrDefault() : cbGenre.SelectedItem as Genre;

            if (genre != null)
            {
                cbSeries.Items.Clear();
                Model.BlockSeries match = new Model.BlockSeries() { GenreId = genre };
                cbSeries.Items.AddRange(DataAccess.Match(match));
                cbSeries.SelectedIndex = cbSeries.Items.Count > 0 ? 0 : -1;
                __HandleSearchChanged();
            }
        }

        private void __HandleSearchChanged()
        {
            Genre genre = cbGenre.Items.Count == 0 ? DataAccess.SelectAll<Genre>().FirstOrDefault() : cbGenre.SelectedItem as Genre;

            if (genre != null)
            {
                Model.BlockSeries series = cbSeries.Items.Count == 0 ? DataAccess.SelectAll<Model.BlockSeries>().FirstOrDefault() : cbSeries.SelectedItem as Model.BlockSeries;

                if (series != null)
                {
                    // Get the input as a queryresult
                    IQueryResult result = DataAccess.Execute(
                        Resources.SelectBlockInfoQuery,
                        new[] { new QueryParam("seriesId", QueryParamType.Integer) },
                        new object[] { series.SeriesId });
                    // Generate a binding source for the query
                    BindingSource bs = new BindingSource();
                    bs.DataSource = result.Source.Tables[0];
                    // Set the control's binding to the generated binding source
                    dgvData.DataSource = bs;
                }
            }
        }
        
        private void SeriesFieldChanged(object sender, EventArgs e)
        {

            Model.BlockSeries series = cbSeries.Items.Count == 0 ? DataAccess.SelectAll<Model.BlockSeries>().FirstOrDefault() : cbSeries.SelectedItem as Model.BlockSeries;

            if (series != null)
                cbGenre.SelectedItem = series.GenreId;

            __HandleSearchChanged();
        }
    }
}
