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
    }
}
