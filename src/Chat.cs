using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class Chat : Hub
{
    public void Send(string name, string message)
    {
        //return Clients.All.InvokeAsync("Send", data);
         Clients.All.SendAsync("broadcastMessage", name, message);
    }
}