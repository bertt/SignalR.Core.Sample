using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class Chat : Hub
{
    public Task Send(string data)
    {
        return Clients.All.InvokeAsync("Send", data);
    }
}