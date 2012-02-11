using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class OrganisationSearchSpec : SearchSpecificationBase<UserFilter, UserOrderBy>
    {
    }

    public class UserFilter : ConditionContainer
    {
        public readonly ConditionString UserName;

        public UserFilter()
        {
            UserName = new ConditionString(this, "Name");
        }
    }

    public class UserOrderBy : SpecOrderByBase { }
}
