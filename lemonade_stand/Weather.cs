using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public static class Weather
    {
        // member variables (HAS A)
        //static Game game;

        // constructor (SPAWNER)
        static Weather()
        {
            
        }

        // member methods (CAN DO)

        public static int SetWeatherForecastForDay()
        {
            int lowerLimit = 0;
            int upperLimit = Game.CountWeatherPossibilities(Game.weatherPossibilities);
            int forecastWeatherID = Game.rnd.Next(lowerLimit, upperLimit); // select random choice from the list
            return forecastWeatherID;
        }


        public static int SetActualWeatherForDay()
        {
            int lowerLimit = 0;
            int upperLimit = Game.CountWeatherPossibilities(Game.weatherPossibilities);
            int actualWeatherID = Game.rnd.Next(lowerLimit, upperLimit); // select random choice from the list
            return actualWeatherID;
        }


    }
}
