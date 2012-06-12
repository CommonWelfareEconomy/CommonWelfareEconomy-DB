using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class CompanySearchSpec : SearchSpecificationBase<CompanyFilter, CompanyOrderBy>{}

    public class CompanyFilter : ConditionContainer
    {
        public readonly ConditionString Name;
        public ConditionTextSearch TextSearch { get; private set; }

        public CompanyFilter()
        {
            Name = new ConditionString(this, "Name");
            TextSearch = new ConditionTextSearch(this,
                "Name", "Industry", "Location", "ZipCode");
        }
    }

    public class CompanyOrderBy : SpecOrderByBase { }
}
