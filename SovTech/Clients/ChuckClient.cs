using Newtonsoft.Json;
using SovTech.Clients.Abstract;
using SovTech.Models;
using static System.Net.WebRequestMethods;

namespace SovTech.Clients
{
    public class ChuckClient: IChuckClient
    {
        public ChuckClient(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public async Task<List<string>> GetCategories()
        {
            List<string> categories = new List<string>();
            HttpClient client = new HttpClient();
            var url = this.Configuration["ClientUrls:ChuckClientURL"];
            var response = await client.GetAsync(url);
            var responseList = JsonConvert.DeserializeObject<List<string>>(response.Content.ReadAsStringAsync().Result);
            return responseList;
        }

        public async Task<ChuckSearch> Search(string query)
        {
            ChuckSearch search = new ChuckSearch();
            HttpClient client = new HttpClient();
            var url = this.Configuration["ClientUrls:ChuckSerachURL"] + query;
            var response = await client.GetAsync(url);
            var responseList = JsonConvert.DeserializeObject<ChuckSearch>(response.Content.ReadAsStringAsync().Result);
            return responseList;
        }
    }
}
