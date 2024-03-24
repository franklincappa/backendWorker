using Serilog;

namespace WorkerServiceAPI.Service
{
    public class LoggerService : ILoggerService
    {

        public LoggerService()
        {

        }
        public void WriteInLog(string cadena)
        {
            Log.Information(cadena);
        }
    }
}
