using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Throws_Exception
    {
        [TestMethod] // threw an exception for Game class - see below
        public static double SetWeatherForecastForDay4()
        {
            Random rnd = new Random();
            // Arrange
            int lowerLimit = 0;
            int upperLimit;


            // Act
            upperLimit = Game.weatherPossibilities.Count() - 1;
            int forecastWeatherID = rnd.Next(lowerLimit, upperLimit);
            Convert.ToDouble(forecastWeatherID);


            // Assert
            Assert.AreEqual(Game.weatherPossibilities, Game.weatherPossibilities);
        }

        private static object Game()
        {
            throw new NotImplementedException();
        }
    }
}
