using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlanRegan_S00188509;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
     
            [TestMethod]
            public void TestIncreasePrice()
            {
                // Arrange
                Phone phone1 = new Phone();
                decimal expectedPrice = 875m;
                phone1.Price = 500m;

                // Act
                phone1.IncreasePrice(.75m);

                // Assert
                Assert.AreEqual(expectedPrice, phone1.Price);
            }
        }
}
