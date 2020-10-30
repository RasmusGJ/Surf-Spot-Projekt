using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace surf_spotter_dot_net_core.Models
{
    public class HttpProxy
    {
        private readonly HttpClient _client = new HttpClient();
        public HttpProxy()
        {
            
        }
        public async Task<string> GetAll(int lat, int lng)
        {
            using (_client)
            {
                var result = "";
                var response = await _client.GetAsync($"https://api.met.no/weatherapi/locationforecast/2.0/compact.json?lat={lat}&lon={lng}");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
        }
    }
}
