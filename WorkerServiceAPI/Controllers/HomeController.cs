using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkerServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        [HttpGet]
        [Route("write/{cadena}")]
        public IActionResult WriteInLog(string cadena) 
        {
            //definir servicio que escriba en el log
            _logger.LogInformation("Entrada Controller");
            return Ok();
        }
    }
}
