using System;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.Treatments;

namespace TheKennelProject.Dogs
{
    internal class DogManager : IDogManager
    {
        public IDataRepository Db { get; set; }
        
        public DogManager(IDataRepository db)
        {
            Db = db;
        }
        public void RegisterDog()
        {
            // TODO: Split input into another class/method?
            IDog dog = DogFactory.Create();

            Console.WriteLine(value: "Please enter the dogs name.");
            dog.Name = Console.ReadLine();

            Console.WriteLine(value: "Please enter any further notes regarding the dog.");
            dog.Notes = Console.ReadLine();

            Console.WriteLine(value: "Is the dog having any special treatments?");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "1. Washing");
            Console.WriteLine(value: "2. Cut claws");
            Console.WriteLine(value: "3. No treatments today");
            Console.WriteLine(value: "");
            
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    //Som PetsAllowed etc
                    Console.WriteLine("No treatment");
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }

            Db.SaveDog(dog);
            Console.WriteLine("Dog registered");
            Console.WriteLine(value: "");
        }

        public void RegisterDogTreatment()
        {
            Console.WriteLine(value: "Please enter the dogs name.");
            IDog dog = Db.GetDogByName(Console.ReadLine());

            Console.WriteLine(value: "Is the dog having any special treatments?");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "1. Washing");
            Console.WriteLine(value: "2. Cut claws");
            Console.WriteLine(value: "3. No treatments today");
            Console.WriteLine(value: "");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    //CutClaws.Equals(true);
                    //ITreatment.Equals(true);
                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    //Som PetsAllowed etc
                    Console.WriteLine("No treatment");
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }

        }
    }
}