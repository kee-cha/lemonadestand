﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Pitcher pitcher;
        public Recipe recipe;
        

        // constructor (SPAWNER)
        public Player()
        {            
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            recipe = new Recipe();
        }

        // member methods (CAN DO)
        public string GetName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.Clear();
            name = userName.ToUpper();
            return name;
        }
        public double ShowMoney()
        {
            double cash = wallet.Money;
            Console.WriteLine("Money: ${0}",cash);
            return cash;
        }
      
    }
}
