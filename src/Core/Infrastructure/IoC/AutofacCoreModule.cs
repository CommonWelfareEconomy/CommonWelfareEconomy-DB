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
        protected override void Load(ContainerBuilder builder)
        {
            var assemblyCore = Assembly.Load("GwoDb.Core");
            builder.RegisterAssemblyTypes(assemblyCore).AssignableTo<IRegisterAsInstancePerLifetime>();
            builder.RegisterAssemblyTypes(assemblyCore).Where(a => a.Name.EndsWith("Repository"));

            builder.RegisterInstance(SessionFactory.CreateSessionFactory().OpenSession());
        }
    }
}
