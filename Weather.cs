using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions;

        public Weather()
        {
            weatherConditions = new List<string>() { "sunny", "rainy", "cloudy", "hazy" };
        }


        public void GetDailyTemp()
        {
            Random temp = new Random();
            temperature = temp.Next(55, 100);
            Console.WriteLine(temperature + "degrees Fahrenheit");
            Console.ReadLine();
        }

        public void GetDailyWeatherCondition()
        {
            Random weather = new Random();
            int weatherCon = weather.Next(0, 4);
            condition = weatherConditions[weatherCon];
            Console.WriteLine(condition);
            Console.ReadLine();
        }

        public void ShowTemp()
        {
            GetDailyTemp();
            GetDailyWeatherCondition();
        }
        
    }
}
