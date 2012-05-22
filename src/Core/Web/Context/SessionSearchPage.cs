using GwoDb.Infrastructure;
using Seedworks.Web.State;

namespace GwoDb.Web.Context
{
    public class SessionSearch : SessionBase, IRegisterAsInstancePerLifetime
    {
        public OrganisationSearchSpec OrgaSearchSpec
        {
            get { return Data.Get("orgaSearchSpecSearchPage", new OrganisationSearchSpec()); }
            set { Data["orgaSearchSpecSearchPage"] = value; }
        }
    }
}
