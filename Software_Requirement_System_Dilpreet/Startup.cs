using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Software_Requirement_System_Dilpreet.Startup))]
namespace Software_Requirement_System_Dilpreet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
