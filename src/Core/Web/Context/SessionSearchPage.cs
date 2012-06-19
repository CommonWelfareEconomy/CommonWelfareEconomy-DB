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

        public ClubSearchSpec ClubSearchSpec
        {
            get { return Data.Get("clubSearchSpecSearchPage", new ClubSearchSpec()); }
            set { Data["clubSearchSpecSearchPage"] = value; }
        }

        public PersonSearchSpec PersonSearchSpec
        {
            get { return Data.Get("personSearchSpecSearchPage", new PersonSearchSpec()); }
            set { Data["personSearchSpecSearchPage"] = value; }
        }

        public PoliticianSearchSpec PoliticianSearchSpec
        {
            get { return Data.Get("politicianSearchSpecSearchPage", new PoliticianSearchSpec()); }
            set { Data["politicianSearchSpecSearchPage"] = value; }
        }

    }
}
