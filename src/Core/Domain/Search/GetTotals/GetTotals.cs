using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GwoDb.Infrastructure;
using NHibernate;

namespace GwoDb.Domain.Search
{
    public class GetTotals : IRegisterAsInstancePerLifetime
    {
        private readonly ISession _session;

        public GetTotals(ISession session){
            _session = session;
        }

        public GetTotalsResult Run()
        {
            var results = _session.CreateMultiQuery()
                .Add("select count(*) from Company")
                .Add("select count(*) from Club")
                .Add("select count(*) from Politician")
                .Add("select count(*) from Person")
                .List();

            return new GetTotalsResult
                       {
                           TotalCompanies = Convert.ToInt32(((ArrayList)results[0])[0]),
                           TotalClubs = Convert.ToInt32(((ArrayList)results[1])[0]),
                           TotalPoliticians = Convert.ToInt32(((ArrayList)results[2])[0]),
                           TotalPersons = Convert.ToInt32(((ArrayList)results[3])[0])
                       };
        }
    }
}