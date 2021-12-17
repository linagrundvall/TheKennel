using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms.RoomProperties;

namespace TheKennelProject.Rooms
{
    class Room : IRoom
    {
        public Guid ID { get; set; }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }

        //Listing the dogs(guests) in this room
        public List<IDog> CurrentDogs { get; set; }
        public List<IRoomProperty> RoomProperties { get; set; }
        
        public Room()
        {
            ID = Guid.NewGuid();
            CurrentDogs = new List<IDog>();
        }
    }
}
