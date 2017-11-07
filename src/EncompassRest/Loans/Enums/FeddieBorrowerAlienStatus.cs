using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FeddieBorrowerAlienStatus
    {
        [EnumMember(Value = "Non Permanent Resident Alien")]
        NonPermanentResidentAlien = 0,
        [EnumMember(Value = "Non Resident Alien")]
        NonResidentAlien = 1
    }
}