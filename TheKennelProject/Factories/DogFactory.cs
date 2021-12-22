using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Animals;

namespace TheKennelProject.Factories
{
    static class DogFactory
    {
        public static IAnimal Create()
        {
            return new Dog();
        }
    }
}
