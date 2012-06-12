using GwoDb.Infrastructure;
using Seedworks.Web.State;

namespace GwoDb.Web.Context
{
    public class SessionSearch : SessionBase, IRegisterAsInstancePerLifetime
    {
        public CompanySearchSpec OrgaSearchSpec
        {
            get { return Data.Get("orgaSearchSpecSearchPage", new CompanySearchSpec()); }
            set { Data["orgaSearchSpecSearchPage"] = value; }
        }
    }
}
