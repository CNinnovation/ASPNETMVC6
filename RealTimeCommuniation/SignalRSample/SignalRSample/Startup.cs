﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRSample.Startup))]
namespace SignalRSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
