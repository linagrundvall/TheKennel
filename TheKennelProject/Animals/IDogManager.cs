namespace TheKennelProject.Animals
{
    internal interface IDogManager
    {
        void RegisterDog();
        void RegisterDogTreatment();
        void CheckInDog();
        void CheckOutDog();
        void ListDogs();
        void ListCurrentDogs();
    }
}