using System;

namespace TheKennelProject.Dogs
{
    interface IDog
    {
        Guid ID { get; set; }
        string OwnersPersonalID { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        public bool IsCheckedIn { get; set; }
    }
}