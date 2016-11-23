using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


using NerdBlock.Sandbox.Implementation;
using NerdBlock.Sandbox;
using System.Threading;
using System.Windows.Forms;

namespace NerdBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MainForm form = new MainForm())
            {
                form.ShowDialog();
            }

                DbConnectData data = new DbConnectData()
                {
                    Host = "localhost",
                    Database = "testing",
                    Username = "test",
                    Password = "password",
                    Port = -1
                };

            PgDatabase database = new PgDatabase();
            database.Init(data);

            while ((database.ConnectionObject as NpgsqlConnection).State != System.Data.ConnectionState.Open)
                Thread.Sleep(1);

            QueryTable.Database = database;


            AddressModel address = new AddressModel();
            address.StreetAddress = "12 Bluenose Lane";
            address.State = "Ontario";
            address.Country = "Canada";

            bool sucess = address.Create();

            if (!sucess)
            {
                MessageBox.Show("Could not save model");
            }

            AddressModel address2 = new AddressModel();
            address2.StreetAddress = "173 Ellesmere Rd";
            address2.State = "Ontario";
            address2.Country = "Canada";
            address2.Create();

            AddressModel model = new AddressModel(70);

            model.Country = "Zimbabwe";
            sucess = model.Update();
            if (!sucess)
            {
                MessageBox.Show("Could not update model");
            }

            AddressModel[] canadianAddress = AddressModel.SearchCountry("Canada");

            if (canadianAddress.Length > 0)
                canadianAddress[0].Delete();
            
            try
            {
                
            }
            finally
            {

            }
        }
    }
}
