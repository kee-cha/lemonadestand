using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Pitcher
    {
        public int cupsLeftInPitcher;
        public int pitcher;
        public Recipe recipe;
        public int custCounter;

        public Pitcher()
        {
            cupsLeftInPitcher = 10;
            recipe = new Recipe();

        }
        public void DecreaseCupsInPitcher(Day day, int i, Player player)
        {
            if (day.cust[i].willToBuy == true)
            {
                if (cupsLeftInPitcher == 0)
                {
                    if (player.inventory.lemons.Count >= recipe.amountOfLemons && player.inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && player.inventory.iceCubes.Count >= recipe.amountOfSugarCubes)
                    {
                        cupsLeftInPitcher = 10;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough ingredients to make another pitcher.");
                    }
                }
                else
                {
                    custCounter++;
                    cupsLeftInPitcher--;
                    player.wallet.MakeMoneyFromSale(player);
                }
            }
        }
        public bool CheckOutOfCups(Player player)
        {
            if (player.inventory.cups.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
