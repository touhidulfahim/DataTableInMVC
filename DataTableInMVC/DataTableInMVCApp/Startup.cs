using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataTableInMVCApp.Startup))]
namespace DataTableInMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
