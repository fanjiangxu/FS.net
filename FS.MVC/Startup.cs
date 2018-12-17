using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FS.MVC.Startup))]
namespace FS.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
