using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
     public class Game
    {
        // member variables (HAS A)
        string playerName;
        public const double numberOfDaysToPlay = 7;

        public static List<string> weatherPossibilities;
        public static List<Day> daysInGameListOfObjects;

        public static Random rnd;
        public /*static*/ Day day; 

        public /*static*/ double cupsSoldOnDayCounter;

        public /*static*/ double runningProfitOrLoss; // $50 different from running balance

        public static double finalScore;


        // constructor (SPAWNER)
        public Game()
        {
            Random rnd = new Random();

            List<string> weatherPossibilities = WeatherPossibilities;

            List<Day> daysInGameListOfObjects = new List<Day>();
            AddDaysToBePlayedToListOfObjects();
        }

        // member methods (CAN DO)
        public /*static*/ void PlayGame()
        {
            UserInterface.Introduction();
            playerName = Player.SetName();

            Wallet.dollarsInWallet = 50;

            runningProfitOrLoss = 0;

            Inventory.amountOfLemons = 0;
            Inventory.amountOfSugarInCups = 0;
            Inventory.amountOfIceBags = 0;

            for (int i = 0; i <= daysInGameListOfObjects.Count - 1; i++)
            {
                daysInGameListOfObjects[i].RunDay();
                runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);
            }

            UserInterface.SummarizeWeek();

            finalScore = Wallet.dollarsInWallet;

            SqlConnection.SaveFinalScoreOfPlayerToDatabase(finalScore);
            UserInterface.PrintHighScoresFromAllTime();

        }



        public static List<Day> AddDaysToBePlayedToListOfObjects()
        {
            for (int i = 0; i <= numberOfDaysToPlay - 1; i++)
            {
                daysInGameListOfObjects.Add(new Day());
            }
            return daysInGameListOfObjects;
        }

        public static List<string> WeatherPossibilities
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


        public /*static*/ double TrackAndPrintRunningWeeklyProfitOrLoss(double runningProfitOrLoss) //  needs more/better logic
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


        public static void DetermineNumberOfPotentialCustomers()
        {
        }


        public /*static*/ double SellLemonadeToCustomerReturnsNumberOfCups() // DO THIS
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
