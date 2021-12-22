using TheKennelProject.Data;

namespace TheKennelProject.Persons
{
    internal interface ICustomerManager
    {
        void RegisterCustomer();
        void SaveCustomer();
        void ListCustomers();
        void ListCustomersWithDogs();
    }
}