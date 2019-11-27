using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public string weather;
        public string condition;
        public int temperature;
        public List<string> weatherConditions;

        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy"};
            GetDailyWeatherCondition();
            GetDailyTemp();
            
        }

        public int GetDailyTemp()
        {
            Random temp = new Random();
            temperature = temp.Next(55, 95);
            Console.WriteLine("Temperature is {0}° F.", temperature);
            return temperature;
        }

        public string GetDailyWeatherCondition()
        {
            Random weather = new Random();
            int weatherCon = weather.Next(0, 4);
            condition = weatherConditions[weatherCon];
            Console.WriteLine("Forecast is {0}.", condition);
            return condition;
        }       
    }
}
