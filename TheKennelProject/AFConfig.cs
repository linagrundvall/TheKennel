﻿using System;
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

            //Dogs
            builder.RegisterType<Dog>().As<IAnimal>();
            builder.RegisterType<DogManager>().As<IDogManager>();

            //Customers
            builder.RegisterType<Customer>().As<IPerson>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();

            //Main menu
            builder.RegisterType<MainMenu>().As<IMenu>();

            //Menu dog
            builder.RegisterType<MenuDog>().As<IMenuDog>();

            //Menu customer
            builder.RegisterType<MenuCustomer>().As<IMenuCustomer>();

            ////Animals
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Animals"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            ////Delegate factory
            //builder.RegisterType<MenuOptions>();
            //builder.RegisterType<Dog>().Keyed<IAnimal>(serviceKey: "Dog").InstancePerDependency();

            //Register one by one (D, exaple)
            //builder.RegisterType<Task>().As<ITask>();

            return builder.Build();
        }
    }
}
