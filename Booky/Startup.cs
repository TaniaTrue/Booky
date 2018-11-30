using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Booky.Startup))]
namespace Booky
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
