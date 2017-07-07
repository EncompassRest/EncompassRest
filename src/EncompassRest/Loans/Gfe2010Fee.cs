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
                var additionalAmount = _additionalAmount; additionalAmount.Clean = value; _additionalAmount = additionalAmount;
                var amount = _amount; amount.Clean = value; _amount = amount;
                var aprIndicator = _aprIndicator; aprIndicator.Clean = value; _aprIndicator = aprIndicator;
                var borPaidAmount = _borPaidAmount; borPaidAmount.Clean = value; _borPaidAmount = borPaidAmount;
                var borrowerAmountPaid2015 = _borrowerAmountPaid2015; borrowerAmountPaid2015.Clean = value; _borrowerAmountPaid2015 = borrowerAmountPaid2015;
                var borrowerCanShopForIndicator2015 = _borrowerCanShopForIndicator2015; borrowerCanShopForIndicator2015.Clean = value; _borrowerCanShopForIndicator2015 = borrowerCanShopForIndicator2015;
                var borrowerDidShopForIndicator2015 = _borrowerDidShopForIndicator2015; borrowerDidShopForIndicator2015.Clean = value; _borrowerDidShopForIndicator2015 = borrowerDidShopForIndicator2015;
                var borrowerFinanced2015 = _borrowerFinanced2015; borrowerFinanced2015.Clean = value; _borrowerFinanced2015 = borrowerFinanced2015;
                var borrowerPAC2015 = _borrowerPAC2015; borrowerPAC2015.Clean = value; _borrowerPAC2015 = borrowerPAC2015;
                var borrowerPOC2015 = _borrowerPOC2015; borrowerPOC2015.Clean = value; _borrowerPOC2015 = borrowerPOC2015;
                var borrowerPTC2015 = _borrowerPTC2015; borrowerPTC2015.Clean = value; _borrowerPTC2015 = borrowerPTC2015;
                var borrowerSelectIndicator = _borrowerSelectIndicator; borrowerSelectIndicator.Clean = value; _borrowerSelectIndicator = borrowerSelectIndicator;
                var brokerAmountPaid2015 = _brokerAmountPaid2015; brokerAmountPaid2015.Clean = value; _brokerAmountPaid2015 = brokerAmountPaid2015;
                var brokerPAC2015 = _brokerPAC2015; brokerPAC2015.Clean = value; _brokerPAC2015 = brokerPAC2015;
                var brokerPOC2015 = _brokerPOC2015; brokerPOC2015.Clean = value; _brokerPOC2015 = brokerPOC2015;
                var description = _description; description.Clean = value; _description = description;
                var escrowedIndicator2015 = _escrowedIndicator2015; escrowedIndicator2015.Clean = value; _escrowedIndicator2015 = escrowedIndicator2015;
                var financedIndicator = _financedIndicator; financedIndicator.Clean = value; _financedIndicator = financedIndicator;
                var gfe2010FeeIndex = _gfe2010FeeIndex; gfe2010FeeIndex.Clean = value; _gfe2010FeeIndex = gfe2010FeeIndex;
                var gfe2010FeeParentType = _gfe2010FeeParentType; gfe2010FeeParentType.Clean = value; _gfe2010FeeParentType = gfe2010FeeParentType;
                var gfe2010FeeType = _gfe2010FeeType; gfe2010FeeType.Clean = value; _gfe2010FeeType = gfe2010FeeType;
                var gfeAmount = _gfeAmount; gfeAmount.Clean = value; _gfeAmount = gfeAmount;
                var id = _id; id.Clean = value; _id = id;
                var insuranceIndicator2015 = _insuranceIndicator2015; insuranceIndicator2015.Clean = value; _insuranceIndicator2015 = insuranceIndicator2015;
                var lastDisclosedClosingDisclosure2015 = _lastDisclosedClosingDisclosure2015; lastDisclosedClosingDisclosure2015.Clean = value; _lastDisclosedClosingDisclosure2015 = lastDisclosedClosingDisclosure2015;
                var lastDisclosedLoanEstimate2015 = _lastDisclosedLoanEstimate2015; lastDisclosedLoanEstimate2015.Clean = value; _lastDisclosedLoanEstimate2015 = lastDisclosedLoanEstimate2015;
                var lenderAmountPaid2015 = _lenderAmountPaid2015; lenderAmountPaid2015.Clean = value; _lenderAmountPaid2015 = lenderAmountPaid2015;
                var lenderPAC2015 = _lenderPAC2015; lenderPAC2015.Clean = value; _lenderPAC2015 = lenderPAC2015;
                var lenderPOC2015 = _lenderPOC2015; lenderPOC2015.Clean = value; _lenderPOC2015 = lenderPOC2015;
                var monthlyPayment = _monthlyPayment; monthlyPayment.Clean = value; _monthlyPayment = monthlyPayment;
                var numberOfMonths = _numberOfMonths; numberOfMonths.Clean = value; _numberOfMonths = numberOfMonths;
                var optionalIndicator2015 = _optionalIndicator2015; optionalIndicator2015.Clean = value; _optionalIndicator2015 = optionalIndicator2015;
                var otherAmountPaid2015 = _otherAmountPaid2015; otherAmountPaid2015.Clean = value; _otherAmountPaid2015 = otherAmountPaid2015;
                var otherPAC2015 = _otherPAC2015; otherPAC2015.Clean = value; _otherPAC2015 = otherPAC2015;
                var otherPOC2015 = _otherPOC2015; otherPOC2015.Clean = value; _otherPOC2015 = otherPOC2015;
                var paidByType = _paidByType; paidByType.Clean = value; _paidByType = paidByType;
                var paidToName = _paidToName; paidToName.Clean = value; _paidToName = paidToName;
                var pocPtcIndicator = _pocPtcIndicator; pocPtcIndicator.Clean = value; _pocPtcIndicator = pocPtcIndicator;
                var propertyIndicator2015 = _propertyIndicator2015; propertyIndicator2015.Clean = value; _propertyIndicator2015 = propertyIndicator2015;
                var ptbType = _ptbType; ptbType.Clean = value; _ptbType = ptbType;
                var rate = _rate; rate.Clean = value; _rate = rate;
                var retainedAmount2015 = _retainedAmount2015; retainedAmount2015.Clean = value; _retainedAmount2015 = retainedAmount2015;
                var sec32PointsAndFees2015 = _sec32PointsAndFees2015; sec32PointsAndFees2015.Clean = value; _sec32PointsAndFees2015 = sec32PointsAndFees2015;
                var sellerAmountPaid2015 = _sellerAmountPaid2015; sellerAmountPaid2015.Clean = value; _sellerAmountPaid2015 = sellerAmountPaid2015;
                var sellerCreditIndicator2015 = _sellerCreditIndicator2015; sellerCreditIndicator2015.Clean = value; _sellerCreditIndicator2015 = sellerCreditIndicator2015;
                var sellerObligatedAmount2015 = _sellerObligatedAmount2015; sellerObligatedAmount2015.Clean = value; _sellerObligatedAmount2015 = sellerObligatedAmount2015;
                var sellerObligatedIndicator2015 = _sellerObligatedIndicator2015; sellerObligatedIndicator2015.Clean = value; _sellerObligatedIndicator2015 = sellerObligatedIndicator2015;
                var sellerPAC2015 = _sellerPAC2015; sellerPAC2015.Clean = value; _sellerPAC2015 = sellerPAC2015;
                var sellerPOC2015 = _sellerPOC2015; sellerPOC2015.Clean = value; _sellerPOC2015 = sellerPOC2015;
                var selPaidAmount = _selPaidAmount; selPaidAmount.Clean = value; _selPaidAmount = selPaidAmount;
                var simultaneousIssuanceIndicator2015 = _simultaneousIssuanceIndicator2015; simultaneousIssuanceIndicator2015.Clean = value; _simultaneousIssuanceIndicator2015 = simultaneousIssuanceIndicator2015;
                var taxesIndicator2015 = _taxesIndicator2015; taxesIndicator2015.Clean = value; _taxesIndicator2015 = taxesIndicator2015;
                var titleServiceSelectIndicator = _titleServiceSelectIndicator; titleServiceSelectIndicator.Clean = value; _titleServiceSelectIndicator = titleServiceSelectIndicator;
                var totalFeeAmount2015 = _totalFeeAmount2015; totalFeeAmount2015.Clean = value; _totalFeeAmount2015 = totalFeeAmount2015;
                var totalFeePercentage2015 = _totalFeePercentage2015; totalFeePercentage2015.Clean = value; _totalFeePercentage2015 = totalFeePercentage2015;
                var totalPaidByBLO2015 = _totalPaidByBLO2015; totalPaidByBLO2015.Clean = value; _totalPaidByBLO2015 = totalPaidByBLO2015;
                var undiscountedInsurance2015 = _undiscountedInsurance2015; undiscountedInsurance2015.Clean = value; _undiscountedInsurance2015 = undiscountedInsurance2015;
                var wholePoc = _wholePoc; wholePoc.Clean = value; _wholePoc = wholePoc;
                var wholePocPaidByType = _wholePocPaidByType; wholePocPaidByType.Clean = value; _wholePocPaidByType = wholePocPaidByType;
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