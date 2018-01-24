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
        //public Day day;
        //public Wallet wallet;
        //public Lemons lemons;
        //public Sugar sugar;
        //public Ice ice;

        // constructor (SPAWNER)
        static UserInterface()
        {

        }

        // member methods (CAN DO)

        public static void WelcomeAndRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand game!");
            Console.WriteLine("You will play for one week (7 days). Each day, you'll choose how much inventory to buy and how much to sell the lemonade for based on the weather.");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadLine();
        }

        public static void PrintWeatherForecastForDay()
        {
            Console.WriteLine("The forecast is: " + Day.GetActualWeatherForecastForDay() + "."); // have to tell it which day to look in - iterate? assign dayID property?
        }

        public static void PrintActualWeatherForDay()
        {
            Console.WriteLine("The forecast is: " + Day.GetActualWeatherForDay() + "."); // have to tell it which day to look in - iterate? assign dayID property?
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
            Console.WriteLine("You have $" + Game.wallet.ContainsMoneyInDollars() + ".");
        }



        public static void SummarizeWeek() // figure out this math, etc. ONLY ON DAY 7
        {
            Console.WriteLine("Here is a summary of the week:");
            Console.WriteLine("/n");

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

        public static void SaveFinalScoreOfPlayerToDatabase() // SQL - do this later
        {
            
        }

        public static void PrintHighScoresFromAllTime() // SQL - do this later
        {
            
        }

    }
}
