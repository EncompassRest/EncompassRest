using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AntiSteeringLoanOption
    /// </summary>
    public sealed partial class AntiSteeringLoanOption : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _antiSteeringLoanOptionIndex;
        /// <summary>
        /// AntiSteeringLoanOption AntiSteeringLoanOptionIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\"}")]
        public int? AntiSteeringLoanOptionIndex { get => _antiSteeringLoanOptionIndex; set => _antiSteeringLoanOptionIndex = value; }
        private DirtyValue<decimal?> _brokerCompensationFeeAmount;
        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerCompensationFeeAmount { get => _brokerCompensationFeeAmount; set => _brokerCompensationFeeAmount = value; }
        private DirtyValue<decimal?> _brokerCompensationFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerCompensationFeeBorPaidAmount { get => _brokerCompensationFeeBorPaidAmount; set => _brokerCompensationFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _brokerCompensationFeePercentage;
        /// <summary>
        /// AntiSteeringLoanOption BrokerCompensationFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerCompensationFeePercentage { get => _brokerCompensationFeePercentage; set => _brokerCompensationFeePercentage = value; }
        private DirtyValue<decimal?> _brokerFeeAmount;
        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeAmount { get => _brokerFeeAmount; set => _brokerFeeAmount = value; }
        private DirtyValue<decimal?> _brokerFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeBorPaidAmount { get => _brokerFeeBorPaidAmount; set => _brokerFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _brokerFeePercentage;
        /// <summary>
        /// AntiSteeringLoanOption BrokerFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerFeePercentage { get => _brokerFeePercentage; set => _brokerFeePercentage = value; }
        private DirtyValue<decimal?> _brokerFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption BrokerFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerFeeSellerPaidAmount { get => _brokerFeeSellerPaidAmount; set => _brokerFeeSellerPaidAmount = value; }
        private DirtyValue<string> _creditorName;
        /// <summary>
        /// AntiSteeringLoanOption CreditorName
        /// </summary>
        public string CreditorName { get => _creditorName; set => _creditorName = value; }
        private DirtyValue<decimal?> _discountAdditionalAmount;
        /// <summary>
        /// AntiSteeringLoanOption DiscountAdditionalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountAdditionalAmount { get => _discountAdditionalAmount; set => _discountAdditionalAmount = value; }
        private DirtyValue<decimal?> _discountAmount;
        /// <summary>
        /// AntiSteeringLoanOption DiscountAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DiscountAmount { get => _discountAmount; set => _discountAmount = value; }
        private DirtyValue<decimal?> _discountFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption DiscountFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountFeeBorPaidAmount { get => _discountFeeBorPaidAmount; set => _discountFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _discountFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption DiscountFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountFeeSellerPaidAmount { get => _discountFeeSellerPaidAmount; set => _discountFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _discountPercentage;
        /// <summary>
        /// AntiSteeringLoanOption DiscountPercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DiscountPercentage { get => _discountPercentage; set => _discountPercentage = value; }
        private DirtyValue<decimal?> _discountPoints;
        /// <summary>
        /// AntiSteeringLoanOption DiscountPoints
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DiscountPoints { get => _discountPoints; set => _discountPoints = value; }
        private DirtyValue<int?> _fixedRatePeriod;
        /// <summary>
        /// AntiSteeringLoanOption FixedRatePeriod
        /// </summary>
        public int? FixedRatePeriod { get => _fixedRatePeriod; set => _fixedRatePeriod = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _haveDemandFeature;
        /// <summary>
        /// AntiSteeringLoanOption HaveDemandFeature
        /// </summary>
        public StringEnumValue<YesOrNo> HaveDemandFeature { get => _haveDemandFeature; set => _haveDemandFeature = value; }
        private DirtyValue<bool?> _havePrepaymentPenalty;
        /// <summary>
        /// AntiSteeringLoanOption HavePrepaymentPenalty
        /// </summary>
        public bool? HavePrepaymentPenalty { get => _havePrepaymentPenalty; set => _havePrepaymentPenalty = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AntiSteeringLoanOption Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _inspectionFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption InspectionFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeeBorPaidAmount { get => _inspectionFeeBorPaidAmount; set => _inspectionFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _inspectionFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption InspectionFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeeSellerPaidAmount { get => _inspectionFeeSellerPaidAmount; set => _inspectionFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _interestRate;
        /// <summary>
        /// AntiSteeringLoanOption InterestRate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InterestRate { get => _interestRate; set => _interestRate = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isBalloonPaymentIn7Years;
        /// <summary>
        /// AntiSteeringLoanOption IsBalloonPaymentIn7Years
        /// </summary>
        public StringEnumValue<YesOrNo> IsBalloonPaymentIn7Years { get => _isBalloonPaymentIn7Years; set => _isBalloonPaymentIn7Years = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isInterestOnlyLoan;
        /// <summary>
        /// AntiSteeringLoanOption IsInterestOnlyLoan
        /// </summary>
        public StringEnumValue<YesOrNo> IsInterestOnlyLoan { get => _isInterestOnlyLoan; set => _isInterestOnlyLoan = value; }
        private DirtyValue<bool?> _isNegativeAmortization;
        /// <summary>
        /// AntiSteeringLoanOption IsNegativeAmortization
        /// </summary>
        public bool? IsNegativeAmortization { get => _isNegativeAmortization; set => _isNegativeAmortization = value; }
        private DirtyValue<int?> _loanTerm;
        /// <summary>
        /// AntiSteeringLoanOption LoanTerm
        /// </summary>
        public int? LoanTerm { get => _loanTerm; set => _loanTerm = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanType;
        /// <summary>
        /// Anti-Steering Disclosure - Loan Option 1 - Loan Type [DISCLOSURE.X689]
        /// </summary>
        [LoanFieldProperty(Description = "Anti-Steering Disclosure - Loan Option 1 - Loan Type")]
        public StringEnumValue<AmortizationType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<decimal?> _originationFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption OriginationFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationFeeBorPaidAmount { get => _originationFeeBorPaidAmount; set => _originationFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _originationFeePercentage;
        /// <summary>
        /// AntiSteeringLoanOption OriginationFeePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationFeePercentage { get => _originationFeePercentage; set => _originationFeePercentage = value; }
        private DirtyValue<decimal?> _originationFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption OriginationFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationFeeSellerPaidAmount { get => _originationFeeSellerPaidAmount; set => _originationFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _originationPointsFees;
        /// <summary>
        /// AntiSteeringLoanOption OriginationPointsFees
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationPointsFees { get => _originationPointsFees; set => _originationPointsFees = value; }
        private DirtyValue<decimal?> _originationPointsPercetange;
        /// <summary>
        /// AntiSteeringLoanOption OriginationPointsPercetange
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationPointsPercetange { get => _originationPointsPercetange; set => _originationPointsPercetange = value; }
        private DirtyValue<decimal?> _processingFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption ProcessingFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ProcessingFeeBorPaidAmount { get => _processingFeeBorPaidAmount; set => _processingFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _processingFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption ProcessingFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ProcessingFeeSellerPaidAmount { get => _processingFeeSellerPaidAmount; set => _processingFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _totalOriginationDiscountAmount;
        /// <summary>
        /// AntiSteeringLoanOption TotalOriginationDiscountAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalOriginationDiscountAmount { get => _totalOriginationDiscountAmount; set => _totalOriginationDiscountAmount = value; }
        private DirtyValue<decimal?> _underwritingFeeBorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UnderwritingFeeBorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnderwritingFeeBorPaidAmount { get => _underwritingFeeBorPaidAmount; set => _underwritingFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _underwritingFeeSellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UnderwritingFeeSellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnderwritingFeeSellerPaidAmount { get => _underwritingFeeSellerPaidAmount; set => _underwritingFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee1BorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee1BorPaidAmount { get => _userDefinedFee1BorPaidAmount; set => _userDefinedFee1BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee1Description;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1Description
        /// </summary>
        public string UserDefinedFee1Description { get => _userDefinedFee1Description; set => _userDefinedFee1Description = value; }
        private DirtyValue<decimal?> _userDefinedFee1SellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee1SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee1SellerPaidAmount { get => _userDefinedFee1SellerPaidAmount; set => _userDefinedFee1SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee2BorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee2BorPaidAmount { get => _userDefinedFee2BorPaidAmount; set => _userDefinedFee2BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee2Description;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2Description
        /// </summary>
        public string UserDefinedFee2Description { get => _userDefinedFee2Description; set => _userDefinedFee2Description = value; }
        private DirtyValue<decimal?> _userDefinedFee2SellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee2SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee2SellerPaidAmount { get => _userDefinedFee2SellerPaidAmount; set => _userDefinedFee2SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee3BorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee3BorPaidAmount { get => _userDefinedFee3BorPaidAmount; set => _userDefinedFee3BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee3Description;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3Description
        /// </summary>
        public string UserDefinedFee3Description { get => _userDefinedFee3Description; set => _userDefinedFee3Description = value; }
        private DirtyValue<decimal?> _userDefinedFee3SellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee3SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee3SellerPaidAmount { get => _userDefinedFee3SellerPaidAmount; set => _userDefinedFee3SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee4BorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee4BorPaidAmount { get => _userDefinedFee4BorPaidAmount; set => _userDefinedFee4BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee4Description;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4Description
        /// </summary>
        public string UserDefinedFee4Description { get => _userDefinedFee4Description; set => _userDefinedFee4Description = value; }
        private DirtyValue<decimal?> _userDefinedFee4SellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee4SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee4SellerPaidAmount { get => _userDefinedFee4SellerPaidAmount; set => _userDefinedFee4SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee5BorPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee5BorPaidAmount { get => _userDefinedFee5BorPaidAmount; set => _userDefinedFee5BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee5Description;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5Description
        /// </summary>
        public string UserDefinedFee5Description { get => _userDefinedFee5Description; set => _userDefinedFee5Description = value; }
        private DirtyValue<decimal?> _userDefinedFee5SellerPaidAmount;
        /// <summary>
        /// AntiSteeringLoanOption UserDefinedFee5SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedFee5SellerPaidAmount { get => _userDefinedFee5SellerPaidAmount; set => _userDefinedFee5SellerPaidAmount = value; }
    }
}