using System;

namespace WillTheAirKillMe.Data
{
    public class AirQualityReading
    {
        public DateTime Date { get; set; }

        public string ReportingArea{get;}
        public string StateCode{get;}
        public double Latitude{get;}
        public double Longitude{get;}
        public ParameterName ParameterName;    
    }
}
