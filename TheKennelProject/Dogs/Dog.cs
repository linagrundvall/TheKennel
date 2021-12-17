using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Dogs
{
    class Dog : IDog
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public Dog()
        {
            ID = Guid.NewGuid();
        }
    }
}
