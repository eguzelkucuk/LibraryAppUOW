[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LibraryAppUOW.WebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LibraryAppUOW.WebApi.App_Start.NinjectWebCommon), "Stop")]

namespace LibraryAppUOW.WebApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Extensions.Conventions;
    using System.Web.Http;
    using LibraryAppUOW.Domain.Interfaces;
    using LibraryAppUOW.Data.Configuration;

    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }


        public static void Stop()
        {
            bootstrapper.ShutDown();
        }


        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);


            GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);

        

            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

         
            kernel.Bind(x => x.FromAssembliesMatching("*").SelectAllClasses().Excluding<UnitOfWork>().BindDefaultInterface());

        }
    }
}