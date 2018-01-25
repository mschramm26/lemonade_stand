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
        public double cupsSoldToday;

        public double forecastWeather;
        public double actualWeather;


        // constructor (SPAWNER)
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

            double lemonsPerPitcherToday = Player.SetNumberOfLemonsPerPitcherToUseInRecipeForDay();
            double sugarPerPitcherToday = Player.SetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay();
            double iceCubesPerPitcherToday = Player.SetNumberOfIceCubesPerPitcherToUseInRecipeForDay();
            Console.WriteLine("Your lemonade recipe today:"); 
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcherToday);
            Console.WriteLine("Cups of sugar per pitcher: " + sugarPerPitcherToday);
            Console.WriteLine("Ice cubes per pitcher: " + iceCubesPerPitcherToday);

            double lemonsToAddToInventory = Player.SetNumberOfLemonsToOrderForToday(); // get number of lemons to order today
            Inventory.amountOfLemons = Inventory.BuyLemonsFromStore(lemonsToAddToInventory); // adding the number of lemons desired to inventory
            Wallet.PayMoneyToStore(lemonsToAddToInventory * Store.SetStoreSellingPriceOfLemons()); // subtracting cost of lemons from wallet
            UserInterface.PrintMoneyInWallet(); // printing current amount in wallet
            UserInterface.PrintInventoryStatus(); // printing inventory status (must include newly updated lemon amount)

            double bagsOfSugarToAddToInventory = Player.SetNumberOfBagsOfSugarToOrderForToday();
            Inventory.amountOfSugarInCups = Inventory.BuyBagsOfSugarFromStore(bagsOfSugarToAddToInventory); 
            Wallet.PayMoneyToStore(bagsOfSugarToAddToInventory * Store.SetStoreSellingPriceOfSugar()); 
            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();

            double iceToAddToInventory = Player.SetNumberOfBagsOfIceToOrderForToday();
            Inventory.amountOfIceBags = Inventory.BuyBagsOfIceFromStore(iceToAddToInventory); 
            Wallet.PayMoneyToStore(iceToAddToInventory * Store.SetStoreSellingPriceOfIce()); 
            UserInterface.PrintMoneyInWallet();
            UserInterface.PrintInventoryStatus();


            double priceOfCupOfLemonadeToday = Player.SetPriceOfCupOfLemonadeForDay();

            cupsSoldToday = Game.SellLemonadeToCustomerReturnsNumberOfCups(); // loooooooooooooong function


            UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday); 
            UserInterface.PrintInventoryStatus();

            return cupsSoldToday;
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




    
        public static double CalculateDailyExpenses()
        {

            double costOfLemons = Player.SetNumberOfLemonsToOrderForToday() * Store.SetStoreSellingPriceOfLemons();
            double costOfSugar = Player.SetNumberOfBagsOfSugarToOrderForToday() * Store.SetStoreSellingPriceOfSugar();
            double costOfIce = Player.SetNumberOfBagsOfIceToOrderForToday() * Store.SetStoreSellingPriceOfIce();

            double expenses = costOfLemons + costOfSugar + costOfIce;
            return expenses;
        }



        public void DetermineNumberOfActualCustomers()
        {
            // calculate based on customer attributes
        }







    }
}
