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
        public async Task SendComment(Comment comment)
        {
            await this.Clients.All.SendAsync("Send", comment);
        }
    }
}
