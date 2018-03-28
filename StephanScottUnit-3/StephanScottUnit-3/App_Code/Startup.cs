using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StephanScottUnit_3.Startup))]
namespace StephanScottUnit_3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
