using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeoCoupons.Startup))]
namespace GeoCoupons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
