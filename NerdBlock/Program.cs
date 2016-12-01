using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NerdBlock.Engine;
using System.Threading;
using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Frontend;
using System.Reflection;
using NerdBlock.Engine.Frontend.Winforms;
using NerdBlock.Engine.Backend.PgImplementation;
using NerdBlock.Engine.LogicLayer;

namespace NerdBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnectData data = DbConnectData.FromFile("DBConfig.txt.local");
            
            PgDatabase database = new PgDatabase();
            database.Init(data);
                        
            DataAccess.Database = database;

            ViewManager.Implementation = new WinformViewManager();
            ViewManager.Implementation.ReflectLoadViews();
            LogicManager.LoadRules();
            LogicManager.LoadActions();

            ViewManager.Run("Login");
        }
    }
}
