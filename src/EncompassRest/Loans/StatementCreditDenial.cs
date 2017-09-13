using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StatementCreditDenial : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _additionalStatement.Dirty
                    || _bankruptcy.Dirty
                    || _collateralNotSufficient.Dirty
                    || _creditApplicationIncomplete.Dirty
                    || _creditReportObtainedFromConsumerReportingAgency.Dirty
                    || _delinquentCreditObligations.Dirty
                    || _denialDate.Dirty
                    || _denialDescription.Dirty
                    || _denialMailedOn.Dirty
                    || _denialOther1.Dirty
                    || _denialOther2.Dirty
                    || _denialOtherDesc1.Dirty
                    || _denialOtherDesc2.Dirty
                    || _deniedBy.Dirty
                    || _deniedByFhlmc.Dirty
                    || _deniedByFnma.Dirty
                    || _deniedByHud.Dirty
                    || _deniedByOther.Dirty
                    || _deniedByVa.Dirty
                    || _descriptionofAccount1.Dirty
                    || _descriptionofAccount2.Dirty
                    || _descriptionofAccount3.Dirty
                    || _descriptionofActionTaken1.Dirty
                    || _descriptionofActionTaken2.Dirty
                    || _ecoaAddress.Dirty
                    || _ecoaAddress2.Dirty
                    || _ecoaCity.Dirty
                    || _ecoaName.Dirty
                    || _ecoaPhone.Dirty
                    || _ecoaPostalCode.Dirty
                    || _ecoaState.Dirty
                    || _excessiveObligations.Dirty
                    || _garnishment.Dirty
                    || _id.Dirty
                    || _inadequateCollateral.Dirty
                    || _informationFromAConsumerReportingAgency.Dirty
                    || _informationObtainedFromOutsideSource.Dirty
                    || _informationObtainedInReportFromCra.Dirty
                    || _insufficientCreditFile.Dirty
                    || _insufficientCreditReference.Dirty
                    || _insufficientData.Dirty
                    || _insufficientFundsToCloseLoan.Dirty
                    || _insufficientIncomeForTotalObligations.Dirty
                    || _insufficientStabilityOfIncome.Dirty
                    || _lackOfCashReserves.Dirty
                    || _lenderInvestorAddress.Dirty
                    || _lenderInvestorCity.Dirty
                    || _lenderInvestorName.Dirty
                    || _lenderInvestorPhone.Dirty
                    || _lenderInvestorPostalCode.Dirty
                    || _lenderInvestorState.Dirty
                    || _lengthOfEmployment.Dirty
                    || _noCreditFile.Dirty
                    || _numberRecentInquiriesCredit.Dirty
                    || _otherDescription.Dirty
                    || _poorCreditPerformance.Dirty
                    || _temporaryOrIrregularEmployment.Dirty
                    || _temporaryResidence.Dirty
                    || _toShortPeriodOfResidence.Dirty
                    || _unableToVerifyCreditReferences.Dirty
                    || _unableToVerifyEmployment.Dirty
                    || _unableToVerifyIncome.Dirty
                    || _unableToVerifyResidence.Dirty
                    || _unacceptableAppraisal.Dirty
                    || _unacceptableCreditReferencesProvided.Dirty
                    || _unacceptableLeaseholdEstate.Dirty
                    || _unacceptablePaymentRecordOnPreviousMtg.Dirty
                    || _unacceptableProperty.Dirty
                    || _weDoNotGrantCredit.Dirty
                    || _withdrawnByApplicant.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _additionalStatement.Dirty = value;
                _bankruptcy.Dirty = value;
                _collateralNotSufficient.Dirty = value;
                _creditApplicationIncomplete.Dirty = value;
                _creditReportObtainedFromConsumerReportingAgency.Dirty = value;
                _delinquentCreditObligations.Dirty = value;
                _denialDate.Dirty = value;
                _denialDescription.Dirty = value;
                _denialMailedOn.Dirty = value;
                _denialOther1.Dirty = value;
                _denialOther2.Dirty = value;
                _denialOtherDesc1.Dirty = value;
                _denialOtherDesc2.Dirty = value;
                _deniedBy.Dirty = value;
                _deniedByFhlmc.Dirty = value;
                _deniedByFnma.Dirty = value;
                _deniedByHud.Dirty = value;
                _deniedByOther.Dirty = value;
                _deniedByVa.Dirty = value;
                _descriptionofAccount1.Dirty = value;
                _descriptionofAccount2.Dirty = value;
                _descriptionofAccount3.Dirty = value;
                _descriptionofActionTaken1.Dirty = value;
                _descriptionofActionTaken2.Dirty = value;
                _ecoaAddress.Dirty = value;
                _ecoaAddress2.Dirty = value;
                _ecoaCity.Dirty = value;
                _ecoaName.Dirty = value;
                _ecoaPhone.Dirty = value;
                _ecoaPostalCode.Dirty = value;
                _ecoaState.Dirty = value;
                _excessiveObligations.Dirty = value;
                _garnishment.Dirty = value;
                _id.Dirty = value;
                _inadequateCollateral.Dirty = value;
                _informationFromAConsumerReportingAgency.Dirty = value;
                _informationObtainedFromOutsideSource.Dirty = value;
                _informationObtainedInReportFromCra.Dirty = value;
                _insufficientCreditFile.Dirty = value;
                _insufficientCreditReference.Dirty = value;
                _insufficientData.Dirty = value;
                _insufficientFundsToCloseLoan.Dirty = value;
                _insufficientIncomeForTotalObligations.Dirty = value;
                _insufficientStabilityOfIncome.Dirty = value;
                _lackOfCashReserves.Dirty = value;
                _lenderInvestorAddress.Dirty = value;
                _lenderInvestorCity.Dirty = value;
                _lenderInvestorName.Dirty = value;
                _lenderInvestorPhone.Dirty = value;
                _lenderInvestorPostalCode.Dirty = value;
                _lenderInvestorState.Dirty = value;
                _lengthOfEmployment.Dirty = value;
                _noCreditFile.Dirty = value;
                _numberRecentInquiriesCredit.Dirty = value;
                _otherDescription.Dirty = value;
                _poorCreditPerformance.Dirty = value;
                _temporaryOrIrregularEmployment.Dirty = value;
                _temporaryResidence.Dirty = value;
                _toShortPeriodOfResidence.Dirty = value;
                _unableToVerifyCreditReferences.Dirty = value;
                _unableToVerifyEmployment.Dirty = value;
                _unableToVerifyIncome.Dirty = value;
                _unableToVerifyResidence.Dirty = value;
                _unacceptableAppraisal.Dirty = value;
                _unacceptableCreditReferencesProvided.Dirty = value;
                _unacceptableLeaseholdEstate.Dirty = value;
                _unacceptablePaymentRecordOnPreviousMtg.Dirty = value;
                _unacceptableProperty.Dirty = value;
                _weDoNotGrantCredit.Dirty = value;
                _withdrawnByApplicant.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}