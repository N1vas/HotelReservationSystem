using HotelReservationSystemProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDatesReturnCheapestHotel()
        {
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", "Regular", 110, 90,3,0,0));
            hotel.AddHotel(new Hotel("Bridgewood", "Regular", 150, 50,4, 0, 0));
            hotel.AddHotel(new Hotel("Ridgewood", "Regular", 220, 150,5, 0, 0));
            string[] dates = "11Sep2020,12Sep2020".Split(",");
            DateTime[] date = new DateTime[dates.Length];
            for (int index = 0; index < date.Length; index++)
            {
                date[index] = DateTime.Parse(dates[index]);
            }
            Hotel cheapestHotel = hotel.FindCheapestHotel(date);
            Assert.AreEqual("Lakewood", cheapestHotel.hotelName);
        }
        [TestMethod]
        public void GivenDatesReturnBestRatedHotel()
        {
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", "Regular", 110, 90, 3, 0, 0));
            hotel.AddHotel(new Hotel("Bridgewood", "Regular", 150, 50, 4, 0, 0));
            hotel.AddHotel(new Hotel("Ridgewood", "Regular", 220, 150, 5, 0, 0));
            string[] dates = "11Sep2020,12Sep2020".Split(",");
            DateTime[] date = new DateTime[dates.Length];
            for (int index = 0; index < date.Length; index++)
            {
                date[index] = DateTime.Parse(dates[index]);
            }
            Hotel cheapestHotel = hotel.FindCheapestHotel(date);
            Assert.AreEqual(5, hotel.HighRatedHotel(date).hotelRating);
        }
    }
}
