using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace NikhilBhingradiyaChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string Name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Name, message);
        }
        public Task SendMessageToCaller(string Name, string message)
        {
            return Clients.Caller.SendAsync("ReceivingMessageFromAUser", Name + " something special", message);
        }
        public Task SendMessageToGroup(string Name, string message)
        {
            return Clients.Group("SignalR Name").SendAsync("ReceivingMessageFromAUser", Name, message);
        }
    }
}