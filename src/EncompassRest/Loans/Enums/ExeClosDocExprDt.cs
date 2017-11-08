using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ExeClosDocExprDt
    {
        [EnumMember(Value = "Funding Date")]
        FundingDate = 0,
        [EnumMember(Value = "Closing Date")]
        ClosingDate = 1
    }
}