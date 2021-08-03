using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;
namespace WillTheAirKillMe.Data
{
    public class AirQualityService
    {
        private IConfiguration configuration;
        private HttpClient client;
        public AirQualityService(IConfiguration _configuration){
            configuration = _configuration;
            client = new HttpClient();
        }
        public async Task<AirQualityReading> GetQualityReading()
        {
            var ApiKey = configuration["api-key"];
             var response = await client.GetStringAsync("https://www.airnowapi.org/aq/observation/zipCode/current/?format=application/json&zipCode=55117&distance=25&API_KEY="+ApiKey);
           var json = JsonConvert.DeserializeObject<List<AirQualityReading>>(response);
           var returnedReading = json[0];
           for(var x =1; x <json.Count; x++){
               if(json[x].AirQualityIndex > returnedReading.AirQualityIndex){
                   returnedReading = json[x];
               }
           }
            return returnedReading;
        }
    }
}
