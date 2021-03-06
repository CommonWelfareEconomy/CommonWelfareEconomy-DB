﻿using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using GwoDb;
using GwoDb.Infrastructure;
using GwoDb.Updates;
using GwoDb.Web.Context;
using HibernatingRhinos.Profiler.Appender.NHibernate;

namespace Frontend.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default-Admin", "Admin/{action}", new { controller = "Admin", action = "Welcome", id = UrlParameter.Optional });
            routes.MapRoute("Default", "{controller}/{action}/{id}",  new { controller = "SearchCompany", action = "Search", id= UrlParameter.Optional });
        }

        protected void Application_Start()
        {
            InitializeAutofac();
            Sl.Resolve<Update>().Run(); 

            AreaRegistration.RegisterAllAreas();

            #if DEBUG
                NHibernateProfiler.Initialize();
            #endif

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        private static void InitializeAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
            builder.RegisterModule(new AutofacCoreModule());
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(MvcApplication))).AssignableTo<IRegisterAsInstancePerLifetime>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected void Session_Start()
        {
            if (!Sl.Resolve<SessionUser>().IsLoggedIn)
                Sl.Resolve<LoginFromCookie>().Run();
        }
    }
}