using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class CompanyRepository : RepositoryDb<Company>
    {
        public CompanyRepository(ISession session) : base(session)
        {
        }

        public override void Create(Company company)
        {
            foreach (var coleague in company.Colleagues)
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
