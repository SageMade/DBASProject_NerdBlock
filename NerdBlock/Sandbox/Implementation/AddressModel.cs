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
        private const string TABLE_NAME = "tbladdress";

        private int myId;
        private string myStreetAddress;
        private string myState;
        private string myCountry;
        private int myApartmentNumber;
        private string mySpecialRequests;

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
        public string SpecialRequests
        {
            get { return mySpecialRequests; }
            set { mySpecialRequests = value; isDirty = true; }
        }
        public bool IsDirty
        {
            get { return isDirty; }
        }

        static AddressModel()
        {
            QueryTable.RegisterQuery("address_insert", 
                QueryTable.Database.PrepareQuery(
                    string.Format("insert into {0} (streetaddress, state, country, apartmentnumber, specialrequests) VALUES (@1, @2, @3, @4, @5)", TABLE_NAME),
                    QueryParamType.VarChar, QueryParamType.VarChar, QueryParamType.VarChar, QueryParamType.Integer, QueryParamType.Text)
                );
            
            QueryTable.RegisterQuery("address_update",
                QueryTable.Database.PrepareQuery(
                    string.Format("update {0} set streetaddress=@2, state=@3, country=@4, apartmentnumber=@5, specialrequests=@6 where addressid=@1", TABLE_NAME),
                    QueryParamType.Integer, QueryParamType.VarChar, QueryParamType.VarChar, QueryParamType.VarChar, QueryParamType.Integer, QueryParamType.Text)
                );
            
            QueryTable.RegisterQuery("address_search_id",
                QueryTable.Database.PrepareQuery(
                    string.Format("select (streetaddress, state, country, apartmentnumber, specialrequests) from {0} where addressid=@1", TABLE_NAME), QueryParamType.Integer)
                );

            QueryTable.RegisterQuery("address_delete",
                QueryTable.Database.PrepareQuery(
                    string.Format("delete from {0} where addressid=@1", TABLE_NAME), QueryParamType.Integer)
                );
            
            QueryTable.RegisterQuery("address_search_country",
                QueryTable.Database.PrepareQuery(
                    string.Format("select (streetaddress, state, country, apartmentnumber, specialrequests, addressid) from {0} where country ILIKE @1", TABLE_NAME), QueryParamType.VarChar)
                );
        }

        public AddressModel(int id) : this()
        {
            myId = id;

            Read();
        }

        public AddressModel()
        {
            myId = -1;
            myApartmentNumber = -1;

            myStreetAddress = null;
            myState = null;
            myCountry = null;
            mySpecialRequests = null;
        }

        public bool Create()
        {
            IQueryResult result = QueryTable.Execute("address_insert", myStreetAddress, myState, myCountry, myApartmentNumber, mySpecialRequests);

            if (result.NumRows > 0)
            {
                isDirty = false;
                return true;
            }
            else
                return false;
        }

        public bool Delete()
        {
            IQueryResult result = QueryTable.Execute("address_delete", myId);

            if (result.NumRows > 0)
                return true;
            else
                return false;
        }

        public bool Read()
        {
            IQueryResult result = QueryTable.Execute("address_search_id", myId);

            if (result.NumRows == 1)
            {
                object[] results =(object[])result.Row.ItemArray[0];
                myApartmentNumber = (int)results[3];

                mySpecialRequests = (string)results[4];
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
            IQueryResult result = QueryTable.Execute("address_update", myId, myStreetAddress, myState, myCountry, myApartmentNumber, mySpecialRequests);

            if (result.NumRows > 0)
            {
                isDirty = false;

                return true;
            }
            else
                return false;
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

                    AddressModel model = new AddressModel((int)results[5]);
                    model.myApartmentNumber = (int)results[3];

                    model.mySpecialRequests = (string)results[4];
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
