using System;
using System.Collections.Generic;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class CompanyRepository : RepositoryDb<Company>
    {
        public CompanyRepository(ISession session) : base(session){}
        public ISession Session { get { return _session; } }

        public void Create(IEnumerable<Company> companiesToCreate)
        {
            foreach(var organisation in companiesToCreate)
                Create(organisation);
        }

        public override void Create(Company company)
        {
            foreach (var coleague in company.Users)
                if (coleague.Id == 0)
                {
                    coleague.DateCreated = DateTime.Now;
                    coleague.DateModified = DateTime.Now;
                }

            base.Create(company);
            Flush();
        }
    }
}
