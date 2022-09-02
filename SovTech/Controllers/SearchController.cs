using Microsoft.AspNetCore.Mvc;
using SovTech.Clients.Abstract;
using SovTech.Services.Abstract;

namespace SovTech.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly ISearchService _searchService;

        public SearchController(ILogger<SearchController> logger, ISearchService searchService)
        {
            _logger = logger;
            _searchService = searchService;
        }
        [HttpPost("/search")]
        public async Task<ActionResult> Search([FromBody]string query)
        {
            return Ok(await _searchService.searchResults(query));
        }
    }
}
