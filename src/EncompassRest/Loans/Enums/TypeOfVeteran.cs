using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfVeteran
    {
        [EnumMember(Value = "Regular Military")]
        RegularMilitary = 0,
        Reserves = 1,
        [EnumMember(Value = "National Guard")]
        NationalGuard = 2
    }
}