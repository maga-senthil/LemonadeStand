using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Sell
    {

        public double pricePerCup;

        public void SalePrice()
        {
            try
            {
                Console.Write("Now its time to think selling price for your lemonade :$");
                string price = Console.ReadLine();
                pricePerCup = Convert.ToDouble(price);
            }
            catch
            {
                Console.WriteLine("Enter proper value(Accept only Numbers ");
                SalePrice();
            }

            Console.WriteLine("Selling Price per Cup  :${0:0.00}", pricePerCup);
        }

    }
}

