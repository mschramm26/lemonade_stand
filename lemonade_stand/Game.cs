using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Game
    {
        // member variables (HAS A)
        public Player player; // instantiate a player object
        public Wallet wallet;
        public UserInterface ui;

        public List<string> weatherPossibilities; // list of forecasted and actual weather possibilities
        public Weather actualWeather;
        public Weather forecastWeather;

        public Random rnd;

        public Day dayOne;
        public Day dayTwo;
        public Day dayThree;
        public Day dayFour;
        public Day dayFive;
        public Day daySix;
        public Day daySeven;



        // constructor  (SPAWNER)
        public Game()
        {
            player = new Player();
            ui = new UserInterface();

            List<string> weatherPossibilities = WeatherPossibilities;
            actualWeather = new Weather();
            forecastWeather = new Weather();

            Random rnd = new Random();

            Day dayOne = new Day();
            Day dayTwo = new Day();
            Day dayThree = new Day();
            Day dayFour = new Day();
            Day dayFive = new Day();
            Day daySix = new Day();
            Day daySeven = new Day();


        }

        // member methods (CAN DO)
        public void PlayGame()
        {
            ui.WelcomeAndRules(); // welcomes player and introduces game
            player.GetName(); // returns player's name as string
            wallet.HasBeginningBalanceOf(); // player starts with $50

            dayOne.RunDay();
            dayTwo.RunDay();
            dayThree.RunDay();
            dayFour.RunDay();
            dayFive.RunDay();
            daySeven.RunDay();

            ui.SummarizeWeek();
            ui.SaveFinalScoreOfPlayerToDatabase();
            ui.PrintHighScoresFromAllTime();

        }

        public List<string> WeatherPossibilities
        {
            set
            {
                weatherPossibilities.Add("sunny");
                weatherPossibilities.Add("cloudy");
                weatherPossibilities.Add("rainy");
            }
            get
            {
                return weatherPossibilities;
            }
        }

        public int CountWeatherPossibilities(List<string> weatherPossibilities)
        {
            return weatherPossibilities.Count();
        }

        public int ChooseRandom(int lowerLimit, int upperLimit)
        {
            int random = rnd.Next(lowerLimit, upperLimit);
            return random;
        }


    }
}
