using NhlFaceoffStatCollector.Interfaces;

namespace NhlFaceoffStatCollector
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly INhlStatsService _statsService;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Starting NHL Faceoff Stat Collector at {time}", DateTimeOffset.Now);

            _logger.LogInformation("Finished NHL Faceoff Stat Collector at {time}", DateTimeOffset.Now);

            await Task.CompletedTask;
        }
    }
}
