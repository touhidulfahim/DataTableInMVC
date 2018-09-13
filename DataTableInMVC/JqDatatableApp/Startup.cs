using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqDatatableApp.Startup))]
namespace JqDatatableApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
