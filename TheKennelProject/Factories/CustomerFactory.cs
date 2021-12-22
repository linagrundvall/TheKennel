using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Persons;

namespace TheKennelProject.Factories
{
    class CustomerFactory
    {
        public static IPerson Create()
        {
            return new Customer();
        }
    }
}
