using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace GwoDb.Infrastructure
{
    public class SpecFilterBase : ConditionContainer
    {
        public readonly ConditionDateTime DateCreated;
        public readonly ConditionDateTime DateModified;

        public SpecFilterBase()
        {
            DateCreated = new ConditionDateTime(this, "DateCreated");
            DateModified = new ConditionDateTime(this, "DateModified");
        }
    }
}
