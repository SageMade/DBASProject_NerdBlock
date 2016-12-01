using NerdBlock.Engine.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    [BusinessActionContainer]
    public class Application
    {
        [BusinessAction("exit_program")]
        public void Exit()
        {
            ViewManager.CloseProgram();
        }
    }
}
