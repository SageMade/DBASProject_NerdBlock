using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend.Models
{
    [DataModel("tblsubscriptionfullfillment")]
    class SubscriptionFullfillment
    {
        [DataField("subscriptionid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblsubscription", "subscriptionid")]
        public int? SubscriptionId { get; set; }

        [DataField("blockid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblBlock", "blockid")]
        public int? BlockId { get; set; }

        [DataField("trackingnumber", QueryParamType.VarChar)]
        public string TrackingNumber { get; set; }

        [DataField("fullfillingemployee", QueryParamType.Integer), ForeignKey("tblemployees", "employeeid")]
        public int? FullfillingEmployee { get; set; }
    }
}
