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
        public Game Game;
        Lemons Lemons;
        Ice Ice;
        Sugar Sugar;

        // need to make day ID's

        // constructor  (SPAWNER)
        public Day()
        {

        }


        // member methods (CAN DO)

        public void RunDay()
        {
            GetWeatherForecastForDay();

            Lemons.ReturnAmountOfLemons();
            Sugar.ReturnAmountOfBagsOfSugar();
            Ice.ReturnAmountOfBagsOfIce();
            PrintInventoryStatus();

            ChooseRecipeForDay();

            OrderLemonsForToday();
            OrderSugarForToday();
            OrderIceForToday();

            SetPriceOfLemonadeForDay();

            SellLemonadeToCustomer();

            DetermineTotalCupsOfLemonadeSoldOnDay();

            // ...day...

            ShowFinancialsAtEndOfDay();
            PrintInventoryStatus();
            // check to see if it should run another day
        }

        public void GetWeatherForecastForDay() // GET what is set by the SET in the Weather class
        {

        }


        public void PrintInventoryStatus()
        {
            // display 
        }



        public void ChooseRecipeForDay() // does this need to happen before or after BuyInventoryForDay?
        {
            Console.WriteLine("Please enter the number of lemons to use per pitcher today.");
            Console.WriteLine("Please enter the number of bags of ice to use per pitcher today."); // tell it how many ice cubes are in a bag somewhere;
            Console.WriteLine("Please enter the number of cups of sugar to use per pitcher today."); // tell it how many cups of sugar are in a bag somewhere;
        }

        public double OrderLemonsForToday()
        {
            Console.WriteLine("How many lemons would you like to buy today?");
            double amountOfLemonsToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfLemonsToBuyForTomorrow;
        }

        public double OrderSugarForToday()
        {
            Console.WriteLine("How many bags of sugar would you like to buy today?");
            double amountOfSugarToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfSugarToBuyForTomorrow;
        }

        public double OrderIceForToday()
        {
            Console.WriteLine("How much ice would you like to buy today?");
            double amountOfIceToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfIceToBuyForTomorrow;
        }


        public void SetPriceOfLemonadeForDay()
        {
            // display weather
            // let them choose recipe
            // then get user input for price
        }

        public void DetermineNumberOfPotentialCustomers()
        {
            // depends on weather. more potential customers when weather is good.
        }

        public void DetermineNumberOfActualCustomers()
        {
            // calculate based on customer attributes
        }

        public void SellLemonadeToCustomer() // possibly combine with...?
        {
            // how many cups did they buy?
            // add revenue to score
            // subtract supplies from inventory available to use for day
        }

        public void DetermineTotalCupsOfLemonadeSoldOnDay() // possibly combine with...?
        {
            // depends on weather. if weather is good, more cups are sold. if weather is bad, fewer cups are sold.
        }

        public void ShowFinancialsAtEndOfDay()
        {
            // show how many cups sold
            // revenue
            // costs of supplies
            // is it a profit or loss for the day?
        }




    }
}
