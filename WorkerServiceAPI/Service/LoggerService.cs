namespace WorkerServiceAPI.Service
{
    public class LoggerService : ILoggerService
    {
        private readonly ILogger<LoggerService> _logger;
        public void WriteInLog(string cadena)
        {
            _logger.LogWarning(cadena);
        }
    }
}
