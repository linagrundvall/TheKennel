using System;
using System.Collections.Generic;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;

namespace TheKennelProject.Data
{
    interface IDataRepository
    {
        IDBUsingLists Db { get; set; }

        List<IRoom> GetAllRooms();
        IRoom GetRoomByDog(IDog dog);
        IRoom GetRoomByGuid(Guid guid);
        IRoom GetRoomByRoomNumber(string roomNumber);
        IDog GetDogByName(string name);
        void SaveDog(IDog dog);
        void SaveCustomer(ICustomer customer);
    }
}