using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend.Winforms
{
    public class AuthAttrib : Attribute
    {
        public string[] RoleNames
        {
            get;
            set;
        }

        public AuthAttrib(params string[] roleNames)
        {
            RoleNames = roleNames;
        }
    }
}
