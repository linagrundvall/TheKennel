﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Treatments
{
    class CutClaws : ITreatment
    {
        public string Name => "CutClaws";

        public string Description => "The dogs claws are being cut.";

        public bool TrueOrFalse { get; set; }
    }
}