using TheKennelProject.Data;

namespace TheKennelProject.MockData
{
    interface IMyMockData
    {
        IDBUsingLists Db { get; set; }

        void MakeCustomers();
        void MakeDogs();
        void GeneratePrice();
    }
}