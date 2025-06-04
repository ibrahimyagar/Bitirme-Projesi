using Microsoft.AspNetCore.SignalR;

public class WebRtcHub : Hub
{
    public async Task SendSignal(string room, string user, string message)
    {
        await Clients.OthersInGroup(room).SendAsync("ReceiveSignal", user, message);
    }

    public async Task JoinRoom(string room)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, room);
    }
}