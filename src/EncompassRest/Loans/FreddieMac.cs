using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FreddieMac : IClean
    {
        private Value<string> _affordableProduct;
        public string AffordableProduct { get { return _affordableProduct; } set { _affordableProduct = value; } }
        private Value<decimal?> _alimonyAsIncomeReduction;
        public decimal? AlimonyAsIncomeReduction { get { return _alimonyAsIncomeReduction; } set { _alimonyAsIncomeReduction = value; } }
        private Value<decimal?> _allMonthlyPayments;
        public decimal? AllMonthlyPayments { get { return _allMonthlyPayments; } set { _allMonthlyPayments = value; } }
        private Value<bool?> _allowsNegativeAmortizationIndicator;
        public bool? AllowsNegativeAmortizationIndicator { get { return _allowsNegativeAmortizationIndicator; } set { _allowsNegativeAmortizationIndicator = value; } }
        private Value<string> _amountOfFinancedMI;
        public string AmountOfFinancedMI { get { return _amountOfFinancedMI; } set { _amountOfFinancedMI = value; } }
        private Value<string> _aPNCity;
        public string APNCity { get { return _aPNCity; } set { _aPNCity = value; } }
        private Value<bool?> _armsLengthTransactionIndicator;
        public bool? ArmsLengthTransactionIndicator { get { return _armsLengthTransactionIndicator; } set { _armsLengthTransactionIndicator = value; } }
        private Value<bool?> _borrowerQualifiesAsVeteranIndicator;
        public bool? BorrowerQualifiesAsVeteranIndicator { get { return _borrowerQualifiesAsVeteranIndicator; } set { _borrowerQualifiesAsVeteranIndicator = value; } }
        private Value<string> _brokerOriginated;
        public string BrokerOriginated { get { return _brokerOriginated; } set { _brokerOriginated = value; } }
        private Value<string> _buydownContributor;
        public string BuydownContributor { get { return _buydownContributor; } set { _buydownContributor = value; } }
        private Value<string> _condoClass;
        public string CondoClass { get { return _condoClass; } set { _condoClass = value; } }
        private Value<decimal?> _convertibleFeeAmount;
        public decimal? ConvertibleFeeAmount { get { return _convertibleFeeAmount; } set { _convertibleFeeAmount = value; } }
        private Value<decimal?> _convertibleFeePercent;
        public decimal? ConvertibleFeePercent { get { return _convertibleFeePercent; } set { _convertibleFeePercent = value; } }
        private Value<decimal?> _convertibleMaxRateAdjPercent;
        public decimal? ConvertibleMaxRateAdjPercent { get { return _convertibleMaxRateAdjPercent; } set { _convertibleMaxRateAdjPercent = value; } }
        private Value<decimal?> _convertibleMinRateAdjPercent;
        public decimal? ConvertibleMinRateAdjPercent { get { return _convertibleMinRateAdjPercent; } set { _convertibleMinRateAdjPercent = value; } }
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        private Value<string> _creditReportCompany;
        public string CreditReportCompany { get { return _creditReportCompany; } set { _creditReportCompany = value; } }
        private Value<decimal?> _financingConcessions;
        public decimal? FinancingConcessions { get { return _financingConcessions; } set { _financingConcessions = value; } }
        private Value<string> _freddieFiel11;
        public string FreddieFiel11 { get { return _freddieFiel11; } set { _freddieFiel11 = value; } }
        private Value<string> _freddieFiel12;
        public string FreddieFiel12 { get { return _freddieFiel12; } set { _freddieFiel12 = value; } }
        private Value<string> _freddieFiel13;
        public string FreddieFiel13 { get { return _freddieFiel13; } set { _freddieFiel13 = value; } }
        private Value<string> _freddieFiel14;
        public string FreddieFiel14 { get { return _freddieFiel14; } set { _freddieFiel14 = value; } }
        private Value<string> _freddieFiel15;
        public string FreddieFiel15 { get { return _freddieFiel15; } set { _freddieFiel15 = value; } }
        private Value<string> _freddieField3;
        public string FreddieField3 { get { return _freddieField3; } set { _freddieField3 = value; } }
        private Value<string> _freddieField7;
        public string FreddieField7 { get { return _freddieField7; } set { _freddieField7 = value; } }
        private Value<string> _hELOCActualBalance;
        public string HELOCActualBalance { get { return _hELOCActualBalance; } set { _hELOCActualBalance = value; } }
        private Value<string> _hELOCCreditLimit;
        public string HELOCCreditLimit { get { return _hELOCCreditLimit; } set { _hELOCCreditLimit = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _lenderAltPhone;
        public string LenderAltPhone { get { return _lenderAltPhone; } set { _lenderAltPhone = value; } }
        private Value<string> _lenderRegistration;
        public string LenderRegistration { get { return _lenderRegistration; } set { _lenderRegistration = value; } }
        private Value<string> _loanProspectorID;
        public string LoanProspectorID { get { return _loanProspectorID; } set { _loanProspectorID = value; } }
        private Value<string> _loanToConduitCode;
        public string LoanToConduitCode { get { return _loanToConduitCode; } set { _loanToConduitCode = value; } }
        private Value<string> _longLegalDescription;
        public string LongLegalDescription { get { return _longLegalDescription; } set { _longLegalDescription = value; } }
        private Value<string> _lossCoverage;
        public string LossCoverage { get { return _lossCoverage; } set { _lossCoverage = value; } }
        private Value<string> _lPKeyNumber;
        public string LPKeyNumber { get { return _lPKeyNumber; } set { _lPKeyNumber = value; } }
        private Value<string> _mIRefundOption;
        public string MIRefundOption { get { return _mIRefundOption; } set { _mIRefundOption = value; } }
        private Value<string> _mortgageInsuranceCompany;
        public string MortgageInsuranceCompany { get { return _mortgageInsuranceCompany; } set { _mortgageInsuranceCompany = value; } }
        private Value<decimal?> _netPurchasePrice;
        public decimal? NetPurchasePrice { get { return _netPurchasePrice; } set { _netPurchasePrice = value; } }
        private Value<string> _newConstructionType;
        public string NewConstructionType { get { return _newConstructionType; } set { _newConstructionType = value; } }
        private Value<string> _noAppraisalMAF;
        public string NoAppraisalMAF { get { return _noAppraisalMAF; } set { _noAppraisalMAF = value; } }
        private Value<decimal?> _nonOccupantNonHousingDebt;
        public decimal? NonOccupantNonHousingDebt { get { return _nonOccupantNonHousingDebt; } set { _nonOccupantNonHousingDebt = value; } }
        private Value<decimal?> _nonOccupantPresentHE;
        public decimal? NonOccupantPresentHE { get { return _nonOccupantPresentHE; } set { _nonOccupantPresentHE = value; } }
        private Value<bool?> _orderCreditEvaluationIndicator;
        public bool? OrderCreditEvaluationIndicator { get { return _orderCreditEvaluationIndicator; } set { _orderCreditEvaluationIndicator = value; } }
        private Value<bool?> _orderMergedCreditReportIndicator;
        public bool? OrderMergedCreditReportIndicator { get { return _orderMergedCreditReportIndicator; } set { _orderMergedCreditReportIndicator = value; } }
        private Value<string> _orderMortgageInsurance;
        public string OrderMortgageInsurance { get { return _orderMortgageInsurance; } set { _orderMortgageInsurance = value; } }
        private Value<bool?> _orderRiskGradeEvaluationIndicator;
        public bool? OrderRiskGradeEvaluationIndicator { get { return _orderRiskGradeEvaluationIndicator; } set { _orderRiskGradeEvaluationIndicator = value; } }
        private Value<decimal?> _originalIntRate;
        public decimal? OriginalIntRate { get { return _originalIntRate; } set { _originalIntRate = value; } }
        private Value<string> _originateID;
        public string OriginateID { get { return _originateID; } set { _originateID = value; } }
        private Value<string> _paymentFrequency;
        public string PaymentFrequency { get { return _paymentFrequency; } set { _paymentFrequency = value; } }
        private Value<string> _paymentOption;
        public string PaymentOption { get { return _paymentOption; } set { _paymentOption = value; } }
        private Value<decimal?> _personIncomeForSelfEmployment1;
        public decimal? PersonIncomeForSelfEmployment1 { get { return _personIncomeForSelfEmployment1; } set { _personIncomeForSelfEmployment1 = value; } }
        private Value<decimal?> _personIncomeForSelfEmployment2;
        public decimal? PersonIncomeForSelfEmployment2 { get { return _personIncomeForSelfEmployment2; } set { _personIncomeForSelfEmployment2 = value; } }
        private Value<int?> _personPercentOfBusinessOwned1;
        public int? PersonPercentOfBusinessOwned1 { get { return _personPercentOfBusinessOwned1; } set { _personPercentOfBusinessOwned1 = value; } }
        private Value<int?> _personPercentOfBusinessOwned2;
        public int? PersonPercentOfBusinessOwned2 { get { return _personPercentOfBusinessOwned2; } set { _personPercentOfBusinessOwned2 = value; } }
        private Value<string> _premiumSource;
        public string PremiumSource { get { return _premiumSource; } set { _premiumSource = value; } }
        private Value<decimal?> _presentHousingExpense;
        public decimal? PresentHousingExpense { get { return _presentHousingExpense; } set { _presentHousingExpense = value; } }
        private Value<string> _processingPoint;
        public string ProcessingPoint { get { return _processingPoint; } set { _processingPoint = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<string> _purposeOfLoan;
        public string PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        private Value<string> _renewalOption;
        public string RenewalOption { get { return _renewalOption; } set { _renewalOption = value; } }
        private Value<string> _renewalType;
        public string RenewalType { get { return _renewalType; } set { _renewalType = value; } }
        private Value<string> _requiredDocumentType;
        public string RequiredDocumentType { get { return _requiredDocumentType; } set { _requiredDocumentType = value; } }
        private Value<decimal?> _reserves;
        public decimal? Reserves { get { return _reserves; } set { _reserves = value; } }
        private Value<bool?> _retailLoanIndicator;
        public bool? RetailLoanIndicator { get { return _retailLoanIndicator; } set { _retailLoanIndicator = value; } }
        private Value<string> _riskClass;
        public string RiskClass { get { return _riskClass; } set { _riskClass = value; } }
        private Value<string> _riskGradeEvaluationType;
        public string RiskGradeEvaluationType { get { return _riskGradeEvaluationType; } set { _riskGradeEvaluationType = value; } }
        private Value<decimal?> _salesConcessions;
        public decimal? SalesConcessions { get { return _salesConcessions; } set { _salesConcessions = value; } }
        private Value<string> _secondaryFinancingType;
        public string SecondaryFinancingType { get { return _secondaryFinancingType; } set { _secondaryFinancingType = value; } }
        private Value<bool?> _secondTrustRefiIndicator;
        public bool? SecondTrustRefiIndicator { get { return _secondTrustRefiIndicator; } set { _secondTrustRefiIndicator = value; } }
        private Value<decimal?> _simulatedPITI;
        public decimal? SimulatedPITI { get { return _simulatedPITI; } set { _simulatedPITI = value; } }
        private Value<string> _sizeOfHousehold;
        public string SizeOfHousehold { get { return _sizeOfHousehold; } set { _sizeOfHousehold = value; } }
        private Value<string> _specialInstruction1;
        public string SpecialInstruction1 { get { return _specialInstruction1; } set { _specialInstruction1 = value; } }
        private Value<string> _specialInstruction2;
        public string SpecialInstruction2 { get { return _specialInstruction2; } set { _specialInstruction2 = value; } }
        private Value<string> _specialInstruction3;
        public string SpecialInstruction3 { get { return _specialInstruction3; } set { _specialInstruction3 = value; } }
        private Value<string> _specialInstruction4;
        public string SpecialInstruction4 { get { return _specialInstruction4; } set { _specialInstruction4 = value; } }
        private Value<string> _specialInstruction5;
        public string SpecialInstruction5 { get { return _specialInstruction5; } set { _specialInstruction5 = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<bool?> _transferLoanToConduitIndicator;
        public bool? TransferLoanToConduitIndicator { get { return _transferLoanToConduitIndicator; } set { _transferLoanToConduitIndicator = value; } }
        private Value<string> _yearsOfCoverage;
        public string YearsOfCoverage { get { return _yearsOfCoverage; } set { _yearsOfCoverage = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _affordableProduct.Clean
                    && _alimonyAsIncomeReduction.Clean
                    && _allMonthlyPayments.Clean
                    && _allowsNegativeAmortizationIndicator.Clean
                    && _amountOfFinancedMI.Clean
                    && _aPNCity.Clean
                    && _armsLengthTransactionIndicator.Clean
                    && _borrowerQualifiesAsVeteranIndicator.Clean
                    && _brokerOriginated.Clean
                    && _buydownContributor.Clean
                    && _condoClass.Clean
                    && _convertibleFeeAmount.Clean
                    && _convertibleFeePercent.Clean
                    && _convertibleMaxRateAdjPercent.Clean
                    && _convertibleMinRateAdjPercent.Clean
                    && _county.Clean
                    && _creditReportCompany.Clean
                    && _financingConcessions.Clean
                    && _freddieFiel11.Clean
                    && _freddieFiel12.Clean
                    && _freddieFiel13.Clean
                    && _freddieFiel14.Clean
                    && _freddieFiel15.Clean
                    && _freddieField3.Clean
                    && _freddieField7.Clean
                    && _hELOCActualBalance.Clean
                    && _hELOCCreditLimit.Clean
                    && _id.Clean
                    && _lenderAltPhone.Clean
                    && _lenderRegistration.Clean
                    && _loanProspectorID.Clean
                    && _loanToConduitCode.Clean
                    && _longLegalDescription.Clean
                    && _lossCoverage.Clean
                    && _lPKeyNumber.Clean
                    && _mIRefundOption.Clean
                    && _mortgageInsuranceCompany.Clean
                    && _netPurchasePrice.Clean
                    && _newConstructionType.Clean
                    && _noAppraisalMAF.Clean
                    && _nonOccupantNonHousingDebt.Clean
                    && _nonOccupantPresentHE.Clean
                    && _orderCreditEvaluationIndicator.Clean
                    && _orderMergedCreditReportIndicator.Clean
                    && _orderMortgageInsurance.Clean
                    && _orderRiskGradeEvaluationIndicator.Clean
                    && _originalIntRate.Clean
                    && _originateID.Clean
                    && _paymentFrequency.Clean
                    && _paymentOption.Clean
                    && _personIncomeForSelfEmployment1.Clean
                    && _personIncomeForSelfEmployment2.Clean
                    && _personPercentOfBusinessOwned1.Clean
                    && _personPercentOfBusinessOwned2.Clean
                    && _premiumSource.Clean
                    && _presentHousingExpense.Clean
                    && _processingPoint.Clean
                    && _propertyType.Clean
                    && _purposeOfLoan.Clean
                    && _renewalOption.Clean
                    && _renewalType.Clean
                    && _requiredDocumentType.Clean
                    && _reserves.Clean
                    && _retailLoanIndicator.Clean
                    && _riskClass.Clean
                    && _riskGradeEvaluationType.Clean
                    && _salesConcessions.Clean
                    && _secondaryFinancingType.Clean
                    && _secondTrustRefiIndicator.Clean
                    && _simulatedPITI.Clean
                    && _sizeOfHousehold.Clean
                    && _specialInstruction1.Clean
                    && _specialInstruction2.Clean
                    && _specialInstruction3.Clean
                    && _specialInstruction4.Clean
                    && _specialInstruction5.Clean
                    && _state.Clean
                    && _transferLoanToConduitIndicator.Clean
                    && _yearsOfCoverage.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var affordableProduct = _affordableProduct; affordableProduct.Clean = value; _affordableProduct = affordableProduct;
                var alimonyAsIncomeReduction = _alimonyAsIncomeReduction; alimonyAsIncomeReduction.Clean = value; _alimonyAsIncomeReduction = alimonyAsIncomeReduction;
                var allMonthlyPayments = _allMonthlyPayments; allMonthlyPayments.Clean = value; _allMonthlyPayments = allMonthlyPayments;
                var allowsNegativeAmortizationIndicator = _allowsNegativeAmortizationIndicator; allowsNegativeAmortizationIndicator.Clean = value; _allowsNegativeAmortizationIndicator = allowsNegativeAmortizationIndicator;
                var amountOfFinancedMI = _amountOfFinancedMI; amountOfFinancedMI.Clean = value; _amountOfFinancedMI = amountOfFinancedMI;
                var aPNCity = _aPNCity; aPNCity.Clean = value; _aPNCity = aPNCity;
                var armsLengthTransactionIndicator = _armsLengthTransactionIndicator; armsLengthTransactionIndicator.Clean = value; _armsLengthTransactionIndicator = armsLengthTransactionIndicator;
                var borrowerQualifiesAsVeteranIndicator = _borrowerQualifiesAsVeteranIndicator; borrowerQualifiesAsVeteranIndicator.Clean = value; _borrowerQualifiesAsVeteranIndicator = borrowerQualifiesAsVeteranIndicator;
                var brokerOriginated = _brokerOriginated; brokerOriginated.Clean = value; _brokerOriginated = brokerOriginated;
                var buydownContributor = _buydownContributor; buydownContributor.Clean = value; _buydownContributor = buydownContributor;
                var condoClass = _condoClass; condoClass.Clean = value; _condoClass = condoClass;
                var convertibleFeeAmount = _convertibleFeeAmount; convertibleFeeAmount.Clean = value; _convertibleFeeAmount = convertibleFeeAmount;
                var convertibleFeePercent = _convertibleFeePercent; convertibleFeePercent.Clean = value; _convertibleFeePercent = convertibleFeePercent;
                var convertibleMaxRateAdjPercent = _convertibleMaxRateAdjPercent; convertibleMaxRateAdjPercent.Clean = value; _convertibleMaxRateAdjPercent = convertibleMaxRateAdjPercent;
                var convertibleMinRateAdjPercent = _convertibleMinRateAdjPercent; convertibleMinRateAdjPercent.Clean = value; _convertibleMinRateAdjPercent = convertibleMinRateAdjPercent;
                var county = _county; county.Clean = value; _county = county;
                var creditReportCompany = _creditReportCompany; creditReportCompany.Clean = value; _creditReportCompany = creditReportCompany;
                var financingConcessions = _financingConcessions; financingConcessions.Clean = value; _financingConcessions = financingConcessions;
                var freddieFiel11 = _freddieFiel11; freddieFiel11.Clean = value; _freddieFiel11 = freddieFiel11;
                var freddieFiel12 = _freddieFiel12; freddieFiel12.Clean = value; _freddieFiel12 = freddieFiel12;
                var freddieFiel13 = _freddieFiel13; freddieFiel13.Clean = value; _freddieFiel13 = freddieFiel13;
                var freddieFiel14 = _freddieFiel14; freddieFiel14.Clean = value; _freddieFiel14 = freddieFiel14;
                var freddieFiel15 = _freddieFiel15; freddieFiel15.Clean = value; _freddieFiel15 = freddieFiel15;
                var freddieField3 = _freddieField3; freddieField3.Clean = value; _freddieField3 = freddieField3;
                var freddieField7 = _freddieField7; freddieField7.Clean = value; _freddieField7 = freddieField7;
                var hELOCActualBalance = _hELOCActualBalance; hELOCActualBalance.Clean = value; _hELOCActualBalance = hELOCActualBalance;
                var hELOCCreditLimit = _hELOCCreditLimit; hELOCCreditLimit.Clean = value; _hELOCCreditLimit = hELOCCreditLimit;
                var id = _id; id.Clean = value; _id = id;
                var lenderAltPhone = _lenderAltPhone; lenderAltPhone.Clean = value; _lenderAltPhone = lenderAltPhone;
                var lenderRegistration = _lenderRegistration; lenderRegistration.Clean = value; _lenderRegistration = lenderRegistration;
                var loanProspectorID = _loanProspectorID; loanProspectorID.Clean = value; _loanProspectorID = loanProspectorID;
                var loanToConduitCode = _loanToConduitCode; loanToConduitCode.Clean = value; _loanToConduitCode = loanToConduitCode;
                var longLegalDescription = _longLegalDescription; longLegalDescription.Clean = value; _longLegalDescription = longLegalDescription;
                var lossCoverage = _lossCoverage; lossCoverage.Clean = value; _lossCoverage = lossCoverage;
                var lPKeyNumber = _lPKeyNumber; lPKeyNumber.Clean = value; _lPKeyNumber = lPKeyNumber;
                var mIRefundOption = _mIRefundOption; mIRefundOption.Clean = value; _mIRefundOption = mIRefundOption;
                var mortgageInsuranceCompany = _mortgageInsuranceCompany; mortgageInsuranceCompany.Clean = value; _mortgageInsuranceCompany = mortgageInsuranceCompany;
                var netPurchasePrice = _netPurchasePrice; netPurchasePrice.Clean = value; _netPurchasePrice = netPurchasePrice;
                var newConstructionType = _newConstructionType; newConstructionType.Clean = value; _newConstructionType = newConstructionType;
                var noAppraisalMAF = _noAppraisalMAF; noAppraisalMAF.Clean = value; _noAppraisalMAF = noAppraisalMAF;
                var nonOccupantNonHousingDebt = _nonOccupantNonHousingDebt; nonOccupantNonHousingDebt.Clean = value; _nonOccupantNonHousingDebt = nonOccupantNonHousingDebt;
                var nonOccupantPresentHE = _nonOccupantPresentHE; nonOccupantPresentHE.Clean = value; _nonOccupantPresentHE = nonOccupantPresentHE;
                var orderCreditEvaluationIndicator = _orderCreditEvaluationIndicator; orderCreditEvaluationIndicator.Clean = value; _orderCreditEvaluationIndicator = orderCreditEvaluationIndicator;
                var orderMergedCreditReportIndicator = _orderMergedCreditReportIndicator; orderMergedCreditReportIndicator.Clean = value; _orderMergedCreditReportIndicator = orderMergedCreditReportIndicator;
                var orderMortgageInsurance = _orderMortgageInsurance; orderMortgageInsurance.Clean = value; _orderMortgageInsurance = orderMortgageInsurance;
                var orderRiskGradeEvaluationIndicator = _orderRiskGradeEvaluationIndicator; orderRiskGradeEvaluationIndicator.Clean = value; _orderRiskGradeEvaluationIndicator = orderRiskGradeEvaluationIndicator;
                var originalIntRate = _originalIntRate; originalIntRate.Clean = value; _originalIntRate = originalIntRate;
                var originateID = _originateID; originateID.Clean = value; _originateID = originateID;
                var paymentFrequency = _paymentFrequency; paymentFrequency.Clean = value; _paymentFrequency = paymentFrequency;
                var paymentOption = _paymentOption; paymentOption.Clean = value; _paymentOption = paymentOption;
                var personIncomeForSelfEmployment1 = _personIncomeForSelfEmployment1; personIncomeForSelfEmployment1.Clean = value; _personIncomeForSelfEmployment1 = personIncomeForSelfEmployment1;
                var personIncomeForSelfEmployment2 = _personIncomeForSelfEmployment2; personIncomeForSelfEmployment2.Clean = value; _personIncomeForSelfEmployment2 = personIncomeForSelfEmployment2;
                var personPercentOfBusinessOwned1 = _personPercentOfBusinessOwned1; personPercentOfBusinessOwned1.Clean = value; _personPercentOfBusinessOwned1 = personPercentOfBusinessOwned1;
                var personPercentOfBusinessOwned2 = _personPercentOfBusinessOwned2; personPercentOfBusinessOwned2.Clean = value; _personPercentOfBusinessOwned2 = personPercentOfBusinessOwned2;
                var premiumSource = _premiumSource; premiumSource.Clean = value; _premiumSource = premiumSource;
                var presentHousingExpense = _presentHousingExpense; presentHousingExpense.Clean = value; _presentHousingExpense = presentHousingExpense;
                var processingPoint = _processingPoint; processingPoint.Clean = value; _processingPoint = processingPoint;
                var propertyType = _propertyType; propertyType.Clean = value; _propertyType = propertyType;
                var purposeOfLoan = _purposeOfLoan; purposeOfLoan.Clean = value; _purposeOfLoan = purposeOfLoan;
                var renewalOption = _renewalOption; renewalOption.Clean = value; _renewalOption = renewalOption;
                var renewalType = _renewalType; renewalType.Clean = value; _renewalType = renewalType;
                var requiredDocumentType = _requiredDocumentType; requiredDocumentType.Clean = value; _requiredDocumentType = requiredDocumentType;
                var reserves = _reserves; reserves.Clean = value; _reserves = reserves;
                var retailLoanIndicator = _retailLoanIndicator; retailLoanIndicator.Clean = value; _retailLoanIndicator = retailLoanIndicator;
                var riskClass = _riskClass; riskClass.Clean = value; _riskClass = riskClass;
                var riskGradeEvaluationType = _riskGradeEvaluationType; riskGradeEvaluationType.Clean = value; _riskGradeEvaluationType = riskGradeEvaluationType;
                var salesConcessions = _salesConcessions; salesConcessions.Clean = value; _salesConcessions = salesConcessions;
                var secondaryFinancingType = _secondaryFinancingType; secondaryFinancingType.Clean = value; _secondaryFinancingType = secondaryFinancingType;
                var secondTrustRefiIndicator = _secondTrustRefiIndicator; secondTrustRefiIndicator.Clean = value; _secondTrustRefiIndicator = secondTrustRefiIndicator;
                var simulatedPITI = _simulatedPITI; simulatedPITI.Clean = value; _simulatedPITI = simulatedPITI;
                var sizeOfHousehold = _sizeOfHousehold; sizeOfHousehold.Clean = value; _sizeOfHousehold = sizeOfHousehold;
                var specialInstruction1 = _specialInstruction1; specialInstruction1.Clean = value; _specialInstruction1 = specialInstruction1;
                var specialInstruction2 = _specialInstruction2; specialInstruction2.Clean = value; _specialInstruction2 = specialInstruction2;
                var specialInstruction3 = _specialInstruction3; specialInstruction3.Clean = value; _specialInstruction3 = specialInstruction3;
                var specialInstruction4 = _specialInstruction4; specialInstruction4.Clean = value; _specialInstruction4 = specialInstruction4;
                var specialInstruction5 = _specialInstruction5; specialInstruction5.Clean = value; _specialInstruction5 = specialInstruction5;
                var state = _state; state.Clean = value; _state = state;
                var transferLoanToConduitIndicator = _transferLoanToConduitIndicator; transferLoanToConduitIndicator.Clean = value; _transferLoanToConduitIndicator = transferLoanToConduitIndicator;
                var yearsOfCoverage = _yearsOfCoverage; yearsOfCoverage.Clean = value; _yearsOfCoverage = yearsOfCoverage;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FreddieMac()
        {
            Clean = true;
        }
    }
}