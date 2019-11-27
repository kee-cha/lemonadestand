using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {
        public int lemonPref;
        public int sugarPref;
        public int icePref;
        public List<string> names;
        public string name;

        public Customer()
        {
            names = new List<string>() { "Mike", "Adam","Chris","Erin","Houa","Chong","Bryce","Elias","Archana","Aaron","Matt","Shalini","Parker"};
        }

        public void CustomerPref()
        {

        }
    }
}
