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
    class MainMenu : IMenu
    {
        public IDogManager DogManager { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IBookingManager BookingManager { get; set; }
        public IMenuCustomer MenuForCustomer { get; set; }
        public IMenuDog MenuForDog { get; set; }

        public MainMenu(IDogManager dogManager, ICustomerManager customerManager, IBookingManager bookingManager, IMenuCustomer menuForCustomer, IMenuDog menuForDog)
        {
            DogManager = dogManager;
            CustomerManager = customerManager;
            BookingManager = bookingManager;
            MenuForCustomer = menuForCustomer;
            MenuForDog = menuForDog;
        }

        public void Show()
        {
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("          Welcome to the Kennel");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("1. Customer");
            DataOutput.ToConsole("2. Dog");
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
                    MenuForCustomer.Show();
                    MenuForCustomer.GetInput();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    MenuForDog.Show();
                    MenuForDog.GetInput();
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
