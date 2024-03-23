using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkerServiceAPI.Service;

namespace WorkerServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoggerService _loggerService;
        public HomeController(ILogger<HomeController> logger, ILoggerService loggerService) {
            _logger = logger;
            _loggerService = loggerService;
        }

        [HttpGet]
        [Route("write/{cadena}")]
        public IActionResult WriteInLog(string cadena) 
        {
            //definir servicio que escriba en el log
            _logger.LogInformation("Entrada Controller");
            _loggerService.WriteInLog(cadena);
            return Ok();
        }
    }
}
