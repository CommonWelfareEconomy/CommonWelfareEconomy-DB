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
            HasOne(x => x.Organisation);
            HasManyToMany(x => x.Subscriptions).Cascade.All().Table("Person_Newsletter");
            Map(x => x.Name);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
