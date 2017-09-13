using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption : IDirty
    {
        private Value<int?> _antiSteeringLoanOptionIndex;
        public int? AntiSteeringLoanOptionIndex { get { return _antiSteeringLoanOptionIndex; } set { _antiSteeringLoanOptionIndex = value; } }
        private Value<decimal?> _brokerCompensationFeeAmount;
        public decimal? BrokerCompensationFeeAmount { get { return _brokerCompensationFeeAmount; } set { _brokerCompensationFeeAmount = value; } }
        private Value<decimal?> _brokerCompensationFeeBorPaidAmount;
        public decimal? BrokerCompensationFeeBorPaidAmount { get { return _brokerCompensationFeeBorPaidAmount; } set { _brokerCompensationFeeBorPaidAmount = value; } }
        private Value<decimal?> _brokerCompensationFeePercentage;
        public decimal? BrokerCompensationFeePercentage { get { return _brokerCompensationFeePercentage; } set { _brokerCompensationFeePercentage = value; } }
        private Value<decimal?> _brokerFeeAmount;
        public decimal? BrokerFeeAmount { get { return _brokerFeeAmount; } set { _brokerFeeAmount = value; } }
        private Value<decimal?> _brokerFeeBorPaidAmount;
        public decimal? BrokerFeeBorPaidAmount { get { return _brokerFeeBorPaidAmount; } set { _brokerFeeBorPaidAmount = value; } }
        private Value<decimal?> _brokerFeePercentage;
        public decimal? BrokerFeePercentage { get { return _brokerFeePercentage; } set { _brokerFeePercentage = value; } }
        private Value<decimal?> _brokerFeeSellerPaidAmount;
        public decimal? BrokerFeeSellerPaidAmount { get { return _brokerFeeSellerPaidAmount; } set { _brokerFeeSellerPaidAmount = value; } }
        private Value<string> _creditorName;
        public string CreditorName { get { return _creditorName; } set { _creditorName = value; } }
        private Value<decimal?> _discountAdditionalAmount;
        public decimal? DiscountAdditionalAmount { get { return _discountAdditionalAmount; } set { _discountAdditionalAmount = value; } }
        private Value<decimal?> _discountAmount;
        public decimal? DiscountAmount { get { return _discountAmount; } set { _discountAmount = value; } }
        private Value<decimal?> _discountFeeBorPaidAmount;
        public decimal? DiscountFeeBorPaidAmount { get { return _discountFeeBorPaidAmount; } set { _discountFeeBorPaidAmount = value; } }
        private Value<decimal?> _discountFeeSellerPaidAmount;
        public decimal? DiscountFeeSellerPaidAmount { get { return _discountFeeSellerPaidAmount; } set { _discountFeeSellerPaidAmount = value; } }
        private Value<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        private Value<decimal?> _discountPoints;
        public decimal? DiscountPoints { get { return _discountPoints; } set { _discountPoints = value; } }
        private Value<int?> _fixedRatePeriod;
        public int? FixedRatePeriod { get { return _fixedRatePeriod; } set { _fixedRatePeriod = value; } }
        private Value<string> _haveDemandFeature;
        public string HaveDemandFeature { get { return _haveDemandFeature; } set { _haveDemandFeature = value; } }
        private Value<bool?> _havePrepaymentPenalty;
        public bool? HavePrepaymentPenalty { get { return _havePrepaymentPenalty; } set { _havePrepaymentPenalty = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _inspectionFeeBorPaidAmount;
        public decimal? InspectionFeeBorPaidAmount { get { return _inspectionFeeBorPaidAmount; } set { _inspectionFeeBorPaidAmount = value; } }
        private Value<decimal?> _inspectionFeeSellerPaidAmount;
        public decimal? InspectionFeeSellerPaidAmount { get { return _inspectionFeeSellerPaidAmount; } set { _inspectionFeeSellerPaidAmount = value; } }
        private Value<decimal?> _interestRate;
        public decimal? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private Value<string> _isBalloonPaymentIn7Years;
        public string IsBalloonPaymentIn7Years { get { return _isBalloonPaymentIn7Years; } set { _isBalloonPaymentIn7Years = value; } }
        private Value<string> _isInterestOnlyLoan;
        public string IsInterestOnlyLoan { get { return _isInterestOnlyLoan; } set { _isInterestOnlyLoan = value; } }
        private Value<bool?> _isNegativeAmortization;
        public bool? IsNegativeAmortization { get { return _isNegativeAmortization; } set { _isNegativeAmortization = value; } }
        private Value<int?> _loanTerm;
        public int? LoanTerm { get { return _loanTerm; } set { _loanTerm = value; } }
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        private Value<decimal?> _originationFeeBorPaidAmount;
        public decimal? OriginationFeeBorPaidAmount { get { return _originationFeeBorPaidAmount; } set { _originationFeeBorPaidAmount = value; } }
        private Value<decimal?> _originationFeePercentage;
        public decimal? OriginationFeePercentage { get { return _originationFeePercentage; } set { _originationFeePercentage = value; } }
        private Value<decimal?> _originationFeeSellerPaidAmount;
        public decimal? OriginationFeeSellerPaidAmount { get { return _originationFeeSellerPaidAmount; } set { _originationFeeSellerPaidAmount = value; } }
        private Value<decimal?> _originationPointsFees;
        public decimal? OriginationPointsFees { get { return _originationPointsFees; } set { _originationPointsFees = value; } }
        private Value<decimal?> _originationPointsPercetange;
        public decimal? OriginationPointsPercetange { get { return _originationPointsPercetange; } set { _originationPointsPercetange = value; } }
        private Value<decimal?> _processingFeeBorPaidAmount;
        public decimal? ProcessingFeeBorPaidAmount { get { return _processingFeeBorPaidAmount; } set { _processingFeeBorPaidAmount = value; } }
        private Value<decimal?> _processingFeeSellerPaidAmount;
        public decimal? ProcessingFeeSellerPaidAmount { get { return _processingFeeSellerPaidAmount; } set { _processingFeeSellerPaidAmount = value; } }
        private Value<decimal?> _totalOriginationDiscountAmount;
        public decimal? TotalOriginationDiscountAmount { get { return _totalOriginationDiscountAmount; } set { _totalOriginationDiscountAmount = value; } }
        private Value<decimal?> _underwritingFeeBorPaidAmount;
        public decimal? UnderwritingFeeBorPaidAmount { get { return _underwritingFeeBorPaidAmount; } set { _underwritingFeeBorPaidAmount = value; } }
        private Value<decimal?> _underwritingFeeSellerPaidAmount;
        public decimal? UnderwritingFeeSellerPaidAmount { get { return _underwritingFeeSellerPaidAmount; } set { _underwritingFeeSellerPaidAmount = value; } }
        private Value<decimal?> _userDefinedFee1BorPaidAmount;
        public decimal? UserDefinedFee1BorPaidAmount { get { return _userDefinedFee1BorPaidAmount; } set { _userDefinedFee1BorPaidAmount = value; } }
        private Value<string> _userDefinedFee1Description;
        public string UserDefinedFee1Description { get { return _userDefinedFee1Description; } set { _userDefinedFee1Description = value; } }
        private Value<decimal?> _userDefinedFee1SellerPaidAmount;
        public decimal? UserDefinedFee1SellerPaidAmount { get { return _userDefinedFee1SellerPaidAmount; } set { _userDefinedFee1SellerPaidAmount = value; } }
        private Value<decimal?> _userDefinedFee2BorPaidAmount;
        public decimal? UserDefinedFee2BorPaidAmount { get { return _userDefinedFee2BorPaidAmount; } set { _userDefinedFee2BorPaidAmount = value; } }
        private Value<string> _userDefinedFee2Description;
        public string UserDefinedFee2Description { get { return _userDefinedFee2Description; } set { _userDefinedFee2Description = value; } }
        private Value<decimal?> _userDefinedFee2SellerPaidAmount;
        public decimal? UserDefinedFee2SellerPaidAmount { get { return _userDefinedFee2SellerPaidAmount; } set { _userDefinedFee2SellerPaidAmount = value; } }
        private Value<decimal?> _userDefinedFee3BorPaidAmount;
        public decimal? UserDefinedFee3BorPaidAmount { get { return _userDefinedFee3BorPaidAmount; } set { _userDefinedFee3BorPaidAmount = value; } }
        private Value<string> _userDefinedFee3Description;
        public string UserDefinedFee3Description { get { return _userDefinedFee3Description; } set { _userDefinedFee3Description = value; } }
        private Value<decimal?> _userDefinedFee3SellerPaidAmount;
        public decimal? UserDefinedFee3SellerPaidAmount { get { return _userDefinedFee3SellerPaidAmount; } set { _userDefinedFee3SellerPaidAmount = value; } }
        private Value<decimal?> _userDefinedFee4BorPaidAmount;
        public decimal? UserDefinedFee4BorPaidAmount { get { return _userDefinedFee4BorPaidAmount; } set { _userDefinedFee4BorPaidAmount = value; } }
        private Value<string> _userDefinedFee4Description;
        public string UserDefinedFee4Description { get { return _userDefinedFee4Description; } set { _userDefinedFee4Description = value; } }
        private Value<decimal?> _userDefinedFee4SellerPaidAmount;
        public decimal? UserDefinedFee4SellerPaidAmount { get { return _userDefinedFee4SellerPaidAmount; } set { _userDefinedFee4SellerPaidAmount = value; } }
        private Value<decimal?> _userDefinedFee5BorPaidAmount;
        public decimal? UserDefinedFee5BorPaidAmount { get { return _userDefinedFee5BorPaidAmount; } set { _userDefinedFee5BorPaidAmount = value; } }
        private Value<string> _userDefinedFee5Description;
        public string UserDefinedFee5Description { get { return _userDefinedFee5Description; } set { _userDefinedFee5Description = value; } }
        private Value<decimal?> _userDefinedFee5SellerPaidAmount;
        public decimal? UserDefinedFee5SellerPaidAmount { get { return _userDefinedFee5SellerPaidAmount; } set { _userDefinedFee5SellerPaidAmount = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _antiSteeringLoanOptionIndex.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}