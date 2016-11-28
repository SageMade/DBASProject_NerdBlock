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
        private static Dictionary<string, Action> myViewActions;

        public static IViewManagerImplementation Implementation
        { get; set; }

        static ViewManager()
        {
            myViewActions = new Dictionary<string, Action>();
        }

        public static void RegisterView(string name, IView view)
        {
            Implementation.RegisterView(name, view);
        }

        public static bool HasAction(string name)
        {
            return myViewActions.ContainsKey(name);
        }
        
        public static void Run(string initialView)
        {
            Implementation.Run(initialView);
        }

        public static void RegisterAction(string name, Action action)
        {
            myViewActions.Add(name, action);
        }

        public static void InvokeAction(string name)
        {
            myViewActions[name].Invoke();
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
