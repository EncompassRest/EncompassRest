using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _antiSteeringLoanOptionIndex.Clean
                    && _brokerCompensationFeeAmount.Clean
                    && _brokerCompensationFeeBorPaidAmount.Clean
                    && _brokerCompensationFeePercentage.Clean
                    && _brokerFeeAmount.Clean
                    && _brokerFeeBorPaidAmount.Clean
                    && _brokerFeePercentage.Clean
                    && _brokerFeeSellerPaidAmount.Clean
                    && _creditorName.Clean
                    && _discountAdditionalAmount.Clean
                    && _discountAmount.Clean
                    && _discountFeeBorPaidAmount.Clean
                    && _discountFeeSellerPaidAmount.Clean
                    && _discountPercentage.Clean
                    && _discountPoints.Clean
                    && _fixedRatePeriod.Clean
                    && _haveDemandFeature.Clean
                    && _havePrepaymentPenalty.Clean
                    && _id.Clean
                    && _inspectionFeeBorPaidAmount.Clean
                    && _inspectionFeeSellerPaidAmount.Clean
                    && _interestRate.Clean
                    && _isBalloonPaymentIn7Years.Clean
                    && _isInterestOnlyLoan.Clean
                    && _isNegativeAmortization.Clean
                    && _loanTerm.Clean
                    && _loanType.Clean
                    && _originationFeeBorPaidAmount.Clean
                    && _originationFeePercentage.Clean
                    && _originationFeeSellerPaidAmount.Clean
                    && _originationPointsFees.Clean
                    && _originationPointsPercetange.Clean
                    && _processingFeeBorPaidAmount.Clean
                    && _processingFeeSellerPaidAmount.Clean
                    && _totalOriginationDiscountAmount.Clean
                    && _underwritingFeeBorPaidAmount.Clean
                    && _underwritingFeeSellerPaidAmount.Clean
                    && _userDefinedFee1BorPaidAmount.Clean
                    && _userDefinedFee1Description.Clean
                    && _userDefinedFee1SellerPaidAmount.Clean
                    && _userDefinedFee2BorPaidAmount.Clean
                    && _userDefinedFee2Description.Clean
                    && _userDefinedFee2SellerPaidAmount.Clean
                    && _userDefinedFee3BorPaidAmount.Clean
                    && _userDefinedFee3Description.Clean
                    && _userDefinedFee3SellerPaidAmount.Clean
                    && _userDefinedFee4BorPaidAmount.Clean
                    && _userDefinedFee4Description.Clean
                    && _userDefinedFee4SellerPaidAmount.Clean
                    && _userDefinedFee5BorPaidAmount.Clean
                    && _userDefinedFee5Description.Clean
                    && _userDefinedFee5SellerPaidAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var antiSteeringLoanOptionIndex = _antiSteeringLoanOptionIndex; antiSteeringLoanOptionIndex.Clean = value; _antiSteeringLoanOptionIndex = antiSteeringLoanOptionIndex;
                var brokerCompensationFeeAmount = _brokerCompensationFeeAmount; brokerCompensationFeeAmount.Clean = value; _brokerCompensationFeeAmount = brokerCompensationFeeAmount;
                var brokerCompensationFeeBorPaidAmount = _brokerCompensationFeeBorPaidAmount; brokerCompensationFeeBorPaidAmount.Clean = value; _brokerCompensationFeeBorPaidAmount = brokerCompensationFeeBorPaidAmount;
                var brokerCompensationFeePercentage = _brokerCompensationFeePercentage; brokerCompensationFeePercentage.Clean = value; _brokerCompensationFeePercentage = brokerCompensationFeePercentage;
                var brokerFeeAmount = _brokerFeeAmount; brokerFeeAmount.Clean = value; _brokerFeeAmount = brokerFeeAmount;
                var brokerFeeBorPaidAmount = _brokerFeeBorPaidAmount; brokerFeeBorPaidAmount.Clean = value; _brokerFeeBorPaidAmount = brokerFeeBorPaidAmount;
                var brokerFeePercentage = _brokerFeePercentage; brokerFeePercentage.Clean = value; _brokerFeePercentage = brokerFeePercentage;
                var brokerFeeSellerPaidAmount = _brokerFeeSellerPaidAmount; brokerFeeSellerPaidAmount.Clean = value; _brokerFeeSellerPaidAmount = brokerFeeSellerPaidAmount;
                var creditorName = _creditorName; creditorName.Clean = value; _creditorName = creditorName;
                var discountAdditionalAmount = _discountAdditionalAmount; discountAdditionalAmount.Clean = value; _discountAdditionalAmount = discountAdditionalAmount;
                var discountAmount = _discountAmount; discountAmount.Clean = value; _discountAmount = discountAmount;
                var discountFeeBorPaidAmount = _discountFeeBorPaidAmount; discountFeeBorPaidAmount.Clean = value; _discountFeeBorPaidAmount = discountFeeBorPaidAmount;
                var discountFeeSellerPaidAmount = _discountFeeSellerPaidAmount; discountFeeSellerPaidAmount.Clean = value; _discountFeeSellerPaidAmount = discountFeeSellerPaidAmount;
                var discountPercentage = _discountPercentage; discountPercentage.Clean = value; _discountPercentage = discountPercentage;
                var discountPoints = _discountPoints; discountPoints.Clean = value; _discountPoints = discountPoints;
                var fixedRatePeriod = _fixedRatePeriod; fixedRatePeriod.Clean = value; _fixedRatePeriod = fixedRatePeriod;
                var haveDemandFeature = _haveDemandFeature; haveDemandFeature.Clean = value; _haveDemandFeature = haveDemandFeature;
                var havePrepaymentPenalty = _havePrepaymentPenalty; havePrepaymentPenalty.Clean = value; _havePrepaymentPenalty = havePrepaymentPenalty;
                var id = _id; id.Clean = value; _id = id;
                var inspectionFeeBorPaidAmount = _inspectionFeeBorPaidAmount; inspectionFeeBorPaidAmount.Clean = value; _inspectionFeeBorPaidAmount = inspectionFeeBorPaidAmount;
                var inspectionFeeSellerPaidAmount = _inspectionFeeSellerPaidAmount; inspectionFeeSellerPaidAmount.Clean = value; _inspectionFeeSellerPaidAmount = inspectionFeeSellerPaidAmount;
                var interestRate = _interestRate; interestRate.Clean = value; _interestRate = interestRate;
                var isBalloonPaymentIn7Years = _isBalloonPaymentIn7Years; isBalloonPaymentIn7Years.Clean = value; _isBalloonPaymentIn7Years = isBalloonPaymentIn7Years;
                var isInterestOnlyLoan = _isInterestOnlyLoan; isInterestOnlyLoan.Clean = value; _isInterestOnlyLoan = isInterestOnlyLoan;
                var isNegativeAmortization = _isNegativeAmortization; isNegativeAmortization.Clean = value; _isNegativeAmortization = isNegativeAmortization;
                var loanTerm = _loanTerm; loanTerm.Clean = value; _loanTerm = loanTerm;
                var loanType = _loanType; loanType.Clean = value; _loanType = loanType;
                var originationFeeBorPaidAmount = _originationFeeBorPaidAmount; originationFeeBorPaidAmount.Clean = value; _originationFeeBorPaidAmount = originationFeeBorPaidAmount;
                var originationFeePercentage = _originationFeePercentage; originationFeePercentage.Clean = value; _originationFeePercentage = originationFeePercentage;
                var originationFeeSellerPaidAmount = _originationFeeSellerPaidAmount; originationFeeSellerPaidAmount.Clean = value; _originationFeeSellerPaidAmount = originationFeeSellerPaidAmount;
                var originationPointsFees = _originationPointsFees; originationPointsFees.Clean = value; _originationPointsFees = originationPointsFees;
                var originationPointsPercetange = _originationPointsPercetange; originationPointsPercetange.Clean = value; _originationPointsPercetange = originationPointsPercetange;
                var processingFeeBorPaidAmount = _processingFeeBorPaidAmount; processingFeeBorPaidAmount.Clean = value; _processingFeeBorPaidAmount = processingFeeBorPaidAmount;
                var processingFeeSellerPaidAmount = _processingFeeSellerPaidAmount; processingFeeSellerPaidAmount.Clean = value; _processingFeeSellerPaidAmount = processingFeeSellerPaidAmount;
                var totalOriginationDiscountAmount = _totalOriginationDiscountAmount; totalOriginationDiscountAmount.Clean = value; _totalOriginationDiscountAmount = totalOriginationDiscountAmount;
                var underwritingFeeBorPaidAmount = _underwritingFeeBorPaidAmount; underwritingFeeBorPaidAmount.Clean = value; _underwritingFeeBorPaidAmount = underwritingFeeBorPaidAmount;
                var underwritingFeeSellerPaidAmount = _underwritingFeeSellerPaidAmount; underwritingFeeSellerPaidAmount.Clean = value; _underwritingFeeSellerPaidAmount = underwritingFeeSellerPaidAmount;
                var userDefinedFee1BorPaidAmount = _userDefinedFee1BorPaidAmount; userDefinedFee1BorPaidAmount.Clean = value; _userDefinedFee1BorPaidAmount = userDefinedFee1BorPaidAmount;
                var userDefinedFee1Description = _userDefinedFee1Description; userDefinedFee1Description.Clean = value; _userDefinedFee1Description = userDefinedFee1Description;
                var userDefinedFee1SellerPaidAmount = _userDefinedFee1SellerPaidAmount; userDefinedFee1SellerPaidAmount.Clean = value; _userDefinedFee1SellerPaidAmount = userDefinedFee1SellerPaidAmount;
                var userDefinedFee2BorPaidAmount = _userDefinedFee2BorPaidAmount; userDefinedFee2BorPaidAmount.Clean = value; _userDefinedFee2BorPaidAmount = userDefinedFee2BorPaidAmount;
                var userDefinedFee2Description = _userDefinedFee2Description; userDefinedFee2Description.Clean = value; _userDefinedFee2Description = userDefinedFee2Description;
                var userDefinedFee2SellerPaidAmount = _userDefinedFee2SellerPaidAmount; userDefinedFee2SellerPaidAmount.Clean = value; _userDefinedFee2SellerPaidAmount = userDefinedFee2SellerPaidAmount;
                var userDefinedFee3BorPaidAmount = _userDefinedFee3BorPaidAmount; userDefinedFee3BorPaidAmount.Clean = value; _userDefinedFee3BorPaidAmount = userDefinedFee3BorPaidAmount;
                var userDefinedFee3Description = _userDefinedFee3Description; userDefinedFee3Description.Clean = value; _userDefinedFee3Description = userDefinedFee3Description;
                var userDefinedFee3SellerPaidAmount = _userDefinedFee3SellerPaidAmount; userDefinedFee3SellerPaidAmount.Clean = value; _userDefinedFee3SellerPaidAmount = userDefinedFee3SellerPaidAmount;
                var userDefinedFee4BorPaidAmount = _userDefinedFee4BorPaidAmount; userDefinedFee4BorPaidAmount.Clean = value; _userDefinedFee4BorPaidAmount = userDefinedFee4BorPaidAmount;
                var userDefinedFee4Description = _userDefinedFee4Description; userDefinedFee4Description.Clean = value; _userDefinedFee4Description = userDefinedFee4Description;
                var userDefinedFee4SellerPaidAmount = _userDefinedFee4SellerPaidAmount; userDefinedFee4SellerPaidAmount.Clean = value; _userDefinedFee4SellerPaidAmount = userDefinedFee4SellerPaidAmount;
                var userDefinedFee5BorPaidAmount = _userDefinedFee5BorPaidAmount; userDefinedFee5BorPaidAmount.Clean = value; _userDefinedFee5BorPaidAmount = userDefinedFee5BorPaidAmount;
                var userDefinedFee5Description = _userDefinedFee5Description; userDefinedFee5Description.Clean = value; _userDefinedFee5Description = userDefinedFee5Description;
                var userDefinedFee5SellerPaidAmount = _userDefinedFee5SellerPaidAmount; userDefinedFee5SellerPaidAmount.Clean = value; _userDefinedFee5SellerPaidAmount = userDefinedFee5SellerPaidAmount;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public AntiSteeringLoanOption()
        {
            Clean = true;
        }
    }
}