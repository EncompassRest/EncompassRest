using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption
    {
        private Value<int?> _antiSteeringLoanOptionIndex;
        public int? AntiSteeringLoanOptionIndex { get { return _antiSteeringLoanOptionIndex; } set { _antiSteeringLoanOptionIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAntiSteeringLoanOptionIndex() => !_antiSteeringLoanOptionIndex.Clean;
        private Value<decimal?> _brokerCompensationFeeAmount;
        public decimal? BrokerCompensationFeeAmount { get { return _brokerCompensationFeeAmount; } set { _brokerCompensationFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeeAmount() => !_brokerCompensationFeeAmount.Clean;
        private Value<decimal?> _brokerCompensationFeeBorPaidAmount;
        public decimal? BrokerCompensationFeeBorPaidAmount { get { return _brokerCompensationFeeBorPaidAmount; } set { _brokerCompensationFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeeBorPaidAmount() => !_brokerCompensationFeeBorPaidAmount.Clean;
        private Value<decimal?> _brokerCompensationFeePercentage;
        public decimal? BrokerCompensationFeePercentage { get { return _brokerCompensationFeePercentage; } set { _brokerCompensationFeePercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeePercentage() => !_brokerCompensationFeePercentage.Clean;
        private Value<decimal?> _brokerFeeAmount;
        public decimal? BrokerFeeAmount { get { return _brokerFeeAmount; } set { _brokerFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeAmount() => !_brokerFeeAmount.Clean;
        private Value<decimal?> _brokerFeeBorPaidAmount;
        public decimal? BrokerFeeBorPaidAmount { get { return _brokerFeeBorPaidAmount; } set { _brokerFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeBorPaidAmount() => !_brokerFeeBorPaidAmount.Clean;
        private Value<decimal?> _brokerFeePercentage;
        public decimal? BrokerFeePercentage { get { return _brokerFeePercentage; } set { _brokerFeePercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeePercentage() => !_brokerFeePercentage.Clean;
        private Value<decimal?> _brokerFeeSellerPaidAmount;
        public decimal? BrokerFeeSellerPaidAmount { get { return _brokerFeeSellerPaidAmount; } set { _brokerFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeSellerPaidAmount() => !_brokerFeeSellerPaidAmount.Clean;
        private Value<string> _creditorName;
        public string CreditorName { get { return _creditorName; } set { _creditorName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorName() => !_creditorName.Clean;
        private Value<decimal?> _discountAdditionalAmount;
        public decimal? DiscountAdditionalAmount { get { return _discountAdditionalAmount; } set { _discountAdditionalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountAdditionalAmount() => !_discountAdditionalAmount.Clean;
        private Value<decimal?> _discountAmount;
        public decimal? DiscountAmount { get { return _discountAmount; } set { _discountAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountAmount() => !_discountAmount.Clean;
        private Value<decimal?> _discountFeeBorPaidAmount;
        public decimal? DiscountFeeBorPaidAmount { get { return _discountFeeBorPaidAmount; } set { _discountFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountFeeBorPaidAmount() => !_discountFeeBorPaidAmount.Clean;
        private Value<decimal?> _discountFeeSellerPaidAmount;
        public decimal? DiscountFeeSellerPaidAmount { get { return _discountFeeSellerPaidAmount; } set { _discountFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountFeeSellerPaidAmount() => !_discountFeeSellerPaidAmount.Clean;
        private Value<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPercentage() => !_discountPercentage.Clean;
        private Value<decimal?> _discountPoints;
        public decimal? DiscountPoints { get { return _discountPoints; } set { _discountPoints = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoints() => !_discountPoints.Clean;
        private Value<int?> _fixedRatePeriod;
        public int? FixedRatePeriod { get { return _fixedRatePeriod; } set { _fixedRatePeriod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFixedRatePeriod() => !_fixedRatePeriod.Clean;
        private Value<string> _haveDemandFeature;
        public string HaveDemandFeature { get { return _haveDemandFeature; } set { _haveDemandFeature = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHaveDemandFeature() => !_haveDemandFeature.Clean;
        private Value<bool?> _havePrepaymentPenalty;
        public bool? HavePrepaymentPenalty { get { return _havePrepaymentPenalty; } set { _havePrepaymentPenalty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHavePrepaymentPenalty() => !_havePrepaymentPenalty.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _inspectionFeeBorPaidAmount;
        public decimal? InspectionFeeBorPaidAmount { get { return _inspectionFeeBorPaidAmount; } set { _inspectionFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeBorPaidAmount() => !_inspectionFeeBorPaidAmount.Clean;
        private Value<decimal?> _inspectionFeeSellerPaidAmount;
        public decimal? InspectionFeeSellerPaidAmount { get { return _inspectionFeeSellerPaidAmount; } set { _inspectionFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeSellerPaidAmount() => !_inspectionFeeSellerPaidAmount.Clean;
        private Value<decimal?> _interestRate;
        public decimal? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRate() => !_interestRate.Clean;
        private Value<string> _isBalloonPaymentIn7Years;
        public string IsBalloonPaymentIn7Years { get { return _isBalloonPaymentIn7Years; } set { _isBalloonPaymentIn7Years = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBalloonPaymentIn7Years() => !_isBalloonPaymentIn7Years.Clean;
        private Value<string> _isInterestOnlyLoan;
        public string IsInterestOnlyLoan { get { return _isInterestOnlyLoan; } set { _isInterestOnlyLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsInterestOnlyLoan() => !_isInterestOnlyLoan.Clean;
        private Value<bool?> _isNegativeAmortization;
        public bool? IsNegativeAmortization { get { return _isNegativeAmortization; } set { _isNegativeAmortization = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsNegativeAmortization() => !_isNegativeAmortization.Clean;
        private Value<int?> _loanTerm;
        public int? LoanTerm { get { return _loanTerm; } set { _loanTerm = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTerm() => !_loanTerm.Clean;
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !_loanType.Clean;
        private Value<decimal?> _originationFeeBorPaidAmount;
        public decimal? OriginationFeeBorPaidAmount { get { return _originationFeeBorPaidAmount; } set { _originationFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeBorPaidAmount() => !_originationFeeBorPaidAmount.Clean;
        private Value<decimal?> _originationFeePercentage;
        public decimal? OriginationFeePercentage { get { return _originationFeePercentage; } set { _originationFeePercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeePercentage() => !_originationFeePercentage.Clean;
        private Value<decimal?> _originationFeeSellerPaidAmount;
        public decimal? OriginationFeeSellerPaidAmount { get { return _originationFeeSellerPaidAmount; } set { _originationFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeSellerPaidAmount() => !_originationFeeSellerPaidAmount.Clean;
        private Value<decimal?> _originationPointsFees;
        public decimal? OriginationPointsFees { get { return _originationPointsFees; } set { _originationPointsFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsFees() => !_originationPointsFees.Clean;
        private Value<decimal?> _originationPointsPercetange;
        public decimal? OriginationPointsPercetange { get { return _originationPointsPercetange; } set { _originationPointsPercetange = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsPercetange() => !_originationPointsPercetange.Clean;
        private Value<decimal?> _processingFeeBorPaidAmount;
        public decimal? ProcessingFeeBorPaidAmount { get { return _processingFeeBorPaidAmount; } set { _processingFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFeeBorPaidAmount() => !_processingFeeBorPaidAmount.Clean;
        private Value<decimal?> _processingFeeSellerPaidAmount;
        public decimal? ProcessingFeeSellerPaidAmount { get { return _processingFeeSellerPaidAmount; } set { _processingFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFeeSellerPaidAmount() => !_processingFeeSellerPaidAmount.Clean;
        private Value<decimal?> _totalOriginationDiscountAmount;
        public decimal? TotalOriginationDiscountAmount { get { return _totalOriginationDiscountAmount; } set { _totalOriginationDiscountAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOriginationDiscountAmount() => !_totalOriginationDiscountAmount.Clean;
        private Value<decimal?> _underwritingFeeBorPaidAmount;
        public decimal? UnderwritingFeeBorPaidAmount { get { return _underwritingFeeBorPaidAmount; } set { _underwritingFeeBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFeeBorPaidAmount() => !_underwritingFeeBorPaidAmount.Clean;
        private Value<decimal?> _underwritingFeeSellerPaidAmount;
        public decimal? UnderwritingFeeSellerPaidAmount { get { return _underwritingFeeSellerPaidAmount; } set { _underwritingFeeSellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFeeSellerPaidAmount() => !_underwritingFeeSellerPaidAmount.Clean;
        private Value<decimal?> _userDefinedFee1BorPaidAmount;
        public decimal? UserDefinedFee1BorPaidAmount { get { return _userDefinedFee1BorPaidAmount; } set { _userDefinedFee1BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1BorPaidAmount() => !_userDefinedFee1BorPaidAmount.Clean;
        private Value<string> _userDefinedFee1Description;
        public string UserDefinedFee1Description { get { return _userDefinedFee1Description; } set { _userDefinedFee1Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1Description() => !_userDefinedFee1Description.Clean;
        private Value<decimal?> _userDefinedFee1SellerPaidAmount;
        public decimal? UserDefinedFee1SellerPaidAmount { get { return _userDefinedFee1SellerPaidAmount; } set { _userDefinedFee1SellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1SellerPaidAmount() => !_userDefinedFee1SellerPaidAmount.Clean;
        private Value<decimal?> _userDefinedFee2BorPaidAmount;
        public decimal? UserDefinedFee2BorPaidAmount { get { return _userDefinedFee2BorPaidAmount; } set { _userDefinedFee2BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2BorPaidAmount() => !_userDefinedFee2BorPaidAmount.Clean;
        private Value<string> _userDefinedFee2Description;
        public string UserDefinedFee2Description { get { return _userDefinedFee2Description; } set { _userDefinedFee2Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2Description() => !_userDefinedFee2Description.Clean;
        private Value<decimal?> _userDefinedFee2SellerPaidAmount;
        public decimal? UserDefinedFee2SellerPaidAmount { get { return _userDefinedFee2SellerPaidAmount; } set { _userDefinedFee2SellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2SellerPaidAmount() => !_userDefinedFee2SellerPaidAmount.Clean;
        private Value<decimal?> _userDefinedFee3BorPaidAmount;
        public decimal? UserDefinedFee3BorPaidAmount { get { return _userDefinedFee3BorPaidAmount; } set { _userDefinedFee3BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3BorPaidAmount() => !_userDefinedFee3BorPaidAmount.Clean;
        private Value<string> _userDefinedFee3Description;
        public string UserDefinedFee3Description { get { return _userDefinedFee3Description; } set { _userDefinedFee3Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3Description() => !_userDefinedFee3Description.Clean;
        private Value<decimal?> _userDefinedFee3SellerPaidAmount;
        public decimal? UserDefinedFee3SellerPaidAmount { get { return _userDefinedFee3SellerPaidAmount; } set { _userDefinedFee3SellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3SellerPaidAmount() => !_userDefinedFee3SellerPaidAmount.Clean;
        private Value<decimal?> _userDefinedFee4BorPaidAmount;
        public decimal? UserDefinedFee4BorPaidAmount { get { return _userDefinedFee4BorPaidAmount; } set { _userDefinedFee4BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4BorPaidAmount() => !_userDefinedFee4BorPaidAmount.Clean;
        private Value<string> _userDefinedFee4Description;
        public string UserDefinedFee4Description { get { return _userDefinedFee4Description; } set { _userDefinedFee4Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4Description() => !_userDefinedFee4Description.Clean;
        private Value<decimal?> _userDefinedFee4SellerPaidAmount;
        public decimal? UserDefinedFee4SellerPaidAmount { get { return _userDefinedFee4SellerPaidAmount; } set { _userDefinedFee4SellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4SellerPaidAmount() => !_userDefinedFee4SellerPaidAmount.Clean;
        private Value<decimal?> _userDefinedFee5BorPaidAmount;
        public decimal? UserDefinedFee5BorPaidAmount { get { return _userDefinedFee5BorPaidAmount; } set { _userDefinedFee5BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5BorPaidAmount() => !_userDefinedFee5BorPaidAmount.Clean;
        private Value<string> _userDefinedFee5Description;
        public string UserDefinedFee5Description { get { return _userDefinedFee5Description; } set { _userDefinedFee5Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5Description() => !_userDefinedFee5Description.Clean;
        private Value<decimal?> _userDefinedFee5SellerPaidAmount;
        public decimal? UserDefinedFee5SellerPaidAmount { get { return _userDefinedFee5SellerPaidAmount; } set { _userDefinedFee5SellerPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5SellerPaidAmount() => !_userDefinedFee5SellerPaidAmount.Clean;
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
                var v0 = _antiSteeringLoanOptionIndex; v0.Clean = value; _antiSteeringLoanOptionIndex = v0;
                var v1 = _brokerCompensationFeeAmount; v1.Clean = value; _brokerCompensationFeeAmount = v1;
                var v2 = _brokerCompensationFeeBorPaidAmount; v2.Clean = value; _brokerCompensationFeeBorPaidAmount = v2;
                var v3 = _brokerCompensationFeePercentage; v3.Clean = value; _brokerCompensationFeePercentage = v3;
                var v4 = _brokerFeeAmount; v4.Clean = value; _brokerFeeAmount = v4;
                var v5 = _brokerFeeBorPaidAmount; v5.Clean = value; _brokerFeeBorPaidAmount = v5;
                var v6 = _brokerFeePercentage; v6.Clean = value; _brokerFeePercentage = v6;
                var v7 = _brokerFeeSellerPaidAmount; v7.Clean = value; _brokerFeeSellerPaidAmount = v7;
                var v8 = _creditorName; v8.Clean = value; _creditorName = v8;
                var v9 = _discountAdditionalAmount; v9.Clean = value; _discountAdditionalAmount = v9;
                var v10 = _discountAmount; v10.Clean = value; _discountAmount = v10;
                var v11 = _discountFeeBorPaidAmount; v11.Clean = value; _discountFeeBorPaidAmount = v11;
                var v12 = _discountFeeSellerPaidAmount; v12.Clean = value; _discountFeeSellerPaidAmount = v12;
                var v13 = _discountPercentage; v13.Clean = value; _discountPercentage = v13;
                var v14 = _discountPoints; v14.Clean = value; _discountPoints = v14;
                var v15 = _fixedRatePeriod; v15.Clean = value; _fixedRatePeriod = v15;
                var v16 = _haveDemandFeature; v16.Clean = value; _haveDemandFeature = v16;
                var v17 = _havePrepaymentPenalty; v17.Clean = value; _havePrepaymentPenalty = v17;
                var v18 = _id; v18.Clean = value; _id = v18;
                var v19 = _inspectionFeeBorPaidAmount; v19.Clean = value; _inspectionFeeBorPaidAmount = v19;
                var v20 = _inspectionFeeSellerPaidAmount; v20.Clean = value; _inspectionFeeSellerPaidAmount = v20;
                var v21 = _interestRate; v21.Clean = value; _interestRate = v21;
                var v22 = _isBalloonPaymentIn7Years; v22.Clean = value; _isBalloonPaymentIn7Years = v22;
                var v23 = _isInterestOnlyLoan; v23.Clean = value; _isInterestOnlyLoan = v23;
                var v24 = _isNegativeAmortization; v24.Clean = value; _isNegativeAmortization = v24;
                var v25 = _loanTerm; v25.Clean = value; _loanTerm = v25;
                var v26 = _loanType; v26.Clean = value; _loanType = v26;
                var v27 = _originationFeeBorPaidAmount; v27.Clean = value; _originationFeeBorPaidAmount = v27;
                var v28 = _originationFeePercentage; v28.Clean = value; _originationFeePercentage = v28;
                var v29 = _originationFeeSellerPaidAmount; v29.Clean = value; _originationFeeSellerPaidAmount = v29;
                var v30 = _originationPointsFees; v30.Clean = value; _originationPointsFees = v30;
                var v31 = _originationPointsPercetange; v31.Clean = value; _originationPointsPercetange = v31;
                var v32 = _processingFeeBorPaidAmount; v32.Clean = value; _processingFeeBorPaidAmount = v32;
                var v33 = _processingFeeSellerPaidAmount; v33.Clean = value; _processingFeeSellerPaidAmount = v33;
                var v34 = _totalOriginationDiscountAmount; v34.Clean = value; _totalOriginationDiscountAmount = v34;
                var v35 = _underwritingFeeBorPaidAmount; v35.Clean = value; _underwritingFeeBorPaidAmount = v35;
                var v36 = _underwritingFeeSellerPaidAmount; v36.Clean = value; _underwritingFeeSellerPaidAmount = v36;
                var v37 = _userDefinedFee1BorPaidAmount; v37.Clean = value; _userDefinedFee1BorPaidAmount = v37;
                var v38 = _userDefinedFee1Description; v38.Clean = value; _userDefinedFee1Description = v38;
                var v39 = _userDefinedFee1SellerPaidAmount; v39.Clean = value; _userDefinedFee1SellerPaidAmount = v39;
                var v40 = _userDefinedFee2BorPaidAmount; v40.Clean = value; _userDefinedFee2BorPaidAmount = v40;
                var v41 = _userDefinedFee2Description; v41.Clean = value; _userDefinedFee2Description = v41;
                var v42 = _userDefinedFee2SellerPaidAmount; v42.Clean = value; _userDefinedFee2SellerPaidAmount = v42;
                var v43 = _userDefinedFee3BorPaidAmount; v43.Clean = value; _userDefinedFee3BorPaidAmount = v43;
                var v44 = _userDefinedFee3Description; v44.Clean = value; _userDefinedFee3Description = v44;
                var v45 = _userDefinedFee3SellerPaidAmount; v45.Clean = value; _userDefinedFee3SellerPaidAmount = v45;
                var v46 = _userDefinedFee4BorPaidAmount; v46.Clean = value; _userDefinedFee4BorPaidAmount = v46;
                var v47 = _userDefinedFee4Description; v47.Clean = value; _userDefinedFee4Description = v47;
                var v48 = _userDefinedFee4SellerPaidAmount; v48.Clean = value; _userDefinedFee4SellerPaidAmount = v48;
                var v49 = _userDefinedFee5BorPaidAmount; v49.Clean = value; _userDefinedFee5BorPaidAmount = v49;
                var v50 = _userDefinedFee5Description; v50.Clean = value; _userDefinedFee5Description = v50;
                var v51 = _userDefinedFee5SellerPaidAmount; v51.Clean = value; _userDefinedFee5SellerPaidAmount = v51;
                _settingClean = 0;
            }
        }
    }
}