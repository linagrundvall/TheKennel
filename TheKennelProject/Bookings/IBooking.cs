using System;

namespace TheKennelProject.Bookings
{
    interface IBooking
    {
        Guid ID { get; set; }
        double Price { get; set; }
    }
}