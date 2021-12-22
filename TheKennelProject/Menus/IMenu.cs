using TheKennelProject.Bookings;
using TheKennelProject.Persons;
using TheKennelProject.Animals;

namespace TheKennelProject.Menus
{
    interface IMenu
    {
        IDogManager DogManager { get; set; }
        ICustomerManager CustomerManager { get; set; }
        IBookingManager BookingManager { get; set; }
        void Show();
        void GetInput();
    }
}