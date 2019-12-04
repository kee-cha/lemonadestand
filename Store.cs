using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Store
    {
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        public Store()
        {
            pricePerLemon = .35;
            pricePerSugarCube = .05;
            pricePerIceCube = .01;
            pricePerCup = .15;
        }

        public void SellLemons(Player player)
        {
            int lemonsToPurchase;
            double transactionAmount;
            do
            {
                lemonsToPurchase = UserInterface.GetNumberOfItems("lemons");
                transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);
                if (player.wallet.Money >= transactionAmount)
                {
                    player.wallet.PayMoneyForItems(transactionAmount);
                    player.inventory.AddLemonsToInventory(lemonsToPurchase);
                    break;
                }
            } while (transactionAmount > player.wallet.Money);
        }

        public void SellSugarCubes(Player player)
        {
            int sugarToPurchase;
            double transactionAmount;
            do
            {
                sugarToPurchase = UserInterface.GetNumberOfItems("sugar");
                transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddSugarCubesToInventory(sugarToPurchase);
                    break;
                }
            } while (transactionAmount > player.wallet.Money);
        }

        public void SellIceCubes(Player player)
        {
            int iceCubesToPurchase;
            double transactionAmount;
            do
            {
                iceCubesToPurchase = UserInterface.GetNumberOfItems("ice cubes");
                transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
                    break;
                }
            } while (transactionAmount > player.wallet.Money);
        }


        public void SellCups(Player player)
        {
            int cupsToPurchase;
            double transactionAmount;
            do
            {
                cupsToPurchase = UserInterface.GetNumberOfItems("cups");
                transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);
                if (player.wallet.Money >= transactionAmount)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddCupsToInventory(cupsToPurchase);
                    break;
                }
            } while (transactionAmount > player.wallet.Money);
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }

        public void BuyItems(Player player)
        {
            SellLemons(player);
            SellSugarCubes(player);
            SellIceCubes(player);
            SellCups(player);
        }
    }
}
