using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LenderTypeCode
    /// </summary>
    public enum LenderTypeCode
    {
        /// <summary>
        /// 1. Commercial Bank
        /// </summary>
        [EnumMember(Value = "1. Commercial Bank")]
        n1CommercialBank = 1,
        /// <summary>
        /// 2. Mortgage Loan Co.
        /// </summary>
        [EnumMember(Value = "2. Mortgage Loan Co.")]
        n2MortgageLoanCo = 2,
        /// <summary>
        /// 3. Insurance Co.
        /// </summary>
        [EnumMember(Value = "3. Insurance Co.")]
        n3InsuranceCo = 3,
        /// <summary>
        /// 4. Production Credit
        /// </summary>
        [EnumMember(Value = "4. Production Credit")]
        n4ProductionCredit = 4,
        /// <summary>
        /// 5. Federal Land Bank
        /// </summary>
        [EnumMember(Value = "5. Federal Land Bank")]
        n5FederalLandBank = 5,
        /// <summary>
        /// 6. Credit Union
        /// </summary>
        [EnumMember(Value = "6. Credit Union")]
        n6CreditUnion = 6,
        /// <summary>
        /// 7. Savings &amp; Loan
        /// </summary>
        [EnumMember(Value = "7. Savings & Loan")]
        n7SavingsLoan = 7,
        /// <summary>
        /// 8. Banks for Coops
        /// </summary>
        [EnumMember(Value = "8. Banks for Coops")]
        n8BanksForCoops = 8,
        /// <summary>
        /// 9. Small Business Investment Co.
        /// </summary>
        [EnumMember(Value = "9. Small Business Investment Co.")]
        n9SmallBusinessInvestmentCo = 9,
        /// <summary>
        /// 10. Broker
        /// </summary>
        [EnumMember(Value = "10. Broker")]
        n10Broker = 10,
        /// <summary>
        /// 11. Other
        /// </summary>
        [EnumMember(Value = "11. Other")]
        n11Other = 11,
        /// <summary>
        /// 12. Non-Traditional
        /// </summary>
        [EnumMember(Value = "12. Non-Traditional")]
        n12NonTraditional = 12
    }
}