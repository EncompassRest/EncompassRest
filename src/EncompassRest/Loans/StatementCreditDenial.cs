using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class StatementCreditDenial : IDirty
    {
        private DirtyValue<bool?> _additionalStatement;
        public bool? AdditionalStatement { get => _additionalStatement; set => _additionalStatement = value; }
        private DirtyValue<bool?> _bankruptcy;
        public bool? Bankruptcy { get => _bankruptcy; set => _bankruptcy = value; }
        private DirtyValue<bool?> _collateralNotSufficient;
        public bool? CollateralNotSufficient { get => _collateralNotSufficient; set => _collateralNotSufficient = value; }
        private DirtyValue<bool?> _creditApplicationIncomplete;
        public bool? CreditApplicationIncomplete { get => _creditApplicationIncomplete; set => _creditApplicationIncomplete = value; }
        private DirtyValue<bool?> _creditReportObtainedFromConsumerReportingAgency;
        public bool? CreditReportObtainedFromConsumerReportingAgency { get => _creditReportObtainedFromConsumerReportingAgency; set => _creditReportObtainedFromConsumerReportingAgency = value; }
        private DirtyValue<bool?> _delinquentCreditObligations;
        public bool? DelinquentCreditObligations { get => _delinquentCreditObligations; set => _delinquentCreditObligations = value; }
        private DirtyValue<DateTime?> _denialDate;
        public DateTime? DenialDate { get => _denialDate; set => _denialDate = value; }
        private DirtyValue<string> _denialDescription;
        public string DenialDescription { get => _denialDescription; set => _denialDescription = value; }
        private DirtyValue<DateTime?> _denialMailedOn;
        public DateTime? DenialMailedOn { get => _denialMailedOn; set => _denialMailedOn = value; }
        private DirtyValue<bool?> _denialOther1;
        public bool? DenialOther1 { get => _denialOther1; set => _denialOther1 = value; }
        private DirtyValue<bool?> _denialOther2;
        public bool? DenialOther2 { get => _denialOther2; set => _denialOther2 = value; }
        private DirtyValue<string> _denialOtherDesc1;
        public string DenialOtherDesc1 { get => _denialOtherDesc1; set => _denialOtherDesc1 = value; }
        private DirtyValue<string> _denialOtherDesc2;
        public string DenialOtherDesc2 { get => _denialOtherDesc2; set => _denialOtherDesc2 = value; }
        private DirtyValue<string> _deniedBy;
        public string DeniedBy { get => _deniedBy; set => _deniedBy = value; }
        private DirtyValue<bool?> _deniedByFhlmc;
        public bool? DeniedByFhlmc { get => _deniedByFhlmc; set => _deniedByFhlmc = value; }
        private DirtyValue<bool?> _deniedByFnma;
        public bool? DeniedByFnma { get => _deniedByFnma; set => _deniedByFnma = value; }
        private DirtyValue<bool?> _deniedByHud;
        public bool? DeniedByHud { get => _deniedByHud; set => _deniedByHud = value; }
        private DirtyValue<bool?> _deniedByOther;
        public bool? DeniedByOther { get => _deniedByOther; set => _deniedByOther = value; }
        private DirtyValue<bool?> _deniedByVa;
        public bool? DeniedByVa { get => _deniedByVa; set => _deniedByVa = value; }
        private DirtyValue<string> _descriptionofAccount1;
        public string DescriptionofAccount1 { get => _descriptionofAccount1; set => _descriptionofAccount1 = value; }
        private DirtyValue<string> _descriptionofAccount2;
        public string DescriptionofAccount2 { get => _descriptionofAccount2; set => _descriptionofAccount2 = value; }
        private DirtyValue<string> _descriptionofAccount3;
        public string DescriptionofAccount3 { get => _descriptionofAccount3; set => _descriptionofAccount3 = value; }
        private DirtyValue<string> _descriptionofActionTaken1;
        public string DescriptionofActionTaken1 { get => _descriptionofActionTaken1; set => _descriptionofActionTaken1 = value; }
        private DirtyValue<string> _descriptionofActionTaken2;
        public string DescriptionofActionTaken2 { get => _descriptionofActionTaken2; set => _descriptionofActionTaken2 = value; }
        private DirtyValue<string> _ecoaAddress;
        public string EcoaAddress { get => _ecoaAddress; set => _ecoaAddress = value; }
        private DirtyValue<string> _ecoaAddress2;
        public string EcoaAddress2 { get => _ecoaAddress2; set => _ecoaAddress2 = value; }
        private DirtyValue<string> _ecoaCity;
        public string EcoaCity { get => _ecoaCity; set => _ecoaCity = value; }
        private DirtyValue<string> _ecoaName;
        public string EcoaName { get => _ecoaName; set => _ecoaName = value; }
        private DirtyValue<string> _ecoaPhone;
        public string EcoaPhone { get => _ecoaPhone; set => _ecoaPhone = value; }
        private DirtyValue<string> _ecoaPostalCode;
        public string EcoaPostalCode { get => _ecoaPostalCode; set => _ecoaPostalCode = value; }
        private DirtyValue<string> _ecoaState;
        public string EcoaState { get => _ecoaState; set => _ecoaState = value; }
        private DirtyValue<bool?> _excessiveObligations;
        public bool? ExcessiveObligations { get => _excessiveObligations; set => _excessiveObligations = value; }
        private DirtyValue<bool?> _garnishment;
        public bool? Garnishment { get => _garnishment; set => _garnishment = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _inadequateCollateral;
        public bool? InadequateCollateral { get => _inadequateCollateral; set => _inadequateCollateral = value; }
        private DirtyValue<bool?> _informationFromAConsumerReportingAgency;
        public bool? InformationFromAConsumerReportingAgency { get => _informationFromAConsumerReportingAgency; set => _informationFromAConsumerReportingAgency = value; }
        private DirtyValue<bool?> _informationObtainedFromOutsideSource;
        public bool? InformationObtainedFromOutsideSource { get => _informationObtainedFromOutsideSource; set => _informationObtainedFromOutsideSource = value; }
        private DirtyValue<bool?> _informationObtainedInReportFromCra;
        public bool? InformationObtainedInReportFromCra { get => _informationObtainedInReportFromCra; set => _informationObtainedInReportFromCra = value; }
        private DirtyValue<bool?> _insufficientCreditFile;
        public bool? InsufficientCreditFile { get => _insufficientCreditFile; set => _insufficientCreditFile = value; }
        private DirtyValue<bool?> _insufficientCreditReference;
        public bool? InsufficientCreditReference { get => _insufficientCreditReference; set => _insufficientCreditReference = value; }
        private DirtyValue<bool?> _insufficientData;
        public bool? InsufficientData { get => _insufficientData; set => _insufficientData = value; }
        private DirtyValue<bool?> _insufficientFundsToCloseLoan;
        public bool? InsufficientFundsToCloseLoan { get => _insufficientFundsToCloseLoan; set => _insufficientFundsToCloseLoan = value; }
        private DirtyValue<bool?> _insufficientIncomeForTotalObligations;
        public bool? InsufficientIncomeForTotalObligations { get => _insufficientIncomeForTotalObligations; set => _insufficientIncomeForTotalObligations = value; }
        private DirtyValue<bool?> _insufficientStabilityOfIncome;
        public bool? InsufficientStabilityOfIncome { get => _insufficientStabilityOfIncome; set => _insufficientStabilityOfIncome = value; }
        private DirtyValue<bool?> _lackOfCashReserves;
        public bool? LackOfCashReserves { get => _lackOfCashReserves; set => _lackOfCashReserves = value; }
        private DirtyValue<string> _lenderInvestorAddress;
        public string LenderInvestorAddress { get => _lenderInvestorAddress; set => _lenderInvestorAddress = value; }
        private DirtyValue<string> _lenderInvestorCity;
        public string LenderInvestorCity { get => _lenderInvestorCity; set => _lenderInvestorCity = value; }
        private DirtyValue<string> _lenderInvestorName;
        public string LenderInvestorName { get => _lenderInvestorName; set => _lenderInvestorName = value; }
        private DirtyValue<string> _lenderInvestorPhone;
        public string LenderInvestorPhone { get => _lenderInvestorPhone; set => _lenderInvestorPhone = value; }
        private DirtyValue<string> _lenderInvestorPostalCode;
        public string LenderInvestorPostalCode { get => _lenderInvestorPostalCode; set => _lenderInvestorPostalCode = value; }
        private DirtyValue<string> _lenderInvestorState;
        public string LenderInvestorState { get => _lenderInvestorState; set => _lenderInvestorState = value; }
        private DirtyValue<bool?> _lengthOfEmployment;
        public bool? LengthOfEmployment { get => _lengthOfEmployment; set => _lengthOfEmployment = value; }
        private DirtyValue<bool?> _noCreditFile;
        public bool? NoCreditFile { get => _noCreditFile; set => _noCreditFile = value; }
        private DirtyValue<bool?> _numberRecentInquiriesCredit;
        public bool? NumberRecentInquiriesCredit { get => _numberRecentInquiriesCredit; set => _numberRecentInquiriesCredit = value; }
        private DirtyValue<string> _otherDescription;
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _poorCreditPerformance;
        public bool? PoorCreditPerformance { get => _poorCreditPerformance; set => _poorCreditPerformance = value; }
        private DirtyValue<bool?> _temporaryOrIrregularEmployment;
        public bool? TemporaryOrIrregularEmployment { get => _temporaryOrIrregularEmployment; set => _temporaryOrIrregularEmployment = value; }
        private DirtyValue<bool?> _temporaryResidence;
        public bool? TemporaryResidence { get => _temporaryResidence; set => _temporaryResidence = value; }
        private DirtyValue<bool?> _toShortPeriodOfResidence;
        public bool? ToShortPeriodOfResidence { get => _toShortPeriodOfResidence; set => _toShortPeriodOfResidence = value; }
        private DirtyValue<bool?> _unableToVerifyCreditReferences;
        public bool? UnableToVerifyCreditReferences { get => _unableToVerifyCreditReferences; set => _unableToVerifyCreditReferences = value; }
        private DirtyValue<bool?> _unableToVerifyEmployment;
        public bool? UnableToVerifyEmployment { get => _unableToVerifyEmployment; set => _unableToVerifyEmployment = value; }
        private DirtyValue<bool?> _unableToVerifyIncome;
        public bool? UnableToVerifyIncome { get => _unableToVerifyIncome; set => _unableToVerifyIncome = value; }
        private DirtyValue<bool?> _unableToVerifyResidence;
        public bool? UnableToVerifyResidence { get => _unableToVerifyResidence; set => _unableToVerifyResidence = value; }
        private DirtyValue<bool?> _unacceptableAppraisal;
        public bool? UnacceptableAppraisal { get => _unacceptableAppraisal; set => _unacceptableAppraisal = value; }
        private DirtyValue<bool?> _unacceptableCreditReferencesProvided;
        public bool? UnacceptableCreditReferencesProvided { get => _unacceptableCreditReferencesProvided; set => _unacceptableCreditReferencesProvided = value; }
        private DirtyValue<bool?> _unacceptableLeaseholdEstate;
        public bool? UnacceptableLeaseholdEstate { get => _unacceptableLeaseholdEstate; set => _unacceptableLeaseholdEstate = value; }
        private DirtyValue<bool?> _unacceptablePaymentRecordOnPreviousMtg;
        public bool? UnacceptablePaymentRecordOnPreviousMtg { get => _unacceptablePaymentRecordOnPreviousMtg; set => _unacceptablePaymentRecordOnPreviousMtg = value; }
        private DirtyValue<bool?> _unacceptableProperty;
        public bool? UnacceptableProperty { get => _unacceptableProperty; set => _unacceptableProperty = value; }
        private DirtyValue<bool?> _weDoNotGrantCredit;
        public bool? WeDoNotGrantCredit { get => _weDoNotGrantCredit; set => _weDoNotGrantCredit = value; }
        private DirtyValue<bool?> _withdrawnByApplicant;
        public bool? WithdrawnByApplicant { get => _withdrawnByApplicant; set => _withdrawnByApplicant = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
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
                    || _withdrawnByApplicant.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}