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
    public class ViewEditOrderFiller : ViewFillerBase
    {
        public ViewEditOrder View;

        public ViewEditOrderFiller(ViewEditOrder view)
        {
            AddFiller("ProductName", new TextBoxFiller<Order>((TextBox)view.Controls["txtProductName"], "ProductName"));
            AddFiller("DateOrdered", new TextBoxFiller<Order>((TextBox)view.Controls["txtDateOrdered"], "DateOrdered"));
            AddFiller("OrderedBy", new TextBoxFiller<Order>((TextBox)view.Controls["txtDateArrived"], "OrderedBy"));
        }
    }
}
