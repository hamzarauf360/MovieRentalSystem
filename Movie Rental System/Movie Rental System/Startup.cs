using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_Rental_System.Startup))]
namespace Movie_Rental_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
