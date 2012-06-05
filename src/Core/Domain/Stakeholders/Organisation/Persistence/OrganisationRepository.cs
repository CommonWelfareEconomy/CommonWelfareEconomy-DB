using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class OrganisationRepository : RepositoryDb<Organisation>
    {
        public OrganisationRepository(ISession session) : base(session){}
        public ISession Session { get { return _session; } }

        public void Create(List<Organisation> organisationsToCreate)
        {
            foreach(var organisation in organisationsToCreate)
                Create(organisation);
        }

        public override void Create(Organisation organisation)
        {
            foreach (var coleague in organisation.Users)
                if (coleague.Id == 0)
                {
                    coleague.DateCreated = DateTime.Now;
                    coleague.DateModified = DateTime.Now;
                }

            base.Create(organisation);
            Flush();
        }


    }
}
