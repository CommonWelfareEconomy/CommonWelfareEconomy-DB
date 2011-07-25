using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GwoDb.Tests.Integration
{
    public class Newsletter_persistence_tests : BaseTest
    {
        [Test]
        public void Should_create_company()
        {
            var newsletter = new Newsletter { Name = "Interne News" };

            var newsletterRepo = Resolve<NewsletterRepository>();
            newsletterRepo.Create(newsletter);

            Assert.That(newsletterRepo.GetAll().Count, Is.EqualTo(1));
            Assert.That(newsletterRepo.GetAll()[0].Name, Is.EqualTo("Interne News"));
        }
    }
}
