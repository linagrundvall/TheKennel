using System.Collections.Generic;
using TheKennelProject.Bookings;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;
using TheKennelProject.AnimalTreatments;

namespace TheKennelProject.Data
{
    interface IDBUsingLists
    {
        public List<ICustomer> Customers { get; set; }
        public List<IDog> Dogs { get; set; }
        public List<IRoom> Rooms { get; set; }
        public List<IBooking> Bookings { get; set; }
        public List<ITreatment> Treatments { get; set; }
    }
}