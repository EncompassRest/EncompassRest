using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StateDisclosure : IClean
    {
        private Value<bool?> _acceptedByBorrowerIndicator;
        public bool? AcceptedByBorrowerIndicator { get { return _acceptedByBorrowerIndicator; } set { _acceptedByBorrowerIndicator = value; } }
        private Value<DateTime?> _acceptedDate;
        public DateTime? AcceptedDate { get { return _acceptedDate; } set { _acceptedDate = value; } }
        private Value<string> _actingOtherDescription1;
        public string ActingOtherDescription1 { get { return _actingOtherDescription1; } set { _actingOtherDescription1 = value; } }
        private Value<string> _actingOtherDescription2;
        public string ActingOtherDescription2 { get { return _actingOtherDescription2; } set { _actingOtherDescription2 = value; } }
        private Value<bool?> _actingOthersIndicator;
        public bool? ActingOthersIndicator { get { return _actingOthersIndicator; } set { _actingOthersIndicator = value; } }
        private Value<int?> _advFeeAgmtInEfctNumDay;
        public int? AdvFeeAgmtInEfctNumDay { get { return _advFeeAgmtInEfctNumDay; } set { _advFeeAgmtInEfctNumDay = value; } }
        private Value<string> _advisoryCondition1;
        public string AdvisoryCondition1 { get { return _advisoryCondition1; } set { _advisoryCondition1 = value; } }
        private Value<string> _advisoryCondition2;
        public string AdvisoryCondition2 { get { return _advisoryCondition2; } set { _advisoryCondition2 = value; } }
        private Value<string> _advisoryCondition3;
        public string AdvisoryCondition3 { get { return _advisoryCondition3; } set { _advisoryCondition3 = value; } }
        private Value<string> _advisoryCondition4;
        public string AdvisoryCondition4 { get { return _advisoryCondition4; } set { _advisoryCondition4 = value; } }
        private Value<decimal?> _amendedAcquisitionCost;
        public decimal? AmendedAcquisitionCost { get { return _amendedAcquisitionCost; } set { _amendedAcquisitionCost = value; } }
        private Value<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _appraisalContact;
        public string AppraisalContact { get { return _appraisalContact; } set { _appraisalContact = value; } }
        private Value<decimal?> _appraisalDeposit;
        public decimal? AppraisalDeposit { get { return _appraisalDeposit; } set { _appraisalDeposit = value; } }
        private Value<string> _areas;
        public string Areas { get { return _areas; } set { _areas = value; } }
        private Value<bool?> _asAttorneyIndicator;
        public bool? AsAttorneyIndicator { get { return _asAttorneyIndicator; } set { _asAttorneyIndicator = value; } }
        private Value<bool?> _asRealBrokerIndicator;
        public bool? AsRealBrokerIndicator { get { return _asRealBrokerIndicator; } set { _asRealBrokerIndicator = value; } }
        private Value<bool?> _attorneyForTheBuyerIndicator;
        public bool? AttorneyForTheBuyerIndicator { get { return _attorneyForTheBuyerIndicator; } set { _attorneyForTheBuyerIndicator = value; } }
        private Value<bool?> _attorneyForTheLenderIndicator;
        public bool? AttorneyForTheLenderIndicator { get { return _attorneyForTheLenderIndicator; } set { _attorneyForTheLenderIndicator = value; } }
        private Value<bool?> _attorneyForTheSellerIndicator;
        public bool? AttorneyForTheSellerIndicator { get { return _attorneyForTheSellerIndicator; } set { _attorneyForTheSellerIndicator = value; } }
        private Value<string> _aZCmplBlankSpcsDoc1BlankFldDesc1;
        public string AZCmplBlankSpcsDoc1BlankFldDesc1 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc1; } set { _aZCmplBlankSpcsDoc1BlankFldDesc1 = value; } }
        private Value<string> _aZCmplBlankSpcsDoc1BlankFldDesc2;
        public string AZCmplBlankSpcsDoc1BlankFldDesc2 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc2; } set { _aZCmplBlankSpcsDoc1BlankFldDesc2 = value; } }
        private Value<string> _aZCmplBlankSpcsDoc1BlankFldDesc3;
        public string AZCmplBlankSpcsDoc1BlankFldDesc3 { get { return _aZCmplBlankSpcsDoc1BlankFldDesc3; } set { _aZCmplBlankSpcsDoc1BlankFldDesc3 = value; } }
        private Value<string> _aZCmplBlankSpcsDoc1Nm;
        public string AZCmplBlankSpcsDoc1Nm { get { return _aZCmplBlankSpcsDoc1Nm; } set { _aZCmplBlankSpcsDoc1Nm = value; } }
        private Value<string> _aZCmplBlankSpcsDoc2Nm;
        public string AZCmplBlankSpcsDoc2Nm { get { return _aZCmplBlankSpcsDoc2Nm; } set { _aZCmplBlankSpcsDoc2Nm = value; } }
        private Value<string> _aZCmplBlankSpcsDoc3Nm;
        public string AZCmplBlankSpcsDoc3Nm { get { return _aZCmplBlankSpcsDoc3Nm; } set { _aZCmplBlankSpcsDoc3Nm = value; } }
        private Value<string> _basedOnOthersDescription;
        public string BasedOnOthersDescription { get { return _basedOnOthersDescription; } set { _basedOnOthersDescription = value; } }
        private Value<bool?> _basedOnOthersIndicator;
        public bool? BasedOnOthersIndicator { get { return _basedOnOthersIndicator; } set { _basedOnOthersIndicator = value; } }
        private Value<bool?> _basedOnWholesaleOptionsIndicator;
        public bool? BasedOnWholesaleOptionsIndicator { get { return _basedOnWholesaleOptionsIndicator; } set { _basedOnWholesaleOptionsIndicator = value; } }
        private Value<decimal?> _borrowerElectsEstablishEscrowAmount;
        public decimal? BorrowerElectsEstablishEscrowAmount { get { return _borrowerElectsEstablishEscrowAmount; } set { _borrowerElectsEstablishEscrowAmount = value; } }
        private Value<bool?> _borrowerElectsEstablishEscrowIndicator;
        public bool? BorrowerElectsEstablishEscrowIndicator { get { return _borrowerElectsEstablishEscrowIndicator; } set { _borrowerElectsEstablishEscrowIndicator = value; } }
        private Value<decimal?> _brokerageFeeAddition1;
        public decimal? BrokerageFeeAddition1 { get { return _brokerageFeeAddition1; } set { _brokerageFeeAddition1 = value; } }
        private Value<decimal?> _brokerageFeeAddition2;
        public decimal? BrokerageFeeAddition2 { get { return _brokerageFeeAddition2; } set { _brokerageFeeAddition2 = value; } }
        private Value<decimal?> _brokerageFeeAddition3;
        public decimal? BrokerageFeeAddition3 { get { return _brokerageFeeAddition3; } set { _brokerageFeeAddition3 = value; } }
        private Value<decimal?> _brokerageFeeAmount1;
        public decimal? BrokerageFeeAmount1 { get { return _brokerageFeeAmount1; } set { _brokerageFeeAmount1 = value; } }
        private Value<decimal?> _brokerageFeeAmount2;
        public decimal? BrokerageFeeAmount2 { get { return _brokerageFeeAmount2; } set { _brokerageFeeAmount2 = value; } }
        private Value<decimal?> _brokerageFeeAmount3;
        public decimal? BrokerageFeeAmount3 { get { return _brokerageFeeAmount3; } set { _brokerageFeeAmount3 = value; } }
        private Value<int?> _brokerageFeeDays;
        public int? BrokerageFeeDays { get { return _brokerageFeeDays; } set { _brokerageFeeDays = value; } }
        private Value<decimal?> _brokerageFeePercent1;
        public decimal? BrokerageFeePercent1 { get { return _brokerageFeePercent1; } set { _brokerageFeePercent1 = value; } }
        private Value<decimal?> _brokerageFeePercent2;
        public decimal? BrokerageFeePercent2 { get { return _brokerageFeePercent2; } set { _brokerageFeePercent2 = value; } }
        private Value<decimal?> _brokerageFeePercent3;
        public decimal? BrokerageFeePercent3 { get { return _brokerageFeePercent3; } set { _brokerageFeePercent3 = value; } }
        private Value<string> _brokerAuthorizedSigningRepName;
        public string BrokerAuthorizedSigningRepName { get { return _brokerAuthorizedSigningRepName; } set { _brokerAuthorizedSigningRepName = value; } }
        private Value<string> _brokerAuthorizedSigningRepTitle;
        public string BrokerAuthorizedSigningRepTitle { get { return _brokerAuthorizedSigningRepTitle; } set { _brokerAuthorizedSigningRepTitle = value; } }
        private Value<string> _brokerForTheSeller;
        public string BrokerForTheSeller { get { return _brokerForTheSeller; } set { _brokerForTheSeller = value; } }
        private Value<string> _brokerLicense;
        public string BrokerLicense { get { return _brokerLicense; } set { _brokerLicense = value; } }
        private Value<string> _brokerName;
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }
        private Value<decimal?> _brokerPayAddition;
        public decimal? BrokerPayAddition { get { return _brokerPayAddition; } set { _brokerPayAddition = value; } }
        private Value<decimal?> _brokerPayAmount;
        public decimal? BrokerPayAmount { get { return _brokerPayAmount; } set { _brokerPayAmount = value; } }
        private Value<bool?> _brokerPayIndicator;
        public bool? BrokerPayIndicator { get { return _brokerPayIndicator; } set { _brokerPayIndicator = value; } }
        private Value<decimal?> _brokerPayPercent;
        public decimal? BrokerPayPercent { get { return _brokerPayPercent; } set { _brokerPayPercent = value; } }
        private Value<bool?> _cHARMBookletIndicator;
        public bool? CHARMBookletIndicator { get { return _cHARMBookletIndicator; } set { _cHARMBookletIndicator = value; } }
        private Value<string> _checkPayableTo;
        public string CheckPayableTo { get { return _checkPayableTo; } set { _checkPayableTo = value; } }
        private Value<decimal?> _commitmentAmount;
        public decimal? CommitmentAmount { get { return _commitmentAmount; } set { _commitmentAmount = value; } }
        private Value<string> _commitmentCondition1;
        public string CommitmentCondition1 { get { return _commitmentCondition1; } set { _commitmentCondition1 = value; } }
        private Value<string> _commitmentCondition2;
        public string CommitmentCondition2 { get { return _commitmentCondition2; } set { _commitmentCondition2 = value; } }
        private Value<decimal?> _commitmentFee;
        public decimal? CommitmentFee { get { return _commitmentFee; } set { _commitmentFee = value; } }
        private Value<decimal?> _commitmentPercent;
        public decimal? CommitmentPercent { get { return _commitmentPercent; } set { _commitmentPercent = value; } }
        private Value<decimal?> _compensationAddition;
        public decimal? CompensationAddition { get { return _compensationAddition; } set { _compensationAddition = value; } }
        private Value<decimal?> _compensationPercent;
        public decimal? CompensationPercent { get { return _compensationPercent; } set { _compensationPercent = value; } }
        private Value<decimal?> _creditDeposit;
        public decimal? CreditDeposit { get { return _creditDeposit; } set { _creditDeposit = value; } }
        private Value<string> _creditIsUsedForReason;
        public string CreditIsUsedForReason { get { return _creditIsUsedForReason; } set { _creditIsUsedForReason = value; } }
        private Value<string> _creditReportContact;
        public string CreditReportContact { get { return _creditReportContact; } set { _creditReportContact = value; } }
        private Value<int?> _daysBeforeClosing;
        public int? DaysBeforeClosing { get { return _daysBeforeClosing; } set { _daysBeforeClosing = value; } }
        private Value<decimal?> _depositReceipt;
        public decimal? DepositReceipt { get { return _depositReceipt; } set { _depositReceipt = value; } }
        private Value<bool?> _depositRefundableIndicator;
        public bool? DepositRefundableIndicator { get { return _depositRefundableIndicator; } set { _depositRefundableIndicator = value; } }
        private Value<string> _directContact;
        public string DirectContact { get { return _directContact; } set { _directContact = value; } }
        private Value<decimal?> _directPayAmount;
        public decimal? DirectPayAmount { get { return _directPayAmount; } set { _directPayAmount = value; } }
        private Value<decimal?> _directPayClosing;
        public decimal? DirectPayClosing { get { return _directPayClosing; } set { _directPayClosing = value; } }
        private Value<decimal?> _directPayCommitment;
        public decimal? DirectPayCommitment { get { return _directPayCommitment; } set { _directPayCommitment = value; } }
        private Value<bool?> _directPayIndicator;
        public bool? DirectPayIndicator { get { return _directPayIndicator; } set { _directPayIndicator = value; } }
        private Value<decimal?> _directPayPercent;
        public decimal? DirectPayPercent { get { return _directPayPercent; } set { _directPayPercent = value; } }
        private Value<string> _disclosureDeliveredBy;
        public string DisclosureDeliveredBy { get { return _disclosureDeliveredBy; } set { _disclosureDeliveredBy = value; } }
        private Value<string> _disclosureDeliveredByOtherMethod;
        public string DisclosureDeliveredByOtherMethod { get { return _disclosureDeliveredByOtherMethod; } set { _disclosureDeliveredByOtherMethod = value; } }
        private Value<DateTime?> _disclosureDeliveredDate;
        public DateTime? DisclosureDeliveredDate { get { return _disclosureDeliveredDate; } set { _disclosureDeliveredDate = value; } }
        private Value<bool?> _estimatedChargeShownOnGFEIndicator;
        public bool? EstimatedChargeShownOnGFEIndicator { get { return _estimatedChargeShownOnGFEIndicator; } set { _estimatedChargeShownOnGFEIndicator = value; } }
        private Value<DateTime?> _expirationDate;
        public DateTime? ExpirationDate { get { return _expirationDate; } set { _expirationDate = value; } }
        private Value<decimal?> _federallySubsidizedAmount;
        public decimal? FederallySubsidizedAmount { get { return _federallySubsidizedAmount; } set { _federallySubsidizedAmount = value; } }
        private Value<decimal?> _federallySubsidizedAmountPercentage;
        public decimal? FederallySubsidizedAmountPercentage { get { return _federallySubsidizedAmountPercentage; } set { _federallySubsidizedAmountPercentage = value; } }
        private Value<decimal?> _feeReceived1;
        public decimal? FeeReceived1 { get { return _feeReceived1; } set { _feeReceived1 = value; } }
        private Value<decimal?> _feeReceived2;
        public decimal? FeeReceived2 { get { return _feeReceived2; } set { _feeReceived2 = value; } }
        private Value<string> _feeReceivedByLender;
        public string FeeReceivedByLender { get { return _feeReceivedByLender; } set { _feeReceivedByLender = value; } }
        private Value<decimal?> _feesReceiving;
        public decimal? FeesReceiving { get { return _feesReceiving; } set { _feesReceiving = value; } }
        private Value<decimal?> _floridaApplicationFee;
        public decimal? FloridaApplicationFee { get { return _floridaApplicationFee; } set { _floridaApplicationFee = value; } }
        private Value<decimal?> _floridaOtherFee1;
        public decimal? FloridaOtherFee1 { get { return _floridaOtherFee1; } set { _floridaOtherFee1 = value; } }
        private Value<decimal?> _floridaOtherFee2;
        public decimal? FloridaOtherFee2 { get { return _floridaOtherFee2; } set { _floridaOtherFee2 = value; } }
        private Value<string> _floridaOtherFeeTo1;
        public string FloridaOtherFeeTo1 { get { return _floridaOtherFeeTo1; } set { _floridaOtherFeeTo1 = value; } }
        private Value<string> _floridaOtherFeeTo2;
        public string FloridaOtherFeeTo2 { get { return _floridaOtherFeeTo2; } set { _floridaOtherFeeTo2 = value; } }
        private Value<string> _floridaOtherFeeTo3;
        public string FloridaOtherFeeTo3 { get { return _floridaOtherFeeTo3; } set { _floridaOtherFeeTo3 = value; } }
        private Value<string> _floridaOtherFeeTo4;
        public string FloridaOtherFeeTo4 { get { return _floridaOtherFeeTo4; } set { _floridaOtherFeeTo4 = value; } }
        private Value<string> _furtherFeesEarnedByMortgageBroker;
        public string FurtherFeesEarnedByMortgageBroker { get { return _furtherFeesEarnedByMortgageBroker; } set { _furtherFeesEarnedByMortgageBroker = value; } }
        private Value<decimal?> _gFEFeeReceived1;
        public decimal? GFEFeeReceived1 { get { return _gFEFeeReceived1; } set { _gFEFeeReceived1 = value; } }
        private Value<decimal?> _gFEFeeReceived2;
        public decimal? GFEFeeReceived2 { get { return _gFEFeeReceived2; } set { _gFEFeeReceived2 = value; } }
        private Value<bool?> _hUDBookletIndicator;
        public bool? HUDBookletIndicator { get { return _hUDBookletIndicator; } set { _hUDBookletIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _independentContractorIndicator;
        public bool? IndependentContractorIndicator { get { return _independentContractorIndicator; } set { _independentContractorIndicator = value; } }
        private Value<string> _indexUsed;
        public string IndexUsed { get { return _indexUsed; } set { _indexUsed = value; } }
        private Value<string> _informationAboutTheIndexCanBeFound;
        public string InformationAboutTheIndexCanBeFound { get { return _informationAboutTheIndexCanBeFound; } set { _informationAboutTheIndexCanBeFound = value; } }
        private Value<string> _inLicensedNo;
        public string InLicensedNo { get { return _inLicensedNo; } set { _inLicensedNo = value; } }
        private Value<string> _inLicensedType;
        public string InLicensedType { get { return _inLicensedType; } set { _inLicensedType = value; } }
        private Value<bool?> _isEstimateIndicator;
        public bool? IsEstimateIndicator { get { return _isEstimateIndicator; } set { _isEstimateIndicator = value; } }
        private Value<bool?> _ksUcccElectionIndicator;
        public bool? KsUcccElectionIndicator { get { return _ksUcccElectionIndicator; } set { _ksUcccElectionIndicator = value; } }
        private Value<bool?> _kyHomeSolicationLoanIndicator;
        public bool? KyHomeSolicationLoanIndicator { get { return _kyHomeSolicationLoanIndicator; } set { _kyHomeSolicationLoanIndicator = value; } }
        private Value<DateTime?> _leaseAgreementDate;
        public DateTime? LeaseAgreementDate { get { return _leaseAgreementDate; } set { _leaseAgreementDate = value; } }
        private Value<DateTime?> _lenderDate;
        public DateTime? LenderDate { get { return _lenderDate; } set { _lenderDate = value; } }
        private Value<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private Value<decimal?> _lenderPaid;
        public decimal? LenderPaid { get { return _lenderPaid; } set { _lenderPaid = value; } }
        private Value<decimal?> _lenderPayAmount;
        public decimal? LenderPayAmount { get { return _lenderPayAmount; } set { _lenderPayAmount = value; } }
        private Value<bool?> _lenderPayIndicator;
        public bool? LenderPayIndicator { get { return _lenderPayIndicator; } set { _lenderPayIndicator = value; } }
        private Value<decimal?> _lenderPayMaxPoint;
        public decimal? LenderPayMaxPoint { get { return _lenderPayMaxPoint; } set { _lenderPayMaxPoint = value; } }
        private Value<decimal?> _lenderPayPercent;
        public decimal? LenderPayPercent { get { return _lenderPayPercent; } set { _lenderPayPercent = value; } }
        private Value<decimal?> _lenderPayPoint;
        public decimal? LenderPayPoint { get { return _lenderPayPoint; } set { _lenderPayPoint = value; } }
        private Value<bool?> _lenderPayUnknownIndicator;
        public bool? LenderPayUnknownIndicator { get { return _lenderPayUnknownIndicator; } set { _lenderPayUnknownIndicator = value; } }
        private Value<string> _lenderStatus;
        public string LenderStatus { get { return _lenderStatus; } set { _lenderStatus = value; } }
        private Value<string> _lessorName;
        public string LessorName { get { return _lessorName; } set { _lessorName = value; } }
        private Value<bool?> _loanTermsFixedThroughDateofLoanClosingIndicator;
        public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get { return _loanTermsFixedThroughDateofLoanClosingIndicator; } set { _loanTermsFixedThroughDateofLoanClosingIndicator = value; } }
        private Value<decimal?> _lockInFee;
        public decimal? LockInFee { get { return _lockInFee; } set { _lockInFee = value; } }
        private Value<string> _methodDescription;
        public string MethodDescription { get { return _methodDescription; } set { _methodDescription = value; } }
        private Value<string> _methodDetermine;
        public string MethodDetermine { get { return _methodDetermine; } set { _methodDetermine = value; } }
        private Value<bool?> _mortgageAgreementIndicator;
        public bool? MortgageAgreementIndicator { get { return _mortgageAgreementIndicator; } set { _mortgageAgreementIndicator = value; } }
        private Value<string> _mtgBrokerLicense;
        public string MtgBrokerLicense { get { return _mtgBrokerLicense; } set { _mtgBrokerLicense = value; } }
        private Value<string> _nameOfLicensee;
        public string NameOfLicensee { get { return _nameOfLicensee; } set { _nameOfLicensee = value; } }
        private Value<decimal?> _newMoneyAmount;
        public decimal? NewMoneyAmount { get { return _newMoneyAmount; } set { _newMoneyAmount = value; } }
        private Value<decimal?> _newYorkApplicationFee;
        public decimal? NewYorkApplicationFee { get { return _newYorkApplicationFee; } set { _newYorkApplicationFee = value; } }
        private Value<decimal?> _newYorkAppraisalFee;
        public decimal? NewYorkAppraisalFee { get { return _newYorkAppraisalFee; } set { _newYorkAppraisalFee = value; } }
        private Value<decimal?> _newYorkCreditReportFee;
        public decimal? NewYorkCreditReportFee { get { return _newYorkCreditReportFee; } set { _newYorkCreditReportFee = value; } }
        private Value<List<NewYorkFee>> _newYorkFees;
        public List<NewYorkFee> NewYorkFees { get { return _newYorkFees; } set { _newYorkFees = value; } }
        private Value<List<NewYorkPrimaryLender>> _newYorkPrimaryLenders;
        public List<NewYorkPrimaryLender> NewYorkPrimaryLenders { get { return _newYorkPrimaryLenders; } set { _newYorkPrimaryLenders = value; } }
        private Value<decimal?> _newYorkProcessingFee;
        public decimal? NewYorkProcessingFee { get { return _newYorkProcessingFee; } set { _newYorkProcessingFee = value; } }
        private Value<decimal?> _notRefundableAmount;
        public decimal? NotRefundableAmount { get { return _notRefundableAmount; } set { _notRefundableAmount = value; } }
        private Value<bool?> _offerRetailPriceIndicator;
        public bool? OfferRetailPriceIndicator { get { return _offerRetailPriceIndicator; } set { _offerRetailPriceIndicator = value; } }
        private Value<decimal?> _originalAcquisitionCost;
        public decimal? OriginalAcquisitionCost { get { return _originalAcquisitionCost; } set { _originalAcquisitionCost = value; } }
        private Value<decimal?> _originationFeeChargedAmount;
        public decimal? OriginationFeeChargedAmount { get { return _originationFeeChargedAmount; } set { _originationFeeChargedAmount = value; } }
        private Value<bool?> _originationFeeChargedIndicator;
        public bool? OriginationFeeChargedIndicator { get { return _originationFeeChargedIndicator; } set { _originationFeeChargedIndicator = value; } }
        private Value<decimal?> _originationFeeDecreasesRate;
        public decimal? OriginationFeeDecreasesRate { get { return _originationFeeDecreasesRate; } set { _originationFeeDecreasesRate = value; } }
        private Value<decimal?> _originationFeeIncreasesRate;
        public decimal? OriginationFeeIncreasesRate { get { return _originationFeeIncreasesRate; } set { _originationFeeIncreasesRate = value; } }
        private Value<string> _originationFeeInterestRateImpactedStatus;
        public string OriginationFeeInterestRateImpactedStatus { get { return _originationFeeInterestRateImpactedStatus; } set { _originationFeeInterestRateImpactedStatus = value; } }
        private Value<string> _originationFeePaidBy;
        public string OriginationFeePaidBy { get { return _originationFeePaidBy; } set { _originationFeePaidBy = value; } }
        private Value<decimal?> _paidByBorrower;
        public decimal? PaidByBorrower { get { return _paidByBorrower; } set { _paidByBorrower = value; } }
        private Value<decimal?> _paidByLender;
        public decimal? PaidByLender { get { return _paidByLender; } set { _paidByLender = value; } }
        private Value<decimal?> _paidByOther1;
        public decimal? PaidByOther1 { get { return _paidByOther1; } set { _paidByOther1 = value; } }
        private Value<decimal?> _paidByOther2;
        public decimal? PaidByOther2 { get { return _paidByOther2; } set { _paidByOther2 = value; } }
        private Value<string> _paidByOtherDescription1;
        public string PaidByOtherDescription1 { get { return _paidByOtherDescription1; } set { _paidByOtherDescription1 = value; } }
        private Value<string> _paidByOtherDescription2;
        public string PaidByOtherDescription2 { get { return _paidByOtherDescription2; } set { _paidByOtherDescription2 = value; } }
        private Value<decimal?> _previousMortgageAmountOne;
        public decimal? PreviousMortgageAmountOne { get { return _previousMortgageAmountOne; } set { _previousMortgageAmountOne = value; } }
        private Value<decimal?> _previousMortgageAmountTwo;
        public decimal? PreviousMortgageAmountTwo { get { return _previousMortgageAmountTwo; } set { _previousMortgageAmountTwo = value; } }
        private Value<bool?> _printCertificationOfCosts;
        public bool? PrintCertificationOfCosts { get { return _printCertificationOfCosts; } set { _printCertificationOfCosts = value; } }
        private Value<bool?> _printInterestRateReductionRider;
        public bool? PrintInterestRateReductionRider { get { return _printInterestRateReductionRider; } set { _printInterestRateReductionRider = value; } }
        private Value<bool?> _printMDDeliveryIndicator;
        public bool? PrintMDDeliveryIndicator { get { return _printMDDeliveryIndicator; } set { _printMDDeliveryIndicator = value; } }
        private Value<string> _providedBy;
        public string ProvidedBy { get { return _providedBy; } set { _providedBy = value; } }
        private Value<string> _questionContact;
        public string QuestionContact { get { return _questionContact; } set { _questionContact = value; } }
        private Value<string> _questionContactPhone;
        public string QuestionContactPhone { get { return _questionContactPhone; } set { _questionContactPhone = value; } }
        private Value<string> _questionContactTollFree;
        public string QuestionContactTollFree { get { return _questionContactTollFree; } set { _questionContactTollFree = value; } }
        private Value<bool?> _rateLockHonoredIndicator;
        public bool? RateLockHonoredIndicator { get { return _rateLockHonoredIndicator; } set { _rateLockHonoredIndicator = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<decimal?> _refinancingFee;
        public decimal? RefinancingFee { get { return _refinancingFee; } set { _refinancingFee = value; } }
        private Value<string> _refundableBy;
        public string RefundableBy { get { return _refundableBy; } set { _refundableBy = value; } }
        private Value<bool?> _refundableIndicator;
        public bool? RefundableIndicator { get { return _refundableIndicator; } set { _refundableIndicator = value; } }
        private Value<string> _refundableType;
        public string RefundableType { get { return _refundableType; } set { _refundableType = value; } }
        private Value<string> _refundCondition1;
        public string RefundCondition1 { get { return _refundCondition1; } set { _refundCondition1 = value; } }
        private Value<string> _refundCondition2;
        public string RefundCondition2 { get { return _refundCondition2; } set { _refundCondition2 = value; } }
        private Value<string> _refundCondition3;
        public string RefundCondition3 { get { return _refundCondition3; } set { _refundCondition3 = value; } }
        private Value<string> _refundCondition4;
        public string RefundCondition4 { get { return _refundCondition4; } set { _refundCondition4 = value; } }
        private Value<string> _refundCondition5;
        public string RefundCondition5 { get { return _refundCondition5; } set { _refundCondition5 = value; } }
        private Value<string> _refundCondition6;
        public string RefundCondition6 { get { return _refundCondition6; } set { _refundCondition6 = value; } }
        private Value<string> _regulatorAddress;
        public string RegulatorAddress { get { return _regulatorAddress; } set { _regulatorAddress = value; } }
        private Value<string> _regulatorCity;
        public string RegulatorCity { get { return _regulatorCity; } set { _regulatorCity = value; } }
        private Value<string> _regulatorMailingAddress;
        public string RegulatorMailingAddress { get { return _regulatorMailingAddress; } set { _regulatorMailingAddress = value; } }
        private Value<string> _regulatorMailingCity;
        public string RegulatorMailingCity { get { return _regulatorMailingCity; } set { _regulatorMailingCity = value; } }
        private Value<string> _regulatorMailingState;
        public string RegulatorMailingState { get { return _regulatorMailingState; } set { _regulatorMailingState = value; } }
        private Value<string> _regulatorMailingZipCode;
        public string RegulatorMailingZipCode { get { return _regulatorMailingZipCode; } set { _regulatorMailingZipCode = value; } }
        private Value<string> _regulatorPhone;
        public string RegulatorPhone { get { return _regulatorPhone; } set { _regulatorPhone = value; } }
        private Value<string> _regulatorState;
        public string RegulatorState { get { return _regulatorState; } set { _regulatorState = value; } }
        private Value<string> _regulatorTollFreePhone;
        public string RegulatorTollFreePhone { get { return _regulatorTollFreePhone; } set { _regulatorTollFreePhone = value; } }
        private Value<string> _regulatorWebAddress;
        public string RegulatorWebAddress { get { return _regulatorWebAddress; } set { _regulatorWebAddress = value; } }
        private Value<string> _regulatorZipCode;
        public string RegulatorZipCode { get { return _regulatorZipCode; } set { _regulatorZipCode = value; } }
        private Value<string> _scheduleOfChargesEstimatedFinalIndicator;
        public string ScheduleOfChargesEstimatedFinalIndicator { get { return _scheduleOfChargesEstimatedFinalIndicator; } set { _scheduleOfChargesEstimatedFinalIndicator = value; } }
        private Value<string> _scRegulatoryAgencyType;
        public string ScRegulatoryAgencyType { get { return _scRegulatoryAgencyType; } set { _scRegulatoryAgencyType = value; } }
        private Value<bool?> _selectDivisionFeesIndicator;
        public bool? SelectDivisionFeesIndicator { get { return _selectDivisionFeesIndicator; } set { _selectDivisionFeesIndicator = value; } }
        private Value<bool?> _selectPrimaryLenderIndicator;
        public bool? SelectPrimaryLenderIndicator { get { return _selectPrimaryLenderIndicator; } set { _selectPrimaryLenderIndicator = value; } }
        private Value<bool?> _selectPrivateLenderIndicator;
        public bool? SelectPrivateLenderIndicator { get { return _selectPrivateLenderIndicator; } set { _selectPrivateLenderIndicator = value; } }
        private Value<decimal?> _servicingFeeChargedAmount;
        public decimal? ServicingFeeChargedAmount { get { return _servicingFeeChargedAmount; } set { _servicingFeeChargedAmount = value; } }
        private Value<bool?> _servicingFeeChargedIndicator;
        public bool? ServicingFeeChargedIndicator { get { return _servicingFeeChargedIndicator; } set { _servicingFeeChargedIndicator = value; } }
        private Value<string> _servicingFeePaidBy;
        public string ServicingFeePaidBy { get { return _servicingFeePaidBy; } set { _servicingFeePaidBy = value; } }
        private Value<string> _servicingFeePaidFrequence;
        public string ServicingFeePaidFrequence { get { return _servicingFeePaidFrequence; } set { _servicingFeePaidFrequence = value; } }
        private Value<bool?> _signedByBorrowerIndicator;
        public bool? SignedByBorrowerIndicator { get { return _signedByBorrowerIndicator; } set { _signedByBorrowerIndicator = value; } }
        private Value<bool?> _specificARMIndicator;
        public bool? SpecificARMIndicator { get { return _specificARMIndicator; } set { _specificARMIndicator = value; } }
        private Value<bool?> _submitToLenderIndicator;
        public bool? SubmitToLenderIndicator { get { return _submitToLenderIndicator; } set { _submitToLenderIndicator = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationAssessments;
        public decimal? TaxExemptAcquisitionCostCertificationAssessments { get { return _taxExemptAcquisitionCostCertificationAssessments; } set { _taxExemptAcquisitionCostCertificationAssessments = value; } }
        private Value<string> _taxExemptAcquisitionCostCertificationOther;
        public string TaxExemptAcquisitionCostCertificationOther { get { return _taxExemptAcquisitionCostCertificationOther; } set { _taxExemptAcquisitionCostCertificationOther = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationOtherAmount;
        public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get { return _taxExemptAcquisitionCostCertificationOtherAmount; } set { _taxExemptAcquisitionCostCertificationOtherAmount = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationOwnersTitleInsurance;
        public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get { return _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; } set { _taxExemptAcquisitionCostCertificationOwnersTitleInsurance = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationRealEstateCommission;
        public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get { return _taxExemptAcquisitionCostCertificationRealEstateCommission; } set { _taxExemptAcquisitionCostCertificationRealEstateCommission = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationRepairsImprovements;
        public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get { return _taxExemptAcquisitionCostCertificationRepairsImprovements; } set { _taxExemptAcquisitionCostCertificationRepairsImprovements = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationSurvey;
        public decimal? TaxExemptAcquisitionCostCertificationSurvey { get { return _taxExemptAcquisitionCostCertificationSurvey; } set { _taxExemptAcquisitionCostCertificationSurvey = value; } }
        private Value<decimal?> _taxExemptAcquisitionCostCertificationTotalAdjustments;
        public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get { return _taxExemptAcquisitionCostCertificationTotalAdjustments; } set { _taxExemptAcquisitionCostCertificationTotalAdjustments = value; } }
        private Value<string> _termsChange;
        public string TermsChange { get { return _termsChange; } set { _termsChange = value; } }
        private Value<decimal?> _texasApplicationFee;
        public decimal? TexasApplicationFee { get { return _texasApplicationFee; } set { _texasApplicationFee = value; } }
        private Value<decimal?> _texasAppraisalFee;
        public decimal? TexasAppraisalFee { get { return _texasAppraisalFee; } set { _texasAppraisalFee = value; } }
        private Value<decimal?> _texasCreditReportFee;
        public decimal? TexasCreditReportFee { get { return _texasCreditReportFee; } set { _texasCreditReportFee = value; } }
        private Value<decimal?> _texasOtherFee1;
        public decimal? TexasOtherFee1 { get { return _texasOtherFee1; } set { _texasOtherFee1 = value; } }
        private Value<decimal?> _texasOtherFee2;
        public decimal? TexasOtherFee2 { get { return _texasOtherFee2; } set { _texasOtherFee2 = value; } }
        private Value<string> _texasOtherFeeContact1;
        public string TexasOtherFeeContact1 { get { return _texasOtherFeeContact1; } set { _texasOtherFeeContact1 = value; } }
        private Value<string> _texasOtherFeeContact2;
        public string TexasOtherFeeContact2 { get { return _texasOtherFeeContact2; } set { _texasOtherFeeContact2 = value; } }
        private Value<decimal?> _texasProcessingFee;
        public decimal? TexasProcessingFee { get { return _texasProcessingFee; } set { _texasProcessingFee = value; } }
        private Value<decimal?> _thirdPartyFee;
        public decimal? ThirdPartyFee { get { return _thirdPartyFee; } set { _thirdPartyFee = value; } }
        private Value<decimal?> _totalFee;
        public decimal? TotalFee { get { return _totalFee; } set { _totalFee = value; } }
        private Value<decimal?> _transferFeeChargedAmount;
        public decimal? TransferFeeChargedAmount { get { return _transferFeeChargedAmount; } set { _transferFeeChargedAmount = value; } }
        private Value<bool?> _transferFeeChargedIndicator;
        public bool? TransferFeeChargedIndicator { get { return _transferFeeChargedIndicator; } set { _transferFeeChargedIndicator = value; } }
        private Value<string> _transferFeePaidBy;
        public string TransferFeePaidBy { get { return _transferFeePaidBy; } set { _transferFeePaidBy = value; } }
        private Value<bool?> _txVeteransLandBoardIndicator;
        public bool? TxVeteransLandBoardIndicator { get { return _txVeteransLandBoardIndicator; } set { _txVeteransLandBoardIndicator = value; } }
        private Value<string> _typeOfProperty;
        public string TypeOfProperty { get { return _typeOfProperty; } set { _typeOfProperty = value; } }
        private Value<string> _underwritingContact;
        public string UnderwritingContact { get { return _underwritingContact; } set { _underwritingContact = value; } }
        private Value<decimal?> _underwritingFee;
        public decimal? UnderwritingFee { get { return _underwritingFee; } set { _underwritingFee = value; } }
        private Value<decimal?> _ySPChargedAmount;
        public decimal? YSPChargedAmount { get { return _ySPChargedAmount; } set { _ySPChargedAmount = value; } }
        private Value<bool?> _ySPChargedIndicator;
        public bool? YSPChargedIndicator { get { return _ySPChargedIndicator; } set { _ySPChargedIndicator = value; } }
        private Value<decimal?> _ySPDecreasesRate;
        public decimal? YSPDecreasesRate { get { return _ySPDecreasesRate; } set { _ySPDecreasesRate = value; } }
        private Value<decimal?> _ySPIncreasesRate;
        public decimal? YSPIncreasesRate { get { return _ySPIncreasesRate; } set { _ySPIncreasesRate = value; } }
        private Value<string> _ySPInterestRateImpactedStatus;
        public string YSPInterestRateImpactedStatus { get { return _ySPInterestRateImpactedStatus; } set { _ySPInterestRateImpactedStatus = value; } }
        private Value<string> _ySPPaidBy;
        public string YSPPaidBy { get { return _ySPPaidBy; } set { _ySPPaidBy = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acceptedByBorrowerIndicator.Clean
                    && _acceptedDate.Clean
                    && _actingOtherDescription1.Clean
                    && _actingOtherDescription2.Clean
                    && _actingOthersIndicator.Clean
                    && _advFeeAgmtInEfctNumDay.Clean
                    && _advisoryCondition1.Clean
                    && _advisoryCondition2.Clean
                    && _advisoryCondition3.Clean
                    && _advisoryCondition4.Clean
                    && _amendedAcquisitionCost.Clean
                    && _applicationDate.Clean
                    && _appraisalContact.Clean
                    && _appraisalDeposit.Clean
                    && _areas.Clean
                    && _asAttorneyIndicator.Clean
                    && _asRealBrokerIndicator.Clean
                    && _attorneyForTheBuyerIndicator.Clean
                    && _attorneyForTheLenderIndicator.Clean
                    && _attorneyForTheSellerIndicator.Clean
                    && _aZCmplBlankSpcsDoc1BlankFldDesc1.Clean
                    && _aZCmplBlankSpcsDoc1BlankFldDesc2.Clean
                    && _aZCmplBlankSpcsDoc1BlankFldDesc3.Clean
                    && _aZCmplBlankSpcsDoc1Nm.Clean
                    && _aZCmplBlankSpcsDoc2Nm.Clean
                    && _aZCmplBlankSpcsDoc3Nm.Clean
                    && _basedOnOthersDescription.Clean
                    && _basedOnOthersIndicator.Clean
                    && _basedOnWholesaleOptionsIndicator.Clean
                    && _borrowerElectsEstablishEscrowAmount.Clean
                    && _borrowerElectsEstablishEscrowIndicator.Clean
                    && _brokerageFeeAddition1.Clean
                    && _brokerageFeeAddition2.Clean
                    && _brokerageFeeAddition3.Clean
                    && _brokerageFeeAmount1.Clean
                    && _brokerageFeeAmount2.Clean
                    && _brokerageFeeAmount3.Clean
                    && _brokerageFeeDays.Clean
                    && _brokerageFeePercent1.Clean
                    && _brokerageFeePercent2.Clean
                    && _brokerageFeePercent3.Clean
                    && _brokerAuthorizedSigningRepName.Clean
                    && _brokerAuthorizedSigningRepTitle.Clean
                    && _brokerForTheSeller.Clean
                    && _brokerLicense.Clean
                    && _brokerName.Clean
                    && _brokerPayAddition.Clean
                    && _brokerPayAmount.Clean
                    && _brokerPayIndicator.Clean
                    && _brokerPayPercent.Clean
                    && _cHARMBookletIndicator.Clean
                    && _checkPayableTo.Clean
                    && _commitmentAmount.Clean
                    && _commitmentCondition1.Clean
                    && _commitmentCondition2.Clean
                    && _commitmentFee.Clean
                    && _commitmentPercent.Clean
                    && _compensationAddition.Clean
                    && _compensationPercent.Clean
                    && _creditDeposit.Clean
                    && _creditIsUsedForReason.Clean
                    && _creditReportContact.Clean
                    && _daysBeforeClosing.Clean
                    && _depositReceipt.Clean
                    && _depositRefundableIndicator.Clean
                    && _directContact.Clean
                    && _directPayAmount.Clean
                    && _directPayClosing.Clean
                    && _directPayCommitment.Clean
                    && _directPayIndicator.Clean
                    && _directPayPercent.Clean
                    && _disclosureDeliveredBy.Clean
                    && _disclosureDeliveredByOtherMethod.Clean
                    && _disclosureDeliveredDate.Clean
                    && _estimatedChargeShownOnGFEIndicator.Clean
                    && _expirationDate.Clean
                    && _federallySubsidizedAmount.Clean
                    && _federallySubsidizedAmountPercentage.Clean
                    && _feeReceived1.Clean
                    && _feeReceived2.Clean
                    && _feeReceivedByLender.Clean
                    && _feesReceiving.Clean
                    && _floridaApplicationFee.Clean
                    && _floridaOtherFee1.Clean
                    && _floridaOtherFee2.Clean
                    && _floridaOtherFeeTo1.Clean
                    && _floridaOtherFeeTo2.Clean
                    && _floridaOtherFeeTo3.Clean
                    && _floridaOtherFeeTo4.Clean
                    && _furtherFeesEarnedByMortgageBroker.Clean
                    && _gFEFeeReceived1.Clean
                    && _gFEFeeReceived2.Clean
                    && _hUDBookletIndicator.Clean
                    && _id.Clean
                    && _independentContractorIndicator.Clean
                    && _indexUsed.Clean
                    && _informationAboutTheIndexCanBeFound.Clean
                    && _inLicensedNo.Clean
                    && _inLicensedType.Clean
                    && _isEstimateIndicator.Clean
                    && _ksUcccElectionIndicator.Clean
                    && _kyHomeSolicationLoanIndicator.Clean
                    && _leaseAgreementDate.Clean
                    && _lenderDate.Clean
                    && _lenderName.Clean
                    && _lenderPaid.Clean
                    && _lenderPayAmount.Clean
                    && _lenderPayIndicator.Clean
                    && _lenderPayMaxPoint.Clean
                    && _lenderPayPercent.Clean
                    && _lenderPayPoint.Clean
                    && _lenderPayUnknownIndicator.Clean
                    && _lenderStatus.Clean
                    && _lessorName.Clean
                    && _loanTermsFixedThroughDateofLoanClosingIndicator.Clean
                    && _lockInFee.Clean
                    && _methodDescription.Clean
                    && _methodDetermine.Clean
                    && _mortgageAgreementIndicator.Clean
                    && _mtgBrokerLicense.Clean
                    && _nameOfLicensee.Clean
                    && _newMoneyAmount.Clean
                    && _newYorkApplicationFee.Clean
                    && _newYorkAppraisalFee.Clean
                    && _newYorkCreditReportFee.Clean
                    && _newYorkFees.Clean
                    && _newYorkPrimaryLenders.Clean
                    && _newYorkProcessingFee.Clean
                    && _notRefundableAmount.Clean
                    && _offerRetailPriceIndicator.Clean
                    && _originalAcquisitionCost.Clean
                    && _originationFeeChargedAmount.Clean
                    && _originationFeeChargedIndicator.Clean
                    && _originationFeeDecreasesRate.Clean
                    && _originationFeeIncreasesRate.Clean
                    && _originationFeeInterestRateImpactedStatus.Clean
                    && _originationFeePaidBy.Clean
                    && _paidByBorrower.Clean
                    && _paidByLender.Clean
                    && _paidByOther1.Clean
                    && _paidByOther2.Clean
                    && _paidByOtherDescription1.Clean
                    && _paidByOtherDescription2.Clean
                    && _previousMortgageAmountOne.Clean
                    && _previousMortgageAmountTwo.Clean
                    && _printCertificationOfCosts.Clean
                    && _printInterestRateReductionRider.Clean
                    && _printMDDeliveryIndicator.Clean
                    && _providedBy.Clean
                    && _questionContact.Clean
                    && _questionContactPhone.Clean
                    && _questionContactTollFree.Clean
                    && _rateLockHonoredIndicator.Clean
                    && _receivedBy.Clean
                    && _refinancingFee.Clean
                    && _refundableBy.Clean
                    && _refundableIndicator.Clean
                    && _refundableType.Clean
                    && _refundCondition1.Clean
                    && _refundCondition2.Clean
                    && _refundCondition3.Clean
                    && _refundCondition4.Clean
                    && _refundCondition5.Clean
                    && _refundCondition6.Clean
                    && _regulatorAddress.Clean
                    && _regulatorCity.Clean
                    && _regulatorMailingAddress.Clean
                    && _regulatorMailingCity.Clean
                    && _regulatorMailingState.Clean
                    && _regulatorMailingZipCode.Clean
                    && _regulatorPhone.Clean
                    && _regulatorState.Clean
                    && _regulatorTollFreePhone.Clean
                    && _regulatorWebAddress.Clean
                    && _regulatorZipCode.Clean
                    && _scheduleOfChargesEstimatedFinalIndicator.Clean
                    && _scRegulatoryAgencyType.Clean
                    && _selectDivisionFeesIndicator.Clean
                    && _selectPrimaryLenderIndicator.Clean
                    && _selectPrivateLenderIndicator.Clean
                    && _servicingFeeChargedAmount.Clean
                    && _servicingFeeChargedIndicator.Clean
                    && _servicingFeePaidBy.Clean
                    && _servicingFeePaidFrequence.Clean
                    && _signedByBorrowerIndicator.Clean
                    && _specificARMIndicator.Clean
                    && _submitToLenderIndicator.Clean
                    && _taxExemptAcquisitionCostCertificationAssessments.Clean
                    && _taxExemptAcquisitionCostCertificationOther.Clean
                    && _taxExemptAcquisitionCostCertificationOtherAmount.Clean
                    && _taxExemptAcquisitionCostCertificationOwnersTitleInsurance.Clean
                    && _taxExemptAcquisitionCostCertificationRealEstateCommission.Clean
                    && _taxExemptAcquisitionCostCertificationRepairsImprovements.Clean
                    && _taxExemptAcquisitionCostCertificationSurvey.Clean
                    && _taxExemptAcquisitionCostCertificationTotalAdjustments.Clean
                    && _termsChange.Clean
                    && _texasApplicationFee.Clean
                    && _texasAppraisalFee.Clean
                    && _texasCreditReportFee.Clean
                    && _texasOtherFee1.Clean
                    && _texasOtherFee2.Clean
                    && _texasOtherFeeContact1.Clean
                    && _texasOtherFeeContact2.Clean
                    && _texasProcessingFee.Clean
                    && _thirdPartyFee.Clean
                    && _totalFee.Clean
                    && _transferFeeChargedAmount.Clean
                    && _transferFeeChargedIndicator.Clean
                    && _transferFeePaidBy.Clean
                    && _txVeteransLandBoardIndicator.Clean
                    && _typeOfProperty.Clean
                    && _underwritingContact.Clean
                    && _underwritingFee.Clean
                    && _ySPChargedAmount.Clean
                    && _ySPChargedIndicator.Clean
                    && _ySPDecreasesRate.Clean
                    && _ySPIncreasesRate.Clean
                    && _ySPInterestRateImpactedStatus.Clean
                    && _ySPPaidBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var acceptedByBorrowerIndicator = _acceptedByBorrowerIndicator; acceptedByBorrowerIndicator.Clean = value; _acceptedByBorrowerIndicator = acceptedByBorrowerIndicator;
                var acceptedDate = _acceptedDate; acceptedDate.Clean = value; _acceptedDate = acceptedDate;
                var actingOtherDescription1 = _actingOtherDescription1; actingOtherDescription1.Clean = value; _actingOtherDescription1 = actingOtherDescription1;
                var actingOtherDescription2 = _actingOtherDescription2; actingOtherDescription2.Clean = value; _actingOtherDescription2 = actingOtherDescription2;
                var actingOthersIndicator = _actingOthersIndicator; actingOthersIndicator.Clean = value; _actingOthersIndicator = actingOthersIndicator;
                var advFeeAgmtInEfctNumDay = _advFeeAgmtInEfctNumDay; advFeeAgmtInEfctNumDay.Clean = value; _advFeeAgmtInEfctNumDay = advFeeAgmtInEfctNumDay;
                var advisoryCondition1 = _advisoryCondition1; advisoryCondition1.Clean = value; _advisoryCondition1 = advisoryCondition1;
                var advisoryCondition2 = _advisoryCondition2; advisoryCondition2.Clean = value; _advisoryCondition2 = advisoryCondition2;
                var advisoryCondition3 = _advisoryCondition3; advisoryCondition3.Clean = value; _advisoryCondition3 = advisoryCondition3;
                var advisoryCondition4 = _advisoryCondition4; advisoryCondition4.Clean = value; _advisoryCondition4 = advisoryCondition4;
                var amendedAcquisitionCost = _amendedAcquisitionCost; amendedAcquisitionCost.Clean = value; _amendedAcquisitionCost = amendedAcquisitionCost;
                var applicationDate = _applicationDate; applicationDate.Clean = value; _applicationDate = applicationDate;
                var appraisalContact = _appraisalContact; appraisalContact.Clean = value; _appraisalContact = appraisalContact;
                var appraisalDeposit = _appraisalDeposit; appraisalDeposit.Clean = value; _appraisalDeposit = appraisalDeposit;
                var areas = _areas; areas.Clean = value; _areas = areas;
                var asAttorneyIndicator = _asAttorneyIndicator; asAttorneyIndicator.Clean = value; _asAttorneyIndicator = asAttorneyIndicator;
                var asRealBrokerIndicator = _asRealBrokerIndicator; asRealBrokerIndicator.Clean = value; _asRealBrokerIndicator = asRealBrokerIndicator;
                var attorneyForTheBuyerIndicator = _attorneyForTheBuyerIndicator; attorneyForTheBuyerIndicator.Clean = value; _attorneyForTheBuyerIndicator = attorneyForTheBuyerIndicator;
                var attorneyForTheLenderIndicator = _attorneyForTheLenderIndicator; attorneyForTheLenderIndicator.Clean = value; _attorneyForTheLenderIndicator = attorneyForTheLenderIndicator;
                var attorneyForTheSellerIndicator = _attorneyForTheSellerIndicator; attorneyForTheSellerIndicator.Clean = value; _attorneyForTheSellerIndicator = attorneyForTheSellerIndicator;
                var aZCmplBlankSpcsDoc1BlankFldDesc1 = _aZCmplBlankSpcsDoc1BlankFldDesc1; aZCmplBlankSpcsDoc1BlankFldDesc1.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc1 = aZCmplBlankSpcsDoc1BlankFldDesc1;
                var aZCmplBlankSpcsDoc1BlankFldDesc2 = _aZCmplBlankSpcsDoc1BlankFldDesc2; aZCmplBlankSpcsDoc1BlankFldDesc2.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc2 = aZCmplBlankSpcsDoc1BlankFldDesc2;
                var aZCmplBlankSpcsDoc1BlankFldDesc3 = _aZCmplBlankSpcsDoc1BlankFldDesc3; aZCmplBlankSpcsDoc1BlankFldDesc3.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc3 = aZCmplBlankSpcsDoc1BlankFldDesc3;
                var aZCmplBlankSpcsDoc1Nm = _aZCmplBlankSpcsDoc1Nm; aZCmplBlankSpcsDoc1Nm.Clean = value; _aZCmplBlankSpcsDoc1Nm = aZCmplBlankSpcsDoc1Nm;
                var aZCmplBlankSpcsDoc2Nm = _aZCmplBlankSpcsDoc2Nm; aZCmplBlankSpcsDoc2Nm.Clean = value; _aZCmplBlankSpcsDoc2Nm = aZCmplBlankSpcsDoc2Nm;
                var aZCmplBlankSpcsDoc3Nm = _aZCmplBlankSpcsDoc3Nm; aZCmplBlankSpcsDoc3Nm.Clean = value; _aZCmplBlankSpcsDoc3Nm = aZCmplBlankSpcsDoc3Nm;
                var basedOnOthersDescription = _basedOnOthersDescription; basedOnOthersDescription.Clean = value; _basedOnOthersDescription = basedOnOthersDescription;
                var basedOnOthersIndicator = _basedOnOthersIndicator; basedOnOthersIndicator.Clean = value; _basedOnOthersIndicator = basedOnOthersIndicator;
                var basedOnWholesaleOptionsIndicator = _basedOnWholesaleOptionsIndicator; basedOnWholesaleOptionsIndicator.Clean = value; _basedOnWholesaleOptionsIndicator = basedOnWholesaleOptionsIndicator;
                var borrowerElectsEstablishEscrowAmount = _borrowerElectsEstablishEscrowAmount; borrowerElectsEstablishEscrowAmount.Clean = value; _borrowerElectsEstablishEscrowAmount = borrowerElectsEstablishEscrowAmount;
                var borrowerElectsEstablishEscrowIndicator = _borrowerElectsEstablishEscrowIndicator; borrowerElectsEstablishEscrowIndicator.Clean = value; _borrowerElectsEstablishEscrowIndicator = borrowerElectsEstablishEscrowIndicator;
                var brokerageFeeAddition1 = _brokerageFeeAddition1; brokerageFeeAddition1.Clean = value; _brokerageFeeAddition1 = brokerageFeeAddition1;
                var brokerageFeeAddition2 = _brokerageFeeAddition2; brokerageFeeAddition2.Clean = value; _brokerageFeeAddition2 = brokerageFeeAddition2;
                var brokerageFeeAddition3 = _brokerageFeeAddition3; brokerageFeeAddition3.Clean = value; _brokerageFeeAddition3 = brokerageFeeAddition3;
                var brokerageFeeAmount1 = _brokerageFeeAmount1; brokerageFeeAmount1.Clean = value; _brokerageFeeAmount1 = brokerageFeeAmount1;
                var brokerageFeeAmount2 = _brokerageFeeAmount2; brokerageFeeAmount2.Clean = value; _brokerageFeeAmount2 = brokerageFeeAmount2;
                var brokerageFeeAmount3 = _brokerageFeeAmount3; brokerageFeeAmount3.Clean = value; _brokerageFeeAmount3 = brokerageFeeAmount3;
                var brokerageFeeDays = _brokerageFeeDays; brokerageFeeDays.Clean = value; _brokerageFeeDays = brokerageFeeDays;
                var brokerageFeePercent1 = _brokerageFeePercent1; brokerageFeePercent1.Clean = value; _brokerageFeePercent1 = brokerageFeePercent1;
                var brokerageFeePercent2 = _brokerageFeePercent2; brokerageFeePercent2.Clean = value; _brokerageFeePercent2 = brokerageFeePercent2;
                var brokerageFeePercent3 = _brokerageFeePercent3; brokerageFeePercent3.Clean = value; _brokerageFeePercent3 = brokerageFeePercent3;
                var brokerAuthorizedSigningRepName = _brokerAuthorizedSigningRepName; brokerAuthorizedSigningRepName.Clean = value; _brokerAuthorizedSigningRepName = brokerAuthorizedSigningRepName;
                var brokerAuthorizedSigningRepTitle = _brokerAuthorizedSigningRepTitle; brokerAuthorizedSigningRepTitle.Clean = value; _brokerAuthorizedSigningRepTitle = brokerAuthorizedSigningRepTitle;
                var brokerForTheSeller = _brokerForTheSeller; brokerForTheSeller.Clean = value; _brokerForTheSeller = brokerForTheSeller;
                var brokerLicense = _brokerLicense; brokerLicense.Clean = value; _brokerLicense = brokerLicense;
                var brokerName = _brokerName; brokerName.Clean = value; _brokerName = brokerName;
                var brokerPayAddition = _brokerPayAddition; brokerPayAddition.Clean = value; _brokerPayAddition = brokerPayAddition;
                var brokerPayAmount = _brokerPayAmount; brokerPayAmount.Clean = value; _brokerPayAmount = brokerPayAmount;
                var brokerPayIndicator = _brokerPayIndicator; brokerPayIndicator.Clean = value; _brokerPayIndicator = brokerPayIndicator;
                var brokerPayPercent = _brokerPayPercent; brokerPayPercent.Clean = value; _brokerPayPercent = brokerPayPercent;
                var cHARMBookletIndicator = _cHARMBookletIndicator; cHARMBookletIndicator.Clean = value; _cHARMBookletIndicator = cHARMBookletIndicator;
                var checkPayableTo = _checkPayableTo; checkPayableTo.Clean = value; _checkPayableTo = checkPayableTo;
                var commitmentAmount = _commitmentAmount; commitmentAmount.Clean = value; _commitmentAmount = commitmentAmount;
                var commitmentCondition1 = _commitmentCondition1; commitmentCondition1.Clean = value; _commitmentCondition1 = commitmentCondition1;
                var commitmentCondition2 = _commitmentCondition2; commitmentCondition2.Clean = value; _commitmentCondition2 = commitmentCondition2;
                var commitmentFee = _commitmentFee; commitmentFee.Clean = value; _commitmentFee = commitmentFee;
                var commitmentPercent = _commitmentPercent; commitmentPercent.Clean = value; _commitmentPercent = commitmentPercent;
                var compensationAddition = _compensationAddition; compensationAddition.Clean = value; _compensationAddition = compensationAddition;
                var compensationPercent = _compensationPercent; compensationPercent.Clean = value; _compensationPercent = compensationPercent;
                var creditDeposit = _creditDeposit; creditDeposit.Clean = value; _creditDeposit = creditDeposit;
                var creditIsUsedForReason = _creditIsUsedForReason; creditIsUsedForReason.Clean = value; _creditIsUsedForReason = creditIsUsedForReason;
                var creditReportContact = _creditReportContact; creditReportContact.Clean = value; _creditReportContact = creditReportContact;
                var daysBeforeClosing = _daysBeforeClosing; daysBeforeClosing.Clean = value; _daysBeforeClosing = daysBeforeClosing;
                var depositReceipt = _depositReceipt; depositReceipt.Clean = value; _depositReceipt = depositReceipt;
                var depositRefundableIndicator = _depositRefundableIndicator; depositRefundableIndicator.Clean = value; _depositRefundableIndicator = depositRefundableIndicator;
                var directContact = _directContact; directContact.Clean = value; _directContact = directContact;
                var directPayAmount = _directPayAmount; directPayAmount.Clean = value; _directPayAmount = directPayAmount;
                var directPayClosing = _directPayClosing; directPayClosing.Clean = value; _directPayClosing = directPayClosing;
                var directPayCommitment = _directPayCommitment; directPayCommitment.Clean = value; _directPayCommitment = directPayCommitment;
                var directPayIndicator = _directPayIndicator; directPayIndicator.Clean = value; _directPayIndicator = directPayIndicator;
                var directPayPercent = _directPayPercent; directPayPercent.Clean = value; _directPayPercent = directPayPercent;
                var disclosureDeliveredBy = _disclosureDeliveredBy; disclosureDeliveredBy.Clean = value; _disclosureDeliveredBy = disclosureDeliveredBy;
                var disclosureDeliveredByOtherMethod = _disclosureDeliveredByOtherMethod; disclosureDeliveredByOtherMethod.Clean = value; _disclosureDeliveredByOtherMethod = disclosureDeliveredByOtherMethod;
                var disclosureDeliveredDate = _disclosureDeliveredDate; disclosureDeliveredDate.Clean = value; _disclosureDeliveredDate = disclosureDeliveredDate;
                var estimatedChargeShownOnGFEIndicator = _estimatedChargeShownOnGFEIndicator; estimatedChargeShownOnGFEIndicator.Clean = value; _estimatedChargeShownOnGFEIndicator = estimatedChargeShownOnGFEIndicator;
                var expirationDate = _expirationDate; expirationDate.Clean = value; _expirationDate = expirationDate;
                var federallySubsidizedAmount = _federallySubsidizedAmount; federallySubsidizedAmount.Clean = value; _federallySubsidizedAmount = federallySubsidizedAmount;
                var federallySubsidizedAmountPercentage = _federallySubsidizedAmountPercentage; federallySubsidizedAmountPercentage.Clean = value; _federallySubsidizedAmountPercentage = federallySubsidizedAmountPercentage;
                var feeReceived1 = _feeReceived1; feeReceived1.Clean = value; _feeReceived1 = feeReceived1;
                var feeReceived2 = _feeReceived2; feeReceived2.Clean = value; _feeReceived2 = feeReceived2;
                var feeReceivedByLender = _feeReceivedByLender; feeReceivedByLender.Clean = value; _feeReceivedByLender = feeReceivedByLender;
                var feesReceiving = _feesReceiving; feesReceiving.Clean = value; _feesReceiving = feesReceiving;
                var floridaApplicationFee = _floridaApplicationFee; floridaApplicationFee.Clean = value; _floridaApplicationFee = floridaApplicationFee;
                var floridaOtherFee1 = _floridaOtherFee1; floridaOtherFee1.Clean = value; _floridaOtherFee1 = floridaOtherFee1;
                var floridaOtherFee2 = _floridaOtherFee2; floridaOtherFee2.Clean = value; _floridaOtherFee2 = floridaOtherFee2;
                var floridaOtherFeeTo1 = _floridaOtherFeeTo1; floridaOtherFeeTo1.Clean = value; _floridaOtherFeeTo1 = floridaOtherFeeTo1;
                var floridaOtherFeeTo2 = _floridaOtherFeeTo2; floridaOtherFeeTo2.Clean = value; _floridaOtherFeeTo2 = floridaOtherFeeTo2;
                var floridaOtherFeeTo3 = _floridaOtherFeeTo3; floridaOtherFeeTo3.Clean = value; _floridaOtherFeeTo3 = floridaOtherFeeTo3;
                var floridaOtherFeeTo4 = _floridaOtherFeeTo4; floridaOtherFeeTo4.Clean = value; _floridaOtherFeeTo4 = floridaOtherFeeTo4;
                var furtherFeesEarnedByMortgageBroker = _furtherFeesEarnedByMortgageBroker; furtherFeesEarnedByMortgageBroker.Clean = value; _furtherFeesEarnedByMortgageBroker = furtherFeesEarnedByMortgageBroker;
                var gFEFeeReceived1 = _gFEFeeReceived1; gFEFeeReceived1.Clean = value; _gFEFeeReceived1 = gFEFeeReceived1;
                var gFEFeeReceived2 = _gFEFeeReceived2; gFEFeeReceived2.Clean = value; _gFEFeeReceived2 = gFEFeeReceived2;
                var hUDBookletIndicator = _hUDBookletIndicator; hUDBookletIndicator.Clean = value; _hUDBookletIndicator = hUDBookletIndicator;
                var id = _id; id.Clean = value; _id = id;
                var independentContractorIndicator = _independentContractorIndicator; independentContractorIndicator.Clean = value; _independentContractorIndicator = independentContractorIndicator;
                var indexUsed = _indexUsed; indexUsed.Clean = value; _indexUsed = indexUsed;
                var informationAboutTheIndexCanBeFound = _informationAboutTheIndexCanBeFound; informationAboutTheIndexCanBeFound.Clean = value; _informationAboutTheIndexCanBeFound = informationAboutTheIndexCanBeFound;
                var inLicensedNo = _inLicensedNo; inLicensedNo.Clean = value; _inLicensedNo = inLicensedNo;
                var inLicensedType = _inLicensedType; inLicensedType.Clean = value; _inLicensedType = inLicensedType;
                var isEstimateIndicator = _isEstimateIndicator; isEstimateIndicator.Clean = value; _isEstimateIndicator = isEstimateIndicator;
                var ksUcccElectionIndicator = _ksUcccElectionIndicator; ksUcccElectionIndicator.Clean = value; _ksUcccElectionIndicator = ksUcccElectionIndicator;
                var kyHomeSolicationLoanIndicator = _kyHomeSolicationLoanIndicator; kyHomeSolicationLoanIndicator.Clean = value; _kyHomeSolicationLoanIndicator = kyHomeSolicationLoanIndicator;
                var leaseAgreementDate = _leaseAgreementDate; leaseAgreementDate.Clean = value; _leaseAgreementDate = leaseAgreementDate;
                var lenderDate = _lenderDate; lenderDate.Clean = value; _lenderDate = lenderDate;
                var lenderName = _lenderName; lenderName.Clean = value; _lenderName = lenderName;
                var lenderPaid = _lenderPaid; lenderPaid.Clean = value; _lenderPaid = lenderPaid;
                var lenderPayAmount = _lenderPayAmount; lenderPayAmount.Clean = value; _lenderPayAmount = lenderPayAmount;
                var lenderPayIndicator = _lenderPayIndicator; lenderPayIndicator.Clean = value; _lenderPayIndicator = lenderPayIndicator;
                var lenderPayMaxPoint = _lenderPayMaxPoint; lenderPayMaxPoint.Clean = value; _lenderPayMaxPoint = lenderPayMaxPoint;
                var lenderPayPercent = _lenderPayPercent; lenderPayPercent.Clean = value; _lenderPayPercent = lenderPayPercent;
                var lenderPayPoint = _lenderPayPoint; lenderPayPoint.Clean = value; _lenderPayPoint = lenderPayPoint;
                var lenderPayUnknownIndicator = _lenderPayUnknownIndicator; lenderPayUnknownIndicator.Clean = value; _lenderPayUnknownIndicator = lenderPayUnknownIndicator;
                var lenderStatus = _lenderStatus; lenderStatus.Clean = value; _lenderStatus = lenderStatus;
                var lessorName = _lessorName; lessorName.Clean = value; _lessorName = lessorName;
                var loanTermsFixedThroughDateofLoanClosingIndicator = _loanTermsFixedThroughDateofLoanClosingIndicator; loanTermsFixedThroughDateofLoanClosingIndicator.Clean = value; _loanTermsFixedThroughDateofLoanClosingIndicator = loanTermsFixedThroughDateofLoanClosingIndicator;
                var lockInFee = _lockInFee; lockInFee.Clean = value; _lockInFee = lockInFee;
                var methodDescription = _methodDescription; methodDescription.Clean = value; _methodDescription = methodDescription;
                var methodDetermine = _methodDetermine; methodDetermine.Clean = value; _methodDetermine = methodDetermine;
                var mortgageAgreementIndicator = _mortgageAgreementIndicator; mortgageAgreementIndicator.Clean = value; _mortgageAgreementIndicator = mortgageAgreementIndicator;
                var mtgBrokerLicense = _mtgBrokerLicense; mtgBrokerLicense.Clean = value; _mtgBrokerLicense = mtgBrokerLicense;
                var nameOfLicensee = _nameOfLicensee; nameOfLicensee.Clean = value; _nameOfLicensee = nameOfLicensee;
                var newMoneyAmount = _newMoneyAmount; newMoneyAmount.Clean = value; _newMoneyAmount = newMoneyAmount;
                var newYorkApplicationFee = _newYorkApplicationFee; newYorkApplicationFee.Clean = value; _newYorkApplicationFee = newYorkApplicationFee;
                var newYorkAppraisalFee = _newYorkAppraisalFee; newYorkAppraisalFee.Clean = value; _newYorkAppraisalFee = newYorkAppraisalFee;
                var newYorkCreditReportFee = _newYorkCreditReportFee; newYorkCreditReportFee.Clean = value; _newYorkCreditReportFee = newYorkCreditReportFee;
                var newYorkFees = _newYorkFees; newYorkFees.Clean = value; _newYorkFees = newYorkFees;
                var newYorkPrimaryLenders = _newYorkPrimaryLenders; newYorkPrimaryLenders.Clean = value; _newYorkPrimaryLenders = newYorkPrimaryLenders;
                var newYorkProcessingFee = _newYorkProcessingFee; newYorkProcessingFee.Clean = value; _newYorkProcessingFee = newYorkProcessingFee;
                var notRefundableAmount = _notRefundableAmount; notRefundableAmount.Clean = value; _notRefundableAmount = notRefundableAmount;
                var offerRetailPriceIndicator = _offerRetailPriceIndicator; offerRetailPriceIndicator.Clean = value; _offerRetailPriceIndicator = offerRetailPriceIndicator;
                var originalAcquisitionCost = _originalAcquisitionCost; originalAcquisitionCost.Clean = value; _originalAcquisitionCost = originalAcquisitionCost;
                var originationFeeChargedAmount = _originationFeeChargedAmount; originationFeeChargedAmount.Clean = value; _originationFeeChargedAmount = originationFeeChargedAmount;
                var originationFeeChargedIndicator = _originationFeeChargedIndicator; originationFeeChargedIndicator.Clean = value; _originationFeeChargedIndicator = originationFeeChargedIndicator;
                var originationFeeDecreasesRate = _originationFeeDecreasesRate; originationFeeDecreasesRate.Clean = value; _originationFeeDecreasesRate = originationFeeDecreasesRate;
                var originationFeeIncreasesRate = _originationFeeIncreasesRate; originationFeeIncreasesRate.Clean = value; _originationFeeIncreasesRate = originationFeeIncreasesRate;
                var originationFeeInterestRateImpactedStatus = _originationFeeInterestRateImpactedStatus; originationFeeInterestRateImpactedStatus.Clean = value; _originationFeeInterestRateImpactedStatus = originationFeeInterestRateImpactedStatus;
                var originationFeePaidBy = _originationFeePaidBy; originationFeePaidBy.Clean = value; _originationFeePaidBy = originationFeePaidBy;
                var paidByBorrower = _paidByBorrower; paidByBorrower.Clean = value; _paidByBorrower = paidByBorrower;
                var paidByLender = _paidByLender; paidByLender.Clean = value; _paidByLender = paidByLender;
                var paidByOther1 = _paidByOther1; paidByOther1.Clean = value; _paidByOther1 = paidByOther1;
                var paidByOther2 = _paidByOther2; paidByOther2.Clean = value; _paidByOther2 = paidByOther2;
                var paidByOtherDescription1 = _paidByOtherDescription1; paidByOtherDescription1.Clean = value; _paidByOtherDescription1 = paidByOtherDescription1;
                var paidByOtherDescription2 = _paidByOtherDescription2; paidByOtherDescription2.Clean = value; _paidByOtherDescription2 = paidByOtherDescription2;
                var previousMortgageAmountOne = _previousMortgageAmountOne; previousMortgageAmountOne.Clean = value; _previousMortgageAmountOne = previousMortgageAmountOne;
                var previousMortgageAmountTwo = _previousMortgageAmountTwo; previousMortgageAmountTwo.Clean = value; _previousMortgageAmountTwo = previousMortgageAmountTwo;
                var printCertificationOfCosts = _printCertificationOfCosts; printCertificationOfCosts.Clean = value; _printCertificationOfCosts = printCertificationOfCosts;
                var printInterestRateReductionRider = _printInterestRateReductionRider; printInterestRateReductionRider.Clean = value; _printInterestRateReductionRider = printInterestRateReductionRider;
                var printMDDeliveryIndicator = _printMDDeliveryIndicator; printMDDeliveryIndicator.Clean = value; _printMDDeliveryIndicator = printMDDeliveryIndicator;
                var providedBy = _providedBy; providedBy.Clean = value; _providedBy = providedBy;
                var questionContact = _questionContact; questionContact.Clean = value; _questionContact = questionContact;
                var questionContactPhone = _questionContactPhone; questionContactPhone.Clean = value; _questionContactPhone = questionContactPhone;
                var questionContactTollFree = _questionContactTollFree; questionContactTollFree.Clean = value; _questionContactTollFree = questionContactTollFree;
                var rateLockHonoredIndicator = _rateLockHonoredIndicator; rateLockHonoredIndicator.Clean = value; _rateLockHonoredIndicator = rateLockHonoredIndicator;
                var receivedBy = _receivedBy; receivedBy.Clean = value; _receivedBy = receivedBy;
                var refinancingFee = _refinancingFee; refinancingFee.Clean = value; _refinancingFee = refinancingFee;
                var refundableBy = _refundableBy; refundableBy.Clean = value; _refundableBy = refundableBy;
                var refundableIndicator = _refundableIndicator; refundableIndicator.Clean = value; _refundableIndicator = refundableIndicator;
                var refundableType = _refundableType; refundableType.Clean = value; _refundableType = refundableType;
                var refundCondition1 = _refundCondition1; refundCondition1.Clean = value; _refundCondition1 = refundCondition1;
                var refundCondition2 = _refundCondition2; refundCondition2.Clean = value; _refundCondition2 = refundCondition2;
                var refundCondition3 = _refundCondition3; refundCondition3.Clean = value; _refundCondition3 = refundCondition3;
                var refundCondition4 = _refundCondition4; refundCondition4.Clean = value; _refundCondition4 = refundCondition4;
                var refundCondition5 = _refundCondition5; refundCondition5.Clean = value; _refundCondition5 = refundCondition5;
                var refundCondition6 = _refundCondition6; refundCondition6.Clean = value; _refundCondition6 = refundCondition6;
                var regulatorAddress = _regulatorAddress; regulatorAddress.Clean = value; _regulatorAddress = regulatorAddress;
                var regulatorCity = _regulatorCity; regulatorCity.Clean = value; _regulatorCity = regulatorCity;
                var regulatorMailingAddress = _regulatorMailingAddress; regulatorMailingAddress.Clean = value; _regulatorMailingAddress = regulatorMailingAddress;
                var regulatorMailingCity = _regulatorMailingCity; regulatorMailingCity.Clean = value; _regulatorMailingCity = regulatorMailingCity;
                var regulatorMailingState = _regulatorMailingState; regulatorMailingState.Clean = value; _regulatorMailingState = regulatorMailingState;
                var regulatorMailingZipCode = _regulatorMailingZipCode; regulatorMailingZipCode.Clean = value; _regulatorMailingZipCode = regulatorMailingZipCode;
                var regulatorPhone = _regulatorPhone; regulatorPhone.Clean = value; _regulatorPhone = regulatorPhone;
                var regulatorState = _regulatorState; regulatorState.Clean = value; _regulatorState = regulatorState;
                var regulatorTollFreePhone = _regulatorTollFreePhone; regulatorTollFreePhone.Clean = value; _regulatorTollFreePhone = regulatorTollFreePhone;
                var regulatorWebAddress = _regulatorWebAddress; regulatorWebAddress.Clean = value; _regulatorWebAddress = regulatorWebAddress;
                var regulatorZipCode = _regulatorZipCode; regulatorZipCode.Clean = value; _regulatorZipCode = regulatorZipCode;
                var scheduleOfChargesEstimatedFinalIndicator = _scheduleOfChargesEstimatedFinalIndicator; scheduleOfChargesEstimatedFinalIndicator.Clean = value; _scheduleOfChargesEstimatedFinalIndicator = scheduleOfChargesEstimatedFinalIndicator;
                var scRegulatoryAgencyType = _scRegulatoryAgencyType; scRegulatoryAgencyType.Clean = value; _scRegulatoryAgencyType = scRegulatoryAgencyType;
                var selectDivisionFeesIndicator = _selectDivisionFeesIndicator; selectDivisionFeesIndicator.Clean = value; _selectDivisionFeesIndicator = selectDivisionFeesIndicator;
                var selectPrimaryLenderIndicator = _selectPrimaryLenderIndicator; selectPrimaryLenderIndicator.Clean = value; _selectPrimaryLenderIndicator = selectPrimaryLenderIndicator;
                var selectPrivateLenderIndicator = _selectPrivateLenderIndicator; selectPrivateLenderIndicator.Clean = value; _selectPrivateLenderIndicator = selectPrivateLenderIndicator;
                var servicingFeeChargedAmount = _servicingFeeChargedAmount; servicingFeeChargedAmount.Clean = value; _servicingFeeChargedAmount = servicingFeeChargedAmount;
                var servicingFeeChargedIndicator = _servicingFeeChargedIndicator; servicingFeeChargedIndicator.Clean = value; _servicingFeeChargedIndicator = servicingFeeChargedIndicator;
                var servicingFeePaidBy = _servicingFeePaidBy; servicingFeePaidBy.Clean = value; _servicingFeePaidBy = servicingFeePaidBy;
                var servicingFeePaidFrequence = _servicingFeePaidFrequence; servicingFeePaidFrequence.Clean = value; _servicingFeePaidFrequence = servicingFeePaidFrequence;
                var signedByBorrowerIndicator = _signedByBorrowerIndicator; signedByBorrowerIndicator.Clean = value; _signedByBorrowerIndicator = signedByBorrowerIndicator;
                var specificARMIndicator = _specificARMIndicator; specificARMIndicator.Clean = value; _specificARMIndicator = specificARMIndicator;
                var submitToLenderIndicator = _submitToLenderIndicator; submitToLenderIndicator.Clean = value; _submitToLenderIndicator = submitToLenderIndicator;
                var taxExemptAcquisitionCostCertificationAssessments = _taxExemptAcquisitionCostCertificationAssessments; taxExemptAcquisitionCostCertificationAssessments.Clean = value; _taxExemptAcquisitionCostCertificationAssessments = taxExemptAcquisitionCostCertificationAssessments;
                var taxExemptAcquisitionCostCertificationOther = _taxExemptAcquisitionCostCertificationOther; taxExemptAcquisitionCostCertificationOther.Clean = value; _taxExemptAcquisitionCostCertificationOther = taxExemptAcquisitionCostCertificationOther;
                var taxExemptAcquisitionCostCertificationOtherAmount = _taxExemptAcquisitionCostCertificationOtherAmount; taxExemptAcquisitionCostCertificationOtherAmount.Clean = value; _taxExemptAcquisitionCostCertificationOtherAmount = taxExemptAcquisitionCostCertificationOtherAmount;
                var taxExemptAcquisitionCostCertificationOwnersTitleInsurance = _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; taxExemptAcquisitionCostCertificationOwnersTitleInsurance.Clean = value; _taxExemptAcquisitionCostCertificationOwnersTitleInsurance = taxExemptAcquisitionCostCertificationOwnersTitleInsurance;
                var taxExemptAcquisitionCostCertificationRealEstateCommission = _taxExemptAcquisitionCostCertificationRealEstateCommission; taxExemptAcquisitionCostCertificationRealEstateCommission.Clean = value; _taxExemptAcquisitionCostCertificationRealEstateCommission = taxExemptAcquisitionCostCertificationRealEstateCommission;
                var taxExemptAcquisitionCostCertificationRepairsImprovements = _taxExemptAcquisitionCostCertificationRepairsImprovements; taxExemptAcquisitionCostCertificationRepairsImprovements.Clean = value; _taxExemptAcquisitionCostCertificationRepairsImprovements = taxExemptAcquisitionCostCertificationRepairsImprovements;
                var taxExemptAcquisitionCostCertificationSurvey = _taxExemptAcquisitionCostCertificationSurvey; taxExemptAcquisitionCostCertificationSurvey.Clean = value; _taxExemptAcquisitionCostCertificationSurvey = taxExemptAcquisitionCostCertificationSurvey;
                var taxExemptAcquisitionCostCertificationTotalAdjustments = _taxExemptAcquisitionCostCertificationTotalAdjustments; taxExemptAcquisitionCostCertificationTotalAdjustments.Clean = value; _taxExemptAcquisitionCostCertificationTotalAdjustments = taxExemptAcquisitionCostCertificationTotalAdjustments;
                var termsChange = _termsChange; termsChange.Clean = value; _termsChange = termsChange;
                var texasApplicationFee = _texasApplicationFee; texasApplicationFee.Clean = value; _texasApplicationFee = texasApplicationFee;
                var texasAppraisalFee = _texasAppraisalFee; texasAppraisalFee.Clean = value; _texasAppraisalFee = texasAppraisalFee;
                var texasCreditReportFee = _texasCreditReportFee; texasCreditReportFee.Clean = value; _texasCreditReportFee = texasCreditReportFee;
                var texasOtherFee1 = _texasOtherFee1; texasOtherFee1.Clean = value; _texasOtherFee1 = texasOtherFee1;
                var texasOtherFee2 = _texasOtherFee2; texasOtherFee2.Clean = value; _texasOtherFee2 = texasOtherFee2;
                var texasOtherFeeContact1 = _texasOtherFeeContact1; texasOtherFeeContact1.Clean = value; _texasOtherFeeContact1 = texasOtherFeeContact1;
                var texasOtherFeeContact2 = _texasOtherFeeContact2; texasOtherFeeContact2.Clean = value; _texasOtherFeeContact2 = texasOtherFeeContact2;
                var texasProcessingFee = _texasProcessingFee; texasProcessingFee.Clean = value; _texasProcessingFee = texasProcessingFee;
                var thirdPartyFee = _thirdPartyFee; thirdPartyFee.Clean = value; _thirdPartyFee = thirdPartyFee;
                var totalFee = _totalFee; totalFee.Clean = value; _totalFee = totalFee;
                var transferFeeChargedAmount = _transferFeeChargedAmount; transferFeeChargedAmount.Clean = value; _transferFeeChargedAmount = transferFeeChargedAmount;
                var transferFeeChargedIndicator = _transferFeeChargedIndicator; transferFeeChargedIndicator.Clean = value; _transferFeeChargedIndicator = transferFeeChargedIndicator;
                var transferFeePaidBy = _transferFeePaidBy; transferFeePaidBy.Clean = value; _transferFeePaidBy = transferFeePaidBy;
                var txVeteransLandBoardIndicator = _txVeteransLandBoardIndicator; txVeteransLandBoardIndicator.Clean = value; _txVeteransLandBoardIndicator = txVeteransLandBoardIndicator;
                var typeOfProperty = _typeOfProperty; typeOfProperty.Clean = value; _typeOfProperty = typeOfProperty;
                var underwritingContact = _underwritingContact; underwritingContact.Clean = value; _underwritingContact = underwritingContact;
                var underwritingFee = _underwritingFee; underwritingFee.Clean = value; _underwritingFee = underwritingFee;
                var ySPChargedAmount = _ySPChargedAmount; ySPChargedAmount.Clean = value; _ySPChargedAmount = ySPChargedAmount;
                var ySPChargedIndicator = _ySPChargedIndicator; ySPChargedIndicator.Clean = value; _ySPChargedIndicator = ySPChargedIndicator;
                var ySPDecreasesRate = _ySPDecreasesRate; ySPDecreasesRate.Clean = value; _ySPDecreasesRate = ySPDecreasesRate;
                var ySPIncreasesRate = _ySPIncreasesRate; ySPIncreasesRate.Clean = value; _ySPIncreasesRate = ySPIncreasesRate;
                var ySPInterestRateImpactedStatus = _ySPInterestRateImpactedStatus; ySPInterestRateImpactedStatus.Clean = value; _ySPInterestRateImpactedStatus = ySPInterestRateImpactedStatus;
                var ySPPaidBy = _ySPPaidBy; ySPPaidBy.Clean = value; _ySPPaidBy = ySPPaidBy;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public StateDisclosure()
        {
            Clean = true;
        }
    }
}