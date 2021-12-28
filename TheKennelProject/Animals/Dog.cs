using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKennelProject.Animals;
using TheKennelProject.AnimalTreatments;


namespace TheKennelProject.Animals
{
    class Dog : IAnimal, IDog
    {
        public Guid ID { get; set; }
        public string OwnersPersonalID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool IsCheckedIn { get; set; }
        public Guid BookingID { get; set; }
        public List<ITreatment> Treatments { get; set; }
        public List<IAnimal> CurrentDogs { get; set; }

        public Dog()
        {
            ID = Guid.NewGuid();
            Treatments = new List<ITreatment>();
            CurrentDogs = new List<IAnimal>();
        }
    }
}
