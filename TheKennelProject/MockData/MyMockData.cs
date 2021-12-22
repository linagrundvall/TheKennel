using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;
using TheKennelProject.Data;
using TheKennelProject.AnimalTreatments;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.MockData
{
    class MyMockData : IMyMockData
    {
        public IDBUsingLists Db { get; set; }
        public MyMockData(IDBUsingLists databaseUsingLists)
        {
            Db = databaseUsingLists;
        }

        public void GeneratePrice()
        {
            var booking = new Booking();
            booking.Price = 500;
            Db.Bookings.Add(booking);

            var cutClaws = new CutClaws();
            cutClaws.Price = 200;
            Db.Treatments.Add(cutClaws);

            var wash = new Wash();
            wash.Price = 200;
            Db.Treatments.Add(wash);
        }

        public void MakeCustomers()
        {
            var Sven = new Customer();
            Sven.FirstName = "Sven";
            Sven.LastName = "Svensson";
            Sven.PersonalIdentificationNumber = "1234";
            Db.Customers.Add(Sven);

            var Eva = new Customer();
            Eva.FirstName = "Eva";
            Eva.LastName = "Evasdottir";
            Eva.PersonalIdentificationNumber = "5678";
            Db.Customers.Add(Eva);

            var Adam = new Customer();
            Adam.FirstName = "Adam";
            Adam.LastName = "Adamsson";
            Adam.PersonalIdentificationNumber = "4321";
            Db.Customers.Add(Adam);
        }

        public void MakeDogs()
        {
            var Lina = new Dog();
            Lina.Name = "Lina";
            Lina.Notes = "She is a kind dog. Likes belly rubs";
            Lina.OwnersPersonalID = "5678";
            Lina.IsCheckedIn = true;
            Db.Dogs.Add(Lina);

            var Nina = new Dog();
            Nina.Name = "Nina";
            Nina.Notes = "Loves long walks in the forrest.";
            Nina.OwnersPersonalID = "5678";
            Nina.IsCheckedIn = false;
            Db.Dogs.Add(Nina);

            var Toby = new Dog();
            Toby.Name = "Toby";
            Toby.OwnersPersonalID = "4321";
            Toby.IsCheckedIn = true;
            Db.Dogs.Add(Toby);

            var Molly = new Dog();
            Molly.Name = "Molly";
            Molly.Notes = "Molly is a princess.";
            Molly.OwnersPersonalID = "1234";
            Molly.IsCheckedIn = true;
            Db.Dogs.Add(Molly);
        }

    }
}
