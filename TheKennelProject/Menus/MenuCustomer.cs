using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Data;
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
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("          Welcome to the Kennel");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("1. Register customer");
            DataOutput.ToConsole("2. List registered customer");
            DataOutput.ToConsole("3. List registered customer with their dogs");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("********************************************");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CustomerManager.RegisterCustomer();
                    CustomerManager.SaveCustomer();
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
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
