using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Domain.Search
{
    public class GetTotalsResult
    {
        public int TotalCompanies;
        public int TotalClubs;
        public int TotalPoliticians;
        public int TotalPersons;

        public int TotalAll { get { return TotalCompanies + TotalClubs + TotalPoliticians + TotalPersons; } }
    }
}
