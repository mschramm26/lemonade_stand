using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Day // need to make day ID's
    {
        // member variables (HAS A)
        public double numberOfPotentialCustomers; // each customer is an object
        public double numberOfActualCustomers;
        public Customer customer;


        public double forecastWeather;
        public double actualWeather;



        

        // constructor  (SPAWNER)
        public Day()
        {
            
        }

        // member methods (CAN DO)

        public double RunDay()
        {
            forecastWeather = GetWeatherForecastForDay(); // what is the point of this? do they need to order inventory for the next day at the end of the current day? at the moment, they order inventory in the morning.
            UserInterface.PrintWeatherForecastForDay();

            actualWeather = GetActualWeatherForDay(forecastWeather);
            UserInterface.PrintActualWeatherForDay();

            UserInterface.PrintInventoryStatus();

            UserInterface.PrintMoneyInWallet();

            double lemonsPerPitcherToday = GetNumberOfLemonsPerPitcherToUseInRecipeForDay();
            double sugarPerPitcherToday = GetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay();
            double iceCubesPerPitcherToday = GetNumberOfIceCubesPerPitcherToUseInRecipeForDay();
            Console.WriteLine("Your lemonade recipe today:"); 
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcherToday);
            Console.WriteLine("Cups of sugar per pitcher: " + sugarPerPitcherToday);
            Console.WriteLine("Ice cubes per pitcher: " + iceCubesPerPitcherToday);

            double lemonsToAddToInventory = GetNumberOfLemonsToOrderForToday(); // get number of lemons to order today
            Inventory.amountOfLemons = Inventory.BuyLemonsFromStore(lemonsToAddToInventory); // adding the number of lemons desired to inventory
            Game.wallet.PayMoneyToStore(lemonsToAddToInventory * Store.SetStoreSellingPriceOfLemons()); // subtracting cost of lemons from wallet
            UserInterface.PrintMoneyInWallet(); // printing current amount in wallet
            UserInterface.PrintInventoryStatus(); // printing inventory status (must include newly updated lemon amount)

            double bagsOfSugarToAddToInventory = GetNumberOfBagsOfSugarToOrderForToday();
            Inventory.amountOfSugarInCups = Inventory.BuyBagsOfSugarFromStore(bagsOfSugarToAddToInventory); 
            Game.wallet.PayMoneyToStore(bagsOfSugarToAddToInventory * Store.SetStoreSellingPriceOfSugar()); 
            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();

            double iceToAddToInventory = GetNumberOfBagsOfIceToOrderForToday();
            Inventory.amountOfIceBags = Inventory.BuyBagsOfIceFromStore(iceToAddToInventory); 
            Game.wallet.PayMoneyToStore(iceToAddToInventory * Store.SetStoreSellingPriceOfIce()); 
            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();


            double priceOfCupOfLemonadeToday = Player.SetPriceOfCupOfLemonadeForDay();

            double cupsSoldToday = Game.SellLemonadeToCustomerReturnsNumberOfCups(); // loooooooooooooong function

            Game.cupsSoldOnDayCounter = Game.cupsSoldOnDayCounter + cupsSoldToday;

            UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday); 
            UserInterface.PrintInventoryStatus();

            return cupsSoldToday;
            // check to see if it should run another day - or maybe move this to the game class. Count day objects and tell it not to run the next day if it's the last day?
        }


        /*START getting weather*/
        public static double GetWeatherForecastForDay()
        {
            return Weather.SetWeatherForecastForDay();
        }

        public static double GetActualWeatherForDay(double forecast)
        {
            return Weather.SetActualWeatherForDay(forecast);
        /*END getting weather*/}


        /*START getting recipe*/
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
        /*END getting recipe*/


        /*START getting amounts of ingredients to order for today*/
        public static double GetNumberOfLemonsToOrderForToday()
        {
            Console.WriteLine("Lemons cost $" + Store.SetStoreSellingPriceOfLemons() + ".");
            Console.WriteLine("How many lemons would you like to buy today?"); // limited to money available in wallet
            double amountOfLemonsToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfLemonsToBuyForTomorrow;
        }

        public static double GetNumberOfBagsOfSugarToOrderForToday()
        {
            Console.WriteLine("Bags of sugar cost $" + Store.SetStoreSellingPriceOfSugar() + ".");
            Console.WriteLine("How many bags of sugar would you like to buy today?"); // limited to money available in wallet
            double amountOfSugarToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfSugarToBuyForTomorrow;
        }

        public static double GetNumberOfBagsOfIceToOrderForToday()
        {
            Console.WriteLine("Ice bags cost $" + Store.SetStoreSellingPriceOfIce() + ".");
            Console.WriteLine("How many bags of ice would you like to buy today?"); // limited to money available in wallet
            double amountOfIceToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfIceToBuyForTomorrow;
        }
        /*END getting amounts of ingredients to order for today*/


    
        public static double CalculateDailyExpenses()
        {

            double costOfLemons = GetNumberOfLemonsToOrderForToday() * Store.SetStoreSellingPriceOfLemons();
            double costOfSugar = GetNumberOfBagsOfSugarToOrderForToday() * Store.SetStoreSellingPriceOfSugar();
            double costOfIce = GetNumberOfBagsOfIceToOrderForToday() * Store.SetStoreSellingPriceOfIce();

            double expenses = costOfLemons + costOfSugar + costOfIce;
            return expenses;
        }



        public void DetermineNumberOfActualCustomers()
        {
            // calculate based on customer attributes
        }







    }
}
