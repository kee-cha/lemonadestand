using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;

        }

        public double PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            Console.WriteLine("Money left: S{0}", money);
            Console.ReadLine();
            return money;
        }

        public void MakeMoneyFromSale(Customer customer, Player player)
        {
            if (customer.willToBuy == true)
            {
                money += player.recipe.pricePerCup;
            }
        }
    }
}
