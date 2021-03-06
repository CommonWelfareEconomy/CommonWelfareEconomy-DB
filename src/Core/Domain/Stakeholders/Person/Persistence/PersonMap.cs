﻿using FluentNHibernate.Mapping;

namespace GwoDb
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Job);
            Map(x => x.Location);
            Map(x => x.Email);
            Map(x => x.Url);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}
