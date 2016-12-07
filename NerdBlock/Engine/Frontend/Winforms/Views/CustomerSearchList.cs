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

        private void FilterTextChanged(object sender, EventArgs e)
        {
            TextBox control = sender as TextBox;
            string filterName = control?.Tag as string;
            myFilter.Set(filterName, control.Text);

            (dgvResults.DataSource as BindingSource).Filter = myFilter.Filter;
        }

        private struct CustomerFilter
        {
            public string FirstNameFilter;
            public string LastNameFilter;
            public string EmailFilter;

            public void Set(string filterName, string filter)
            {
                switch (filterName.ToLower())
                {
                    case "firstname":
                        FirstNameFilter = filter;
                        break;
                    case "lastname":
                        LastNameFilter = filter;
                        break;
                    case "email":
                        EmailFilter = filter;
                        break;
                }
            }

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
