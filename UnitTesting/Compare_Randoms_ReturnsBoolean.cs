using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Compare_Randoms_ReturnsBoolean
    {
        [TestMethod] // Random and Game added - still fails?
        public static double SetWeatherForecastForDay2()
        {
            Random rnd = new Random();
            Game();
            // Arrange
            int lowerLimit = 0;
            int upperLimit;


            // Act
            upperLimit = Game.weatherPossibilities.Count() - 1;
            forecastWeatherID = rnd.Next(lowerLimit, upperLimit);
            Convert.ToDouble(forecastWeatherID);


            // Assert
            Assert.AreEqual(rnd, rnd);
        }
    }
}
