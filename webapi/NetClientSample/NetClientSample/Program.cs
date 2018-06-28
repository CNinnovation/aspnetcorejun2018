using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetClientSample
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await GetSomethingAsync();
        }

        private static async Task GetSomethingAsync()
        {
            var client = new HttpClient();
            HttpResponseMessage resp = await client.GetAsync("https://www.cninnovation.com/downloads/racers.xml");
            resp.EnsureSuccessStatusCode();
            string data = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(data);


        }
    }
}
