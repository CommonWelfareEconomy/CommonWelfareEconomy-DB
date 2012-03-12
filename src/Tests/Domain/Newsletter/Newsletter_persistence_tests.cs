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
        public void Should_create_organisation()
        {
            var newsletter = new Newsletter { Name = "Interne News" };

            var newsletterRepo = Resolve<NewsletterRepository>();
            newsletterRepo.Create(newsletter);

            Assert.That(newsletterRepo.GetAll().Count, Is.EqualTo(1));
            Assert.That(newsletterRepo.GetAll()[0].Name, Is.EqualTo("Interne News"));
        }

        [Test]
        public void Should_persist_subscribers()
        {
            var persons = Resolve<Arrange_person>().
                            AddPerson("Wadim").
                            AddPerson("Daniel").
                            AddPerson("Martin").
                            Persist();

            Resolve<Arrange_newsletter>().
                AddNewsletter("News 1").
                    WithSubscriber(persons.All[0]).
                    WithSubscriber(persons.All[1]).
                AddNewsletter("News 2").
                    WithSubscriber(persons.All[2]).
                Persist();

            var newsletter = Resolve<NewsletterRepository>().GetAll();
            
            Assert.That(newsletter.Count, Is.EqualTo(2));
            Assert.That(newsletter[0].Subscribers.Count, Is.EqualTo(2));
            Assert.That(newsletter[1].Subscribers.Count, Is.EqualTo(1));
        }
    }
}
