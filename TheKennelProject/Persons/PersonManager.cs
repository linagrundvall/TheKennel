using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;
using TheKennelProject.Factories;

namespace TheKennelProject.Persons
{
    internal class PersonManager : IPersonManager
    {
        public IDataRepository Db { get; set; }

        public PersonManager(IDataRepository db)
        {
            Db = db;
        }

        IPerson person = CustomerFactory.Create();

        public void RegisterPerson()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            person.PersonalIdentificationNumber = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter first name.");
            person.FirstName = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter last name.");
            person.LastName = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter any further notes regarding the person.");
            person.Notes = DataInput.FromConsole();
        }

        public void SavePerson()
        {
            Db.SavePerson(person);
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void ListPersons()
        {
            var persons = Db.GetAllPersons();
            DataOutput.ToConsole("");

            foreach (var person in persons)
            {
                DataOutput.ToConsole(person.FirstName + " " + person.LastName);
            }
            DataOutput.ToConsole("");
        }

        public void ListPersonsWithAnimals()
        {
            var persons = Db.GetAllPersons();
            var animals = Db.GetAllAnimals();

            DataOutput.ToConsole("");

            foreach (var person in persons)
            {
                DataOutput.ToConsole(person.FirstName + " " + person.LastName);

                foreach (var animal in animals)
                {
                    if (animal.OwnersPersonalID == person.PersonalIdentificationNumber)
                    {
                        DataOutput.ToConsole(" is the owner of " + animal.Name);
                    }
                }
                DataOutput.ToConsole("");
            }
            DataOutput.ToConsole("");
        }

        public void ShowPerson()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            IPerson person = Db.GetPersonByPersonalIdNumber(DataInput.FromConsole());

            DataOutput.ToConsole(person.FirstName + " " + person.LastName);
            DataOutput.ToConsole("");
        }
    }
}
