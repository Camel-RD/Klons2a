using KlonsChatApiServer.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KlonsChatApiServer.Services
{
    public class SignalHub : Hub
    {
        private static readonly ConcurrentDictionary<string, HashSet<string>> _connections = [];

        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override Task OnConnectedAsync()
        {
            var userId = UserManager.GetUserId(Context);
            if (userId != DbOps.AdminGuid)
                Context.Abort();

            if (!string.IsNullOrEmpty(userId))
            {
                _connections.AddOrUpdate(userId,
                    _ => new HashSet<string> { Context.ConnectionId },
                    (_, set) => { set.Add(Context.ConnectionId); return set; });
            }

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = UserManager.GetUserId(Context);

            if (!string.IsNullOrEmpty(userId) && _connections.ContainsKey(userId))
            {
                _connections[userId].Remove(Context.ConnectionId);
                if (_connections[userId].Count == 0)
                    _connections.TryRemove(userId, out _);
            }

            return base.OnDisconnectedAsync(exception);
        }

        public static IEnumerable<string> GetConnectionsForUser(string userId)
        {
            var rt = _connections.TryGetValue(userId, out var connections);
            if (!rt) return Enumerable.Empty<string>();
            return connections;
        }
    }
}
