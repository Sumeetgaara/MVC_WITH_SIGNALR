using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace MVCWITHSIGNALR
{
    public class MyHub : Hub
    {
        public void Send()
        {
            GlobalHost.ConnectionManager.GetHubContext<MyHub>().Clients.All.SendAsync("New Updates!Refresh to see!! ~Your Powerful Server.");
        }

    }
}