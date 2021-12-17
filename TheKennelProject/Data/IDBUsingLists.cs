using System.Collections.Generic;
using TheKennelProject.Dogs;
using TheKennelProject.Entities;
using TheKennelProject.Rooms;

namespace TheKennelProject.Data
{
    interface IDBUsingLists
    {
        public List<Customer> Customers { get; set; }
        public List<IDog> Dogs { get; set; }
        public List<IRoom> Rooms { get; set; }
    }
}