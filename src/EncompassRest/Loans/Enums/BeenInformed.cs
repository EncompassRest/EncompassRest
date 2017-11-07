using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BeenInformed
    {
        [EnumMember(Value = "The reasonable value of the property as determined by V.A.")]
        TheReasonableValueOfThePropertyAsDeterminedByVA = 0,
        [EnumMember(Value = "The statement of appraised value as determined by HUD / FHA")]
        TheStatementOfAppraisedValueAsDeterminedByHUDFHA = 1
    }
}