using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace ClareSoft.Hubs
{
    public class Led1Hub: Hub
    {
        public async Task SendMessage(bool b)
        {
            await Clients.All.SendAsync("ReceiveMessage", b);
        }
    }
}
