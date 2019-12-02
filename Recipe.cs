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
        public void AmountOfLemonsUse()
        {
            Console.WriteLine("How many lemons do you want to use?");
            int lemonAmount = Int32.Parse(Console.ReadLine());
            amountOfLemons = lemonAmount;
        }
        public void AmountOfSugarUse()
        {
            Console.WriteLine("How many sugar cubes do you want to use?");
            int sugarAmount = Int32.Parse(Console.ReadLine());
            amountOfSugarCubes = sugarAmount;
        }
        public void AmountOfIceUse()
        {
            Console.WriteLine("How many ice cubes do you want to use?");
            int iceCubeAmount = Int32.Parse(Console.ReadLine());
            amountOfIceCubes = iceCubeAmount;
        }
        public void CostPerCup()
        {
            Console.WriteLine("How much would you like to sell a cup of lemonade for?");
            double price = Convert.ToDouble(Console.ReadLine());
            pricePerCup = price;
        }
        public void AskPlayerForRecipe()
        {
            AmountOfLemonsUse();
            AmountOfSugarUse();
            AmountOfIceUse();
            CostPerCup();
            DetermineTaste();
        }

    }
}
