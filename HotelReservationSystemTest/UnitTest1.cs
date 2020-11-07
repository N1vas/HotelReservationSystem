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
        [TestMethod]
        public void TestMethod2()
        {
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", 110));
            hotel.AddHotel(new Hotel("Ridgewood", 220));
            hotel.AddHotel(new Hotel("Bridgewood", 150));
            string[] dates = {"01Jan2019","11Dec2020"};
            Hotel cheapestHotel = hotel.FindCheapestHotel(dates);
            Assert.AreEqual("Lakewood", cheapestHotel.hotelName);
            Assert.AreEqual(220, cheapestHotel.regularRates * dates.Length);

        }
    }
}
