using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend.Models
{
    [DataModel("tblsubscriptionfullfillment")]
    public class SubscriptionFullfillment
    {
        [DataField("subscriptionid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblsubscription", "subscriptionid")]
        public Subscription SubscriptionId { get; set; }

        [DataField("blockid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblBlock", "blockid")]
        public Block BlockId { get; set; }

        [DataField("trackingnumber", QueryParamType.VarChar)]
        public string TrackingNumber { get; set; }

        [DataField("fullfillingemployee", QueryParamType.Integer), ForeignKey("tblemployees", "employeeid")]
        public Employee FullfillingEmployee { get; set; }
    }
}
