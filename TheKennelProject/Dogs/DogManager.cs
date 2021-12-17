using System;
using TheKennelProject.Data;
using TheKennelProject.Factories;

namespace TheKennelProject.Dogs
{
    internal class DogManager : IDogManager
    {
        public IDataRepository Db { get; set; }
        
        public DogManager(IDataRepository db)
        {
            Db = db;
        }
        public void RegisterDog()
        {
            // TODO: Split input into another class/method?
            IDog dog = DogFactory.Create();

            // TODO: Add validation for all three
            Console.WriteLine(value: "Please enter the dogs name.");
            dog.Name = Console.ReadLine();

            Console.WriteLine(value: "Please enter any further notes regarding the dog.");
            dog.Notes = Console.ReadLine();

            Db.SaveDog(dog);
        }
    }
}