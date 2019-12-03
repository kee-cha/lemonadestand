using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public static class UserInterface
    {
        public static void DisplayInventory(Player player, int lemon, int sugar, int ice, int cup)
        {
            Console.WriteLine(player.name + "'s Inventory- " + "\n"
            + "Lemons: " + lemon + "\n"
            + "Sugar Cubes: " + sugar + "\n"
            + "Ice Cubes: " + ice + "\n"
            + "Cups: " + cup + "\n");
            Console.ReadLine();
        }
        public static void WelcomeIntro()
        {
            Console.WriteLine("This is your Lemonade Stand. Let's make some money.");
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

        public static int HowManyDaysToSell()
        {
            Console.WriteLine("How many days would you like to sell lemonade?");
            string daysToSell = Console.ReadLine();
            Console.Clear();
            int numOfDays;
            while (!int.TryParse(daysToSell, out numOfDays) || numOfDays < 0)
            {
                Console.WriteLine("Please input a valid number of days to sell.");
                daysToSell = Console.ReadLine();
                Console.Clear();
            }
            return numOfDays;
        }
        public static string GameOver()
        {
            Console.WriteLine("Game over. You are out of money.");
            string youLose = Console.ReadLine();
            return youLose;
        }
        public static string DoneSellingLemonaade()
        {
            Console.WriteLine("Well done. Your days of selling lemonades are now over.");
            string allDone = Console.ReadLine();
            return allDone;
        }
    }
}
