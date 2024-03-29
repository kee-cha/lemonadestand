﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Customer
    {
        public string tastePref;
        public string name;
        public bool willToBuy = false;

        public double costOfDrink;
        public Customer(int taste, double rng, int temp, Player player)
        {
            CustomerFlavorPref(taste);
            DrinkPricePref(rng);
            willToBuy = AmountCustomerBuy(temp, player);
        }

        public void CustomerFlavorPref(int taste)
        {
            switch (taste)
            {
                case 0:
                    tastePref = "sweet";
                    break;
                case 1:
                    tastePref = "sour";
                    break;
                case 2:
                    tastePref = "balance";
                    break;
                default:
                    break;
            }
        }
        public void DrinkPricePref(double rng)
        {
            double priceOfCup = rng * 2;
            costOfDrink = priceOfCup;
        }

        public bool AmountCustomerBuy(int temp, Player player)
        {
            if (temp >= 70 && player.recipe.amountOfIceCubes > 4 && (tastePref == player.recipe.drinkTaste || player.recipe.drinkTaste == "balance") && costOfDrink > player.recipe.pricePerCup)
            {

                return true;
            }
            else if (temp < 70 && player.recipe.amountOfIceCubes <= 4 && (tastePref == player.recipe.drinkTaste || player.recipe.drinkTaste == "balance") && costOfDrink > player.recipe.pricePerCup)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
