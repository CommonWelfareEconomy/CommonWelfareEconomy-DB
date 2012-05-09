using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GwoDb.Tests.Integration
{
    public class Person_persistence_tests : BaseTest
    {
        [Test]
        public void Should_create_person()
        {
            var person = new Person {Name = "Meyer"};
            Resolve<PersonRepository>().Create(person);
        }
    }
}
