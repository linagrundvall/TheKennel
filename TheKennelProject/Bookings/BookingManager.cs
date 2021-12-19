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
            //var List<IRoom> rooms = Db.GetAllRooms();
            var bookings = Db.GetAllBookings();
            var dogs = Db.GetAllDogs();
            

            //foreach (var dog in dogs)
            //{
            //    foreach (var treatment in dog)
            //    {
            //        Console.WriteLine(treatment.Name);
            //        Console.WriteLine(treatment.TrueOrFalse);
            //    }
            //}
        }
        //foreach (var room in rooms)
        //        {
        //            foreach (var property in room.RoomProperties)
        //            {
        //                Console.WriteLine(property.Name);
        //                Console.WriteLine(property.TrueOrFalse);
        //            }
}

//public void GetReceipt()
//        {
//         
        
//    }
    }
}
