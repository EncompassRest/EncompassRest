using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ATRLoanType
    {
        Exempt = 0,
        [EnumMember(Value = "General ATR")]
        GeneralATR = 1,
        [EnumMember(Value = "Non-Standard to Standard Refinance")]
        NonStandardToStandardRefinance = 2,
        [EnumMember(Value = "Qualified Mortgage")]
        QualifiedMortgage = 3
    }
}