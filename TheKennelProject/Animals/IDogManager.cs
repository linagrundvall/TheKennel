namespace TheKennelProject.Animals
{
    internal interface IDogManager
    {
        void RegisterDog();
        void SaveDog();
        void RegisterDogTreatment();
        void AddCutClaws(IAnimal dog);
        void AddWash(IAnimal dog);
        void CheckInDog();
        void CheckOutDog();
        void ListDogs();
        void ListCurrentDogs();
    }
}