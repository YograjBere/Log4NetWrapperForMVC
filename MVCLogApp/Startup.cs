using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLogApp.Startup))]
namespace MVCLogApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
