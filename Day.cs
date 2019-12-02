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
        public int customers = 0;
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
                int priceOfCup = rng.Next(8);
                customer = new Customer(taste, priceOfCup, temp, player);
                cust.Add(customer);
                customers++;
                
            }
        }

        public void CustomerPerWeather(Day currentDay, Random rng, int temp, Player player)
        {
            switch (currentDay.weather.condition.ToLower())
            {
                case "sunny":
                    GenerateCustomer(10,rng,temp, player);
                    break;
                case "rainy":
                    GenerateCustomer(5,rng, temp, player);
                    break;
                case "hazy":
                    GenerateCustomer(7,rng, temp, player);
                    break;
                case "cloudy":
                    GenerateCustomer(8, rng, temp, player);
                    break;
                default:
                    break;
            }
        }
    }
}
