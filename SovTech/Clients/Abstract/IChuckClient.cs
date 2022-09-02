using SovTech.Models;

namespace SovTech.Clients.Abstract
{
    public interface IChuckClient
    {
        public Task<List<string>> GetCategories();
        public Task<ChuckSearch> Search(string query);

    }
}
