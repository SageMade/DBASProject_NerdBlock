using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Implementation
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
            PgQuery insert = new PgQuery(QueryTable.Database, insertParams, false, "insert into {0} (street_address, state, country, apt_num, unit_num) VALUES (@1, @2, @3, @4, @5)", TABLE_NAME);
            QueryTable.RegisterQuery("address_insert", insert);

            insertParams = new NpgsqlParameter[]
            {
                new NpgsqlParameter("1", NpgsqlDbType.Integer)
            };
            PgQuery search = new PgQuery(QueryTable.Database, insertParams, true, "select (street_address, state, country, apt_num, unit_num) from {0} where id=@1", TABLE_NAME);
            QueryTable.RegisterQuery("address_search_id", search);


            NpgsqlParameter[] commandParams = new NpgsqlParameter[]
            {
                new NpgsqlParameter("1", NpgsqlDbType.Varchar)
            };
            PgQuery countrySearch = new PgQuery(QueryTable.Database, commandParams, true, "select (street_address, state, country, apt_num, unit_num) from {0} where country ILIKE @1", TABLE_NAME);
            QueryTable.RegisterQuery("address_search_country", countrySearch);
        }

        public AddressModel(int id) : this()
        {
            myId = id;

            Read();
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
            IQueryResult result = QueryTable.Execute("address_search_id", myId);

            if (result.NumRows == 1)
            {
                object[] results =(object[])result.Row.ItemArray[0];
                myUnit = (int)results[4];
                myApartmentNumber = (int)results[3];

                myStreetAddress = (string)results[0];
                myState = (string)results[1];
                myCountry = (string)results[2];

                return true;
            }
            else
                return false;
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
        
        public static AddressModel[] SearchCountry(string country)
        {
            IQueryResult queryResult = QueryTable.Execute("address_search_country", country);
            
            if (queryResult.NumRows > 0)
            {
                AddressModel[] result = new AddressModel[queryResult.NumRows];

                for (int index = 0; index < result.Length; index++)
                {
                    object[] results = (object[])queryResult.Row.ItemArray[0];

                    AddressModel model = new AddressModel();
                    model.myUnit = (int)results[4];
                    model.myApartmentNumber = (int)results[3];

                    model.myStreetAddress = (string)results[0];
                    model.myState = (string)results[1];
                    model.myCountry = (string)results[2];

                    result[index] = model;

                    queryResult.MoveNext();
                }

                return result;
            }
            else
                return new AddressModel[0];
        }
    }
}
