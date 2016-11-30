using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Backend;
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

        public static IView CurrentView()
        {
            return Implementation.CurrentView;
        }

        public static void ShowFlash(string message, FlashMessageType flashType)
        {
            Implementation.ShowFlash(message, flashType);
        }

        public static void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new()
        {
            Implementation.PopulateList<ValueType, TargetType>(targetObject);
        }

        public static void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult queryResult, int nameIndex = 0)
        {
            Implementation.PopulateFromQuery<TargetType>(targetObject, queryResult, nameIndex);
        }
    }
}
