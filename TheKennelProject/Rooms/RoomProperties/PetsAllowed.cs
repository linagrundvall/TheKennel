using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Rooms.RoomProperties
{
    class PetsAllowed : IRoomProperty
    {
        public string Name => "PetsAllowed";

        public string Description => "Are pets allowed in this room.";

        public bool TrueOrFalse { get; set; }
    }
}
