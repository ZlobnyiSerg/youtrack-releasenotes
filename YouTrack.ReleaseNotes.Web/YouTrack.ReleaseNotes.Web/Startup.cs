using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouTrack.ReleaseNotes.Web.Startup))]
namespace YouTrack.ReleaseNotes.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
