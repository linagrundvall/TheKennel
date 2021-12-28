using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;
using TheKennelProject.Data;
using TheKennelProject.Factories;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Menus;

namespace TheKennelProject.Animals
{
    internal class AnimalManager : IAnimalManager
    {
        public IDataRepository Db { get; set; }

        public AnimalManager(IDataRepository db)
        {
            Db = db;
        }

        IAnimal animal = DogFactory.Create();

        public void RegisterAnimal()
        {
            DataOutput.ToConsole("Please enter personal identification number.");
            animal.OwnersPersonalID = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter the animals name.");
            animal.Name = DataInput.FromConsole();

            DataOutput.ToConsole("Please enter any further notes regarding the animal.");
            animal.Notes = DataInput.FromConsole();
        }

        public void SaveAnimal()
        {
            IBooking booking = BookingFactory.Create();
            animal.BookingID = booking.ID;

            Db.SaveAnimal(animal);
            Db.SaveBooking(booking);
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void RegisterAnimalTreatment()
        {
            DataOutput.ToConsole("Please enter the animals name.");
            IAnimal animal = Db.GetAnimalByName(DataInput.FromConsole());
            DataOutput.ToConsole("");

            DataOutput.ToConsole("What treatment is the animal having?");
            DataOutput.ToConsole("");
            DataOutput.ToConsole("1. Washing");
            DataOutput.ToConsole("2. Cut claws");
            DataOutput.ToConsole("");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddWash(animal);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    AddCutClaws(animal);
                    break;
                default:
                    DataOutput.ToConsole("Unknown command. Please try again.");
                    break;
            }
            DataOutput.ToConsole("");
        }

        public void AddCutClaws(IAnimal animal)
        {
            ITreatment cutClaws = new CutClaws();
            cutClaws.TrueOrFalse = true;
            animal.Treatments.Add(cutClaws);
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void AddWash(IAnimal animal)
        {
            ITreatment wash = new Wash();
            wash.TrueOrFalse = true;
            animal.Treatments.Add(wash);
            DataOutput.ToConsole("Registration succeeded!");
            DataOutput.ToConsole("");
        }

        public void CheckInAnimal()
        {
            DataOutput.ToConsole("Please enter the name of the animal");
            IAnimal animal = Db.GetAnimalByName(DataInput.FromConsole());
            animal.IsCheckedIn = true;
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Check in succeeded!");
            DataOutput.ToConsole("");
        }

        public void CheckOutAnimal()
        {
            DataOutput.ToConsole("Please enter the name of the animal");
            IAnimal animal = Db.GetAnimalByName(DataInput.FromConsole());

            double totalPrice = GetPriceTreatments(animal) + GetPriceBooking(animal);

            animal.IsCheckedIn = false;
            DataOutput.ToConsole("");
            DataOutput.ToConsole("Check out succeeded!");
            DataOutput.ToConsole("Total price is: " + totalPrice + " kr");
            DataOutput.ToConsole("");
        }

        public double GetPriceBooking(IAnimal animal)
        {
            var bookings = Db.GetAllBookings();
            var priceBooking = 0.0;
            foreach (var booking in bookings)
            {
                if (booking.ID == animal.BookingID || animal.IsCheckedIn == true)
                {
                    priceBooking += booking.Price;
                }
                else
                {
                    DataOutput.ToConsole("Sorry. The animal is not here.");
                }
            }
            return priceBooking;
        }

        public double GetPriceTreatments(IAnimal animal)
        {
            var treatments = animal.Treatments;
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

        public void ListAnimals()
        {
            var animals = Db.GetAllAnimals();
            DataOutput.ToConsole("");

            foreach (var animal in animals)
            {
                DataOutput.ToConsole(animal.Name);
            }
            DataOutput.ToConsole("");
        }

        public void ListCurrentAnimals()
        {
            var animals = Db.GetCurrentAnimals();
            var persons = Db.GetAllPersons();

            DataOutput.ToConsole("");

            foreach (var animal in animals)
            {
                DataOutput.ToConsole(animal.Name);

                foreach (var person in persons)
                {
                    if (person.PersonalIdentificationNumber == animal.OwnersPersonalID)
                    {
                        DataOutput.ToConsole(" and its owner " + person.FirstName + " " + person.LastName);
                        DataOutput.ToConsole("");
                    }
                }
            }
            DataOutput.ToConsole("");
        }
    }
}
