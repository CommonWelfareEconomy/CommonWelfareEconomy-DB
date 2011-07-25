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
            var assemblyTrueOrFalse = Assembly.Load("GwoDb.Core");
            builder.RegisterAssemblyTypes(assemblyTrueOrFalse).AssignableTo<IRegisterAsInstancePerLifetime>();
            builder.RegisterAssemblyTypes(assemblyTrueOrFalse).Where(a => a.Name.EndsWith("Repository"));

            builder.RegisterInstance(SessionFactory.CreateSessionFactory().OpenSession());
        }
    }
}
