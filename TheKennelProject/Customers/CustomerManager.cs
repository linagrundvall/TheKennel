using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;
using TheKennelProject.Factories;

namespace TheKennelProject.Customers
{
    internal class CustomerManager : ICustomerManager
    {
        public IDataRepository Db { get; set; }

        public CustomerManager(IDataRepository db)
        {
            Db = db;
        }
        public void RegisterCustomer()
        {
            // TODO: Split input into another class/method?
            ICustomer customer = CustomerFactory.Create();

            Console.WriteLine(value: "Please enter personal identification number.");
            customer.PersonalIdentificationNumber = Console.ReadLine();

            Console.WriteLine(value: "Please enter first name.");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine(value: "Please enter last name.");
            customer.LastName = Console.ReadLine();

            Console.WriteLine(value: "Please enter any further notes regarding the customer.");
            customer.Notes = Console.ReadLine();

            Db.SaveCustomer(customer);
            Console.WriteLine("Customer registered");
        }
    }
}
