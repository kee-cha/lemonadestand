using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();

        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        public void ShowItems(Player player)
        {
            UserInterface.DisplayInventory(player, lemons.Count, sugarCubes.Count, iceCubes.Count, cups.Count);
        }

        public void TakeLemonsOutInventory(Player player)
        {
            for (int i = 0; i < player.recipe.amountOfLemons; i++)
            {
                lemons.RemoveAt(0);
            }
        }

        public void TakeSugarCubesOutInventory(Player player)
        {
            for (int i = 0; i < player.recipe.amountOfSugarCubes; i++)
            {
                sugarCubes.RemoveAt(0);
            }
        }

        public void TakeIceCubesOutInventory(Player player)
        {
            for (int i = 0; i < player.recipe.amountOfIceCubes; i++)
            {
                iceCubes.RemoveAt(0);
            }
        }
    }
}
