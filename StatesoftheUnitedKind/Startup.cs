using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatesoftheUnitedKind.Startup))]
namespace StatesoftheUnitedKind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
