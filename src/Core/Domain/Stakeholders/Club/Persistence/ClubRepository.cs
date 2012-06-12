using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class ClubRepository : RepositoryDb<Club>
    {
        public ClubRepository(ISession session) : base(session)
        {
        }
    }
}
