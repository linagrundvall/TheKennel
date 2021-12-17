using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TheKennelProject.Data;
using TheKennelProject.Dogs;
using TheKennelProject.Entities;
using TheKennelProject.Menu;
using TheKennelProject.MockData;
using TheKennelProject.Rooms;

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

            //Dogs
            builder.RegisterType<Dog>().As<IDog>();
            builder.RegisterType<DogManager>().As<IDogManager>();

            //Rooms
            builder.RegisterType<Room>().As<IRoom>();
            builder.RegisterType<RoomManager>().As<IRoomManager>();

            //Customers
            builder.RegisterType<Customer>().As<ICustomer>();

            //Menu
            builder.RegisterType<MainMenu>().As<IMainMenu>();

            //Menu
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Menu"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + n.Name));

            ////Animal menu
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Animal_Menu"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            ////Customer menu
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Customer_Menu"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            ////Main menu
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Main_Menu"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            ////Customers
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Customer"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            ////Animals
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(Type i => i.Namespace.Contains(value: "Animals"))
            //    .As(Type i => i.GetInterfaces()
            //    .FirstOrDefault(Type n => n.Name == "I" + i.Name));

            //Data
            //builder.RegisterType<DataRepository>().As<IDataRepository>().SingleInstance();

            ////Delegate factory
            //builder.RegisterType<MenuOptions>();
            //builder.RegisterType<Dog>().Keyed<IAnimal>(serviceKey: "Dog").InstancePerDependency();


            //Register one by one (D, exaple)
            //builder.RegisterType<Task>().As<ITask>();

            return builder.Build();
        }
    }
}
