using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GwoDb.Tests.Integration
{
    public class Arrange_person
    {
        private readonly PersonRepository _personRepo;
        private readonly List<Person> _personToCreate = new List<Person>();

        public List<Person> All { get { return _personToCreate; } }

        public Arrange_person(PersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public Arrange_person AddPerson(string name)
        {
            _personToCreate.Add(new Person { Name = name });
            return this;
        }

        public Arrange_person Persist()
        {
            _personRepo.Create(_personToCreate);
            return this;
        }


    }
}
