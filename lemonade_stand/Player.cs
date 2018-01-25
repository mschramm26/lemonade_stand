using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    static class Player
    {
        // member variables (HAS A)


        // constructor (SPAWNER)
        static Player()
        {

        }


        // member methods (CAN DO)

        public static string SetName()
        {
            Console.WriteLine("Please enter your name.");
            string playerName = Console.ReadLine(); // validate this? need for SQL
            return playerName;
        }





        public static double SetNumberOfLemonsPerPitcherToUseInRecipeForDay() /*START getting recipe*/
        {
            Console.WriteLine("Please enter the number of lemons to use per pitcher today.");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double SetNumberOfCupsOfSugarPerPitcherToUseInRecipeForDay()
        {
            Console.WriteLine("Please enter the number of cups of sugar to use per pitcher today."); // tell it how many bags of sugar are in a bag somewhere;
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double SetNumberOfIceCubesPerPitcherToUseInRecipeForDay()
        {
            Console.WriteLine("Please enter the number of ice cubes to use per pitcher today."); // tell it how many ice cubes are in a bag somewhere;
            return Convert.ToDouble(Console.ReadLine());
        } /*END getting recipe*/



        
        public static double SetNumberOfLemonsToOrderForToday() /*START getting amounts of ingredients to order for today*/
        {
            Console.WriteLine("Lemons cost $" + Store.SetStoreSellingPriceOfLemons() + ".");
            Console.WriteLine("How many lemons would you like to buy today?"); // limited to money available in wallet
            double amountOfLemonsToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfLemonsToBuyForTomorrow;
        }

        public static double SetNumberOfBagsOfSugarToOrderForToday()
        {
            Console.WriteLine("Bags of sugar cost $" + Store.SetStoreSellingPriceOfSugar() + ".");
            Console.WriteLine("How many bags of sugar would you like to buy today?"); // limited to money available in wallet
            double amountOfSugarToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfSugarToBuyForTomorrow;
        }

        public static double SetNumberOfBagsOfIceToOrderForToday()
        {
            Console.WriteLine("Ice bags cost $" + Store.SetStoreSellingPriceOfIce() + ".");
            Console.WriteLine("How many bags of ice would you like to buy today?"); // limited to money available in wallet
            double amountOfIceToBuyForTomorrow = Convert.ToDouble(Console.ReadLine());
            return amountOfIceToBuyForTomorrow;
        } /*END getting amounts of ingredients to order for today*/



        public static double SetPriceOfCupOfLemonadeForDay()
        {
            Console.WriteLine("What price would you like to sell each cup of lemonade for today?");
            double pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }





    }
}
