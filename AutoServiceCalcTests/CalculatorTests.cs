using System;
using AutoServiceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoServiceCalcTests
{
    /*
       Calculate the total amount of a repair bill,
       Break out parts and labor and tax (6% on parts only).
       Calculate total.

       Oil change – $26.66 = $11.00 oil + .75hours labor($15.00)
       Lube Job – $18.18 = $3.00 grease + .45hours labor($15.00)
       Radiator flush – 30.30 = 5.00 radiator fluid +1.25hours labor($25.00)
       Transmission flush – $80.90 = $15.00 transmission fluid + 3.25hours labor($65.00)
       Muffler replacement – $103.60 = $60.00 muffler + 2.0hours labor($40.00)
       Inspection – $15.00 - .75hours labor($15.00)
       Tire rotation – $20.00 = 1.0hour labor ($20.00)

       labor = $20.00/hour.  
    */
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void OilChangeHasCorrectParts()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            string part = c.Partname;

            //Assert
            Assert.AreEqual("oil", part);

        }

        [TestMethod]
        public void OilChangeHasCorrectPartPrice()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(11.00m, price);

        }
        [TestMethod]
        public void OilChangeHasCorrectLaborHours()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(0.75m, labor);

        }
        [TestMethod]
        public void OilChangeReturnsCorrectLaborCharge()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(15.00m, laborcharge);

        }
        [TestMethod]
        public void OilChangeCalculatesTaxCorrectly()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.66m, tax);

        }

        [TestMethod]
        public void OilChangeCalculatesTotalCorrectly()
        {
            //Arrange
            OilChange c = new OilChange();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(26.66m, total);

        }

        // LubeJob Tests
        [TestMethod]
        public void LubeJobHasCorrectPartName()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            string part = c.Partname;

            //Assert
            Assert.AreEqual("grease", part);

        }

        [TestMethod]
        public void LubeHasCorrectPartPrice()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(3.00m, price);

        }

        [TestMethod]
        public void LubeJobHasCorrectLaborHours()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(0.75m, labor);

        }

        [TestMethod]
        public void LubeJobReturnsCorrectLaborCharge()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(15.00m, laborcharge);

        }

        [TestMethod]
        public void LubeJobCalculatesTaxCorrectly()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.18m, tax);

        }

        [TestMethod]
        public void LubeJobCalculatesTotalCorrectly()
        {
            //Arrange
            LubeJob c = new LubeJob();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(18.18m, total);

        }
        // Tests for Radiator flush – 30.30 = 5.00 radiator fluid +1.25hours labor($25.00)
        [TestMethod]
        public void RadiatorFlushHasCorrectPartName()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            string part = c.Partname;

            //Assert
            Assert.AreEqual("radiator fluid", part);

        }

        [TestMethod]
        public void RadiatorFlushHasCorrectPartPrice()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(5.00m, price);

        }
        
        [TestMethod]
        public void RadiatorFlushHasCorrectLaborHours()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(1.25m, labor);
        }
        
        [TestMethod]
        public void RadiatorFlushReturnsCorrectLaborCharge()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(25.00m, laborcharge);

        }
        
        [TestMethod]
        public void RadiatorFlushCalculatesTaxCorrectly()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.30m, tax);

        }
     
        [TestMethod]
        public void RadiatorFlushCalculatesTotalCorrectly()
        {
            //Arrange
            RadiatorFlush c = new RadiatorFlush();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(30.30m, total);

        }

        //Tests - Transmission flush – $80.90 = $15.00 transmission fluid + 3.25hours labor($65.00)
        public void TransmissionFlushHasCorrectPartPrice()
        {
            //Arrange
            TransmissionFlush c = new TransmissionFlush();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(15.00m, price);

        }

        [TestMethod]
        public void TransmissionFlushHasCorrectLaborHours()
        {
            //Arrange
            TransmissionFlush c = new TransmissionFlush();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(3.25m, labor);
        }

        [TestMethod]
        public void TransmissionFlushReturnsCorrectLaborCharge()
        {
            //Arrange
            TransmissionFlush c = new TransmissionFlush();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(65.00m, laborcharge);

        }

        [TestMethod]
        public void TransmissionFlushCalculatesTaxCorrectly()
        {
            //Arrange
            TransmissionFlush c = new TransmissionFlush();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.90m, tax);

        }

        [TestMethod]
        public void TransmissionFlushCalculatesTotalCorrectly()
        {
            //Arrange
            TransmissionFlush c = new TransmissionFlush();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(80.900m, total);

        }
    }
}
