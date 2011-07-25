using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GwoDb.Tests.Integration
{
    class Company_persistence_tests : BaseTest
    {
        [Test]
        public void Should_create_company()
        {
            var company = new Company { Name = "Firma Müller" };

            var companyRepo = Resolve<CompanyRepository>();
            companyRepo.Create(company);

            Assert.That(companyRepo.GetAll().Count, Is.EqualTo(1));
            Assert.That(companyRepo.GetAll()[0].Name, Is.EqualTo("Firma Müller"));

        }
    }
}
