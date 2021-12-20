using System;
using System.Collections.Generic;
using TheKennelProject.Bookings;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;
using TheKennelProject.AnimalTreatments;

namespace TheKennelProject.Data
{
    interface IDataRepository
    {
        IDBUsingLists Db { get; set; }

        ICustomer GetCustomerByPersonalIdNumber(string personalIdentificationNumber);
        List<IRoom> GetAllRooms();
        IRoom GetRoomByDog(IDog dog);
        IRoom GetRoomByGuid(Guid guid);
        IRoom GetRoomByRoomNumber(string roomNumber);
        IDog GetDogByName(string name);
        IDog GetDogByOwnersPersonalID(string personalIdentificationNumber);
        void SaveDog(IDog dog);
        void SaveCustomer(ICustomer customer);
        void SaveBooking(IBooking booking);
        double GetTreatmentPrice(ITreatment dogTreatment);
        List<ICustomer> GetAllCustomers();
        List<IDog> GetAllDogs();
        List<IDog> GetCurrentDogs();
        List<IBooking> GetAllBookings();
        List<ITreatment> GetAllTreatments();
        //List<ICustomer> GetCustomersWithDogs();
    }
}