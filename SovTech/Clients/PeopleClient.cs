using Newtonsoft.Json;
using SovTech.Clients.Abstract;
using SovTech.Models;

namespace SovTech.Clients
{
    public class PeopleClient : IPeopleClient
    {
        public PeopleClient(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public async Task<People> GetPeoople()
        {
            People people = new People();
            HttpClient client = new HttpClient();
            var url = this.Configuration["ClientUrls:PeopleClientURL"];
            var response = await client.GetAsync(url);
            var responseList = JsonConvert.DeserializeObject<People>(response.Content.ReadAsStringAsync().Result);
            return responseList;
        }

        public async Task<PeopleSearch> SearchPeople(string query)
        {
            PeopleSearch peoplesearch = new PeopleSearch();
            HttpClient client = new HttpClient();
            var url = this.Configuration["ClientUrls:PeopleSerachURL"] + query;
            var response = await client.GetAsync(url);
            var responseList = JsonConvert.DeserializeObject<PeopleSearch>(response.Content.ReadAsStringAsync().Result);
            return responseList;
        }
    }
}
