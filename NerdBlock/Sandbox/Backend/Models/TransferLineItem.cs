using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend.Models
{
    [DataModel("tbltransferlineitem")]
    public class TransferLineItem
    {
        [DataField("transferid", QueryParamType.Integer), PrimaryKey, ForeignKey("tbltransfer", "transferid")]
        public int? TransferId { get; set; }

        [DataField("productid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblproduct", "productid")]
        public int? ProductId { get; set; }

        [DataField("quantity", QueryParamType.Integer)]
        public int? Quantity { get; set; }
    }
}
