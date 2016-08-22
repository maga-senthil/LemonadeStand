using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Game
    {
        Day day;
        Player player;
        public int startDay;

        public Game()
        {
            startDay = 0;
            player = new Player();
            day = new Day();
        }

        public int AddDay()
        {
            startDay += 1;
            return startDay;
        }
        public void RunGame()
        {
            AboutGame.DisplayAboutGame();
            Console.WriteLine("\t\tWelcome to LemonadeStand Game");
            player.CheckPlayerName();
            player.ChooseDays();

            while (startDay < player.daysWantToPlay)
            {
                day = new Day();
                AddDay();
                Console.WriteLine("Day : {0}    ", startDay);

                Console.WriteLine("        Weather");
                day.weather.DisplayPredictedWeather();
                day.weather.DisplayActualWeather();
                Console.WriteLine();
                day.Demand(day.weather);
                player.StartAmountOfGame();
                Console.WriteLine("You're going to start the business with ${0:00.00}.", player.startAmount);
                player.buy.DisplayIngPrice();
                Console.WriteLine("Your Current Inventory:");
                player.stand.inventory.CurrentInventory();

                Console.WriteLine("Buy Ingrediants:");

                player.buy.BuyIngrediant();
                player.buy.CheckIngPrice(player);

                player.stand.inventory.AddInvQuantity(player.buy.lemon, player.buy.sugar, player.buy.ice, player.buy.cup);

                player.UpdateAmount(player.buy);

                Console.WriteLine("Now you are ready to prepare lemonade!");
                Console.WriteLine("You can use your own lemonade Recipe!");
                Console.Write("How many lemons do you want to add per cup?: ");
                player.stand.GetLemToRecipe();
                Console.Write("How many sugarpacks do you want to add per cup?: ");
                player.stand.GetSugToRecipe();
                Console.Write("How many iceCubes do you want to add per cup?: ");
                player.stand.GetIceToRecipe();
                player.stand.CheckLemInv();
                player.stand.CheckSugInv();
                player.stand.CheckIceInv();
                player.stand.CalMaxCups();
                player.stand.CupsWantTo();
                player.stand.CheckMaxCup();
                player.sell.SalePrice();
                player.stand.inventory.UpdateInvQuantity(player.stand);
                player.stand.DisplayRecipe();
                day.GetCustomer(day.customerPerDay, player.stand);
                day.DisplayCustomers(player);
                player.stand.cashBox.profitForTheDay(day, player.sell);
                player.stand.cashBox.CalculateToRemainCash(player);
                day.report.DisplayReport(day, player.stand, player.stand.cashBox, startDay);
                day.writeFile.StoreReportInFile(day, player.stand, player.stand.cashBox, startDay);
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            startDay++;
          
            day.readFile.ReadReport(day.writeFile);

        }
    }

}


    
