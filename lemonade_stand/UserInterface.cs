using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class UserInterface
    {
        // member variables (HAS A)
        public Game Game;

        // constructor  (SPAWNER)
        public UserInterface()
        {

        }


        // member methods (CAN DO)

        public void WelcomeAndRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand game!");
        }


        public void SummarizeWeek()
        {
            // display cost tracking of each of the 7 days - dayOne, dayTwo, dayThree, dayFour, dayFive, daySix, daySeven
            // sum up to determine bottom line profit/loss for week (figure out this math exactly)
        }

        public void SaveFinalScoreOfPlayerToDatabase()
        {
            // SQL - do this later
        }

        public void PrintHighScoresFromAllTime()
        {
            // SQL - do this later
        }

    }
}
