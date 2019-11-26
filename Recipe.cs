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

        public int MakeRecipe()
        {
            Console.WriteLine("How many lemons do you want to use?");
            int lemonAmount = Int32.Parse(Console.ReadLine());
            amountOfLemons += lemonAmount;
            Console.WriteLine(amountOfLemons);
            Console.ReadLine();
            return amountOfLemons;
        }
    }
}
