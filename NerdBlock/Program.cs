using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NerdBlock.Engine;
using System.Threading;
using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Frontend;
using System.Reflection;
using NerdBlock.Engine.Frontend.Winforms;
using NerdBlock.Engine.Backend.PgImplementation;

namespace NerdBlock
{
    class Program
    {
        static void Main(string[] args)
        {

            DbConnectData data = DbConnectData.FromFile("DBConfig.txt.local");
            
            PgDatabase database = new PgDatabase();
            database.Init(data);

            while ((database.ConnectionObject as NpgsqlConnection).State != System.Data.ConnectionState.Open)
                Thread.Sleep(1);
            
            DataAccess.Database = database;

            ViewManager.Implementation = new WinformViewManager();

            Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(
                T => T.BaseType == typeof(ViewBase)).ToArray();
            
            for (int index = 0; index < types.Length; index++)
            {
                ViewBase item = Activator.CreateInstance(types[index]) as ViewBase;
                ViewManager.RegisterView(types[index].Name, item);
            }

            ViewManager.Run("Login");
            
            /*
            AddressModel address = new AddressModel();
            address.StreetAddress = "12 Bluenose Lane";
            address.State = "Ontario";
            address.Country = "Canada";
           

            bool sucess = address.Create();

            if (!sucess)
            {
                MessageBox.Show("Could not save model");
            }
            */
            
            Address test = new Address();
            test.StreetAddress = "12 Bluenose Lane";
            test.Country = "Canada";
            test.State = "Ontario";
            test.PostalCode = "L1B1P5";

            Employee employee1 = new Employee();
            employee1.FirstName = "Shawn";
            employee1.LastName = "Matthews";
            employee1.SIN = "696969699";
            employee1.DateJoined = DateTime.Now;

            employee1.HomeAddress = test;

            bool result1 = DataAccess.Insert(employee1);

            if (!result1)
                employee1.DateJoined = null;

            Employee[] employees = DataAccess.Match(employee1);
                        
            bool result2 = DataAccess.Insert(test);

            bool result3 = DataAccess.Exists(test);

            //DataAccess.Insert(test);

            /*
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
            */
        }
    }
}
