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
        public static double forecastWeatherID;
        public static int actualWeatherID;

        // constructor (SPAWNER)
        static Weather()
        {
            
        }

        // member methods (CAN DO)

        public static double SetWeatherForecastForDay()
        {
            int lowerLimit = 0;
            int upperLimit = Game.weatherPossibilities.Count() - 1;
            forecastWeatherID = Game.rnd.Next(lowerLimit, upperLimit); // select random choice from the list
            Convert.ToDouble(forecastWeatherID);
            return forecastWeatherID;
        }


        public static int SetActualWeatherForDay(double forecast)
        {
            if (forecast == 0) // first index position
            {
                int lowerLimit = Convert.ToInt32(forecast);
                int upperLimit = Convert.ToInt32(forecast + 2);
                actualWeatherID = Game.rnd.Next(lowerLimit, upperLimit);
                return actualWeatherID;
            }
            if (forecast == Game.weatherPossibilities.Count() - 1) // last index position
            {
                int lowerLimit = Convert.ToInt32(Game.weatherPossibilities.Count() - 3);
                int upperLimit = Convert.ToInt32(Game.weatherPossibilities.Count() - 1);
                actualWeatherID = Game.rnd.Next(lowerLimit, upperLimit);
                return actualWeatherID;
            }
            else
            {
                int lowerLimit = Convert.ToInt32(forecast - 1);
                int upperLimit = Convert.ToInt32(forecast + 1);
                actualWeatherID = Game.rnd.Next(lowerLimit, upperLimit);
                return actualWeatherID;
            }
        }





    }
}
