using HotelReservationSystemProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string hotelName = "Lakewood";
            int regularRates = 110;
            HotelsBuilder hotels = new HotelsBuilder();
            Hotel hotel = new Hotel(hotelName, regularRates);
            hotels.AddHotel(hotel);
            Assert.AreEqual("Lakewood", hotels.hotelList[0].hotelName);
            Assert.AreEqual(110, hotels.hotelList[0].regularRates);
        }
    }
}
