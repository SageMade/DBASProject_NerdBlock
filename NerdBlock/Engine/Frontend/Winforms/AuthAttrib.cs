using System;

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
