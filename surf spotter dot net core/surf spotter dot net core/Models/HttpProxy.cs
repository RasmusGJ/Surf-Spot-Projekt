using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static surf_spotter_dot_net_core.Models.APIModel;

namespace surf_spotter_dot_net_core.Models
{
    public class HttpProxy
    {
        private readonly HttpClient client = new HttpClient();
        public HttpProxy()
        {
            
        }
        public async Task<string> GetAllByCurrent(double lat, double lng)
        {

             var result = "";
             var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&exclude=minute,daily,hourly&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
             if (response.IsSuccessStatusCode)
             {
                 result = await response.Content.ReadAsStringAsync();
             }
            
             return result;
        }
        
        public async Task<List<Hourly>> GetAllByHourly(double lat, double lng)
        {
            Root hourlys = new Root();
            
            var result = "";
            var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    hourlys = JsonConvert.DeserializeObject<Root>(result);
                }
                
                return hourlys.Hourly;
        }

        public async Task<string> GetAllByDaily(double lat, double lng)
        {
            var result = "";
            var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lng}&exclude=minute,hourly,current&units=metric&appid=90109a7db32ae3dda1bca5e0458bc1da");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
        public async Task<List<Spot>> GetAllSpots()
        {
            Spot spot = new Spot();

            var result = "";
            var response = await client.GetAsync($"http://localhost:57804/api/getall");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                spot.Spots = JsonConvert.DeserializeObject<List<Spot>>(result);
            }

            return spot.Spots;
        }
        

        public async Task<Spot> GetOneSpot(int id)
        {
            //skal lige fikses - ikke en liste :)
            Spot spot = new Spot();
                
            var result = "";
            var response = await client.GetAsync($"http://localhost:57804/api/getbyid/{id}");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                spot = JsonConvert.DeserializeObject<Spot>(result);
            }
            return spot;
        }
    }
}
