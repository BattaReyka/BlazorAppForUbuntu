using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace PraktikumsAufgabe.Hubs
{
    public class RandomNumberHub : Hub
    {
        public async Task SendNumber(int number)
        {
            await Clients.All.SendAsync("ReceiveNumber", number);
        }
    }
}