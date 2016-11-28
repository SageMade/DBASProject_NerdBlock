using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend.Models
{
    [DataModel("tblpaymentinstance")]
    public class PaymentInstance
    {
        [DataField("subscriptionid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblsubscriptionid", "subscriptionid")]
        public Subscription SubscriptionId { get; set; }

        [DataField("paymentdate", QueryParamType.Date), PrimaryKey]
        public DateTime? PaymentDate { get; set; }

        [DataField("billinginfoid", QueryParamType.Integer), ForeignKey("tblbillinginfo", "billinginfoid")]
        public BillingInfo BillingInfoId { get; set; }

        [DataField("ispayed", QueryParamType.Boolean)]
        public bool? IsPayed { get; set; }
    }
}
