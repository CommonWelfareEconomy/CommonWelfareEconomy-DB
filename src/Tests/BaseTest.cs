using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using GwoDb.Infrastructure;
using NUnit.Framework;

namespace GwoDb.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private static IContainer _container;

        [SetUp]
        public void Setup()
        {
            InitializeContainer();
        }

        private static void InitializeContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacCoreModule(withTestProject:true));
            _container = builder.Build();
            SessionFactory.BuildSchema();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }


    }
}
