using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ticketsysteem.Startup))]
namespace Ticketsysteem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
