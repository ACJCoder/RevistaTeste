using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevistaTeste.Startup))]
namespace RevistaTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
