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

    class DataRepository : IDataRepository
    {
        public IDBUsingLists Db { get; set; }

        public DataRepository(IDBUsingLists db)
        {
            Db = db;
        }

        #region Customer
        public List<IPerson> GetAllCustomers()
        {
            return Db.Customers.ToList();
        }

        public IPerson GetCustomerByPersonalIdNumber(string personalIdentificationNumber)
        {
            return Db.Customers.Where(c => c.PersonalIdentificationNumber == personalIdentificationNumber).FirstOrDefault();
        }

        public void SaveCustomer(IPerson customer)
        {
            Db.Customers.Add(customer);
        }
        #endregion

        #region Dogs
        public List<IAnimal> GetAllDogs()
        {
            return Db.Dogs.ToList();
        }

        public List<IAnimal> GetCurrentDogs()
        {
            return Db.Dogs.Where(d => d.IsCheckedIn == true).ToList();
        }

        public IAnimal GetDogByName(string name)
        {
            return Db.Dogs.Where(d => d.Name == name).FirstOrDefault();
        }

        public IAnimal GetDogByOwnersPersonalID(string personalIdentificationNumber)
        {
            return Db.Dogs.Where(d => d.OwnersPersonalID == personalIdentificationNumber).FirstOrDefault();
        }

        public void SaveDog(IAnimal dog)
        {
            Db.Dogs.Add(dog);
        }
        #endregion

        #region Treatments
        public List<ITreatment> GetAllTreatments()
        {
            return Db.Treatments.ToList();
        }

        public double GetTreatmentPrice(ITreatment dogTreatment)
        {
            var treatments = GetAllTreatments();
            foreach (var treatment in treatments)
            {
                if (treatment.Name == dogTreatment.Name)
                {
                    return treatment.Price;
                }
            }
            return 0.0;
        }
        #endregion

        #region Booking
        public List<IBooking> GetAllBookings()
        {
            return Db.Bookings.ToList();
        }

        public void SaveBooking(IBooking booking)
        {
            Db.Bookings.Add(booking);
        }
        #endregion
    }
}
