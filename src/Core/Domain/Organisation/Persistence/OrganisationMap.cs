using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class OrganisationMap : ClassMap<Organisation>
    {
        public OrganisationMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Users).Cascade.All();
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
