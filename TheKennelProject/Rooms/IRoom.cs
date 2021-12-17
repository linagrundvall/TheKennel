using System;
using System.Collections.Generic;
using TheKennelProject.Dogs;
using TheKennelProject.Rooms.RoomProperties;

namespace TheKennelProject.Rooms
{
    interface IRoom
    {
        List<IDog> CurrentDogs { get; set; }
        Guid ID { get; set; }
        List<IRoomProperty> RoomProperties { get; set; }
        decimal Price { get; set; }
        string RoomNumber { get; set; }
    }
}