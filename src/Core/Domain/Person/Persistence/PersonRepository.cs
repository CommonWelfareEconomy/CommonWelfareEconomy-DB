﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace GwoDb
{
    public class PersonRepository : RepositoryDb<Person>
    {
        public PersonRepository(ISession session) : base(session)
        {
        }
    }
}