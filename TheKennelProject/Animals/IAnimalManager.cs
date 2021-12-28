using TheKennelProject.Data;

namespace TheKennelProject.Animals
{
    internal interface IAnimalManager
    {
        IDataRepository Db { get; set; }

        void AddCutClaws(IAnimal animal);
        void AddWash(IAnimal animal);
        void CheckInAnimal();
        void CheckOutAnimal();
        double GetPriceBooking(IAnimal animal);
        double GetPriceTreatments(IAnimal animal);
        void ListAnimals();
        void ListCurrentAnimals();
        void RegisterAnimal();
        void RegisterAnimalTreatment();
        void SaveAnimal();
    }
}