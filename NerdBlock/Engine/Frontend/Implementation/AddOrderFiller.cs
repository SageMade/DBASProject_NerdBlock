using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Frontend.Winforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
{
    public class AddOrderFiller : ViewFillerBase
    {
        public AddOrder View;

        public AddOrderFiller(AddOrder view)
        {
            //Stuff need to be fixed with the models
            AddFiller("ProductName", new TextBoxFiller<Order>((TextBox)view.Controls["txtProductName"], "ProductName"));
            AddFiller("QuantityOrdered", new TextBoxFiller<Order>((TextBox)view.Controls["txtQuantityOrdered"], "QuantityOrdered"));
            AddFiller("BatchCost", new TextBoxFiller<OrderLineitem>((TextBox)view.Controls["txtPrice"], "BatchCost"));
            AddFiller("Address", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtAddress"], "Address"));
            AddFiller("Phone", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtPhone"], "Phone"));
            AddFiller("DateOrdered", new TextBoxFiller<Order>((TextBox)view.Controls["txtDateOrdered"], "DateOrdered"));
            AddFiller("OrderedBy", new TextBoxFiller<Order>((TextBox)view.Controls["txtDateArrived"], "OrderedBy"));
        }
    }
}
