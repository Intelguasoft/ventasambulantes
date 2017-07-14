using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ventasambulantes.Startup))]
namespace ventasambulantes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
