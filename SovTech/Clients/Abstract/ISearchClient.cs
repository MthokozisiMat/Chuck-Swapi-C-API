namespace SovTech.Clients.Abstract
{
    public interface ISearchClient
    {
        public Task<List<string>> GetCategories();

    }
}
