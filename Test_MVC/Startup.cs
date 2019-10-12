using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_MVC.Startup))]
namespace Test_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
