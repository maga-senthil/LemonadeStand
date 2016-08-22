using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandProject
{
    class Report
    {
        public void DisplayReport(Day day, Stand stand, CashBox cashBox ,int daycount)
        {
            Console.WriteLine("\t\t *****LEMONADE SALES REPOT FOR THE DAY***** ");
            Console.Write("Day : {0}     ", daycount);
            
            Console.WriteLine("Number of lemonade cups made  :{0}", stand.numberOfLemCups);
            Console.WriteLine("Number of lemonade cups sold  :{0}", day.lemonadeCupsSold);

            Console.WriteLine("Expenses  :{0}", cashBox.expense);
            Console.WriteLine("Profit    :{0}", cashBox.cashEarned);
            
        }

       
     
       

    }
}
