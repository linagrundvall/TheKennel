using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Bookings;
using TheKennelProject.Customers;
using TheKennelProject.Data;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms;
using TheKennelProject.Rooms.RoomProperties;
using TheKennelProject.Treatments;

namespace TheKennelProject.MockData
{
    class MyMockData : IMyMockData
    {
        public IDBUsingLists Db { get; set; }
        public MyMockData(IDBUsingLists databaseUsingLists)
        {
            Db = databaseUsingLists;
        }
        public void GenerateRooms()
        {
            //Create rooms 
            for (int i = 1; i < 11; i++)
            {
                var room = new Room();
                room.RoomNumber = i.ToString();
                room.Price = i * 100;

                //if (i % 2 == 0)
                //{
                //    IRoomProperty petsAllowed = new PetsAllowed();
                //    petsAllowed.TrueOrFalse = true;
                //    room.RoomProperties.Add(petsAllowed);
                //}
                //else
                //{
                //    IRoomProperty smokingAllowed = new SmokingAllowed();
                //    smokingAllowed.TrueOrFalse = true;
                //    room.RoomProperties.Add(smokingAllowed);
                //}

                Db.Rooms.Add(room);
            }
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

        //Make customers
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

        //Make dogs
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
