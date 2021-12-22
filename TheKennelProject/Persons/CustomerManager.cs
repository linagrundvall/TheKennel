﻿using System;
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
        public void RegisterCustomer()
        {
            IPerson customer = CustomerFactory.Create();
            // TODO: Split input into another class/method?

            Console.WriteLine(value: "Please enter personal identification number.");
            customer.PersonalIdentificationNumber = Console.ReadLine();

            Console.WriteLine(value: "Please enter first name.");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine(value: "Please enter last name.");
            customer.LastName = Console.ReadLine();

            Console.WriteLine(value: "Please enter any further notes regarding the customer.");
            customer.Notes = Console.ReadLine();

            Db.SaveCustomer(customer);
            Console.WriteLine("");
            Console.WriteLine("Customer registered");
            Console.WriteLine("");
        }

        public void ListCustomers()
        {
            var customers = Db.GetAllCustomers();
            Console.WriteLine("");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }
            Console.WriteLine("");
        }

        public void ListCustomersWithDogs()
        {
            var customers = Db.GetAllCustomers();
            var dogs = Db.GetAllDogs();
            
            Console.WriteLine("");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);

                foreach (var dog in dogs)
                {
                    if (dog.OwnersPersonalID == customer.PersonalIdentificationNumber)
                    {
                        Console.WriteLine(" is the owner of " + dog.Name);
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public void ShowCustomer()
        {
            Console.WriteLine(value: "Please enter personal identification number.");
            IPerson customer = Db.GetCustomerByPersonalIdNumber(Console.ReadLine());
            
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
            Console.WriteLine("");
        }
    }
}