using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_FATURA.Startup))]
namespace E_FATURA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
