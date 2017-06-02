using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Fee : IClean
    {
        private Value<decimal?> _additionalAmount;
        public decimal? AdditionalAmount { get { return _additionalAmount; } set { _additionalAmount = value; } }
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<bool?> _aprIndicator;
        public bool? AprIndicator { get { return _aprIndicator; } set { _aprIndicator = value; } }
        private Value<decimal?> _borPaidAmount;
        public decimal? BorPaidAmount { get { return _borPaidAmount; } set { _borPaidAmount = value; } }
        private Value<decimal?> _borrowerAmountPaid2015;
        public decimal? BorrowerAmountPaid2015 { get { return _borrowerAmountPaid2015; } set { _borrowerAmountPaid2015 = value; } }
        private Value<bool?> _borrowerCanShopForIndicator2015;
        public bool? BorrowerCanShopForIndicator2015 { get { return _borrowerCanShopForIndicator2015; } set { _borrowerCanShopForIndicator2015 = value; } }
        private Value<bool?> _borrowerDidShopForIndicator2015;
        public bool? BorrowerDidShopForIndicator2015 { get { return _borrowerDidShopForIndicator2015; } set { _borrowerDidShopForIndicator2015 = value; } }
        private Value<decimal?> _borrowerFinanced2015;
        public decimal? BorrowerFinanced2015 { get { return _borrowerFinanced2015; } set { _borrowerFinanced2015 = value; } }
        private Value<decimal?> _borrowerPAC2015;
        public decimal? BorrowerPAC2015 { get { return _borrowerPAC2015; } set { _borrowerPAC2015 = value; } }
        private Value<decimal?> _borrowerPOC2015;
        public decimal? BorrowerPOC2015 { get { return _borrowerPOC2015; } set { _borrowerPOC2015 = value; } }
        private Value<decimal?> _borrowerPTC2015;
        public decimal? BorrowerPTC2015 { get { return _borrowerPTC2015; } set { _borrowerPTC2015 = value; } }
        private Value<bool?> _borrowerSelectIndicator;
        public bool? BorrowerSelectIndicator { get { return _borrowerSelectIndicator; } set { _borrowerSelectIndicator = value; } }
        private Value<decimal?> _brokerAmountPaid2015;
        public decimal? BrokerAmountPaid2015 { get { return _brokerAmountPaid2015; } set { _brokerAmountPaid2015 = value; } }
        private Value<decimal?> _brokerPAC2015;
        public decimal? BrokerPAC2015 { get { return _brokerPAC2015; } set { _brokerPAC2015 = value; } }
        private Value<decimal?> _brokerPOC2015;
        public decimal? BrokerPOC2015 { get { return _brokerPOC2015; } set { _brokerPOC2015 = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<bool?> _escrowedIndicator2015;
        public bool? EscrowedIndicator2015 { get { return _escrowedIndicator2015; } set { _escrowedIndicator2015 = value; } }
        private Value<bool?> _financedIndicator;
        public bool? FinancedIndicator { get { return _financedIndicator; } set { _financedIndicator = value; } }
        private Value<int?> _gfe2010FeeIndex;
        public int? Gfe2010FeeIndex { get { return _gfe2010FeeIndex; } set { _gfe2010FeeIndex = value; } }
        private Value<string> _gfe2010FeeParentType;
        public string Gfe2010FeeParentType { get { return _gfe2010FeeParentType; } set { _gfe2010FeeParentType = value; } }
        private Value<string> _gfe2010FeeType;
        public string Gfe2010FeeType { get { return _gfe2010FeeType; } set { _gfe2010FeeType = value; } }
        private Value<decimal?> _gfeAmount;
        public decimal? GfeAmount { get { return _gfeAmount; } set { _gfeAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _insuranceIndicator2015;
        public bool? InsuranceIndicator2015 { get { return _insuranceIndicator2015; } set { _insuranceIndicator2015 = value; } }
        private Value<decimal?> _lastDisclosedClosingDisclosure2015;
        public decimal? LastDisclosedClosingDisclosure2015 { get { return _lastDisclosedClosingDisclosure2015; } set { _lastDisclosedClosingDisclosure2015 = value; } }
        private Value<int?> _lastDisclosedLoanEstimate2015;
        public int? LastDisclosedLoanEstimate2015 { get { return _lastDisclosedLoanEstimate2015; } set { _lastDisclosedLoanEstimate2015 = value; } }
        private Value<decimal?> _lenderAmountPaid2015;
        public decimal? LenderAmountPaid2015 { get { return _lenderAmountPaid2015; } set { _lenderAmountPaid2015 = value; } }
        private Value<decimal?> _lenderPAC2015;
        public decimal? LenderPAC2015 { get { return _lenderPAC2015; } set { _lenderPAC2015 = value; } }
        private Value<decimal?> _lenderPOC2015;
        public decimal? LenderPOC2015 { get { return _lenderPOC2015; } set { _lenderPOC2015 = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<int?> _numberOfMonths;
        public int? NumberOfMonths { get { return _numberOfMonths; } set { _numberOfMonths = value; } }
        private Value<bool?> _optionalIndicator2015;
        public bool? OptionalIndicator2015 { get { return _optionalIndicator2015; } set { _optionalIndicator2015 = value; } }
        private Value<decimal?> _otherAmountPaid2015;
        public decimal? OtherAmountPaid2015 { get { return _otherAmountPaid2015; } set { _otherAmountPaid2015 = value; } }
        private Value<decimal?> _otherPAC2015;
        public decimal? OtherPAC2015 { get { return _otherPAC2015; } set { _otherPAC2015 = value; } }
        private Value<decimal?> _otherPOC2015;
        public decimal? OtherPOC2015 { get { return _otherPOC2015; } set { _otherPOC2015 = value; } }
        private Value<string> _paidByType;
        public string PaidByType { get { return _paidByType; } set { _paidByType = value; } }
        private Value<string> _paidToName;
        public string PaidToName { get { return _paidToName; } set { _paidToName = value; } }
        private Value<bool?> _pocPtcIndicator;
        public bool? PocPtcIndicator { get { return _pocPtcIndicator; } set { _pocPtcIndicator = value; } }
        private Value<bool?> _propertyIndicator2015;
        public bool? PropertyIndicator2015 { get { return _propertyIndicator2015; } set { _propertyIndicator2015 = value; } }
        private Value<string> _ptbType;
        public string PtbType { get { return _ptbType; } set { _ptbType = value; } }
        private Value<decimal?> _rate;
        public decimal? Rate { get { return _rate; } set { _rate = value; } }
        private Value<decimal?> _retainedAmount2015;
        public decimal? RetainedAmount2015 { get { return _retainedAmount2015; } set { _retainedAmount2015 = value; } }
        private Value<decimal?> _sec32PointsAndFees2015;
        public decimal? Sec32PointsAndFees2015 { get { return _sec32PointsAndFees2015; } set { _sec32PointsAndFees2015 = value; } }
        private Value<decimal?> _sellerAmountPaid2015;
        public decimal? SellerAmountPaid2015 { get { return _sellerAmountPaid2015; } set { _sellerAmountPaid2015 = value; } }
        private Value<bool?> _sellerCreditIndicator2015;
        public bool? SellerCreditIndicator2015 { get { return _sellerCreditIndicator2015; } set { _sellerCreditIndicator2015 = value; } }
        private Value<decimal?> _sellerObligatedAmount2015;
        public decimal? SellerObligatedAmount2015 { get { return _sellerObligatedAmount2015; } set { _sellerObligatedAmount2015 = value; } }
        private Value<bool?> _sellerObligatedIndicator2015;
        public bool? SellerObligatedIndicator2015 { get { return _sellerObligatedIndicator2015; } set { _sellerObligatedIndicator2015 = value; } }
        private Value<decimal?> _sellerPAC2015;
        public decimal? SellerPAC2015 { get { return _sellerPAC2015; } set { _sellerPAC2015 = value; } }
        private Value<decimal?> _sellerPOC2015;
        public decimal? SellerPOC2015 { get { return _sellerPOC2015; } set { _sellerPOC2015 = value; } }
        private Value<decimal?> _selPaidAmount;
        public decimal? SelPaidAmount { get { return _selPaidAmount; } set { _selPaidAmount = value; } }
        private Value<bool?> _simultaneousIssuanceIndicator2015;
        public bool? SimultaneousIssuanceIndicator2015 { get { return _simultaneousIssuanceIndicator2015; } set { _simultaneousIssuanceIndicator2015 = value; } }
        private Value<bool?> _taxesIndicator2015;
        public bool? TaxesIndicator2015 { get { return _taxesIndicator2015; } set { _taxesIndicator2015 = value; } }
        private Value<bool?> _titleServiceSelectIndicator;
        public bool? TitleServiceSelectIndicator { get { return _titleServiceSelectIndicator; } set { _titleServiceSelectIndicator = value; } }
        private Value<decimal?> _totalFeeAmount2015;
        public decimal? TotalFeeAmount2015 { get { return _totalFeeAmount2015; } set { _totalFeeAmount2015 = value; } }
        private Value<decimal?> _totalFeePercentage2015;
        public decimal? TotalFeePercentage2015 { get { return _totalFeePercentage2015; } set { _totalFeePercentage2015 = value; } }
        private Value<decimal?> _totalPaidByBLO2015;
        public decimal? TotalPaidByBLO2015 { get { return _totalPaidByBLO2015; } set { _totalPaidByBLO2015 = value; } }
        private Value<decimal?> _undiscountedInsurance2015;
        public decimal? UndiscountedInsurance2015 { get { return _undiscountedInsurance2015; } set { _undiscountedInsurance2015 = value; } }
        private Value<decimal?> _wholePoc;
        public decimal? WholePoc { get { return _wholePoc; } set { _wholePoc = value; } }
        private Value<string> _wholePocPaidByType;
        public string WholePocPaidByType { get { return _wholePocPaidByType; } set { _wholePocPaidByType = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalAmount.Clean
                    && _amount.Clean
                    && _aprIndicator.Clean
                    && _borPaidAmount.Clean
                    && _borrowerAmountPaid2015.Clean
                    && _borrowerCanShopForIndicator2015.Clean
                    && _borrowerDidShopForIndicator2015.Clean
                    && _borrowerFinanced2015.Clean
                    && _borrowerPAC2015.Clean
                    && _borrowerPOC2015.Clean
                    && _borrowerPTC2015.Clean
                    && _borrowerSelectIndicator.Clean
                    && _brokerAmountPaid2015.Clean
                    && _brokerPAC2015.Clean
                    && _brokerPOC2015.Clean
                    && _description.Clean
                    && _escrowedIndicator2015.Clean
                    && _financedIndicator.Clean
                    && _gfe2010FeeIndex.Clean
                    && _gfe2010FeeParentType.Clean
                    && _gfe2010FeeType.Clean
                    && _gfeAmount.Clean
                    && _id.Clean
                    && _insuranceIndicator2015.Clean
                    && _lastDisclosedClosingDisclosure2015.Clean
                    && _lastDisclosedLoanEstimate2015.Clean
                    && _lenderAmountPaid2015.Clean
                    && _lenderPAC2015.Clean
                    && _lenderPOC2015.Clean
                    && _monthlyPayment.Clean
                    && _numberOfMonths.Clean
                    && _optionalIndicator2015.Clean
                    && _otherAmountPaid2015.Clean
                    && _otherPAC2015.Clean
                    && _otherPOC2015.Clean
                    && _paidByType.Clean
                    && _paidToName.Clean
                    && _pocPtcIndicator.Clean
                    && _propertyIndicator2015.Clean
                    && _ptbType.Clean
                    && _rate.Clean
                    && _retainedAmount2015.Clean
                    && _sec32PointsAndFees2015.Clean
                    && _sellerAmountPaid2015.Clean
                    && _sellerCreditIndicator2015.Clean
                    && _sellerObligatedAmount2015.Clean
                    && _sellerObligatedIndicator2015.Clean
                    && _sellerPAC2015.Clean
                    && _sellerPOC2015.Clean
                    && _selPaidAmount.Clean
                    && _simultaneousIssuanceIndicator2015.Clean
                    && _taxesIndicator2015.Clean
                    && _titleServiceSelectIndicator.Clean
                    && _totalFeeAmount2015.Clean
                    && _totalFeePercentage2015.Clean
                    && _totalPaidByBLO2015.Clean
                    && _undiscountedInsurance2015.Clean
                    && _wholePoc.Clean
                    && _wholePocPaidByType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalAmount; v0.Clean = value; _additionalAmount = v0;
                var v1 = _amount; v1.Clean = value; _amount = v1;
                var v2 = _aprIndicator; v2.Clean = value; _aprIndicator = v2;
                var v3 = _borPaidAmount; v3.Clean = value; _borPaidAmount = v3;
                var v4 = _borrowerAmountPaid2015; v4.Clean = value; _borrowerAmountPaid2015 = v4;
                var v5 = _borrowerCanShopForIndicator2015; v5.Clean = value; _borrowerCanShopForIndicator2015 = v5;
                var v6 = _borrowerDidShopForIndicator2015; v6.Clean = value; _borrowerDidShopForIndicator2015 = v6;
                var v7 = _borrowerFinanced2015; v7.Clean = value; _borrowerFinanced2015 = v7;
                var v8 = _borrowerPAC2015; v8.Clean = value; _borrowerPAC2015 = v8;
                var v9 = _borrowerPOC2015; v9.Clean = value; _borrowerPOC2015 = v9;
                var v10 = _borrowerPTC2015; v10.Clean = value; _borrowerPTC2015 = v10;
                var v11 = _borrowerSelectIndicator; v11.Clean = value; _borrowerSelectIndicator = v11;
                var v12 = _brokerAmountPaid2015; v12.Clean = value; _brokerAmountPaid2015 = v12;
                var v13 = _brokerPAC2015; v13.Clean = value; _brokerPAC2015 = v13;
                var v14 = _brokerPOC2015; v14.Clean = value; _brokerPOC2015 = v14;
                var v15 = _description; v15.Clean = value; _description = v15;
                var v16 = _escrowedIndicator2015; v16.Clean = value; _escrowedIndicator2015 = v16;
                var v17 = _financedIndicator; v17.Clean = value; _financedIndicator = v17;
                var v18 = _gfe2010FeeIndex; v18.Clean = value; _gfe2010FeeIndex = v18;
                var v19 = _gfe2010FeeParentType; v19.Clean = value; _gfe2010FeeParentType = v19;
                var v20 = _gfe2010FeeType; v20.Clean = value; _gfe2010FeeType = v20;
                var v21 = _gfeAmount; v21.Clean = value; _gfeAmount = v21;
                var v22 = _id; v22.Clean = value; _id = v22;
                var v23 = _insuranceIndicator2015; v23.Clean = value; _insuranceIndicator2015 = v23;
                var v24 = _lastDisclosedClosingDisclosure2015; v24.Clean = value; _lastDisclosedClosingDisclosure2015 = v24;
                var v25 = _lastDisclosedLoanEstimate2015; v25.Clean = value; _lastDisclosedLoanEstimate2015 = v25;
                var v26 = _lenderAmountPaid2015; v26.Clean = value; _lenderAmountPaid2015 = v26;
                var v27 = _lenderPAC2015; v27.Clean = value; _lenderPAC2015 = v27;
                var v28 = _lenderPOC2015; v28.Clean = value; _lenderPOC2015 = v28;
                var v29 = _monthlyPayment; v29.Clean = value; _monthlyPayment = v29;
                var v30 = _numberOfMonths; v30.Clean = value; _numberOfMonths = v30;
                var v31 = _optionalIndicator2015; v31.Clean = value; _optionalIndicator2015 = v31;
                var v32 = _otherAmountPaid2015; v32.Clean = value; _otherAmountPaid2015 = v32;
                var v33 = _otherPAC2015; v33.Clean = value; _otherPAC2015 = v33;
                var v34 = _otherPOC2015; v34.Clean = value; _otherPOC2015 = v34;
                var v35 = _paidByType; v35.Clean = value; _paidByType = v35;
                var v36 = _paidToName; v36.Clean = value; _paidToName = v36;
                var v37 = _pocPtcIndicator; v37.Clean = value; _pocPtcIndicator = v37;
                var v38 = _propertyIndicator2015; v38.Clean = value; _propertyIndicator2015 = v38;
                var v39 = _ptbType; v39.Clean = value; _ptbType = v39;
                var v40 = _rate; v40.Clean = value; _rate = v40;
                var v41 = _retainedAmount2015; v41.Clean = value; _retainedAmount2015 = v41;
                var v42 = _sec32PointsAndFees2015; v42.Clean = value; _sec32PointsAndFees2015 = v42;
                var v43 = _sellerAmountPaid2015; v43.Clean = value; _sellerAmountPaid2015 = v43;
                var v44 = _sellerCreditIndicator2015; v44.Clean = value; _sellerCreditIndicator2015 = v44;
                var v45 = _sellerObligatedAmount2015; v45.Clean = value; _sellerObligatedAmount2015 = v45;
                var v46 = _sellerObligatedIndicator2015; v46.Clean = value; _sellerObligatedIndicator2015 = v46;
                var v47 = _sellerPAC2015; v47.Clean = value; _sellerPAC2015 = v47;
                var v48 = _sellerPOC2015; v48.Clean = value; _sellerPOC2015 = v48;
                var v49 = _selPaidAmount; v49.Clean = value; _selPaidAmount = v49;
                var v50 = _simultaneousIssuanceIndicator2015; v50.Clean = value; _simultaneousIssuanceIndicator2015 = v50;
                var v51 = _taxesIndicator2015; v51.Clean = value; _taxesIndicator2015 = v51;
                var v52 = _titleServiceSelectIndicator; v52.Clean = value; _titleServiceSelectIndicator = v52;
                var v53 = _totalFeeAmount2015; v53.Clean = value; _totalFeeAmount2015 = v53;
                var v54 = _totalFeePercentage2015; v54.Clean = value; _totalFeePercentage2015 = v54;
                var v55 = _totalPaidByBLO2015; v55.Clean = value; _totalPaidByBLO2015 = v55;
                var v56 = _undiscountedInsurance2015; v56.Clean = value; _undiscountedInsurance2015 = v56;
                var v57 = _wholePoc; v57.Clean = value; _wholePoc = v57;
                var v58 = _wholePocPaidByType; v58.Clean = value; _wholePocPaidByType = v58;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010Fee()
        {
            Clean = true;
        }
    }
}