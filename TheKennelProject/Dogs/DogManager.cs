﻿using System;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.Treatments;
using TheKennelProject.Dogs;

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

            Console.WriteLine(value: "Do you want the dog to have any treatments?");
            Console.WriteLine(value: "");
            Console.WriteLine(value: "1. Yes");
            Console.WriteLine(value: "2. No");
            Console.WriteLine(value: "");
            
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    RegisterDogTreatment();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("No treatment today");
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

            Console.WriteLine(value: "What treatment is the dog having?");
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
                    ITreatment cutClaws = new CutClaws();
                    cutClaws.TrueOrFalse = true;
                    //dog.Treatments.Add(cutClaws);

                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    //ITreatment wash = new Wash();
                    //wash.TrueOrFalse = true;
                    //dog.Treatments.Add(wash);
                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    Console.WriteLine("No treatment today");
                    break;
                default:
                    Console.WriteLine(value: "Unknown command. Please try again.");
                    break;
            }
            Db.SaveDog(dog);
            Console.WriteLine("Treatment registered");
            Console.WriteLine(value: "");
        }
    }
}