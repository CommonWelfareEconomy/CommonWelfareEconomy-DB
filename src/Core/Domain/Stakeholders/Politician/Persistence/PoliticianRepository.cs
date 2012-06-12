using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class PoliticianRepository : RepositoryDb<Politician>
    {
        public PoliticianRepository(ISession session) : base(session){}
    }
}
