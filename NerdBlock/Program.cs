using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Frontend.Winforms;
using NerdBlock.Engine.Backend.PgImplementation;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.LogicLayer.Implementation;

namespace NerdBlock
{
    class Program
    {
        /// <summary>
        /// Main program entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Get our database connect data, will eventually be hard coded or accessed via a web API
            DbConnectData data = DbConnectData.FromFile("DBConfig.txt.local");
            
            // Create and init that database
            PgDatabase database = new PgDatabase();
            database.Init(data);
                        
            // Assign the database connection to the DA
            DataAccess.Database = database;

            // Make our winforms view manager and assign it to the view manager
            ViewManager.Implementation = new WinformViewManager();
            // Reflection load all our views
            ViewManager.Implementation.ReflectLoadViews();

            // Create our auth handler
            Auth.Implementation = new NerdAuth();
            Auth.User = null;

            // Reflection load our rules and actions
            LogicManager.LoadRules();
            LogicManager.LoadActions();

            // Run the application, starting at the Login form
            ViewManager.Run("Login");
        }
    }
}
