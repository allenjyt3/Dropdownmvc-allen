using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ajaxification17082017.Startup))]
namespace Ajaxification17082017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
