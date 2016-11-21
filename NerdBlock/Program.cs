using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


using MySqlTest.Sandbox.Implementation;
using MySqlTest.Sandbox;
using System.Threading;

namespace MySqlTest
{
    class Program
    {
        static void Main(string[] args)
        {
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

            address.Create();
            
            try
            {
                
            }
            finally
            {

            }
        }
    }
}
