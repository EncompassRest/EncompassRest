using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InitiallyPayableToYourInstitution
    {
        [EnumMember(Value = "Initially payable to your institution")]
        InitiallyPayableToYourInstitution = 0,
        [EnumMember(Value = "Not initially payable to your institution")]
        NotInitiallyPayableToYourInstitution = 1,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2
    }
}