using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpTar.Startup))]
namespace EmpTar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
