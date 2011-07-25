        using System;using System.Collections.Generic;
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

        [Test]
        public void Should_create_company_with_colleagues()
        {
            var company = new Company { Name = "Firma Müller" };
            company.Colleagues.Add(new Person{Name = "Kollege 1"});
            company.Colleagues.Add(new Person { Name = "Kollege 2" });

            var companyRepo = Resolve<CompanyRepository>();
            companyRepo.Create(company);

            var companies = companyRepo.GetAll();

            Assert.That(companies.Count, Is.EqualTo(1));
            Assert.That(companies[0].Name, Is.EqualTo("Firma Müller"));
            Assert.That(companies[0].Colleagues.Count, Is.EqualTo(2));
            Assert.That(companies[0].Colleagues[0].Name, Is.EqualTo("Kollege 1"));
            Assert.That(companies[0].Colleagues[1].Name, Is.EqualTo("Kollege 2"));
        }
    }
}
