﻿﻿using System;
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
            Map(x => x.Industry);
            Map(x => x.Size);
            Map(x => x.Url);
            Map(x => x.Location);
            Map(x => x.ZipCode);
            Map(x => x.Email);
            Map(x => x.Password);
            Map(x => x.CountryIso3);
            Map(x => x.WelfareBalanceFor2011);
            Map(x => x.WelfareBalanceFor2012);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}
