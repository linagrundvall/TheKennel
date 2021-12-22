using System;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.AnimalTreatments;
using System.Collections.Generic;
using System.Linq;
using TheKennelProject.Bookings;
using TheKennelProject.Animals;

namespace TheKennelProject.Animals
{
    internal class DogManager : IDogManager
    {
        public IDataRepository Db { get; set; }

        public DogManager(IDataRepository db)
        {
            Db = db;
        }

        IAnimal dog = DogFactory.Create();

        public void RegisterDog()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            dog.OwnersPersonalID = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter the dogs name.");
            dog.Name = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter any further notes regarding the dog.");
            dog.Notes = DataInput.FromConsole();
        }

        public void SaveDog()
        {
            IBooking booking = BookingFactory.Create();
            dog.BookingID = booking.ID;

            Db.SaveDog(dog);
            Db.SaveBooking(booking);
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void RegisterDogTreatment()
        {
            DataOutput.ToConsole("Please enter the dogs name.");
            IAnimal dog = Db.GetDogByName(DataInput.FromConsole());
            DataOutput.ToConsole("");

            DataOutput.ToConsole("What treatment is the dog having?");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("1. Washing");
            DataOutput.ToConsole("2. Cut claws");
            DataOutput.ToConsole("3. No treatments today");
            DataOutput.ToConsole("");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddWash(dog);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    AddCutClaws(dog);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    DataOutput.ToConsole("No treatment today");
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
            DataOutput.ToConsole("");
        }

        public void AddCutClaws(IAnimal dog)
        {
            ITreatment cutClaws = new CutClaws();
            cutClaws.TrueOrFalse = true;
            dog.Treatments.Add(cutClaws);
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void AddWash(IAnimal dog)
        {
            ITreatment wash = new Wash();
            wash.TrueOrFalse = true;
            dog.Treatments.Add(wash);
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void CheckInDog()
        {
            DataOutput.ToConsole("Please enter the name of the dog");
            IAnimal dog = Db.GetDogByName(DataInput.FromConsole());
            dog.IsCheckedIn = true;
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Check in succeeded!");
            DataOutput.ToConsole("");
        }

        public void CheckOutDog()
        {
            DataOutput.ToConsole("Please enter the name of the dog");
            IAnimal dog = Db.GetDogByName(DataInput.FromConsole());

            double totalPrice = GetPriceTreatments(dog) + GetPriceBooking(dog);

            dog.IsCheckedIn = false;
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Check out succeeded!");
            DataOutput.ToConsole("Total price is: " + totalPrice + " kr");
            DataOutput.ToConsole("");
        }

        public double GetPriceBooking(IAnimal dog)
        {
            var bookings = Db.GetAllBookings();
            var priceBooking = 0.0;
            foreach (var booking in bookings)
            {
                if (booking.ID == dog.BookingID || dog.IsCheckedIn == true)
                {
                    priceBooking += booking.Price;
                }
                else
                {
                    DataOutput.ToConsole("Sorry. The dog is not here.");
                }
            }
            return priceBooking;
        }

        public double GetPriceTreatments(IAnimal dog)
        {
            var treatments = dog.Treatments;
            var priceTreatments = 0.0;
            foreach (var treatment in treatments)
            {
                if (treatment.Name == "Wash")
                {
                    priceTreatments += Db.GetTreatmentPrice(treatment);
                }
                else if (treatment.Name == "CutClaws")
                {
                    priceTreatments += Db.GetTreatmentPrice(treatment);
                }
            }
            return priceTreatments;
        }

        public void ListDogs()
        {
            var dogs = Db.GetAllDogs();
            DataOutput.ToConsole("");

            foreach (var dog in dogs)
            {
                DataOutput.ToConsole(dog.Name);
            }
            DataOutput.ToConsole("");
        }

        public void ListCurrentDogs()
        {
            var dogs = Db.GetCurrentDogs();
            var customers = Db.GetAllCustomers();

            DataOutput.ToConsole("");

            foreach (var dog in dogs)
            {
                DataOutput.ToConsole(dog.Name);

                foreach (var customer in customers)
                {
                    if (customer.PersonalIdentificationNumber == dog.OwnersPersonalID)
                    {
                        DataOutput.ToConsole(" and its owner " + customer.FirstName + " " + customer.LastName);
                        DataOutput.ToConsole("");
                    }
                }
            }
            DataOutput.ToConsole("");
        }
    }
}

