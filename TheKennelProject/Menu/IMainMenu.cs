using TheKennelProject.Dogs;
using TheKennelProject.Rooms;

namespace TheKennelProject.Menu
{
    interface IMainMenu
    {
        IDogManager DogManager { get; set; }
        IRoomManager RoomManager { get; set; }

        void GetInput();
        void Show();
    }
}