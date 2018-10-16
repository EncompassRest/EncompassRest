using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CanGoOrGoes
    /// </summary>
    public enum CanGoOrGoes
    {
        /// <summary>
        /// Can go
        /// </summary>
        [EnumMember(Value = "Can go")]
        CanGo = 0,
        /// <summary>
        /// Goes
        /// </summary>
        Goes = 1
    }
}