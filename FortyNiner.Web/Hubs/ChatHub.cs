using Microsoft.AspNetCore.SignalR;

namespace FortyNiner.Web.Hubs
{
    public class ChatHub : Hub
    {
        public string GetConnectionId() => Context.ConnectionId;
    }
}
