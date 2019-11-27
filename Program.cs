using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface.WelcomeIntro();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.ShowItems();
            Store store = new Store();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            Console.Clear();
            player.inventory.ShowItems();
            



        }
    }
}
