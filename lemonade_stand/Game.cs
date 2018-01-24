using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
     static class Game
    {
        // member variables (HAS A)
        public static Player player;
        public static Wallet wallet;
        //static UserInterface;

        public static List<string> weatherPossibilities; // list of forecasted and actual weather possibilities

        public static Random rnd; 

        public static Day day; // remove this later
        public static Day dayOne;
        public static Day dayTwo;
        public static Day dayThree;
        public static Day dayFour;
        public static Day dayFive;
        public static Day daySix;
        public static Day daySeven;

        public static double runningProfitOrLoss; // (it's $50 different from running balance)



        // constructor (SPAWNER)
        static Game()
        {
            player = new Player();
            wallet = new Wallet();
            //ui = new UserInterface();

            List<string> weatherPossibilities = WeatherPossibilities;

            Random rnd = new Random();

            Day dayOne = new Day();
            Day dayTwo = new Day();
            Day dayThree = new Day();
            Day dayFour = new Day();
            Day dayFive = new Day();
            Day daySix = new Day();
            Day daySeven = new Day();


        }

        // member methods (CAN DO)
        public static void PlayGame()
        {
            UserInterface.WelcomeAndRules(); 
            player.GetName(); 

            wallet.dollarsInWallet = 50;
            runningProfitOrLoss = 0;

            Inventory.amountOfLemons = 0;
            Inventory.amountOfSugarInCups = 0;
            Inventory.amountOfIceBags = 0;


            dayOne.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            dayTwo.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            dayThree.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            dayFour.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            dayFive.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            daySix.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            daySeven.RunDay();
            runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);

            UserInterface.SummarizeWeek();
            UserInterface.SaveFinalScoreOfPlayerToDatabase();
            UserInterface.PrintHighScoresFromAllTime();

        }


        static public double TrackAndPrintRunningWeeklyProfitOrLoss(double runningProfitOrLoss)
        {
            if (day.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss() == 0)
            {

                runningProfitOrLoss = runningProfitOrLoss + 0;
                Console.WriteLine("You hit even. Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + "."); 
                return runningProfitOrLoss;
            }
            if (day.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss() > 0)
            {
                runningProfitOrLoss = runningProfitOrLoss + day.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss();
                Console.WriteLine("Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            if (day.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss() < 0)
            {
                runningProfitOrLoss = runningProfitOrLoss - day.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss();
                Console.WriteLine("Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            else
            {
                return runningProfitOrLoss;
            }
        }

        static public List<string> WeatherPossibilities
        {
            set
            {
                weatherPossibilities.Add("sunny");
                weatherPossibilities.Add("cloudy");
                weatherPossibilities.Add("rainy");
            }
            get
            {
                return weatherPossibilities;
            }
        }

        static public int CountWeatherPossibilities(List<string> weatherPossibilities)
        {
            return weatherPossibilities.Count();
        }



    }
}
