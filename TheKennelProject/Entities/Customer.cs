using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Entities
{
    class Customer : ICustomer
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalIdentificationNumber { get; set; }
        public string Notes { get; set; }


        public Customer()
        {
            ID = Guid.NewGuid();
        }

    }
}
