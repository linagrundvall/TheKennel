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
    class MenuAnimal : IMenuAnimal
    {
        public IAnimalManager AnimalManager { get; set; }
        public IPersonManager PersonManager { get; set; }
        public IBookingManager BookingManager { get; set; }

        public MenuAnimal(IAnimalManager animalManager, IPersonManager personManager, IBookingManager bookingManager)
        {
            AnimalManager = animalManager;
            PersonManager = personManager;
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
            DataOutput.ToConsole("1. Register animal");
            DataOutput.ToConsole("2. Register special treatment for animal");
            DataOutput.ToConsole("3. Check in animal");
            DataOutput.ToConsole("4. Check out animal");
            DataOutput.ToConsole("5. List registered animals");
            DataOutput.ToConsole("6. List current animals with their owners");
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
                    AnimalManager.RegisterAnimal();
                    AnimalManager.SaveAnimal();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    AnimalManager.RegisterAnimalTreatment();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AnimalManager.CheckInAnimal();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    AnimalManager.CheckOutAnimal();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    AnimalManager.ListAnimals();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    AnimalManager.ListCurrentAnimals();
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
