using NerdBlock.Engine.Backend;
using System.Reflection;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Interface for classes that implement a specific view manager, for instance, a Winforms view manager
    /// </summary>
    public interface IViewManagerImplementation
    {
        /// <summary>
        /// Gets the current view being displayed
        /// </summary>
        IView CurrentView { get; }

        /// <summary>
        /// Starts the application, displaying the given initial view
        /// </summary>
        /// <param name="initialView">The name of the initial view to display</param>
        void Run(string initialView);

        /// <summary>
        /// Displays the view with the given name to the user
        /// </summary>
        /// <param name="viewName">The name of the view to display</param>
        void ShowView(string viewName);

        /// <summary>
        /// Displays the view to the user
        /// </summary>
        /// <param name="view">The view to display</param>
        void ShowView(IView view);

        /// <summary>
        /// Gets the view with the given name
        /// </summary>
        /// <param name="name">The name of the view to get</param>
        /// <returns>The view associated with the given name</returns>
        IView GetView(string name);

        /// <summary>
        /// Register a view with the view manager
        /// </summary>
        /// <param name="name">The name of the view to register</param>
        /// <param name="view">The view to register</param>
        void RegisterView(string name, IView view);

        /// <summary>
        /// Handles loading and generating the views from runtime reflection
        /// </summary>
        /// <param name="assembly">The assemly to search for IView implementations in</param>
        void ReflectLoadViews(Assembly assembly = null);

        /// <summary>
        /// Shows a flash message or dialog with the given content
        /// </summary>
        /// <param name="message">The text to display in the flash message</param>
        /// <param name="flashType">The type of flash message to display</param>
        void ShowFlash(string message, FlashMessageType flashType);
        
        /// <summary>
        /// Populates an object from all instances of a given model type
        /// </summary>
        /// <typeparam name="ValueType">The type of model to fill with</typeparam>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new();

        /// <summary>
        /// Populates an object from a query result
        /// </summary>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        /// <param name="queryResult">The query to populate from</param>
        /// <param name="nameIndex">The index of the name within the query</param>
        void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult query, int nameIndex = 0);

        /// <summary>
        /// Close the program
        /// </summary>
        void CloseProgram();

        /// <summary>
        /// Handles when the auth engine's authorization has changed
        /// </summary>
        void HandleAuthChanged();
    }
}