using TheKennelProject.Bookings;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.Menus
{
    interface IMenu
    {
        IAnimalManager AnimalManager { get; set; }
        IPersonManager PersonManager { get; set; }
        IBookingManager BookingManager { get; set; }
        void Show();
        void GetInput();
    }
}