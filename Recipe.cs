using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Recipe
    {
        public string drinkTaste;
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0;
        }
        public void DetermineTaste()
        {
            int tasteDif = amountOfSugarCubes - amountOfLemons;
            if (tasteDif > 0)
            {
                drinkTaste = "sweet";
            }
            else if (tasteDif < 0)
            {
                drinkTaste = "sour";
            }
            else
            {
                drinkTaste = "balance";
            }
        }
        public void AmountOfLemonsUse(Player player)
        {
            Console.WriteLine("How many lemons do you want to use?");
            var lemonAmount = Console.ReadLine();
            while (!int.TryParse(lemonAmount, out amountOfLemons) || amountOfLemons < 0 || amountOfLemons > player.inventory.lemons.Count)
            {
                Console.WriteLine("Please input a valid amount of lemons to use.");
                lemonAmount = Console.ReadLine();
            }

            player.inventory.TakeLemonsOutInventory(player);

        }

        public void AmountOfSugarUse(Player player)
        {
            Console.WriteLine("How many sugar cubes do you want to use?");
            var sugar = Console.ReadLine();
            while (!int.TryParse(sugar, out amountOfSugarCubes) || amountOfSugarCubes < 0 || amountOfSugarCubes > player.inventory.sugarCubes.Count)
            {
                Console.WriteLine("Please input a valid amount of sugar cubes to use.");
                sugar = Console.ReadLine();
            }
            player.inventory.TakeSugarCubesOutInventory(player);
        }
        public void AmountOfIceUse(Player player)
        {
            Console.WriteLine("How many ice cubes do you want to use?");
            var iceCubeAmount = Console.ReadLine();
            while (!int.TryParse(iceCubeAmount, out amountOfIceCubes) || amountOfIceCubes < 0 || amountOfIceCubes > player.inventory.iceCubes.Count)
            {
                Console.WriteLine("Please input a valid amount of ice cubes to use.");
                iceCubeAmount = Console.ReadLine();
            }
            player.inventory.TakeIceCubesOutInventory(player);
        }
        public void CostPerCup()
        {
            Console.WriteLine("How much would you like to sell a cup of lemonade for?");
            var price = Console.ReadLine();
            while (!double.TryParse(price, out pricePerCup) || pricePerCup < 0)
            {
                Console.WriteLine("Please input a valid price for each cup of lemonade to sell.");
                price = Console.ReadLine();
            }
        }
        public void AskPlayerForRecipe(Player player)
        {
            AmountOfLemonsUse(player);
            AmountOfSugarUse(player);
            AmountOfIceUse(player);
            CostPerCup();
            DetermineTaste();
        }

    }
}
