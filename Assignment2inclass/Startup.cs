using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2inclass.Startup))]
namespace Assignment2inclass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
