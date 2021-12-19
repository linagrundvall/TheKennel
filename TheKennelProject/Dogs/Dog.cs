using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Treatments;

namespace TheKennelProject.Dogs
{
    class Dog : IDog
    {
        public Guid ID { get; set; }
        public string OwnersPersonalID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool IsCheckedIn { get; set; }
        public List<ITreatment> Treatments { get; set; }
        public List<IDog> CurrentDogs { get; set; }

        public Dog()
        {
            ID = Guid.NewGuid();
            //Treatments = new List<ITreatment>();
            CurrentDogs = new List<IDog>();
        }
    }
}
