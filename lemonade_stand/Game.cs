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
        public static string playerName;
        public const double numberOfDaysToPlay = 7;

        public static List<string> weatherPossibilities;
        public static List<Day> daysInGameListOfObjects;

        public static Random rnd;

        public static double runningProfitOrLoss; // $50 different from running balance

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
        public void PlayGame()
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
                daysInGameListOfObjects.ElementAt(i);
                runningProfitOrLoss = TrackAndPrintRunningWeeklyProfitOrLoss(runningProfitOrLoss);
            }

            UserInterface.SummarizeWeek();

            finalScore = Wallet.dollarsInWallet;

            SqlConnection.SaveFinalScoreOfPlayerToDatabase(finalScore);
            SqlConnection.PrintHighScoresFromAllTime();

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


        public static double TrackAndPrintRunningWeeklyProfitOrLoss(double runningProfitOrLoss) //  needs more/better logic
        {
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(Day.cupsSoldToday) == 0)
            {

                runningProfitOrLoss = runningProfitOrLoss + 0;
                Console.WriteLine("You hit even. Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(Day.cupsSoldToday) > 0)
            {
                runningProfitOrLoss = runningProfitOrLoss + UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(Day.cupsSoldToday);
                Console.WriteLine("Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            if (UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(Day.cupsSoldToday) < 0)
            {
                runningProfitOrLoss = runningProfitOrLoss - UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(Day.cupsSoldToday);
                Console.WriteLine("Your running PROFIT/LOSS for the week is $" + runningProfitOrLoss + ".");
                return runningProfitOrLoss;
            }
            else
            {
                return runningProfitOrLoss;
            }
        }



        public static double? SellLemonadeToCustomerReturnsNumberOfCups()  // iterate through the customer objects
        {
            Day.cupsSoldToday = 0;
            double pitcherCounter = 0;
            double numberOfCupsPerPitcher = 8;

            double numberCustomerWants = Customer.ChoosesNumberOfCupsToBuyIfAny(Customer.thirstinessScale); // number of cups customer wants to buy - depends on weather, etc. 

            List<double> amounts = new List<double>() { Inventory.amountOfLemons / Day.lemonsPerPitcherToday, Inventory.amountOfSugarInCups / Day.sugarPerPitcherToday, (Inventory.amountOfIceBags * 100) / Day.iceCubesPerPitcherToday };
            double itemThatMakesSmallestAmountOfCups = amounts.Min(); // this is how many PITCHERS (not cups) we can make today
            double comparisonResult = numberCustomerWants.CompareTo(itemThatMakesSmallestAmountOfCups); // do we have enough to sell them the requested amount? if this returns negative, no. if it returns positive, yes. if it returns 0, they are equal.

            bool? canMakeRequestedAmount;
            if (comparisonResult >= 0)
            {
                canMakeRequestedAmount = true;
            }
            if (comparisonResult < 0)
            {
                canMakeRequestedAmount = false;
            }
            else
            {
                canMakeRequestedAmount = null;
            }

            if (canMakeRequestedAmount == true)
            {
                // sell them that amount:

                Wallet.dollarsInWallet += numberCustomerWants * Day.priceOfCupOfLemonadeToday; // calculate revenue and add revenue to wallet


                Day.cupsSoldToday += numberCustomerWants;
                pitcherCounter += numberCustomerWants;

                if (pitcherCounter >= 8)
                {
                    // subtract a pitcher's worth of lemons, sugar, and ice from inventory (or maybe multiple pitchers) - do this every time it reaches a multiple of 8
                    Inventory.amountOfLemons -= Day.lemonsPerPitcherToday;
                    Inventory.amountOfSugarInCups -= Day.sugarPerPitcherToday;
                    Inventory.amountOfIceBags = Inventory.amountOfIceBags - (Day.iceCubesPerPitcherToday * 100);

                }


                
                if (amounts.Exists(IsPositiveNumber)) // check to see if we're out of stock (if we don't have enough of any ingredient to make another full pitcher)
                {
                    bool isOutOfStock = true; // GO TO NEXT DAY
                }
                else
                {
                    bool isOutOfStock = false; // ask the next customer
                }
            }
            if (canMakeRequestedAmount == false)
            {
                // sell them partial until we can't sell any more full cups
                // then end day because we're out of stock
            }
            else
            {
                double? result = null;
                return result;
            }


            return Day.cupsSoldToday;

        }


        public class bool? IsPositiveNumber(double numberToTest)
        {
            bool? isPositiveNumber;
            if (numberToTest > 0)
            {
                isPositiveNumber = true;
            }
            else
            {
                isPositiveNumber = null;
            }
            return isPositiveNumber;
        }


    }
}
