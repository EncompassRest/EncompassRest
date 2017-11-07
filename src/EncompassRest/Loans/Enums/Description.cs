using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Description
    {
        AccessoryUnitIncome = 0,
        AlimonyChildSupport = 1,
        AutomobileExpenseAccount = 2,
        CapitalGains = 3,
        EmploymentRelatedAssets = 4,
        FNMBoarderIncome = 5,
        FNMGovernmentMortgageCreditCertificate = 6,
        ForeignIncome = 7,
        FosterCare = 8,
        Section8 = 9,
        MilitaryBasePay = 10,
        MilitaryClothesAllowance = 11,
        MilitaryCombatPay = 12,
        MilitaryFlightPay = 13,
        MilitaryHazardPay = 14,
        MilitaryOverseasPay = 15,
        MilitaryPropPay = 16,
        MilitaryQuartersAllowance = 17,
        MilitaryRationsAllowance = 18,
        MilitaryVariableHousingAllowance = 19,
        [EnumMember(Value = "Non-borrowerHouseholdIncome")]
        NonBorrowerHouseholdIncome = 20,
        NotesReceivableInstallment = 21,
        OtherIncome = 22,
        Pension = 23,
        MortgageDifferential = 24,
        RoyaltyPayment = 25,
        SeasonalIncome = 26,
        SocialSecurity = 27,
        TemporaryLeave = 28,
        TipIncome = 29,
        Trust = 30,
        Unemployment = 31,
        VABenefitsNonEducational = 32
    }
}