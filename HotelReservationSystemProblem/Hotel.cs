using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem
{
    public class Hotel
    {
        public string hotelName { get; set; }
        public string customerType { get; set; }
        public int weekdayRates { get; set; }
        public int weekendRates { get; set; }
        public Hotel()
        {
            hotelName = "";
            customerType = "";
            weekdayRates = 0;
            weekendRates = 0;
        }
        public Hotel(string hotelName, string customerType, int weekdayRates, int weekendRates)
        {
            this.hotelName = hotelName;
            this.customerType = customerType;
            this.weekdayRates = weekdayRates;
            this.weekendRates = weekendRates;
        }
    }
}
