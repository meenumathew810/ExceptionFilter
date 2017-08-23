using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterExample3.Startup))]
namespace FilterExample3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
