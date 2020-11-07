using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem
{
    public class Hotel
    {
        public string hotelName { get; set; }
        public int regularRates { get; set; }
        public Hotel()
        {
            hotelName = "";
            regularRates = 0;
        }
        public Hotel(string hotelName, int regularRates)
        {
            this.hotelName = hotelName;
            this.regularRates = regularRates;
        }
    }
}
