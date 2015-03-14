using System;
using Microsoft.Owin;
using Owin;
using tesseract;

namespace tesseract
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}