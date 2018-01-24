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
        public static double numberOfDaysToPlay = 7;
        public static Wallet wallet;

        public static List<string> weatherPossibilities;
        public static List<object> daysInGame;

        public static Random rnd;

        public static Day day;
        //public static Day dayTwo;
        //public static Day dayThree;
        //public static Day dayFour;
        //public static Day dayFive;
        //public static Day daySix;
        //public static Day daySeven;

        public static double cupsSoldToday;
        public static double cupsSoldOnDayCounter;

        public static double runningProfitOrLoss; // (it's $50 different from running balance)



        // constructor (SPAWNER)
        static Game()
        {
            wallet = new Wallet();

            List<string> weatherPossibilities = WeatherPossibilities;
            List<object> daysInGame = new List<object>();

            Random rnd = new Random();

            Day day = new Day();


        }

        // member methods (CAN DO)
        public static void PlayGame()
        {
            UserInterface.WelcomeAndRules();
            string playerName = Player.EnterName();

            wallet.dollarsInWallet = 50;
            runningProfitOrLoss = 0;

            Inventory.amountOfLemons = 0;
            Inventory.amountOfSugarInCups = 0;
            Inventory.amountOfIceBags = 0;


            foreach(object day in daysInGame)
            {
                cupsSoldToday = Game.day.RunDay();
                runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);
            }



            UserInterface.SummarizeWeek();

            double finalScore;
            finalScore = wallet.dollarsInWallet;

            SaveFinalScoreOfPlayerToDatabase(finalScore);
            UserInterface.PrintHighScoresFromAllTime();

        }


        static public double TrackAndPrintRunningWeeklyProfitOrLoss(double runningProfitOrLoss)
        {
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday) == 0)
            {

                runningProfitOrLoss = runningProfitOrLoss + 0;
                Console.WriteLine("You hit even. Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + "."); 
                return runningProfitOrLoss;
            }
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday) > 0)
            {
                runningProfitOrLoss = runningProfitOrLoss + UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday);
                Console.WriteLine("Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday) < 0)
            {
                runningProfitOrLoss = runningProfitOrLoss - UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday);
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
                weatherPossibilities.Add("hot, humid, sunny"); 
                weatherPossibilities.Add("hot, humid, cloudy"); 
                weatherPossibilities.Add("hot, rainy"); 
                weatherPossibilities.Add("hot, sunny"); 
                weatherPossibilities.Add("hot, cloudy"); 
                weatherPossibilities.Add("warm, humid, sunny"); 
                weatherPossibilities.Add("warm, humid, cloudy"); 
                weatherPossibilities.Add("warm, sunny"); 
                weatherPossibilities.Add("warm, cloudy"); 
                weatherPossibilities.Add("chilly, humid, sunny"); 
                weatherPossibilities.Add("chilly, sunny"); 
                weatherPossibilities.Add("chilly, humid, cloudy"); 
                weatherPossibilities.Add("chilly, cloudy");
                weatherPossibilities.Add("warm, rainy"); 
                weatherPossibilities.Add("chilly, rainy");
            }
            get
            {
                return weatherPossibilities;
            }
        }

        static public List<object> ListOfDaysToPlay()
        {
            numberOfDaysToPlay = 7;
            for (int i = 0; i <= numberOfDaysToPlay - 1; i++)
            {
                daysInGame.Add(i);
            }
            return daysInGame;
        }



        static public int CountWeatherPossibilities(List<string> weatherPossibilities)
        {
            return weatherPossibilities.Count();
        }

        public static void SaveFinalScoreOfPlayerToDatabase(double finalScore) // SQL - do this later
        {

        }

        public static void DetermineNumberOfPotentialCustomers()
        {
            // depends on weather. more potential customers when weather is good.
            // IF weather = good [define good], THEN numberOfCustomers = high [define high]
            // IF weather = bad [define bad], THEN numberOfCustomers = low [define low]
        }


        public static double SellLemonadeToCustomerReturnsNumberOfCups() // DO THIS
        {
            cupsSoldOnDayCounter = 0; // could make it a member variable?

            // iterate through the customer objects

            //if (customer.WantsToBuy())
            //{

            //}



            // does the customer want to buy? depends on weather, etc. if weather is good, more cups are sold. if weather is bad, fewer cups are sold.
            // if the customer wants to buy, how many cups does he/she want?
            // check to see if we have enough to sell them that amount
            // if we do have enough, sell them that amount
            // calculate revenue (numberOfCupsOrdered * priceOfCup)
            // add revenue to wallet
            // subtract lemons, sugar, and ice from inventory (calculate fractional amounts per cup?)
            // check to see if we're out of stock (if we don't have enough of any ingredient to make another full cup)
            // if we are out of stock, end the day
            // if we aren't out of stock, proceed to ask the next customer
            // if we don't have enough, sell them partial until we can't sell any more full cups
            // then end day because we're out of stock
            // if the customer does not want to buy, check next customer if there is one


            return cupsSoldOnDayCounter;

        }




    }
}
