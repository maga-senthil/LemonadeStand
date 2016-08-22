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


        public int GetLemToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
               amountOfLemon  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                GetLemToRecipe();
            }
            return amountOfLemon;
        }

        public int GetSugToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
               amountOfSugar  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                GetSugToRecipe();
            }
            return amountOfSugar;
        }

        public int GetIceToRecipe()
        {
            try
            {
                string getItem = Console.ReadLine();
                amountOfIce  = Convert.ToInt32(getItem);
            }
            catch
            {
                Console.WriteLine("Enter Proper value:( accept only numbers)");
                GetIceToRecipe();
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

        public int CheckLemInv()
        {
            lemonPerCup = inventory.lemonInStock / amountOfLemon;
            return lemonPerCup;
        }

        public int CheckSugInv()
        {
            sugarPerCup = inventory.sugarInStock / amountOfSugar;
            return sugarPerCup;
        }

        public int CheckIceInv()
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



            //public void PlayerPickLemon(Inventory inventory)
            //{
            //    Console.Write("How many lemons you want :");
            //    string amountOfLemonReq = Console.ReadLine();


            //    if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfLemonReq, "^[0-9]"))
            //    {
            //        Console.WriteLine("Enter proper value(Accept only numbers):");
            //        PlayerPickLemon(inventory);

            //    }
            //    else
            //    {
            //        amountOfLemon = Convert.ToInt32(amountOfLemonReq);
            //        lemonPerCup = inventory.lemonInStock / amountOfLemon;
            //    }

            //}


            //public void PlayerPickSugar(Inventory inventory)
            //{
            //    Console.Write("How many suger packs you want :");
            //    string amountOfSugarReq = Console.ReadLine();


            //    if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfSugarReq, "^[0-9]"))
            //    {
            //        Console.WriteLine("Enter proper value(Accept only numbers):");
            //        PlayerPickSugar(inventory);

            //    }
            //    else
            //    {
            //        amountOfSugar = Convert.ToInt32(amountOfSugarReq);
            //        sugarPerCup = inventory.sugarInStock / amountOfSugar;
            //    }


            // }



            //public void PlayerPickIce(Inventory inventory)
            //{ 

            //    Console.Write("How many ice cubes you want :");
            //    string amountOfIceReq = Console.ReadLine();


            //    if (!System.Text.RegularExpressions.Regex.IsMatch(amountOfIceReq, "^[0-9]"))
            //    {
            //        Console.WriteLine("Enter proper value(Accept only numbers):");
            //        PlayerPickIce(inventory);

            //    }
            //    else
            //    {
            //        amountOfIce = Convert.ToInt32(amountOfIceReq);
            //        icePerCup = inventory.iceInStock / amountOfIce;
            //    }

            //}


        
    }


}
