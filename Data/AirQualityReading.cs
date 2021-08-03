using System;
using Newtonsoft.Json;

namespace WillTheAirKillMe.Data
{
    public class AirQualityReading
    {
        [JsonProperty("DateObserved")]
        public string Date { get; set; }
        public string HourObserved {get;set;}
        public string LocalTimeZone{get;set;}
        public string ReportingArea{get;set;}
        public string StateCode{get; set;}
        public double Latitude{get;set;}
        public double Longitude{get;set;}
        public string ParameterName{get;set;}   
        [JsonProperty("AQI")]
        public int AirQualityIndex{get;set;}
        public Category Category{get;set;}
    }
}
