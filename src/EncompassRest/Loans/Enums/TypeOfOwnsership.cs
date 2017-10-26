using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfOwnsership
    {
        SoleOwnership = 0,
        [EnumMember(Value = "Joint - 2 Or More Veterans")]
        Joint2OrMoreVeterans = 1,
        [EnumMember(Value = "Joint - Veteran/Non-Veteran")]
        JointVeteranNonVeteran = 2
    }
}