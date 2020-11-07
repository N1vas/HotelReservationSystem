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
            int weekdayRates = 110;
            int weekendRates = 90;
            HotelsBuilder hotels = new HotelsBuilder();
            Hotel hotel = new Hotel(hotelName, "Regular", weekdayRates, weekendRates);
            hotels.AddHotel(hotel);
            Assert.AreEqual("Lakewood", hotels.hotelList[0].hotelName);
            Assert.AreEqual(110, hotels.hotelList[0].weekdayRates);
        }
        [TestMethod]
        public void TestMethod2()
        {
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", "Regular", 110, 90));
            hotel.AddHotel(new Hotel("Bridgewood", "Regular", 150, 50));
            hotel.AddHotel(new Hotel("Ridgewood", "Regular", 220, 150));
            string[] dates = {"01Jan2019","11Dec2020"};
            Hotel cheapestHotel = hotel.FindCheapestHotel(dates);
            Assert.AreEqual("Lakewood", cheapestHotel.hotelName);
            Assert.AreEqual(220, cheapestHotel.weekdayRates * dates.Length);

        }
    }
}
