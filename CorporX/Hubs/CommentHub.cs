using CorporX.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Hubs
{
    public class CommentHub:Hub
    {
        public async Task SendMessage(Comment comment)
        {
            await Clients.All.SendAsync("Send", comment);
        }
    }
}
