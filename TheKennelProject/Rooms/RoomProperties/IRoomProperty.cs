namespace TheKennelProject.Rooms.RoomProperties
{
    public interface IRoomProperty
    {
        public string Name { get; }
        public string Description { get; }
        public bool TrueOrFalse { get; set; }
    }
}