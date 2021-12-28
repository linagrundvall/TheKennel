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
        public string Description => "The animal is being washed.";
        public bool TrueOrFalse { get; set; }
        public double Price { get; set; }
    }
}
