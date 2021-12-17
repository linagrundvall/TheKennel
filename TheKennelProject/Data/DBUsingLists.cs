using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Dogs;
using TheKennelProject.Entities;
using TheKennelProject.Rooms;

namespace TheKennelProject.Data
{
    class DBUsingLists : IDBUsingLists
    {
        public List<IRoom> Rooms { get; set; }

        //Dog instead of guests
        public List<IDog> Dogs { get; set; }
        public List<Customer> Customers { get; set; }

        public DBUsingLists()
        {
            Rooms = new List<IRoom>();
            Dogs = new List<IDog>();
            Customers = new List<Customer>();
        }
    }
}
