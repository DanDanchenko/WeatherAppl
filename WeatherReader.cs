using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Globalization;
using System.IO;

namespace WeatherApi
{
    public static  class WeatherReader
    {
        public  const string ApiKey = "8ce35e0573e4e01cb99b9691a2f77597";
        static string Country;
        static string City;

        

        private const string CurrentUrl =
             //"http://api.openweathermap.org/data/2.5/weather?" +
             //"zip=@LOC@&mode=xml&units=imperial&APPID=" + ApiKey;
             "http://api.openweathermap.org/data/2.5/weather?" +
            "q=@LOC@&mode=xml&APPID=" + ApiKey;
        static string DataFromSite = "";

        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "q=@LOC@&mode=xml&APPID=" + ApiKey;

        public static string GetWeather(string town)
        {
            WebClient Client;
            string url = CurrentUrl.Replace("@LOC@", town); 
            Client = new WebClient();
            string feedback = "";
            try
            {
                feedback = Client.DownloadString(url);
            }
            catch
            {
                feedback = "";
            }
            return feedback;
        }
        public static string GetForecast(string town)
        {
            WebClient Client;
            string url = ForecastUrl.Replace("@LOC@", town);
            Client = new WebClient();
            string feedback = "";
            try
            {
                feedback = Client.DownloadString(url);
            }
            catch
            {
                feedback = "";
            }
            return feedback;
        }
    }
}
