using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LiabilityType
    /// </summary>
    public enum LiabilityType
    {
        /// <summary>
        /// Child Care
        /// </summary>
        [Description("Child Care")]
        ChildCare = 0,
        /// <summary>
        /// Child Support
        /// </summary>
        [Description("Child Support")]
        ChildSupport = 1,
        /// <summary>
        /// Collections Judgments And Liens
        /// </summary>
        [Description("Collections Judgments And Liens")]
        CollectionsJudgementsAndLiens = 2,
        /// <summary>
        /// HELOC
        /// </summary>
        HELOC = 3,
        /// <summary>
        /// Installment
        /// </summary>
        Installment = 4,
        /// <summary>
        /// Lease Payments
        /// </summary>
        [Description("Lease Payments")]
        LeasePayments = 5,
        /// <summary>
        /// Mortgage
        /// </summary>
        [Description("Mortgage")]
        MortgageLoan = 6,
        /// <summary>
        /// Open 30 Days Charge Account
        /// </summary>
        [Description("Open 30 Days Charge Account")]
        Open30DayChargeAccount = 7,
        /// <summary>
        /// Other Liability
        /// </summary>
        [Description("Other Liability")]
        OtherLiability = 8,
        /// <summary>
        /// Revolving
        /// </summary>
        Revolving = 9,
        /// <summary>
        /// Separate Maintenance Expense
        /// </summary>
        [Description("Separate Maintenance Expense")]
        SeparateMaintenanceExpense = 10,
        /// <summary>
        /// Other Expense
        /// </summary>
        [Description("Other Expense")]
        OtherExpense = 11,
        /// <summary>
        /// Taxes
        /// </summary>
        Taxes = 12
    }
}