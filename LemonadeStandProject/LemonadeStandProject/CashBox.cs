using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class CashBox
    {
        public double profit;
        public double expense;
        double amountToLemSold;
        public double netProfit;


        public double profitForTheDay(Day day,Sell sell)
        {
            amountToLemSold = day.lemonadeCupsSold * sell.pricePerCup;

            return amountToLemSold;
        }

        public double CalculateToRemainCash(Player player)
        {
            expense = player.initialCashBalance  - player.startAmount;
            profit = amountToLemSold - expense;

            return profit;
        }

        public double CalNetProfit()
        {
            netProfit += profit;
            return netProfit;
        }

        public void DisplayNetProfit(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("Weekly profit  : {0}",netProfit);
            Console.WriteLine("Cash Remaining : {0}",player.startAmount);
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************************");
        }
    }
}
