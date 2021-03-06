﻿using System;
namespace HotelReservationSystemProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Reservation System.");
            HotelsBuilder hotel = new HotelsBuilder();
            hotel.AddHotel(new Hotel("Lakewood", "Regular", 110, 90,3,80,80));
            hotel.AddHotel(new Hotel("Bridgewood", "Regular", 150, 50,4,110,50));
            hotel.AddHotel(new Hotel("Ridgewood", "Regular", 220, 150,5,100,40));
            string[] dates = { "11Sep2020", "12Sep2020" };
            DateTime[] date = new DateTime[dates.Length];
            for (int index = 0; index < date.Length; index++)
            {
                date[index] = DateTime.Parse(dates[index]);
            }
            Hotel ratedHotel = hotel.FindCheapestHotel(date);
            Console.WriteLine("Best Rated Hotel for given dates: " + ratedHotel.hotelName);
        }
    }
}
