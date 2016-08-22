using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Buy
    {
       public lemon lemon;
       public Sugar sugar;
       public Ice ice;
       public Cup cup;
       public double totalPrice;

        public double lemonPrice;
        public double sugarPrice;
        public double icePrice;
        public double cupPrice;

        public Buy()
        {
            lemon = new lemon();
            sugar = new Sugar();
            ice = new Ice();
            cup = new Cup();

            lemonPrice = 0.25;
            sugarPrice = 0.50;
            icePrice = 0.10;
            cupPrice = 0.05;

        }

        public void DisplayIngPrice()
        {
            Console.WriteLine("Cost for Each Item:");
            Console.WriteLine("\tLemon  :{0:0.00}", lemonPrice);
            Console.WriteLine("\tSugar  :{0:0.00}", sugarPrice);
            Console.WriteLine("\tIce    :{0:0.00}", icePrice);
            Console.WriteLine("\tCup    :{0:0.00}", cupPrice);
        }
        public void BuyIngrediant()
        {
            Console.Write("\tlemon   : ");

            try 
            {
                string item = Console.ReadLine();
               lemon.numberOfLemon  = int.Parse(item);
            }
            catch
            {
                Console.WriteLine("EnterProper value:( accept only numbers)");
               
            }

            Console.Write("\tSugar   : ");
            try
            {
                string item = Console.ReadLine();
               sugar.numberOfSugarPacks = int.Parse(item);
            }
            catch
            {

                Console.WriteLine("EnterProper value:( accept only numbers)");
                
            }
            Console.Write("\tIce     : ");

            try
            {
                string item = Console.ReadLine();
                ice.numberOfIceCubes = int.Parse(item);
            }
            catch
            {

                Console.WriteLine("EnterProper value:( accept only numbers)");
               
            }
            Console.Write("\tCup     : ");
       

            try
            {
                string item = Console.ReadLine();
                cup.numberOfCups = int.Parse(item);
            }
            catch
            {

                Console.WriteLine("EnterProper value:( accept only numbers)");
                
            }

        }

       

        public double  CheckIngPrice(Player player)
        {

            totalPrice = (lemon.numberOfLemon * lemonPrice) + (sugar.numberOfSugarPacks * sugarPrice) + (ice.numberOfIceCubes * icePrice) + (cup.numberOfCups *cupPrice);
          

            if (totalPrice > player.startAmount)
            {
                Console.WriteLine("Oops! you don't have so much money yet!; buy again...");
                BuyIngrediant();
                CheckIngPrice(player);
            }
         
                return totalPrice;
            
           
        }
        

    }
}
