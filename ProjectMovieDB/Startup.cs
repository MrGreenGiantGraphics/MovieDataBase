using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMovieDB.Startup))]
namespace ProjectMovieDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
