using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRSample
{
    public class MyChatHub : Hub
    {

        public void Send(string name, string message)
        {

            Clients.All.BroadcastMessage(name, message);
        }
    }
}