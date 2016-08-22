using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Inventory
    {
           
        public int lemonInStock;
        public int sugarInStock;
        public int iceInStock;
        public int cupsInStock;

        public Inventory ()
        {
           
            lemonInStock = 0;
            sugarInStock = 0;
            iceInStock = 0;
            cupsInStock = 0;
        }

        public void AddToInventory(Lemon lemon, Sugar sugar, Ice ice, Cup cup)
        {

            lemonInStock += lemon.numberOfLemon;
            sugarInStock += sugar.numberOfSugarPacks;
            iceInStock += ice.numberOfIceCubes;
            cupsInStock += cup.numberOfCups;

        }

        public void CurrentInventory()
        {
            Console.WriteLine("\tLemon   : {0}", lemonInStock);
            Console.WriteLine("\tSugar   : {0}", sugarInStock);
            Console.WriteLine("\tIce     : {0}", iceInStock);
            Console.WriteLine("\tCup     : {0}", cupsInStock);
        }
        public void UpdateInvQuantity(Stand stand)
        {
            lemonInStock -= stand.numberOfLemCups * stand.amountOfLemon;
            sugarInStock -= stand.numberOfLemCups * stand.amountOfSugar;
            iceInStock -= stand.numberOfLemCups * stand.amountOfIce;
            cupsInStock -= stand.numberOfLemCups;
        }

      
             
    }


}
