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
using NerdBlock.Engine.Backend;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public partial class AddressEntry : UserControl
    {
        public string Prefix
        {
            get;
            set;
        }

        public AddressEntry()
        {
            InitializeComponent();
        }

        private string __GetName(string attribName)
        {
            if (string.IsNullOrWhiteSpace(Prefix))
                return attribName;
            else
                return Prefix.Trim() + "." + attribName;
        }

        public void Fill(IoMap map)
        {
            ViewManager.PopulateFromQuery(cbState, DataAccess.Execute("select state from tbladdress group by state order by state"));
            ViewManager.PopulateFromQuery(cbCountry, DataAccess.Execute("select country from tbladdress group by country order by country"));
            ViewManager.PopulateFromQuery(cbCity, DataAccess.Execute("select city from tbladdress group by city order by city"));

            txtStreet.Text = map.GetInput<string>(__GetName("Street"));
            txtPostalCode.Text = map.GetInput<string>(__GetName("PostalCode"));
            txtAptNum.Text = map.GetInput<string>(__GetName("AptNum"));            
            cbCity.Text = map.GetInput<string>(__GetName("City"));
            cbCountry.Text = map.GetInput<string>(__GetName("Country"));
            cbState.Text = map.GetInput<string>(__GetName("State"));
        }

        public void Populate(IoMap map)
        {
            map.SetInput(__GetName("Street"), txtStreet.Text);
            map.SetInput(__GetName("PostalCode"), txtPostalCode.Text);
            map.SetInput(__GetName("AptNum"), txtAptNum.Text);
            map.SetInput(__GetName("City"), cbCity.Text);
            map.SetInput(__GetName("Country"), cbCountry.Text);
            map.SetInput(__GetName("State"), cbState.Text);
        }
    }
}
