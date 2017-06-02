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
                var v0 = _affordableProduct; v0.Clean = value; _affordableProduct = v0;
                var v1 = _alimonyAsIncomeReduction; v1.Clean = value; _alimonyAsIncomeReduction = v1;
                var v2 = _allMonthlyPayments; v2.Clean = value; _allMonthlyPayments = v2;
                var v3 = _allowsNegativeAmortizationIndicator; v3.Clean = value; _allowsNegativeAmortizationIndicator = v3;
                var v4 = _amountOfFinancedMI; v4.Clean = value; _amountOfFinancedMI = v4;
                var v5 = _aPNCity; v5.Clean = value; _aPNCity = v5;
                var v6 = _armsLengthTransactionIndicator; v6.Clean = value; _armsLengthTransactionIndicator = v6;
                var v7 = _borrowerQualifiesAsVeteranIndicator; v7.Clean = value; _borrowerQualifiesAsVeteranIndicator = v7;
                var v8 = _brokerOriginated; v8.Clean = value; _brokerOriginated = v8;
                var v9 = _buydownContributor; v9.Clean = value; _buydownContributor = v9;
                var v10 = _condoClass; v10.Clean = value; _condoClass = v10;
                var v11 = _convertibleFeeAmount; v11.Clean = value; _convertibleFeeAmount = v11;
                var v12 = _convertibleFeePercent; v12.Clean = value; _convertibleFeePercent = v12;
                var v13 = _convertibleMaxRateAdjPercent; v13.Clean = value; _convertibleMaxRateAdjPercent = v13;
                var v14 = _convertibleMinRateAdjPercent; v14.Clean = value; _convertibleMinRateAdjPercent = v14;
                var v15 = _county; v15.Clean = value; _county = v15;
                var v16 = _creditReportCompany; v16.Clean = value; _creditReportCompany = v16;
                var v17 = _financingConcessions; v17.Clean = value; _financingConcessions = v17;
                var v18 = _freddieFiel11; v18.Clean = value; _freddieFiel11 = v18;
                var v19 = _freddieFiel12; v19.Clean = value; _freddieFiel12 = v19;
                var v20 = _freddieFiel13; v20.Clean = value; _freddieFiel13 = v20;
                var v21 = _freddieFiel14; v21.Clean = value; _freddieFiel14 = v21;
                var v22 = _freddieFiel15; v22.Clean = value; _freddieFiel15 = v22;
                var v23 = _freddieField3; v23.Clean = value; _freddieField3 = v23;
                var v24 = _freddieField7; v24.Clean = value; _freddieField7 = v24;
                var v25 = _hELOCActualBalance; v25.Clean = value; _hELOCActualBalance = v25;
                var v26 = _hELOCCreditLimit; v26.Clean = value; _hELOCCreditLimit = v26;
                var v27 = _id; v27.Clean = value; _id = v27;
                var v28 = _lenderAltPhone; v28.Clean = value; _lenderAltPhone = v28;
                var v29 = _lenderRegistration; v29.Clean = value; _lenderRegistration = v29;
                var v30 = _loanProspectorID; v30.Clean = value; _loanProspectorID = v30;
                var v31 = _loanToConduitCode; v31.Clean = value; _loanToConduitCode = v31;
                var v32 = _longLegalDescription; v32.Clean = value; _longLegalDescription = v32;
                var v33 = _lossCoverage; v33.Clean = value; _lossCoverage = v33;
                var v34 = _lPKeyNumber; v34.Clean = value; _lPKeyNumber = v34;
                var v35 = _mIRefundOption; v35.Clean = value; _mIRefundOption = v35;
                var v36 = _mortgageInsuranceCompany; v36.Clean = value; _mortgageInsuranceCompany = v36;
                var v37 = _netPurchasePrice; v37.Clean = value; _netPurchasePrice = v37;
                var v38 = _newConstructionType; v38.Clean = value; _newConstructionType = v38;
                var v39 = _noAppraisalMAF; v39.Clean = value; _noAppraisalMAF = v39;
                var v40 = _nonOccupantNonHousingDebt; v40.Clean = value; _nonOccupantNonHousingDebt = v40;
                var v41 = _nonOccupantPresentHE; v41.Clean = value; _nonOccupantPresentHE = v41;
                var v42 = _orderCreditEvaluationIndicator; v42.Clean = value; _orderCreditEvaluationIndicator = v42;
                var v43 = _orderMergedCreditReportIndicator; v43.Clean = value; _orderMergedCreditReportIndicator = v43;
                var v44 = _orderMortgageInsurance; v44.Clean = value; _orderMortgageInsurance = v44;
                var v45 = _orderRiskGradeEvaluationIndicator; v45.Clean = value; _orderRiskGradeEvaluationIndicator = v45;
                var v46 = _originalIntRate; v46.Clean = value; _originalIntRate = v46;
                var v47 = _originateID; v47.Clean = value; _originateID = v47;
                var v48 = _paymentFrequency; v48.Clean = value; _paymentFrequency = v48;
                var v49 = _paymentOption; v49.Clean = value; _paymentOption = v49;
                var v50 = _personIncomeForSelfEmployment1; v50.Clean = value; _personIncomeForSelfEmployment1 = v50;
                var v51 = _personIncomeForSelfEmployment2; v51.Clean = value; _personIncomeForSelfEmployment2 = v51;
                var v52 = _personPercentOfBusinessOwned1; v52.Clean = value; _personPercentOfBusinessOwned1 = v52;
                var v53 = _personPercentOfBusinessOwned2; v53.Clean = value; _personPercentOfBusinessOwned2 = v53;
                var v54 = _premiumSource; v54.Clean = value; _premiumSource = v54;
                var v55 = _presentHousingExpense; v55.Clean = value; _presentHousingExpense = v55;
                var v56 = _processingPoint; v56.Clean = value; _processingPoint = v56;
                var v57 = _propertyType; v57.Clean = value; _propertyType = v57;
                var v58 = _purposeOfLoan; v58.Clean = value; _purposeOfLoan = v58;
                var v59 = _renewalOption; v59.Clean = value; _renewalOption = v59;
                var v60 = _renewalType; v60.Clean = value; _renewalType = v60;
                var v61 = _requiredDocumentType; v61.Clean = value; _requiredDocumentType = v61;
                var v62 = _reserves; v62.Clean = value; _reserves = v62;
                var v63 = _retailLoanIndicator; v63.Clean = value; _retailLoanIndicator = v63;
                var v64 = _riskClass; v64.Clean = value; _riskClass = v64;
                var v65 = _riskGradeEvaluationType; v65.Clean = value; _riskGradeEvaluationType = v65;
                var v66 = _salesConcessions; v66.Clean = value; _salesConcessions = v66;
                var v67 = _secondaryFinancingType; v67.Clean = value; _secondaryFinancingType = v67;
                var v68 = _secondTrustRefiIndicator; v68.Clean = value; _secondTrustRefiIndicator = v68;
                var v69 = _simulatedPITI; v69.Clean = value; _simulatedPITI = v69;
                var v70 = _sizeOfHousehold; v70.Clean = value; _sizeOfHousehold = v70;
                var v71 = _specialInstruction1; v71.Clean = value; _specialInstruction1 = v71;
                var v72 = _specialInstruction2; v72.Clean = value; _specialInstruction2 = v72;
                var v73 = _specialInstruction3; v73.Clean = value; _specialInstruction3 = v73;
                var v74 = _specialInstruction4; v74.Clean = value; _specialInstruction4 = v74;
                var v75 = _specialInstruction5; v75.Clean = value; _specialInstruction5 = v75;
                var v76 = _state; v76.Clean = value; _state = v76;
                var v77 = _transferLoanToConduitIndicator; v77.Clean = value; _transferLoanToConduitIndicator = v77;
                var v78 = _yearsOfCoverage; v78.Clean = value; _yearsOfCoverage = v78;
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