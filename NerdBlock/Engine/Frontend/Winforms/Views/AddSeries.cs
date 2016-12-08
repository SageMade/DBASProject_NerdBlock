using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class AddSeries : ViewBase
    {
        public AddSeries()
        {
            InitializeComponent();
            
            Inputs.Add(new TextBoxInput("Name", txtSeriesName));
            Inputs.Add(new TextBoxInput("Price", txtPrice));
            Inputs.Add(new TextBoxInput("Volume", txtVolume));
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));

            Outputs.Add(new ModelPopulatedComboBox<Genre>("Block.Genre", cbGenre));

            btnAdd.Click += (X, Y) => AttemptAction("insert_series");
        }
    }
}
