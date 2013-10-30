using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTB_Foundation_WebForms_Sample.Startup))]
namespace MTB_Foundation_WebForms_Sample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
