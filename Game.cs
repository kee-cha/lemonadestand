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
        public bool outOfCup;
        public double beginMoney;

        public Game()
        {
            days = new List<Day>() { };
            store = new Store();
            player = new Player();
        }
        public void RunGame()
        {
            UserInterface.WelcomeIntro();
            player.GetName();
            numOfDays = UserInterface.HowManyDaysToSell();
            ShowForecastForAmountOfDays();
            for (int i = 0; i < numOfDays; i++)
            {
                if (player.wallet.Money == 0)
                {
                    UserInterface.GameOver();
                }
                else
                {
                    InitializCurrentDay(i);
                    beginMoney = player.ShowMoney();
                    player.inventory.ShowItems(player);
                    store.BuyItems(player);
                    Console.Clear();
                    Console.WriteLine("Today is " + newTemp + "°F and " + currentDay.weather.condition);
                    Console.ReadLine();
                    player.ShowMoney();
                    player.inventory.ShowItems(player);
                    UserInterface.MakePitcherDirection();
                    player.recipe.AskPlayerForRecipe(player);
                    currentDay.CustomerPerWeather(currentDay, randomNum, newTemp, player);
                    for (int j = 0; j < currentDay.cust.Count; j++)
                    {
                        outOfCup = player.pitcher.CheckIfOutOfCups(player);
                        if (outOfCup == true)
                        {
                            break;
                        }
                        else
                        {
                            player.pitcher.DecreaseCupsInPitcher(currentDay, j, player);
                        }
                    }
                    player.ShowMoney();
                    player.ShowProfit();
                    Console.WriteLine("{0} customers bought lemonade.", player.pitcher.custCounter);
                    player.inventory.ShowItems(player);
                    Console.ReadLine();
                    Console.Clear();
                    player.pitcher.custCounter = 0;
                    player.wallet.profit = 0;
                    if (i == (numOfDays - 1))
                    {
                        UserInterface.DoneSellingLemonaade();
                        Console.Clear();
                        player.ShowMoney();
                        player.wallet.DailyProfit(player);
                    }
                }
            }
            UserInterface.ShowFinalProfit(player);

        }
        public void ShowForecastForAmountOfDays()
        {
            for (int i = 0; i < numOfDays; i++)
            {
                Console.WriteLine("Day: " + (i + 1));
                Day day = new Day(randomNum.Next(55, 95), randomNum.Next(0, 4));
                days.Add(day);
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void InitializCurrentDay(int i)
        {
            currentDay = days[0];
            switch (randomNum.Next(2))
            {
                case 0:
                    newTemp = currentDay.weather.temperature + 3;
                    break;
                case 1:
                    newTemp = currentDay.weather.temperature - 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Day " + (i + 1) + " current weather: " + newTemp + "°F and " + currentDay.weather.condition);
            Console.ReadLine();
            days.RemoveAt(0);
        }
    }
}
