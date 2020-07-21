using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatrommHub:Hub
    {
        public override Task OnConnectedAsync()
        {
            //Context.ConnectionId
            return base.OnConnectedAsync(); 
        }

        public async Task StartMessage(string user)
        {
            
            await Clients.All.SendAsync("JoinedRoom", user);
        }


        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

       
    }
}
