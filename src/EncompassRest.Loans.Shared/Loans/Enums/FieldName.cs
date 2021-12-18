using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FieldName
    /// </summary>
    public enum FieldName
    {
        /// <summary>
        /// WhoHave25Percent
        /// </summary>
        WhoHave25Percent = 0,
        /// <summary>
        /// WhoAreEmployedByFamily
        /// </summary>
        WhoAreEmployedByFamily = 1,
        /// <summary>
        /// WhoArePaidByCommissions
        /// </summary>
        WhoArePaidByCommissions = 2,
        /// <summary>
        /// WhoOwnRentalProperties
        /// </summary>
        WhoOwnRentalProperties = 3,
        /// <summary>
        /// WhoReceiveVariableIncome
        /// </summary>
        WhoReceiveVariableIncome = 4,
        /// <summary>
        /// DocumentOwnership
        /// </summary>
        DocumentOwnership = 5,
        /// <summary>
        /// AdequateLiquidity
        /// </summary>
        AdequateLiquidity = 6,
        /// <summary>
        /// PositiveSales
        /// </summary>
        PositiveSales = 7,
        /// <summary>
        /// TaxRefunds
        /// </summary>
        TaxRefunds = 8,
        /// <summary>
        /// Depletion
        /// </summary>
        Depletion = 9,
        /// <summary>
        /// Amortization
        /// </summary>
        Amortization = 10,
        /// <summary>
        /// MortgageOrNotesPayable
        /// </summary>
        MortgageOrNotesPayable = 11,
        /// <summary>
        /// MealsAndEntertainment
        /// </summary>
        MealsAndEntertainment = 12,
        /// <summary>
        /// SubTotal
        /// </summary>
        SubTotal = 13,
        /// <summary>
        /// PartnershipTotal
        /// </summary>
        PartnershipTotal = 14,
        /// <summary>
        /// NonRecurringOther
        /// </summary>
        NonRecurringOther = 15,
        /// <summary>
        /// Depreciation
        /// </summary>
        Depreciation = 16,
        /// <summary>
        /// AlimonyReceived
        /// </summary>
        AlimonyReceived = 17,
        /// <summary>
        /// MealsAndEntertaintment
        /// </summary>
        MealsAndEntertaintment = 18,
        /// <summary>
        /// CorporationTotal
        /// </summary>
        CorporationTotal = 19,
        /// <summary>
        /// TaxableIncome
        /// </summary>
        TaxableIncome = 20,
        /// <summary>
        /// TotalTax
        /// </summary>
        TotalTax = 21,
        /// <summary>
        /// NonRecurringLoss
        /// </summary>
        NonRecurringLoss = 22,
        /// <summary>
        /// NegateScheduleD
        /// </summary>
        NegateScheduleD = 23,
        /// <summary>
        /// NetOperatingLoss
        /// </summary>
        NetOperatingLoss = 24,
        /// <summary>
        /// SubTotalMultipliedBy
        /// </summary>
        SubTotalMultipliedBy = 25,
        /// <summary>
        /// DividendsPaidToBorrower
        /// </summary>
        DividendsPaidToBorrower = 26,
        /// <summary>
        /// PensionAndIRA
        /// </summary>
        PensionAndIRA = 27,
        /// <summary>
        /// NegateScheduleE
        /// </summary>
        NegateScheduleE = 28,
        /// <summary>
        /// UnemploymentCompensation
        /// </summary>
        UnemploymentCompensation = 29,
        /// <summary>
        /// SocialSecurity
        /// </summary>
        SocialSecurity = 30,
        /// <summary>
        /// SalaryDrawToIndividual
        /// </summary>
        SalaryDrawToIndividual = 31,
        /// <summary>
        /// NetProfitAmount
        /// </summary>
        NetProfitAmount = 32,
        /// <summary>
        /// NetProfitPercent
        /// </summary>
        NetProfitPercent = 33,
        /// <summary>
        /// NetProfitTotal
        /// </summary>
        NetProfitTotal = 34,
        /// <summary>
        /// AllowableAddbackAmount
        /// </summary>
        AllowableAddbackAmount = 35,
        /// <summary>
        /// AllowableAddbackPercent
        /// </summary>
        AllowableAddbackPercent = 36,
        /// <summary>
        /// AllowableAddbackTotal
        /// </summary>
        AllowableAddbackTotal = 37,
        /// <summary>
        /// YearToDateTotal
        /// </summary>
        YearToDateTotal = 38,
        /// <summary>
        /// NetProfitOrLoss
        /// </summary>
        NetProfitOrLoss = 39,
        /// <summary>
        /// NetFarmProfitOrLoss
        /// </summary>
        NetFarmProfitOrLoss = 40,
        /// <summary>
        /// Other
        /// </summary>
        Other = 41,
        /// <summary>
        /// TotalExpenses
        /// </summary>
        TotalExpenses = 42,
        /// <summary>
        /// Depreciation1
        /// </summary>
        Depreciation1 = 43,
        /// <summary>
        /// InterestIncome
        /// </summary>
        InterestIncome = 44,
        /// <summary>
        /// DividendIncome
        /// </summary>
        DividendIncome = 45,
        /// <summary>
        /// Depreciation2
        /// </summary>
        Depreciation2 = 46,
        /// <summary>
        /// BusinessUseOfHome
        /// </summary>
        BusinessUseOfHome = 47,
        /// <summary>
        /// RecurringCapitalGains
        /// </summary>
        RecurringCapitalGains = 48,
        /// <summary>
        /// PrincipalPaymentsReceived
        /// </summary>
        PrincipalPaymentsReceived = 49,
        /// <summary>
        /// GrossRentsAndRoyalties
        /// </summary>
        GrossRentsAndRoyalties = 50,
        /// <summary>
        /// Amortization1
        /// </summary>
        Amortization1 = 51,
        /// <summary>
        /// InsuranceMortgageInterestAndTaxes
        /// </summary>
        InsuranceMortgageInterestAndTaxes = 52,
        /// <summary>
        /// NonTaxPortion
        /// </summary>
        NonTaxPortion = 53,
        /// <summary>
        /// Amortization2
        /// </summary>
        Amortization2 = 54,
        /// <summary>
        /// OrdinaryIncome
        /// </summary>
        OrdinaryIncome = 55,
        /// <summary>
        /// NetIncome
        /// </summary>
        NetIncome = 56,
        /// <summary>
        /// GuaranteedPayments
        /// </summary>
        GuaranteedPayments = 57,
        /// <summary>
        /// Total
        /// </summary>
        Total = 58,
        /// <summary>
        /// TotalIncome
        /// </summary>
        TotalIncome = 59,
        /// <summary>
        /// Wages
        /// </summary>
        Wages = 60,
        /// <summary>
        /// TaxExempt
        /// </summary>
        TaxExempt = 61,
        /// <summary>
        /// Passthrough
        /// </summary>
        Passthrough = 62,
        /// <summary>
        /// OwnershipPercent
        /// </summary>
        OwnershipPercent = 63,
        /// <summary>
        /// Year2_FormB
        /// </summary>
        [EnumMember(Value = "Year2_FormB")]
        Year2FormB = 64,
        /// <summary>
        /// Year2_FormA
        /// </summary>
        [EnumMember(Value = "Year2_FormA")]
        Year2FormA = 65,
        /// <summary>
        /// Year1_FormA
        /// </summary>
        [EnumMember(Value = "Year1_FormA")]
        Year1FormA = 66,
        /// <summary>
        /// Year1_FormB
        /// </summary>
        [EnumMember(Value = "Year1_FormB")]
        Year1FormB = 67,
        /// <summary>
        /// BusinessName
        /// </summary>
        BusinessName = 68,
        /// <summary>
        /// None
        /// </summary>
        None = 69,
        /// <summary>
        /// OtherDescription
        /// </summary>
        OtherDescription = 70
    }
}