using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tests.Integration
{
    public class Arrange_newsletter
    {
        private readonly NewsletterRepository _newsletterRepo;
        private readonly List<Newsletter> _newsletterToCreate = new List<Newsletter>();

        public Arrange_newsletter(NewsletterRepository newsletterRepo)
        {
            _newsletterRepo = newsletterRepo;
        }

        public Arrange_newsletter AddNewsletter(string name)
        {
            _newsletterToCreate.Add(new Newsletter{ Name = name });
            return this;
        }

        public Arrange_newsletter WithSubscriber(Person person)
        {
            _newsletterToCreate.Last().Subscribers.Add(person);
            return this;
        }

        public void Persist()
        {
            _newsletterRepo.Create(_newsletterToCreate);
        }

        
    }
}
