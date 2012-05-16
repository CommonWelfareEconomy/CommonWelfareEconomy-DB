using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Autofac;
using Module = Autofac.Module;

namespace GwoDb.Infrastructure
{
    public class AutofacCoreModule : Module
    {
        private readonly bool _withTestProject;
        
        public AutofacCoreModule(){}

        public AutofacCoreModule(bool withTestProject = true)
        {
            _withTestProject = withTestProject;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var assemblyCore = Assembly.Load("GwoDb.Core");
            builder.RegisterAssemblyTypes(assemblyCore).AssignableTo<IRegisterAsInstancePerLifetime>();
            builder.RegisterAssemblyTypes(assemblyCore).Where(a => a.Name.EndsWith("Repository"));

            if(_withTestProject)
            {
                var assemblyTest = Assembly.Load("GwoDb.Tests");
                builder.RegisterAssemblyTypes(assemblyTest).Where(a => a.Name.StartsWith("Arrange"));                
            }

            builder.RegisterInstance(SessionFactory.CreateSessionFactory().OpenSession());
        }
    }
}
