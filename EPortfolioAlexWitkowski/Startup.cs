using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPortfolioAlexWitkowski.Startup))]
namespace EPortfolioAlexWitkowski
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
