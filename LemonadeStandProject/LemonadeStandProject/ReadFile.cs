using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStandProject
{
    class ReadFile
    {

        
        public void ReadReport(WriteFile writeFile)
        {
            using (StreamReader readFile = File.OpenText(writeFile.lemProRepFile))
            {
                string line = "";
                while ((line = readFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
