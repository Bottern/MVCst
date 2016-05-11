using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_2._2_TicTacToe.Startup))]
namespace Lab_2._2_TicTacToe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
