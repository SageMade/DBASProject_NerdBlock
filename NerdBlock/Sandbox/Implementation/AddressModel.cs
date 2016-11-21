using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlTest.Sandbox.Implementation
{
    public class AddressModel : IModel<AddressModel>
    {
        private const string TABLE_NAME = "tbl_address";

        private int myId;
        private string myStreetAddress;
        private string myState;
        private string myCountry;
        private int myApartmentNumber;
        private int myUnit;

        private bool isDirty;

        public int Id
        {
            get { return myId; }
        }
        public string StreetAddress
        {
            get { return myStreetAddress; }
            set { myStreetAddress = value; isDirty = true; }
        }
        public string State
        {
            get { return myState; }
            set { myState = value; isDirty = true; }
        }
        public string Country
        {
            get { return myCountry; }
            set { myCountry = value; isDirty = true; }
        }
        public int ApartmentNumber
        {
            get { return myApartmentNumber; }
            set { myApartmentNumber = value; isDirty = true; }
        }
        public int UnitNumber
        {
            get { return myUnit; }
            set { myUnit = value; isDirty = true; }
        }

        static AddressModel()
        {
            NpgsqlParameter[] insertParams = new NpgsqlParameter[] 
            {
                new NpgsqlParameter("1", NpgsqlDbType.Varchar),
                new NpgsqlParameter("2", NpgsqlDbType.Varchar),
                new NpgsqlParameter("3", NpgsqlDbType.Varchar),
                new NpgsqlParameter("4", NpgsqlDbType.Integer),
                new NpgsqlParameter("5", NpgsqlDbType.Integer),
            };
            PgQuery insert = new PgQuery(QueryTable.Database, insertParams, "insert into {0} (street_address, state, country, apt_num, unit_num) VALUES (@1, @2, @3, @4, @5)", TABLE_NAME);
            QueryTable.RegisterQuery("address_insert", insert);
        }

        public AddressModel()
        {
            myId = -1;
            myUnit = -1;
            myApartmentNumber = -1;

            myStreetAddress = null;
            myState = null;
            myCountry = null;
        }

        public bool Create()
        {
            IQueryResult result = QueryTable.Execute("address_insert", myStreetAddress, myState, myCountry, myApartmentNumber, myUnit);

            if (result.NumRows > 0)
                return true;
            else
                return false;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public AddressModel[] Execute()
        {
            throw new NotImplementedException();
        }

        public AddressModel[] Query(AddressModel search)
        {
            throw new NotImplementedException();
        }
    }
}
