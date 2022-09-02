using SovTech.Clients.Abstract;
using SovTech.Models;
using SovTech.Services.Abstract;

namespace SovTech.Services
{
    public class SearchService: ISearchService
    {
        private readonly IPeopleClient _peopleClient;
        private readonly IChuckClient _chuckClient;

        public SearchService(IPeopleClient peopleClient, IChuckClient categoriesClient)
        {
            _peopleClient = peopleClient;
            _chuckClient = categoriesClient;
        }

        public async Task<SearchResults> searchResults(string query)
        {
            SearchResults searchResults = new SearchResults();
            var StarWarsResults = await _peopleClient.SearchPeople(query);
            var ChuckResults = await _chuckClient.Search(query);
            searchResults.ChuckNorrisResults = ChuckResults;
            searchResults.StarWarsResults = StarWarsResults;

            return searchResults;
        }
    }
}
