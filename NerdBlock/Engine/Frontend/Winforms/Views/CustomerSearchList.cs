using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using NerdBlock.Engine.Backend;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class CustomerSearchList : ViewBase
    {
        private CustomerFilter myFilter;

        public CustomerSearchList()
        {
            InitializeComponent();

            myFilter = new CustomerFilter();

            Outputs.Add(new DataGridOutput("Customers", dgvResults));
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            IQueryResult result = DataAccess.Execute("select * from tblcustomers");
            map.SetOutput("Customers", result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myFilter.FirstNameFilter = textBox1.Text;

            (dgvResults.DataSource as BindingSource).Filter = myFilter.Filter;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            myFilter.LastNameFilter = txtLastName.Text;

            (dgvResults.DataSource as BindingSource).Filter = myFilter.Filter;
        }

        private struct CustomerFilter
        {
            public string FirstNameFilter;
            public string LastNameFilter;
            public string EmailFilter;

            public string Filter
            {
                get
                {
                    return string.Format("FirstName LIKE '%{0}%' AND LastName LIKE '%{1}%' AND Email LIKE '%{2}%'", FirstNameFilter, LastNameFilter, EmailFilter);
                }
            }
        }
    }
}
