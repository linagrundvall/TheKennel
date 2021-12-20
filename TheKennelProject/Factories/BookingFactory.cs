using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;

namespace TheKennelProject.Factories
{
    class BookingFactory
    {
        public static IBooking Create()
        {
            return new Booking();
        }
    }
}
