using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ScribrAPI.CentralHub
{
    public class PushNotification : Hub
    {
        public async Task ConnectToHub()
        {
            await Clients.All.SendAsync("Connected");
        }

        public async Task AddVideo()
        {
            await Clients.All.SendAsync("VideoAdded");
        }

        public async Task DeleteVideo()
        {
            await Clients.All.SendAsync("VideoDeleted");
        }
    }
}
