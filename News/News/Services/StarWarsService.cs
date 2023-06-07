using News.Models;
using System.Net;
using System;
using System.Threading.Tasks;

namespace News.Services
{
    public class StarWarsService
    {
        public async Task<StarWarsResult> GetPlanets()
        {
            string url = GetUrl();

            var webclient = new WebClient();
            webclient.Headers["User-Agent"] =
                @"Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) 
                (compatible; MSIE 6.0; Windows NT 5.1; 
                .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

            string ret = string.Empty;

            try
            {
                ret = await webclient.DownloadStringTaskAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StarWarsResult>(ret);
        }

        private string GetUrl()
        {
            return "https://swapi.dev/api/planets/1/";
        }
    }
}
