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
    class MenuPerson : IMenuPerson
    {
        public IAnimalManager AnimalManager { get; set; }
        public IPersonManager PersonManager { get; set; }
        public IBookingManager BookingManager { get; set; }

        public MenuPerson(IAnimalManager animalManager, IPersonManager personManager, IBookingManager bookingManager)
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
            DataOutput.ToConsole("1. Register person");
            DataOutput.ToConsole("2. List registered persons");
            DataOutput.ToConsole("3. List registered persons with their dogs");
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
                    PersonManager.RegisterPerson();
                    PersonManager.SavePerson();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    PersonManager.ListPersons();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    PersonManager.ListPersonsWithAnimals();
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
