using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFS_dotNetDevTest.Startup))]
namespace AFS_dotNetDevTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
