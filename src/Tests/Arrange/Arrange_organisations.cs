using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tests.Integration
{
    public class Arrange_organisations
    {
        private readonly OrganisationRepository _organisationRepo;
        private readonly List<Organisation> _organisationsToCreate = new List<Organisation>();

        public Arrange_organisations(OrganisationRepository organisationRepo)
        {
            _organisationRepo = organisationRepo;
        }

        public Arrange_organisations AddOrganisation(string name)
        {
            _organisationsToCreate.Add(new Organisation { Name = name });
            return this;
        }

        public void Persist()
        {
            _organisationRepo.Create(_organisationsToCreate);
        }
    }
}
