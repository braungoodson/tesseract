using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace tesseract
{
    public class Dawn : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}