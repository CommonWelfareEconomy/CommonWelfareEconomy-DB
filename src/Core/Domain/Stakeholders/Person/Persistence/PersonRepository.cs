using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class PersonRepository : RepositoryDb<Person>
    {
        public PersonRepository(ISession session) : base(session){}
    }
}
