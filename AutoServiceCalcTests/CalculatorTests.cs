﻿using System;
using AutoServiceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoServiceCalcTests
{
    /*
       Calculate the total amount of a repair bill,
       Break out parts and labor and tax (6% on parts only).
       Calculate total.

       Oil change – $26.00 = $11.00 oil + .45hours labor($15.00)
       Lube Job – $18.00 = $3.00 grease + .45hours labor($15.00)
       Radiator flush – 30.00 = 5.00 radiator fluid +1.25hours labor($25.00)
       Transmission flush – $80.00 = $15.00 transmission fluid + 3.25hours labor($65.00)
       Inspection – $15.00 - .45hours labor($15.00)
       Muffler replacement – $100.00 = $60.00 muffler + 2.0hours labor($40.00)
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
            Assert.AreEqual(0.45m, labor);

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
            Assert.AreEqual(26.00m, total);

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
            Assert.AreEqual(0.45m, labor);

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
        /*
    [TestMethod]
    public void OilChangeCalculatesTotalCorrectly()
    {
        //Arrange
        LubeJob c = new LubeJob();

        //Act
        decimal total = c.calculateTotal();

        //Assert
        Assert.AreEqual(26.00m, total);

    }

    */
    }
}
