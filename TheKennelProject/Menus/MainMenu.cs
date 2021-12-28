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
        public IAnimalManager AnimalManager { get; set; }
        public IPersonManager PersonManager { get; set; }
        public IBookingManager BookingManager { get; set; }
        public IMenuPerson MenuForPerson { get; set; }
        public IMenuAnimal MenuForAnimal { get; set; }

        public MainMenu(IAnimalManager animalManager, IPersonManager personManager, IBookingManager bookingManager, IMenuPerson menuForPerson, IMenuAnimal menuForAnimal)
        {
            AnimalManager = animalManager;
            PersonManager = personManager;
            BookingManager = bookingManager;
            MenuForPerson = menuForPerson;
            MenuForAnimal = menuForAnimal;
        }

        public void Show()
        {
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("          Welcome to the Kennel");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("********************************************");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("1. Person");
            DataOutput.ToConsole("2. Animal");
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
                    MenuForPerson.Show();
                    MenuForPerson.GetInput();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    MenuForAnimal.Show();
                    MenuForAnimal.GetInput();
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
