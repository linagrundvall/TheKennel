using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;

namespace TheKennelProject.Bookings
{
    class BookingManager : IBookingManager
    {
        public IDataRepository Db { get; set; }

        public BookingManager(IDataRepository db)
        {
            Db = db;
        }

        public void ListBookings()
        {
            Db.GetAllBookings();
        }
    }
}
