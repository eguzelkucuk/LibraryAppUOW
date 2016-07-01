[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LibraryAppUOW.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LibraryAppUOW.App_Start.NinjectWebCommon), "Stop")]

namespace LibraryAppUOW.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject; 
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using Domain.Interfaces;
    using Data.Configuration;

    public static class NinjectWebCommon 
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
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

       
        private static void RegisterServices(IKernel kernel)
        {

           
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

  
            kernel.Bind(x => x.FromAssembliesMatching("*").SelectAllClasses().Excluding<UnitOfWork>().BindDefaultInterface());

        }        
    }
}
