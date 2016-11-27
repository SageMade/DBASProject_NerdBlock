using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Backend.Models
{
    [DataModel("tblBlockItem")]
    public class BlockItem
    {
        [DataField("blockid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblblock", "blockid")]
        public int? BlockId { get; set; }

        [DataField("productid", QueryParamType.Integer), PrimaryKey, ForeignKey("tblproduct", "productid")]
        public int? ProducId { get; set; }

        [DataField("quantity", QueryParamType.Integer)]
        public int? Quantity { get; set; }
    }
}
