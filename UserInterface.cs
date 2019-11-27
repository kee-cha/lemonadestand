using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public static class UserInterface
    {
        public static void DisplayInventory(int lemon, int sugar, int ice, int cup)
        {
            Console.WriteLine("Your Inventory" + "\n"
            + "Lemons: " + lemon + "\n"
            + "Sugar Cubes: " + sugar + "\n"
            + "Ice Cubes: " + ice + "\n" 
            + "Cups: " + cup + "\n");
            Console.ReadLine();
        }
        public static void WelcomeIntro()
        {
            Console.WriteLine("Oh No! While riding your bike, a stray dog ran in front of you causing you to steer away and hitting a tree.  Thank goodness you are not hurt but your bike is now damaged.  Unfortunately, you only have $20 and that is not enough funds to repair it.  You need your bike to get to your new job that starts in 7 days.  Well, to make some money, you decide to start a lemonade stand.  You have 7 days to raise as much money for the repairs but to start your lemonade business, you will need to buy some ingredients.  Make sure to pay attention to the temperature and forecast as that will affect the amonut of customers that will buy that day.  Good Luck.");
            Console.ReadLine();
            Console.Clear();
        }
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
    }
}
