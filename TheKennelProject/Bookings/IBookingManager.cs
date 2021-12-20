using TheKennelProject.Data;

namespace TheKennelProject.Bookings
{
    interface IBookingManager
    {
        IDataRepository Db { get; set; }

        void GetReceipt();
        void ListBookings();
        //void ListBookingByPersonalID()
    }
}