using Microsoft.AspNetCore.SignalR;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using SecurityGateApv.Domain.Interfaces.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Notifications
{
    public class NotificationHub : Hub
    {
        private IDictionary<string, UserConnectionDTO> _connections;
        public NotificationHub(IDictionary<string, UserConnectionDTO> connections)
        {
            _connections = connections;
        }
        public async Task JoinHub(UserConnectionDTO conn)
        {
            _connections[Context.ConnectionId] = conn;
            await Clients.All.SendAsync("ReceiveMessage", "admind", $"{Context.ConnectionId} has joined");
        }

        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage", "admind", $"Test API");
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            _connections.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
