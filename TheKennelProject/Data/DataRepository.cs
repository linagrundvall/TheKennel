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
        public List<IPerson> GetAllPersons()
        {
            return Db.Persons.ToList();
        }

        public IPerson GetPersonByPersonalIdNumber(string personalIdentificationNumber)
        {
            return Db.Persons.Where(c => c.PersonalIdentificationNumber == personalIdentificationNumber).FirstOrDefault();
        }

        public void SavePerson(IPerson person)
        {
            Db.Persons.Add(person);
        }
        #endregion

        #region Dogs
        public List<IAnimal> GetAllAnimals()
        {
            return Db.Animals.ToList();
        }

        public List<IAnimal> GetCurrentAnimals()
        {
            return Db.Animals.Where(d => d.IsCheckedIn == true).ToList();
        }

        public IAnimal GetAnimalByName(string name)
        {
            return Db.Animals.Where(d => d.Name == name).FirstOrDefault();
        }

        public IAnimal GetAnimalByOwnersPersonalID(string personalIdentificationNumber)
        {
            return Db.Animals.Where(d => d.OwnersPersonalID == personalIdentificationNumber).FirstOrDefault();
        }

        public void SaveAnimal(IAnimal animal)
        {
            Db.Animals.Add(animal);
        }
        #endregion

        #region Treatments
        public List<ITreatment> GetAllTreatments()
        {
            return Db.Treatments.ToList();
        }

        public double GetTreatmentPrice(ITreatment animalTreatment)
        {
            var treatments = GetAllTreatments();
            foreach (var treatment in treatments)
            {
                if (treatment.Name == animalTreatment.Name)
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
