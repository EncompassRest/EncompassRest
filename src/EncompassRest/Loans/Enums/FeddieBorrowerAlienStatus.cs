using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FeddieBorrowerAlienStatus
    /// </summary>
    public enum FeddieBorrowerAlienStatus
    {
        /// <summary>
        /// Non Permanent Resident Alien
        /// </summary>
        [EnumMember(Value = "Non Permanent Resident Alien")]
        NonPermanentResidentAlien = 0,
        /// <summary>
        /// Non Resident Alien
        /// </summary>
        [EnumMember(Value = "Non Resident Alien")]
        NonResidentAlien = 1
    }
}