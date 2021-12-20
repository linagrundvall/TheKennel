using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.AnimalTreatments
{
    class Wash : ITreatment
    {
        public string Name => "Wash";

        public string Description => "The dog is being washed.";

        public bool TrueOrFalse { get; set; }
        public decimal Price { get; set; }
    }
}
