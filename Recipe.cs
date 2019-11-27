using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Recipe
    {
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

        public int AmountOfLemonsUse()
        {
            Console.WriteLine("How many lemons do you want to use?");
            int lemonAmount = Int32.Parse(Console.ReadLine());
            amountOfLemons += lemonAmount;
            return amountOfLemons;
        }
        public int AmountOfSugarUse()
        {
            Console.WriteLine("How many sugar cubes do you want to use?");
            int sugarAmount = Int32.Parse(Console.ReadLine());
            amountOfSugarCubes += sugarAmount;
            return amountOfSugarCubes;
        }
        public int AmountOfIceUse()
        {
            Console.WriteLine("How many ice cubes do you want to use?");
            int iceCubeAmount = Int32.Parse(Console.ReadLine());
            amountOfIceCubes += iceCubeAmount;
            return amountOfIceCubes;
        }
        public double CostPerCup()
        {
            Console.WriteLine("How much would you like to sell a cup of lemonade for?");
            double price = Int32.Parse(Console.ReadLine());
            pricePerCup = price;
            return pricePerCup;
        }


    }
}
