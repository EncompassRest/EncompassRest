using EncompassRest.Loans.Enums;
using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// BuySide
    /// </summary>
    public sealed partial class LoanInformation : DirtyExtensibleObject
    {
        private DirtyValue<List<LockRequestBorrower>?>? _lockRequestBorrowers;
        private DirtyValue<string?>? _planCode;
        private DirtyValue<string?>? _loanDocumentationType;
        private DirtyValue<string?>? _borrowerMinimumFico;
        private DirtyValue<string?>? _coBorrowerMinimumFico;
        private DirtyValue<string?>? _creditScoreToUse;
        private DirtyValue<bool?>? _isFirstTimeHomeBuyer;
        private DirtyValue<bool?>? _canDemonstrateTwelveMonthMortgageRentalHistory;
        private DirtyValue<SubjectProperty?>? _subjectProperty;
        private DirtyValue<StringEnumValue<LoanPurposeType>>? _loanPurposeType;
        private DirtyValue<bool?>? _currentAcquisition;
        private DirtyValue<bool?>? _currentConstructionRefinance;
        private DirtyValue<bool?>? _loanFor203K;
        private DirtyValue<decimal?>? _totalForLesserOfSumAsIs;
        private DirtyValue<string?>? _lienPriorityType;
        private DirtyValue<StringEnumValue<LoanType>>? _mortgageType;
        private DirtyValue<StringEnumValue<AmortizationType>>? _loanAmortizationType;
        private DirtyValue<string?>? _gpmRate;
        private DirtyValue<string?>? _gpmYears;
        private DirtyValue<string?>? _fnmProductPlanIdentifier;
        private DirtyValue<string?>? _otherAmortizationTypeDescription;
        private DirtyValue<string?>? _requestImpoundWaived;
        private DirtyValue<StringEnumValue<ImpoundType>>? _requestImpoundType;
        private DirtyValue<bool?>? _prepayPenalty;
        private DirtyValue<int?>? _penaltyTerm;
        private DirtyValue<bool?>? _noClosingCost;
        private DirtyValue<bool?>? _lenderFeeWaiver;
        private DirtyValue<DateTime?>? _estimatedClosingDate;
        private DirtyValue<decimal?>? _sellerPaidMiPremium;
        private DirtyValue<decimal?>? _fhaUpfrontMiPremiumPercent;
        private DirtyValue<decimal?>? _fundingAmount;
        private DirtyValue<decimal?>? _ltv;
        private DirtyValue<decimal?>? _combinedLtv;
        private DirtyValue<decimal?>? _mipPaidInCash;
        private DirtyValue<bool?>? _roundToNearestFifty;
        private DirtyValue<int?>? _balloonLoanMaturityTerms;
        private DirtyValue<int?>? _loanAmortizationTerms;
        private DirtyValue<decimal?>? _baseLoanAmount;
        private DirtyValue<decimal?>? _borrowerRequestedLoanAmount;
        private DirtyValue<decimal?>? _helocActualBalance;
        private DirtyValue<decimal?>? _firstSubordinateAmount;
        private DirtyValue<decimal?>? _secondSubordinateAmount;
        private DirtyValue<decimal?>? _otherSubordinateAmount;
        private DirtyValue<bool?>? _lockField;
        private DirtyValue<decimal?>? _totalSubordinateFinancing;
        private DirtyValue<DateTime?>? _pricingUpdated;
        private DirtyValue<StringEnumValue<ImpoundType>>? _impoundType;
        private DirtyValue<StringEnumValue<ImpoundWaived>>? _impoundWaived;
        private DirtyValue<bool?>? _isLenderPaid;
        private DirtyValue<string?>? _pricingHistoryData;

        /// <summary>
        /// Object containing the borrowers' information.
        /// </summary>
        public List<LockRequestBorrower>? LockRequestBorrowers { get => _lockRequestBorrowers; set => SetField(ref _lockRequestBorrowers, value); }

        /// <summary>
        /// The plan code associated with the lock request.
        /// </summary>
        public string? PlanCode { get => _planCode; set => SetField(ref _planCode, value); }

        /// <summary>
        /// Fannie Mae loan documentation type code.
        /// </summary>
        public string? LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }

        /// <summary>
        /// The minimum FICO score allowed for the borrower to qualify for the loan program.
        /// </summary>
        public string? BorrowerMinimumFico { get => _borrowerMinimumFico; set => SetField(ref _borrowerMinimumFico, value); }

        /// <summary>
        /// The minimum FICO score allowed for the co-borrower to qualify for the loan program.
        /// </summary>
        public string? CoBorrowerMinimumFico { get => _coBorrowerMinimumFico; set => SetField(ref _coBorrowerMinimumFico, value); }

        /// <summary>
        /// The credit score to use when qualifying the loan for a loan product. Depending on the loan product and the scores of the applicants, the credit score may come from the borrower, co-borrower, or even co-mortgagors.
        /// </summary>
        public string? CreditScoreToUse { get => _creditScoreToUse; set => SetField(ref _creditScoreToUse, value); }

        /// <summary>
        /// Indicates whether the borrower is a first time home buyer.
        /// </summary>
        public bool? IsFirstTimeHomeBuyer { get => _isFirstTimeHomeBuyer; set => SetField(ref _isFirstTimeHomeBuyer, value); }

        /// <summary>
        /// Indicates whether the borrower can demonstrate twelve months mortgage rental history.
        /// </summary>
        public bool? CanDemonstrateTwelveMonthMortgageRentalHistory { get => _canDemonstrateTwelveMonthMortgageRentalHistory; set => SetField(ref _canDemonstrateTwelveMonthMortgageRentalHistory, value); }

        /// <summary>
        /// Attributes that define the subject property.
        /// </summary>
        public SubjectProperty? SubjectProperty { get => _subjectProperty; set => SetField(ref _subjectProperty, value); }

        /// <summary>
        /// Loan Purpose Type. Possible values are: construction-perm, no cash-out refi, purchase, construction, cash-out refi, other
        /// </summary>
        public StringEnumValue<LoanPurposeType>? LoanPurposeType { get => _loanPurposeType; set => SetField(ref _loanPurposeType, value); }

        /// <summary>
        /// Indicates whether the loan is a current Acquisition.
        /// </summary>
        public bool? CurrentAcquisition { get => _currentAcquisition; set => SetField(ref _currentAcquisition, value); }

        /// <summary>
        /// Indicates whether the loan is a current Construction Refinance.
        /// </summary>
        public bool? CurrentConstructionRefinance { get => _currentConstructionRefinance; set => SetField(ref _currentConstructionRefinance, value); }

        /// <summary>
        /// Indicates whether the loan is for a 203K.
        /// </summary>
        public bool? LoanFor203K { get => _loanFor203K; set => SetField(ref _loanFor203K, value); }

        /// <summary>
        /// Total for lesser of sum as is.
        /// </summary>
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => SetField(ref _totalForLesserOfSumAsIs, value); }

        /// <summary>
        /// Lien priority type.
        /// </summary>
        public string? LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }

        /// <summary>
        /// Mortgage type. Possible values are: Conventional, VA, FHA, USDA-RHS, Other, HELOC
        /// </summary>
        public StringEnumValue<LoanType>? MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

        /// <summary>
        /// Loan Amortization Type. Possible values are fixed rate, gpm-rate, arm, other
        /// </summary>
        public StringEnumValue<AmortizationType>? LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }

        /// <summary>
        /// GPM rate. A mortgage in which the payments are lower in the first years, and then increase annually until a level that fully amortizes the loan within its term.
        /// </summary>
        public string? GpmRate { get => _gpmRate; set => SetField(ref _gpmRate, value); }

        /// <summary>
        /// GPM years. The number of years the rate (as defined by the GPM attribute) is in effect before the loan is reamortized.
        /// </summary>
        public string? GpmYears { get => _gpmYears; set => SetField(ref _gpmYears, value); }

        /// <summary>
        /// FNM Product Plan Identifier.
        /// </summary>
        public string? FnmProductPlanIdentifier { get => _fnmProductPlanIdentifier; set => SetField(ref _fnmProductPlanIdentifier, value); }

        /// <summary>
        /// Description if the amortization type is set to Other.
        /// </summary>
        public string? OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }

        /// <summary>
        /// Request Impound Waived indicator.
        /// </summary>
        public string? RequestImpoundWaived { get => _requestImpoundWaived; set => SetField(ref _requestImpoundWaived, value); }

        /// <summary>
        /// Request Impound Type. Possible values are: Taxes & Insurance, taxes only, insurance only, no impounds
        /// </summary>
        public StringEnumValue<ImpoundType>? RequestImpoundType { get => _requestImpoundType; set => SetField(ref _requestImpoundType, value); }

        /// <summary>
        /// Indicates whether the Penalty is prepaid.
        /// </summary>
        public bool? PrepayPenalty { get => _prepayPenalty; set => SetField(ref _prepayPenalty, value); }

        /// <summary>
        /// Term of the penalty in months.
        /// </summary>
        public int? PenaltyTerm { get => _penaltyTerm; set => SetField(ref _penaltyTerm, value); }

        /// <summary>
        /// Indicates whether there is a closing cost.
        /// </summary>
        public bool? NoClosingCost { get => _noClosingCost; set => SetField(ref _noClosingCost, value); }

        /// <summary>
        /// Indicates whether there is a lender fee waiver.
        /// </summary>
        public bool? LenderFeeWaiver { get => _lenderFeeWaiver; set => SetField(ref _lenderFeeWaiver, value); }

        /// <summary>
        /// Estimated closing date of the loan.
        /// </summary>
        public DateTime? EstimatedClosingDate { get => _estimatedClosingDate; set => SetField(ref _estimatedClosingDate, value); }

        /// <summary>
        /// Seller paid MI premium.
        /// </summary>
        public decimal? SellerPaidMiPremium { get => _sellerPaidMiPremium; set => SetField(ref _sellerPaidMiPremium, value); }

        /// <summary>
        /// FHA upfront MI premium percentage
        /// </summary>
        public decimal? FhaUpfrontMiPremiumPercent { get => _fhaUpfrontMiPremiumPercent; set => SetField(ref _fhaUpfrontMiPremiumPercent, value); }

        /// <summary>
        /// Funding amount.
        /// </summary>
        public decimal? FundingAmount { get => _fundingAmount; set => SetField(ref _fundingAmount, value); }

        /// <summary>
        /// The Loan-to-Value (LTV) ratio used for the lock request.
        /// </summary>
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

        /// <summary>
        /// The combined Loan-to-Value (CLTV) ratio used for the lock request.
        /// </summary>
        public decimal? CombinedLtv { get => _combinedLtv; set => SetField(ref _combinedLtv, value); }

        /// <summary>
        /// The Amount Paid in Cash or the MIP/Funding amount.
        /// </summary>
        public decimal? MipPaidInCash { get => _mipPaidInCash; set => SetField(ref _mipPaidInCash, value); }

        /// <summary>
        /// Round the Total Loan Amount to the nearest $50 increment.
        /// </summary>
        public bool? RoundToNearestFifty { get => _roundToNearestFifty; set => SetField(ref _roundToNearestFifty, value); }

        /// <summary>
        /// Balloon loan maturity terms.
        /// </summary>
        public int? BalloonLoanMaturityTerms { get => _balloonLoanMaturityTerms; set => SetField(ref _balloonLoanMaturityTerms, value); }

        /// <summary>
        /// Loan amortization terms.
        /// </summary>
        public int? LoanAmortizationTerms { get => _loanAmortizationTerms; set => SetField(ref _loanAmortizationTerms, value); }

        /// <summary>
        /// Base loan amount.
        /// </summary>
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }

        /// <summary>
        /// Borrower requested loan amount.
        /// </summary>
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => SetField(ref _borrowerRequestedLoanAmount, value); }

        /// <summary>
        /// HELOC actual balance.
        /// </summary>
        public decimal? HelocActualBalance { get => _helocActualBalance; set => SetField(ref _helocActualBalance, value); }

        /// <summary>
        /// First subordinate amount.
        /// </summary>
        public decimal? FirstSubordinateAmount { get => _firstSubordinateAmount; set => SetField(ref _firstSubordinateAmount, value); }

        /// <summary>
        /// Second subordinate amount.
        /// </summary>
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => SetField(ref _secondSubordinateAmount, value); }

        /// <summary>
        /// Other subordinate amount.
        /// </summary>
        public decimal? OtherSubordinateAmount { get => _otherSubordinateAmount; set => SetField(ref _otherSubordinateAmount, value); }

        /// <summary>
        /// Lock field.
        /// </summary>
        public bool? LockField { get => _lockField; set => SetField(ref _lockField, value); }

        /// <summary>
        /// Total subordinate financing.
        /// </summary>
        public decimal? TotalSubordinateFinancing { get => _totalSubordinateFinancing; set => SetField(ref _totalSubordinateFinancing, value); }

        /// <summary>
        /// The last date and time that pricing was imported.
        /// </summary>
        public DateTime? PricingUpdated { get => _pricingUpdated; set => SetField(ref _pricingUpdated, value); }

        /// <summary>
        /// Impound type. Possible options are: Taxes and Insurance(T&I), Taxes only(T), Insurance only(I), No impounds\
        /// </summary>
        public StringEnumValue<ImpoundType>? ImpoundType { get => _impoundType; set => SetField(ref _impoundType, value); }

        /// <summary>
        /// Whether the impound is waived or not waived.
        /// </summary>
        public StringEnumValue<ImpoundWaived>? ImpoundWaived { get => _impoundWaived; set => SetField(ref _impoundWaived, value); }

        /// <summary>
        /// Indicates whether the lender has paid MI.
        /// </summary>
        public bool? IsLenderPaid { get => _isLenderPaid; set => SetField(ref _isLenderPaid, value); }

        /// <summary>
        /// Pricing history data.
        /// </summary>
        public string? PricingHistoryData { get => _pricingHistoryData; set => SetField(ref _pricingHistoryData, value); }

    }
}