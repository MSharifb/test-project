using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThirdExam.Startup))]
namespace ThirdExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
