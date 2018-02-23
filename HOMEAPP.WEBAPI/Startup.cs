
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HOMEAPP.WEBAPI.Startup))]

namespace HOMEAPP.WEBAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}






















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.Owin;
//using Owin;
//using Microsoft.Owin.Cors;
//using HOMEAPP.WEBAPI.Authentication;
//using Microsoft.Owin.Security.OAuth;
//using System.Web.Http;
//using WebApiContrib.IoC.Ninject;

//[assembly: OwinStartup(typeof(HOMEAPP.WEBAPI.Startup))]

//namespace HOMEAPP.WEBAPI
//{
//    public partial class Startup
//    {

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="app"></param>
//        public void Configuration(IAppBuilder app)
//        {
//            HttpConfiguration config = new HttpConfiguration();

//            ConfigureOAuth(app);


//            WebApiConfig.Register(config);


//            app.UseCors(CorsOptions.AllowAll);

//            app.UseWebApi(config);

//            config.DependencyResolver = new NinjectResolver(new Ninject.Web.Common.Bootstrapper().Kernel);
//        }
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="app"></param>
//        public void ConfigureOAuth(IAppBuilder app)
//        {
//            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
//            {
//                AllowInsecureHttp = true,
//                TokenEndpointPath = new PathString("/token"),
//                AccessTokenExpireTimeSpan = TimeSpan.FromDays(2),
//                Provider = new AuthorizationServerProvider()
//            };

//            // Token Generation
//            app.UseOAuthAuthorizationServer(OAuthServerOptions);
//            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

//        }
//    }
//}
