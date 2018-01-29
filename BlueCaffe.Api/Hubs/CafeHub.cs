using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BlueCafe.Api.Hubs
{
    [HubName("cafeHub")]
    public class CafeHub : Hub
    {
        public void Send(string name, string message)
        {
             
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}