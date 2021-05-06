using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// StateDisclosure
    /// </summary>
    public sealed partial class StateDisclosure : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?>? _acceptedByBorrowerIndicator;
        private DirtyValue<DateTime?>? _acceptedDate;
        private DirtyValue<string?>? _actingOtherDescription1;
        private DirtyValue<string?>? _actingOtherDescription2;
        private DirtyValue<bool?>? _actingOthersIndicator;
        private DirtyValue<int?>? _advFeeAgmtInEfctNumDay;
        private DirtyValue<string?>? _advisoryCondition1;
        private DirtyValue<string?>? _advisoryCondition2;
        private DirtyValue<string?>? _advisoryCondition3;
        private DirtyValue<string?>? _advisoryCondition4;
        private DirtyValue<decimal?>? _amendedAcquisitionCost;
        private DirtyValue<DateTime?>? _applicationDate;
        private DirtyValue<string?>? _appraisalContact;
        private DirtyValue<decimal?>? _appraisalDeposit;
        private DirtyValue<StringEnumValue<Areas>>? _areas;
        private DirtyValue<bool?>? _asAttorneyIndicator;
        private DirtyValue<bool?>? _asRealBrokerIndicator;
        private DirtyValue<bool?>? _attorneyForTheBuyerIndicator;
        private DirtyValue<bool?>? _attorneyForTheLenderIndicator;
        private DirtyValue<bool?>? _attorneyForTheSellerIndicator;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc1BlankFldDesc1;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc1BlankFldDesc2;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc1BlankFldDesc3;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc1Nm;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc2Nm;
        private DirtyValue<string?>? _aZCmplBlankSpcsDoc3Nm;
        private DirtyValue<string?>? _basedOnOthersDescription;
        private DirtyValue<bool?>? _basedOnOthersIndicator;
        private DirtyValue<bool?>? _basedOnWholesaleOptionsIndicator;
        private DirtyValue<decimal?>? _borrowerElectsEstablishEscrowAmount;
        private DirtyValue<bool?>? _borrowerElectsEstablishEscrowIndicator;
        private DirtyValue<decimal?>? _brokerageFeeAddition1;
        private DirtyValue<decimal?>? _brokerageFeeAddition2;
        private DirtyValue<decimal?>? _brokerageFeeAddition3;
        private DirtyValue<decimal?>? _brokerageFeeAmount1;
        private DirtyValue<decimal?>? _brokerageFeeAmount2;
        private DirtyValue<decimal?>? _brokerageFeeAmount3;
        private DirtyValue<int?>? _brokerageFeeDays;
        private DirtyValue<decimal?>? _brokerageFeePercent1;
        private DirtyValue<decimal?>? _brokerageFeePercent2;
        private DirtyValue<decimal?>? _brokerageFeePercent3;
        private DirtyValue<string?>? _brokerAuthorizedSigningRepName;
        private DirtyValue<string?>? _brokerAuthorizedSigningRepTitle;
        private DirtyValue<StringEnumValue<BrokerForTheSeller>>? _brokerForTheSeller;
        private DirtyValue<string?>? _brokerLicense;
        private DirtyValue<string?>? _brokerName;
        private DirtyValue<decimal?>? _brokerPayAddition;
        private DirtyValue<decimal?>? _brokerPayAmount;
        private DirtyValue<bool?>? _brokerPayIndicator;
        private DirtyValue<decimal?>? _brokerPayPercent;
        private DirtyValue<bool?>? _cHARMBookletIndicator;
        private DirtyValue<string?>? _checkPayableTo;
        private DirtyValue<decimal?>? _commitmentAmount;
        private DirtyValue<string?>? _commitmentCondition1;
        private DirtyValue<string?>? _commitmentCondition2;
        private DirtyValue<decimal?>? _commitmentFee;
        private DirtyValue<decimal?>? _commitmentPercent;
        private DirtyValue<decimal?>? _compensationAddition;
        private DirtyValue<decimal?>? _compensationPercent;
        private DirtyValue<decimal?>? _creditDeposit;
        private DirtyValue<string?>? _creditIsUsedForReason;
        private DirtyValue<string?>? _creditReportContact;
        private DirtyValue<int?>? _daysBeforeClosing;
        private DirtyValue<decimal?>? _depositReceipt;
        private DirtyValue<bool?>? _depositRefundableIndicator;
        private DirtyValue<string?>? _directContact;
        private DirtyValue<decimal?>? _directPayAmount;
        private DirtyValue<decimal?>? _directPayClosing;
        private DirtyValue<decimal?>? _directPayCommitment;
        private DirtyValue<bool?>? _directPayIndicator;
        private DirtyValue<decimal?>? _directPayPercent;
        private DirtyValue<StringEnumValue<DisclosureDeliveredBy>>? _disclosureDeliveredBy;
        private DirtyValue<string?>? _disclosureDeliveredByOtherMethod;
        private DirtyValue<DateTime?>? _disclosureDeliveredDate;
        private DirtyValue<bool?>? _estimatedChargeShownOnGFEIndicator;
        private DirtyValue<DateTime?>? _expirationDate;
        private DirtyValue<decimal?>? _federallySubsidizedAmount;
        private DirtyValue<decimal?>? _federallySubsidizedAmountPercentage;
        private DirtyValue<decimal?>? _feeReceived1;
        private DirtyValue<decimal?>? _feeReceived2;
        private DirtyValue<StringEnumValue<RefundableType>>? _feeReceivedByLender;
        private DirtyValue<decimal?>? _feesReceiving;
        private DirtyValue<decimal?>? _floridaApplicationFee;
        private DirtyValue<decimal?>? _floridaOtherFee1;
        private DirtyValue<decimal?>? _floridaOtherFee2;
        private DirtyValue<string?>? _floridaOtherFeeTo1;
        private DirtyValue<string?>? _floridaOtherFeeTo2;
        private DirtyValue<string?>? _floridaOtherFeeTo3;
        private DirtyValue<string?>? _floridaOtherFeeTo4;
        private DirtyValue<string?>? _furtherFeesEarnedByMortgageBroker;
        private DirtyValue<decimal?>? _gFEFeeReceived1;
        private DirtyValue<decimal?>? _gFEFeeReceived2;
        private DirtyValue<bool?>? _hUDBookletIndicator;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _independentContractorIndicator;
        private DirtyValue<string?>? _indexUsed;
        private DirtyValue<string?>? _informationAboutTheIndexCanBeFound;
        private DirtyValue<string?>? _inLicensedNo;
        private DirtyValue<StringEnumValue<InLicensedType>>? _inLicensedType;
        private DirtyValue<bool?>? _isEstimateIndicator;
        private DirtyValue<bool?>? _ksUcccElectionIndicator;
        private DirtyValue<bool?>? _kyHomeSolicationLoanIndicator;
        private DirtyValue<DateTime?>? _leaseAgreementDate;
        private DirtyValue<DateTime?>? _lenderDate;
        private DirtyValue<string?>? _lenderName;
        private DirtyValue<decimal?>? _lenderPaid;
        private DirtyValue<decimal?>? _lenderPayAmount;
        private DirtyValue<bool?>? _lenderPayIndicator;
        private DirtyValue<decimal?>? _lenderPayMaxPoint;
        private DirtyValue<decimal?>? _lenderPayPercent;
        private DirtyValue<decimal?>? _lenderPayPoint;
        private DirtyValue<bool?>? _lenderPayUnknownIndicator;
        private DirtyValue<string?>? _lenderStatus;
        private DirtyValue<string?>? _lessorName;
        private DirtyValue<bool?>? _loanTermsFixedThroughDateofLoanClosingIndicator;
        private DirtyValue<decimal?>? _lockInFee;
        private DirtyValue<string?>? _methodDescription;
        private DirtyValue<StringEnumValue<MethodDetermine>>? _methodDetermine;
        private DirtyValue<bool?>? _mortgageAgreementIndicator;
        private DirtyValue<string?>? _mtgBrokerLicense;
        private DirtyValue<string?>? _nameOfLicensee;
        private DirtyValue<decimal?>? _newMoneyAmount;
        private DirtyValue<decimal?>? _newYorkApplicationFee;
        private DirtyValue<decimal?>? _newYorkAppraisalFee;
        private DirtyValue<decimal?>? _newYorkCreditReportFee;
        private DirtyList<NewYorkFee>? _newYorkFees;
        private DirtyList<NewYorkPrimaryLender>? _newYorkPrimaryLenders;
        private DirtyValue<decimal?>? _newYorkProcessingFee;
        private DirtyValue<decimal?>? _notRefundableAmount;
        private DirtyValue<bool?>? _offerRetailPriceIndicator;
        private DirtyValue<decimal?>? _originalAcquisitionCost;
        private DirtyValue<decimal?>? _originationFeeChargedAmount;
        private DirtyValue<bool?>? _originationFeeChargedIndicator;
        private DirtyValue<decimal?>? _originationFeeDecreasesRate;
        private DirtyValue<decimal?>? _originationFeeIncreasesRate;
        private DirtyValue<StringEnumValue<InterestRateImpactedStatus>>? _originationFeeInterestRateImpactedStatus;
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>>? _originationFeePaidBy;
        private DirtyValue<decimal?>? _paidByBorrower;
        private DirtyValue<decimal?>? _paidByLender;
        private DirtyValue<decimal?>? _paidByOther1;
        private DirtyValue<decimal?>? _paidByOther2;
        private DirtyValue<string?>? _paidByOtherDescription1;
        private DirtyValue<string?>? _paidByOtherDescription2;
        private DirtyValue<decimal?>? _previousMortgageAmountOne;
        private DirtyValue<decimal?>? _previousMortgageAmountTwo;
        private DirtyValue<bool?>? _printCertificationOfCosts;
        private DirtyValue<bool?>? _printInterestRateReductionRider;
        private DirtyValue<bool?>? _printMDDeliveryIndicator;
        private DirtyValue<StringEnumValue<ProvidedBy>>? _providedBy;
        private DirtyValue<string?>? _questionContact;
        private DirtyValue<string?>? _questionContactPhone;
        private DirtyValue<string?>? _questionContactTollFree;
        private DirtyValue<bool?>? _rateLockHonoredIndicator;
        private DirtyValue<string?>? _receivedBy;
        private DirtyValue<decimal?>? _refinancingFee;
        private DirtyValue<string?>? _refundableBy;
        private DirtyValue<bool?>? _refundableIndicator;
        private DirtyValue<StringEnumValue<RefundableType>>? _refundableType;
        private DirtyValue<string?>? _refundCondition1;
        private DirtyValue<string?>? _refundCondition2;
        private DirtyValue<string?>? _refundCondition3;
        private DirtyValue<string?>? _refundCondition4;
        private DirtyValue<string?>? _refundCondition5;
        private DirtyValue<string?>? _refundCondition6;
        private DirtyValue<string?>? _regulatorAddress;
        private DirtyValue<string?>? _regulatorCity;
        private DirtyValue<string?>? _regulatorMailingAddress;
        private DirtyValue<string?>? _regulatorMailingCity;
        private DirtyValue<StringEnumValue<State>>? _regulatorMailingState;
        private DirtyValue<string?>? _regulatorMailingZipCode;
        private DirtyValue<string?>? _regulatorPhone;
        private DirtyValue<StringEnumValue<State>>? _regulatorState;
        private DirtyValue<string?>? _regulatorTollFreePhone;
        private DirtyValue<string?>? _regulatorWebAddress;
        private DirtyValue<string?>? _regulatorZipCode;
        private DirtyValue<StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator>>? _scheduleOfChargesEstimatedFinalIndicator;
        private DirtyValue<StringEnumValue<ScRegulatoryAgencyType>>? _scRegulatoryAgencyType;
        private DirtyValue<bool?>? _selectDivisionFeesIndicator;
        private DirtyValue<bool?>? _selectPrimaryLenderIndicator;
        private DirtyValue<bool?>? _selectPrivateLenderIndicator;
        private DirtyValue<decimal?>? _servicingFeeChargedAmount;
        private DirtyValue<bool?>? _servicingFeeChargedIndicator;
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>>? _servicingFeePaidBy;
        private DirtyValue<StringEnumValue<ServicingFeePaidFrequence>>? _servicingFeePaidFrequence;
        private DirtyValue<bool?>? _signedByBorrowerIndicator;
        private DirtyValue<bool?>? _specificARMIndicator;
        private DirtyValue<bool?>? _submitToLenderIndicator;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationAssessments;
        private DirtyValue<string?>? _taxExemptAcquisitionCostCertificationOther;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationOtherAmount;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationOwnersTitleInsurance;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationRealEstateCommission;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationRepairsImprovements;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationSurvey;
        private DirtyValue<decimal?>? _taxExemptAcquisitionCostCertificationTotalAdjustments;
        private DirtyValue<StringEnumValue<TermsChange>>? _termsChange;
        private DirtyValue<decimal?>? _texasApplicationFee;
        private DirtyValue<decimal?>? _texasAppraisalFee;
        private DirtyValue<decimal?>? _texasCreditReportFee;
        private DirtyValue<decimal?>? _texasOtherFee1;
        private DirtyValue<decimal?>? _texasOtherFee2;
        private DirtyValue<string?>? _texasOtherFeeContact1;
        private DirtyValue<string?>? _texasOtherFeeContact2;
        private DirtyValue<decimal?>? _texasProcessingFee;
        private DirtyValue<decimal?>? _thirdPartyFee;
        private DirtyValue<decimal?>? _totalFee;
        private DirtyValue<decimal?>? _transferFeeChargedAmount;
        private DirtyValue<bool?>? _transferFeeChargedIndicator;
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>>? _transferFeePaidBy;
        private DirtyValue<bool?>? _txVeteransLandBoardIndicator;
        private DirtyValue<StringEnumValue<TypeOfProperty>>? _typeOfProperty;
        private DirtyValue<string?>? _underwritingContact;
        private DirtyValue<decimal?>? _underwritingFee;
        private DirtyValue<decimal?>? _ySPChargedAmount;
        private DirtyValue<bool?>? _ySPChargedIndicator;
        private DirtyValue<decimal?>? _ySPDecreasesRate;
        private DirtyValue<decimal?>? _ySPIncreasesRate;
        private DirtyValue<StringEnumValue<InterestRateImpactedStatus>>? _ySPInterestRateImpactedStatus;
        private DirtyValue<StringEnumValue<StateDisclosureFeePaidBy>>? _ySPPaidBy;

        /// <summary>
        /// Disclosure-FL Borr Accept [FLMTGCM.X10]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"The date by which the commitment must be accepted by the borrower is\"}")]
        public bool? AcceptedByBorrowerIndicator { get => _acceptedByBorrowerIndicator; set => SetField(ref _acceptedByBorrowerIndicator, value); }

        /// <summary>
        /// Disclosure-FL Borr Accept Date [FLMTGCM.X11]
        /// </summary>
        public DateTime? AcceptedDate { get => _acceptedDate; set => SetField(ref _acceptedDate, value); }

        /// <summary>
        /// Disclosure-TX Act Descr 1 [DISCLOSURE.X77]
        /// </summary>
        public string? ActingOtherDescription1 { get => _actingOtherDescription1; set => SetField(ref _actingOtherDescription1, value); }

        /// <summary>
        /// Disclosure-TX Act Descr 2 [DISCLOSURE.X78]
        /// </summary>
        public string? ActingOtherDescription2 { get => _actingOtherDescription2; set => SetField(ref _actingOtherDescription2, value); }

        /// <summary>
        /// Disclosure-TX Act as Follows [DISCLOSURE.X76]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"We will be acting as follows:\"}")]
        public bool? ActingOthersIndicator { get => _actingOthersIndicator; set => SetField(ref _actingOthersIndicator, value); }

        /// <summary>
        /// Disclosure-AZ Advance Fee Agreement In Effect Number Of Days [DISCLOSURE.X915]
        /// </summary>
        public int? AdvFeeAgmtInEfctNumDay { get => _advFeeAgmtInEfctNumDay; set => SetField(ref _advFeeAgmtInEfctNumDay, value); }

        /// <summary>
        /// Disclosure-NY Acknowledge 1 [DISCLOSURE.X105]
        /// </summary>
        public string? AdvisoryCondition1 { get => _advisoryCondition1; set => SetField(ref _advisoryCondition1, value); }

        /// <summary>
        /// Disclosure-NY Acknowledge 2 [DISCLOSURE.X106]
        /// </summary>
        public string? AdvisoryCondition2 { get => _advisoryCondition2; set => SetField(ref _advisoryCondition2, value); }

        /// <summary>
        /// Disclosure-NY Acknowledge 3 [DISCLOSURE.X107]
        /// </summary>
        public string? AdvisoryCondition3 { get => _advisoryCondition3; set => SetField(ref _advisoryCondition3, value); }

        /// <summary>
        /// Disclosure-NY Acknowledge 4 [DISCLOSURE.X108]
        /// </summary>
        public string? AdvisoryCondition4 { get => _advisoryCondition4; set => SetField(ref _advisoryCondition4, value); }

        /// <summary>
        /// Disclosure - AK - Amended Acquisition Cost [DISCLOSURE.X974]
        /// </summary>
        public decimal? AmendedAcquisitionCost { get => _amendedAcquisitionCost; set => SetField(ref _amendedAcquisitionCost, value); }

        /// <summary>
        /// Disclosure-NY Application Date [DISCLOSURE.X172]
        /// </summary>
        public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

        /// <summary>
        /// Disclosure-TX Appraisal Fee Descr [DISCLOSURE.X84]
        /// </summary>
        public string? AppraisalContact { get => _appraisalContact; set => SetField(ref _appraisalContact, value); }

        /// <summary>
        /// Disclosure-FL Appraisal Fee [DISCLOSURE.X69]
        /// </summary>
        public decimal? AppraisalDeposit { get => _appraisalDeposit; set => SetField(ref _appraisalDeposit, value); }

        /// <summary>
        /// Disclosure - AK - Areas [DISCLOSURE.X960]
        /// </summary>
        public StringEnumValue<Areas> Areas { get => _areas; set => SetField(ref _areas, value); }

        /// <summary>
        /// Disclosure-TX Role - Attorney [DISCLOSURE.X99]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"as an attorney for\"}")]
        public bool? AsAttorneyIndicator { get => _asAttorneyIndicator; set => SetField(ref _asAttorneyIndicator, value); }

        /// <summary>
        /// Disclosure-TX Role - RE Broker/Agent [DISCLOSURE.X95]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"as a real estate broker, agent, or salesperson for\"}")]
        public bool? AsRealBrokerIndicator { get => _asRealBrokerIndicator; set => SetField(ref _asRealBrokerIndicator, value); }

        /// <summary>
        /// Disclosure-TX Attorney for Buyer [DISCLOSURE.X101]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"you (the buyer)\"}")]
        public bool? AttorneyForTheBuyerIndicator { get => _attorneyForTheBuyerIndicator; set => SetField(ref _attorneyForTheBuyerIndicator, value); }

        /// <summary>
        /// Disclosure-TX Attorney for Buyer/Seller [DISCLOSURE.X102]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"the lender\"}")]
        public bool? AttorneyForTheLenderIndicator { get => _attorneyForTheLenderIndicator; set => SetField(ref _attorneyForTheLenderIndicator, value); }

        /// <summary>
        /// Disclosure-TX Attorney for Seller [DISCLOSURE.X100]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"the seller\"}")]
        public bool? AttorneyForTheSellerIndicator { get => _attorneyForTheSellerIndicator; set => SetField(ref _attorneyForTheSellerIndicator, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 1 [DISCLOSURE.X917]
        /// </summary>
        public string? AZCmplBlankSpcsDoc1BlankFldDesc1 { get => _aZCmplBlankSpcsDoc1BlankFldDesc1; set => SetField(ref _aZCmplBlankSpcsDoc1BlankFldDesc1, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 2 [DISCLOSURE.X919]
        /// </summary>
        public string? AZCmplBlankSpcsDoc1BlankFldDesc2 { get => _aZCmplBlankSpcsDoc1BlankFldDesc2; set => SetField(ref _aZCmplBlankSpcsDoc1BlankFldDesc2, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document Description 3 [DISCLOSURE.X921]
        /// </summary>
        public string? AZCmplBlankSpcsDoc1BlankFldDesc3 { get => _aZCmplBlankSpcsDoc1BlankFldDesc3; set => SetField(ref _aZCmplBlankSpcsDoc1BlankFldDesc3, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 1 [DISCLOSURE.X916]
        /// </summary>
        public string? AZCmplBlankSpcsDoc1Nm { get => _aZCmplBlankSpcsDoc1Nm; set => SetField(ref _aZCmplBlankSpcsDoc1Nm, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 2 [DISCLOSURE.X918]
        /// </summary>
        public string? AZCmplBlankSpcsDoc2Nm { get => _aZCmplBlankSpcsDoc2Nm; set => SetField(ref _aZCmplBlankSpcsDoc2Nm, value); }

        /// <summary>
        /// Disclosure-AZ AZ Complete Blank Spaces Document 3 [DISCLOSURE.X920]
        /// </summary>
        public string? AZCmplBlankSpcsDoc3Nm { get => _aZCmplBlankSpcsDoc3Nm; set => SetField(ref _aZCmplBlankSpcsDoc3Nm, value); }

        /// <summary>
        /// Disclosure-TX Compensated Based on Others Description [DISCLOSURE.X909]
        /// </summary>
        public string? BasedOnOthersDescription { get => _basedOnOthersDescription; set => SetField(ref _basedOnOthersDescription, value); }

        /// <summary>
        /// Disclosure-TX Compensated Based on Others [DISCLOSURE.X908]
        /// </summary>
        public bool? BasedOnOthersIndicator { get => _basedOnOthersIndicator; set => SetField(ref _basedOnOthersIndicator, value); }

        /// <summary>
        /// Disclosure-TX Compensated Wholesale Options [DISCLOSURE.X80]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Our pricing for your loan is based upon current wholesale options available to us\"}")]
        public bool? BasedOnWholesaleOptionsIndicator { get => _basedOnWholesaleOptionsIndicator; set => SetField(ref _basedOnWholesaleOptionsIndicator, value); }

        /// <summary>
        /// Disclosure- CA Borrower Elects To Establish Escrow Account Amount [DISCLOSURE.X914]
        /// </summary>
        public decimal? BorrowerElectsEstablishEscrowAmount { get => _borrowerElectsEstablishEscrowAmount; set => SetField(ref _borrowerElectsEstablishEscrowAmount, value); }

        /// <summary>
        /// Disclosure- CA Borrower Elects To Establish Escrow Account Indicator [DISCLOSURE.X913]
        /// </summary>
        public bool? BorrowerElectsEstablishEscrowIndicator { get => _borrowerElectsEstablishEscrowIndicator; set => SetField(ref _borrowerElectsEstablishEscrowIndicator, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee Amt [DISCLOSURE.X62]
        /// </summary>
        public decimal? BrokerageFeeAddition1 { get => _brokerageFeeAddition1; set => SetField(ref _brokerageFeeAddition1, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp From Amt [DISCLOSURE.X64]
        /// </summary>
        public decimal? BrokerageFeeAddition2 { get => _brokerageFeeAddition2; set => SetField(ref _brokerageFeeAddition2, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp To Amt [DISCLOSURE.X66]
        /// </summary>
        public decimal? BrokerageFeeAddition3 { get => _brokerageFeeAddition3; set => SetField(ref _brokerageFeeAddition3, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee Total [FLGFE.X38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BrokerageFeeAmount1 { get => _brokerageFeeAmount1; set => SetField(ref _brokerageFeeAmount1, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp From Total [FLGFE.X39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BrokerageFeeAmount2 { get => _brokerageFeeAmount2; set => SetField(ref _brokerageFeeAmount2, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp To Total [FLGFE.X40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BrokerageFeeAmount3 { get => _brokerageFeeAmount3; set => SetField(ref _brokerageFeeAmount3, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee # Days [FLGFE.X41]
        /// </summary>
        public int? BrokerageFeeDays { get => _brokerageFeeDays; set => SetField(ref _brokerageFeeDays, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Broker Fee % [DISCLOSURE.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerageFeePercent1 { get => _brokerageFeePercent1; set => SetField(ref _brokerageFeePercent1, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp From % [DISCLOSURE.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerageFeePercent2 { get => _brokerageFeePercent2; set => SetField(ref _brokerageFeePercent2, value); }

        /// <summary>
        /// Disclosure-FL Borr Paid Comp To % [DISCLOSURE.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerageFeePercent3 { get => _brokerageFeePercent3; set => SetField(ref _brokerageFeePercent3, value); }

        /// <summary>
        /// Disclosure-NV Broker Authorized Signing Representative Name [DISCLOSURE.X922]
        /// </summary>
        public string? BrokerAuthorizedSigningRepName { get => _brokerAuthorizedSigningRepName; set => SetField(ref _brokerAuthorizedSigningRepName, value); }

        /// <summary>
        /// Disclosure-NV Broker Authorized Signing Representative Title [DISCLOSURE.X923]
        /// </summary>
        public string? BrokerAuthorizedSigningRepTitle { get => _brokerAuthorizedSigningRepTitle; set => SetField(ref _brokerAuthorizedSigningRepTitle, value); }

        /// <summary>
        /// Disclosure-TX Broker for Seller/Buyer/Buyer and Seller [DISCLOSURE.X96]
        /// </summary>
        public StringEnumValue<BrokerForTheSeller> BrokerForTheSeller { get => _brokerForTheSeller; set => SetField(ref _brokerForTheSeller, value); }

        /// <summary>
        /// Disclosure-TX License # [DISCLOSURE.X73]
        /// </summary>
        public string? BrokerLicense { get => _brokerLicense; set => SetField(ref _brokerLicense, value); }

        /// <summary>
        /// Disclosure-TX Broker/Loan Officer [DISCLOSURE.X72]
        /// </summary>
        public string? BrokerName { get => _brokerName; set => SetField(ref _brokerName, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Fee + [DISCLOSURE.X98]
        /// </summary>
        public decimal? BrokerPayAddition { get => _brokerPayAddition; set => SetField(ref _brokerPayAddition, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Fee Amt [DISCLOSURE.X116]
        /// </summary>
        public decimal? BrokerPayAmount { get => _brokerPayAmount; set => SetField(ref _brokerPayAmount, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Fee [DISCLOSURE.X114]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I will pay you a fee of\"}")]
        public bool? BrokerPayIndicator { get => _brokerPayIndicator; set => SetField(ref _brokerPayIndicator, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Fee % [DISCLOSURE.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerPayPercent { get => _brokerPayPercent; set => SetField(ref _brokerPayPercent, value); }

        /// <summary>
        /// Disclosure-FL Federal CHARM booklet [FLGFE.X73]
        /// </summary>
        public bool? CHARMBookletIndicator { get => _cHARMBookletIndicator; set => SetField(ref _cHARMBookletIndicator, value); }

        /// <summary>
        /// Disclosure-FL Check Payable To [DISCLOSURE.X170]
        /// </summary>
        public string? CheckPayableTo { get => _checkPayableTo; set => SetField(ref _checkPayableTo, value); }

        /// <summary>
        /// Disclosure-FL Interest Rate Fee Amt [FLMTGCM.X15]
        /// </summary>
        public decimal? CommitmentAmount { get => _commitmentAmount; set => SetField(ref _commitmentAmount, value); }

        /// <summary>
        /// Disclosure-NY Loan Commit Conditions 1 [DISCLOSURE.X103]
        /// </summary>
        public string? CommitmentCondition1 { get => _commitmentCondition1; set => SetField(ref _commitmentCondition1, value); }

        /// <summary>
        /// Disclosure-NY Loan Commit Conditions 2 [DISCLOSURE.X104]
        /// </summary>
        public string? CommitmentCondition2 { get => _commitmentCondition2; set => SetField(ref _commitmentCondition2, value); }

        /// <summary>
        /// Disclosure-FL Commitment Fee [FLMTGCM.X7]
        /// </summary>
        public decimal? CommitmentFee { get => _commitmentFee; set => SetField(ref _commitmentFee, value); }

        /// <summary>
        /// Disclosure-FL Interest Rate Fee % [FLMTGCM.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CommitmentPercent { get => _commitmentPercent; set => SetField(ref _commitmentPercent, value); }

        /// <summary>
        /// Disclosure-FL Lender Paid Broker Comp To % [FLGFE.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? CompensationAddition { get => _compensationAddition; set => SetField(ref _compensationAddition, value); }

        /// <summary>
        /// Disclosure-FL Lender Paid Broker Comp From % [FLGFE.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? CompensationPercent { get => _compensationPercent; set => SetField(ref _compensationPercent, value); }

        /// <summary>
        /// Disclosure-FL Credit Deposit [DISCLOSURE.X70]
        /// </summary>
        public decimal? CreditDeposit { get => _creditDeposit; set => SetField(ref _creditDeposit, value); }

        /// <summary>
        /// Disclosure Credit Score Used From The Credit Report to Set the Terms of Credit [DISCLOSURE.X637]
        /// </summary>
        public string? CreditIsUsedForReason { get => _creditIsUsedForReason; set => SetField(ref _creditIsUsedForReason, value); }

        /// <summary>
        /// Disclosure-TX Credit Rpt Fee Descr [DISCLOSURE.X86]
        /// </summary>
        public string? CreditReportContact { get => _creditReportContact; set => SetField(ref _creditReportContact, value); }

        /// <summary>
        /// Disclosure-FL Rate Est # Days Before Close [FLMTGCM.X6]
        /// </summary>
        public int? DaysBeforeClosing { get => _daysBeforeClosing; set => SetField(ref _daysBeforeClosing, value); }

        /// <summary>
        /// Disclosure-FL Receipt of Deposit Amt [FLGFE.X53]
        /// </summary>
        public decimal? DepositReceipt { get => _depositReceipt; set => SetField(ref _depositReceipt, value); }

        /// <summary>
        /// Disclosure-FL Deposit Refundable [FLGFE.X55]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Refundable by\"}")]
        public bool? DepositRefundableIndicator { get => _depositRefundableIndicator; set => SetField(ref _depositRefundableIndicator, value); }

        /// <summary>
        /// Disclosure-FL Direct inquiries To [FLGFE.X70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DirectContact { get => _directContact; set => SetField(ref _directContact, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Direct Amt [DISCLOSURE.X121]
        /// </summary>
        public decimal? DirectPayAmount { get => _directPayAmount; set => SetField(ref _directPayAmount, value); }

        /// <summary>
        /// Disclosure-NY  Broker Paid Direct at Close [DISCLOSURE.X119]
        /// </summary>
        public decimal? DirectPayClosing { get => _directPayClosing; set => SetField(ref _directPayClosing, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Direct at Commit [DISCLOSURE.X118]
        /// </summary>
        public decimal? DirectPayCommitment { get => _directPayCommitment; set => SetField(ref _directPayCommitment, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Direct [DISCLOSURE.X117]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I will pay you directly, upon my signed acceptance of a commitment\"}")]
        public bool? DirectPayIndicator { get => _directPayIndicator; set => SetField(ref _directPayIndicator, value); }

        /// <summary>
        /// Disclosure-NY Broker Paid Direct % [DISCLOSURE.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DirectPayPercent { get => _directPayPercent; set => SetField(ref _directPayPercent, value); }

        /// <summary>
        /// Disclosure - TX - Disclosure Delivered By [DISCLOSURE.X957]
        /// </summary>
        public StringEnumValue<DisclosureDeliveredBy> DisclosureDeliveredBy { get => _disclosureDeliveredBy; set => SetField(ref _disclosureDeliveredBy, value); }

        /// <summary>
        /// Disclosure - TX - Disclosure Delivered By Other Method [DISCLOSURE.X958]
        /// </summary>
        public string? DisclosureDeliveredByOtherMethod { get => _disclosureDeliveredByOtherMethod; set => SetField(ref _disclosureDeliveredByOtherMethod, value); }

        /// <summary>
        /// Disclosure - TX - Disclosure Delivered Date [DISCLOSURE.X959]
        /// </summary>
        public DateTime? DisclosureDeliveredDate { get => _disclosureDeliveredDate; set => SetField(ref _disclosureDeliveredDate, value); }

        /// <summary>
        /// Disclosure-TX Estimated fees Will be Shown on the Good Faith Estimate Which We are Providing Now or Within three (3) Days. [DISCLOSURE.X910]
        /// </summary>
        public bool? EstimatedChargeShownOnGFEIndicator { get => _estimatedChargeShownOnGFEIndicator; set => SetField(ref _estimatedChargeShownOnGFEIndicator, value); }

        /// <summary>
        /// Disclosure-FL Expiration Date [FLMTGCM.X1]
        /// </summary>
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

        /// <summary>
        /// Disclosure - AK - Federally-Subsidized Amount [DISCLOSURE.X964]
        /// </summary>
        public decimal? FederallySubsidizedAmount { get => _federallySubsidizedAmount; set => SetField(ref _federallySubsidizedAmount, value); }

        /// <summary>
        /// Disclosure - AK - Federally-Subsidized Amount Percentage [DISCLOSURE.X963]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FederallySubsidizedAmountPercentage { get => _federallySubsidizedAmountPercentage; set => SetField(ref _federallySubsidizedAmountPercentage, value); }

        /// <summary>
        /// Disclosure-NY Fee Amt [DISCLOSURE.X150]
        /// </summary>
        public decimal? FeeReceived1 { get => _feeReceived1; set => SetField(ref _feeReceived1, value); }

        /// <summary>
        /// Disclosure-NY Recipient Fee Amt [DISCLOSURE.X152]
        /// </summary>
        public decimal? FeeReceived2 { get => _feeReceived2; set => SetField(ref _feeReceived2, value); }

        /// <summary>
        /// Disclosure-FL Lender Fee Refund/Non-Refund [FLGFE.X71]
        /// </summary>
        public StringEnumValue<RefundableType> FeeReceivedByLender { get => _feeReceivedByLender; set => SetField(ref _feeReceivedByLender, value); }

        /// <summary>
        /// Disclosure-TX Rec $ Fees [DISCLOSURE.X81]
        /// </summary>
        public decimal? FeesReceiving { get => _feesReceiving; set => SetField(ref _feesReceiving, value); }

        /// <summary>
        /// Disclosure-FL Application Fee [DISCLOSURE.X67]
        /// </summary>
        public decimal? FloridaApplicationFee { get => _floridaApplicationFee; set => SetField(ref _floridaApplicationFee, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 1 Amt [FLMTGCM.X18]
        /// </summary>
        public decimal? FloridaOtherFee1 { get => _floridaOtherFee1; set => SetField(ref _floridaOtherFee1, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 3 Amt [FLMTGCM.X21]
        /// </summary>
        public decimal? FloridaOtherFee2 { get => _floridaOtherFee2; set => SetField(ref _floridaOtherFee2, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 1 Descr [FLMTGCM.X17]
        /// </summary>
        public string? FloridaOtherFeeTo1 { get => _floridaOtherFeeTo1; set => SetField(ref _floridaOtherFeeTo1, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 2 Descr [FLMTGCM.X19]
        /// </summary>
        public string? FloridaOtherFeeTo2 { get => _floridaOtherFeeTo2; set => SetField(ref _floridaOtherFeeTo2, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 3 Descr [FLMTGCM.X20]
        /// </summary>
        public string? FloridaOtherFeeTo3 { get => _floridaOtherFeeTo3; set => SetField(ref _floridaOtherFeeTo3, value); }

        /// <summary>
        /// Disclosure-FL Other Fee 4 Descr [FLMTGCM.X22]
        /// </summary>
        public string? FloridaOtherFeeTo4 { get => _floridaOtherFeeTo4; set => SetField(ref _floridaOtherFeeTo4, value); }

        /// <summary>
        /// Disclosure-NV Further Explanation of Any Fee Earned by Mortgage Broker [DISCLOSURE.X949]
        /// </summary>
        public string? FurtherFeesEarnedByMortgageBroker { get => _furtherFeesEarnedByMortgageBroker; set => SetField(ref _furtherFeesEarnedByMortgageBroker, value); }

        /// <summary>
        /// Disclosure-NY GFE Amt [DISCLOSURE.X151]
        /// </summary>
        public decimal? GFEFeeReceived1 { get => _gFEFeeReceived1; set => SetField(ref _gFEFeeReceived1, value); }

        /// <summary>
        /// Disclosure-NY Recipient GFE Amt [DISCLOSURE.X153]
        /// </summary>
        public decimal? GFEFeeReceived2 { get => _gFEFeeReceived2; set => SetField(ref _gFEFeeReceived2, value); }

        /// <summary>
        /// Disclosure-FL HUD settlement booklet [FLGFE.X75]
        /// </summary>
        public bool? HUDBookletIndicator { get => _hUDBookletIndicator; set => SetField(ref _hUDBookletIndicator, value); }

        /// <summary>
        /// StateDisclosure Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Disclosure-TX Act as Independent Contractor [DISCLOSURE.X75]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"We are acting as an independent contractor\"}")]
        public bool? IndependentContractorIndicator { get => _independentContractorIndicator; set => SetField(ref _independentContractorIndicator, value); }

        /// <summary>
        /// Disclosure-FL Int Rate Index Used [DISCLOSURE.X168]
        /// </summary>
        public string? IndexUsed { get => _indexUsed; set => SetField(ref _indexUsed, value); }

        /// <summary>
        /// Disclosure-FL Int Rate Index Info [DISCLOSURE.X169]
        /// </summary>
        public string? InformationAboutTheIndexCanBeFound { get => _informationAboutTheIndexCanBeFound; set => SetField(ref _informationAboutTheIndexCanBeFound, value); }

        /// <summary>
        /// Disclosure Licensed No [DISCLOSURE.X1027]
        /// </summary>
        public string? InLicensedNo { get => _inLicensedNo; set => SetField(ref _inLicensedNo, value); }

        /// <summary>
        /// Disclosure Licensed Type [DISCLOSURE.X1028]
        /// </summary>
        public StringEnumValue<InLicensedType> InLicensedType { get => _inLicensedType; set => SetField(ref _inLicensedType, value); }

        /// <summary>
        /// Disclosure-FL is Estimate [FLMTGCM.X12]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"This disclosure is an ESTIMATE. Some of the information necessary for an accurate disclosure is unknown to the lender. This disclosure is based upon the best information reasonably available to the lender at this time.\"}")]
        public bool? IsEstimateIndicator { get => _isEstimateIndicator; set => SetField(ref _isEstimateIndicator, value); }

        /// <summary>
        /// Disclosure - KS - Kansas UCCC Election [DISCLOSURE.X954]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public bool? KsUcccElectionIndicator { get => _ksUcccElectionIndicator; set => SetField(ref _ksUcccElectionIndicator, value); }

        /// <summary>
        /// Disclosure - KY - Kentucky Home Solicitation Loan [DISCLOSURE.X956]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public bool? KyHomeSolicationLoanIndicator { get => _kyHomeSolicationLoanIndicator; set => SetField(ref _kyHomeSolicationLoanIndicator, value); }

        /// <summary>
        /// Disclosure - AK - Lease Agreement Date [DISCLOSURE.X975]
        /// </summary>
        public DateTime? LeaseAgreementDate { get => _leaseAgreementDate; set => SetField(ref _leaseAgreementDate, value); }

        /// <summary>
        /// Disclosure-NY Date [DISCLOSURE.X156]
        /// </summary>
        public DateTime? LenderDate { get => _lenderDate; set => SetField(ref _lenderDate, value); }

        /// <summary>
        /// Disclosure-NY Lender [DISCLOSURE.X154]
        /// </summary>
        public string? LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }

        /// <summary>
        /// Disclosure-FL Lender fee paid to licensee [FLGFE.X77]
        /// </summary>
        public decimal? LenderPaid { get => _lenderPaid; set => SetField(ref _lenderPaid, value); }

        /// <summary>
        /// Disclosure-NY Lender Paid Fee Amt [DISCLOSURE.X111]
        /// </summary>
        public decimal? LenderPayAmount { get => _lenderPayAmount; set => SetField(ref _lenderPayAmount, value); }

        /// <summary>
        /// Disclosure-NY Lender Paid Fee [DISCLOSURE.X109]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"The lender will pay you a fee of\"}")]
        public bool? LenderPayIndicator { get => _lenderPayIndicator; set => SetField(ref _lenderPayIndicator, value); }

        /// <summary>
        /// Disclosure-NY Lender Paid Points Max [DISCLOSURE.X113]
        /// </summary>
        public decimal? LenderPayMaxPoint { get => _lenderPayMaxPoint; set => SetField(ref _lenderPayMaxPoint, value); }

        /// <summary>
        /// Disclosure-NY Lender Paid Fee % [DISCLOSURE.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LenderPayPercent { get => _lenderPayPercent; set => SetField(ref _lenderPayPercent, value); }

        /// <summary>
        /// Disclosure-NY Lender Paid Points [DISCLOSURE.X112]
        /// </summary>
        public decimal? LenderPayPoint { get => _lenderPayPoint; set => SetField(ref _lenderPayPoint, value); }

        /// <summary>
        /// Disclosure-NY Lender Fee Unknown [DISCLOSURE.X97]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"The fee the lender will pay you is not known. The maximum points paid including premium pricing shall not\"}")]
        public bool? LenderPayUnknownIndicator { get => _lenderPayUnknownIndicator; set => SetField(ref _lenderPayUnknownIndicator, value); }

        /// <summary>
        /// Disclosure-NY Status/Disposition [DISCLOSURE.X155]
        /// </summary>
        public string? LenderStatus { get => _lenderStatus; set => SetField(ref _lenderStatus, value); }

        /// <summary>
        /// Disclosure - AK - Lessor Name [DISCLOSURE.X976]
        /// </summary>
        public string? LessorName { get => _lessorName; set => SetField(ref _lessorName, value); }

        /// <summary>
        /// Disclosure-Loan Terms Fixed Through Date of Loan Closing [DISCLOSURE.X951]
        /// </summary>
        public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get => _loanTermsFixedThroughDateofLoanClosingIndicator; set => SetField(ref _loanTermsFixedThroughDateofLoanClosingIndicator, value); }

        /// <summary>
        /// Disclosure-FL Lock-in Fee [FLMTGCM.X13]
        /// </summary>
        public decimal? LockInFee { get => _lockInFee; set => SetField(ref _lockInFee, value); }

        /// <summary>
        /// Disclosure-FL Rate Index at Closing [FLMTGCM.X4]
        /// </summary>
        public string? MethodDescription { get => _methodDescription; set => SetField(ref _methodDescription, value); }

        /// <summary>
        /// Disclosure-FL Rate Index Subject to Change [FLMTGCM.X3]
        /// </summary>
        public StringEnumValue<MethodDetermine> MethodDetermine { get => _methodDetermine; set => SetField(ref _methodDetermine, value); }

        /// <summary>
        /// Disclosure-FL Mortgage loan origination agreement [FLGFE.X72]
        /// </summary>
        public bool? MortgageAgreementIndicator { get => _mortgageAgreementIndicator; set => SetField(ref _mortgageAgreementIndicator, value); }

        /// <summary>
        /// Disclosure-FL Broker License # [FLGFE.X57]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MtgBrokerLicense { get => _mtgBrokerLicense; set => SetField(ref _mtgBrokerLicense, value); }

        /// <summary>
        /// Disclosure-FL Licensee Name [DISCLOSURE.X171]
        /// </summary>
        public string? NameOfLicensee { get => _nameOfLicensee; set => SetField(ref _nameOfLicensee, value); }

        /// <summary>
        /// Disclosure-NY New Money Amount [DISCLOSURE.X993]
        /// </summary>
        public decimal? NewMoneyAmount { get => _newMoneyAmount; set => SetField(ref _newMoneyAmount, value); }

        /// <summary>
        /// Disclosure-NY Application Fee [DISCLOSURE.X122]
        /// </summary>
        public decimal? NewYorkApplicationFee { get => _newYorkApplicationFee; set => SetField(ref _newYorkApplicationFee, value); }

        /// <summary>
        /// Disclosure-NY Appraisal Fee [DISCLOSURE.X123]
        /// </summary>
        public decimal? NewYorkAppraisalFee { get => _newYorkAppraisalFee; set => SetField(ref _newYorkAppraisalFee, value); }

        /// <summary>
        /// Disclosure-NY Credit Fee [DISCLOSURE.X124]
        /// </summary>
        public decimal? NewYorkCreditReportFee { get => _newYorkCreditReportFee; set => SetField(ref _newYorkCreditReportFee, value); }

        /// <summary>
        /// StateDisclosure NewYorkFees
        /// </summary>
        [AllowNull]
        public IList<NewYorkFee> NewYorkFees { get => GetField(ref _newYorkFees); set => SetField(ref _newYorkFees, value); }

        /// <summary>
        /// StateDisclosure NewYorkPrimaryLenders
        /// </summary>
        [AllowNull]
        public IList<NewYorkPrimaryLender> NewYorkPrimaryLenders { get => GetField(ref _newYorkPrimaryLenders); set => SetField(ref _newYorkPrimaryLenders, value); }

        /// <summary>
        /// Disclosure-NY Processing Fee [DISCLOSURE.X127]
        /// </summary>
        public decimal? NewYorkProcessingFee { get => _newYorkProcessingFee; set => SetField(ref _newYorkProcessingFee, value); }

        /// <summary>
        /// Disclosure-TX Non-Refundable Amt [DISCLOSURE.X94]
        /// </summary>
        public decimal? NotRefundableAmount { get => _notRefundableAmount; set => SetField(ref _notRefundableAmount, value); }

        /// <summary>
        /// Disclosure-TX Compensated Retail Price [DISCLOSURE.X79]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"The retail price we offer you\"}")]
        public bool? OfferRetailPriceIndicator { get => _offerRetailPriceIndicator; set => SetField(ref _offerRetailPriceIndicator, value); }

        /// <summary>
        /// Disclosure - AK - Original Acquisition Cost [DISCLOSURE.X973]
        /// </summary>
        public decimal? OriginalAcquisitionCost { get => _originalAcquisitionCost; set => SetField(ref _originalAcquisitionCost, value); }

        /// <summary>
        /// Disclosure-NV Origination Fee Charged Amount [DISCLOSURE.X925]
        /// </summary>
        public decimal? OriginationFeeChargedAmount { get => _originationFeeChargedAmount; set => SetField(ref _originationFeeChargedAmount, value); }

        /// <summary>
        /// Disclosure-NV Origination Fee Charged Indicator [DISCLOSURE.X924]
        /// </summary>
        public bool? OriginationFeeChargedIndicator { get => _originationFeeChargedIndicator; set => SetField(ref _originationFeeChargedIndicator, value); }

        /// <summary>
        /// Disclosure-NV Origination Fee Decreases Interest Rate By [DISCLOSURE.X928]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationFeeDecreasesRate { get => _originationFeeDecreasesRate; set => SetField(ref _originationFeeDecreasesRate, value); }

        /// <summary>
        /// Disclosure-NV Origination Fee Increases Interest Rate By [DISCLOSURE.X929]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationFeeIncreasesRate { get => _originationFeeIncreasesRate; set => SetField(ref _originationFeeIncreasesRate, value); }

        /// <summary>
        /// Disclosure-NV Identify one of three possible impacts of Origination Fee on the Interest Rate [DISCLOSURE.X927]
        /// </summary>
        public StringEnumValue<InterestRateImpactedStatus> OriginationFeeInterestRateImpactedStatus { get => _originationFeeInterestRateImpactedStatus; set => SetField(ref _originationFeeInterestRateImpactedStatus, value); }

        /// <summary>
        /// Disclosure-NV Origination Fee Paid By [DISCLOSURE.X926]
        /// </summary>
        public StringEnumValue<StateDisclosureFeePaidBy> OriginationFeePaidBy { get => _originationFeePaidBy; set => SetField(ref _originationFeePaidBy, value); }

        /// <summary>
        /// Disclosure-NY Broker Fee Borr [DISCLOSURE.X158]
        /// </summary>
        public decimal? PaidByBorrower { get => _paidByBorrower; set => SetField(ref _paidByBorrower, value); }

        /// <summary>
        /// Disclosure-NY Broker Fee Lender Paid [DISCLOSURE.X157]
        /// </summary>
        public decimal? PaidByLender { get => _paidByLender; set => SetField(ref _paidByLender, value); }

        /// <summary>
        /// Disclosure-NY Other Fee 1 Amt [DISCLOSURE.X160]
        /// </summary>
        public decimal? PaidByOther1 { get => _paidByOther1; set => SetField(ref _paidByOther1, value); }

        /// <summary>
        /// Disclosure-NY Other Fee 2 Amt [DISCLOSURE.X162]
        /// </summary>
        public decimal? PaidByOther2 { get => _paidByOther2; set => SetField(ref _paidByOther2, value); }

        /// <summary>
        /// Disclosure-NY Other Fee 1 Descr [DISCLOSURE.X159]
        /// </summary>
        public string? PaidByOtherDescription1 { get => _paidByOtherDescription1; set => SetField(ref _paidByOtherDescription1, value); }

        /// <summary>
        /// Disclosure-NY Other Fee 2 Descr [DISCLOSURE.X161]
        /// </summary>
        public string? PaidByOtherDescription2 { get => _paidByOtherDescription2; set => SetField(ref _paidByOtherDescription2, value); }

        /// <summary>
        /// Disclosure-NY Previous Mortgage Amount 1 [DISCLOSURE.X994]
        /// </summary>
        public decimal? PreviousMortgageAmountOne { get => _previousMortgageAmountOne; set => SetField(ref _previousMortgageAmountOne, value); }

        /// <summary>
        /// Disclosure-NY Previous Mortgage Amount 2 [DISCLOSURE.X995]
        /// </summary>
        public decimal? PreviousMortgageAmountTwo { get => _previousMortgageAmountTwo; set => SetField(ref _previousMortgageAmountTwo, value); }

        /// <summary>
        /// Disclosure - AK - Print Certification O fCosts [DISCLOSURE.X962]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public bool? PrintCertificationOfCosts { get => _printCertificationOfCosts; set => SetField(ref _printCertificationOfCosts, value); }

        /// <summary>
        /// Disclosure - AK - Print Interest Rate Reduction Rider [DISCLOSURE.X961]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public bool? PrintInterestRateReductionRider { get => _printInterestRateReductionRider; set => SetField(ref _printInterestRateReductionRider, value); }

        /// <summary>
        /// Disclosure-MD Print MD Delivery of Net Proceeds Authorization Disclosure [DISCLOSURE.X911]
        /// </summary>
        public bool? PrintMDDeliveryIndicator { get => _printMDDeliveryIndicator; set => SetField(ref _printMDDeliveryIndicator, value); }

        /// <summary>
        /// Disclosure-FL GFE Provided By [FLGFE.X67]
        /// </summary>
        public StringEnumValue<ProvidedBy> ProvidedBy { get => _providedBy; set => SetField(ref _providedBy, value); }

        /// <summary>
        /// Disclosure-NY Ques/Comments To [DISCLOSURE.X128]
        /// </summary>
        public string? QuestionContact { get => _questionContact; set => SetField(ref _questionContact, value); }

        /// <summary>
        /// Disclosure-NY Ques/Comments Phone [DISCLOSURE.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? QuestionContactPhone { get => _questionContactPhone; set => SetField(ref _questionContactPhone, value); }

        /// <summary>
        /// Disclosure-NY Ques/Comments Toll Free [DISCLOSURE.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? QuestionContactTollFree { get => _questionContactTollFree; set => SetField(ref _questionContactTollFree, value); }

        /// <summary>
        /// Disclosure-NY-Rate Lock honored only if loan closes at least 3 business days prior to the Lock Expiration Date [DISCLOSURE.X950]
        /// </summary>
        public bool? RateLockHonoredIndicator { get => _rateLockHonoredIndicator; set => SetField(ref _rateLockHonoredIndicator, value); }

        /// <summary>
        /// Disclosure-NY Fee Recipient [DISCLOSURE.X149]
        /// </summary>
        public string? ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// Disclosure-FL Refi Fee [FLMTGCM.X16]
        /// </summary>
        public decimal? RefinancingFee { get => _refinancingFee; set => SetField(ref _refinancingFee, value); }

        /// <summary>
        /// Disclosure-FL Deposit Refundable By [FLGFE.X56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? RefundableBy { get => _refundableBy; set => SetField(ref _refundableBy, value); }

        /// <summary>
        /// Disclosure-FL Commitment Fee Refundable If [FLMTGCM.X8]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Refundable If\"}")]
        public bool? RefundableIndicator { get => _refundableIndicator; set => SetField(ref _refundableIndicator, value); }

        /// <summary>
        /// Disclosure-FL Appl Fee Refund/Non Refund [DISCLOSURE.X68]
        /// </summary>
        public StringEnumValue<RefundableType> RefundableType { get => _refundableType; set => SetField(ref _refundableType, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 1 [DISCLOSURE.X125]
        /// </summary>
        public string? RefundCondition1 { get => _refundCondition1; set => SetField(ref _refundCondition1, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 2 [DISCLOSURE.X126]
        /// </summary>
        public string? RefundCondition2 { get => _refundCondition2; set => SetField(ref _refundCondition2, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 3 [DISCLOSURE.X164]
        /// </summary>
        public string? RefundCondition3 { get => _refundCondition3; set => SetField(ref _refundCondition3, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 4 [DISCLOSURE.X165]
        /// </summary>
        public string? RefundCondition4 { get => _refundCondition4; set => SetField(ref _refundCondition4, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 5 [DISCLOSURE.X166]
        /// </summary>
        public string? RefundCondition5 { get => _refundCondition5; set => SetField(ref _refundCondition5, value); }

        /// <summary>
        /// Disclosure-NY Appl Fee Refund If 6 [DISCLOSURE.X167]
        /// </summary>
        public string? RefundCondition6 { get => _refundCondition6; set => SetField(ref _refundCondition6, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Address [DISCLOSURE.X1064]
        /// </summary>
        public string? RegulatorAddress { get => _regulatorAddress; set => SetField(ref _regulatorAddress, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator City [DISCLOSURE.X1065]
        /// </summary>
        public string? RegulatorCity { get => _regulatorCity; set => SetField(ref _regulatorCity, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing Address [DISCLOSURE.X1070]
        /// </summary>
        public string? RegulatorMailingAddress { get => _regulatorMailingAddress; set => SetField(ref _regulatorMailingAddress, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing City [DISCLOSURE.X1071]
        /// </summary>
        public string? RegulatorMailingCity { get => _regulatorMailingCity; set => SetField(ref _regulatorMailingCity, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing State [DISCLOSURE.X1072]
        /// </summary>
        public StringEnumValue<State> RegulatorMailingState { get => _regulatorMailingState; set => SetField(ref _regulatorMailingState, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Mailing Zip Code [DISCLOSURE.X1073]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? RegulatorMailingZipCode { get => _regulatorMailingZipCode; set => SetField(ref _regulatorMailingZipCode, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Phone [DISCLOSURE.X1068]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? RegulatorPhone { get => _regulatorPhone; set => SetField(ref _regulatorPhone, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator State [DISCLOSURE.X1066]
        /// </summary>
        public StringEnumValue<State> RegulatorState { get => _regulatorState; set => SetField(ref _regulatorState, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Toll-free Phone [DISCLOSURE.X1069]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? RegulatorTollFreePhone { get => _regulatorTollFreePhone; set => SetField(ref _regulatorTollFreePhone, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure - Regulatory Agency - Web Address [DISCLOSURE.X1156]
        /// </summary>
        public string? RegulatorWebAddress { get => _regulatorWebAddress; set => SetField(ref _regulatorWebAddress, value); }

        /// <summary>
        /// South Carolina State Specific Disclosure -  Regulator Zip Code [DISCLOSURE.X1067]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? RegulatorZipCode { get => _regulatorZipCode; set => SetField(ref _regulatorZipCode, value); }

        /// <summary>
        /// Disclosure-MD The schedule of charges is Estimated, subject to change or Final, not subject to change [DISCLOSURE.X912]
        /// </summary>
        public StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator> ScheduleOfChargesEstimatedFinalIndicator { get => _scheduleOfChargesEstimatedFinalIndicator; set => SetField(ref _scheduleOfChargesEstimatedFinalIndicator, value); }

        /// <summary>
        /// Disclosure - SC - Regulatory Agency [DISCLOSURE.X953]
        /// </summary>
        public StringEnumValue<ScRegulatoryAgencyType> ScRegulatoryAgencyType { get => _scRegulatoryAgencyType; set => SetField(ref _scRegulatoryAgencyType, value); }

        /// <summary>
        /// Disclosure-NY Lender Division of Fees Is Selected [DISCLOSURE.X181]
        /// </summary>
        public bool? SelectDivisionFeesIndicator { get => _selectDivisionFeesIndicator; set => SetField(ref _selectDivisionFeesIndicator, value); }

        /// <summary>
        /// Disclosure-NY Lender Primary Lender Is Selected [DISCLOSURE.X179]
        /// </summary>
        public bool? SelectPrimaryLenderIndicator { get => _selectPrimaryLenderIndicator; set => SetField(ref _selectPrimaryLenderIndicator, value); }

        /// <summary>
        /// Disclosure-NY Lender Private Lender Is Selected [DISCLOSURE.X180]
        /// </summary>
        public bool? SelectPrivateLenderIndicator { get => _selectPrivateLenderIndicator; set => SetField(ref _selectPrivateLenderIndicator, value); }

        /// <summary>
        /// Disclosure-NV Servicing Fee Charged Amount [DISCLOSURE.X940]
        /// </summary>
        public decimal? ServicingFeeChargedAmount { get => _servicingFeeChargedAmount; set => SetField(ref _servicingFeeChargedAmount, value); }

        /// <summary>
        /// Disclosure-NV Servicing Fee Indicator [DISCLOSURE.X939]
        /// </summary>
        public bool? ServicingFeeChargedIndicator { get => _servicingFeeChargedIndicator; set => SetField(ref _servicingFeeChargedIndicator, value); }

        /// <summary>
        /// Disclosure-NV Servicing Fee Paid By [DISCLOSURE.X941]
        /// </summary>
        public StringEnumValue<StateDisclosureFeePaidBy> ServicingFeePaidBy { get => _servicingFeePaidBy; set => SetField(ref _servicingFeePaidBy, value); }

        /// <summary>
        /// Disclosure-NV Servicing Fee Paid Frequency [DISCLOSURE.X942]
        /// </summary>
        public StringEnumValue<ServicingFeePaidFrequence> ServicingFeePaidFrequence { get => _servicingFeePaidFrequence; set => SetField(ref _servicingFeePaidFrequence, value); }

        /// <summary>
        /// Disclosure-FL GFE of settlemnt chrgs dated/signed by borrower [FLGFE.X76]
        /// </summary>
        public bool? SignedByBorrowerIndicator { get => _signedByBorrowerIndicator; set => SetField(ref _signedByBorrowerIndicator, value); }

        /// <summary>
        /// Disclosure-FL Specific ARM rates, terms, and conditions [FLGFE.X74]
        /// </summary>
        public bool? SpecificARMIndicator { get => _specificARMIndicator; set => SetField(ref _specificARMIndicator, value); }

        /// <summary>
        /// Disclosure-TX Will Submit to Lender [DISCLOSURE.X74]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"We will submit your loan application to a participating lender\"}")]
        public bool? SubmitToLenderIndicator { get => _submitToLenderIndicator; set => SetField(ref _submitToLenderIndicator, value); }

        /// <summary>
        /// Disclosure - AK - Assessments [DISCLOSURE.X968]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationAssessments { get => _taxExemptAcquisitionCostCertificationAssessments; set => SetField(ref _taxExemptAcquisitionCostCertificationAssessments, value); }

        /// <summary>
        /// Disclosure - AK - Other [DISCLOSURE.X970]
        /// </summary>
        public string? TaxExemptAcquisitionCostCertificationOther { get => _taxExemptAcquisitionCostCertificationOther; set => SetField(ref _taxExemptAcquisitionCostCertificationOther, value); }

        /// <summary>
        /// Disclosure - AK - Other Amount [DISCLOSURE.X971]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get => _taxExemptAcquisitionCostCertificationOtherAmount; set => SetField(ref _taxExemptAcquisitionCostCertificationOtherAmount, value); }

        /// <summary>
        /// Disclosure - AK - Owners Title Insurance [DISCLOSURE.X965]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get => _taxExemptAcquisitionCostCertificationOwnersTitleInsurance; set => SetField(ref _taxExemptAcquisitionCostCertificationOwnersTitleInsurance, value); }

        /// <summary>
        /// Disclosure - AK - Real Estate Commission [DISCLOSURE.X967]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get => _taxExemptAcquisitionCostCertificationRealEstateCommission; set => SetField(ref _taxExemptAcquisitionCostCertificationRealEstateCommission, value); }

        /// <summary>
        /// Disclosure - AK - Repairs/Improvements [DISCLOSURE.X969]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get => _taxExemptAcquisitionCostCertificationRepairsImprovements; set => SetField(ref _taxExemptAcquisitionCostCertificationRepairsImprovements, value); }

        /// <summary>
        /// Disclosure - AK - Survey [DISCLOSURE.X966]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationSurvey { get => _taxExemptAcquisitionCostCertificationSurvey; set => SetField(ref _taxExemptAcquisitionCostCertificationSurvey, value); }

        /// <summary>
        /// Disclosure - AK - Total Adjustments [DISCLOSURE.X972]
        /// </summary>
        public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get => _taxExemptAcquisitionCostCertificationTotalAdjustments; set => SetField(ref _taxExemptAcquisitionCostCertificationTotalAdjustments, value); }

        /// <summary>
        /// Disclosure-FL Terms Are/Are Not Subject to Change [FLMTGCM.X2]
        /// </summary>
        public StringEnumValue<TermsChange> TermsChange { get => _termsChange; set => SetField(ref _termsChange, value); }

        /// <summary>
        /// Disclosure-TX Application Fee [DISCLOSURE.X82]
        /// </summary>
        public decimal? TexasApplicationFee { get => _texasApplicationFee; set => SetField(ref _texasApplicationFee, value); }

        /// <summary>
        /// Disclosure-TX Appraisal Fee [DISCLOSURE.X85]
        /// </summary>
        public decimal? TexasAppraisalFee { get => _texasAppraisalFee; set => SetField(ref _texasAppraisalFee, value); }

        /// <summary>
        /// Disclosure-TX Credit Rpt Fee [DISCLOSURE.X87]
        /// </summary>
        public decimal? TexasCreditReportFee { get => _texasCreditReportFee; set => SetField(ref _texasCreditReportFee, value); }

        /// <summary>
        /// Disclosure-TX Other Fee 1 [DISCLOSURE.X91]
        /// </summary>
        public decimal? TexasOtherFee1 { get => _texasOtherFee1; set => SetField(ref _texasOtherFee1, value); }

        /// <summary>
        /// Disclosure-TX Other Fee 2 [DISCLOSURE.X93]
        /// </summary>
        public decimal? TexasOtherFee2 { get => _texasOtherFee2; set => SetField(ref _texasOtherFee2, value); }

        /// <summary>
        /// Disclosure-TX Other Fee 1 Descr [DISCLOSURE.X90]
        /// </summary>
        public string? TexasOtherFeeContact1 { get => _texasOtherFeeContact1; set => SetField(ref _texasOtherFeeContact1, value); }

        /// <summary>
        /// Disclosure-TX Other Fee 2 Descr [DISCLOSURE.X92]
        /// </summary>
        public string? TexasOtherFeeContact2 { get => _texasOtherFeeContact2; set => SetField(ref _texasOtherFeeContact2, value); }

        /// <summary>
        /// Disclosure-TX Processing Fee [DISCLOSURE.X83]
        /// </summary>
        public decimal? TexasProcessingFee { get => _texasProcessingFee; set => SetField(ref _texasProcessingFee, value); }

        /// <summary>
        /// Disclosure-FL Third Party Fee Amt [FLGFE.X54]
        /// </summary>
        public decimal? ThirdPartyFee { get => _thirdPartyFee; set => SetField(ref _thirdPartyFee, value); }

        /// <summary>
        /// Disclosure-NY Total Broker Fee [DISCLOSURE.X163]
        /// </summary>
        public decimal? TotalFee { get => _totalFee; set => SetField(ref _totalFee, value); }

        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Charged Amount [DISCLOSURE.X937]
        /// </summary>
        public decimal? TransferFeeChargedAmount { get => _transferFeeChargedAmount; set => SetField(ref _transferFeeChargedAmount, value); }

        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Indicator [DISCLOSURE.X936]
        /// </summary>
        public bool? TransferFeeChargedIndicator { get => _transferFeeChargedIndicator; set => SetField(ref _transferFeeChargedIndicator, value); }

        /// <summary>
        /// Disclosure-NV Service Rights Transfer Fee Paid By [DISCLOSURE.X938]
        /// </summary>
        public StringEnumValue<StateDisclosureFeePaidBy> TransferFeePaidBy { get => _transferFeePaidBy; set => SetField(ref _transferFeePaidBy, value); }

        /// <summary>
        /// Disclosure - TX - Texas Veterans Land Board [DISCLOSURE.X955]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public bool? TxVeteransLandBoardIndicator { get => _txVeteransLandBoardIndicator; set => SetField(ref _txVeteransLandBoardIndicator, value); }

        /// <summary>
        /// Disclosure-NY Type of Property [DISCLOSURE.X996]
        /// </summary>
        public StringEnumValue<TypeOfProperty> TypeOfProperty { get => _typeOfProperty; set => SetField(ref _typeOfProperty, value); }

        /// <summary>
        /// Disclosure-TX Underwriting Fee Descr [DISCLOSURE.X88]
        /// </summary>
        public string? UnderwritingContact { get => _underwritingContact; set => SetField(ref _underwritingContact, value); }

        /// <summary>
        /// Disclosure-TX Underwriting Fee [DISCLOSURE.X89]
        /// </summary>
        public decimal? UnderwritingFee { get => _underwritingFee; set => SetField(ref _underwritingFee, value); }

        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Charged Amount [DISCLOSURE.X931]
        /// </summary>
        public decimal? YSPChargedAmount { get => _ySPChargedAmount; set => SetField(ref _ySPChargedAmount, value); }

        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Indicator [DISCLOSURE.X930]
        /// </summary>
        public bool? YSPChargedIndicator { get => _ySPChargedIndicator; set => SetField(ref _ySPChargedIndicator, value); }

        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Decreases Interest Rate By [DISCLOSURE.X934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? YSPDecreasesRate { get => _ySPDecreasesRate; set => SetField(ref _ySPDecreasesRate, value); }

        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP) Increases Interest Rate By [DISCLOSURE.X935]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? YSPIncreasesRate { get => _ySPIncreasesRate; set => SetField(ref _ySPIncreasesRate, value); }

        /// <summary>
        /// Disclosure-NV Identify one of three possible impacts of Yield Spread Premium (YSP) on the Interest Rate [DISCLOSURE.X933]
        /// </summary>
        public StringEnumValue<InterestRateImpactedStatus> YSPInterestRateImpactedStatus { get => _ySPInterestRateImpactedStatus; set => SetField(ref _ySPInterestRateImpactedStatus, value); }

        /// <summary>
        /// Disclosure-NV Yield Spread Premium (YSP)  Paid By [DISCLOSURE.X932]
        /// </summary>
        public StringEnumValue<StateDisclosureFeePaidBy> YSPPaidBy { get => _ySPPaidBy; set => SetField(ref _ySPPaidBy, value); }
    }
}