using Microsoft.AspNetCore.Mvc;
using SovTech.Clients.Abstract;

namespace SovTech.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SwapiController : Controller
    {
        private readonly ILogger<SwapiController> _logger;
        private readonly IPeopleClient _peopleClient;

        public SwapiController(ILogger<SwapiController> logger, IPeopleClient peopleClient)
        {
            _logger = logger;
            _peopleClient = peopleClient;
        }
        [HttpGet("/swapi/people")]
        public async Task<ActionResult> GetPeople()
        {
            return Ok(await _peopleClient.GetPeoople());
        }
    }
}
