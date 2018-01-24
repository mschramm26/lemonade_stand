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

        public static string EnterName()
        {
            Console.WriteLine("Please enter your name.");
            string playerName = Console.ReadLine(); // validate this? need for SQL
            return playerName;
        }

        public static double SetPriceOfCupOfLemonadeForDay()
        {
            Console.WriteLine("What price would you like to sell each cup of lemonade for today?");
            double pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }


    }
}
