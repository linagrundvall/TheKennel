using System;

namespace TheKennelProject.Bookings
{
    interface IBooking
    {
        Guid ID { get; set; }
        decimal Price { get; set; }
    }
}