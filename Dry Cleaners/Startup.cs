using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dry_Cleaners.Startup))]
namespace Dry_Cleaners
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
