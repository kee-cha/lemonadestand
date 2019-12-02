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
        public void DecreaseCupsInPitcher(Day day, int i)
        {
            while (day.cust[i].willToBuy == true)
            {
                cupsLeftInPitcher--;

                if (cupsLeftInPitcher == 0)
                {

                }
            }
        }
    }
}
