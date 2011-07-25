using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            HasOne(x => x.Company);
            HasManyToMany(x => x.Subscriptions).Table("Person_Newsletter");
            Map(x => x.Name);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
