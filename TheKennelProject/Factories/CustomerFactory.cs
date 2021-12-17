﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Customers;

namespace TheKennelProject.Factories
{
    class CustomerFactory
    {
        public static ICustomer Create()
        {
            return new Customer();
        }
    }
}
