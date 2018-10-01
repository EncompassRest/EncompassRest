using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AntiSteeringLoanOption
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(AntiSteeringLoanOptionIndex))]
    public sealed partial class AntiSteeringLoanOption : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _antiSteeringLoanOptionIndex;
        private DirtyValue<decimal?> _brokerCompensationFeeAmount;
        private DirtyValue<decimal?> _brokerCompensationFeeBorPaidAmount;
        private DirtyValue<decimal?> _brokerCompensationFeePercentage;
        private DirtyValue<decimal?> _brokerFeeAmount;
        private DirtyValue<decimal?> _brokerFeeBorPaidAmount;
        private DirtyValue<decimal?> _brokerFeePercentage;
        private DirtyValue<decimal?> _brokerFeeSellerPaidAmount;
        private DirtyValue<string> _creditorName;
        private DirtyValue<decimal?> _discountAdditionalAmount;
        private DirtyValue<decimal?> _discountAmount;
        private DirtyValue<decimal?> _discountFeeBorPaidAmount;
        private DirtyValue<decimal?> _discountFeeSellerPaidAmount;
        private DirtyValue<decimal?> _discountPercentage;
        private DirtyValue<decimal?> _discountPoints;
        private DirtyValue<int?> _fixedRatePeriod;
        private DirtyValue<StringEnumValue<YesOrNo>> _haveDemandFeature;
        private DirtyValue<bool?> _havePrepaymentPenalty;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _inspectionFeeBorPaidAmount;
        private DirtyValue<decimal?> _inspectionFeeSellerPaidAmount;
        private DirtyValue<decimal?> _interestRate;
        private DirtyValue<StringEnumValue<YesOrNo>> _isBalloonPaymentIn7Years;
        private DirtyValue<StringEnumValue<YesOrNo>> _isInterestOnlyLoan;
        private DirtyValue<bool?> _isNegativeAmortization;
        private DirtyValue<int?> _loanTerm;
        private DirtyValue<StringEnumValue<AmortizationType>> _loanType;
        private DirtyValue<decimal?> _originationFeeBorPaidAmount;
        private DirtyValue<decimal?> _originationFeePercentage;
        private DirtyValue<decimal?> _originationFeeSellerPaidAmount;
        private DirtyValue<decimal?> _originationPointsFees;
        private DirtyValue<decimal?> _originationPointsPercetange;
        private DirtyValue<decimal?> _processingFeeBorPaidAmount;
        private DirtyValue<decimal?> _processingFeeSellerPaidAmount;
        private DirtyValue<decimal?> _totalOriginationDiscountAmount;
        private DirtyValue<decimal?> _underwritingFeeBorPaidAmount;
        private DirtyValue<decimal?> _underwritingFeeSellerPaidAmount;
        private DirtyValue<decimal?> _userDefinedFee1BorPaidAmount;
        private DirtyValue<string> _userDefinedFee1Description;
        private DirtyValue<decimal?> _userDefinedFee1SellerPaidAmount;
        private DirtyValue<decimal?> _userDefinedFee2BorPaidAmount;
        private DirtyValue<string> _userDefinedFee2Description;
        private DirtyValue<decimal?> _userDefinedFee2SellerPaidAmount;
        private DirtyValue<decimal?> _userDefinedFee3BorPaidAmount;
        private DirtyValue<string> _userDefinedFee3Description;
        private DirtyValue<decimal?> _userDefinedFee3SellerPaidAmount;
        private DirtyValue<decimal?> _userDefinedFee4BorPaidAmount;
        private DirtyValue<string> _userDefinedFee4Description;
        private DirtyValue<decimal?> _userDefinedFee4SellerPaidAmount;
        private DirtyValue<decimal?> _userDefinedFee5BorPaidAmount;
        private DirtyValue<string> _userDefinedFee5Description;
        private DirtyValue<decimal?> _userDefinedFee5SellerPaidAmount;

        /// <summary>
        /// AntiSteeringLoanOption AntiSteeringLoanOptionIndex
        /// </summary>
        public int? AntiSteeringLoanOptionIndex { get => _antiSteeringLoanOptionIndex; set => SetField(ref _antiSteeringLoanOptionIndex, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerCompensationFeeAmount { get => _brokerCompensationFeeAmount; set => SetField(ref _brokerCompensationFeeAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerCompensationFeeBorPaidAmount { get => _brokerCompensationFeeBorPaidAmount; set => SetField(ref _brokerCompensationFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerCompensationFeePercentage { get => _brokerCompensationFeePercentage; set => SetField(ref _brokerCompensationFeePercentage, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeAmount { get => _brokerFeeAmount; set => SetField(ref _brokerFeeAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeBorPaidAmount { get => _brokerFeeBorPaidAmount; set => SetField(ref _brokerFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerFeePercentage { get => _brokerFeePercentage; set => SetField(ref _brokerFeePercentage, value); }

        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeSellerPaidAmount { get => _brokerFeeSellerPaidAmount; set => SetField(ref _brokerFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption CreditorName
        /// </summary>
        public string CreditorName { get => _creditorName; set => SetField(ref _creditorName, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountAdditionalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountAdditionalAmount { get => _discountAdditionalAmount; set => SetField(ref _discountAdditionalAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DiscountAmount { get => _discountAmount; set => SetField(ref _discountAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountFeeBorPaidAmount { get => _discountFeeBorPaidAmount; set => SetField(ref _discountFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountFeeSellerPaidAmount { get => _discountFeeSellerPaidAmount; set => SetField(ref _discountFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountPercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DiscountPercentage { get => _discountPercentage; set => SetField(ref _discountPercentage, value); }

        /// <summary>
        /// AntiSteeringLoanOption DiscountPoints
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DiscountPoints { get => _discountPoints; set => SetField(ref _discountPoints, value); }

        /// <summary>
        /// AntiSteeringLoanOption FixedRatePeriod
        /// </summary>
        public int? FixedRatePeriod { get => _fixedRatePeriod; set => SetField(ref _fixedRatePeriod, value); }

        /// <summary>
        /// AntiSteeringLoanOption HaveDemandFeature
        /// </summary>
        public StringEnumValue<YesOrNo> HaveDemandFeature { get => _haveDemandFeature; set => SetField(ref _haveDemandFeature, value); }

        /// <summary>
        /// AntiSteeringLoanOption HavePrepaymentPenalty
        /// </summary>
        public bool? HavePrepaymentPenalty { get => _havePrepaymentPenalty; set => SetField(ref _havePrepaymentPenalty, value); }

        /// <summary>
        /// AntiSteeringLoanOption Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// AntiSteeringLoanOption InspectionFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeeBorPaidAmount { get => _inspectionFeeBorPaidAmount; set => SetField(ref _inspectionFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption InspectionFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeeSellerPaidAmount { get => _inspectionFeeSellerPaidAmount; set => SetField(ref _inspectionFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption InterestRate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

        /// <summary>
        /// AntiSteeringLoanOption IsBalloonPaymentIn7Years
        /// </summary>
        public StringEnumValue<YesOrNo> IsBalloonPaymentIn7Years { get => _isBalloonPaymentIn7Years; set => SetField(ref _isBalloonPaymentIn7Years, value); }

        /// <summary>
        /// AntiSteeringLoanOption IsInterestOnlyLoan
        /// </summary>
        public StringEnumValue<YesOrNo> IsInterestOnlyLoan { get => _isInterestOnlyLoan; set => SetField(ref _isInterestOnlyLoan, value); }

        /// <summary>
        /// AntiSteeringLoanOption IsNegativeAmortization
        /// </summary>
        public bool? IsNegativeAmortization { get => _isNegativeAmortization; set => SetField(ref _isNegativeAmortization, value); }

        /// <summary>
        /// AntiSteeringLoanOption LoanTerm
        /// </summary>
        public int? LoanTerm { get => _loanTerm; set => SetField(ref _loanTerm, value); }

        /// <summary>
        /// Anti-Steering Disclosure - Loan Option 1 - Loan Type [DISCLOSURE.X689]
        /// </summary>
        public StringEnumValue<AmortizationType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

        /// <summary>
        /// AntiSteeringLoanOption OriginationFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationFeeBorPaidAmount { get => _originationFeeBorPaidAmount; set => SetField(ref _originationFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption OriginationFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationFeePercentage { get => _originationFeePercentage; set => SetField(ref _originationFeePercentage, value); }

        /// <summary>
        /// AntiSteeringLoanOption OriginationFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationFeeSellerPaidAmount { get => _originationFeeSellerPaidAmount; set => SetField(ref _originationFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption OriginationPointsFees
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationPointsFees { get => _originationPointsFees; set => SetField(ref _originationPointsFees, value); }

        /// <summary>
        /// AntiSteeringLoanOption OriginationPointsPercetange
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationPointsPercetange { get => _originationPointsPercetange; set => SetField(ref _originationPointsPercetange, value); }

        /// <summary>
        /// AntiSteeringLoanOption ProcessingFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ProcessingFeeBorPaidAmount { get => _processingFeeBorPaidAmount; set => SetField(ref _processingFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption ProcessingFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ProcessingFeeSellerPaidAmount { get => _processingFeeSellerPaidAmount; set => SetField(ref _processingFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption TotalOriginationDiscountAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalOriginationDiscountAmount { get => _totalOriginationDiscountAmount; set => SetField(ref _totalOriginationDiscountAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UnderwritingFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnderwritingFeeBorPaidAmount { get => _underwritingFeeBorPaidAmount; set => SetField(ref _underwritingFeeBorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UnderwritingFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnderwritingFeeSellerPaidAmount { get => _underwritingFeeSellerPaidAmount; set => SetField(ref _underwritingFeeSellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee1BorPaidAmount { get => _userDefinedFee1BorPaidAmount; set => SetField(ref _userDefinedFee1BorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1Description
        /// </summary>
        public string UserDefinedFee1Description { get => _userDefinedFee1Description; set => SetField(ref _userDefinedFee1Description, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee1SellerPaidAmount { get => _userDefinedFee1SellerPaidAmount; set => SetField(ref _userDefinedFee1SellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee2BorPaidAmount { get => _userDefinedFee2BorPaidAmount; set => SetField(ref _userDefinedFee2BorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2Description
        /// </summary>
        public string UserDefinedFee2Description { get => _userDefinedFee2Description; set => SetField(ref _userDefinedFee2Description, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee2SellerPaidAmount { get => _userDefinedFee2SellerPaidAmount; set => SetField(ref _userDefinedFee2SellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee3BorPaidAmount { get => _userDefinedFee3BorPaidAmount; set => SetField(ref _userDefinedFee3BorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3Description
        /// </summary>
        public string UserDefinedFee3Description { get => _userDefinedFee3Description; set => SetField(ref _userDefinedFee3Description, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee3SellerPaidAmount { get => _userDefinedFee3SellerPaidAmount; set => SetField(ref _userDefinedFee3SellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee4BorPaidAmount { get => _userDefinedFee4BorPaidAmount; set => SetField(ref _userDefinedFee4BorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4Description
        /// </summary>
        public string UserDefinedFee4Description { get => _userDefinedFee4Description; set => SetField(ref _userDefinedFee4Description, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee4SellerPaidAmount { get => _userDefinedFee4SellerPaidAmount; set => SetField(ref _userDefinedFee4SellerPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee5BorPaidAmount { get => _userDefinedFee5BorPaidAmount; set => SetField(ref _userDefinedFee5BorPaidAmount, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5Description
        /// </summary>
        public string UserDefinedFee5Description { get => _userDefinedFee5Description; set => SetField(ref _userDefinedFee5Description, value); }

        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee5SellerPaidAmount { get => _userDefinedFee5SellerPaidAmount; set => SetField(ref _userDefinedFee5SellerPaidAmount, value); }
    }
}