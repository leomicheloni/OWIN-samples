using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(InMemoryServer.Startup))]
namespace InMemoryServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var config = new HttpConfiguration();
            

            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Test" }
            );

            app.UseWebApi(config);
        }
    }
}