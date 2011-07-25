using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Colleagues).Cascade.All();
            Map(x => x.DateCreated);
            Map(x => x.DateModified);            
        }
    }
}
