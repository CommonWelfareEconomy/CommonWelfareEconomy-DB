using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class NewsletterRepository : RepositoryDb<Newsletter>
    {
        public NewsletterRepository(ISession session): base(session)
        {
        }

        public void Create(List<Newsletter> newsletters)
        {
            foreach(var newsletter in newsletters)
                Create(newsletter);

            Flush();
        }
    }
}
