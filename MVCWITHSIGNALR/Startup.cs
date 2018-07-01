using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWITHSIGNALR.Startup))]
namespace MVCWITHSIGNALR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
