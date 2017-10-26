using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieRelatedLoanLienPosition
    {
        [EnumMember(Value = "Second Lien")]
        SecondLien = 0,
        [EnumMember(Value = "Third Lien")]
        ThirdLien = 1,
        [EnumMember(Value = "Fourth Lien")]
        FourthLien = 2
    }
}