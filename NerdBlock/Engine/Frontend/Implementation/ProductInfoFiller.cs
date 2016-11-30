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
     public class ProductInfoFiller : ViewFillerBase
    {
        public ProductInfo View;

        public ProductInfoFiller(ProductInfo view)
        {
            AddFiller("Name", new TextBoxFiller<Product>((TextBox)view.Controls["txtProductName"], "Name"));
            AddFiller("Description", new TextBoxFiller<Product>((TextBox)view.Controls["txtProductDescription"], "Description"));
            AddFiller("Width", new TextBoxFiller<Product>((TextBox)view.Controls["txtWidth"], "Width"));
            AddFiller("Height", new TextBoxFiller<Product>((TextBox)view.Controls["txtLength"], "Height"));
            AddFiller("Depth", new TextBoxFiller<Product>((TextBox)view.Controls["txtHeight"], "Depth"));
        }
    }
}
