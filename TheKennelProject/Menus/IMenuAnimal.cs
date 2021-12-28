using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Persons;

namespace TheKennelProject.Menus
{
    interface IMenuAnimal
    {
        IBookingManager BookingManager { get; set; }
        IPersonManager PersonManager { get; set; }
        IAnimalManager AnimalManager { get; set; }

        void GetInput();
        void Show();
    }
}