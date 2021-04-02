using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// TypeOfVeteran
    /// </summary>
    public enum TypeOfVeteran
    {
        /// <summary>
        /// Regular Military
        /// </summary>
        [EnumMember(Value = "Regular Military")]
        RegularMilitary = 0,
        /// <summary>
        /// Reserves
        /// </summary>
        Reserves = 1,
        /// <summary>
        /// National Guard
        /// </summary>
        [EnumMember(Value = "National Guard")]
        NationalGuard = 2
    }
}