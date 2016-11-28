﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend.Models
{
    [DataModel("tblCustomers")]
    public class Customer
    {
        [DataField("cusomterid", QueryParamType.Integer), AutoGenerated, PrimaryKey]
        public int? CustomerId { get; set; }

        [DataField("email", QueryParamType.VarChar)]
        public string Email { get; set; }

        [DataField("datejoined", QueryParamType.Date)]
        public DateTime? DateJoined { get; set; }

        [DataField("username", QueryParamType.VarChar)]
        public string UserName { get; set; }

        [DataField("hashedpass", QueryParamType.VarChar)]
        public string HashedPass { get; set; }

        [DataField("logintoken", QueryParamType.VarChar), Nullable]
        public string LoginToken { get; set; }

        [DataField("passwordresettoken", QueryParamType.VarChar), Nullable]
        public string PasswordResetToken { get; set; }

        [DataField("firstname", QueryParamType.VarChar)]
        public string FirstName { get; set; }

        [DataField("lastname", QueryParamType.VarChar)]
        public string LastName { get; set; }

        [DataField("homeaddress", QueryParamType.Integer), ForeignKey("tbladdress", "id")]
        public Address HomeAddress { get; set; }

        [DataField("billingaddress", QueryParamType.Integer), ForeignKey("tbladdress", "id"), Nullable]
        public Address BillingAddress { get; set; }
    }
}