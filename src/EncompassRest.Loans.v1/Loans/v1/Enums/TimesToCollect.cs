using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// TimesToCollect
    /// </summary>
    public enum TimesToCollect
    {
        /// <summary>
        /// Apply for a lease
        /// </summary>
        [EnumMember(Value = "Apply for a lease")]
        ApplyForALease = 0,
        /// <summary>
        /// Apply for a loan
        /// </summary>
        [EnumMember(Value = "Apply for a loan")]
        ApplyForALoan = 1,
        /// <summary>
        /// Apply for financing
        /// </summary>
        [EnumMember(Value = "Apply for financing")]
        ApplyForFinancing = 2,
        /// <summary>
        /// Apply for insurance
        /// </summary>
        [EnumMember(Value = "Apply for insurance")]
        ApplyForInsurance = 3,
        /// <summary>
        /// Buy securities from us
        /// </summary>
        [EnumMember(Value = "Buy securities from us")]
        BuySecuritiesFromUs = 4,
        /// <summary>
        /// Deposit Money
        /// </summary>
        [EnumMember(Value = "Deposit Money")]
        DepositMoney = 5,
        /// <summary>
        /// Direct us to buy securities
        /// </summary>
        [EnumMember(Value = "Direct us to buy securities")]
        DirectUsToBuySecurities = 6,
        /// <summary>
        /// Direct us to sell your securities
        /// </summary>
        [EnumMember(Value = "Direct us to sell your securities")]
        DirectUsToSellYourSecurities = 7,
        /// <summary>
        /// Enter into an investment advisory contract
        /// </summary>
        [EnumMember(Value = "Enter into an investment advisory contract")]
        EnterIntoAnInvestmentAdvisoryContract = 8,
        /// <summary>
        /// File an insurance claim
        /// </summary>
        [EnumMember(Value = "File an insurance claim")]
        FileAnInsuranceClaim = 9,
        /// <summary>
        /// Give us your contact information
        /// </summary>
        [EnumMember(Value = "Give us your contact information")]
        GiveUsYourContactInformation = 10,
        /// <summary>
        /// Give us your employment history
        /// </summary>
        [EnumMember(Value = "Give us your employment history")]
        GiveUsYourEmploymentHistory = 11,
        /// <summary>
        /// Give us your income information
        /// </summary>
        [EnumMember(Value = "Give us your income information")]
        GiveUsYourIncomeInformation = 12,
        /// <summary>
        /// Give us your wage statements
        /// </summary>
        [EnumMember(Value = "Give us your wage statements")]
        GiveUsYourWageStatements = 13,
        /// <summary>
        /// Make a wire transfer
        /// </summary>
        [EnumMember(Value = "Make a wire transfer")]
        MakeAWireTransfer = 14,
        /// <summary>
        /// Make deposits or withdrawals from your account
        /// </summary>
        [EnumMember(Value = "Make deposits or withdrawals from your account")]
        MakeDepositsOrWithdrawalsFromYourAccount = 15,
        /// <summary>
        /// Order a commodity futures or option trade
        /// </summary>
        [EnumMember(Value = "Order a commodity futures or option trade")]
        OrderACommodityFuturesOrOptionTrade = 16,
        /// <summary>
        /// Open an account
        /// </summary>
        [EnumMember(Value = "Open an account")]
        OpenAnAccount = 17,
        /// <summary>
        /// Pay insurance premiums
        /// </summary>
        [EnumMember(Value = "Pay insurance premiums")]
        PayInsurancePremiums = 18,
        /// <summary>
        /// Pay us by check
        /// </summary>
        [EnumMember(Value = "Pay us by check")]
        PayUsByCheck = 19,
        /// <summary>
        /// Pay your bills
        /// </summary>
        [EnumMember(Value = "Pay your bills")]
        PayYourBills = 20,
        /// <summary>
        /// Provide account information
        /// </summary>
        [EnumMember(Value = "Provide account information")]
        ProvideAccountInformation = 21,
        /// <summary>
        /// Provide employment information
        /// </summary>
        [EnumMember(Value = "Provide employment information")]
        ProvideEmploymentInformation = 22,
        /// <summary>
        /// Provide your mortgage information
        /// </summary>
        [EnumMember(Value = "Provide your mortgage information")]
        ProvideYourMortgageInformation = 23,
        /// <summary>
        /// Seek advice about your investments
        /// </summary>
        [EnumMember(Value = "Seek advice about your investments")]
        SeekAdviceAboutYourInvestments = 24,
        /// <summary>
        /// Seek financial or tax advice
        /// </summary>
        [EnumMember(Value = "Seek financial or tax advice")]
        SeekFinancialOrTaxAdvice = 25,
        /// <summary>
        /// Sell securities to us
        /// </summary>
        [EnumMember(Value = "Sell securities to us")]
        SellSecuritiesToUs = 26,
        /// <summary>
        /// Show your driver's license
        /// </summary>
        [EnumMember(Value = "Show your driver's license")]
        ShowYourDriversLicense = 27,
        /// <summary>
        /// Show your government issued ID
        /// </summary>
        [EnumMember(Value = "Show your government issued ID")]
        ShowYourGovernmentIssuedID = 28,
        /// <summary>
        /// Tell us about your investment or retirement earnings
        /// </summary>
        [EnumMember(Value = "Tell us about your investment or retirement earnings")]
        TellUsAboutYourInvestmentOrRetirementEarnings = 29,
        /// <summary>
        /// Tell us about your investment or retirement portfolio
        /// </summary>
        [EnumMember(Value = "Tell us about your investment or retirement portfolio")]
        TellUsAboutYourInvestmentOrRetirementPortfolio = 30,
        /// <summary>
        /// Tell us where to send the money
        /// </summary>
        [EnumMember(Value = "Tell us where to send the money")]
        TellUsWhereToSendTheMoney = 31,
        /// <summary>
        /// Tell us who receives the money
        /// </summary>
        [EnumMember(Value = "Tell us who receives the money")]
        TellUsWhoReceivesTheMoney = 32,
        /// <summary>
        /// Use your credit or debit card
        /// </summary>
        [EnumMember(Value = "Use your credit or debit card")]
        UseYourCreditOrDebitCard = 33
    }
}