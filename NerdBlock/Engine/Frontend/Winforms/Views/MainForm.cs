using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AddEmployeeFiller filler = new AddEmployeeFiller(addEmployee1);

            Employee insert = new Employee()
            {
                FirstName = "Shawn",
                LastName = "Matthews",
                SIN = "123456789",
                DateJoined = DateTime.Now,
                Email = "me@shawnm.ca",
                Phone = 9058096006,
                HomeAddress = new Address()
                {
                    StreetAddress = "12 Bluenose Lane",
                    State = "Ontario",
                    PostalCode = "L1B1P5",
                    Country = "Country",

                }
            };

            DataAccess.Insert(insert);

            Employee search = new Employee() { FirstName = "Shawn", LastName = "Matthews" };

            Employee[] results = DataAccess.Match(search);
            
            filler.FillFrom(results[0]);
        }
    }
}
