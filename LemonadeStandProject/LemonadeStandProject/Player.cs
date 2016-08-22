using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Player
    {
        public Buy buy;
        public Stand stand;
        public Sell sell;
        string player;
        public string playerName;
        public int daysWantToPlay;
        public double startAmount;
        int getDays;
        public double initialCashBalance;

        public Player()
        {
           buy = new Buy();
           stand = new Stand();
           sell = new Sell();
           startAmount = 0;
        }


        public void GetPlayerName()
        {
            CheckPlayerName();
            Console.WriteLine("Player name is {0}", playerName);
        }

        public void CheckPlayerName()
        {
            Console.Write("Enter the Player name  : ");
            player  = Console.ReadLine();
            if (!System.Text.RegularExpressions.Regex.IsMatch(player, "^[a-zA-Z]"))
            {
                Console.WriteLine("Enter your name properly(Accept only alphabets):");
                CheckPlayerName();
                            
            }
            else
            {
                playerName = player;
            }
           
            
        }

        public void ChooseDays()
        {
           
            try
            {
                Console.Write("Days to play: 7 or 14 or 21 : ");
                string toPlay = Console.ReadLine();
                getDays = Convert.ToInt32(toPlay);
            }
            catch
            {
                Console.WriteLine("Choose proper value:");
                ChooseDays();
            }

                     
           if (getDays == 7 || getDays  == 14 || getDays  == 21)
            {

                daysWantToPlay = getDays;
            }
            else
            {

                Console.WriteLine("Choose proper value:");
                ChooseDays();
            }
        }
        public double StartAmountOfGame()
        {
            startAmount += 100;
            initialCashBalance = startAmount;
            return startAmount;
        }

        public double UpdateAmount(Buy buying)
        {
            startAmount -=buying.totalPrice;
            Console.WriteLine("Cash spent      :{0}",buying.totalPrice);
            Console.WriteLine("Cash remaining  : {0}",startAmount);
            return startAmount;
        }       

        
       
    }
}
