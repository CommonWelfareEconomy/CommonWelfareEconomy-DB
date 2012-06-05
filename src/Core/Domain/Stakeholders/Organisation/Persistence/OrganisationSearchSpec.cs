using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class OrganisationSearchSpec : SearchSpecificationBase<OrganisationFilter, OrganisationOrderBy>{}

    public class OrganisationFilter : ConditionContainer
    {
        public readonly ConditionString Name;
        public ConditionTextSearch TextSearch { get; private set; }

        public OrganisationFilter()
        {
            Name = new ConditionString(this, "Name");
            TextSearch = new ConditionTextSearch(this,
                "Name", "Industry", "Location", "ZipCode");
        }
    }

    public class OrganisationOrderBy : SpecOrderByBase { }
}
