using System;
using System.Collections.Generic;
using TheKennelProject.Bookings;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.Data
{
    interface IDataRepository
    {
        IDBUsingLists Db { get; set; }

        //Customers
        List<IPerson> GetAllPersons();
        IPerson GetPersonByPersonalIdNumber(string personalIdentificationNumber);
        void SavePerson(IPerson customer);

        //Dogs
        List<IAnimal> GetAllAnimals();
        List<IAnimal> GetCurrentAnimals();
        IAnimal GetAnimalByName(string name);
        IAnimal GetAnimalByOwnersPersonalID(string personalIdentificationNumber);
        void SaveAnimal(IAnimal animal);

        //Treatment
        List<ITreatment> GetAllTreatments();
        double GetTreatmentPrice(ITreatment animalTreatment);

        //Booking
        List<IBooking> GetAllBookings();
        void SaveBooking(IBooking booking);
    }
}