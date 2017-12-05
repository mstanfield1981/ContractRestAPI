using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractRestAPI.Startup))]
namespace ContractRestAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
