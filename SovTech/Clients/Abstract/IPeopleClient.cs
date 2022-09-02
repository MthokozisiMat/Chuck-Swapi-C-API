using SovTech.Models;

namespace SovTech.Clients.Abstract
{
    public interface IPeopleClient
    {
        public Task<People> GetPeoople();
        public Task<PeopleSearch> SearchPeople(string query);

    }
}
