using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InformationTypesWeCollect
    {
        [EnumMember(Value = "Account balances")]
        AccountBalances = 0,
        [EnumMember(Value = "Account transactions")]
        AccountTransactions = 1,
        Assets = 2,
        [EnumMember(Value = "Checking account information")]
        CheckingAccountInformation = 3,
        [EnumMember(Value = "Credit-based insurance scores")]
        CreditBasedInsuranceScores = 4,
        [EnumMember(Value = "Credit card or other debt")]
        CreditCardOrOtherDebt = 5,
        [EnumMember(Value = "Credit history")]
        CreditHistory = 6,
        [EnumMember(Value = "Credit scores")]
        CreditScores = 7,
        [EnumMember(Value = "Employment information")]
        EmploymentInformation = 8,
        Income = 9,
        [EnumMember(Value = "Insurance claim history")]
        InsuranceClaimHistory = 10,
        [EnumMember(Value = "Investment experience")]
        InvestmentExperience = 11,
        [EnumMember(Value = "Medical information")]
        MedicalInformation = 12,
        [EnumMember(Value = "Medical-related debts")]
        MedicalRelatedDebts = 13,
        [EnumMember(Value = "Mortgage rates and payments")]
        MortgageRatesAndPayments = 14,
        [EnumMember(Value = "Overdraft history")]
        OverdraftHistory = 15,
        [EnumMember(Value = "Payment history")]
        PaymentHistory = 16,
        [EnumMember(Value = "Purchase history")]
        PurchaseHistory = 17,
        [EnumMember(Value = "Retirement assets")]
        RetirementAssets = 18,
        [EnumMember(Value = "Risk tolerance")]
        RiskTolerance = 19,
        [EnumMember(Value = "Transaction history")]
        TransactionHistory = 20,
        [EnumMember(Value = "Transaction or loss history")]
        TransactionOrLossHistory = 21,
        [EnumMember(Value = "Wire transfer instructions")]
        WireTransferInstructions = 22
    }
}