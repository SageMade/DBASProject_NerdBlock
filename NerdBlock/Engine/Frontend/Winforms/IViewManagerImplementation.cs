using NerdBlock.Engine.Backend;
using System.Reflection;

namespace NerdBlock.Engine.Frontend.Winforms
{
    public interface IViewManagerImplementation
    {
        IView CurrentView { get; }

        void Run(string initialView);

        void ShowView(string viewName);

        void ShowView(IView view);

        IView GetView(string name);

        void RegisterView(string name, IView view);

        void ReflectLoadViews(Assembly assembly = null);

        void ShowFlash(string message, FlashMessageType flashType);

        void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new();

        void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult query, int nameIndex = 0);

        void InitAuth(object authObject);
    }
}