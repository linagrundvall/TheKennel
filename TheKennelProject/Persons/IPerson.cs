using System;

namespace TheKennelProject.Persons
{
    interface IPerson
    {
        string FirstName { get; set; }
        Guid ID { get; set; }
        string LastName { get; set; }
        string Notes { get; set; }
        string PersonalIdentificationNumber { get; set; }
    }
}