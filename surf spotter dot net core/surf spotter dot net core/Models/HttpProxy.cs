using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace surf_spotter_dot_net_core.Models
{
    public class HttpProxy
    {
        private readonly HttpClient _client = new HttpClient();
        public HttpProxy()
        {
            
        }
        public async Task<string> GetAllByCurrent(int lat, int lng)
        {
            using (_client)
            {
                var result = "";
                var response = await _client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&exclude=minute,daily,hourly&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

                
                return result;
            }
        }
        
        public async Task<string> GetAllByHourly(int lat, int lng)
        {
            List <Weather> weathers = new List<Weather>();
            using (_client)
            {
                var result = "";
                var response = await _client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&exclude=minute,daily,current&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

                JObject joResponse = JObject.Parse(result);
                JObject ojObject = (JObject)joResponse["daily"];
                JArray array = (JArray)ojObject["0"];
                array.ToList();
                return result;
            }
        }

        public async Task<string> GetAllByDaily(int lat, int lng)
        {
            using (_client)
            {
                var result = "";
                var response = await _client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&exclude=minute,hourly,current&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
        }
    }
}
