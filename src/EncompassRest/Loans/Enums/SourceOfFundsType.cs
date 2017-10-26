using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SourceOfFundsType
    {
        [EnumMember(Value = "1. New Guaranteed Loan")]
        n1NewGuaranteedLoan = 0,
        [EnumMember(Value = "2. Reserved (used for Direct Loan Programs)")]
        n2ReservedUsedForDirectLoanPrograms = 1,
        [EnumMember(Value = "3. Reserved")]
        n3Reserved = 2,
        [EnumMember(Value = "4. Reserved")]
        n4Reserved = 3,
        [EnumMember(Value = "5. Consolidation of Guaranteed Loans Without Interest Assistance")]
        n5ConsolidationOfGuaranteedLoansWithoutInterestAssistance = 4,
        [EnumMember(Value = "6. New Guaranteed Farm Loan Program Loan (FLP) with Interest Assistance")]
        n6NewGuaranteedFarmLoanProgramLoanFLPWithInterestAssistance = 5,
        [EnumMember(Value = "7. FLP Interest Assistance Only")]
        n7FLPInterestAssistanceOnly = 6,
        [EnumMember(Value = "8. New Guaranteed SFH Loan with Interest Assistance")]
        n8NewGuaranteedSFHLoanWithInterestAssistance = 7
    }
}