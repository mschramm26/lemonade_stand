using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTesting
{
    [TestClass]
    public class Compare_Doubles_ReturnsBooleans
    {
        [TestMethod] // made it null - should still fail because double is not nullable
        public static double ContainsMoneyInDollars1()
        {
            // Arrange
            public static double dollarsInWallet;
        

            // Act
            dollarsInWallet = null;

            // Assert
            Assert(dollarsInWallet, dollarsInWallet);

        }

        [TestMethod] // made double nullable - should pass now
        public static double ContainsMoneyInDollars2()
        {
            // Arrange
            public static double? dollarsInWallet;


            // Act
            dollarsInWallet = null;

            // Assert
            Assert.AreEqual(dollarsInWallet, dollarsInWallet);

        }

    }
}
