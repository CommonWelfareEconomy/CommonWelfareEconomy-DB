using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class PersonSearchSpec : SearchSpecificationBase<PersonFilter, PersonOrderBy> { }

    public class PersonFilter : ConditionContainer
    {
        public ConditionTextSearch TextSearch { get; private set; }

        public PersonFilter()
        {
            TextSearch = new ConditionTextSearch(this, "Name", "Job", "Location");
        }
    }

    public class PersonOrderBy : SpecOrderByBase { }
}
