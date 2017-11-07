using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TimesToCollect
    {
        [EnumMember(Value = "Apply for a lease")]
        ApplyForALease = 0,
        [EnumMember(Value = "Apply for a loan")]
        ApplyForALoan = 1,
        [EnumMember(Value = "Apply for financing")]
        ApplyForFinancing = 2,
        [EnumMember(Value = "Apply for insurance")]
        ApplyForInsurance = 3,
        [EnumMember(Value = "Buy securities from us")]
        BuySecuritiesFromUs = 4,
        [EnumMember(Value = "Deposit Money")]
        DepositMoney = 5,
        [EnumMember(Value = "Direct us to buy securities")]
        DirectUsToBuySecurities = 6,
        [EnumMember(Value = "Direct us to sell your securities")]
        DirectUsToSellYourSecurities = 7,
        [EnumMember(Value = "Enter into an investment advisory contract")]
        EnterIntoAnInvestmentAdvisoryContract = 8,
        [EnumMember(Value = "File an insurance claim")]
        FileAnInsuranceClaim = 9,
        [EnumMember(Value = "Give us your contact information")]
        GiveUsYourContactInformation = 10,
        [EnumMember(Value = "Give us your employment history")]
        GiveUsYourEmploymentHistory = 11,
        [EnumMember(Value = "Give us your income information")]
        GiveUsYourIncomeInformation = 12,
        [EnumMember(Value = "Give us your wage statements")]
        GiveUsYourWageStatements = 13,
        [EnumMember(Value = "Make a wire transfer")]
        MakeAWireTransfer = 14,
        [EnumMember(Value = "Make deposits or withdrawals from your account")]
        MakeDepositsOrWithdrawalsFromYourAccount = 15,
        [EnumMember(Value = "Order a commodity futures or option trade")]
        OrderACommodityFuturesOrOptionTrade = 16,
        [EnumMember(Value = "Open an account")]
        OpenAnAccount = 17,
        [EnumMember(Value = "Pay insurance premiums")]
        PayInsurancePremiums = 18,
        [EnumMember(Value = "Pay us by check")]
        PayUsByCheck = 19,
        [EnumMember(Value = "Pay your bills")]
        PayYourBills = 20,
        [EnumMember(Value = "Provide account information")]
        ProvideAccountInformation = 21,
        [EnumMember(Value = "Provide employment information")]
        ProvideEmploymentInformation = 22,
        [EnumMember(Value = "Provide your mortgage information")]
        ProvideYourMortgageInformation = 23,
        [EnumMember(Value = "Seek advice about your investments")]
        SeekAdviceAboutYourInvestments = 24,
        [EnumMember(Value = "Seek financial or tax advice")]
        SeekFinancialOrTaxAdvice = 25,
        [EnumMember(Value = "Sell securities to us")]
        SellSecuritiesToUs = 26,
        [EnumMember(Value = "Show your driver's license")]
        ShowYourDriversLicense = 27,
        [EnumMember(Value = "Show your government issued ID")]
        ShowYourGovernmentIssuedID = 28,
        [EnumMember(Value = "Tell us about your investment or retirement earnings")]
        TellUsAboutYourInvestmentOrRetirementEarnings = 29,
        [EnumMember(Value = "Tell us about your investment or retirement portfolio")]
        TellUsAboutYourInvestmentOrRetirementPortfolio = 30,
        [EnumMember(Value = "Tell us where to send the money")]
        TellUsWhereToSendTheMoney = 31,
        [EnumMember(Value = "Tell us who receives the money")]
        TellUsWhoReceivesTheMoney = 32,
        [EnumMember(Value = "Use your credit or debit card")]
        UseYourCreditOrDebitCard = 33
    }
}