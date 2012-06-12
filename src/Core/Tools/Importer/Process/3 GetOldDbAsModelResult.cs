using System.Collections.Generic;

namespace GwoDb.Tools.Import
{
    public class GetOldDbAsModelResult
    {
        public IList<Company> Organisations;
        public IList<Club> Clubs;
        public IList<Politician> Politicians;
        public IList<Person> Persons;
    }
}