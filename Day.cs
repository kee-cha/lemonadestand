using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        public List<Customer> cust= new List<Customer>(){};
        public Weather weather;
        public Customer customer;

        public Day(int temp, int cond)
        {
            weather = new Weather(temp, cond);
        }
        public void GenerateCustomer(int count, Random rng, int temp, Player player)
        {
            for (int i = 0; i < count; i++)
            {
                int taste = rng.Next(3);
                double priceOfCup = rng.NextDouble();
                customer = new Customer(taste, priceOfCup, temp, player);
                cust.Add(customer);
            }
        }

        public void CustomerPerWeather(Day currentDay, Random rng, int temp, Player player)
        {
            switch (currentDay.weather.condition.ToLower())
            {
                case "sunny":
                    GenerateCustomer(100,rng,temp, player);
                    break;
                case "rainy":
                    GenerateCustomer(50,rng, temp, player);
                    break;
                case "hazy":
                    GenerateCustomer(70,rng, temp, player);
                    break;
                case "cloudy":
                    GenerateCustomer(80, rng, temp, player);
                    break;
                default:
                    break;
            }
        }
    }
}
