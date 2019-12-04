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
            Console.WriteLine(player.name + "'s Inventory--" + "\n"
            + "Lemons ($0.35 per lemon): " + lemon + "\n"
            + "Sugar Cubes ($0.05 per sugar cube): " + sugar + "\n"
            + "Ice Cubes ($0.01 per ice cube): " + ice + "\n"
            + "Cups ($0.15 per cup): " + cup + "\n");
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
        public static double ShowFinalProfit(Player player)
        {
            double totalProfit = player.wallet.Money - 20;
            Console.WriteLine("Your total profit that you made from your lemonade stand is ${0}.", totalProfit);
            Console.ReadLine();
            return totalProfit;
        }
        public static string MakePitcherDirection()
        {
            Console.WriteLine("Ok, time to make your lemonade." + "\n" + "The amount of each ingredient will make one pitcher of lemonade." + "\n" + "The standard amount to make a balance flavor lemonade is 4 lemons, 4 sugar cubes, and 4 ice cubes." + "\n" + "Each pitcher serves 10 cups of lemonade." + "\n" + "Feel free to change your recipe to add more tartness or sweetness of the drink." + "\n" + "Keep in mind that the amount of ice cubes affects the temperature of the drink." + "\n" + "The current day temperature also will affect the customers of how they like the drink temperature." + "\n");
            string directions = Console.ReadLine();
            return directions;
        }
    }
}
