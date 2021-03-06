using System.Collections.Generic;
using TheKennelProject.Bookings;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.Data
{
    interface IDBUsingLists
    {
        public List<IPerson> Persons { get; set; }
        public List<IAnimal> Animals { get; set; }
        public List<ITreatment> Treatments { get; set; }
        public List<IBooking> Bookings { get; set; }
    }
}