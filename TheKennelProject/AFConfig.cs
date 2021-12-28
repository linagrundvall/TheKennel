using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TheKennelProject.Animals;
using TheKennelProject.Bookings;
using TheKennelProject.Data;
using TheKennelProject.Menus;
using TheKennelProject.MockData;
using TheKennelProject.Persons;

namespace TheKennelProject
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Register main Application
            builder.RegisterType<Application>().As<IApplication>();

            //MockData
            builder.RegisterType<MyMockData>().As<IMyMockData>();

            //Data (Single instance = there is only one)
            builder.RegisterType<DBUsingLists>().As<IDBUsingLists>().SingleInstance();

            //Repository
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            //Booking
            builder.RegisterType<Booking>().As<IBooking>();
            builder.RegisterType<BookingManager>().As<IBookingManager>();

            //Animals
            builder.RegisterType<Dog>().As<IAnimal>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();

            //Persons
            builder.RegisterType<Customer>().As<IPerson>();
            builder.RegisterType<PersonManager>().As<IPersonManager>();

            //Main menu
            builder.RegisterType<MainMenu>().As<IMenu>();

            //Menu animal
            builder.RegisterType<MenuAnimal>().As<IMenuAnimal>();

            //Menu person
            builder.RegisterType<MenuPerson>().As<IMenuPerson>();

            return builder.Build();
        }
    }
}
