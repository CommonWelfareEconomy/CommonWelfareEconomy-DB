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
    }
}
