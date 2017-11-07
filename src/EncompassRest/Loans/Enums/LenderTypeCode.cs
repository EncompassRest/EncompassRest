using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LenderTypeCode
    {
        [EnumMember(Value = "1. Commercial Bank")]
        n1CommercialBank = 1,
        [EnumMember(Value = "2. Mortgage Loan Co.")]
        n2MortgageLoanCo = 2,
        [EnumMember(Value = "3. Insurance Co.")]
        n3InsuranceCo = 3,
        [EnumMember(Value = "4. Production Credit")]
        n4ProductionCredit = 4,
        [EnumMember(Value = "5. Federal Land Bank")]
        n5FederalLandBank = 5,
        [EnumMember(Value = "6. Credit Union")]
        n6CreditUnion = 6,
        [EnumMember(Value = "7. Savings & Loan")]
        n7SavingsLoan = 7,
        [EnumMember(Value = "8. Banks for Coops")]
        n8BanksForCoops = 8,
        [EnumMember(Value = "9. Small Business Investment Co.")]
        n9SmallBusinessInvestmentCo = 9,
        [EnumMember(Value = "10. Broker")]
        n10Broker = 10,
        [EnumMember(Value = "11. Other")]
        n11Other = 11,
        [EnumMember(Value = "12. Non-Traditional")]
        n12NonTraditional = 12
    }
}