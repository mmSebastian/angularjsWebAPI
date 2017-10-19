using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FiiiEx.Startup))]

namespace FiiiEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // Allow CORS on token middleware provider, need to add the header "Access-Control-Allow-Origin" to Owin context
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
         
        }
    }
}
