using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class PoliticianSearchSpec : SearchSpecificationBase<PoliticianFilter, PoliticianOrderBy> { }

    public class PoliticianFilter : ConditionContainer
    {
        public ConditionTextSearch TextSearch { get; private set; }

        public PoliticianFilter()
        {
            TextSearch = new ConditionTextSearch(this, "Name", "Capacity", "Location");
        }
    }

    public class PoliticianOrderBy : SpecOrderByBase { }
}
