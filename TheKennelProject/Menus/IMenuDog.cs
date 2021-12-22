using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Persons;

namespace TheKennelProject.Menus
{
    interface IMenuDog
    {
        IBookingManager BookingManager { get; set; }
        ICustomerManager CustomerManager { get; set; }
        IDogManager DogManager { get; set; }

        void GetInput();
        void Show();
    }
}