using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Persons;

namespace TheKennelProject.Menus
{
    class MenuCustomer : IMenuCustomer
    {
        public IDogManager DogManager { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IBookingManager BookingManager { get; set; }

        public MenuCustomer(IDogManager dogManager, ICustomerManager customerManager, IBookingManager bookingManager)
        {
            DogManager = dogManager;
            CustomerManager = customerManager;
            BookingManager = bookingManager;
        }
        public void Show()
        {
            Console.WriteLine(value: "********************************************");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "          Welcome to the Kennel");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "********************************************");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "1. Register customer");
            Console.WriteLine(value: "2. List registered customer");
            Console.WriteLine(value: "3. List registered customer with their dogs");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "********************************************");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CustomerManager.RegisterCustomer();

                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    CustomerManager.ListCustomers();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    CustomerManager.ListCustomersWithDogs();
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }
        }
    }
}
