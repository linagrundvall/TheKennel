using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Data;
using Autofac;
using TheKennelProject.MockData;
using TheKennelProject.Menu;

namespace TheKennelProject
{
    internal class Application : IApplication
    {
        public IDBUsingLists Db { get; set; }
        public IMyMockData MyMockData { get; set; }
        public IMainMenu MainMenu { get; set; }

        public Application(IMainMenu mainMenu, IDBUsingLists databaseUsingLists, IMyMockData myMockData)
        {
            Db = databaseUsingLists;
            MyMockData = myMockData;
            MainMenu = mainMenu;
        }
        public void Run()
        {
            MyMockData.GeneratePrice();
            MyMockData.GenerateRooms();
            MyMockData.MakeCustomers();
            MyMockData.MakeDogs();

            while (true)
            {
                MainMenu.Show();
                MainMenu.GetInput();
            }
        }
    }
}
