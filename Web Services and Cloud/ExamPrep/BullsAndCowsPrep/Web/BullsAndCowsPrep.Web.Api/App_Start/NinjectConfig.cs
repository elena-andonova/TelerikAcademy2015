namespace BullsAndCowsPrep.Web.Api
{
    using Data.Repositories;
    using Data;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using System;
    using System.Data.Entity;
    using System.Web;
    using System.Linq;
    using Services.Data.Contracts;
    using Common.Constants;

    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
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
            kernel.Bind<IBullsAndCowsPrepDbContext>().To<BullsAndCowsPrepDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));

            kernel.Bind<IGamesService>().To<GamesService>();

            //// when many controllers have been created
            //kernel.Bind(b => b
            //        .From(Assemblies.DataServices)
            //        .SelectAllClasses()
            //        .BindDefaultInterface());
        }
    }
}