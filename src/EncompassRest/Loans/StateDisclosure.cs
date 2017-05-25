using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _acceptedByBorrowerIndicator; v0.Clean = value; _acceptedByBorrowerIndicator = v0;
                var v1 = _acceptedDate; v1.Clean = value; _acceptedDate = v1;
                var v2 = _actingOtherDescription1; v2.Clean = value; _actingOtherDescription1 = v2;
                var v3 = _actingOtherDescription2; v3.Clean = value; _actingOtherDescription2 = v3;
                var v4 = _actingOthersIndicator; v4.Clean = value; _actingOthersIndicator = v4;
                var v5 = _advFeeAgmtInEfctNumDay; v5.Clean = value; _advFeeAgmtInEfctNumDay = v5;
                var v6 = _advisoryCondition1; v6.Clean = value; _advisoryCondition1 = v6;
                var v7 = _advisoryCondition2; v7.Clean = value; _advisoryCondition2 = v7;
                var v8 = _advisoryCondition3; v8.Clean = value; _advisoryCondition3 = v8;
                var v9 = _advisoryCondition4; v9.Clean = value; _advisoryCondition4 = v9;
                var v10 = _amendedAcquisitionCost; v10.Clean = value; _amendedAcquisitionCost = v10;
                var v11 = _applicationDate; v11.Clean = value; _applicationDate = v11;
                var v12 = _appraisalContact; v12.Clean = value; _appraisalContact = v12;
                var v13 = _appraisalDeposit; v13.Clean = value; _appraisalDeposit = v13;
                var v14 = _areas; v14.Clean = value; _areas = v14;
                var v15 = _asAttorneyIndicator; v15.Clean = value; _asAttorneyIndicator = v15;
                var v16 = _asRealBrokerIndicator; v16.Clean = value; _asRealBrokerIndicator = v16;
                var v17 = _attorneyForTheBuyerIndicator; v17.Clean = value; _attorneyForTheBuyerIndicator = v17;
                var v18 = _attorneyForTheLenderIndicator; v18.Clean = value; _attorneyForTheLenderIndicator = v18;
                var v19 = _attorneyForTheSellerIndicator; v19.Clean = value; _attorneyForTheSellerIndicator = v19;
                var v20 = _aZCmplBlankSpcsDoc1BlankFldDesc1; v20.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc1 = v20;
                var v21 = _aZCmplBlankSpcsDoc1BlankFldDesc2; v21.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc2 = v21;
                var v22 = _aZCmplBlankSpcsDoc1BlankFldDesc3; v22.Clean = value; _aZCmplBlankSpcsDoc1BlankFldDesc3 = v22;
                var v23 = _aZCmplBlankSpcsDoc1Nm; v23.Clean = value; _aZCmplBlankSpcsDoc1Nm = v23;
                var v24 = _aZCmplBlankSpcsDoc2Nm; v24.Clean = value; _aZCmplBlankSpcsDoc2Nm = v24;
                var v25 = _aZCmplBlankSpcsDoc3Nm; v25.Clean = value; _aZCmplBlankSpcsDoc3Nm = v25;
                var v26 = _basedOnOthersDescription; v26.Clean = value; _basedOnOthersDescription = v26;
                var v27 = _basedOnOthersIndicator; v27.Clean = value; _basedOnOthersIndicator = v27;
                var v28 = _basedOnWholesaleOptionsIndicator; v28.Clean = value; _basedOnWholesaleOptionsIndicator = v28;
                var v29 = _borrowerElectsEstablishEscrowAmount; v29.Clean = value; _borrowerElectsEstablishEscrowAmount = v29;
                var v30 = _borrowerElectsEstablishEscrowIndicator; v30.Clean = value; _borrowerElectsEstablishEscrowIndicator = v30;
                var v31 = _brokerageFeeAddition1; v31.Clean = value; _brokerageFeeAddition1 = v31;
                var v32 = _brokerageFeeAddition2; v32.Clean = value; _brokerageFeeAddition2 = v32;
                var v33 = _brokerageFeeAddition3; v33.Clean = value; _brokerageFeeAddition3 = v33;
                var v34 = _brokerageFeeAmount1; v34.Clean = value; _brokerageFeeAmount1 = v34;
                var v35 = _brokerageFeeAmount2; v35.Clean = value; _brokerageFeeAmount2 = v35;
                var v36 = _brokerageFeeAmount3; v36.Clean = value; _brokerageFeeAmount3 = v36;
                var v37 = _brokerageFeeDays; v37.Clean = value; _brokerageFeeDays = v37;
                var v38 = _brokerageFeePercent1; v38.Clean = value; _brokerageFeePercent1 = v38;
                var v39 = _brokerageFeePercent2; v39.Clean = value; _brokerageFeePercent2 = v39;
                var v40 = _brokerageFeePercent3; v40.Clean = value; _brokerageFeePercent3 = v40;
                var v41 = _brokerAuthorizedSigningRepName; v41.Clean = value; _brokerAuthorizedSigningRepName = v41;
                var v42 = _brokerAuthorizedSigningRepTitle; v42.Clean = value; _brokerAuthorizedSigningRepTitle = v42;
                var v43 = _brokerForTheSeller; v43.Clean = value; _brokerForTheSeller = v43;
                var v44 = _brokerLicense; v44.Clean = value; _brokerLicense = v44;
                var v45 = _brokerName; v45.Clean = value; _brokerName = v45;
                var v46 = _brokerPayAddition; v46.Clean = value; _brokerPayAddition = v46;
                var v47 = _brokerPayAmount; v47.Clean = value; _brokerPayAmount = v47;
                var v48 = _brokerPayIndicator; v48.Clean = value; _brokerPayIndicator = v48;
                var v49 = _brokerPayPercent; v49.Clean = value; _brokerPayPercent = v49;
                var v50 = _cHARMBookletIndicator; v50.Clean = value; _cHARMBookletIndicator = v50;
                var v51 = _checkPayableTo; v51.Clean = value; _checkPayableTo = v51;
                var v52 = _commitmentAmount; v52.Clean = value; _commitmentAmount = v52;
                var v53 = _commitmentCondition1; v53.Clean = value; _commitmentCondition1 = v53;
                var v54 = _commitmentCondition2; v54.Clean = value; _commitmentCondition2 = v54;
                var v55 = _commitmentFee; v55.Clean = value; _commitmentFee = v55;
                var v56 = _commitmentPercent; v56.Clean = value; _commitmentPercent = v56;
                var v57 = _compensationAddition; v57.Clean = value; _compensationAddition = v57;
                var v58 = _compensationPercent; v58.Clean = value; _compensationPercent = v58;
                var v59 = _creditDeposit; v59.Clean = value; _creditDeposit = v59;
                var v60 = _creditIsUsedForReason; v60.Clean = value; _creditIsUsedForReason = v60;
                var v61 = _creditReportContact; v61.Clean = value; _creditReportContact = v61;
                var v62 = _daysBeforeClosing; v62.Clean = value; _daysBeforeClosing = v62;
                var v63 = _depositReceipt; v63.Clean = value; _depositReceipt = v63;
                var v64 = _depositRefundableIndicator; v64.Clean = value; _depositRefundableIndicator = v64;
                var v65 = _directContact; v65.Clean = value; _directContact = v65;
                var v66 = _directPayAmount; v66.Clean = value; _directPayAmount = v66;
                var v67 = _directPayClosing; v67.Clean = value; _directPayClosing = v67;
                var v68 = _directPayCommitment; v68.Clean = value; _directPayCommitment = v68;
                var v69 = _directPayIndicator; v69.Clean = value; _directPayIndicator = v69;
                var v70 = _directPayPercent; v70.Clean = value; _directPayPercent = v70;
                var v71 = _disclosureDeliveredBy; v71.Clean = value; _disclosureDeliveredBy = v71;
                var v72 = _disclosureDeliveredByOtherMethod; v72.Clean = value; _disclosureDeliveredByOtherMethod = v72;
                var v73 = _disclosureDeliveredDate; v73.Clean = value; _disclosureDeliveredDate = v73;
                var v74 = _estimatedChargeShownOnGFEIndicator; v74.Clean = value; _estimatedChargeShownOnGFEIndicator = v74;
                var v75 = _expirationDate; v75.Clean = value; _expirationDate = v75;
                var v76 = _federallySubsidizedAmount; v76.Clean = value; _federallySubsidizedAmount = v76;
                var v77 = _federallySubsidizedAmountPercentage; v77.Clean = value; _federallySubsidizedAmountPercentage = v77;
                var v78 = _feeReceived1; v78.Clean = value; _feeReceived1 = v78;
                var v79 = _feeReceived2; v79.Clean = value; _feeReceived2 = v79;
                var v80 = _feeReceivedByLender; v80.Clean = value; _feeReceivedByLender = v80;
                var v81 = _feesReceiving; v81.Clean = value; _feesReceiving = v81;
                var v82 = _floridaApplicationFee; v82.Clean = value; _floridaApplicationFee = v82;
                var v83 = _floridaOtherFee1; v83.Clean = value; _floridaOtherFee1 = v83;
                var v84 = _floridaOtherFee2; v84.Clean = value; _floridaOtherFee2 = v84;
                var v85 = _floridaOtherFeeTo1; v85.Clean = value; _floridaOtherFeeTo1 = v85;
                var v86 = _floridaOtherFeeTo2; v86.Clean = value; _floridaOtherFeeTo2 = v86;
                var v87 = _floridaOtherFeeTo3; v87.Clean = value; _floridaOtherFeeTo3 = v87;
                var v88 = _floridaOtherFeeTo4; v88.Clean = value; _floridaOtherFeeTo4 = v88;
                var v89 = _furtherFeesEarnedByMortgageBroker; v89.Clean = value; _furtherFeesEarnedByMortgageBroker = v89;
                var v90 = _gFEFeeReceived1; v90.Clean = value; _gFEFeeReceived1 = v90;
                var v91 = _gFEFeeReceived2; v91.Clean = value; _gFEFeeReceived2 = v91;
                var v92 = _hUDBookletIndicator; v92.Clean = value; _hUDBookletIndicator = v92;
                var v93 = _id; v93.Clean = value; _id = v93;
                var v94 = _independentContractorIndicator; v94.Clean = value; _independentContractorIndicator = v94;
                var v95 = _indexUsed; v95.Clean = value; _indexUsed = v95;
                var v96 = _informationAboutTheIndexCanBeFound; v96.Clean = value; _informationAboutTheIndexCanBeFound = v96;
                var v97 = _inLicensedNo; v97.Clean = value; _inLicensedNo = v97;
                var v98 = _inLicensedType; v98.Clean = value; _inLicensedType = v98;
                var v99 = _isEstimateIndicator; v99.Clean = value; _isEstimateIndicator = v99;
                var v100 = _ksUcccElectionIndicator; v100.Clean = value; _ksUcccElectionIndicator = v100;
                var v101 = _kyHomeSolicationLoanIndicator; v101.Clean = value; _kyHomeSolicationLoanIndicator = v101;
                var v102 = _leaseAgreementDate; v102.Clean = value; _leaseAgreementDate = v102;
                var v103 = _lenderDate; v103.Clean = value; _lenderDate = v103;
                var v104 = _lenderName; v104.Clean = value; _lenderName = v104;
                var v105 = _lenderPaid; v105.Clean = value; _lenderPaid = v105;
                var v106 = _lenderPayAmount; v106.Clean = value; _lenderPayAmount = v106;
                var v107 = _lenderPayIndicator; v107.Clean = value; _lenderPayIndicator = v107;
                var v108 = _lenderPayMaxPoint; v108.Clean = value; _lenderPayMaxPoint = v108;
                var v109 = _lenderPayPercent; v109.Clean = value; _lenderPayPercent = v109;
                var v110 = _lenderPayPoint; v110.Clean = value; _lenderPayPoint = v110;
                var v111 = _lenderPayUnknownIndicator; v111.Clean = value; _lenderPayUnknownIndicator = v111;
                var v112 = _lenderStatus; v112.Clean = value; _lenderStatus = v112;
                var v113 = _lessorName; v113.Clean = value; _lessorName = v113;
                var v114 = _loanTermsFixedThroughDateofLoanClosingIndicator; v114.Clean = value; _loanTermsFixedThroughDateofLoanClosingIndicator = v114;
                var v115 = _lockInFee; v115.Clean = value; _lockInFee = v115;
                var v116 = _methodDescription; v116.Clean = value; _methodDescription = v116;
                var v117 = _methodDetermine; v117.Clean = value; _methodDetermine = v117;
                var v118 = _mortgageAgreementIndicator; v118.Clean = value; _mortgageAgreementIndicator = v118;
                var v119 = _mtgBrokerLicense; v119.Clean = value; _mtgBrokerLicense = v119;
                var v120 = _nameOfLicensee; v120.Clean = value; _nameOfLicensee = v120;
                var v121 = _newMoneyAmount; v121.Clean = value; _newMoneyAmount = v121;
                var v122 = _newYorkApplicationFee; v122.Clean = value; _newYorkApplicationFee = v122;
                var v123 = _newYorkAppraisalFee; v123.Clean = value; _newYorkAppraisalFee = v123;
                var v124 = _newYorkCreditReportFee; v124.Clean = value; _newYorkCreditReportFee = v124;
                var v125 = _newYorkFees; v125.Clean = value; _newYorkFees = v125;
                var v126 = _newYorkPrimaryLenders; v126.Clean = value; _newYorkPrimaryLenders = v126;
                var v127 = _newYorkProcessingFee; v127.Clean = value; _newYorkProcessingFee = v127;
                var v128 = _notRefundableAmount; v128.Clean = value; _notRefundableAmount = v128;
                var v129 = _offerRetailPriceIndicator; v129.Clean = value; _offerRetailPriceIndicator = v129;
                var v130 = _originalAcquisitionCost; v130.Clean = value; _originalAcquisitionCost = v130;
                var v131 = _originationFeeChargedAmount; v131.Clean = value; _originationFeeChargedAmount = v131;
                var v132 = _originationFeeChargedIndicator; v132.Clean = value; _originationFeeChargedIndicator = v132;
                var v133 = _originationFeeDecreasesRate; v133.Clean = value; _originationFeeDecreasesRate = v133;
                var v134 = _originationFeeIncreasesRate; v134.Clean = value; _originationFeeIncreasesRate = v134;
                var v135 = _originationFeeInterestRateImpactedStatus; v135.Clean = value; _originationFeeInterestRateImpactedStatus = v135;
                var v136 = _originationFeePaidBy; v136.Clean = value; _originationFeePaidBy = v136;
                var v137 = _paidByBorrower; v137.Clean = value; _paidByBorrower = v137;
                var v138 = _paidByLender; v138.Clean = value; _paidByLender = v138;
                var v139 = _paidByOther1; v139.Clean = value; _paidByOther1 = v139;
                var v140 = _paidByOther2; v140.Clean = value; _paidByOther2 = v140;
                var v141 = _paidByOtherDescription1; v141.Clean = value; _paidByOtherDescription1 = v141;
                var v142 = _paidByOtherDescription2; v142.Clean = value; _paidByOtherDescription2 = v142;
                var v143 = _previousMortgageAmountOne; v143.Clean = value; _previousMortgageAmountOne = v143;
                var v144 = _previousMortgageAmountTwo; v144.Clean = value; _previousMortgageAmountTwo = v144;
                var v145 = _printCertificationOfCosts; v145.Clean = value; _printCertificationOfCosts = v145;
                var v146 = _printInterestRateReductionRider; v146.Clean = value; _printInterestRateReductionRider = v146;
                var v147 = _printMDDeliveryIndicator; v147.Clean = value; _printMDDeliveryIndicator = v147;
                var v148 = _providedBy; v148.Clean = value; _providedBy = v148;
                var v149 = _questionContact; v149.Clean = value; _questionContact = v149;
                var v150 = _questionContactPhone; v150.Clean = value; _questionContactPhone = v150;
                var v151 = _questionContactTollFree; v151.Clean = value; _questionContactTollFree = v151;
                var v152 = _rateLockHonoredIndicator; v152.Clean = value; _rateLockHonoredIndicator = v152;
                var v153 = _receivedBy; v153.Clean = value; _receivedBy = v153;
                var v154 = _refinancingFee; v154.Clean = value; _refinancingFee = v154;
                var v155 = _refundableBy; v155.Clean = value; _refundableBy = v155;
                var v156 = _refundableIndicator; v156.Clean = value; _refundableIndicator = v156;
                var v157 = _refundableType; v157.Clean = value; _refundableType = v157;
                var v158 = _refundCondition1; v158.Clean = value; _refundCondition1 = v158;
                var v159 = _refundCondition2; v159.Clean = value; _refundCondition2 = v159;
                var v160 = _refundCondition3; v160.Clean = value; _refundCondition3 = v160;
                var v161 = _refundCondition4; v161.Clean = value; _refundCondition4 = v161;
                var v162 = _refundCondition5; v162.Clean = value; _refundCondition5 = v162;
                var v163 = _refundCondition6; v163.Clean = value; _refundCondition6 = v163;
                var v164 = _regulatorAddress; v164.Clean = value; _regulatorAddress = v164;
                var v165 = _regulatorCity; v165.Clean = value; _regulatorCity = v165;
                var v166 = _regulatorMailingAddress; v166.Clean = value; _regulatorMailingAddress = v166;
                var v167 = _regulatorMailingCity; v167.Clean = value; _regulatorMailingCity = v167;
                var v168 = _regulatorMailingState; v168.Clean = value; _regulatorMailingState = v168;
                var v169 = _regulatorMailingZipCode; v169.Clean = value; _regulatorMailingZipCode = v169;
                var v170 = _regulatorPhone; v170.Clean = value; _regulatorPhone = v170;
                var v171 = _regulatorState; v171.Clean = value; _regulatorState = v171;
                var v172 = _regulatorTollFreePhone; v172.Clean = value; _regulatorTollFreePhone = v172;
                var v173 = _regulatorWebAddress; v173.Clean = value; _regulatorWebAddress = v173;
                var v174 = _regulatorZipCode; v174.Clean = value; _regulatorZipCode = v174;
                var v175 = _scheduleOfChargesEstimatedFinalIndicator; v175.Clean = value; _scheduleOfChargesEstimatedFinalIndicator = v175;
                var v176 = _scRegulatoryAgencyType; v176.Clean = value; _scRegulatoryAgencyType = v176;
                var v177 = _selectDivisionFeesIndicator; v177.Clean = value; _selectDivisionFeesIndicator = v177;
                var v178 = _selectPrimaryLenderIndicator; v178.Clean = value; _selectPrimaryLenderIndicator = v178;
                var v179 = _selectPrivateLenderIndicator; v179.Clean = value; _selectPrivateLenderIndicator = v179;
                var v180 = _servicingFeeChargedAmount; v180.Clean = value; _servicingFeeChargedAmount = v180;
                var v181 = _servicingFeeChargedIndicator; v181.Clean = value; _servicingFeeChargedIndicator = v181;
                var v182 = _servicingFeePaidBy; v182.Clean = value; _servicingFeePaidBy = v182;
                var v183 = _servicingFeePaidFrequence; v183.Clean = value; _servicingFeePaidFrequence = v183;
                var v184 = _signedByBorrowerIndicator; v184.Clean = value; _signedByBorrowerIndicator = v184;
                var v185 = _specificARMIndicator; v185.Clean = value; _specificARMIndicator = v185;
                var v186 = _submitToLenderIndicator; v186.Clean = value; _submitToLenderIndicator = v186;
                var v187 = _taxExemptAcquisitionCostCertificationAssessments; v187.Clean = value; _taxExemptAcquisitionCostCertificationAssessments = v187;
                var v188 = _taxExemptAcquisitionCostCertificationOther; v188.Clean = value; _taxExemptAcquisitionCostCertificationOther = v188;
                var v189 = _taxExemptAcquisitionCostCertificationOtherAmount; v189.Clean = value; _taxExemptAcquisitionCostCertificationOtherAmount = v189;
                var v190 = _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; v190.Clean = value; _taxExemptAcquisitionCostCertificationOwnersTitleInsurance = v190;
                var v191 = _taxExemptAcquisitionCostCertificationRealEstateCommission; v191.Clean = value; _taxExemptAcquisitionCostCertificationRealEstateCommission = v191;
                var v192 = _taxExemptAcquisitionCostCertificationRepairsImprovements; v192.Clean = value; _taxExemptAcquisitionCostCertificationRepairsImprovements = v192;
                var v193 = _taxExemptAcquisitionCostCertificationSurvey; v193.Clean = value; _taxExemptAcquisitionCostCertificationSurvey = v193;
                var v194 = _taxExemptAcquisitionCostCertificationTotalAdjustments; v194.Clean = value; _taxExemptAcquisitionCostCertificationTotalAdjustments = v194;
                var v195 = _termsChange; v195.Clean = value; _termsChange = v195;
                var v196 = _texasApplicationFee; v196.Clean = value; _texasApplicationFee = v196;
                var v197 = _texasAppraisalFee; v197.Clean = value; _texasAppraisalFee = v197;
                var v198 = _texasCreditReportFee; v198.Clean = value; _texasCreditReportFee = v198;
                var v199 = _texasOtherFee1; v199.Clean = value; _texasOtherFee1 = v199;
                var v200 = _texasOtherFee2; v200.Clean = value; _texasOtherFee2 = v200;
                var v201 = _texasOtherFeeContact1; v201.Clean = value; _texasOtherFeeContact1 = v201;
                var v202 = _texasOtherFeeContact2; v202.Clean = value; _texasOtherFeeContact2 = v202;
                var v203 = _texasProcessingFee; v203.Clean = value; _texasProcessingFee = v203;
                var v204 = _thirdPartyFee; v204.Clean = value; _thirdPartyFee = v204;
                var v205 = _totalFee; v205.Clean = value; _totalFee = v205;
                var v206 = _transferFeeChargedAmount; v206.Clean = value; _transferFeeChargedAmount = v206;
                var v207 = _transferFeeChargedIndicator; v207.Clean = value; _transferFeeChargedIndicator = v207;
                var v208 = _transferFeePaidBy; v208.Clean = value; _transferFeePaidBy = v208;
                var v209 = _txVeteransLandBoardIndicator; v209.Clean = value; _txVeteransLandBoardIndicator = v209;
                var v210 = _typeOfProperty; v210.Clean = value; _typeOfProperty = v210;
                var v211 = _underwritingContact; v211.Clean = value; _underwritingContact = v211;
                var v212 = _underwritingFee; v212.Clean = value; _underwritingFee = v212;
                var v213 = _ySPChargedAmount; v213.Clean = value; _ySPChargedAmount = v213;
                var v214 = _ySPChargedIndicator; v214.Clean = value; _ySPChargedIndicator = v214;
                var v215 = _ySPDecreasesRate; v215.Clean = value; _ySPDecreasesRate = v215;
                var v216 = _ySPIncreasesRate; v216.Clean = value; _ySPIncreasesRate = v216;
                var v217 = _ySPInterestRateImpactedStatus; v217.Clean = value; _ySPInterestRateImpactedStatus = v217;
                var v218 = _ySPPaidBy; v218.Clean = value; _ySPPaidBy = v218;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}