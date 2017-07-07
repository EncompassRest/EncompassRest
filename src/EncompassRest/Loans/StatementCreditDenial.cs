using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var additionalStatement = _additionalStatement; additionalStatement.Clean = value; _additionalStatement = additionalStatement;
                var bankruptcy = _bankruptcy; bankruptcy.Clean = value; _bankruptcy = bankruptcy;
                var collateralNotSufficient = _collateralNotSufficient; collateralNotSufficient.Clean = value; _collateralNotSufficient = collateralNotSufficient;
                var creditApplicationIncomplete = _creditApplicationIncomplete; creditApplicationIncomplete.Clean = value; _creditApplicationIncomplete = creditApplicationIncomplete;
                var creditReportObtainedFromConsumerReportingAgency = _creditReportObtainedFromConsumerReportingAgency; creditReportObtainedFromConsumerReportingAgency.Clean = value; _creditReportObtainedFromConsumerReportingAgency = creditReportObtainedFromConsumerReportingAgency;
                var delinquentCreditObligations = _delinquentCreditObligations; delinquentCreditObligations.Clean = value; _delinquentCreditObligations = delinquentCreditObligations;
                var denialDate = _denialDate; denialDate.Clean = value; _denialDate = denialDate;
                var denialDescription = _denialDescription; denialDescription.Clean = value; _denialDescription = denialDescription;
                var denialMailedOn = _denialMailedOn; denialMailedOn.Clean = value; _denialMailedOn = denialMailedOn;
                var denialOther1 = _denialOther1; denialOther1.Clean = value; _denialOther1 = denialOther1;
                var denialOther2 = _denialOther2; denialOther2.Clean = value; _denialOther2 = denialOther2;
                var denialOtherDesc1 = _denialOtherDesc1; denialOtherDesc1.Clean = value; _denialOtherDesc1 = denialOtherDesc1;
                var denialOtherDesc2 = _denialOtherDesc2; denialOtherDesc2.Clean = value; _denialOtherDesc2 = denialOtherDesc2;
                var deniedBy = _deniedBy; deniedBy.Clean = value; _deniedBy = deniedBy;
                var deniedByFhlmc = _deniedByFhlmc; deniedByFhlmc.Clean = value; _deniedByFhlmc = deniedByFhlmc;
                var deniedByFnma = _deniedByFnma; deniedByFnma.Clean = value; _deniedByFnma = deniedByFnma;
                var deniedByHud = _deniedByHud; deniedByHud.Clean = value; _deniedByHud = deniedByHud;
                var deniedByOther = _deniedByOther; deniedByOther.Clean = value; _deniedByOther = deniedByOther;
                var deniedByVa = _deniedByVa; deniedByVa.Clean = value; _deniedByVa = deniedByVa;
                var descriptionofAccount1 = _descriptionofAccount1; descriptionofAccount1.Clean = value; _descriptionofAccount1 = descriptionofAccount1;
                var descriptionofAccount2 = _descriptionofAccount2; descriptionofAccount2.Clean = value; _descriptionofAccount2 = descriptionofAccount2;
                var descriptionofAccount3 = _descriptionofAccount3; descriptionofAccount3.Clean = value; _descriptionofAccount3 = descriptionofAccount3;
                var descriptionofActionTaken1 = _descriptionofActionTaken1; descriptionofActionTaken1.Clean = value; _descriptionofActionTaken1 = descriptionofActionTaken1;
                var descriptionofActionTaken2 = _descriptionofActionTaken2; descriptionofActionTaken2.Clean = value; _descriptionofActionTaken2 = descriptionofActionTaken2;
                var ecoaAddress = _ecoaAddress; ecoaAddress.Clean = value; _ecoaAddress = ecoaAddress;
                var ecoaAddress2 = _ecoaAddress2; ecoaAddress2.Clean = value; _ecoaAddress2 = ecoaAddress2;
                var ecoaCity = _ecoaCity; ecoaCity.Clean = value; _ecoaCity = ecoaCity;
                var ecoaName = _ecoaName; ecoaName.Clean = value; _ecoaName = ecoaName;
                var ecoaPhone = _ecoaPhone; ecoaPhone.Clean = value; _ecoaPhone = ecoaPhone;
                var ecoaPostalCode = _ecoaPostalCode; ecoaPostalCode.Clean = value; _ecoaPostalCode = ecoaPostalCode;
                var ecoaState = _ecoaState; ecoaState.Clean = value; _ecoaState = ecoaState;
                var excessiveObligations = _excessiveObligations; excessiveObligations.Clean = value; _excessiveObligations = excessiveObligations;
                var garnishment = _garnishment; garnishment.Clean = value; _garnishment = garnishment;
                var id = _id; id.Clean = value; _id = id;
                var inadequateCollateral = _inadequateCollateral; inadequateCollateral.Clean = value; _inadequateCollateral = inadequateCollateral;
                var informationFromAConsumerReportingAgency = _informationFromAConsumerReportingAgency; informationFromAConsumerReportingAgency.Clean = value; _informationFromAConsumerReportingAgency = informationFromAConsumerReportingAgency;
                var informationObtainedFromOutsideSource = _informationObtainedFromOutsideSource; informationObtainedFromOutsideSource.Clean = value; _informationObtainedFromOutsideSource = informationObtainedFromOutsideSource;
                var informationObtainedInReportFromCra = _informationObtainedInReportFromCra; informationObtainedInReportFromCra.Clean = value; _informationObtainedInReportFromCra = informationObtainedInReportFromCra;
                var insufficientCreditFile = _insufficientCreditFile; insufficientCreditFile.Clean = value; _insufficientCreditFile = insufficientCreditFile;
                var insufficientCreditReference = _insufficientCreditReference; insufficientCreditReference.Clean = value; _insufficientCreditReference = insufficientCreditReference;
                var insufficientData = _insufficientData; insufficientData.Clean = value; _insufficientData = insufficientData;
                var insufficientFundsToCloseLoan = _insufficientFundsToCloseLoan; insufficientFundsToCloseLoan.Clean = value; _insufficientFundsToCloseLoan = insufficientFundsToCloseLoan;
                var insufficientIncomeForTotalObligations = _insufficientIncomeForTotalObligations; insufficientIncomeForTotalObligations.Clean = value; _insufficientIncomeForTotalObligations = insufficientIncomeForTotalObligations;
                var insufficientStabilityOfIncome = _insufficientStabilityOfIncome; insufficientStabilityOfIncome.Clean = value; _insufficientStabilityOfIncome = insufficientStabilityOfIncome;
                var lackOfCashReserves = _lackOfCashReserves; lackOfCashReserves.Clean = value; _lackOfCashReserves = lackOfCashReserves;
                var lenderInvestorAddress = _lenderInvestorAddress; lenderInvestorAddress.Clean = value; _lenderInvestorAddress = lenderInvestorAddress;
                var lenderInvestorCity = _lenderInvestorCity; lenderInvestorCity.Clean = value; _lenderInvestorCity = lenderInvestorCity;
                var lenderInvestorName = _lenderInvestorName; lenderInvestorName.Clean = value; _lenderInvestorName = lenderInvestorName;
                var lenderInvestorPhone = _lenderInvestorPhone; lenderInvestorPhone.Clean = value; _lenderInvestorPhone = lenderInvestorPhone;
                var lenderInvestorPostalCode = _lenderInvestorPostalCode; lenderInvestorPostalCode.Clean = value; _lenderInvestorPostalCode = lenderInvestorPostalCode;
                var lenderInvestorState = _lenderInvestorState; lenderInvestorState.Clean = value; _lenderInvestorState = lenderInvestorState;
                var lengthOfEmployment = _lengthOfEmployment; lengthOfEmployment.Clean = value; _lengthOfEmployment = lengthOfEmployment;
                var noCreditFile = _noCreditFile; noCreditFile.Clean = value; _noCreditFile = noCreditFile;
                var numberRecentInquiriesCredit = _numberRecentInquiriesCredit; numberRecentInquiriesCredit.Clean = value; _numberRecentInquiriesCredit = numberRecentInquiriesCredit;
                var otherDescription = _otherDescription; otherDescription.Clean = value; _otherDescription = otherDescription;
                var poorCreditPerformance = _poorCreditPerformance; poorCreditPerformance.Clean = value; _poorCreditPerformance = poorCreditPerformance;
                var temporaryOrIrregularEmployment = _temporaryOrIrregularEmployment; temporaryOrIrregularEmployment.Clean = value; _temporaryOrIrregularEmployment = temporaryOrIrregularEmployment;
                var temporaryResidence = _temporaryResidence; temporaryResidence.Clean = value; _temporaryResidence = temporaryResidence;
                var toShortPeriodOfResidence = _toShortPeriodOfResidence; toShortPeriodOfResidence.Clean = value; _toShortPeriodOfResidence = toShortPeriodOfResidence;
                var unableToVerifyCreditReferences = _unableToVerifyCreditReferences; unableToVerifyCreditReferences.Clean = value; _unableToVerifyCreditReferences = unableToVerifyCreditReferences;
                var unableToVerifyEmployment = _unableToVerifyEmployment; unableToVerifyEmployment.Clean = value; _unableToVerifyEmployment = unableToVerifyEmployment;
                var unableToVerifyIncome = _unableToVerifyIncome; unableToVerifyIncome.Clean = value; _unableToVerifyIncome = unableToVerifyIncome;
                var unableToVerifyResidence = _unableToVerifyResidence; unableToVerifyResidence.Clean = value; _unableToVerifyResidence = unableToVerifyResidence;
                var unacceptableAppraisal = _unacceptableAppraisal; unacceptableAppraisal.Clean = value; _unacceptableAppraisal = unacceptableAppraisal;
                var unacceptableCreditReferencesProvided = _unacceptableCreditReferencesProvided; unacceptableCreditReferencesProvided.Clean = value; _unacceptableCreditReferencesProvided = unacceptableCreditReferencesProvided;
                var unacceptableLeaseholdEstate = _unacceptableLeaseholdEstate; unacceptableLeaseholdEstate.Clean = value; _unacceptableLeaseholdEstate = unacceptableLeaseholdEstate;
                var unacceptablePaymentRecordOnPreviousMtg = _unacceptablePaymentRecordOnPreviousMtg; unacceptablePaymentRecordOnPreviousMtg.Clean = value; _unacceptablePaymentRecordOnPreviousMtg = unacceptablePaymentRecordOnPreviousMtg;
                var unacceptableProperty = _unacceptableProperty; unacceptableProperty.Clean = value; _unacceptableProperty = unacceptableProperty;
                var weDoNotGrantCredit = _weDoNotGrantCredit; weDoNotGrantCredit.Clean = value; _weDoNotGrantCredit = weDoNotGrantCredit;
                var withdrawnByApplicant = _withdrawnByApplicant; withdrawnByApplicant.Clean = value; _withdrawnByApplicant = withdrawnByApplicant;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public StatementCreditDenial()
        {
            Clean = true;
        }
    }
}