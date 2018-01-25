using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public class Day 
    {
        // member variables (HAS A)
        public static double cupsSoldToday;

        public static double forecastWeather;
        public static double actualWeather;

        public Customer customer;

        public static List<Customer> poolOfPotentialCustomers;

        public static double numberOfPotentialCustomers;

        public static double lemonsPerPitcherToday;
        public static double sugarPerPitcherToday;
        public static double iceCubesPerPitcherToday;


        // constructor (SPAWNER)
        public Day()
        {
            customer = new Customer(double frugalityScale, double thirstinessScale);

            List<Customer> poolOfPotentialCustomers = new List<Customer>();
            forecastWeather = GetWeatherForecastForDay(); // investigate

            actualWeather = GetActualWeatherForDay(forecastWeather);
            numberOfPotentialCustomers = SetNumberOfPotentialCustomers(actualWeather);
            GenerateCustomers(numberOfPotentialCustomers);
        }

        // member methods (CAN DO)

        public static double RunDay()
        {
            UserInterface.PrintWeatherForecastForDay();

            UserInterface.PrintActualWeatherForDay();

            UserInterface.PrintInventoryStatus();

            UserInterface.PrintMoneyInWallet();

            lemonsPerPitcherToday = Player.SetNumberOfLemonsPerPitcherToUseInRecipeForDay();
            sugarPerPitcherToday = Player.SetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay();
            iceCubesPerPitcherToday = Player.SetNumberOfIceCubesPerPitcherToUseInRecipeForDay();
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


            cupsSoldToday = Game.SellLemonadeToCustomerReturnsNumberOfCups();


            UserInterface.ShowFinancialsAtEndOfDayAndReturnProfitOrLoss(cupsSoldToday); 
            UserInterface.PrintInventoryStatus();

            return cupsSoldToday;
        }

        public double SetNumberOfPotentialCustomers(double actualWeather) 
        {
            if (actualWeather > ((Game.weatherPossibilities.Count) / 3) * 2) // bad weather (positions 10-15ish)
            {
                numberOfPotentialCustomers = 50;
            }
            if (actualWeather <= (Game.weatherPossibilities.Count) / 3) // good weather (weather index positions 1-5ish)
            {
                numberOfPotentialCustomers = 150;
            }
            else
            {
                numberOfPotentialCustomers = 100;
            }
            return numberOfPotentialCustomers;
        }
        

        public static List<Customer> GenerateCustomers(double numberOfPotentialCustomers)
        {
            for (int i = 0; i <= Convert.ToInt32(numberOfPotentialCustomers); i++)
            {
                poolOfPotentialCustomers.Add(new Customer(double frugalityScale, double thirstinessScale));
            }
            return poolOfPotentialCustomers;
        }




        public static double GetWeatherForecastForDay()
        {
            return Weather.SetWeatherForecastForDay();
        }

        public static double GetActualWeatherForDay(double forecast)
        {
            return Weather.SetActualWeatherForDay(forecast);
        }




    
        public static double CalculateDailyExpenses()
        {

            double costOfLemons = Player.SetNumberOfLemonsToOrderForToday() * Store.SetStoreSellingPriceOfLemons();
            double costOfSugar = Player.SetNumberOfBagsOfSugarToOrderForToday() * Store.SetStoreSellingPriceOfSugar();
            double costOfIce = Player.SetNumberOfBagsOfIceToOrderForToday() * Store.SetStoreSellingPriceOfIce();

            double expenses = costOfLemons + costOfSugar + costOfIce;
            return expenses;
        }









    }
}
