using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Bookings
{
    class Booking : IBooking
    {
        public Guid ID { get; set; }
        public decimal Price { get; set; }

        public Booking()
        {
            ID = Guid.NewGuid();
        }
    }
}
