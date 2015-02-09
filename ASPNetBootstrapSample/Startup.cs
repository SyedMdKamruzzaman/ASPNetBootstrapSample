using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetBootstrapSample.Startup))]
namespace ASPNetBootstrapSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
