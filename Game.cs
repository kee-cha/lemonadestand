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
        public int currentDay;
        public Store store;

        public Game()
        {
            currentDay = 0;
            days = new List<Day>();
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
            store.SellLemons(player);
        }
      
    }
}
