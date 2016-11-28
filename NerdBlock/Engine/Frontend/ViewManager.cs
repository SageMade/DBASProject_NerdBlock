using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdBlock.Engine.Frontend.Winforms;

namespace NerdBlock.Engine.Frontend
{
    public static class ViewManager
    {
        public static IViewManagerImplementation Implementation
        { get; set; }

        static ViewManager()
        {

        }

        public static void RegisterView(string name, IView view)
        {
            Implementation.RegisterView(name, view);
        }
                
        public static void Run(string initialView)
        {
            Implementation.Run(initialView);
        }
        
        public static void Show(string name)
        {
            Implementation.ShowView(name);
        }

        public static void Show(IView view)
        {
            Implementation.ShowView(view);
        }

        public static IView GetView(string name)
        {
            return Implementation.GetView(name);
        }
    }
}
