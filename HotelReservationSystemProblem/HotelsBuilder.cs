using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem
{
    public class HotelsBuilder
    {
        public List<Hotel> hotelList;
        public HotelsBuilder()
        {
            hotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            hotelList.Add(hotel);
        }
        public Hotel FindCheapestHotel(DateTime[] dates)
        {
            int totalPrice = 0;
            int weekendCount = 0;
            int weekdayCount = 0;
            int minimumRate = 99999;
            Hotel cheapestHotel = null;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendCount++;
                }
                else
                {
                    weekdayCount++;
                }
            }
            foreach (var hotel in hotelList)
            {
                totalPrice = hotel.weekdayRates * weekdayCount + hotel.weekendRates * weekendCount;
                if (totalPrice < minimumRate)
                {
                    minimumRate = totalPrice;
                    cheapestHotel = hotel;
                }
            }
            Console.WriteLine("Total Rate: " + minimumRate);
            return cheapestHotel;
        }
        public Hotel FindCheapestHotel(string[] dates)
        {
            DateTime[] validatedDates = getDates(dates);
            hotelList.Sort((hotel1, hotel2) => hotel1.weekdayRates.CompareTo(hotel2.weekdayRates));
            return hotelList[0];
        }
        public DateTime[] getDates(string[] dates)
        {
            DateTime[] datesValidated = new DateTime[dates.Length];
            for (int i = 0; i < dates.Length; i++)
            {
                datesValidated[i] = ConvertToDate(dates[i]);
            }
            return datesValidated;
        }
        public DateTime ConvertToDate(string enteredDate)
        {
            return DateTime.Parse(enteredDate);
        }
    }
}
