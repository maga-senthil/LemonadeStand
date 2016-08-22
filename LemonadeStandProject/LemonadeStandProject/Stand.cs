using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Stand : IRecipe
    {
        public Inventory inventory;
        public CashBox cashBox;
        public int amountOfLemon;
        public int amountOfSugar;
        public int amountOfIce;
        public int numberOfLemCups;
        public int cupOfLemonade;
        int lemonPerCup;
        int sugarPerCup;
        int icePerCup;
        int minimumCups;
      
        public Stand()
        {
            inventory = new Inventory();
            cashBox = new CashBox();
            numberOfLemCups = 0;
            cupOfLemonade = 0;
        }


        public int AddLemonToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
               amountOfLemon  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                AddLemonToRecipe();
            }
            return amountOfLemon;
        }

        public int AddSugarToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
               amountOfSugar  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                AddSugarToRecipe();
            }
            return amountOfSugar;
        }

        public int AddIceToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
                amountOfIce  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                AddIceToRecipe();
            }
            return amountOfIce;
        }


        public void DisplayRecipe()
        {
            Console.WriteLine("Lemon per cup  : {0}", amountOfLemon);
            Console.WriteLine("Sugar per cup  : {0}", amountOfSugar);
            Console.WriteLine("Ice per cup    : {0}", amountOfIce);
            Console.WriteLine("Lemonade Cups  : {0}", numberOfLemCups);
        }

        public int CheckLemonInventory()
        {
            lemonPerCup = inventory.lemonInStock / amountOfLemon;
            return lemonPerCup;
        }

        public int CheckSugarInventory()
        {
            sugarPerCup = inventory.sugarInStock / amountOfSugar;
            return sugarPerCup;
        }

        public int CheckIceInventory()
        {
            icePerCup = inventory.iceInStock / amountOfIce;
            return icePerCup;
        }

        public int CalMaxCups()
        {

            int[] stock = new[] { lemonPerCup, sugarPerCup, icePerCup, inventory.cupsInStock };
            minimumCups = stock.Min();
            Console.WriteLine("Great Receipe!" );
            Console.WriteLine("Looking at the available inventory & your receipe,");
            Console.WriteLine("The Maximum cups of Lemonade you can make is {0}", minimumCups);
            return minimumCups;
        }

      public int GetRecipe()
        {
            cupOfLemonade = amountOfLemon + amountOfSugar + amountOfIce;
            numberOfLemCups = numberOfLemCups * cupOfLemonade;
            return numberOfLemCups;
        }


        public int CupsWantTo()
        {
            try
            {
                Console.Write("How many cups do you want to prepare?");
                string numberOfCupsReq = Console.ReadLine();
                numberOfLemCups = Convert.ToInt16(numberOfCupsReq);
            }
            catch
            {
                Console.WriteLine("Enter proper value(Accept only numbers):");
                CupsWantTo();
            }
            return numberOfLemCups;
        }

        public void CheckMaxCup()
        {

            if (numberOfLemCups <= minimumCups)
            {
                minimumCups = numberOfLemCups;
            }
            else
            {
                Console.WriteLine("Maximum cups of Lemonade you can make is {0}", minimumCups);
                CupsWantTo();
            }

        }



            
        
    }


}
