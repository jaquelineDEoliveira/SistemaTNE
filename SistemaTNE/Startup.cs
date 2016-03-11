using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaTNE.Startup))]
namespace SistemaTNE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
