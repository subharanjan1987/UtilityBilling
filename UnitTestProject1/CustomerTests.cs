using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerData.Tests
{
    [TestClass]
    public class CustomerTests
    {
      [TestMethod]
        public void ResidentialBillCalc()  //Testing if usage is <1000 kwh for residentail customer
        {
            //arrange
            int initial = 1000;
            double expectedbill = 58;
            double actualBill;
            Residential r; //ref of residential class

            //act
            r = new Residential("Birju",123,'R');
            actualBill = r. calculateBill(initial,0);  //calling the method to calculate bill for residential customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }
        [TestMethod]
        public void ResidentialBill()  //Testing if usage is >1000 kwh for residential customer
        {
            //arrange
            int initial = 2000;
            double expectedbill = 110;
            double actualBill;
            Residential r; //ref of residential class

            //act
            r = new Residential("Birju", 123, 'R');
            actualBill = r.calculateBill(initial, 0);  //calling the method to calculate bill for residential customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }

        [TestMethod]

        public void CommercialBillCalc()    //Testing if usage is <=1000 kwh for commercial customer   
        {
            //arrange
            int initial = 1000;
            double expectedbill = 60;
            double actualBill;
            Commercial c; //ref of commercial class

            //act
            c = new Commercial("Birju", 123, 'C');
            actualBill = c.calculateBill(initial,0);  //calling the method to calculate bill for commercial customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }
        [TestMethod]
        public void CommercialBill()    //Testing if usage is >1000 kwh for commercial customer   
        {
            //arrange
            int initial = 2000;
            double expectedbill = 105;
            double actualBill;
            Commercial c; //ref of commercial class

            //act
            c = new Commercial("Birju", 123, 'C');
            actualBill = c.calculateBill(initial, 0);  //calling the method to calculate bill for commercial customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }
        [TestMethod]
        public void IndustrialBillCalc()  //Testing if usage <=1000 kwh for Industrial customer for both onpeak and offpeak hours
        {
            //arrange
            int onPeak= 1000;
            int offPeak = 1000;
            double expectedbill = 116;
            double actualBill;
            Industrial i; //ref of Industrial class

            //act
            i = new Industrial("Birju", 123, 'I');
            actualBill = i.calculateBill(onPeak,offPeak);  //calling the method to calculate bill for industrial customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }
        [TestMethod]
        public void IndustrialBill()  //Testing if usage >1000 kwh for Industrial customer for both onpeak and offpeak hours
        {
            //arrange
            int onPeak = 2000;
            int offPeak = 1500;
            double expectedbill = 195;
            double actualBill;
            Industrial i; //ref of Industrial class

            //act
            i = new Industrial("Birju", 123, 'I');
            actualBill = i.calculateBill(onPeak, offPeak);  //calling the method to calculate bill for indutrial customer to test actual bill against expected bill

            //assert
            Assert.AreEqual(actualBill, expectedbill);
        }



    }
}
