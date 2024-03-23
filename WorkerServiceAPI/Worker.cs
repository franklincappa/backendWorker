
namespace WorkerServiceAPI
{
    public class Worker : BackgroundService
    {
        //configuración logger
        private readonly ILogger<Worker> _logger;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Start servicio");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Stop servicio");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //funcionalidad de escribir en el log
            while(stoppingToken.IsCancellationRequested) 
            {
                _logger.LogTrace("El servicio sigue ejecutandose correctamente");
                await Task.Delay(60000, stoppingToken);
            } 
        }
    }
}
