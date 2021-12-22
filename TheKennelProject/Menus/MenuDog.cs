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
    class MenuDog : IMenuDog
    {
        public IDogManager DogManager { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IBookingManager BookingManager { get; set; }

        public MenuDog(IDogManager dogManager, ICustomerManager customerManager, IBookingManager bookingManager)
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
            DataOutput.ToConsole("1. Register dog");
            DataOutput.ToConsole("2. Register special treatment for dog");
            DataOutput.ToConsole("3. Check in dog");
            DataOutput.ToConsole("4. Check out dog");
            DataOutput.ToConsole("5. List registered dogs");
            DataOutput.ToConsole("6. List current dogs with their owners");
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
                    DogManager.RegisterDog();
                    DogManager.SaveDog();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    DogManager.RegisterDogTreatment();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    DogManager.CheckInDog();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    DogManager.CheckOutDog();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    DogManager.ListDogs();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    DogManager.ListCurrentDogs();
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
