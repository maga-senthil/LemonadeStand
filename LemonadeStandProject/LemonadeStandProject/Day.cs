using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
   class Day
    {
        List<Customer> customerList;
        string displaytext;
        public int lemonadeCupsSold;
        public Weather weather;
        public int customerPerDay;
        public Report report;
        public WriteFile writeFile;
        public ReadFile readFile;
        public Day ()
        {
            weather= new Weather();
            report = new Report();
            writeFile = new WriteFile();
            readFile = new ReadFile();
            readFile = new ReadFile();
            lemonadeCupsSold  = 0;
            customerList = new List<Customer> ();
            customerPerDay = 0;

        }

      public int Demand(Weather weather)
        {
            if (weather.perception == "Sunny" || weather.actualTemperature > 90)
            {
                Console.WriteLine("Hi! Its a perfect day, you can sell more lemonade!!!!");
                Console.WriteLine("So, Invest more money & buy more items.");
                customerPerDay = 100;
                Console.WriteLine("Expected customers :{0}", customerPerDay);
            }
            else if (weather.perception == "Cloudy" || weather.actualTemperature < 90)
            {
                Console.WriteLine("OK, It's not too bad at all.");
                Console.WriteLine("You can still sell a lot of Lemonade");
                customerPerDay = 75;
                Console.WriteLine("Expected customers :{0}", customerPerDay);

            }
            else if (weather.perception == "rainy")
            {
                Console.WriteLine("Opps!!! I don,t think we can sell many lemonade today.");
                Console.WriteLine("Be Carefull with your investment.");
                customerPerDay = 30;
                Console.WriteLine("Expected customers :{0}", customerPerDay);

            }
            
            return customerPerDay;
        }


        public List<Customer> GetCustomer(int numberOfCustomers, Stand stand)
        {

            Random random = new Random();

            for (int i = 0; i < numberOfCustomers; i++)
            {
                int rnd = random.Next(1, 5);
                if (rnd == 1 || rnd == 3)
                {
                    displaytext = "passes by & didn't buy lemonade.";
                }
                else
                {
                    displaytext = "bought lemonade. ";
                    lemonadeCupsSold += 1;
                }

                Customer customer = new Customer("customer" + " " + i + " " + displaytext);

                if (stand.numberOfLemCups > lemonadeCupsSold)
                {
                    customerList.Add(customer);

                }
                else
                {
                    break;

                }

            }
            return customerList;
        }

        public void DisplayCustomers(Player player)
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.name);
            }
            Console.WriteLine("{0} customers bought lemonade", lemonadeCupsSold);

            if (player.stand.numberOfLemCups == lemonadeCupsSold)
            {
                Console.WriteLine("SOLD OUT");
            }
        }
    }
}
