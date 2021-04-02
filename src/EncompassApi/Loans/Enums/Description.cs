using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// Description
    /// </summary>
    public enum Description
    {
        /// <summary>
        /// Accessory Unit Income
        /// </summary>
        [Description("Accessory Unit Income")]
        AccessoryUnitIncome = 0,
        /// <summary>
        /// Alimony/Child Support
        /// </summary>
        [Description("Alimony/Child Support")]
        AlimonyChildSupport = 1,
        /// <summary>
        /// Automobile/Expense Account
        /// </summary>
        [Description("Automobile/Expense Account")]
        AutomobileExpenseAccount = 2,
        /// <summary>
        /// Capital Gains
        /// </summary>
        [Description("Capital Gains")]
        CapitalGains = 3,
        /// <summary>
        /// Employment Related Assets
        /// </summary>
        [Description("Employment Related Assets")]
        EmploymentRelatedAssets = 4,
        /// <summary>
        /// FNM Boarder Income
        /// </summary>
        [Description("FNM Boarder Income")]
        FNMBoarderIncome = 5,
        /// <summary>
        /// FNM Government Mortgage Credit Certificate
        /// </summary>
        [Description("FNM Government Mortgage Credit Certificate")]
        FNMGovernmentMortgageCreditCertificate = 6,
        /// <summary>
        /// Foreign Income
        /// </summary>
        [Description("Foreign Income")]
        ForeignIncome = 7,
        /// <summary>
        /// Foster Care
        /// </summary>
        [Description("Foster Care")]
        FosterCare = 8,
        /// <summary>
        /// Housing Choice Voucher Program (Section 8)
        /// </summary>
        [Description("Housing Choice Voucher Program (Section 8)")]
        Section8 = 9,
        /// <summary>
        /// Military Base Pay
        /// </summary>
        [Description("Military Base Pay")]
        MilitaryBasePay = 10,
        /// <summary>
        /// Military Clothes Allowance
        /// </summary>
        [Description("Military Clothes Allowance")]
        MilitaryClothesAllowance = 11,
        /// <summary>
        /// Military Combat Pay
        /// </summary>
        [Description("Military Combat Pay")]
        MilitaryCombatPay = 12,
        /// <summary>
        /// Military Flight Pay
        /// </summary>
        [Description("Military Flight Pay")]
        MilitaryFlightPay = 13,
        /// <summary>
        /// Military Hazard Pay
        /// </summary>
        [Description("Military Hazard Pay")]
        MilitaryHazardPay = 14,
        /// <summary>
        /// Military Overseas Pay
        /// </summary>
        [Description("Military Overseas Pay")]
        MilitaryOverseasPay = 15,
        /// <summary>
        /// Military Prop Pay
        /// </summary>
        [Description("Military Prop Pay")]
        MilitaryPropPay = 16,
        /// <summary>
        /// Military Quarters Allowance
        /// </summary>
        [Description("Military Quarters Allowance")]
        MilitaryQuartersAllowance = 17,
        /// <summary>
        /// Military Rations Allowance
        /// </summary>
        [Description("Military Rations Allowance")]
        MilitaryRationsAllowance = 18,
        /// <summary>
        /// Military Variable Housing Allowance
        /// </summary>
        [Description("Military Variable Housing Allowance")]
        MilitaryVariableHousingAllowance = 19,
        /// <summary>
        /// Non-borrower Household Income
        /// </summary>
        [Description("Non-borrower Household Income")]
        [EnumMember(Value = "Non-borrowerHouseholdIncome")]
        NonBorrowerHouseholdIncome = 20,
        /// <summary>
        /// Notes Receivable/Installment
        /// </summary>
        [Description("Notes Receivable/Installment")]
        NotesReceivableInstallment = 21,
        /// <summary>
        /// Other Types Of Income
        /// </summary>
        [Description("Other Types Of Income")]
        OtherIncome = 22,
        /// <summary>
        /// Pension/Retirement Income
        /// </summary>
        [Description("Pension/Retirement Income")]
        Pension = 23,
        /// <summary>
        /// Real Estate/Mortgage Differential
        /// </summary>
        [Description("Real Estate/Mortgage Differential")]
        MortgageDifferential = 24,
        /// <summary>
        /// Royalty Payment
        /// </summary>
        [Description("Royalty Payment")]
        RoyaltyPayment = 25,
        /// <summary>
        /// Seasonal Income
        /// </summary>
        [Description("Seasonal Income")]
        SeasonalIncome = 26,
        /// <summary>
        /// Social Security/Disability Income
        /// </summary>
        [Description("Social Security/Disability Income")]
        SocialSecurity = 27,
        /// <summary>
        /// Temporary Leave
        /// </summary>
        [Description("Temporary Leave")]
        TemporaryLeave = 28,
        /// <summary>
        /// Tip Income
        /// </summary>
        [Description("Tip Income")]
        TipIncome = 29,
        /// <summary>
        /// Trust Income
        /// </summary>
        [Description("Trust Income")]
        Trust = 30,
        /// <summary>
        /// Unemployment/Public Assistance
        /// </summary>
        [Description("Unemployment/Public Assistance")]
        Unemployment = 31,
        /// <summary>
        /// VA Benefits NonEducational
        /// </summary>
        [Description("VA Benefits NonEducational")]
        VABenefitsNonEducational = 32
    }
}