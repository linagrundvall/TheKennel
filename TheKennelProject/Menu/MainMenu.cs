using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;

namespace TheKennelProject.Menu
{
    class MainMenu : IMainMenu
    {
        public IDogManager DogManager { get; set; }
        public IRoomManager RoomManager { get; set; }

        public MainMenu(IDogManager dogManager, IRoomManager roomManager)
        {
            DogManager = dogManager;
            RoomManager = roomManager;
        }
        public void Show()
        {
            Console.WriteLine(value: "**********************************");
            Console.WriteLine(value: "     Welcome to the Kennel");
            Console.WriteLine(value: "**********************************");
            Console.WriteLine(value: "1. Register dog");
            Console.WriteLine(value: "2. Add dog to room");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    DogManager.RegisterDog();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    RoomManager.AddDogToRoom();
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }
        }
    }
}
