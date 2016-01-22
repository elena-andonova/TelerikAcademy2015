using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(BullsAndCowsPrep.Web.Api.Startup))]

namespace BullsAndCowsPrep.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.RegisterMappings("BullsAndCowsPrep.Web.Api");

            ConfigureAuth(app);

            //Adding http configuration
            var httpConfig = new HttpConfiguration();

            WebApiConfig.Register(httpConfig);

            httpConfig.EnsureInitialized();

            //Configure Ninject
            app
                .UseNinjectMiddleware(NinjectConfig.CreateKernel)
                .UseNinjectWebApi(httpConfig);
        }        
    }
}
