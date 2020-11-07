using System;
namespace HotelReservationSystemProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Reservation System.");
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", "Regular", 110, 90));
            hotel.AddHotel(new Hotel("Bridgewood", "Regular", 150, 50));
            hotel.AddHotel(new Hotel("Ridgewood", "Regular", 220, 150));
            string[] dates = { "10Sep2020", "11Sep2020" };
            Hotel cheapestHotel = hotel.FindCheapestHotel(dates);
            Console.WriteLine("Cheapest Hotel for given dates: " + cheapestHotel.hotelName+ "\nTotal Rate: " + cheapestHotel.weekdayRates * dates.Length);
        }
    }
}
