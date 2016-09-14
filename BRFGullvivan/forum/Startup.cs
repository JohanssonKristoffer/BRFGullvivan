using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(forum.Startup))]
namespace forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
