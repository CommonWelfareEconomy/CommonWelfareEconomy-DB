using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GwoDb.Tests.Integration
{
    class Organisation_persistence_tests : BaseTest
    {
        [Test]
        public void Should_create_organisation()
        {
            var organisation = new Company { Name = "Firma Müller" };

            var organisationRepo = Resolve<CompanyRepository>();
            organisationRepo.Create(organisation);

            Assert.That(organisationRepo.GetAll().Count, Is.EqualTo(1));
            Assert.That(organisationRepo.GetAll()[0].Name, Is.EqualTo("Firma Müller"));
        }

        [Test]
        public void Should_create_organisation_with_users()
        {
            var organisation = new Company { Name = "Firma Müller" };
            organisation.Users.Add(new Person{Name = "Kollege 1"});
            organisation.Users.Add(new Person { Name = "Kollege 2" });

            var organisationRepo = Resolve<CompanyRepository>();
            organisationRepo.Create(organisation);

            var organisations = organisationRepo.GetAll();

            Assert.That(organisations.Count, Is.EqualTo(1));
            Assert.That(organisations[0].Name, Is.EqualTo("Firma Müller"));
            Assert.That(organisations[0].Users.Count, Is.EqualTo(2));
            Assert.That(organisations[0].Users[0].Name, Is.EqualTo("Kollege 1"));
            Assert.That(organisations[0].Users[1].Name, Is.EqualTo("Kollege 2"));
        }

        [Test]
        public void Should_filter_and_order_organisations()
        {
            Resolve<Arrange_organisations>()
                .AddOrganisation("Firma Meyer")
                .AddOrganisation("Firma Müller")
                .AddOrganisation("Genossenschaft Berger").
                Persist();

            var searchSpec = new CompanySearchSpec();
            searchSpec.Filter.Name.Like("Firma");

            var organisationRepo = Resolve<CompanyRepository>();
            var organisations = organisationRepo.GetBy(searchSpec);

            Assert.That(organisations.Count, Is.EqualTo(2));
            Assert.That(organisations[0].Name, Is.EqualTo("Firma Meyer"));
            Assert.That(organisations[1].Name, Is.EqualTo("Firma Müller"));
        }
    }
}