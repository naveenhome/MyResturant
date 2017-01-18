using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyResturant.Startup))]
namespace MyResturant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
