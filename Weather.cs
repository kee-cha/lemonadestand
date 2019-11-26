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
            weatherConditions = new List<string>() { "sunny", "rainy", "cloudy", "hazy" };
        }

        public int GetDailyTemp()
        {
            Random temp = new Random();
            temperature = temp.Next(55, 100);
            return temperature;
        }

        public string GetDailyWeatherCondition()
        {
            Random weather = new Random();
            int weatherCon = weather.Next(0, 4);
            condition = weatherConditions[weatherCon];
            return condition;
        }

        public string ShowTemp()
        {
            GetDailyTemp();
            GetDailyWeatherCondition();
            Console.WriteLine(temperature + " degrees Fahrenheit and " + condition);
            weather = Console.ReadLine();
            return weather;
        }
        
    }
}
