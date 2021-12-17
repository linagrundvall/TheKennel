using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Treatments
{
    class Washing : ITreatment
    {
        public string Name => "Washing";

        public string Description => "The dog is being washed.";

        public bool TrueOrFalse { get; set; }
    }
}
