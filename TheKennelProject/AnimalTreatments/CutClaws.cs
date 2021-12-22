using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.AnimalTreatments
{
    class CutClaws : ITreatment
    {
        public string Name => "CutClaws";

        public string Description => "The animals claws are being cut.";

        public bool TrueOrFalse { get; set; }
        public double Price { get; set; }
    }
}
