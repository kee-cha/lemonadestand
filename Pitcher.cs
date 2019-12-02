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

        public Pitcher()
        {
            cupsLeftInPitcher = 10;
            
        }
        public void DecreaseCupsInPitcher(Customer customer,int temp, Player player)
        {
            while (customer.AmountCustomerBuy(temp, player) == true)
            {
                cupsLeftInPitcher--;
            }
        }
    }
}
