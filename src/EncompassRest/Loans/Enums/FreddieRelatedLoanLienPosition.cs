using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieRelatedLoanLienPosition
    {
        [EnumMember(Value = "Second Lien")]
        SecondLien = 2,
        [EnumMember(Value = "Third Lien")]
        ThirdLien = 3,
        [EnumMember(Value = "Fourth Lien")]
        FourthLien = 4
    }
}