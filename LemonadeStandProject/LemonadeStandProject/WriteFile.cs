using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandProject
{
    class WriteFile
    {
        
        string[] storeTextInRepot = new string[4];
        double[] storeNumberInReport = new double[4];
        public string lemProRepFile;
        
        public void StoreReportInFile(Day day,Stand stand,CashBox cashBox,int dayCount)
        {
            storeTextInRepot[0] = "Number of lemonade cups made  :";
            storeTextInRepot[1] = "Number of lemonade cups sold  :";
            storeTextInRepot[2] = "Expense  :";
            storeTextInRepot[3] = "profit   :";

            storeNumberInReport[0] = stand.numberOfLemCups;
            storeNumberInReport[1] = day.lemonadeCupsSold;
            storeNumberInReport[2] = cashBox.expense;
            storeNumberInReport[3] = cashBox.cashEarned;

            lemProRepFile = @"c:\codecamp\GameReport.txt";

            if (File.Exists(lemProRepFile))
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(lemProRepFile, true))

                {

                    file.WriteLine("Day: " + dayCount);

                    for (int i = 0; i < storeTextInRepot.Length; i++)
                    {

                        file.WriteLine(storeTextInRepot[i] + storeNumberInReport[i]);

                    }

                    file.Close();
                }

            }

            else
            {
                using (System.IO.StreamWriter  file1 = new  System.IO.StreamWriter(lemProRepFile))
                {

                    file1.WriteLine("Day: " + dayCount);

                    for (int i = 0; i < storeTextInRepot.Length; i++)
                    {

                        file1.WriteLine(storeTextInRepot[i] + storeNumberInReport[i]);

                    }

                    file1.Close();
                }
            }

        }


    }
}
