using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleGithubDemo.Startup))]
namespace SampleGithubDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
