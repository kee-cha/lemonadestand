﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        
        public Weather weather;
        public List<Customer> customer;

        public Day()
        {
            weather = new Weather();
            customer = new List<Customer>();
        }

        public void AmountOfCustomer()
        {   

            for(int i = 0; i < customer.Count; i++)
            {
                

            }
        }
    }
}
