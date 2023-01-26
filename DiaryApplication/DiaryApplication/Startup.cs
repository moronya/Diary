using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiaryApplication.Startup))]
namespace DiaryApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
