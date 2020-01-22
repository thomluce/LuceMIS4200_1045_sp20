using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuceMIS4200_1045_sp20.Startup))]
namespace LuceMIS4200_1045_sp20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
