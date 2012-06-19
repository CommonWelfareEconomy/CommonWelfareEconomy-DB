using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class ClubSearchSpec : SearchSpecificationBase<ClubFilter, ClubOrderBy> { }
    

    public class ClubFilter : ConditionContainer
    {
        public ConditionTextSearch TextSearch { get; private set; }

        public ClubFilter()
        {
            TextSearch = new ConditionTextSearch(this, "Name", "AreaOfWork", "Location");
        }
    }

    public class ClubOrderBy : SpecOrderByBase { }
}
