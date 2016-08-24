using Microsoft.Owin;
using Owin;

namespace StarterMvc.Web
{

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
