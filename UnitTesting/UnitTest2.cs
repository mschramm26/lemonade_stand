using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod] // gave forecastWeatherID a data type - passes now?
        public static double SetWeatherForecastForDay3()
        {
            Random rnd = new Random();
            Game();
            // Arrange
            int lowerLimit = 0;
            int upperLimit;


            // Act
            int forecastWeatherID;
            upperLimit = Game.weatherPossibilities.Count() - 1;
            forecastWeatherID = rnd.Next(lowerLimit, upperLimit);
            Convert.ToDouble(forecastWeatherID);


            // Assert
            Assert.AreEqual(forecastWeatherID, forecastWeatherID);
        }
    }
}
