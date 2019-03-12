using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InclassAssignment1.Startup))]
namespace InclassAssignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
