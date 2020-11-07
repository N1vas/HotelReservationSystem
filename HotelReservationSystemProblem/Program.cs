using System;
namespace HotelReservationSystemProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Rservation System.");
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", 110));
            hotel.AddHotel(new Hotel("Ridgewood", 220));
            hotel.AddHotel(new Hotel("Bridgewood", 150));
        }
    }
}
