using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class NewsletterMap : ClassMap<Newsletter>
    {
        public NewsletterMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Subscribers).Cascade.All().Table("Person_Newsletter");
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
