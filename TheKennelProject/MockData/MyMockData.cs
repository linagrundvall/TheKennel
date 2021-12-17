using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;
using TheKennelProject.Rooms;
using TheKennelProject.Rooms.RoomProperties;

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
    }
}
