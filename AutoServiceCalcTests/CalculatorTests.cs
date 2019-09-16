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
       Lube Job – $18.18 = $3.00 grease + .75hours labor($15.00)
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

        /*[TestMethod]
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
        */
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
        /*
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
        */
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
        /*
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
        */
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
        /*
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
        */
        // Tests - Muffler replacement – $103.60 = $60.00 muffler + 2.0hours labor($40.00)
        public void MufflerReplacementHasCorrectPartPrice()
        {
            //Arrange
            MufflerReplacement c = new MufflerReplacement();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(60.00m, price);

        }

        [TestMethod]
        public void MufflerReplacementHasCorrectLaborHours()
        {
            //Arrange
            MufflerReplacement c = new MufflerReplacement();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(2.00m, labor);
        }
        /*
        [TestMethod]
        public void MufflerReplacementReturnsCorrectLaborCharge()
        {
            //Arrange
            MufflerReplacement c = new MufflerReplacement();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(40.00m, laborcharge);

        }
        
        [TestMethod]
        public void MufflerReplacementCalculatesTaxCorrectly()
        {
            //Arrange
            MufflerReplacement c = new MufflerReplacement();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(3.60m, tax);

        }
        
        [TestMethod]
        public void MufflerReplacementCalculatesTotalCorrectly()
        {
            //Arrange
            MufflerReplacement c = new MufflerReplacement();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(103.60m, total);

        }
        */
        // Tests - Inspection – $15.00 - .75hours labor($15.00)
        public void InspectionHasCorrectPartPrice()
        {
            //Arrange
            Inspection c = new Inspection();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(0.00m, price);

        }

        [TestMethod]
        public void InspectionHasCorrectLaborHours()
        {
            //Arrange
            Inspection c = new Inspection();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(0.75m, labor);
        }
        /*
        [TestMethod]
        public void InspectionReturnsCorrectLaborCharge()
        {
            //Arrange
            Inspection c = new Inspection();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(15.00m, laborcharge);

        }
        
        [TestMethod]
        public void InspectionCalculatesTaxCorrectly()
        {
            //Arrange
            Inspection c = new Inspection();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.00m, tax);

        }
        
        [TestMethod]
        public void InspectionCalculatesTotalCorrectly()
        {
            //Arrange
            Inspection c = new Inspection();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(15.00m, total);

        }
        */
        // Tests - Tire rotation – $20.00 = 1.0hour labor ($20.00)
        public void TireRotationHasCorrectPartPrice()
        {
            //Arrange
            TireRotation c = new TireRotation();

            //Act
            decimal price = c.Partprice;

            //Assert
            Assert.AreEqual(0.00m, price);

        }

        [TestMethod]
        public void TireRotationHasCorrectLaborHours()
        {
            //Arrange
            TireRotation c = new TireRotation();

            //Act
            decimal labor = c.Laborhours;

            //Assert
            Assert.AreEqual(1.0m, labor);
        }
        /*
        [TestMethod]
        public void TireRotationReturnsCorrectLaborCharge()
        {
            //Arrange
            TireRotation c = new TireRotation();

            //Act
            decimal laborcharge = c.getLaborCharge();

            //Assert
            Assert.AreEqual(20.00m, laborcharge);

        }
        
        [TestMethod]
        public void TireRotationCalculatesTaxCorrectly()
        {
            //Arrange
            TireRotation c = new TireRotation();

            //Act
            decimal tax = c.getTax();

            //Assert
            Assert.AreEqual(0.00m, tax);

        }
        
        [TestMethod]
        public void TireRotationCalculatesTotalCorrectly()
        {
            //Arrange
            TireRotation c = new TireRotation();

            //Act
            decimal total = c.calculateTotal();

            //Assert
            Assert.AreEqual(20.00m, total);

        }
        */
        //Tests - total parts calculates correctly
        [TestMethod]
        public void GivenOIlChangeAndLubeJobOjectsRepairBillCanBeCreated()
        {
            // Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RepairBill bill = new RepairBill();

            // Act
            bill.addService(s1);
            bill.addService(s2);

            // Assert
            Assert.IsNotNull(bill);
        }
        [TestMethod]
        public void GivenOIlChangeAndLubeJobOjectsPartTotalIsCorrect()
        {
            // Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            decimal total = bill.getPartTotal();
            Assert.AreEqual(14.00m,total);
        }
        [TestMethod]
        public void GivenThreeServicesPartTotalIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);

            //Act
            decimal total = bill.getPartTotal();

            //Assert
            Assert.AreEqual(19.00m, total);
        }
        [TestMethod]
        public void GivenFourServicesPartTotalIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);

            //Act
            decimal total = bill.getPartTotal();

            //Assert
            Assert.AreEqual(34.00m, total);
        }
        [TestMethod]
        public void GivenFiveServicesPartTotalIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);

            //Act
            decimal total = bill.getPartTotal();

            //Assert
            Assert.AreEqual(94.00m, total);
        }
        [TestMethod]
        public void GivenSixServicesPartTotalIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);
            bill.addService(s6);

            //Act
            decimal total = bill.getPartTotal();

            //Assert
            Assert.AreEqual(94.00m, total);
        }
        [TestMethod]
        public void GivenAllServicesPartTotalIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);

            //Act
            decimal total = bill.getPartTotal();

            //Assert
            Assert.AreEqual(94.00m, total);
        }
        // Test labor calculates correctly
        [TestMethod]
        public void GivenAllServicesTotalLaborHoursIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();
            TireRotation s7 = new TireRotation();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);
            bill.addService(s6);
            bill.addService(s7);

            //Act
            decimal total = bill.getLaborhoursTotal();

            //Assert
            Assert.AreEqual(9.75m, total);
        }
        [TestMethod]
        public void GivenAllServicesTotalLaborChargeIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();
            TireRotation s7 = new TireRotation();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);
            bill.addService(s6);
            bill.addService(s7);

            //Act
            decimal total = bill.getLaborChargeTotal();

            //Assert
            Assert.AreEqual(195.00m, total);
        }
        [TestMethod]
        public void GivenAllServicesTotalTaxIsCorrect()
        {
            //Arrange
            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();
            TireRotation s7 = new TireRotation();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);
            bill.addService(s6);
            bill.addService(s7);

            //Act
            decimal total = bill.getTaxTotal();

            //Assert
            Assert.AreEqual(5.64m, total);
        }
        
        [TestMethod]
        public void serviceIsRemoved()
        {
            //Arrange
            MufflerReplacement muffler = new MufflerReplacement();

            OilChange s1 = new OilChange();
            LubeJob s2 = new LubeJob();
            RadiatorFlush s3 = new RadiatorFlush();
            TransmissionFlush s4 = new TransmissionFlush();
            MufflerReplacement s5 = new MufflerReplacement();
            Inspection s6 = new Inspection();
            TireRotation s7 = new TireRotation();

            RepairBill bill = new RepairBill();
            bill.addService(s1);
            bill.addService(s2);
            bill.addService(s3);
            bill.addService(s4);
            bill.addService(s5);
            bill.addService(s6);
            bill.addService(s7);

            // Act
            bill.removeService(muffler);
            int length = bill.getServices().Count;

            // Assert
            Assert.AreEqual(6, length);
        }
        
        [TestMethod]
        public void twoServicesWithSameValuesAreEqual()
        {
            //Arrange
            MufflerReplacement m = new MufflerReplacement();
            MufflerReplacement m2 = new MufflerReplacement();

            //Act
            Boolean servicesAreEqual = m.Equals(m2);

            //Assert
            Assert.IsTrue(servicesAreEqual);
        }
    }

}

