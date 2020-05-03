using Microsoft.VisualStudio.TestTools.UnitTesting;
using miniStore;
using System;

namespace ParcelUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Parcel sut; // subject under testing

        [TestMethod]
        public void CalculateDeliveryCost_DeliveryCountryLithuaniaAndDeliveryTypePostOffice_TotalPriceShouldBe150()
        {
            sut = new Parcel(0, "Post Office", 0, "Lithuania");

            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(1.5, result);
        }

        [TestMethod]
        public void CalculateDeliveryCost_DeliveryCountryLithuaniaAndDeliveryTypeCourierServices_TotalPriceShouldBe350()
        {
            sut = new Parcel(0, "Courier Services", 0, "Lithuania");

            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void CalculateDeliveryCost_DeliveryCountryLithuaniaAndDeliveryTypePostMachine_TotalPriceShouldBe250()
        {
            sut = new Parcel(0, "Post Machine", 0, "Lithuania");

            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(2.5, result);
        }
        [TestMethod]
        public void CalculateDeliveryCost_DeliveryCountrAnyOther_TotalPriceShouldBe650()
        {
            sut = new Parcel(0, "", 0, "Any Other");

            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(6.5, result);
        }
        [TestMethod]
        public void CalculateTotalPrice_DeliveryCountryLithuaniaAndDeliveryTypePostOffice_TotalDeliveryPrice1150()
        {
            sut = new Parcel(0, "Post Office", 10, "Lithuania");
            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(11.50, result);
        }
        [TestMethod]
        public void CalculateTotalPrice_DeliveryCountryLithuaniaAndDeliveryTypeCourierServices_TotalDeliveryPrice1350()
        {
            sut = new Parcel(0, "Courier Services", 10, "Lithuania");
            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(13.50, result);
        }
        [TestMethod]
        public void CalculateTotalPrice_DeliveryCountryLithuaniaAndDeliveryTypePostMachine_TotalDeliveryPrice1250()
        {
            sut = new Parcel(0, "Post Machine", 10, "Lithuania");
            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(12.50, result);
        }
        [TestMethod]
        public void CalculateTotalPrice_DeliveryCountrAnyOther_TotalDeliveryPrice1650()
        {
            sut = new Parcel(0, "", 10, "Any Other");
            var result = sut.CalculateTotalPrice();
            Assert.AreEqual(16.50, result);
        }
        [TestMethod]
        public void GetDeliverySize_BasketSizeEquals2_DeliverySizeSetToS()
        {
            sut = new Parcel(3, "", 0, "");
            var result = sut.DeliverySize;
            Assert.AreEqual("S", result);
        }

        [TestMethod]
        public void GetDeliverySize_BasketSizeEquals3_DeliverySizeSetToM()
        {
            sut = new Parcel(4, "", 0, "");
            var result = sut.DeliverySize;
            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void GetDeliverySize_BasketSizeEquals6_DeliverySizeSetToL()
        {
            sut = new Parcel(7, "", 0, "");
            var result = sut.DeliverySize;
            Assert.AreEqual("L", result);
        }

        //[TestMethod]
        //public void it_throws()
        //{
        //    Assert.ThrowsException<ArgumentException>(() => new Parcel(4, "", 0, ""));
        //}
    }
}
