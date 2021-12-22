using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.Data
{
    class DBUsingLists : IDBUsingLists
    {
        public List<IPerson> Customers { get; set; }
        public List<IAnimal> Dogs { get; set; }
        public List<ITreatment> Treatments { get; set; }
        public List<IBooking> Bookings { get; set; }

        public DBUsingLists()
        {
            Customers = new List<IPerson>();
            Dogs = new List<IAnimal>();
            Treatments = new List<ITreatment>();
            Bookings = new List<IBooking>();
        }
    }
}
