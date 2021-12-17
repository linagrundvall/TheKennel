using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;

namespace TheKennelProject.Data
{

    class DataRepository : IDataRepository
    {
        public IDBUsingLists Db { get; set; }

        public DataRepository(IDBUsingLists db)
        {
            Db = db;
        }
        public ICustomer GetCustomerByPersonalIdNumber(string personalIdentificationNumber)
        {
            return Db.Customers.Where(c => c.PersonalIdentificationNumber == personalIdentificationNumber).FirstOrDefault();
        }

        public IRoom GetRoomByRoomNumber(string roomNumber)
        {
            return Db.Rooms.Where(r => r.RoomNumber == roomNumber).FirstOrDefault();
        }

        public IRoom GetRoomByGuid(Guid guid)
        {
            return Db.Rooms.Where(r => r.ID == guid).FirstOrDefault();
        }

        public List<IRoom> GetAllRooms()
        {
            return Db.Rooms.ToList();
        }

        public IRoom GetRoomByDog(IDog dog)
        {
            return Db.Rooms.Where(r => r.CurrentDogs.Contains(dog)).FirstOrDefault();
        }

        public IDog GetDogByName(string name)
        {
            return Db.Dogs.Where(d => d.Name == name).FirstOrDefault();
        }

        public void SaveDog(IDog dog)
        {
            Db.Dogs.Add(dog);
        }

        public void SaveCustomer(ICustomer customer)
        {
            Db.Customers.Add(customer);
        }

        public List<IDog> GetAllDogs()
        {
            return Db.Dogs.ToList();
        }

        public List<ICustomer> GetAllCustomers()
        {
            return Db.Customers.ToList();
        }

    }
}
