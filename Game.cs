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

        public Game()
        {
            currentDay = new Day();
            days = new List<Day>() { };
            player = new Player();
            store = new Store();
        }

        public void AdddDaysToList()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }

        public void RunGame()
        {
            NewDay();
            UserInterface.WelcomeIntro();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.ShowMoney();
            player.inventory.ShowItems();
            Store store = new Store();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            Console.Clear();
            player.ShowMoney();
            player.inventory.ShowItems();
        }
        public void NewDay()
        {
            currentDay = days[0];
            Console.WriteLine(currentDay);
            Console.ReadLine();
        }
    }
}
