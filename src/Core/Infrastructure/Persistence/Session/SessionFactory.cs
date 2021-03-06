﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace GwoDb.Infrastructure
{
    public class SessionFactory
    {
        private static Configuration _configuration;
        
        public static ISessionFactory CreateSessionFactory()
        {
            try
            {
                return Fluently.Configure()
                  .Database(
                    MsSqlConfiguration.MsSql2008
                      .ConnectionString(c => c
                        .FromConnectionStringWithKey("main"))
                  )
                  .Mappings(m =>
                    m.FluentMappings.Conventions.Add<EnumConvention>().AddFromAssemblyOf<Person>())
                  .ExposeConfiguration(SetConfig)
                  .BuildSessionFactory();                
            }catch(Exception ex){throw; } /* add break point here */

        }

        private static void SetConfig(Configuration config)
        {
            _configuration = config;
        }

        public static void BuildSchema()
        {
            new SchemaExport(_configuration)
                .Create(false, true);
        }
    }
}
