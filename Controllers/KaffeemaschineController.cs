using Microsoft.AspNetCore.Mvc;

namespace Kaffeemaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeeController : ControllerBase
    {
        

        private readonly ILogger<KaffeeController> _logger;

        public KaffeeController(ILogger<KaffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetKaffe")]
        public IEnumerable<Kaffee> Get()
        {
            
           
        }

        [HttpPost(Name = "Post Kaffee")]
        public IEnumerable<Kaffee> Get()
        {

        }
    }
}