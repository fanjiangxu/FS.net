using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FS.Tidebuy.CMS.Worker.Startup))]
namespace FS.Tidebuy.CMS.Worker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
