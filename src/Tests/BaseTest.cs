﻿using System;
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

        public BaseTest()
        {
            InitializeContainer();
        }

        private static void InitializeContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<AutofacCoreModule>();
            _container = builder.Build();
            SessionFactory.BuildSchema();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }


    }
}