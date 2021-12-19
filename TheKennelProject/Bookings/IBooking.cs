using System;

namespace TheKennelProject.Bookings
{
    interface IBooking
    {
        public Guid ID { get; set; }
        decimal Price { get; set; }
    }
}