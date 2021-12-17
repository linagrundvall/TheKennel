using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Customers;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;

namespace TheKennelProject.Menu
{
    class MainMenu : IMainMenu
    {
        public IDogManager DogManager { get; set; }
        public IRoomManager RoomManager { get; set; }
        public ICustomerManager CustomerManager { get; set; }

        public MainMenu(IDogManager dogManager, IRoomManager roomManager, ICustomerManager customerManager)
        {
            DogManager = dogManager;
            RoomManager = roomManager;
            CustomerManager = customerManager;
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
            Console.WriteLine(value: "2. Register dog");
            Console.WriteLine(value: "3. Register special treatment for dog");
            Console.WriteLine(value: "4. Check in dog");
            Console.WriteLine(value: "5. Check out dog");
            Console.WriteLine(value: "6. List customers");
            Console.WriteLine(value: "7. List dogs");
            Console.WriteLine(value: "8. List current dogs");
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
                    DogManager.RegisterDog();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    DogManager.RegisterDogTreatment();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    DogManager.CheckInDog();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    DogManager.CheckOutDog();

                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    CustomerManager.ListCustomers();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    DogManager.ListDogs();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Console.WriteLine("List current animals");
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }
        }
    }
}
