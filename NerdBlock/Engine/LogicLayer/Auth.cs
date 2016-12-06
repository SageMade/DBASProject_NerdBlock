using System;

namespace NerdBlock.Engine.LogicLayer
{
    public static class Auth
    {
        public static IAuthImplementation Implementation { get; set; }

        public static event EventHandler OnAuthChanged;

        public static object User
        {
            get { return Implementation?.User; }
            set
            {
                Implementation.User = value;
                OnAuthChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static bool HasAccess(string actionName)
        {
            return Implementation.HasAccess(actionName);
        }

        public static bool TryAction(string actionName, out string message)
        {
            return Implementation.TryAction(actionName, out message);
        }
    }
}
