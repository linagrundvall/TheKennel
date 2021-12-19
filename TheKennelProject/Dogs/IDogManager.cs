namespace TheKennelProject.Dogs
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