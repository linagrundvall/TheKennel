using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;
using TheKennelProject.Treatments;

namespace TheKennelProject.Data
{
    class DBUsingLists : IDBUsingLists
    {
        public List<IRoom> Rooms { get; set; }

        public List<IDog> Dogs { get; set; }
        public List<ICustomer> Customers { get; set; }
        public List<IBooking> Bookings { get; set; }
        public List<ITreatment> Treatments { get; set; }

        public DBUsingLists()
        {
            Rooms = new List<IRoom>();
            Dogs = new List<IDog>();
            Customers = new List<ICustomer>();
            Bookings = new List<IBooking>();
            Treatments = new List<ITreatment>();
        }
    }
}
