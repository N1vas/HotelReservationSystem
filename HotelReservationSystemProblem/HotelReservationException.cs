using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystemProblem
{
    public class HotelReservationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_HOTEL_TYPE
        }
        ExceptionType type;
        public HotelReservationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
