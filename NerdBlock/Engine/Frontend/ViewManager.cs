using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    public static class ViewManager
    {
        private static Dictionary<string, IView> myViews;

        static ViewManager()
        {
            myViews = new Dictionary<string, IView>();
        }

        public static void RegisterView(string name, IView view)
        {
            myViews.Add(name, view);
        }

        public static void Show(string name)
        {
            if (myViews.ContainsKey(name))
                myViews[name].ShowView();
        }

        public static IView GetView(string name)
        {
            if (myViews.ContainsKey(name))
                return myViews[name];
            else
                return null;
        }
    }
}
