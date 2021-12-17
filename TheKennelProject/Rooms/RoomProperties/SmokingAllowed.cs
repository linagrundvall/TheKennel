using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Rooms.RoomProperties
{
    class SmokingAllowed : IRoomProperty
    {
        public string Name => "SmokingAllowed";

        public string Description => "Is smoking allowed in this room.";

        public bool TrueOrFalse { get; set; }
    }
}
