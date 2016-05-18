using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_4._2_Partial.Startup))]
namespace Lab_4._2_Partial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
