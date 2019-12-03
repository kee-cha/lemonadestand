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
 

        public Weather(int temp, int cond)
        {
            weatherConditions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy"};
            GetDailyTemp(temp);
            GetDailyWeatherCondition(cond);
        }

        public int GetDailyTemp(int rng)
        {
            temperature = rng;
            Console.WriteLine("Temperature is {0}° F.", temperature);
            return temperature;
        }

        public string GetDailyWeatherCondition(int rng)
        {
            int weatherCon = rng;
            condition = weatherConditions[weatherCon];
            Console.WriteLine("Forecast is {0}.", condition);
            return condition;
        }                   
    }
}
