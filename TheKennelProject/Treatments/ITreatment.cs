using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKennelProject.Treatments
{
    public interface ITreatment
    {
        public string Name { get; }
        public string Description { get; }
        public bool TrueOrFalse { get; set; }
        public decimal Price { get; set; }
    }
}
