using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Loans.v1;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LoanInformation
    /// </summary>
    public sealed partial class LoanInformation : DirtyExtensibleObject
    {
        /// <summary>
        /// Object containing the borrowers' information.
        /// </summary>
        public List<LockRequestBorrower>? LockRequestBorrowers { get => GetValue<List<LockRequestBorrower>?>(); set => SetValue(value); }

        /// <summary>
        /// The plan code associated with the lock request.
        /// </summary>
        public string? PlanCode { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Fannie Mae loan documentation type code.
        /// </summary>
        public string? LoanDocumentationType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The minimum FICO score allowed for the borrower to qualify for the loan program.
        /// </summary>
        public string? BorrowerMinimumFico { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The minimum FICO score allowed for the co-borrower to qualify for the loan program.
        /// </summary>
        public string? CoBorrowerMinimumFico { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The credit score to use when qualifying the loan for a loan product. Depending on the loan product and the scores of the applicants, the credit score may come from the borrower, co-borrower, or even co-mortgagors.
        /// </summary>
        public string? CreditScoreToUse { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the borrower is a first time home buyer.
        /// </summary>
        public bool? IsFirstTimeHomeBuyer { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the borrower can demonstrate twelve months mortgage rental history.
        /// </summary>
        public bool? CanDemonstrateTwelveMonthMortgageRentalHistory { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Attributes that define the subject property.
        /// </summary>
        public SubjectProperty? SubjectProperty { get => GetValue<SubjectProperty?>(); set => SetValue(value); }

        /// <summary>
        /// Loan Purpose Type. Possible values are: construction-perm, no cash-out refi, purchase, construction, cash-out refi, other
        /// </summary>
        public StringEnumValue<LoanPurposeType> LoanPurposeType { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the loan is a current Acquisition.
        /// </summary>
        public bool? CurrentAcquisition { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the loan is a current Construction Refinance.
        /// </summary>
        public bool? CurrentConstructionRefinance { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the loan is for a 203K.
        /// </summary>
        public bool? LoanFor203K { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Total for lesser of sum as is.
        /// </summary>
        public decimal? TotalForLesserOfSumAsIs { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Lien priority type.
        /// </summary>
        public string? LienPriorityType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Mortgage type. Possible values are: Conventional, VA, FHA, USDA-RHS, Other, HELOC
        /// </summary>
        public StringEnumValue<LoanType>? MortgageType { get => GetValue<StringEnumValue<LoanType>?>(); set => SetValue(value); }

        /// <summary>
        /// Loan Amortization Type. Possible values are fixed rate, gpm-rate, arm, other
        /// </summary>
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

        /// <summary>
        /// GPM rate. A mortgage in which the payments are lower in the first years, and then increase annually until a level that fully amortizes the loan within its term.
        /// </summary>
        public decimal? GpmRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// GPM years. The number of years the rate (as defined by the GPM attribute) is in effect before the loan is reamortized.
        /// </summary>
        public int? GpmYears { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// FNM Product Plan Identifier.
        /// </summary>
        public string? FnmProductPlanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Description if the amortization type is set to Other.
        /// </summary>
        public string? OtherAmortizationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Request Impound Waived indicator.
        /// </summary>
        public string? RequestImpoundWaived { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Request Impound Type. Possible values are: Taxes and Insurance, taxes only, insurance only, no impounds
        /// </summary>
        public StringEnumValue<ImpoundType> RequestImpoundType { get => GetValue<StringEnumValue<ImpoundType>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the Penalty is prepaid.
        /// </summary>
        public bool? PrepayPenalty { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Term of the penalty in months.
        /// </summary>
        public int? PenaltyTerm { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether there is a closing cost.
        /// </summary>
        public bool? NoClosingCost { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether there is a lender fee waiver.
        /// </summary>
        public bool? LenderFeeWaiver { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Estimated closing date of the loan.
        /// </summary>
        public DateTime? EstimatedClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Seller paid MI premium.
        /// </summary>
        public decimal? SellerPaidMiPremium { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// FHA upfront MI premium percentage
        /// </summary>
        public decimal? FhaUpfrontMiPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Funding amount.
        /// </summary>
        public decimal? FundingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Loan-to-Value (LTV) ratio used for the lock request.
        /// </summary>
        public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The combined Loan-to-Value (CLTV) ratio used for the lock request.
        /// </summary>
        public decimal? CombinedLtv { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Amount Paid in Cash or the MIP/Funding amount.
        /// </summary>
        public decimal? MipPaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Round the Total Loan Amount to the nearest $50 increment.
        /// </summary>
        public bool? RoundToNearestFifty { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Balloon loan maturity terms.
        /// </summary>
        public int? BalloonLoanMaturityTerms { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Loan amortization terms.
        /// </summary>
        public int? LoanAmortizationTerms { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Base loan amount.
        /// </summary>
        public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Borrower requested loan amount.
        /// </summary>
        public decimal? BorrowerRequestedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// HELOC actual balance.
        /// </summary>
        public decimal? HelocActualBalance { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// First subordinate amount.
        /// </summary>
        public decimal? FirstSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Second subordinate amount.
        /// </summary>
        public decimal? SecondSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Other subordinate amount.
        /// </summary>
        public decimal? OtherSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Lock field.
        /// </summary>
        public bool? LockField { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Total subordinate financing.
        /// </summary>
        public decimal? TotalSubordinateFinancing { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The last date and time that pricing was imported.
        /// </summary>
        public DateTime? PricingUpdated { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Impound type. Possible options are: Taxes and Insurance(T and I), Taxes only(T), Insurance only(I), No impounds\
        /// </summary>
        public StringEnumValue<ImpoundType> ImpoundType { get => GetValue<StringEnumValue<ImpoundType>>(); set => SetValue(value); }

        /// <summary>
        /// Whether the impound is waived or not waived.
        /// </summary>
        public StringEnumValue<ImpoundWaived> ImpoundWaived { get => GetValue<StringEnumValue<ImpoundWaived>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the lender has paid MI.
        /// </summary>
        public bool? IsLenderPaidMortgageInsurance { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Pricing history data.
        /// </summary>
        public string? PricingHistoryData { get => GetValue<string?>(); set => SetValue(value); }
    }
}