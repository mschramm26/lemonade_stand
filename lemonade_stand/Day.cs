using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Day
    {
        // member variables (HAS A)
        public double numberOfPotentialCustomers; // each customer is an object
        public double numberOfActualCustomers;
        public double cupsSoldOnDayCounter;

        //public Game game;
        //public UserInterface ui;
        public Customer customer;

        //static Weather weather;
        public Store store;
        public Wallet wallet;

        //public Weather actualWeather;
        //public Weather forecastWeather;

        // need to make day ID's

        // constructor  (SPAWNER)
        public Day()
        {
            //weather = new Weather();
            //actualWeather = new Weather();
            //forecastWeather = new Weather();

        }

        // member methods (CAN DO)

        public void RunDay()
        {
            GetActualWeatherForecastForDay(); // what is the point of this? do they need to order inventory for the next day at the end of the current day? at the moment, they order inventory in the morning.
            UserInterface.PrintWeatherForecastForDay();

            GetActualWeatherForDay(); // must be pretty close to forecast
            UserInterface.PrintActualWeatherForDay();

            UserInterface.PrintInventoryStatus();

            UserInterface.PrintMoneyInWallet();

            double lemonsPerPitcherToday = GetNumberOfLemonsPerPitcherToUseInRecipeForDay();
            double sugarPerPitcherToday = GetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay();
            double iceCubesPerPitcherToday = GetNumberOfIceCubesPerPitcherToUseInRecipeForDay();
            
            Console.WriteLine("Your lemonade recipe today:"); // tell them their recipe 
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcherToday);
            Console.WriteLine("Cups of sugar per pitcher: " + sugarPerPitcherToday);
            Console.WriteLine("Ice cubes per pitcher: " + iceCubesPerPitcherToday);


            GetNumberOfLemonsToOrderForToday();
            // add lemons to inventory
            // get lemon inventory 
            // subtract lemon costs from wallet
            // get money in wallet
            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();

            GetNumberOfBagsOfSugarToOrderForToday();
            // add sugar to inventory
            // get sugar inventory
            // subtract sugar costs from wallet
            // get money in wallet

            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();

            GetNumberOfBagsOfIceToOrderForToday();
            // add ice to inventory
            // get ice inventory
            // subtract ice costs from wallet
            // get money in wallet

            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();


            UserInterface.PrintInventoryStatus();
            UserInterface.PrintMoneyInWallet();

            SetPriceOfCupOfLemonadeForDay();

            SellLemonadeToCustomerReturnsNumberOfCups(); // loooooooooooooong function



            ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(); // move to ui
            UserInterface.PrintInventoryStatus(); 

            // check to see if it should run another day - or maybe move this to the game class. Count day objects and tell it not to run the next day if it's the last day?
        }



        public static int GetActualWeatherForecastForDay()
        {
            return Weather.SetWeatherForecastForDay();
        }

        public static int GetActualWeatherForDay()
        {
            return Weather.SetActualWeatherForDay();
        }


        public double GetNumberOfLemonsPerPitcherToUseInRecipeForDay() 
        {
            Console.WriteLine("Please enter the number of lemons to use per pitcher today.");
            return Convert.ToDouble(Console.ReadLine());
        }

        public double GetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay()
        {
            Console.WriteLine("Please enter the number of cups of sugar to use per pitcher today."); // tell it how many bags of sugar are in a bag somewhere;
            return Convert.ToDouble(Console.ReadLine());
        }
        public double GetNumberOfIceCubesPerPitcherToUseInRecipeForDay()
        {
            Console.WriteLine("Please enter the number of ice cubes to use per pitcher today."); // tell it how many ice cubes are in a bag somewhere;
            return Convert.ToDouble(Console.ReadLine());
        }




        public double GetNumberOfLemonsToOrderForToday()
        {
            Console.WriteLine("Lemons cost $" + store.SetStoreSellingPriceOfLemons() + ".");
            Console.WriteLine("How many lemons would you like to buy today?"); // limited to money available in wallet
            double amountOfLemonsToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfLemonsToBuyForTomorrow;
        }

        public double GetNumberOfBagsOfSugarToOrderForToday()
        {
            Console.WriteLine("Bags of sugar cost $" + store.SetStoreSellingPriceOfSugar() + ".");
            Console.WriteLine("How many bags of sugar would you like to buy today?"); // limited to money available in wallet
            double amountOfSugarToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfSugarToBuyForTomorrow;
        }

        public double GetNumberOfBagsOfIceToOrderForToday()
        {
            Console.WriteLine("Ice bags cost $" + store.SetStoreSellingPriceOfIce() + ".");
            Console.WriteLine("How many bags of ice would you like to buy today?"); // limited to money available in wallet
            double amountOfIceToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfIceToBuyForTomorrow;
        }


        public double CalculateDailyExpenses()
        {

            double costOfLemons = GetNumberOfLemonsToOrderForToday() * store.SetStoreSellingPriceOfLemons();
            double costOfSugar = GetNumberOfBagsOfSugarToOrderForToday() * store.SetStoreSellingPriceOfSugar();
            double costOfIce = GetNumberOfBagsOfIceToOrderForToday() * store.SetStoreSellingPriceOfIce();

            double expenses = costOfLemons + costOfSugar + costOfIce;
            return expenses;
        }

        public double SetPriceOfCupOfLemonadeForDay()
        {
            Console.WriteLine("What price would you like to sell each cup of lemonade for today?");
            double pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }

        public void DetermineNumberOfPotentialCustomers()
        {
            // depends on weather. more potential customers when weather is good.
        }

        public void DetermineNumberOfActualCustomers()
        {
            // calculate based on customer attributes
        }

        public double SellLemonadeToCustomerReturnsNumberOfCups() 
        {
            cupsSoldOnDayCounter = 0; // could make it a member variable?

            // iterate through the customer objects

            if (customer.WantsToBuy())
            {

            }



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


        public double ShowFinancialsAtEndOfDayAndReturnProfitOrLoss() // move to ui?
        {
            double dollarsMadeToday = SellLemonadeToCustomerReturnsNumberOfCups() * SetPriceOfCupOfLemonadeForDay();
            double expensesToday = CalculateDailyExpenses(); 

            Console.WriteLine("You sold " + SellLemonadeToCustomerReturnsNumberOfCups() + " cups today.");
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




    }
}
