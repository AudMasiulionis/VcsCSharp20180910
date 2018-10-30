using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_HTTP
{
    public class BeerClient
    {
        private const string uri = "http://ontariobeerapi.ca/";

        public List<Beer> GetBeers()
        {
            List<Beer> courses = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                using (HttpResponseMessage response = client.GetAsync("products").Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<List<Beer>>(result);
                    }
                    return courses;
                }
            }
        }

        //todo implement other beers
    }
}
