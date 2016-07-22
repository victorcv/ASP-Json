using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcdia4.Startup))]
namespace mvcdia4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
