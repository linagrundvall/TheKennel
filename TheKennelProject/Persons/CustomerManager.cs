using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.Persons;

namespace TheKennelProject.Persons
{
    internal class CustomerManager : ICustomerManager
    {
        public IDataRepository Db { get; set; }

        public CustomerManager(IDataRepository db)
        {
            Db = db;
        }

        IPerson customer = CustomerFactory.Create();

        public void RegisterCustomer()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            customer.PersonalIdentificationNumber = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter first name.");
            customer.FirstName = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter last name.");
            customer.LastName = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter any further notes regarding the customer.");
            customer.Notes = DataInput.FromConsole();
        }

        public void SaveCustomer()
        {
            Db.SaveCustomer(customer);
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void ListCustomers()
        {
            var customers = Db.GetAllCustomers();
            DataOutput.ToConsole("");

            foreach (var customer in customers)
            {
                DataOutput.ToConsole(customer.FirstName + " " + customer.LastName);
            }
            DataOutput.ToConsole("");
        }

        public void ListCustomersWithDogs()
        {
            var customers = Db.GetAllCustomers();
            var dogs = Db.GetAllDogs();

            DataOutput.ToConsole("");

            foreach (var customer in customers)
            {
                DataOutput.ToConsole(customer.FirstName + " " + customer.LastName);

                foreach (var dog in dogs)
                {
                    if (dog.OwnersPersonalID == customer.PersonalIdentificationNumber)
                    {
                        DataOutput.ToConsole(" is the owner of " + dog.Name);
                    }
                }
                DataOutput.ToConsole("");
            }
            DataOutput.ToConsole("");
        }

        public void ShowCustomer()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            IPerson customer = Db.GetCustomerByPersonalIdNumber(DataInput.FromConsole());

            DataOutput.ToConsole(customer.FirstName + " " + customer.LastName);
            DataOutput.ToConsole("");
        }
    }
}
