using TheKennelProject.Data;

namespace TheKennelProject.Persons
{
    internal interface ICustomerManager
    {
        void RegisterCustomer();
        void ListCustomers();
        void ListCustomersWithDogs();
    }
}