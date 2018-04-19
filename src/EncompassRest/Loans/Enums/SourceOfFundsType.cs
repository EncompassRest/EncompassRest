using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SourceOfFundsType
    /// </summary>
    public enum SourceOfFundsType
    {
        /// <summary>
        /// 1. New Guaranteed Loan
        /// </summary>
        [EnumMember(Value = "1. New Guaranteed Loan")]
        n1NewGuaranteedLoan = 1,
        /// <summary>
        /// 2. Reserved (used for Direct Loan Programs)
        /// </summary>
        [EnumMember(Value = "2. Reserved (used for Direct Loan Programs)")]
        n2ReservedUsedForDirectLoanPrograms = 2,
        /// <summary>
        /// 3. Reserved
        /// </summary>
        [EnumMember(Value = "3. Reserved")]
        n3Reserved = 3,
        /// <summary>
        /// 4. Reserved
        /// </summary>
        [EnumMember(Value = "4. Reserved")]
        n4Reserved = 4,
        /// <summary>
        /// 5. Consolidation of Guaranteed Loans Without Interest Assistance
        /// </summary>
        [EnumMember(Value = "5. Consolidation of Guaranteed Loans Without Interest Assistance")]
        n5ConsolidationOfGuaranteedLoansWithoutInterestAssistance = 5,
        /// <summary>
        /// 6. New Guaranteed Farm Loan Program Loan (FLP) with Interest Assistance
        /// </summary>
        [EnumMember(Value = "6. New Guaranteed Farm Loan Program Loan (FLP) with Interest Assistance")]
        n6NewGuaranteedFarmLoanProgramLoanFLPWithInterestAssistance = 6,
        /// <summary>
        /// 7. FLP Interest Assistance Only
        /// </summary>
        [EnumMember(Value = "7. FLP Interest Assistance Only")]
        n7FLPInterestAssistanceOnly = 7,
        /// <summary>
        /// 8. New Guaranteed SFH Loan with Interest Assistance
        /// </summary>
        [EnumMember(Value = "8. New Guaranteed SFH Loan with Interest Assistance")]
        n8NewGuaranteedSFHLoanWithInterestAssistance = 8
    }
}