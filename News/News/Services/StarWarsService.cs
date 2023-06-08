using News.Models;
using System.Net;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Security;
using System.Threading;

namespace News.Services
{
    public class StarWarsService
    {
        public async Task<StarWarsResult> GetPlanets()
        {

            StarWarsResult r = new StarWarsResult();
            
            for (int i = 1; i <= 60; i++)
            {
                string url = $"https://swapi.dev/api/planets/{i}/";

                var webclient = new WebClient();

                webclient.Headers["User-Agent"] =
                    @"Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) 
                (compatible; MSIE 6.0; Windows NT 5.1; 
                .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(
                       delegate { return true; }
                    );

                string ret = string.Empty;

                try
                {
                    ret = await webclient.DownloadStringTaskAsync(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                Planet retorno = Newtonsoft.Json.JsonConvert.DeserializeObject<Planet>(ret);
                r.Planets.Add(retorno);
                Thread.Sleep(2500);
            }
            
            return r;
        }
    }
}
