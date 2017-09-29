using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StateDisclosure : IDirty
    {
        private DirtyValue<bool?> _acceptedByBorrowerIndicator;
        public bool? AcceptedByBorrowerIndicator { get { return _acceptedByBorrowerIndicator; } set { _acceptedByBorrowerIndicator = value; } }
        private DirtyValue<DateTime?> _acceptedDate;
        public DateTime? AcceptedDate { get { return _acceptedDate; } set { _acceptedDate = value; } }
        private DirtyValue<string> _actingOtherDescription1;
        public string ActingOtherDescription1 { get { return _actingOtherDescription1; } set { _actingOtherDescription1 = value; } }
        private DirtyValue<string> _actingOtherDescription2;
        public string ActingOtherDescription2 { get { return _actingOtherDescription2; } set { _actingOtherDescription2 = value; } }
        private DirtyValue<bool?> _actingOthersIndicator;
        public bool? ActingOthersIndicator { get { return _actingOthersIndicator; } set { _actingOthersIndicator = value; } }
        private DirtyValue<int?> _advFeeAgmtInEfctNumDay;
        public int? AdvFeeAgmtInEfctNumDay { get { return _advFeeAgmtInEfctNumDay; } set { _advFeeAgmtInEfctNumDay = value; } }
        private DirtyValue<string> _advisoryCondition1;
        public string AdvisoryCondition1 { get { return _advisoryCondition1; } set { _advisoryCondition1 = value; } }
        private DirtyValue<string> _advisoryCondition2;
        public string AdvisoryCondition2 { get { return _advisoryCondition2; } set { _advisoryCondition2 = value; } }
        private DirtyValue<string> _advisoryCondition3;
        public string AdvisoryCondition3 { get { return _advisoryCondition3; } set { _advisoryCondition3 = value; } }
        private DirtyValue<string> _advisoryCondition4;
        public string AdvisoryCondition4 { get { return _advisoryCondition4; } set { _advisoryCondition4 = value; } }
        private DirtyValue<decimal?> _amendedAcquisitionCost;
        public decimal? AmendedAcquisitionCost { get { return _amendedAcquisitionCost; } set { _amendedAcquisitionCost = value; } }
        private DirtyValue<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private DirtyValue<string> _appraisalContact;
        public string AppraisalContact { get { return _appraisalContact; } set { _appraisalContact = value; } }
        private DirtyValue<decimal?> _appraisalDeposit;
        public decimal? AppraisalDeposit { get { return _appraisalDeposit; } set { _appraisalDeposit = value; } }
        private DirtyValue<string> _areas;
        public string Areas { get { return _areas; } set { _areas = value; } }
        private DirtyValue<bool?> _asAttorneyIndicator;
        public bool? AsAttorneyIndicator { get { return _asAttorneyIndicator; } set { _asAttorneyIndicator = value; } }
        private DirtyValue<bool?> _asRealBrokerIndicator;
        public bool? AsRealBrokerIndicator { get { return _asRealBrokerIndicator; } set { _asRealBrokerIndicator = value; } }
        private DirtyValue<bool?> _attorneyForTheBuyerIndicator;
        public bool? AttorneyForTheBuyerIndicator { get { return _attorneyForTheBuyerIndicator; } set { _attorneyForTheBuyerIndicator = value; } }
        private DirtyValue<bool?> _attorneyForTheLenderIndicator;
        public bool? AttorneyForTheLenderIndicator { get { return _attorneyForTheLenderIndicator; } set { _attorneyForTheLenderIndicator = value; } }
        private DirtyValue<bool?> _attorneyForTheSellerIndicator;
        public bool? AttorneyForTheSellerIndicator { get { return _attorneyForTheSellerIndicator; } set { _attorneyForTheSellerIndicator = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc1;
        public string AZCmplBlankSpcsDoc1BlankFldDesc1 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc1; } set { _aZCmplBlankSpcsDoc1BlankFldDesc1 = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc2;
        public string AZCmplBlankSpcsDoc1BlankFldDesc2 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc2; } set { _aZCmplBlankSpcsDoc1BlankFldDesc2 = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1BlankFldDesc3;
        public string AZCmplBlankSpcsDoc1BlankFldDesc3 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc3; } set { _aZCmplBlankSpcsDoc1BlankFldDesc3 = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc1Nm;
        public string AZCmplBlankSpcsDoc1Nm { get { return _aZCmplBlankSpcsDoc1Nm; } set { _aZCmplBlankSpcsDoc1Nm = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc2Nm;
        public string AZCmplBlankSpcsDoc2Nm { get { return _aZCmplBlankSpcsDoc2Nm; } set { _aZCmplBlankSpcsDoc2Nm = value; } }
        private DirtyValue<string> _aZCmplBlankSpcsDoc3Nm;
        public string AZCmplBlankSpcsDoc3Nm { get { return _aZCmplBlankSpcsDoc3Nm; } set { _aZCmplBlankSpcsDoc3Nm = value; } }
        private DirtyValue<string> _basedOnOthersDescription;
        public string BasedOnOthersDescription { get { return _basedOnOthersDescription; } set { _basedOnOthersDescription = value; } }
        private DirtyValue<bool?> _basedOnOthersIndicator;
        public bool? BasedOnOthersIndicator { get { return _basedOnOthersIndicator; } set { _basedOnOthersIndicator = value; } }
        private DirtyValue<bool?> _basedOnWholesaleOptionsIndicator;
        public bool? BasedOnWholesaleOptionsIndicator { get { return _basedOnWholesaleOptionsIndicator; } set { _basedOnWholesaleOptionsIndicator = value; } }
        private DirtyValue<decimal?> _borrowerElectsEstablishEscrowAmount;
        public decimal? BorrowerElectsEstablishEscrowAmount { get { return _borrowerElectsEstablishEscrowAmount; } set { _borrowerElectsEstablishEscrowAmount = value; } }
        private DirtyValue<bool?> _borrowerElectsEstablishEscrowIndicator;
        public bool? BorrowerElectsEstablishEscrowIndicator { get { return _borrowerElectsEstablishEscrowIndicator; } set { _borrowerElectsEstablishEscrowIndicator = value; } }
        private DirtyValue<decimal?> _brokerageFeeAddition1;
        public decimal? BrokerageFeeAddition1 { get { return _brokerageFeeAddition1; } set { _brokerageFeeAddition1 = value; } }
        private DirtyValue<decimal?> _brokerageFeeAddition2;
        public decimal? BrokerageFeeAddition2 { get { return _brokerageFeeAddition2; } set { _brokerageFeeAddition2 = value; } }
        private DirtyValue<decimal?> _brokerageFeeAddition3;
        public decimal? BrokerageFeeAddition3 { get { return _brokerageFeeAddition3; } set { _brokerageFeeAddition3 = value; } }
        private DirtyValue<decimal?> _brokerageFeeAmount1;
        public decimal? BrokerageFeeAmount1 { get { return _brokerageFeeAmount1; } set { _brokerageFeeAmount1 = value; } }
        private DirtyValue<decimal?> _brokerageFeeAmount2;
        public decimal? BrokerageFeeAmount2 { get { return _brokerageFeeAmount2; } set { _brokerageFeeAmount2 = value; } }
        private DirtyValue<decimal?> _brokerageFeeAmount3;
        public decimal? BrokerageFeeAmount3 { get { return _brokerageFeeAmount3; } set { _brokerageFeeAmount3 = value; } }
        private DirtyValue<int?> _brokerageFeeDays;
        public int? BrokerageFeeDays { get { return _brokerageFeeDays; } set { _brokerageFeeDays = value; } }
        private DirtyValue<decimal?> _brokerageFeePercent1;
        public decimal? BrokerageFeePercent1 { get { return _brokerageFeePercent1; } set { _brokerageFeePercent1 = value; } }
        private DirtyValue<decimal?> _brokerageFeePercent2;
        public decimal? BrokerageFeePercent2 { get { return _brokerageFeePercent2; } set { _brokerageFeePercent2 = value; } }
        private DirtyValue<decimal?> _brokerageFeePercent3;
        public decimal? BrokerageFeePercent3 { get { return _brokerageFeePercent3; } set { _brokerageFeePercent3 = value; } }
        private DirtyValue<string> _brokerAuthorizedSigningRepName;
        public string BrokerAuthorizedSigningRepName { get { return _brokerAuthorizedSigningRepName; } set { _brokerAuthorizedSigningRepName = value; } }
        private DirtyValue<string> _brokerAuthorizedSigningRepTitle;
        public string BrokerAuthorizedSigningRepTitle { get { return _brokerAuthorizedSigningRepTitle; } set { _brokerAuthorizedSigningRepTitle = value; } }
        private DirtyValue<string> _brokerForTheSeller;
        public string BrokerForTheSeller { get { return _brokerForTheSeller; } set { _brokerForTheSeller = value; } }
        private DirtyValue<string> _brokerLicense;
        public string BrokerLicense { get { return _brokerLicense; } set { _brokerLicense = value; } }
        private DirtyValue<string> _brokerName;
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }
        private DirtyValue<decimal?> _brokerPayAddition;
        public decimal? BrokerPayAddition { get { return _brokerPayAddition; } set { _brokerPayAddition = value; } }
        private DirtyValue<decimal?> _brokerPayAmount;
        public decimal? BrokerPayAmount { get { return _brokerPayAmount; } set { _brokerPayAmount = value; } }
        private DirtyValue<bool?> _brokerPayIndicator;
        public bool? BrokerPayIndicator { get { return _brokerPayIndicator; } set { _brokerPayIndicator = value; } }
        private DirtyValue<decimal?> _brokerPayPercent;
        public decimal? BrokerPayPercent { get { return _brokerPayPercent; } set { _brokerPayPercent = value; } }
        private DirtyValue<bool?> _cHARMBookletIndicator;
        public bool? CHARMBookletIndicator { get { return _cHARMBookletIndicator; } set { _cHARMBookletIndicator = value; } }
        private DirtyValue<string> _checkPayableTo;
        public string CheckPayableTo { get { return _checkPayableTo; } set { _checkPayableTo = value; } }
        private DirtyValue<decimal?> _commitmentAmount;
        public decimal? CommitmentAmount { get { return _commitmentAmount; } set { _commitmentAmount = value; } }
        private DirtyValue<string> _commitmentCondition1;
        public string CommitmentCondition1 { get { return _commitmentCondition1; } set { _commitmentCondition1 = value; } }
        private DirtyValue<string> _commitmentCondition2;
        public string CommitmentCondition2 { get { return _commitmentCondition2; } set { _commitmentCondition2 = value; } }
        private DirtyValue<decimal?> _commitmentFee;
        public decimal? CommitmentFee { get { return _commitmentFee; } set { _commitmentFee = value; } }
        private DirtyValue<decimal?> _commitmentPercent;
        public decimal? CommitmentPercent { get { return _commitmentPercent; } set { _commitmentPercent = value; } }
        private DirtyValue<decimal?> _compensationAddition;
        public decimal? CompensationAddition { get { return _compensationAddition; } set { _compensationAddition = value; } }
        private DirtyValue<decimal?> _compensationPercent;
        public decimal? CompensationPercent { get { return _compensationPercent; } set { _compensationPercent = value; } }
        private DirtyValue<decimal?> _creditDeposit;
        public decimal? CreditDeposit { get { return _creditDeposit; } set { _creditDeposit = value; } }
        private DirtyValue<string> _creditIsUsedForReason;
        public string CreditIsUsedForReason { get { return _creditIsUsedForReason; } set { _creditIsUsedForReason = value; } }
        private DirtyValue<string> _creditReportContact;
        public string CreditReportContact { get { return _creditReportContact; } set { _creditReportContact = value; } }
        private DirtyValue<int?> _daysBeforeClosing;
        public int? DaysBeforeClosing { get { return _daysBeforeClosing; } set { _daysBeforeClosing = value; } }
        private DirtyValue<decimal?> _depositReceipt;
        public decimal? DepositReceipt { get { return _depositReceipt; } set { _depositReceipt = value; } }
        private DirtyValue<bool?> _depositRefundableIndicator;
        public bool? DepositRefundableIndicator { get { return _depositRefundableIndicator; } set { _depositRefundableIndicator = value; } }
        private DirtyValue<string> _directContact;
        public string DirectContact { get { return _directContact; } set { _directContact = value; } }
        private DirtyValue<decimal?> _directPayAmount;
        public decimal? DirectPayAmount { get { return _directPayAmount; } set { _directPayAmount = value; } }
        private DirtyValue<decimal?> _directPayClosing;
        public decimal? DirectPayClosing { get { return _directPayClosing; } set { _directPayClosing = value; } }
        private DirtyValue<decimal?> _directPayCommitment;
        public decimal? DirectPayCommitment { get { return _directPayCommitment; } set { _directPayCommitment = value; } }
        private DirtyValue<bool?> _directPayIndicator;
        public bool? DirectPayIndicator { get { return _directPayIndicator; } set { _directPayIndicator = value; } }
        private DirtyValue<decimal?> _directPayPercent;
        public decimal? DirectPayPercent { get { return _directPayPercent; } set { _directPayPercent = value; } }
        private DirtyValue<string> _disclosureDeliveredBy;
        public string DisclosureDeliveredBy { get { return _disclosureDeliveredBy; } set { _disclosureDeliveredBy = value; } }
        private DirtyValue<string> _disclosureDeliveredByOtherMethod;
        public string DisclosureDeliveredByOtherMethod { get { return _disclosureDeliveredByOtherMethod; } set { _disclosureDeliveredByOtherMethod = value; } }
        private DirtyValue<DateTime?> _disclosureDeliveredDate;
        public DateTime? DisclosureDeliveredDate { get { return _disclosureDeliveredDate; } set { _disclosureDeliveredDate = value; } }
        private DirtyValue<bool?> _estimatedChargeShownOnGFEIndicator;
        public bool? EstimatedChargeShownOnGFEIndicator { get { return _estimatedChargeShownOnGFEIndicator; } set { _estimatedChargeShownOnGFEIndicator = value; } }
        private DirtyValue<DateTime?> _expirationDate;
        public DateTime? ExpirationDate { get { return _expirationDate; } set { _expirationDate = value; } }
        private DirtyValue<decimal?> _federallySubsidizedAmount;
        public decimal? FederallySubsidizedAmount { get { return _federallySubsidizedAmount; } set { _federallySubsidizedAmount = value; } }
        private DirtyValue<decimal?> _federallySubsidizedAmountPercentage;
        public decimal? FederallySubsidizedAmountPercentage { get { return _federallySubsidizedAmountPercentage; } set { _federallySubsidizedAmountPercentage = value; } }
        private DirtyValue<decimal?> _feeReceived1;
        public decimal? FeeReceived1 { get { return _feeReceived1; } set { _feeReceived1 = value; } }
        private DirtyValue<decimal?> _feeReceived2;
        public decimal? FeeReceived2 { get { return _feeReceived2; } set { _feeReceived2 = value; } }
        private DirtyValue<string> _feeReceivedByLender;
        public string FeeReceivedByLender { get { return _feeReceivedByLender; } set { _feeReceivedByLender = value; } }
        private DirtyValue<decimal?> _feesReceiving;
        public decimal? FeesReceiving { get { return _feesReceiving; } set { _feesReceiving = value; } }
        private DirtyValue<decimal?> _floridaApplicationFee;
        public decimal? FloridaApplicationFee { get { return _floridaApplicationFee; } set { _floridaApplicationFee = value; } }
        private DirtyValue<decimal?> _floridaOtherFee1;
        public decimal? FloridaOtherFee1 { get { return _floridaOtherFee1; } set { _floridaOtherFee1 = value; } }
        private DirtyValue<decimal?> _floridaOtherFee2;
        public decimal? FloridaOtherFee2 { get { return _floridaOtherFee2; } set { _floridaOtherFee2 = value; } }
        private DirtyValue<string> _floridaOtherFeeTo1;
        public string FloridaOtherFeeTo1 { get { return _floridaOtherFeeTo1; } set { _floridaOtherFeeTo1 = value; } }
        private DirtyValue<string> _floridaOtherFeeTo2;
        public string FloridaOtherFeeTo2 { get { return _floridaOtherFeeTo2; } set { _floridaOtherFeeTo2 = value; } }
        private DirtyValue<string> _floridaOtherFeeTo3;
        public string FloridaOtherFeeTo3 { get { return _floridaOtherFeeTo3; } set { _floridaOtherFeeTo3 = value; } }
        private DirtyValue<string> _floridaOtherFeeTo4;
        public string FloridaOtherFeeTo4 { get { return _floridaOtherFeeTo4; } set { _floridaOtherFeeTo4 = value; } }
        private DirtyValue<string> _furtherFeesEarnedByMortgageBroker;
        public string FurtherFeesEarnedByMortgageBroker { get { return _furtherFeesEarnedByMortgageBroker; } set { _furtherFeesEarnedByMortgageBroker = value; } }
        private DirtyValue<decimal?> _gFEFeeReceived1;
        public decimal? GFEFeeReceived1 { get { return _gFEFeeReceived1; } set { _gFEFeeReceived1 = value; } }
        private DirtyValue<decimal?> _gFEFeeReceived2;
        public decimal? GFEFeeReceived2 { get { return _gFEFeeReceived2; } set { _gFEFeeReceived2 = value; } }
        private DirtyValue<bool?> _hUDBookletIndicator;
        public bool? HUDBookletIndicator { get { return _hUDBookletIndicator; } set { _hUDBookletIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _independentContractorIndicator;
        public bool? IndependentContractorIndicator { get { return _independentContractorIndicator; } set { _independentContractorIndicator = value; } }
        private DirtyValue<string> _indexUsed;
        public string IndexUsed { get { return _indexUsed; } set { _indexUsed = value; } }
        private DirtyValue<string> _informationAboutTheIndexCanBeFound;
        public string InformationAboutTheIndexCanBeFound { get { return _informationAboutTheIndexCanBeFound; } set { _informationAboutTheIndexCanBeFound = value; } }
        private DirtyValue<string> _inLicensedNo;
        public string InLicensedNo { get { return _inLicensedNo; } set { _inLicensedNo = value; } }
        private DirtyValue<string> _inLicensedType;
        public string InLicensedType { get { return _inLicensedType; } set { _inLicensedType = value; } }
        private DirtyValue<bool?> _isEstimateIndicator;
        public bool? IsEstimateIndicator { get { return _isEstimateIndicator; } set { _isEstimateIndicator = value; } }
        private DirtyValue<bool?> _ksUcccElectionIndicator;
        public bool? KsUcccElectionIndicator { get { return _ksUcccElectionIndicator; } set { _ksUcccElectionIndicator = value; } }
        private DirtyValue<bool?> _kyHomeSolicationLoanIndicator;
        public bool? KyHomeSolicationLoanIndicator { get { return _kyHomeSolicationLoanIndicator; } set { _kyHomeSolicationLoanIndicator = value; } }
        private DirtyValue<DateTime?> _leaseAgreementDate;
        public DateTime? LeaseAgreementDate { get { return _leaseAgreementDate; } set { _leaseAgreementDate = value; } }
        private DirtyValue<DateTime?> _lenderDate;
        public DateTime? LenderDate { get { return _lenderDate; } set { _lenderDate = value; } }
        private DirtyValue<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private DirtyValue<decimal?> _lenderPaid;
        public decimal? LenderPaid { get { return _lenderPaid; } set { _lenderPaid = value; } }
        private DirtyValue<decimal?> _lenderPayAmount;
        public decimal? LenderPayAmount { get { return _lenderPayAmount; } set { _lenderPayAmount = value; } }
        private DirtyValue<bool?> _lenderPayIndicator;
        public bool? LenderPayIndicator { get { return _lenderPayIndicator; } set { _lenderPayIndicator = value; } }
        private DirtyValue<decimal?> _lenderPayMaxPoint;
        public decimal? LenderPayMaxPoint { get { return _lenderPayMaxPoint; } set { _lenderPayMaxPoint = value; } }
        private DirtyValue<decimal?> _lenderPayPercent;
        public decimal? LenderPayPercent { get { return _lenderPayPercent; } set { _lenderPayPercent = value; } }
        private DirtyValue<decimal?> _lenderPayPoint;
        public decimal? LenderPayPoint { get { return _lenderPayPoint; } set { _lenderPayPoint = value; } }
        private DirtyValue<bool?> _lenderPayUnknownIndicator;
        public bool? LenderPayUnknownIndicator { get { return _lenderPayUnknownIndicator; } set { _lenderPayUnknownIndicator = value; } }
        private DirtyValue<string> _lenderStatus;
        public string LenderStatus { get { return _lenderStatus; } set { _lenderStatus = value; } }
        private DirtyValue<string> _lessorName;
        public string LessorName { get { return _lessorName; } set { _lessorName = value; } }
        private DirtyValue<bool?> _loanTermsFixedThroughDateofLoanClosingIndicator;
        public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get { return _loanTermsFixedThroughDateofLoanClosingIndicator; } set { _loanTermsFixedThroughDateofLoanClosingIndicator = value; } }
        private DirtyValue<decimal?> _lockInFee;
        public decimal? LockInFee { get { return _lockInFee; } set { _lockInFee = value; } }
        private DirtyValue<string> _methodDescription;
        public string MethodDescription { get { return _methodDescription; } set { _methodDescription = value; } }
        private DirtyValue<string> _methodDetermine;
        public string MethodDetermine { get { return _methodDetermine; } set { _methodDetermine = value; } }
        private DirtyValue<bool?> _mortgageAgreementIndicator;
        public bool? MortgageAgreementIndicator { get { return _mortgageAgreementIndicator; } set { _mortgageAgreementIndicator = value; } }
        private DirtyValue<string> _mtgBrokerLicense;
        public string MtgBrokerLicense { get { return _mtgBrokerLicense; } set { _mtgBrokerLicense = value; } }
        private DirtyValue<string> _nameOfLicensee;
        public string NameOfLicensee { get { return _nameOfLicensee; } set { _nameOfLicensee = value; } }
        private DirtyValue<decimal?> _newMoneyAmount;
        public decimal? NewMoneyAmount { get { return _newMoneyAmount; } set { _newMoneyAmount = value; } }
        private DirtyValue<decimal?> _newYorkApplicationFee;
        public decimal? NewYorkApplicationFee { get { return _newYorkApplicationFee; } set { _newYorkApplicationFee = value; } }
        private DirtyValue<decimal?> _newYorkAppraisalFee;
        public decimal? NewYorkAppraisalFee { get { return _newYorkAppraisalFee; } set { _newYorkAppraisalFee = value; } }
        private DirtyValue<decimal?> _newYorkCreditReportFee;
        public decimal? NewYorkCreditReportFee { get { return _newYorkCreditReportFee; } set { _newYorkCreditReportFee = value; } }
        private DirtyList<NewYorkFee> _newYorkFees;
        public IList<NewYorkFee> NewYorkFees { get { var v = _newYorkFees; return v ?? Interlocked.CompareExchange(ref _newYorkFees, (v = new DirtyList<NewYorkFee>()), null) ?? v; } set { _newYorkFees = new DirtyList<NewYorkFee>(value); } }
        private DirtyList<NewYorkPrimaryLender> _newYorkPrimaryLenders;
        public IList<NewYorkPrimaryLender> NewYorkPrimaryLenders { get { var v = _newYorkPrimaryLenders; return v ?? Interlocked.CompareExchange(ref _newYorkPrimaryLenders, (v = new DirtyList<NewYorkPrimaryLender>()), null) ?? v; } set { _newYorkPrimaryLenders = new DirtyList<NewYorkPrimaryLender>(value); } }
        private DirtyValue<decimal?> _newYorkProcessingFee;
        public decimal? NewYorkProcessingFee { get { return _newYorkProcessingFee; } set { _newYorkProcessingFee = value; } }
        private DirtyValue<decimal?> _notRefundableAmount;
        public decimal? NotRefundableAmount { get { return _notRefundableAmount; } set { _notRefundableAmount = value; } }
        private DirtyValue<bool?> _offerRetailPriceIndicator;
        public bool? OfferRetailPriceIndicator { get { return _offerRetailPriceIndicator; } set { _offerRetailPriceIndicator = value; } }
        private DirtyValue<decimal?> _originalAcquisitionCost;
        public decimal? OriginalAcquisitionCost { get { return _originalAcquisitionCost; } set { _originalAcquisitionCost = value; } }
        private DirtyValue<decimal?> _originationFeeChargedAmount;
        public decimal? OriginationFeeChargedAmount { get { return _originationFeeChargedAmount; } set { _originationFeeChargedAmount = value; } }
        private DirtyValue<bool?> _originationFeeChargedIndicator;
        public bool? OriginationFeeChargedIndicator { get { return _originationFeeChargedIndicator; } set { _originationFeeChargedIndicator = value; } }
        private DirtyValue<decimal?> _originationFeeDecreasesRate;
        public decimal? OriginationFeeDecreasesRate { get { return _originationFeeDecreasesRate; } set { _originationFeeDecreasesRate = value; } }
        private DirtyValue<decimal?> _originationFeeIncreasesRate;
        public decimal? OriginationFeeIncreasesRate { get { return _originationFeeIncreasesRate; } set { _originationFeeIncreasesRate = value; } }
        private DirtyValue<string> _originationFeeInterestRateImpactedStatus;
        public string OriginationFeeInterestRateImpactedStatus { get { return _originationFeeInterestRateImpactedStatus; } set { _originationFeeInterestRateImpactedStatus = value; } }
        private DirtyValue<string> _originationFeePaidBy;
        public string OriginationFeePaidBy { get { return _originationFeePaidBy; } set { _originationFeePaidBy = value; } }
        private DirtyValue<decimal?> _paidByBorrower;
        public decimal? PaidByBorrower { get { return _paidByBorrower; } set { _paidByBorrower = value; } }
        private DirtyValue<decimal?> _paidByLender;
        public decimal? PaidByLender { get { return _paidByLender; } set { _paidByLender = value; } }
        private DirtyValue<decimal?> _paidByOther1;
        public decimal? PaidByOther1 { get { return _paidByOther1; } set { _paidByOther1 = value; } }
        private DirtyValue<decimal?> _paidByOther2;
        public decimal? PaidByOther2 { get { return _paidByOther2; } set { _paidByOther2 = value; } }
        private DirtyValue<string> _paidByOtherDescription1;
        public string PaidByOtherDescription1 { get { return _paidByOtherDescription1; } set { _paidByOtherDescription1 = value; } }
        private DirtyValue<string> _paidByOtherDescription2;
        public string PaidByOtherDescription2 { get { return _paidByOtherDescription2; } set { _paidByOtherDescription2 = value; } }
        private DirtyValue<decimal?> _previousMortgageAmountOne;
        public decimal? PreviousMortgageAmountOne { get { return _previousMortgageAmountOne; } set { _previousMortgageAmountOne = value; } }
        private DirtyValue<decimal?> _previousMortgageAmountTwo;
        public decimal? PreviousMortgageAmountTwo { get { return _previousMortgageAmountTwo; } set { _previousMortgageAmountTwo = value; } }
        private DirtyValue<bool?> _printCertificationOfCosts;
        public bool? PrintCertificationOfCosts { get { return _printCertificationOfCosts; } set { _printCertificationOfCosts = value; } }
        private DirtyValue<bool?> _printInterestRateReductionRider;
        public bool? PrintInterestRateReductionRider { get { return _printInterestRateReductionRider; } set { _printInterestRateReductionRider = value; } }
        private DirtyValue<bool?> _printMDDeliveryIndicator;
        public bool? PrintMDDeliveryIndicator { get { return _printMDDeliveryIndicator; } set { _printMDDeliveryIndicator = value; } }
        private DirtyValue<string> _providedBy;
        public string ProvidedBy { get { return _providedBy; } set { _providedBy = value; } }
        private DirtyValue<string> _questionContact;
        public string QuestionContact { get { return _questionContact; } set { _questionContact = value; } }
        private DirtyValue<string> _questionContactPhone;
        public string QuestionContactPhone { get { return _questionContactPhone; } set { _questionContactPhone = value; } }
        private DirtyValue<string> _questionContactTollFree;
        public string QuestionContactTollFree { get { return _questionContactTollFree; } set { _questionContactTollFree = value; } }
        private DirtyValue<bool?> _rateLockHonoredIndicator;
        public bool? RateLockHonoredIndicator { get { return _rateLockHonoredIndicator; } set { _rateLockHonoredIndicator = value; } }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private DirtyValue<decimal?> _refinancingFee;
        public decimal? RefinancingFee { get { return _refinancingFee; } set { _refinancingFee = value; } }
        private DirtyValue<string> _refundableBy;
        public string RefundableBy { get { return _refundableBy; } set { _refundableBy = value; } }
        private DirtyValue<bool?> _refundableIndicator;
        public bool? RefundableIndicator { get { return _refundableIndicator; } set { _refundableIndicator = value; } }
        private DirtyValue<string> _refundableType;
        public string RefundableType { get { return _refundableType; } set { _refundableType = value; } }
        private DirtyValue<string> _refundCondition1;
        public string RefundCondition1 { get { return _refundCondition1; } set { _refundCondition1 = value; } }
        private DirtyValue<string> _refundCondition2;
        public string RefundCondition2 { get { return _refundCondition2; } set { _refundCondition2 = value; } }
        private DirtyValue<string> _refundCondition3;
        public string RefundCondition3 { get { return _refundCondition3; } set { _refundCondition3 = value; } }
        private DirtyValue<string> _refundCondition4;
        public string RefundCondition4 { get { return _refundCondition4; } set { _refundCondition4 = value; } }
        private DirtyValue<string> _refundCondition5;
        public string RefundCondition5 { get { return _refundCondition5; } set { _refundCondition5 = value; } }
        private DirtyValue<string> _refundCondition6;
        public string RefundCondition6 { get { return _refundCondition6; } set { _refundCondition6 = value; } }
        private DirtyValue<string> _regulatorAddress;
        public string RegulatorAddress { get { return _regulatorAddress; } set { _regulatorAddress = value; } }
        private DirtyValue<string> _regulatorCity;
        public string RegulatorCity { get { return _regulatorCity; } set { _regulatorCity = value; } }
        private DirtyValue<string> _regulatorMailingAddress;
        public string RegulatorMailingAddress { get { return _regulatorMailingAddress; } set { _regulatorMailingAddress = value; } }
        private DirtyValue<string> _regulatorMailingCity;
        public string RegulatorMailingCity { get { return _regulatorMailingCity; } set { _regulatorMailingCity = value; } }
        private DirtyValue<string> _regulatorMailingState;
        public string RegulatorMailingState { get { return _regulatorMailingState; } set { _regulatorMailingState = value; } }
        private DirtyValue<string> _regulatorMailingZipCode;
        public string RegulatorMailingZipCode { get { return _regulatorMailingZipCode; } set { _regulatorMailingZipCode = value; } }
        private DirtyValue<string> _regulatorPhone;
        public string RegulatorPhone { get { return _regulatorPhone; } set { _regulatorPhone = value; } }
        private DirtyValue<string> _regulatorState;
        public string RegulatorState { get { return _regulatorState; } set { _regulatorState = value; } }
        private DirtyValue<string> _regulatorTollFreePhone;
        public string RegulatorTollFreePhone { get { return _regulatorTollFreePhone; } set { _regulatorTollFreePhone = value; } }
        private DirtyValue<string> _regulatorWebAddress;
        public string RegulatorWebAddress { get { return _regulatorWebAddress; } set { _regulatorWebAddress = value; } }
        private DirtyValue<string> _regulatorZipCode;
        public string RegulatorZipCode { get { return _regulatorZipCode; } set { _regulatorZipCode = value; } }
        private DirtyValue<string> _scheduleOfChargesEstimatedFinalIndicator;
        public string ScheduleOfChargesEstimatedFinalIndicator { get { return _scheduleOfChargesEstimatedFinalIndicator; } set { _scheduleOfChargesEstimatedFinalIndicator = value; } }
        private DirtyValue<string> _scRegulatoryAgencyType;
        public string ScRegulatoryAgencyType { get { return _scRegulatoryAgencyType; } set { _scRegulatoryAgencyType = value; } }
        private DirtyValue<bool?> _selectDivisionFeesIndicator;
        public bool? SelectDivisionFeesIndicator { get { return _selectDivisionFeesIndicator; } set { _selectDivisionFeesIndicator = value; } }
        private DirtyValue<bool?> _selectPrimaryLenderIndicator;
        public bool? SelectPrimaryLenderIndicator { get { return _selectPrimaryLenderIndicator; } set { _selectPrimaryLenderIndicator = value; } }
        private DirtyValue<bool?> _selectPrivateLenderIndicator;
        public bool? SelectPrivateLenderIndicator { get { return _selectPrivateLenderIndicator; } set { _selectPrivateLenderIndicator = value; } }
        private DirtyValue<decimal?> _servicingFeeChargedAmount;
        public decimal? ServicingFeeChargedAmount { get { return _servicingFeeChargedAmount; } set { _servicingFeeChargedAmount = value; } }
        private DirtyValue<bool?> _servicingFeeChargedIndicator;
        public bool? ServicingFeeChargedIndicator { get { return _servicingFeeChargedIndicator; } set { _servicingFeeChargedIndicator = value; } }
        private DirtyValue<string> _servicingFeePaidBy;
        public string ServicingFeePaidBy { get { return _servicingFeePaidBy; } set { _servicingFeePaidBy = value; } }
        private DirtyValue<string> _servicingFeePaidFrequence;
        public string ServicingFeePaidFrequence { get { return _servicingFeePaidFrequence; } set { _servicingFeePaidFrequence = value; } }
        private DirtyValue<bool?> _signedByBorrowerIndicator;
        public bool? SignedByBorrowerIndicator { get { return _signedByBorrowerIndicator; } set { _signedByBorrowerIndicator = value; } }
        private DirtyValue<bool?> _specificARMIndicator;
        public bool? SpecificARMIndicator { get { return _specificARMIndicator; } set { _specificARMIndicator = value; } }
        private DirtyValue<bool?> _submitToLenderIndicator;
        public bool? SubmitToLenderIndicator { get { return _submitToLenderIndicator; } set { _submitToLenderIndicator = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationAssessments;
        public decimal? TaxExemptAcquisitionCostCertificationAssessments { get { return _taxExemptAcquisitionCostCertificationAssessments; } set { _taxExemptAcquisitionCostCertificationAssessments = value; } }
        private DirtyValue<string> _taxExemptAcquisitionCostCertificationOther;
        public string TaxExemptAcquisitionCostCertificationOther { get { return _taxExemptAcquisitionCostCertificationOther; } set { _taxExemptAcquisitionCostCertificationOther = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationOtherAmount;
        public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get { return _taxExemptAcquisitionCostCertificationOtherAmount; } set { _taxExemptAcquisitionCostCertificationOtherAmount = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationOwnersTitleInsurance;
        public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get { return _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; } set { _taxExemptAcquisitionCostCertificationOwnersTitleInsurance = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationRealEstateCommission;
        public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get { return _taxExemptAcquisitionCostCertificationRealEstateCommission; } set { _taxExemptAcquisitionCostCertificationRealEstateCommission = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationRepairsImprovements;
        public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get { return _taxExemptAcquisitionCostCertificationRepairsImprovements; } set { _taxExemptAcquisitionCostCertificationRepairsImprovements = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationSurvey;
        public decimal? TaxExemptAcquisitionCostCertificationSurvey { get { return _taxExemptAcquisitionCostCertificationSurvey; } set { _taxExemptAcquisitionCostCertificationSurvey = value; } }
        private DirtyValue<decimal?> _taxExemptAcquisitionCostCertificationTotalAdjustments;
        public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get { return _taxExemptAcquisitionCostCertificationTotalAdjustments; } set { _taxExemptAcquisitionCostCertificationTotalAdjustments = value; } }
        private DirtyValue<string> _termsChange;
        public string TermsChange { get { return _termsChange; } set { _termsChange = value; } }
        private DirtyValue<decimal?> _texasApplicationFee;
        public decimal? TexasApplicationFee { get { return _texasApplicationFee; } set { _texasApplicationFee = value; } }
        private DirtyValue<decimal?> _texasAppraisalFee;
        public decimal? TexasAppraisalFee { get { return _texasAppraisalFee; } set { _texasAppraisalFee = value; } }
        private DirtyValue<decimal?> _texasCreditReportFee;
        public decimal? TexasCreditReportFee { get { return _texasCreditReportFee; } set { _texasCreditReportFee = value; } }
        private DirtyValue<decimal?> _texasOtherFee1;
        public decimal? TexasOtherFee1 { get { return _texasOtherFee1; } set { _texasOtherFee1 = value; } }
        private DirtyValue<decimal?> _texasOtherFee2;
        public decimal? TexasOtherFee2 { get { return _texasOtherFee2; } set { _texasOtherFee2 = value; } }
        private DirtyValue<string> _texasOtherFeeContact1;
        public string TexasOtherFeeContact1 { get { return _texasOtherFeeContact1; } set { _texasOtherFeeContact1 = value; } }
        private DirtyValue<string> _texasOtherFeeContact2;
        public string TexasOtherFeeContact2 { get { return _texasOtherFeeContact2; } set { _texasOtherFeeContact2 = value; } }
        private DirtyValue<decimal?> _texasProcessingFee;
        public decimal? TexasProcessingFee { get { return _texasProcessingFee; } set { _texasProcessingFee = value; } }
        private DirtyValue<decimal?> _thirdPartyFee;
        public decimal? ThirdPartyFee { get { return _thirdPartyFee; } set { _thirdPartyFee = value; } }
        private DirtyValue<decimal?> _totalFee;
        public decimal? TotalFee { get { return _totalFee; } set { _totalFee = value; } }
        private DirtyValue<decimal?> _transferFeeChargedAmount;
        public decimal? TransferFeeChargedAmount { get { return _transferFeeChargedAmount; } set { _transferFeeChargedAmount = value; } }
        private DirtyValue<bool?> _transferFeeChargedIndicator;
        public bool? TransferFeeChargedIndicator { get { return _transferFeeChargedIndicator; } set { _transferFeeChargedIndicator = value; } }
        private DirtyValue<string> _transferFeePaidBy;
        public string TransferFeePaidBy { get { return _transferFeePaidBy; } set { _transferFeePaidBy = value; } }
        private DirtyValue<bool?> _txVeteransLandBoardIndicator;
        public bool? TxVeteransLandBoardIndicator { get { return _txVeteransLandBoardIndicator; } set { _txVeteransLandBoardIndicator = value; } }
        private DirtyValue<string> _typeOfProperty;
        public string TypeOfProperty { get { return _typeOfProperty; } set { _typeOfProperty = value; } }
        private DirtyValue<string> _underwritingContact;
        public string UnderwritingContact { get { return _underwritingContact; } set { _underwritingContact = value; } }
        private DirtyValue<decimal?> _underwritingFee;
        public decimal? UnderwritingFee { get { return _underwritingFee; } set { _underwritingFee = value; } }
        private DirtyValue<decimal?> _ySPChargedAmount;
        public decimal? YSPChargedAmount { get { return _ySPChargedAmount; } set { _ySPChargedAmount = value; } }
        private DirtyValue<bool?> _ySPChargedIndicator;
        public bool? YSPChargedIndicator { get { return _ySPChargedIndicator; } set { _ySPChargedIndicator = value; } }
        private DirtyValue<decimal?> _ySPDecreasesRate;
        public decimal? YSPDecreasesRate { get { return _ySPDecreasesRate; } set { _ySPDecreasesRate = value; } }
        private DirtyValue<decimal?> _ySPIncreasesRate;
        public decimal? YSPIncreasesRate { get { return _ySPIncreasesRate; } set { _ySPIncreasesRate = value; } }
        private DirtyValue<string> _ySPInterestRateImpactedStatus;
        public string YSPInterestRateImpactedStatus { get { return _ySPInterestRateImpactedStatus; } set { _ySPInterestRateImpactedStatus = value; } }
        private DirtyValue<string> _ySPPaidBy;
        public string YSPPaidBy { get { return _ySPPaidBy; } set { _ySPPaidBy = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _acceptedByBorrowerIndicator.Dirty
                    || _acceptedDate.Dirty
                    || _actingOtherDescription1.Dirty
                    || _actingOtherDescription2.Dirty
                    || _actingOthersIndicator.Dirty
                    || _advFeeAgmtInEfctNumDay.Dirty
                    || _advisoryCondition1.Dirty
                    || _advisoryCondition2.Dirty
                    || _advisoryCondition3.Dirty
                    || _advisoryCondition4.Dirty
                    || _amendedAcquisitionCost.Dirty
                    || _applicationDate.Dirty
                    || _appraisalContact.Dirty
                    || _appraisalDeposit.Dirty
                    || _areas.Dirty
                    || _asAttorneyIndicator.Dirty
                    || _asRealBrokerIndicator.Dirty
                    || _attorneyForTheBuyerIndicator.Dirty
                    || _attorneyForTheLenderIndicator.Dirty
                    || _attorneyForTheSellerIndicator.Dirty
                    || _aZCmplBlankSpcsDoc1BlankFldDesc1.Dirty
                    || _aZCmplBlankSpcsDoc1BlankFldDesc2.Dirty
                    || _aZCmplBlankSpcsDoc1BlankFldDesc3.Dirty
                    || _aZCmplBlankSpcsDoc1Nm.Dirty
                    || _aZCmplBlankSpcsDoc2Nm.Dirty
                    || _aZCmplBlankSpcsDoc3Nm.Dirty
                    || _basedOnOthersDescription.Dirty
                    || _basedOnOthersIndicator.Dirty
                    || _basedOnWholesaleOptionsIndicator.Dirty
                    || _borrowerElectsEstablishEscrowAmount.Dirty
                    || _borrowerElectsEstablishEscrowIndicator.Dirty
                    || _brokerageFeeAddition1.Dirty
                    || _brokerageFeeAddition2.Dirty
                    || _brokerageFeeAddition3.Dirty
                    || _brokerageFeeAmount1.Dirty
                    || _brokerageFeeAmount2.Dirty
                    || _brokerageFeeAmount3.Dirty
                    || _brokerageFeeDays.Dirty
                    || _brokerageFeePercent1.Dirty
                    || _brokerageFeePercent2.Dirty
                    || _brokerageFeePercent3.Dirty
                    || _brokerAuthorizedSigningRepName.Dirty
                    || _brokerAuthorizedSigningRepTitle.Dirty
                    || _brokerForTheSeller.Dirty
                    || _brokerLicense.Dirty
                    || _brokerName.Dirty
                    || _brokerPayAddition.Dirty
                    || _brokerPayAmount.Dirty
                    || _brokerPayIndicator.Dirty
                    || _brokerPayPercent.Dirty
                    || _cHARMBookletIndicator.Dirty
                    || _checkPayableTo.Dirty
                    || _commitmentAmount.Dirty
                    || _commitmentCondition1.Dirty
                    || _commitmentCondition2.Dirty
                    || _commitmentFee.Dirty
                    || _commitmentPercent.Dirty
                    || _compensationAddition.Dirty
                    || _compensationPercent.Dirty
                    || _creditDeposit.Dirty
                    || _creditIsUsedForReason.Dirty
                    || _creditReportContact.Dirty
                    || _daysBeforeClosing.Dirty
                    || _depositReceipt.Dirty
                    || _depositRefundableIndicator.Dirty
                    || _directContact.Dirty
                    || _directPayAmount.Dirty
                    || _directPayClosing.Dirty
                    || _directPayCommitment.Dirty
                    || _directPayIndicator.Dirty
                    || _directPayPercent.Dirty
                    || _disclosureDeliveredBy.Dirty
                    || _disclosureDeliveredByOtherMethod.Dirty
                    || _disclosureDeliveredDate.Dirty
                    || _estimatedChargeShownOnGFEIndicator.Dirty
                    || _expirationDate.Dirty
                    || _federallySubsidizedAmount.Dirty
                    || _federallySubsidizedAmountPercentage.Dirty
                    || _feeReceived1.Dirty
                    || _feeReceived2.Dirty
                    || _feeReceivedByLender.Dirty
                    || _feesReceiving.Dirty
                    || _floridaApplicationFee.Dirty
                    || _floridaOtherFee1.Dirty
                    || _floridaOtherFee2.Dirty
                    || _floridaOtherFeeTo1.Dirty
                    || _floridaOtherFeeTo2.Dirty
                    || _floridaOtherFeeTo3.Dirty
                    || _floridaOtherFeeTo4.Dirty
                    || _furtherFeesEarnedByMortgageBroker.Dirty
                    || _gFEFeeReceived1.Dirty
                    || _gFEFeeReceived2.Dirty
                    || _hUDBookletIndicator.Dirty
                    || _id.Dirty
                    || _independentContractorIndicator.Dirty
                    || _indexUsed.Dirty
                    || _informationAboutTheIndexCanBeFound.Dirty
                    || _inLicensedNo.Dirty
                    || _inLicensedType.Dirty
                    || _isEstimateIndicator.Dirty
                    || _ksUcccElectionIndicator.Dirty
                    || _kyHomeSolicationLoanIndicator.Dirty
                    || _leaseAgreementDate.Dirty
                    || _lenderDate.Dirty
                    || _lenderName.Dirty
                    || _lenderPaid.Dirty
                    || _lenderPayAmount.Dirty
                    || _lenderPayIndicator.Dirty
                    || _lenderPayMaxPoint.Dirty
                    || _lenderPayPercent.Dirty
                    || _lenderPayPoint.Dirty
                    || _lenderPayUnknownIndicator.Dirty
                    || _lenderStatus.Dirty
                    || _lessorName.Dirty
                    || _loanTermsFixedThroughDateofLoanClosingIndicator.Dirty
                    || _lockInFee.Dirty
                    || _methodDescription.Dirty
                    || _methodDetermine.Dirty
                    || _mortgageAgreementIndicator.Dirty
                    || _mtgBrokerLicense.Dirty
                    || _nameOfLicensee.Dirty
                    || _newMoneyAmount.Dirty
                    || _newYorkApplicationFee.Dirty
                    || _newYorkAppraisalFee.Dirty
                    || _newYorkCreditReportFee.Dirty
                    || _newYorkProcessingFee.Dirty
                    || _notRefundableAmount.Dirty
                    || _offerRetailPriceIndicator.Dirty
                    || _originalAcquisitionCost.Dirty
                    || _originationFeeChargedAmount.Dirty
                    || _originationFeeChargedIndicator.Dirty
                    || _originationFeeDecreasesRate.Dirty
                    || _originationFeeIncreasesRate.Dirty
                    || _originationFeeInterestRateImpactedStatus.Dirty
                    || _originationFeePaidBy.Dirty
                    || _paidByBorrower.Dirty
                    || _paidByLender.Dirty
                    || _paidByOther1.Dirty
                    || _paidByOther2.Dirty
                    || _paidByOtherDescription1.Dirty
                    || _paidByOtherDescription2.Dirty
                    || _previousMortgageAmountOne.Dirty
                    || _previousMortgageAmountTwo.Dirty
                    || _printCertificationOfCosts.Dirty
                    || _printInterestRateReductionRider.Dirty
                    || _printMDDeliveryIndicator.Dirty
                    || _providedBy.Dirty
                    || _questionContact.Dirty
                    || _questionContactPhone.Dirty
                    || _questionContactTollFree.Dirty
                    || _rateLockHonoredIndicator.Dirty
                    || _receivedBy.Dirty
                    || _refinancingFee.Dirty
                    || _refundableBy.Dirty
                    || _refundableIndicator.Dirty
                    || _refundableType.Dirty
                    || _refundCondition1.Dirty
                    || _refundCondition2.Dirty
                    || _refundCondition3.Dirty
                    || _refundCondition4.Dirty
                    || _refundCondition5.Dirty
                    || _refundCondition6.Dirty
                    || _regulatorAddress.Dirty
                    || _regulatorCity.Dirty
                    || _regulatorMailingAddress.Dirty
                    || _regulatorMailingCity.Dirty
                    || _regulatorMailingState.Dirty
                    || _regulatorMailingZipCode.Dirty
                    || _regulatorPhone.Dirty
                    || _regulatorState.Dirty
                    || _regulatorTollFreePhone.Dirty
                    || _regulatorWebAddress.Dirty
                    || _regulatorZipCode.Dirty
                    || _scheduleOfChargesEstimatedFinalIndicator.Dirty
                    || _scRegulatoryAgencyType.Dirty
                    || _selectDivisionFeesIndicator.Dirty
                    || _selectPrimaryLenderIndicator.Dirty
                    || _selectPrivateLenderIndicator.Dirty
                    || _servicingFeeChargedAmount.Dirty
                    || _servicingFeeChargedIndicator.Dirty
                    || _servicingFeePaidBy.Dirty
                    || _servicingFeePaidFrequence.Dirty
                    || _signedByBorrowerIndicator.Dirty
                    || _specificARMIndicator.Dirty
                    || _submitToLenderIndicator.Dirty
                    || _taxExemptAcquisitionCostCertificationAssessments.Dirty
                    || _taxExemptAcquisitionCostCertificationOther.Dirty
                    || _taxExemptAcquisitionCostCertificationOtherAmount.Dirty
                    || _taxExemptAcquisitionCostCertificationOwnersTitleInsurance.Dirty
                    || _taxExemptAcquisitionCostCertificationRealEstateCommission.Dirty
                    || _taxExemptAcquisitionCostCertificationRepairsImprovements.Dirty
                    || _taxExemptAcquisitionCostCertificationSurvey.Dirty
                    || _taxExemptAcquisitionCostCertificationTotalAdjustments.Dirty
                    || _termsChange.Dirty
                    || _texasApplicationFee.Dirty
                    || _texasAppraisalFee.Dirty
                    || _texasCreditReportFee.Dirty
                    || _texasOtherFee1.Dirty
                    || _texasOtherFee2.Dirty
                    || _texasOtherFeeContact1.Dirty
                    || _texasOtherFeeContact2.Dirty
                    || _texasProcessingFee.Dirty
                    || _thirdPartyFee.Dirty
                    || _totalFee.Dirty
                    || _transferFeeChargedAmount.Dirty
                    || _transferFeeChargedIndicator.Dirty
                    || _transferFeePaidBy.Dirty
                    || _txVeteransLandBoardIndicator.Dirty
                    || _typeOfProperty.Dirty
                    || _underwritingContact.Dirty
                    || _underwritingFee.Dirty
                    || _ySPChargedAmount.Dirty
                    || _ySPChargedIndicator.Dirty
                    || _ySPDecreasesRate.Dirty
                    || _ySPIncreasesRate.Dirty
                    || _ySPInterestRateImpactedStatus.Dirty
                    || _ySPPaidBy.Dirty
                    || _newYorkFees?.Dirty == true
                    || _newYorkPrimaryLenders?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _acceptedByBorrowerIndicator.Dirty = value;
                _acceptedDate.Dirty = value;
                _actingOtherDescription1.Dirty = value;
                _actingOtherDescription2.Dirty = value;
                _actingOthersIndicator.Dirty = value;
                _advFeeAgmtInEfctNumDay.Dirty = value;
                _advisoryCondition1.Dirty = value;
                _advisoryCondition2.Dirty = value;
                _advisoryCondition3.Dirty = value;
                _advisoryCondition4.Dirty = value;
                _amendedAcquisitionCost.Dirty = value;
                _applicationDate.Dirty = value;
                _appraisalContact.Dirty = value;
                _appraisalDeposit.Dirty = value;
                _areas.Dirty = value;
                _asAttorneyIndicator.Dirty = value;
                _asRealBrokerIndicator.Dirty = value;
                _attorneyForTheBuyerIndicator.Dirty = value;
                _attorneyForTheLenderIndicator.Dirty = value;
                _attorneyForTheSellerIndicator.Dirty = value;
                _aZCmplBlankSpcsDoc1BlankFldDesc1.Dirty = value;
                _aZCmplBlankSpcsDoc1BlankFldDesc2.Dirty = value;
                _aZCmplBlankSpcsDoc1BlankFldDesc3.Dirty = value;
                _aZCmplBlankSpcsDoc1Nm.Dirty = value;
                _aZCmplBlankSpcsDoc2Nm.Dirty = value;
                _aZCmplBlankSpcsDoc3Nm.Dirty = value;
                _basedOnOthersDescription.Dirty = value;
                _basedOnOthersIndicator.Dirty = value;
                _basedOnWholesaleOptionsIndicator.Dirty = value;
                _borrowerElectsEstablishEscrowAmount.Dirty = value;
                _borrowerElectsEstablishEscrowIndicator.Dirty = value;
                _brokerageFeeAddition1.Dirty = value;
                _brokerageFeeAddition2.Dirty = value;
                _brokerageFeeAddition3.Dirty = value;
                _brokerageFeeAmount1.Dirty = value;
                _brokerageFeeAmount2.Dirty = value;
                _brokerageFeeAmount3.Dirty = value;
                _brokerageFeeDays.Dirty = value;
                _brokerageFeePercent1.Dirty = value;
                _brokerageFeePercent2.Dirty = value;
                _brokerageFeePercent3.Dirty = value;
                _brokerAuthorizedSigningRepName.Dirty = value;
                _brokerAuthorizedSigningRepTitle.Dirty = value;
                _brokerForTheSeller.Dirty = value;
                _brokerLicense.Dirty = value;
                _brokerName.Dirty = value;
                _brokerPayAddition.Dirty = value;
                _brokerPayAmount.Dirty = value;
                _brokerPayIndicator.Dirty = value;
                _brokerPayPercent.Dirty = value;
                _cHARMBookletIndicator.Dirty = value;
                _checkPayableTo.Dirty = value;
                _commitmentAmount.Dirty = value;
                _commitmentCondition1.Dirty = value;
                _commitmentCondition2.Dirty = value;
                _commitmentFee.Dirty = value;
                _commitmentPercent.Dirty = value;
                _compensationAddition.Dirty = value;
                _compensationPercent.Dirty = value;
                _creditDeposit.Dirty = value;
                _creditIsUsedForReason.Dirty = value;
                _creditReportContact.Dirty = value;
                _daysBeforeClosing.Dirty = value;
                _depositReceipt.Dirty = value;
                _depositRefundableIndicator.Dirty = value;
                _directContact.Dirty = value;
                _directPayAmount.Dirty = value;
                _directPayClosing.Dirty = value;
                _directPayCommitment.Dirty = value;
                _directPayIndicator.Dirty = value;
                _directPayPercent.Dirty = value;
                _disclosureDeliveredBy.Dirty = value;
                _disclosureDeliveredByOtherMethod.Dirty = value;
                _disclosureDeliveredDate.Dirty = value;
                _estimatedChargeShownOnGFEIndicator.Dirty = value;
                _expirationDate.Dirty = value;
                _federallySubsidizedAmount.Dirty = value;
                _federallySubsidizedAmountPercentage.Dirty = value;
                _feeReceived1.Dirty = value;
                _feeReceived2.Dirty = value;
                _feeReceivedByLender.Dirty = value;
                _feesReceiving.Dirty = value;
                _floridaApplicationFee.Dirty = value;
                _floridaOtherFee1.Dirty = value;
                _floridaOtherFee2.Dirty = value;
                _floridaOtherFeeTo1.Dirty = value;
                _floridaOtherFeeTo2.Dirty = value;
                _floridaOtherFeeTo3.Dirty = value;
                _floridaOtherFeeTo4.Dirty = value;
                _furtherFeesEarnedByMortgageBroker.Dirty = value;
                _gFEFeeReceived1.Dirty = value;
                _gFEFeeReceived2.Dirty = value;
                _hUDBookletIndicator.Dirty = value;
                _id.Dirty = value;
                _independentContractorIndicator.Dirty = value;
                _indexUsed.Dirty = value;
                _informationAboutTheIndexCanBeFound.Dirty = value;
                _inLicensedNo.Dirty = value;
                _inLicensedType.Dirty = value;
                _isEstimateIndicator.Dirty = value;
                _ksUcccElectionIndicator.Dirty = value;
                _kyHomeSolicationLoanIndicator.Dirty = value;
                _leaseAgreementDate.Dirty = value;
                _lenderDate.Dirty = value;
                _lenderName.Dirty = value;
                _lenderPaid.Dirty = value;
                _lenderPayAmount.Dirty = value;
                _lenderPayIndicator.Dirty = value;
                _lenderPayMaxPoint.Dirty = value;
                _lenderPayPercent.Dirty = value;
                _lenderPayPoint.Dirty = value;
                _lenderPayUnknownIndicator.Dirty = value;
                _lenderStatus.Dirty = value;
                _lessorName.Dirty = value;
                _loanTermsFixedThroughDateofLoanClosingIndicator.Dirty = value;
                _lockInFee.Dirty = value;
                _methodDescription.Dirty = value;
                _methodDetermine.Dirty = value;
                _mortgageAgreementIndicator.Dirty = value;
                _mtgBrokerLicense.Dirty = value;
                _nameOfLicensee.Dirty = value;
                _newMoneyAmount.Dirty = value;
                _newYorkApplicationFee.Dirty = value;
                _newYorkAppraisalFee.Dirty = value;
                _newYorkCreditReportFee.Dirty = value;
                _newYorkProcessingFee.Dirty = value;
                _notRefundableAmount.Dirty = value;
                _offerRetailPriceIndicator.Dirty = value;
                _originalAcquisitionCost.Dirty = value;
                _originationFeeChargedAmount.Dirty = value;
                _originationFeeChargedIndicator.Dirty = value;
                _originationFeeDecreasesRate.Dirty = value;
                _originationFeeIncreasesRate.Dirty = value;
                _originationFeeInterestRateImpactedStatus.Dirty = value;
                _originationFeePaidBy.Dirty = value;
                _paidByBorrower.Dirty = value;
                _paidByLender.Dirty = value;
                _paidByOther1.Dirty = value;
                _paidByOther2.Dirty = value;
                _paidByOtherDescription1.Dirty = value;
                _paidByOtherDescription2.Dirty = value;
                _previousMortgageAmountOne.Dirty = value;
                _previousMortgageAmountTwo.Dirty = value;
                _printCertificationOfCosts.Dirty = value;
                _printInterestRateReductionRider.Dirty = value;
                _printMDDeliveryIndicator.Dirty = value;
                _providedBy.Dirty = value;
                _questionContact.Dirty = value;
                _questionContactPhone.Dirty = value;
                _questionContactTollFree.Dirty = value;
                _rateLockHonoredIndicator.Dirty = value;
                _receivedBy.Dirty = value;
                _refinancingFee.Dirty = value;
                _refundableBy.Dirty = value;
                _refundableIndicator.Dirty = value;
                _refundableType.Dirty = value;
                _refundCondition1.Dirty = value;
                _refundCondition2.Dirty = value;
                _refundCondition3.Dirty = value;
                _refundCondition4.Dirty = value;
                _refundCondition5.Dirty = value;
                _refundCondition6.Dirty = value;
                _regulatorAddress.Dirty = value;
                _regulatorCity.Dirty = value;
                _regulatorMailingAddress.Dirty = value;
                _regulatorMailingCity.Dirty = value;
                _regulatorMailingState.Dirty = value;
                _regulatorMailingZipCode.Dirty = value;
                _regulatorPhone.Dirty = value;
                _regulatorState.Dirty = value;
                _regulatorTollFreePhone.Dirty = value;
                _regulatorWebAddress.Dirty = value;
                _regulatorZipCode.Dirty = value;
                _scheduleOfChargesEstimatedFinalIndicator.Dirty = value;
                _scRegulatoryAgencyType.Dirty = value;
                _selectDivisionFeesIndicator.Dirty = value;
                _selectPrimaryLenderIndicator.Dirty = value;
                _selectPrivateLenderIndicator.Dirty = value;
                _servicingFeeChargedAmount.Dirty = value;
                _servicingFeeChargedIndicator.Dirty = value;
                _servicingFeePaidBy.Dirty = value;
                _servicingFeePaidFrequence.Dirty = value;
                _signedByBorrowerIndicator.Dirty = value;
                _specificARMIndicator.Dirty = value;
                _submitToLenderIndicator.Dirty = value;
                _taxExemptAcquisitionCostCertificationAssessments.Dirty = value;
                _taxExemptAcquisitionCostCertificationOther.Dirty = value;
                _taxExemptAcquisitionCostCertificationOtherAmount.Dirty = value;
                _taxExemptAcquisitionCostCertificationOwnersTitleInsurance.Dirty = value;
                _taxExemptAcquisitionCostCertificationRealEstateCommission.Dirty = value;
                _taxExemptAcquisitionCostCertificationRepairsImprovements.Dirty = value;
                _taxExemptAcquisitionCostCertificationSurvey.Dirty = value;
                _taxExemptAcquisitionCostCertificationTotalAdjustments.Dirty = value;
                _termsChange.Dirty = value;
                _texasApplicationFee.Dirty = value;
                _texasAppraisalFee.Dirty = value;
                _texasCreditReportFee.Dirty = value;
                _texasOtherFee1.Dirty = value;
                _texasOtherFee2.Dirty = value;
                _texasOtherFeeContact1.Dirty = value;
                _texasOtherFeeContact2.Dirty = value;
                _texasProcessingFee.Dirty = value;
                _thirdPartyFee.Dirty = value;
                _totalFee.Dirty = value;
                _transferFeeChargedAmount.Dirty = value;
                _transferFeeChargedIndicator.Dirty = value;
                _transferFeePaidBy.Dirty = value;
                _txVeteransLandBoardIndicator.Dirty = value;
                _typeOfProperty.Dirty = value;
                _underwritingContact.Dirty = value;
                _underwritingFee.Dirty = value;
                _ySPChargedAmount.Dirty = value;
                _ySPChargedIndicator.Dirty = value;
                _ySPDecreasesRate.Dirty = value;
                _ySPIncreasesRate.Dirty = value;
                _ySPInterestRateImpactedStatus.Dirty = value;
                _ySPPaidBy.Dirty = value;
                if (_newYorkFees != null) _newYorkFees.Dirty = value;
                if (_newYorkPrimaryLenders != null) _newYorkPrimaryLenders.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}