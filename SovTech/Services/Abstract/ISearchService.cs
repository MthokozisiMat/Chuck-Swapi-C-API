using SovTech.Models;

namespace SovTech.Services.Abstract
{
    public interface ISearchService
    {
        public Task<SearchResults> searchResults(string query);
    }
}
