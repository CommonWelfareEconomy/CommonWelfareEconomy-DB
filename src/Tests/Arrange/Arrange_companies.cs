using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tests.Integration
{
    public class Arrange_companies
    {
        private readonly CompanyRepository _companyRepo;
        private readonly List<Company> _organisationsToCreate = new List<Company>();

        public Arrange_companies(CompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        public Arrange_companies AddOrganisation(string name)
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
