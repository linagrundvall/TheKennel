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
        List<IPerson> GetAllCustomers();
        IPerson GetCustomerByPersonalIdNumber(string personalIdentificationNumber);
        void SaveCustomer(IPerson customer);

        //Dogs
        List<IAnimal> GetAllDogs();
        List<IAnimal> GetCurrentDogs();
        IAnimal GetDogByName(string name);
        IAnimal GetDogByOwnersPersonalID(string personalIdentificationNumber);
        void SaveDog(IAnimal dog);

        //Treatment
        List<ITreatment> GetAllTreatments();
        double GetTreatmentPrice(ITreatment dogTreatment);

        //Booking
        List<IBooking> GetAllBookings();
        void SaveBooking(IBooking booking);
    }
}