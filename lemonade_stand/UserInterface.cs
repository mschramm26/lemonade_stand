using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    static class UserInterface
    {
        // member variables (HAS A)


        // constructor (SPAWNER)
        static UserInterface()
        {

        }

        // member methods (CAN DO)



        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Lemonade Stand game!");
            Console.WriteLine("You will play for one week (7 days). Each day, you'll choose how much inventory to buy and how much to sell the lemonade for based on the weather.");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadLine();
        }

        public static void PrintWeatherForecastForDay()
        {
            double forecastWeatherID = Day.GetWeatherForecastForDay();
            Console.WriteLine("The forecast is: " + Game.weatherPossibilities[Convert.ToInt32(forecastWeatherID)] + "."); 
        }

        public static void PrintActualWeatherForDay()
        {
            double actualWeatherID = Day.GetActualWeatherForDay(Weather.forecastWeatherID);
            Console.WriteLine("The forecast is: " + Game.weatherPossibilities[Convert.ToInt32(actualWeatherID)] + "."); 
        }


        public static void PrintInventoryStatus()
        {
            Console.WriteLine("The current inventory status is as follows:");
            Console.WriteLine("Lemons: " + Inventory.ReturnCurrentAmountOfLemons());
            Console.WriteLine("Cups of sugar: " + Inventory.ReturnCurrentAmountOfCupsOfSugar());
            Console.WriteLine("Bags of ice: " + Inventory.ReturnCurrentAmountOfBagsOfIce());
        }

        public static void PrintMoneyInWallet()
        {
            Console.WriteLine("You have $" + Wallet.ContainsMoneyInDollars() + ".");
        }

        public static double ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(double cupsSoldToday)
        {
            double dollarsMadeToday = Game.SellLemonadeToCustomerReturnsNumberOfCups() * Player.SetPriceOfCupOfLemonadeForDay();
            double expensesToday = Day.CalculateDailyExpenses();

            Console.WriteLine("You sold " + cupsSoldToday + " cups today.");
            Console.WriteLine("You made $" + dollarsMadeToday + ".");
            Console.WriteLine("Your expenses today were $" + expensesToday + ".");

            string profitOrLoss;

            double difference = dollarsMadeToday - expensesToday;
            if (difference == 0)
            {
                profitOrLoss = "HIT EVEN";
            }
            if (difference > 0)
            {
                profitOrLoss = "PROFIT";
            }
            if (difference < 0)
            {
                profitOrLoss = "LOSS";
            }
            else
            {
                profitOrLoss = null;
            }
            Console.WriteLine("You had a " + profitOrLoss + " of $" + difference + " today.");
            return difference;
        }



        public static void SummarizeWeek() // figure out this math, etc. 
        {
            Console.WriteLine("Here is a summary of your week:" + "/n");

            Console.WriteLine("DAY 1");
            Console.WriteLine("Beginning balance was X."); 
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X of X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 2");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 3");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 4");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 5");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 6");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

            Console.WriteLine("DAY 7");
            Console.WriteLine("Beginning balance was X.");
            Console.WriteLine("Revenue was X.");
            Console.WriteLine("Expenses were X.");
            Console.WriteLine("You had a X.");
            Console.WriteLine("The running profit or loss is a X of X.");

        }


        public static void PrintHighScoresFromAllTime() // SQL - do this later
        {
            
        }

    }
}
