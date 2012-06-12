using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tests.Integration
{
    public class Arrange_organisations
    {
        private readonly CompanyRepository _companyRepo;
        private readonly List<Company> _organisationsToCreate = new List<Company>();

        public Arrange_organisations(CompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        public Arrange_organisations AddOrganisation(string name)
        {
            _organisationsToCreate.Add(new Company { Name = name });
            return this;
        }

        public void Persist()
        {
            _companyRepo.Create(_organisationsToCreate);
        }
    }
}
