using TheKennelProject.Data;

namespace TheKennelProject.Persons
{
    internal interface IPersonManager
    {
        IDataRepository Db { get; set; }

        void ListPersons();
        void ListPersonsWithAnimals();
        void RegisterPerson();
        void SavePerson();
        void ShowPerson();
    }
}