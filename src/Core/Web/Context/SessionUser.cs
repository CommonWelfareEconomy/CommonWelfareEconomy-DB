using GwoDb.Infrastructure;
using Seedworks.Web.State;

namespace GwoDb.Web.Context
{
    public class SessionUser : SessionBase, IRegisterAsInstancePerLifetime
    {
        public bool IsAdmin
        {
            get { return Data.Get<bool>("isAdmin", false); }
            set { Data["isAdmin"] = value; }            
        }

        public bool IsCompany
        {
            get { return Data.Get<bool>("isCompany", false); }
            set { Data["isCompany"] = value; }
        }

        public bool IsLoggedIn
        {
            get { return Data.Get<bool>("isLoggedIn", false); }
            set { Data["isLoggedIn"] = value; }
        }

        public void Logout()
        {
            IsLoggedIn = false;
            IsAdmin = false;
        }
    }
}
