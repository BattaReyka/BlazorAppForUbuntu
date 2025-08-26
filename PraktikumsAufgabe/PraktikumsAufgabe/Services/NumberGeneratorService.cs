using Microsoft.AspNetCore.SignalR;
using PraktikumsAufgabe.Hubs;
using PraktikumsAufgabe.Data;

namespace PraktikumsAufgabe.Services
{
    public class NumberGeneratorService : BackgroundService
    {
        private readonly IHubContext<RandomNumberHub> _hubContext;
        private readonly Random _random = new();

        public NumberGeneratorService(IHubContext<RandomNumberHub> hubContext)
        {
            _hubContext = hubContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var entry = new RandomEntry
                {
                    Timestamp = DateTime.Now,
                    Value = _random.Next(100000, 1000000)
                };

                await _hubContext.Clients.All.SendAsync("ReceiveNumber", entry);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
