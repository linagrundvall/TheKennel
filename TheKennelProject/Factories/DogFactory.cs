using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Dogs;

namespace TheKennelProject.Factories
{
    static class DogFactory
    {
        public static IDog Create()
        {
            return new Dog();
        }
    }
}
