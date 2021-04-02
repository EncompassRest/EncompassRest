using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// OtherIncomeSourceDescription
    /// </summary>
    public enum OtherIncomeSourceDescription
    {
        /// <summary>
        /// Alimony
        /// </summary>
        Alimony = 0,
        /// <summary>
        /// Automobile Allowance
        /// </summary>
        [Description("Automobile Allowance")]
        AutomobileAllowance = 1,
        /// <summary>
        /// Boarder Income
        /// </summary>
        [Description("Boarder Income")]
        BoarderIncome = 2,
        /// <summary>
        /// Capital Gains
        /// </summary>
        [Description("Capital Gains")]
        CapitalGains = 3,
        /// <summary>
        /// Child Support
        /// </summary>
        [Description("Child Support")]
        ChildSupport = 4,
        /// <summary>
        /// Defined Contribution Plan
        /// </summary>
        [Description("Defined Contribution Plan")]
        DefinedContributionPlan = 5,
        /// <summary>
        /// Disability
        /// </summary>
        Disability = 6,
        /// <summary>
        /// Dividends Interest
        /// </summary>
        [Description("Dividends Interest")]
        DividendsInterest = 7,
        /// <summary>
        /// Foster Care
        /// </summary>
        [Description("Foster Care")]
        FosterCare = 8,
        /// <summary>
        /// Housing Allowance
        /// </summary>
        [Description("Housing Allowance")]
        HousingAllowance = 9,
        /// <summary>
        /// Mortgage Credit Certificate
        /// </summary>
        [Description("Mortgage Credit Certificate")]
        MortgageCreditCertificate = 10,
        /// <summary>
        /// Mortgage Differential
        /// </summary>
        [Description("Mortgage Differential")]
        MortgageDifferential = 11,
        /// <summary>
        /// Notes Receivable Installment
        /// </summary>
        [Description("Notes Receivable Installment")]
        NotesReceivableInstallment = 12,
        /// <summary>
        /// Other
        /// </summary>
        Other = 13,
        /// <summary>
        /// Public Assistance
        /// </summary>
        [Description("Public Assistance")]
        PublicAssistance = 14,
        /// <summary>
        /// Pension
        /// </summary>
        Pension = 15,
        /// <summary>
        /// Royalties
        /// </summary>
        Royalties = 16,
        /// <summary>
        /// Separate Maintenance
        /// </summary>
        [Description("Separate Maintenance")]
        SeparateMaintenance = 17,
        /// <summary>
        /// Social Security
        /// </summary>
        [Description("Social Security")]
        SocialSecurity = 18,
        /// <summary>
        /// Trust
        /// </summary>
        Trust = 19,
        /// <summary>
        /// Unemployment
        /// </summary>
        Unemployment = 20,
        /// <summary>
        /// VA Benefits NonEducational
        /// </summary>
        [Description("VA Benefits NonEducational")]
        VABenefitsNonEducational = 21,
        /// <summary>
        /// Accessory Unit Income
        /// </summary>
        [Description("Accessory Unit Income")]
        AccessoryUnitIncome = 22,
        /// <summary>
        /// Employment Related Account
        /// </summary>
        [Description("Employment Related Account")]
        EmploymentRelatedAccount = 23,
        /// <summary>
        /// Housing Choice Voucher Program
        /// </summary>
        [Description("Housing Choice Voucher Program")]
        HousingChoiceVoucherProgram = 24,
        /// <summary>
        /// Non Borrower Household Income
        /// </summary>
        [Description("Non Borrower Household Income")]
        NonBorrowerHouseholdIncome = 25,
        /// <summary>
        /// Temporary Leave
        /// </summary>
        [Description("Temporary Leave")]
        TemporaryLeave = 26,
        /// <summary>
        /// Tip Income
        /// </summary>
        [Description("Tip Income")]
        TipIncome = 27
    }
}