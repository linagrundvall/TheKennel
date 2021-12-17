using System;
using System.Linq;
using TheKennelProject.Data;
using TheKennelProject.Dogs;

namespace TheKennelProject.Rooms
{
    internal class RoomManager : IRoomManager
    {
        public IDataRepository Db { get; set; }
        public RoomManager(IDataRepository db)
        {
            Db = db;
        }
        public void AddDogToRoom()
        {
            // TODO: Validation
            // TODO: Break out into different methods?
            Console.WriteLine(value: "Please enter the name of the dog.");
            IDog dog = Db.GetDogByName(Console.ReadLine());

            Console.WriteLine(value: "Please enter the room number.");
            IRoom room = Db.GetRoomByRoomNumber(Console.ReadLine());

            room.CurrentDogs.Add(dog);

            }
            public void ListRooms()
            {
                var rooms = Db.GetAllRooms();
            //    foreach (var room in rooms)
            //    {
            //        Console.WriteLine(room.RoomNumber);

                foreach (var room in rooms)
                {
                    foreach (var property in room.RoomProperties)
                    {
                        Console.WriteLine(property.Name);
                        Console.WriteLine(property.TrueOrFalse);
                    }
                }
            }
        }
    }
}