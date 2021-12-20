using System;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Dogs;
using TheKennelProject.Customers;
using System.Collections.Generic;
using System.Linq;
using TheKennelProject.Bookings;

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
            IDog dog = DogFactory.Create();
            
            // TODO: Split input into another class/method?
            Console.WriteLine(value: "Please enter personal identification number.");
            dog.OwnersPersonalID = Console.ReadLine();

            // TODO: Flytta personnummer till egen klass?

            Console.WriteLine(value: "Please enter the dogs name.");
            dog.Name = Console.ReadLine();

            Console.WriteLine(value: "Please enter any further notes regarding the dog.");
            dog.Notes = Console.ReadLine();

            IBooking booking = BookingFactory.Create();
            dog.BookingID = booking.ID;

            Db.SaveDog(dog);
            Db.SaveBooking(booking);
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
                //TODO: Ta ut metoderna i nya metoder
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    var treatments = new List<ITreatment>();
                    ITreatment wash = new Wash();
                    wash.TrueOrFalse = true;
                    dog.Treatments.Add(wash);
                    Console.WriteLine("Treatment registered");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    var treatments2 = new List<ITreatment>();
                    ITreatment cutClaws = new CutClaws();
                    cutClaws.TrueOrFalse = true;
                    dog.Treatments.Add(cutClaws);
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
            //Db.SaveDog(dog);
            Console.WriteLine(value: "");
        }
        public void CheckInDog()
        {
            // TODO: Break out into different methods?
            Console.WriteLine(value: "Please enter the name of the dog");
            IDog dog = Db.GetDogByName(Console.ReadLine());
            dog.IsCheckedIn = true;
            Console.WriteLine(value: "");
            Console.WriteLine("The dog has been checked in");
            Console.WriteLine(value: "");
        }

        public void CheckOutDog()
        {
            // TODO: Break out into different methods?
            Console.WriteLine(value: "Please enter the name of the dog");
            
            IDog dog = Db.GetDogByName(Console.ReadLine());
            Console.WriteLine(value: "");
            Console.WriteLine("The dog has been checked out");
            Console.WriteLine(value: "");

            //TODO: Lägg denna i BookingManager?

            var bookings = Db.GetAllBookings();
            var treatments = dog.Treatments;
            var totalPrice = 0.0;
            foreach (var treatment in treatments)
            {
                if (treatment.Name == "Wash")
                {
                    totalPrice += Db.GetTreatmentPrice(treatment);
                }
                else if (treatment.Name == "CutClaws")
                {
                    totalPrice += Db.GetTreatmentPrice(treatment);
                }
            }
            
            foreach (var booking in bookings)
            {
                if (booking.ID == dog.BookingID || dog.IsCheckedIn == true)
                {
                    totalPrice += booking.Price;

                    Console.WriteLine("Total price is: " + totalPrice + " kr");
                }
                else
                {
                    Console.WriteLine("Sorry. The dog is not here.");
                }

            }

            dog.IsCheckedIn = false;
            Console.WriteLine("Hey");

            //if (dog.Treatments.Count > 0)
            //{
                //if (dog.Treatments.Contains(ITreatment Wash))
                ////Wash.TrueOrFalse == true
                ////treatments.CutClaws = true
                //{
                //    var totalPrice = bookingPrice + treatments.Wash.Price;
                //}

                //if (dog.Treatments.Contains(ITreatment CutClaws))
                //{
                //    var totalPrice = bookingPrice + treatments.Wash.Price;
                //}

            //var treatments = new List<ITreatment>();
            //ITreatment wash = new Wash();
            //wash.TrueOrFalse = true;
            //dog.Treatments.Add(wash);
        }

        public void ListDogs()
        {
            var dogs = Db.GetAllDogs();
            Console.WriteLine("");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }
            Console.WriteLine("");
        }

        public void ListCurrentDogs()
        {
            var dogs = Db.GetCurrentDogs();
            var customers = Db.GetAllCustomers();

            Console.WriteLine("");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name);

                foreach (var customer in customers)
                {
                    if (customer.PersonalIdentificationNumber == dog.OwnersPersonalID)
                    {
                        Console.WriteLine(" and its owner " + customer.FirstName + " " + customer.LastName);
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}

