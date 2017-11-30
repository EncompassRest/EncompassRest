using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption : ExtensibleObject
    {
        private DirtyValue<int?> _antiSteeringLoanOptionIndex;
        public int? AntiSteeringLoanOptionIndex { get => _antiSteeringLoanOptionIndex; set => _antiSteeringLoanOptionIndex = value; }
        private DirtyValue<decimal?> _brokerCompensationFeeAmount;
        public decimal? BrokerCompensationFeeAmount { get => _brokerCompensationFeeAmount; set => _brokerCompensationFeeAmount = value; }
        private DirtyValue<decimal?> _brokerCompensationFeeBorPaidAmount;
        public decimal? BrokerCompensationFeeBorPaidAmount { get => _brokerCompensationFeeBorPaidAmount; set => _brokerCompensationFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _brokerCompensationFeePercentage;
        public decimal? BrokerCompensationFeePercentage { get => _brokerCompensationFeePercentage; set => _brokerCompensationFeePercentage = value; }
        private DirtyValue<decimal?> _brokerFeeAmount;
        public decimal? BrokerFeeAmount { get => _brokerFeeAmount; set => _brokerFeeAmount = value; }
        private DirtyValue<decimal?> _brokerFeeBorPaidAmount;
        public decimal? BrokerFeeBorPaidAmount { get => _brokerFeeBorPaidAmount; set => _brokerFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _brokerFeePercentage;
        public decimal? BrokerFeePercentage { get => _brokerFeePercentage; set => _brokerFeePercentage = value; }
        private DirtyValue<decimal?> _brokerFeeSellerPaidAmount;
        public decimal? BrokerFeeSellerPaidAmount { get => _brokerFeeSellerPaidAmount; set => _brokerFeeSellerPaidAmount = value; }
        private DirtyValue<string> _creditorName;
        public string CreditorName { get => _creditorName; set => _creditorName = value; }
        private DirtyValue<decimal?> _discountAdditionalAmount;
        public decimal? DiscountAdditionalAmount { get => _discountAdditionalAmount; set => _discountAdditionalAmount = value; }
        private DirtyValue<decimal?> _discountAmount;
        public decimal? DiscountAmount { get => _discountAmount; set => _discountAmount = value; }
        private DirtyValue<decimal?> _discountFeeBorPaidAmount;
        public decimal? DiscountFeeBorPaidAmount { get => _discountFeeBorPaidAmount; set => _discountFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _discountFeeSellerPaidAmount;
        public decimal? DiscountFeeSellerPaidAmount { get => _discountFeeSellerPaidAmount; set => _discountFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get => _discountPercentage; set => _discountPercentage = value; }
        private DirtyValue<decimal?> _discountPoints;
        public decimal? DiscountPoints { get => _discountPoints; set => _discountPoints = value; }
        private DirtyValue<int?> _fixedRatePeriod;
        public int? FixedRatePeriod { get => _fixedRatePeriod; set => _fixedRatePeriod = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _haveDemandFeature;
        public StringEnumValue<YesOrNo> HaveDemandFeature { get => _haveDemandFeature; set => _haveDemandFeature = value; }
        private DirtyValue<bool?> _havePrepaymentPenalty;
        public bool? HavePrepaymentPenalty { get => _havePrepaymentPenalty; set => _havePrepaymentPenalty = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _inspectionFeeBorPaidAmount;
        public decimal? InspectionFeeBorPaidAmount { get => _inspectionFeeBorPaidAmount; set => _inspectionFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _inspectionFeeSellerPaidAmount;
        public decimal? InspectionFeeSellerPaidAmount { get => _inspectionFeeSellerPaidAmount; set => _inspectionFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _interestRate;
        public decimal? InterestRate { get => _interestRate; set => _interestRate = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isBalloonPaymentIn7Years;
        public StringEnumValue<YesOrNo> IsBalloonPaymentIn7Years { get => _isBalloonPaymentIn7Years; set => _isBalloonPaymentIn7Years = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isInterestOnlyLoan;
        public StringEnumValue<YesOrNo> IsInterestOnlyLoan { get => _isInterestOnlyLoan; set => _isInterestOnlyLoan = value; }
        private DirtyValue<bool?> _isNegativeAmortization;
        public bool? IsNegativeAmortization { get => _isNegativeAmortization; set => _isNegativeAmortization = value; }
        private DirtyValue<int?> _loanTerm;
        public int? LoanTerm { get => _loanTerm; set => _loanTerm = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanType;
        public StringEnumValue<AmortizationType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<decimal?> _originationFeeBorPaidAmount;
        public decimal? OriginationFeeBorPaidAmount { get => _originationFeeBorPaidAmount; set => _originationFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _originationFeePercentage;
        public decimal? OriginationFeePercentage { get => _originationFeePercentage; set => _originationFeePercentage = value; }
        private DirtyValue<decimal?> _originationFeeSellerPaidAmount;
        public decimal? OriginationFeeSellerPaidAmount { get => _originationFeeSellerPaidAmount; set => _originationFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _originationPointsFees;
        public decimal? OriginationPointsFees { get => _originationPointsFees; set => _originationPointsFees = value; }
        private DirtyValue<decimal?> _originationPointsPercetange;
        public decimal? OriginationPointsPercetange { get => _originationPointsPercetange; set => _originationPointsPercetange = value; }
        private DirtyValue<decimal?> _processingFeeBorPaidAmount;
        public decimal? ProcessingFeeBorPaidAmount { get => _processingFeeBorPaidAmount; set => _processingFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _processingFeeSellerPaidAmount;
        public decimal? ProcessingFeeSellerPaidAmount { get => _processingFeeSellerPaidAmount; set => _processingFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _totalOriginationDiscountAmount;
        public decimal? TotalOriginationDiscountAmount { get => _totalOriginationDiscountAmount; set => _totalOriginationDiscountAmount = value; }
        private DirtyValue<decimal?> _underwritingFeeBorPaidAmount;
        public decimal? UnderwritingFeeBorPaidAmount { get => _underwritingFeeBorPaidAmount; set => _underwritingFeeBorPaidAmount = value; }
        private DirtyValue<decimal?> _underwritingFeeSellerPaidAmount;
        public decimal? UnderwritingFeeSellerPaidAmount { get => _underwritingFeeSellerPaidAmount; set => _underwritingFeeSellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee1BorPaidAmount;
        public decimal? UserDefinedFee1BorPaidAmount { get => _userDefinedFee1BorPaidAmount; set => _userDefinedFee1BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee1Description;
        public string UserDefinedFee1Description { get => _userDefinedFee1Description; set => _userDefinedFee1Description = value; }
        private DirtyValue<decimal?> _userDefinedFee1SellerPaidAmount;
        public decimal? UserDefinedFee1SellerPaidAmount { get => _userDefinedFee1SellerPaidAmount; set => _userDefinedFee1SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee2BorPaidAmount;
        public decimal? UserDefinedFee2BorPaidAmount { get => _userDefinedFee2BorPaidAmount; set => _userDefinedFee2BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee2Description;
        public string UserDefinedFee2Description { get => _userDefinedFee2Description; set => _userDefinedFee2Description = value; }
        private DirtyValue<decimal?> _userDefinedFee2SellerPaidAmount;
        public decimal? UserDefinedFee2SellerPaidAmount { get => _userDefinedFee2SellerPaidAmount; set => _userDefinedFee2SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee3BorPaidAmount;
        public decimal? UserDefinedFee3BorPaidAmount { get => _userDefinedFee3BorPaidAmount; set => _userDefinedFee3BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee3Description;
        public string UserDefinedFee3Description { get => _userDefinedFee3Description; set => _userDefinedFee3Description = value; }
        private DirtyValue<decimal?> _userDefinedFee3SellerPaidAmount;
        public decimal? UserDefinedFee3SellerPaidAmount { get => _userDefinedFee3SellerPaidAmount; set => _userDefinedFee3SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee4BorPaidAmount;
        public decimal? UserDefinedFee4BorPaidAmount { get => _userDefinedFee4BorPaidAmount; set => _userDefinedFee4BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee4Description;
        public string UserDefinedFee4Description { get => _userDefinedFee4Description; set => _userDefinedFee4Description = value; }
        private DirtyValue<decimal?> _userDefinedFee4SellerPaidAmount;
        public decimal? UserDefinedFee4SellerPaidAmount { get => _userDefinedFee4SellerPaidAmount; set => _userDefinedFee4SellerPaidAmount = value; }
        private DirtyValue<decimal?> _userDefinedFee5BorPaidAmount;
        public decimal? UserDefinedFee5BorPaidAmount { get => _userDefinedFee5BorPaidAmount; set => _userDefinedFee5BorPaidAmount = value; }
        private DirtyValue<string> _userDefinedFee5Description;
        public string UserDefinedFee5Description { get => _userDefinedFee5Description; set => _userDefinedFee5Description = value; }
        private DirtyValue<decimal?> _userDefinedFee5SellerPaidAmount;
        public decimal? UserDefinedFee5SellerPaidAmount { get => _userDefinedFee5SellerPaidAmount; set => _userDefinedFee5SellerPaidAmount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _antiSteeringLoanOptionIndex.Dirty
                    || _brokerCompensationFeeAmount.Dirty
                    || _brokerCompensationFeeBorPaidAmount.Dirty
                    || _brokerCompensationFeePercentage.Dirty
                    || _brokerFeeAmount.Dirty
                    || _brokerFeeBorPaidAmount.Dirty
                    || _brokerFeePercentage.Dirty
                    || _brokerFeeSellerPaidAmount.Dirty
                    || _creditorName.Dirty
                    || _discountAdditionalAmount.Dirty
                    || _discountAmount.Dirty
                    || _discountFeeBorPaidAmount.Dirty
                    || _discountFeeSellerPaidAmount.Dirty
                    || _discountPercentage.Dirty
                    || _discountPoints.Dirty
                    || _fixedRatePeriod.Dirty
                    || _haveDemandFeature.Dirty
                    || _havePrepaymentPenalty.Dirty
                    || _id.Dirty
                    || _inspectionFeeBorPaidAmount.Dirty
                    || _inspectionFeeSellerPaidAmount.Dirty
                    || _interestRate.Dirty
                    || _isBalloonPaymentIn7Years.Dirty
                    || _isInterestOnlyLoan.Dirty
                    || _isNegativeAmortization.Dirty
                    || _loanTerm.Dirty
                    || _loanType.Dirty
                    || _originationFeeBorPaidAmount.Dirty
                    || _originationFeePercentage.Dirty
                    || _originationFeeSellerPaidAmount.Dirty
                    || _originationPointsFees.Dirty
                    || _originationPointsPercetange.Dirty
                    || _processingFeeBorPaidAmount.Dirty
                    || _processingFeeSellerPaidAmount.Dirty
                    || _totalOriginationDiscountAmount.Dirty
                    || _underwritingFeeBorPaidAmount.Dirty
                    || _underwritingFeeSellerPaidAmount.Dirty
                    || _userDefinedFee1BorPaidAmount.Dirty
                    || _userDefinedFee1Description.Dirty
                    || _userDefinedFee1SellerPaidAmount.Dirty
                    || _userDefinedFee2BorPaidAmount.Dirty
                    || _userDefinedFee2Description.Dirty
                    || _userDefinedFee2SellerPaidAmount.Dirty
                    || _userDefinedFee3BorPaidAmount.Dirty
                    || _userDefinedFee3Description.Dirty
                    || _userDefinedFee3SellerPaidAmount.Dirty
                    || _userDefinedFee4BorPaidAmount.Dirty
                    || _userDefinedFee4Description.Dirty
                    || _userDefinedFee4SellerPaidAmount.Dirty
                    || _userDefinedFee5BorPaidAmount.Dirty
                    || _userDefinedFee5Description.Dirty
                    || _userDefinedFee5SellerPaidAmount.Dirty;
            }
            set
            {
                _antiSteeringLoanOptionIndex.Dirty = value;
                _brokerCompensationFeeAmount.Dirty = value;
                _brokerCompensationFeeBorPaidAmount.Dirty = value;
                _brokerCompensationFeePercentage.Dirty = value;
                _brokerFeeAmount.Dirty = value;
                _brokerFeeBorPaidAmount.Dirty = value;
                _brokerFeePercentage.Dirty = value;
                _brokerFeeSellerPaidAmount.Dirty = value;
                _creditorName.Dirty = value;
                _discountAdditionalAmount.Dirty = value;
                _discountAmount.Dirty = value;
                _discountFeeBorPaidAmount.Dirty = value;
                _discountFeeSellerPaidAmount.Dirty = value;
                _discountPercentage.Dirty = value;
                _discountPoints.Dirty = value;
                _fixedRatePeriod.Dirty = value;
                _haveDemandFeature.Dirty = value;
                _havePrepaymentPenalty.Dirty = value;
                _id.Dirty = value;
                _inspectionFeeBorPaidAmount.Dirty = value;
                _inspectionFeeSellerPaidAmount.Dirty = value;
                _interestRate.Dirty = value;
                _isBalloonPaymentIn7Years.Dirty = value;
                _isInterestOnlyLoan.Dirty = value;
                _isNegativeAmortization.Dirty = value;
                _loanTerm.Dirty = value;
                _loanType.Dirty = value;
                _originationFeeBorPaidAmount.Dirty = value;
                _originationFeePercentage.Dirty = value;
                _originationFeeSellerPaidAmount.Dirty = value;
                _originationPointsFees.Dirty = value;
                _originationPointsPercetange.Dirty = value;
                _processingFeeBorPaidAmount.Dirty = value;
                _processingFeeSellerPaidAmount.Dirty = value;
                _totalOriginationDiscountAmount.Dirty = value;
                _underwritingFeeBorPaidAmount.Dirty = value;
                _underwritingFeeSellerPaidAmount.Dirty = value;
                _userDefinedFee1BorPaidAmount.Dirty = value;
                _userDefinedFee1Description.Dirty = value;
                _userDefinedFee1SellerPaidAmount.Dirty = value;
                _userDefinedFee2BorPaidAmount.Dirty = value;
                _userDefinedFee2Description.Dirty = value;
                _userDefinedFee2SellerPaidAmount.Dirty = value;
                _userDefinedFee3BorPaidAmount.Dirty = value;
                _userDefinedFee3Description.Dirty = value;
                _userDefinedFee3SellerPaidAmount.Dirty = value;
                _userDefinedFee4BorPaidAmount.Dirty = value;
                _userDefinedFee4Description.Dirty = value;
                _userDefinedFee4SellerPaidAmount.Dirty = value;
                _userDefinedFee5BorPaidAmount.Dirty = value;
                _userDefinedFee5Description.Dirty = value;
                _userDefinedFee5SellerPaidAmount.Dirty = value;
            }
        }
    }
}