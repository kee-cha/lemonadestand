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
            
            //Weather weather = new Weather();
            //weather.ShowTemp();
            //Wallet moolah = new Wallet();
            //double change = moolah.PayMoneyForItems(10);
            //Console.WriteLine(change);
            //Console.ReadLine();
            UserInterface.GetNumberOfItems("lemons");
            Game game = new Game();
            game.player.getName();
            game.gameRun();
            Recipe recipe = new Recipe();
            recipe.MakeRecipe();
        }
    }
}
