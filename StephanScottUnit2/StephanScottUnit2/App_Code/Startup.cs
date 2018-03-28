using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StephanScottUnit2.Startup))]
namespace StephanScottUnit2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
