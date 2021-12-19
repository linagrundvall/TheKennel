using TheKennelProject.Data;

namespace TheKennelProject.MockData
{
    interface IMyMockData
    {
        IDBUsingLists Db { get; set; }

        void GenerateRooms();
        void MakeCustomers();
        void MakeDogs();
        void GeneratePrice();
    }
}