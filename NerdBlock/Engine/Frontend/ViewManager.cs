using System;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.LogicLayer;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Manages displaying and switching between views
    /// </summary>
    public static class ViewManager
    {
        /// <summary>
        /// Gets or set's the ViewManager's implementation
        /// </summary>
        public static IViewManagerImplementation Implementation
        { get; set; }
        
        /// <summary>
        /// Gets the current view being displayed
        /// </summary>
        public static IView CurrentView
        {
            get { return Implementation.CurrentView; }
        }
        
        static ViewManager()
        {
            Auth.OnAuthChanged += (X, Y) => HandleAuthChanged();
        }

        /// <summary>
        /// Close the program
        /// </summary>
        public static void CloseProgram()
        {
            // Call the implementation's method
            Implementation.CloseProgram();
        }

        /// <summary>
        /// Register a view with the view manager
        /// </summary>
        /// <param name="name">The name of the view to register</param>
        /// <param name="view">The view to register</param>
        public static void RegisterView(string name, IView view)
        {
            // Call the implementation's method
            Implementation.RegisterView(name, view);
        }

        /// <summary>
        /// Handles when the auth engine's authorization has changed
        /// </summary>
        public static void HandleAuthChanged()
        {
            // Call the implementation's method
            Implementation.HandleAuthChanged();
        }

        internal static void ShowInitial()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts the application, displaying a given initial view
        /// </summary>
        /// <param name="initialView">The name of the view to start at</param>
        public static void Run(string initialView)
        {
            // Call the implementation's method
            Implementation.Run(initialView);
        }
        
        /// <summary>
        /// Shows a view with the given name to the user
        /// </summary>
        /// <param name="name">The name of the view to display</param>
        public static void Show(string name)
        {
            // Call the implementation's method
            Implementation.ShowView(name);
        }

        /// <summary>
        /// Shows a view to the user
        /// </summary>
        /// <param name="view">The view to display</param>
        public static void Show(IView view)
        {
            // Call the implementation's method
            Implementation.ShowView(view);
        }

        /// <summary>
        /// Gets the view with the given name
        /// </summary>
        /// <param name="name">The name of the view to get</param>
        /// <returns>The view associated with the given name</returns>
        public static IView GetView(string name)
        {
            // Call the implementation's method
            return Implementation.GetView(name);
        }

        /// <summary>
        /// Shows a flash message or dialog with the given content
        /// </summary>
        /// <param name="message">The text to display in the flash message</param>
        /// <param name="flashType">The type of flash message to display</param>
        public static void ShowFlash(string message, FlashMessageType flashType)
        {
            // Call the implementation's method
            Implementation.ShowFlash(message, flashType);
        }

        /// <summary>
        /// Populates an object from all instances of a given model type
        /// </summary>
        /// <typeparam name="ValueType">The type of model to fill with</typeparam>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        public static void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new()
        {
            // Call the implementation's method
            Implementation.PopulateList<ValueType, TargetType>(targetObject);
        }

        /// <summary>
        /// Populates an object from a query result
        /// </summary>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        /// <param name="queryResult">The query to populate from</param>
        /// <param name="nameIndex">The index of the name within the query</param>
        public static void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult queryResult, int nameIndex = 0)
        {
            // Call the implementation's method
            Implementation.PopulateFromQuery<TargetType>(targetObject, queryResult, nameIndex);
        }
    }
}
