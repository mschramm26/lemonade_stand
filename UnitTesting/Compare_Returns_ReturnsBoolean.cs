using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Compare_Returns_ReturnsBoolean
    {
        [TestMethod] // fails - no instances of Game and Random or forecastWeatherID
        public static double SetWeatherForecastForDay1()
        {
            // Arrange
            int lowerLimit = 0;
            int upperLimit;


            // Act
            upperLimit = Game.weatherPossibilities.Count() - 1;
            forecastWeatherID = Game.rnd.Next(lowerLimit, upperLimit);
            Convert.ToDouble(forecastWeatherID);


            // Assert
            Assert.AreEqual(forecastWeatherID, forecastWeatherID);


        }





    }
}
