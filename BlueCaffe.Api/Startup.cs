using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(BlueCafe.Api.Startup))]
namespace BlueCafe.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
