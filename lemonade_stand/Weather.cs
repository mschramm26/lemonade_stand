using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Weather
    {
        // member variables (HAS A)
        public Game Game;
        public string typeOfWeather;
        public Random rnd;

        // constructor (SPAWNER)
        public Weather()
        {
        }

        // member methods (CAN DO)

        public int SetForecastForDay(Random rnd, int lowerLimit, int upperLimit)
        {
            lowerLimit = 0;
            upperLimit = Game.CountWeatherPossibilities(Game.weatherPossibilities);
            int forecastWeatherID = rnd.Next(lowerLimit, upperLimit); // select random choice from the list
            return forecastWeatherID;
        }


        public double DetermineActualWeatherForDay(List<string> weatherPossibilities)
        {

            double actualWeatherID = rnd.Next(0, weatherPossibilities.Count); // select random choice from the list
            return actualWeatherID;
        }


    }
}
