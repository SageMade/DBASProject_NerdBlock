using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend.Models
{
    [DataModel("tblorderlineitem")]
    public class OrderLineitem
    {
        [DataField("orderid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblorder", "orderid")]
        public Order OrderId { get; set; }

        [DataField("productid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblproduct", "productid")]
        public Product ProductId { get; set; }

        [DataField("quantity", QueryParamType.Integer)]
        public int? Quantity { get; set; }

        [DataField("batchcost", QueryParamType.Money)]
        public decimal? BatchCost { get; set; }
    }
}
