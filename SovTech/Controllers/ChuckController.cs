using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SovTech.Clients;
using SovTech.Clients.Abstract;

namespace SovTech.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ChuckController : Controller
    {
        private readonly ILogger<ChuckController> _logger;
        private readonly  IChuckClient _categoriesClient;

        public ChuckController(ILogger<ChuckController> logger, IChuckClient categoriesClient)
        {
            _logger = logger;
            _categoriesClient = categoriesClient;
        }
        [HttpGet("/chuck/categories")]
        public  async Task<ActionResult> GetCategories()
        {
            return Ok( await _categoriesClient.GetCategories());
        }
    }
}
