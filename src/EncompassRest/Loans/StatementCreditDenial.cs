using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class StatementCreditDenial : IClean
    {
        private Value<bool?> _additionalStatement;
        public bool? AdditionalStatement { get { return _additionalStatement; } set { _additionalStatement = value; } }
        private Value<bool?> _bankruptcy;
        public bool? Bankruptcy { get { return _bankruptcy; } set { _bankruptcy = value; } }
        private Value<bool?> _collateralNotSufficient;
        public bool? CollateralNotSufficient { get { return _collateralNotSufficient; } set { _collateralNotSufficient = value; } }
        private Value<bool?> _creditApplicationIncomplete;
        public bool? CreditApplicationIncomplete { get { return _creditApplicationIncomplete; } set { _creditApplicationIncomplete = value; } }
        private Value<bool?> _creditReportObtainedFromConsumerReportingAgency;
        public bool? CreditReportObtainedFromConsumerReportingAgency { get { return _creditReportObtainedFromConsumerReportingAgency; } set { _creditReportObtainedFromConsumerReportingAgency = value; } }
        private Value<bool?> _delinquentCreditObligations;
        public bool? DelinquentCreditObligations { get { return _delinquentCreditObligations; } set { _delinquentCreditObligations = value; } }
        private Value<DateTime?> _denialDate;
        public DateTime? DenialDate { get { return _denialDate; } set { _denialDate = value; } }
        private Value<string> _denialDescription;
        public string DenialDescription { get { return _denialDescription; } set { _denialDescription = value; } }
        private Value<DateTime?> _denialMailedOn;
        public DateTime? DenialMailedOn { get { return _denialMailedOn; } set { _denialMailedOn = value; } }
        private Value<bool?> _denialOther1;
        public bool? DenialOther1 { get { return _denialOther1; } set { _denialOther1 = value; } }
        private Value<bool?> _denialOther2;
        public bool? DenialOther2 { get { return _denialOther2; } set { _denialOther2 = value; } }
        private Value<string> _denialOtherDesc1;
        public string DenialOtherDesc1 { get { return _denialOtherDesc1; } set { _denialOtherDesc1 = value; } }
        private Value<string> _denialOtherDesc2;
        public string DenialOtherDesc2 { get { return _denialOtherDesc2; } set { _denialOtherDesc2 = value; } }
        private Value<string> _deniedBy;
        public string DeniedBy { get { return _deniedBy; } set { _deniedBy = value; } }
        private Value<bool?> _deniedByFhlmc;
        public bool? DeniedByFhlmc { get { return _deniedByFhlmc; } set { _deniedByFhlmc = value; } }
        private Value<bool?> _deniedByFnma;
        public bool? DeniedByFnma { get { return _deniedByFnma; } set { _deniedByFnma = value; } }
        private Value<bool?> _deniedByHud;
        public bool? DeniedByHud { get { return _deniedByHud; } set { _deniedByHud = value; } }
        private Value<bool?> _deniedByOther;
        public bool? DeniedByOther { get { return _deniedByOther; } set { _deniedByOther = value; } }
        private Value<bool?> _deniedByVa;
        public bool? DeniedByVa { get { return _deniedByVa; } set { _deniedByVa = value; } }
        private Value<string> _descriptionofAccount1;
        public string DescriptionofAccount1 { get { return _descriptionofAccount1; } set { _descriptionofAccount1 = value; } }
        private Value<string> _descriptionofAccount2;
        public string DescriptionofAccount2 { get { return _descriptionofAccount2; } set { _descriptionofAccount2 = value; } }
        private Value<string> _descriptionofAccount3;
        public string DescriptionofAccount3 { get { return _descriptionofAccount3; } set { _descriptionofAccount3 = value; } }
        private Value<string> _descriptionofActionTaken1;
        public string DescriptionofActionTaken1 { get { return _descriptionofActionTaken1; } set { _descriptionofActionTaken1 = value; } }
        private Value<string> _descriptionofActionTaken2;
        public string DescriptionofActionTaken2 { get { return _descriptionofActionTaken2; } set { _descriptionofActionTaken2 = value; } }
        private Value<string> _ecoaAddress;
        public string EcoaAddress { get { return _ecoaAddress; } set { _ecoaAddress = value; } }
        private Value<string> _ecoaAddress2;
        public string EcoaAddress2 { get { return _ecoaAddress2; } set { _ecoaAddress2 = value; } }
        private Value<string> _ecoaCity;
        public string EcoaCity { get { return _ecoaCity; } set { _ecoaCity = value; } }
        private Value<string> _ecoaName;
        public string EcoaName { get { return _ecoaName; } set { _ecoaName = value; } }
        private Value<string> _ecoaPhone;
        public string EcoaPhone { get { return _ecoaPhone; } set { _ecoaPhone = value; } }
        private Value<string> _ecoaPostalCode;
        public string EcoaPostalCode { get { return _ecoaPostalCode; } set { _ecoaPostalCode = value; } }
        private Value<string> _ecoaState;
        public string EcoaState { get { return _ecoaState; } set { _ecoaState = value; } }
        private Value<bool?> _excessiveObligations;
        public bool? ExcessiveObligations { get { return _excessiveObligations; } set { _excessiveObligations = value; } }
        private Value<bool?> _garnishment;
        public bool? Garnishment { get { return _garnishment; } set { _garnishment = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _inadequateCollateral;
        public bool? InadequateCollateral { get { return _inadequateCollateral; } set { _inadequateCollateral = value; } }
        private Value<bool?> _informationFromAConsumerReportingAgency;
        public bool? InformationFromAConsumerReportingAgency { get { return _informationFromAConsumerReportingAgency; } set { _informationFromAConsumerReportingAgency = value; } }
        private Value<bool?> _informationObtainedFromOutsideSource;
        public bool? InformationObtainedFromOutsideSource { get { return _informationObtainedFromOutsideSource; } set { _informationObtainedFromOutsideSource = value; } }
        private Value<bool?> _informationObtainedInReportFromCra;
        public bool? InformationObtainedInReportFromCra { get { return _informationObtainedInReportFromCra; } set { _informationObtainedInReportFromCra = value; } }
        private Value<bool?> _insufficientCreditFile;
        public bool? InsufficientCreditFile { get { return _insufficientCreditFile; } set { _insufficientCreditFile = value; } }
        private Value<bool?> _insufficientCreditReference;
        public bool? InsufficientCreditReference { get { return _insufficientCreditReference; } set { _insufficientCreditReference = value; } }
        private Value<bool?> _insufficientData;
        public bool? InsufficientData { get { return _insufficientData; } set { _insufficientData = value; } }
        private Value<bool?> _insufficientFundsToCloseLoan;
        public bool? InsufficientFundsToCloseLoan { get { return _insufficientFundsToCloseLoan; } set { _insufficientFundsToCloseLoan = value; } }
        private Value<bool?> _insufficientIncomeForTotalObligations;
        public bool? InsufficientIncomeForTotalObligations { get { return _insufficientIncomeForTotalObligations; } set { _insufficientIncomeForTotalObligations = value; } }
        private Value<bool?> _insufficientStabilityOfIncome;
        public bool? InsufficientStabilityOfIncome { get { return _insufficientStabilityOfIncome; } set { _insufficientStabilityOfIncome = value; } }
        private Value<bool?> _lackOfCashReserves;
        public bool? LackOfCashReserves { get { return _lackOfCashReserves; } set { _lackOfCashReserves = value; } }
        private Value<string> _lenderInvestorAddress;
        public string LenderInvestorAddress { get { return _lenderInvestorAddress; } set { _lenderInvestorAddress = value; } }
        private Value<string> _lenderInvestorCity;
        public string LenderInvestorCity { get { return _lenderInvestorCity; } set { _lenderInvestorCity = value; } }
        private Value<string> _lenderInvestorName;
        public string LenderInvestorName { get { return _lenderInvestorName; } set { _lenderInvestorName = value; } }
        private Value<string> _lenderInvestorPhone;
        public string LenderInvestorPhone { get { return _lenderInvestorPhone; } set { _lenderInvestorPhone = value; } }
        private Value<string> _lenderInvestorPostalCode;
        public string LenderInvestorPostalCode { get { return _lenderInvestorPostalCode; } set { _lenderInvestorPostalCode = value; } }
        private Value<string> _lenderInvestorState;
        public string LenderInvestorState { get { return _lenderInvestorState; } set { _lenderInvestorState = value; } }
        private Value<bool?> _lengthOfEmployment;
        public bool? LengthOfEmployment { get { return _lengthOfEmployment; } set { _lengthOfEmployment = value; } }
        private Value<bool?> _noCreditFile;
        public bool? NoCreditFile { get { return _noCreditFile; } set { _noCreditFile = value; } }
        private Value<bool?> _numberRecentInquiriesCredit;
        public bool? NumberRecentInquiriesCredit { get { return _numberRecentInquiriesCredit; } set { _numberRecentInquiriesCredit = value; } }
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private Value<bool?> _poorCreditPerformance;
        public bool? PoorCreditPerformance { get { return _poorCreditPerformance; } set { _poorCreditPerformance = value; } }
        private Value<bool?> _temporaryOrIrregularEmployment;
        public bool? TemporaryOrIrregularEmployment { get { return _temporaryOrIrregularEmployment; } set { _temporaryOrIrregularEmployment = value; } }
        private Value<bool?> _temporaryResidence;
        public bool? TemporaryResidence { get { return _temporaryResidence; } set { _temporaryResidence = value; } }
        private Value<bool?> _toShortPeriodOfResidence;
        public bool? ToShortPeriodOfResidence { get { return _toShortPeriodOfResidence; } set { _toShortPeriodOfResidence = value; } }
        private Value<bool?> _unableToVerifyCreditReferences;
        public bool? UnableToVerifyCreditReferences { get { return _unableToVerifyCreditReferences; } set { _unableToVerifyCreditReferences = value; } }
        private Value<bool?> _unableToVerifyEmployment;
        public bool? UnableToVerifyEmployment { get { return _unableToVerifyEmployment; } set { _unableToVerifyEmployment = value; } }
        private Value<bool?> _unableToVerifyIncome;
        public bool? UnableToVerifyIncome { get { return _unableToVerifyIncome; } set { _unableToVerifyIncome = value; } }
        private Value<bool?> _unableToVerifyResidence;
        public bool? UnableToVerifyResidence { get { return _unableToVerifyResidence; } set { _unableToVerifyResidence = value; } }
        private Value<bool?> _unacceptableAppraisal;
        public bool? UnacceptableAppraisal { get { return _unacceptableAppraisal; } set { _unacceptableAppraisal = value; } }
        private Value<bool?> _unacceptableCreditReferencesProvided;
        public bool? UnacceptableCreditReferencesProvided { get { return _unacceptableCreditReferencesProvided; } set { _unacceptableCreditReferencesProvided = value; } }
        private Value<bool?> _unacceptableLeaseholdEstate;
        public bool? UnacceptableLeaseholdEstate { get { return _unacceptableLeaseholdEstate; } set { _unacceptableLeaseholdEstate = value; } }
        private Value<bool?> _unacceptablePaymentRecordOnPreviousMtg;
        public bool? UnacceptablePaymentRecordOnPreviousMtg { get { return _unacceptablePaymentRecordOnPreviousMtg; } set { _unacceptablePaymentRecordOnPreviousMtg = value; } }
        private Value<bool?> _unacceptableProperty;
        public bool? UnacceptableProperty { get { return _unacceptableProperty; } set { _unacceptableProperty = value; } }
        private Value<bool?> _weDoNotGrantCredit;
        public bool? WeDoNotGrantCredit { get { return _weDoNotGrantCredit; } set { _weDoNotGrantCredit = value; } }
        private Value<bool?> _withdrawnByApplicant;
        public bool? WithdrawnByApplicant { get { return _withdrawnByApplicant; } set { _withdrawnByApplicant = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalStatement.Clean
                    && _bankruptcy.Clean
                    && _collateralNotSufficient.Clean
                    && _creditApplicationIncomplete.Clean
                    && _creditReportObtainedFromConsumerReportingAgency.Clean
                    && _delinquentCreditObligations.Clean
                    && _denialDate.Clean
                    && _denialDescription.Clean
                    && _denialMailedOn.Clean
                    && _denialOther1.Clean
                    && _denialOther2.Clean
                    && _denialOtherDesc1.Clean
                    && _denialOtherDesc2.Clean
                    && _deniedBy.Clean
                    && _deniedByFhlmc.Clean
                    && _deniedByFnma.Clean
                    && _deniedByHud.Clean
                    && _deniedByOther.Clean
                    && _deniedByVa.Clean
                    && _descriptionofAccount1.Clean
                    && _descriptionofAccount2.Clean
                    && _descriptionofAccount3.Clean
                    && _descriptionofActionTaken1.Clean
                    && _descriptionofActionTaken2.Clean
                    && _ecoaAddress.Clean
                    && _ecoaAddress2.Clean
                    && _ecoaCity.Clean
                    && _ecoaName.Clean
                    && _ecoaPhone.Clean
                    && _ecoaPostalCode.Clean
                    && _ecoaState.Clean
                    && _excessiveObligations.Clean
                    && _garnishment.Clean
                    && _id.Clean
                    && _inadequateCollateral.Clean
                    && _informationFromAConsumerReportingAgency.Clean
                    && _informationObtainedFromOutsideSource.Clean
                    && _informationObtainedInReportFromCra.Clean
                    && _insufficientCreditFile.Clean
                    && _insufficientCreditReference.Clean
                    && _insufficientData.Clean
                    && _insufficientFundsToCloseLoan.Clean
                    && _insufficientIncomeForTotalObligations.Clean
                    && _insufficientStabilityOfIncome.Clean
                    && _lackOfCashReserves.Clean
                    && _lenderInvestorAddress.Clean
                    && _lenderInvestorCity.Clean
                    && _lenderInvestorName.Clean
                    && _lenderInvestorPhone.Clean
                    && _lenderInvestorPostalCode.Clean
                    && _lenderInvestorState.Clean
                    && _lengthOfEmployment.Clean
                    && _noCreditFile.Clean
                    && _numberRecentInquiriesCredit.Clean
                    && _otherDescription.Clean
                    && _poorCreditPerformance.Clean
                    && _temporaryOrIrregularEmployment.Clean
                    && _temporaryResidence.Clean
                    && _toShortPeriodOfResidence.Clean
                    && _unableToVerifyCreditReferences.Clean
                    && _unableToVerifyEmployment.Clean
                    && _unableToVerifyIncome.Clean
                    && _unableToVerifyResidence.Clean
                    && _unacceptableAppraisal.Clean
                    && _unacceptableCreditReferencesProvided.Clean
                    && _unacceptableLeaseholdEstate.Clean
                    && _unacceptablePaymentRecordOnPreviousMtg.Clean
                    && _unacceptableProperty.Clean
                    && _weDoNotGrantCredit.Clean
                    && _withdrawnByApplicant.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalStatement; v0.Clean = value; _additionalStatement = v0;
                var v1 = _bankruptcy; v1.Clean = value; _bankruptcy = v1;
                var v2 = _collateralNotSufficient; v2.Clean = value; _collateralNotSufficient = v2;
                var v3 = _creditApplicationIncomplete; v3.Clean = value; _creditApplicationIncomplete = v3;
                var v4 = _creditReportObtainedFromConsumerReportingAgency; v4.Clean = value; _creditReportObtainedFromConsumerReportingAgency = v4;
                var v5 = _delinquentCreditObligations; v5.Clean = value; _delinquentCreditObligations = v5;
                var v6 = _denialDate; v6.Clean = value; _denialDate = v6;
                var v7 = _denialDescription; v7.Clean = value; _denialDescription = v7;
                var v8 = _denialMailedOn; v8.Clean = value; _denialMailedOn = v8;
                var v9 = _denialOther1; v9.Clean = value; _denialOther1 = v9;
                var v10 = _denialOther2; v10.Clean = value; _denialOther2 = v10;
                var v11 = _denialOtherDesc1; v11.Clean = value; _denialOtherDesc1 = v11;
                var v12 = _denialOtherDesc2; v12.Clean = value; _denialOtherDesc2 = v12;
                var v13 = _deniedBy; v13.Clean = value; _deniedBy = v13;
                var v14 = _deniedByFhlmc; v14.Clean = value; _deniedByFhlmc = v14;
                var v15 = _deniedByFnma; v15.Clean = value; _deniedByFnma = v15;
                var v16 = _deniedByHud; v16.Clean = value; _deniedByHud = v16;
                var v17 = _deniedByOther; v17.Clean = value; _deniedByOther = v17;
                var v18 = _deniedByVa; v18.Clean = value; _deniedByVa = v18;
                var v19 = _descriptionofAccount1; v19.Clean = value; _descriptionofAccount1 = v19;
                var v20 = _descriptionofAccount2; v20.Clean = value; _descriptionofAccount2 = v20;
                var v21 = _descriptionofAccount3; v21.Clean = value; _descriptionofAccount3 = v21;
                var v22 = _descriptionofActionTaken1; v22.Clean = value; _descriptionofActionTaken1 = v22;
                var v23 = _descriptionofActionTaken2; v23.Clean = value; _descriptionofActionTaken2 = v23;
                var v24 = _ecoaAddress; v24.Clean = value; _ecoaAddress = v24;
                var v25 = _ecoaAddress2; v25.Clean = value; _ecoaAddress2 = v25;
                var v26 = _ecoaCity; v26.Clean = value; _ecoaCity = v26;
                var v27 = _ecoaName; v27.Clean = value; _ecoaName = v27;
                var v28 = _ecoaPhone; v28.Clean = value; _ecoaPhone = v28;
                var v29 = _ecoaPostalCode; v29.Clean = value; _ecoaPostalCode = v29;
                var v30 = _ecoaState; v30.Clean = value; _ecoaState = v30;
                var v31 = _excessiveObligations; v31.Clean = value; _excessiveObligations = v31;
                var v32 = _garnishment; v32.Clean = value; _garnishment = v32;
                var v33 = _id; v33.Clean = value; _id = v33;
                var v34 = _inadequateCollateral; v34.Clean = value; _inadequateCollateral = v34;
                var v35 = _informationFromAConsumerReportingAgency; v35.Clean = value; _informationFromAConsumerReportingAgency = v35;
                var v36 = _informationObtainedFromOutsideSource; v36.Clean = value; _informationObtainedFromOutsideSource = v36;
                var v37 = _informationObtainedInReportFromCra; v37.Clean = value; _informationObtainedInReportFromCra = v37;
                var v38 = _insufficientCreditFile; v38.Clean = value; _insufficientCreditFile = v38;
                var v39 = _insufficientCreditReference; v39.Clean = value; _insufficientCreditReference = v39;
                var v40 = _insufficientData; v40.Clean = value; _insufficientData = v40;
                var v41 = _insufficientFundsToCloseLoan; v41.Clean = value; _insufficientFundsToCloseLoan = v41;
                var v42 = _insufficientIncomeForTotalObligations; v42.Clean = value; _insufficientIncomeForTotalObligations = v42;
                var v43 = _insufficientStabilityOfIncome; v43.Clean = value; _insufficientStabilityOfIncome = v43;
                var v44 = _lackOfCashReserves; v44.Clean = value; _lackOfCashReserves = v44;
                var v45 = _lenderInvestorAddress; v45.Clean = value; _lenderInvestorAddress = v45;
                var v46 = _lenderInvestorCity; v46.Clean = value; _lenderInvestorCity = v46;
                var v47 = _lenderInvestorName; v47.Clean = value; _lenderInvestorName = v47;
                var v48 = _lenderInvestorPhone; v48.Clean = value; _lenderInvestorPhone = v48;
                var v49 = _lenderInvestorPostalCode; v49.Clean = value; _lenderInvestorPostalCode = v49;
                var v50 = _lenderInvestorState; v50.Clean = value; _lenderInvestorState = v50;
                var v51 = _lengthOfEmployment; v51.Clean = value; _lengthOfEmployment = v51;
                var v52 = _noCreditFile; v52.Clean = value; _noCreditFile = v52;
                var v53 = _numberRecentInquiriesCredit; v53.Clean = value; _numberRecentInquiriesCredit = v53;
                var v54 = _otherDescription; v54.Clean = value; _otherDescription = v54;
                var v55 = _poorCreditPerformance; v55.Clean = value; _poorCreditPerformance = v55;
                var v56 = _temporaryOrIrregularEmployment; v56.Clean = value; _temporaryOrIrregularEmployment = v56;
                var v57 = _temporaryResidence; v57.Clean = value; _temporaryResidence = v57;
                var v58 = _toShortPeriodOfResidence; v58.Clean = value; _toShortPeriodOfResidence = v58;
                var v59 = _unableToVerifyCreditReferences; v59.Clean = value; _unableToVerifyCreditReferences = v59;
                var v60 = _unableToVerifyEmployment; v60.Clean = value; _unableToVerifyEmployment = v60;
                var v61 = _unableToVerifyIncome; v61.Clean = value; _unableToVerifyIncome = v61;
                var v62 = _unableToVerifyResidence; v62.Clean = value; _unableToVerifyResidence = v62;
                var v63 = _unacceptableAppraisal; v63.Clean = value; _unacceptableAppraisal = v63;
                var v64 = _unacceptableCreditReferencesProvided; v64.Clean = value; _unacceptableCreditReferencesProvided = v64;
                var v65 = _unacceptableLeaseholdEstate; v65.Clean = value; _unacceptableLeaseholdEstate = v65;
                var v66 = _unacceptablePaymentRecordOnPreviousMtg; v66.Clean = value; _unacceptablePaymentRecordOnPreviousMtg = v66;
                var v67 = _unacceptableProperty; v67.Clean = value; _unacceptableProperty = v67;
                var v68 = _weDoNotGrantCredit; v68.Clean = value; _weDoNotGrantCredit = v68;
                var v69 = _withdrawnByApplicant; v69.Clean = value; _withdrawnByApplicant = v69;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}