using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatDemo.Hubs
{
    public class ChatHub : Hub
    {
        // call this method when a user connects to hub
        //public override Task OnConnected()
        //{
        //var connectionId = Context.ConnectionId; //get connection id
        //    return base.OnConnected();
        //}

        public void Send(string name, string message)
        {
            // Call the getMessage method to update users' messsages.
            Clients.All.getMessage(name, message);

            //only call a particular user gets messages
            //Clients.Client(connectionId).getMessage("System", connectionId+"   :" + DateTime.Now);
        }

        public void ShowUserGoOnline(string name, string message)
        {
            Clients.Others.getMessage(name, message); // Call other users to get message method
        }

        //public override Task OnDisconnected(bool stopCalled)
        //{
        //    Clients.All.getMessage("System", "a user go offline at " + DateTime.Now);
        //    return base.OnDisconnected(stopCalled);
        //}
    }
}