using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Models
{
    public class ChatHub:Hub
    {
        public async Task Send(string userName,string message)
        {
            await this.Clients.All.SendAsync("Receive", userName,message);
        }
    }
}
