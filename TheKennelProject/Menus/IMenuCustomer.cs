using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Persons;

namespace TheKennelProject.Menus
{
    interface IMenuCustomer
    {
        IBookingManager BookingManager { get; set; }
        ICustomerManager CustomerManager { get; set; }
        IDogManager DogManager { get; set; }

        void Show();
        void GetInput();
    }
}