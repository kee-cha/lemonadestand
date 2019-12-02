using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Game
    {
        public Player player;
        public List<Day> days;
        public Day currentDay;
        public Store store;
        public int numOfDays;
        public Random randomNum = new Random();
        public int newTemp;
     

        public Game()
        {            
            days = new List<Day>() { };
            player = new Player();
            store = new Store();            
        }        
        public void RunGame()
        {
            //UserInterface.WelcomeIntro();
            numOfDays = UserInterface.HowManyDaysToSell();
            AdddDaysToList();
            InitializCurrentDay();
            //Player player = new Player();
            //Inventory inventory = new Inventory();
            //player.inventory.ShowItems();
            //Store store = new Store();
            //store.SellLemons(player);
            //store.SellSugarCubes(player);
            //store.SellIceCubes(player);
            //store.SellCups(player);
            //Console.Clear();
            //player.ShowMoney();
            //player.inventory.ShowItems();
            player.recipe.AskPlayerForRecipe();
            currentDay.CustomerPerWeather(currentDay, randomNum, newTemp, player);
            for (int i = 0; i < currentDay.cust.Count; i++)
            {
                Console.WriteLine(currentDay.cust[i].willToBuy);
                Console.WriteLine(currentDay.cust[i].costOfDrink + " " + currentDay.cust[i].tastePref);
            }
            Console.WriteLine(currentDay.customers);
            Console.ReadLine();
        }
        public void AdddDaysToList()
        {
            for (int i = 0; i < numOfDays; i++)
            {
                Console.WriteLine("Day: " +(i+1)); 
                Day day = new Day(randomNum.Next(55, 95), randomNum.Next(0, 4));
                days.Add(day);
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();
        }
        
        public void InitializCurrentDay()
        {
            currentDay = days[0];
            switch (randomNum.Next(2))
            {
                case 1:
                    newTemp = currentDay.weather.temperature + 5;
                    break;
                case 0:
                    newTemp = currentDay.weather.temperature - 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Today is " + newTemp + "°F and " + currentDay.weather.condition);
            Console.ReadLine();
            days.RemoveAt(0);
        }
    }
}
