using System;
using System.Collections.Generic;
using TheKennelProject.AnimalTreatments;

namespace TheKennelProject.Animals
{
    interface IAnimal
    {
        Guid BookingID { get; set; }
        Guid ID { get; set; }
        bool IsCheckedIn { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        string OwnersPersonalID { get; set; }
        List<ITreatment> Treatments { get; set; }
    }
}