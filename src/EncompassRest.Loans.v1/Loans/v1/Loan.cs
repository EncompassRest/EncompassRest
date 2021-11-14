using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Loan
    /// </summary>
    public sealed partial class Loan : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?>? _additionalLoanDoesNotApply;
        private AdditionalRequests? _additionalRequests;
        private DirtyValue<DateTime?>? _adverseActionDate;
        private DirtyList<AffiliatedBusinessArrangement>? _affiliatedBusinessArrangements;
        private DirtyValue<bool?>? _affordableLoan;
        private DirtyValue<string?>? _agencyCaseIdentifier;
        private Aiq? _aiq;
        private DirtyValue<string?>? _alertChangeCircumstanceApplyLECD;
        private DirtyList<AlertChangeCircumstance>? _alertChangeCircumstances;
        private DirtyValue<bool?>? _allowPrint2003Application;
        private DirtyValue<decimal?>? _alterationsImprovementsOrRepairsAmount;
        private DirtyList<Application>? _applications;
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>>? _applicationTakenMethodType;
        private DirtyValue<DateTime?>? _aprDisclosureDate;
        private DirtyValue<string?>? _armTypeDescription;
        private ATRQMCommon? _aTRQMCommon;
        private DirtyValue<int?>? _averageRepresentativeCreditScore;
        private DirtyValue<decimal?>? _baseLoanAmount;
        private DirtyValue<bool?>? _belowMarketSubordinateFinancingIndicator;
        private DirtyValue<string?>? _billingCategory;
        private DirtyValue<decimal?>? _biweeklyPaymentAmount;
        private DirtyValue<int?>? _bLTV;
        private DirtyValue<bool?>? _borrCommunityPropertyStateResidentIndicator;
        private DirtyValue<decimal?>? _borrEstimatedClosingCostsAmount;
        private DirtyValue<bool?>? _borrowerCoBorrowerMarriedIndicator;
        private DirtyValue<string?>? _borrowerCount;
        private DirtyValue<string?>? _borrowerFullName;
        private DirtyValue<decimal?>? _borrowerPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _borrowerPaidDiscountPointsAmount;
        private DirtyValue<decimal?>? _borrowerPaidFHAVAClosingCostsAmount;
        private DirtyValue<int?>? _borrowerPairCount;
        private DirtyValue<decimal?>? _borrowerRequestedLoanAmount;
        private DirtyValue<decimal?>? _borrowerRequestedLoanAmountURLA;
        private DirtyValue<decimal?>? _brokerPaidClosingCostsAmount;
        private DirtyValue<bool?>? _buydownIndicator;
        private DirtyValue<decimal?>? _buydownMonthlyPaymentAmount;
        private DirtyValue<decimal?>? _buydownRatePercent;
        private DirtyValue<decimal?>? _calculatedDrawAmount;
        private DirtyValue<decimal?>? _calculatedLoanAmount;
        private DirtyValue<decimal?>? _cashFromToBorrowerAmount;
        private DirtyValue<StringEnumValue<Channel>>? _channel;
        private DirtyValue<decimal?>? _closedEndPrimaryMortgageLoanAmount;
        private DirtyValue<decimal?>? _closedEndSubordinateMortgageLoanAmount;
        private DirtyValue<DateTime?>? _closingBillingDate;
        private ClosingCost? _closingCost;
        private DirtyValue<string?>? _closingCostProgram;
        private DirtyValue<decimal?>? _closingCostsAndPrepaidsFromOtherLienAmount;
        private DirtyValue<decimal?>? _closingCostsPaidByOthersAmount;
        private DirtyValue<string?>? _closingDocsStackingOrder;
        private ClosingDocument? _closingDocument;
        private DirtyValue<int?>? _collateralManagerScore;
        private CollateralTracking? _collateralTracking;
        private DirtyValue<decimal?>? _combinedLtv;
        private DirtyValue<string?>? _commitmentNumber;
        private CommitmentTerms? _commitmentTerms;
        private DirtyValue<bool?>? _communityPropertyStateResidentIndicator;
        private DirtyValue<bool?>? _complianceReviewType;
        private DirtyList<ComplianceTestLog>? _complianceTestLogs;
        private DirtyValue<bool?>? _condominiumIndicator;
        private DirtyValue<StringEnumValue<ConformingJumbo>>? _conformingJumbo;
        private DirtyValue<bool?>? _constructionLoanIndicator;
        private ConstructionManagement? _constructionManagement;
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingType>>? _constructionToPermanentClosingType;
        private DirtyValue<string?>? _consumerConnectSiteID;
        private DirtyList<Contact>? _contacts;
        private DirtyValue<bool?>? _contactUpdatedIndicator;
        private DirtyValue<decimal?>? _contractSellerCreditAmount;
        private DirtyList<ConversationLog>? _conversationLogs;
        private DirtyValue<bool?>? _conversionOfContractForDeedIndicator;
        private DirtyValue<bool?>? _cooperativeIndicator;
        private DirtyValue<bool?>? _copyBrokerToLenderIndicator;
        private DirtyValue<StringEnumValue<YOrN>>? _copyLoanNumLenderCaseNum;
        private Correspondent? _correspondent;
        private DirtyValue<string?>? _counselingBorrowerFullName;
        private DirtyValue<DateTime?>? _counselingCompletedDate;
        private DirtyValue<string?>? _creditScoreToUse;
        private DirtyList<CrmLog>? _crmLogs;
        private DirtyValue<int?>? _currentApplicationIndex;
        private DirtyValue<bool?>? _currentApplicationIsPrimary;
        private DirtyValue<StringEnumValue<CurrentFirstMortgageHolderType>>? _currentFirstMortgageHolderType;
        private DirtyList<CustomField>? _customFields;
        private DirtyValue<CustomModelFields?>? _customModelFields;
        private DirtyList<DataTracLog>? _dataTracLogs;
        private DirtyValue<bool?>? _dBIndicator;
        private DirtyValue<bool?>? _deductOverwireAmountIndicator;
        private DirtyValue<bool?>? _disableESignConsentAlert;
        private DirtyValue<bool?>? _disableKeyPricingAlert;
        private DisclosureNotices? _disclosureNotices;
        private DirtyList<DisclosureTracking2015Log>? _disclosureTracking2015Logs;
        private DirtyList<DisclosureTrackingLog>? _disclosureTrackingLogs;
        private DirtyValue<decimal?>? _discountPoint;
        private DirtyValue<StringEnumValue<DocEngine>>? _docEngine;
        private DirtyList<DocumentLog>? _documentLogs;
        private DirtyList<DocumentOrderLog>? _documentOrderLogs;
        private DirtyList<DocumentTrackingLog>? _documentTrackingLogs;
        private DirtyValue<string?>? _doNotCheckEmail;
        private DirtyValue<bool?>? _doNotPrintCompensationFees;
        private DirtyList<DownloadLog>? _downloadLogs;
        private DownPayment? _downPayment;
        private DirtyValue<decimal?>? _downPaymentPercent;
        private DirtyValue<int?>? _eDeliveryVersion;
        private DirtyList<EdmLog>? _edmLogs;
        private DirtyValue<ElliUCDDetail?>? _elliUCDFields;
        private DirtyList<EmailTriggerLog>? _emailTriggerLogs;
        private EmDocument? _emDocument;
        private EmDocumentInvestor? _emDocumentInvestor;
        private EmDocumentLender? _emDocumentLender;
        private DirtyValue<string?>? _emXmlVersionId;
        private DirtyValue<string?>? _encompassId;
        private DirtyValue<string?>? _encompassVersion;
        private DirtyValue<decimal?>? _energyImprovementAmount;
        private DirtyValue<bool?>? _enforceCountyLoanLimit;
        private DirtyList<EnhancedConditionLog>? _enhancedConditionLogs;
        private DirtyValue<bool?>? _enoteAuthoritativeCopy;
        private DirtyValue<string?>? _enoteControllerOrgId;
        private DirtyValue<string?>? _enoteControllerOrgName;
        private DirtyValue<string?>? _enoteDelagateeForTransferOrgId;
        private DirtyValue<string?>? _enoteDelagateeForTransferOrgName;
        private DirtyValue<string?>? _enoteLenderName;
        private DirtyValue<string?>? _enoteLocationOrgId;
        private DirtyValue<string?>? _enoteLocationOrgName;
        private DirtyValue<string?>? _enoteMasterServiceOrgId;
        private DirtyValue<string?>? _enoteMasterServiceOrgName;
        private DirtyValue<string?>? _enoteMersMinNumber;
        private DirtyValue<DateTime?>? _enoteRegisteredDateTime;
        private DirtyValue<string?>? _enoteSecuredPartyDelagateeOrgId;
        private DirtyValue<string?>? _enoteSecuredPartyDelagateeOrgName;
        private DirtyValue<string?>? _enoteSecuredPartyOrgId;
        private DirtyValue<string?>? _enoteSecuredPartyOrgName;
        private DirtyValue<string?>? _enoteSubservicerOrgId;
        private DirtyValue<string?>? _enoteSubservicerOrgName;
        private DirtyValue<DateTime?>? _enoteTransferEffectiveDate;
        private DirtyValue<StringEnumValue<EnoteTransferStatus>>? _enoteTransferStatus;
        private DirtyValue<decimal?>? _estimatedClosingCostsAmount;
        private DirtyValue<decimal?>? _estimatedConstructionInterest;
        private DirtyValue<decimal?>? _estimatedPrepaidItemsAmount;
        private DirtyValue<decimal?>? _existingLiensAndDrawUsed;
        private DirtyValue<decimal?>? _existingLiensUsed;
        private DirtyValue<int?>? _expectedBorrowerCount;
        private DirtyValue<StringEnumValue<ExportLoanNumber>>? _exportLoanNumber;
        private DirtyList<ExportLog>? _exportLogs;
        private FannieMae? _fannieMae;
        private DirtyList<FannieServiceDuLog>? _fannieServiceDuLogs;
        private DirtyList<FannieServiceEcLog>? _fannieServiceEcLogs;
        private DirtyList<Fee>? _fees;
        private DirtyValue<decimal?>? _fhaMiPremiumRefundAmount;
        private FhaVaLoan? _fhaVaLoan;
        private DirtyValue<string?>? _fHAVALoanOriginatorIdentifier;
        private DirtyList<FieldLockData>? _fieldLockData;
        private DirtyValue<decimal?>? _firstAdjustmentMinimum;
        private DirtyValue<decimal?>? _firstSubordinateLienAmount;
        private DirtyValue<bool?>? _firstTimeHomebuyersIndicator;
        private DirtyValue<StringEnumValue<FnmCommunityLendingProductName>>? _fnmCommunityLendingProductName;
        private DirtyValue<bool?>? _fnmCommunitySecondsIndicator;
        private DirtyValue<bool?>? _fnmNeighborsMortgageEligibilityIndicator;
        private DirtyList<Form>? _forms;
        private DirtyValue<int?>? _fraudScore;
        private FreddieMac? _freddieMac;
        private DirtyList<FreddieServiceLpaLog>? _freddieServiceLpaLogs;
        private DirtyList<FreddieServiceLqaLog>? _freddieServiceLqaLogs;
        private Funding? _funding;
        private DirtyValue<string?>? _fundingDeductionList;
        private DirtyValue<string?>? _fundingFeeList;
        private DirtyList<FundingFee>? _fundingFees;
        private Gfe? _gfe;
        private DirtyList<GoodFaithFeeVarianceCureLog>? _goodFaithFeeVarianceCureLogs;
        private DirtyValue<string?>? _governmentLoanLenderIdentifier;
        private DirtyValue<string?>? _governmentLoanSponsorIdentifier;
        private DirtyValue<decimal?>? _governmentMortgageCreditCertificateAmount;
        private DirtyValue<StringEnumValue<GovernmentRefinanceType>>? _governmentRefinanceType;
        private DirtyValue<StringEnumValue<GovernmentRefinanceTypeOtherDescription>>? _governmentRefinanceTypeOtherDescription;
        private DirtyValue<string?>? _hasAbusinessRelationshipWith;
        private DirtyValue<decimal?>? _hcltvHtltv;
        private DirtyValue<decimal?>? _helocTeaserRate;
        private Hmda? _hmda;
        private DirtyList<HomeCounselingProvider>? _homeCounselingProviders;
        private DirtyValue<string?>? _homeCounselingProvidersDistance;
        private DirtyValue<string?>? _homeCounselingProvidersLanguageNames;
        private DirtyValue<string?>? _homeCounselingProvidersServiceNames;
        private DirtyValue<int?>? _householdSizeCount;
        private DirtyValue<string?>? _housingCounselingAgency;
        private DirtyValue<string?>? _housingCounselingAgencyFullName;
        private DirtyList<HtmlEmailLog>? _htmlEmailLogs;
        private Hud1Es? _hud1Es;
        private DirtyValue<decimal?>? _hudIncomeLimitAdjustmentFactor;
        private DirtyValue<decimal?>? _hudLendingIncomeLimitAmount;
        private HudLoanData? _hudLoanData;
        private DirtyValue<decimal?>? _hudMedianIncomeAmount;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _includeUSDAFeeInClosing;
        private DirtyValue<decimal?>? _initialInterestRate;
        private DirtyValue<string?>? _initialInterestRateUI;
        private DirtyValue<string?>? _insuranceAuthorizationIndicator;
        private InterimServicing? _interimServicing;
        private DirtyValue<DateTime?>? _interviewerApplicationSignedDate;
        private DirtyValue<string?>? _interviewerEmail;
        private DirtyValue<string?>? _interviewerLicenseIdentifier;
        private DirtyValue<string?>? _interviewerPhoneNumber;
        private DirtyValue<string?>? _interviewersCompanyStateLicense;
        private DirtyValue<string?>? _interviewersId;
        private DirtyValue<string?>? _inverviewerName;
        private DirtyList<InvestorDeliveryLog>? _investorDeliveryLogs;
        private DirtyValue<bool?>? _isCreditorProhibitsBorrower;
        private DirtyValue<bool?>? _isEmployeeLoan;
        private DirtyValue<bool?>? _isLoanAmountRounding;
        private DirtyValue<bool?>? _isLSSecondaryFile;
        private DirtyValue<bool?>? _isRequiredInterestReserveCompoundInterest;
        private DirtyValue<decimal?>? _landIfAcquiredSeperatelyAmount;
        private DirtyValue<string?>? _leadSource;
        private DirtyValue<string?>? _leadSourceID;
        private DirtyValue<string?>? _lenderCaseIdentifier;
        private DirtyValue<StringEnumValue<LenderChannel>>? _lenderChannel;
        private DirtyValue<decimal?>? _lenderCreditsInFunding;
        private DirtyValue<string?>? _lenderInvestorCode;
        private DirtyValue<decimal?>? _lenderPaidClosignCostsDotAmount;
        private DirtyValue<decimal?>? _lenderPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _lesserAppraisedValueOrSalesPrice;
        private DirtyValue<decimal?>? _lifeInsuranceCoverageAmount;
        private DirtyValue<decimal?>? _lifeInsuranceEstimatedMonthlyAmount;
        private DirtyValue<decimal?>? _lifeInsuranceTotalProtectedMonthlyAmount;
        private DirtyValue<decimal?>? _linkedBorrowerRequestedLoanAmount;
        private DirtyValue<string?>? _linkId;
        private DirtyList<LoanActionLog>? _loanActionLogs;
        private DirtyValue<int?>? _loanAmortizationTermMonths;
        private DirtyValue<StringEnumValue<AmortizationType>>? _loanAmortizationType;
        private DirtyValue<string?>? _loanCreatedDate;
        private DirtyValue<DateTime?>? _loanCreatedDateUtc;
        private DirtyValue<bool?>? _loanFeaturesOtherIndicator;
        private DirtyValue<string?>? _loanIdNumber;
        private DirtyValue<bool?>? _loanImportStatusIndicator;
        private DirtyValue<StringEnumValue<LoanLinkSyncType>>? _loanLinkSyncType;
        private DirtyValue<string?>? _loanNumber;
        private LoanProductData? _loanProductData;
        private DirtyValue<string?>? _loanProgramName;
        private DirtyList<LoanProgram>? _loanPrograms;
        private DirtyValue<StringEnumValue<LoanPurposeOfRefinanceType>>? _loanPurposeOfRefinanceType;
        private DirtyValue<string?>? _loanSource;
        private LoanSubmission? _loanSubmission;
        private DirtyValue<decimal?>? _loanTotalProposedMonthlyMaintenanceAmount;
        private DirtyValue<decimal?>? _loanTotalProposedMonthlyUtilitiesAmount;
        private DirtyValue<string?>? _loanUnderwriterCHUMSIdentifier;
        private DirtyValue<string?>? _loanVALoanProcedureType;
        private DirtyValue<decimal?>? _loanVARateReductionInitialComputationTotalAmount;
        private DirtyValue<decimal?>? _loanVAResidualIncomeAmount;
        private DirtyValue<int?>? _loanVersionId;
        private DirtyList<LockCancellationLog>? _lockCancellationLogs;
        private DirtyList<LockConfirmLog>? _lockConfirmLogs;
        private DirtyList<LockDenialLog>? _lockDenialLogs;
        private DirtyList<LockRemovedLog>? _lockRemovedLogs;
        private DirtyList<LockRequestLog>? _lockRequestLogs;
        private DirtyList<LockVoidLog>? _lockVoidLogs;
        private ElliLOCompensation? _lOCompensation;
        private DirtyList<LogEntryLog>? _logEntryLogs;
        private DirtyValue<DateTime?>? _lotAcquiredDate;
        private DirtyValue<decimal?>? _ltv;
        private DirtyValue<decimal?>? _ltvPropertyValue;
        private DirtyValue<string?>? _masterCommitmentNumber;
        private DirtyValue<DateTime?>? _maturityDate;
        private DirtyValue<decimal?>? _maxBackRatio;
        private DirtyValue<decimal?>? _maxFrontRatio;
        private Mcaw? _mcaw;
        private DirtyValue<string?>? _mersNumber;
        private DirtyValue<DateTime?>? _mersNumberRegistrationDate;
        private DirtyValue<string?>? _mersOrgId;
        private DirtyValue<decimal?>? _miAndFundingFeeFinancedAmount;
        private DirtyValue<decimal?>? _miAndFundingFeeTotalAmount;
        private DirtyValue<DateTime?>? _milestoneApprovedDate;
        private DirtyValue<DateTime?>? _milestoneApprovedDueDate;
        private DirtyValue<DateTime?>? _milestoneCompletedDate;
        private DirtyValue<DateTime?>? _milestoneCompletedDueDate;
        private DirtyValue<DateTime?>? _milestoneCurrentDateUtc;
        private DirtyValue<StringEnumValue<MilestoneCurrentName>>? _milestoneCurrentName;
        private DirtyValue<DateTime?>? _milestoneDocSignedDate;
        private DirtyValue<DateTime?>? _milestoneDocSignedDueDate;
        private DirtyValue<int?>? _milestoneDuration;
        private DirtyValue<DateTime?>? _milestoneFileStartedDate;
        private DirtyList<MilestoneFreeRoleLog>? _milestoneFreeRoleLogs;
        private DirtyValue<DateTime?>? _milestoneFundedDate;
        private DirtyValue<DateTime?>? _milestoneFundedDueDate;
        private DirtyList<MilestoneHistoryLog>? _milestoneHistoryLogs;
        private DirtyList<MilestoneLog>? _milestoneLogs;
        private DirtyValue<DateTime?>? _milestoneProcessedDate;
        private DirtyValue<string?>? _milestoneStage;
        private DirtyValue<DateTime?>? _milestoneSubmittedDate;
        private DirtyValue<DateTime?>? _milestoneSubmittedDueDate;
        private DirtyList<MilestoneTaskLog>? _milestoneTaskLogs;
        private DirtyList<MilestoneTemplateLog>? _milestoneTemplateLogs;
        private DirtyValue<decimal?>? _mipBorrowerPaidInCashAmount;
        private DirtyValue<decimal?>? _mipPaidInCashAmount;
        private Miscellaneous? _miscellaneous;
        private DirtyList<MIServiceArchLog>? _mIServiceArchLogs;
        private DirtyList<MIServiceMgicLog>? _mIServiceMgicLogs;
        private DirtyList<MIServiceRadianLog>? _mIServiceRadianLogs;
        private DirtyValue<bool?>? _mom;
        private DirtyValue<decimal?>? _monthlyPIPaymentAmountForLE1andCD1;
        private DirtyValue<decimal?>? _mortgageInsurancePremiumFHARefundAmount;
        private DirtyValue<decimal?>? _mortgageInsurancePremiumUpfrontFactorPercent;
        private DirtyValue<StringEnumValue<LoanType>>? _mortgageType;
        private DirtyValue<string?>? _msaIdentifier;
        private DirtyValue<StringEnumValue<NativeAmericanLandsType>>? _nativeAmericanLandsType;
        private DirtyValue<StringEnumValue<NativeAmericanLandsTypeOtherDescription>>? _nativeAmericanLandsTypeOtherDescription;
        private DirtyValue<bool?>? _negativeAmortization;
        private NetTangibleBenefit? _netTangibleBenefit;
        private DirtyValue<decimal?>? _newFirstMortgageAmount;
        private DirtyValue<string?>? _newHELOCCreditorName;
        private DirtyValue<decimal?>? _newHELOCMonthlyPayment;
        private DirtyValue<string?>? _newMortgageCreditorName;
        private DirtyValue<decimal?>? _newMortgageMonthlyPayment;
        private DirtyValue<string?>? _newSubordinateCreditorName;
        private DirtyValue<decimal?>? _newSubordinateMonthlyPayment;
        private DirtyValue<string?>? _nmlsLoanOriginatorId;
        private DirtyValue<bool?>? _noClosingCostOption;
        private DirtyList<NonBorrowingOwner>? _nonBorrowingOwners;
        private DirtyList<NonVol>? _nonVols;
        private DirtyValue<bool?>? _notInProjectIndicator;
        private DirtyValue<bool?>? _notRequiredForPurchaseSaleOrRefinance;
        private DirtyValue<bool?>? _notRequiredForSettlementOfYourLoan;
        private DirtyValue<StringEnumValue<OccupancyType>>? _occupancyType;
        private DirtyValue<string?>? _openingDocsInvestorCode;
        private DirtyValue<StringEnumValue<DocsLoanProgramType>>? _openingDocsLoanProgramType;
        private DirtyValue<string?>? _openingDocsPlanDescription;
        private DirtyValue<string?>? _openingDocsPlanId;
        private DirtyValue<string?>? _openingDocsProgramCode;
        private DirtyValue<string?>? _openingDocsStackingOrder;
        private DirtyValue<string?>? _organizationCode;
        private DirtyValue<DateTime?>? _originationDate;
        private DirtyValue<string?>? _originatorAddressLineText;
        private DirtyValue<StringEnumValue<UnitType>>? _originatorAddressUnitDesignatorType;
        private DirtyValue<string?>? _originatorAddressUnitIdentifier;
        private DirtyValue<string?>? _originatorFirstName;
        private DirtyValue<string?>? _originatorLastName;
        private DirtyValue<string?>? _originatorMiddleName;
        private DirtyValue<string?>? _originatorSuffixName;
        private DirtyValue<string?>? _otherAmortizationTypeDescription;
        private DirtyValue<string?>? _otherMortgageTypeDescription;
        private DirtyValue<decimal?>? _otherPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _overwireAmount;
        private DirtyValue<DateTime?>? _ownershipCompletedDate;
        private DirtyValue<decimal?>? _paceLoanPayoffAmount;
        private DirtyValue<bool?>? _paymentDeferredFirstFiveYears;
        private DirtyValue<bool?>? _paymentScheduleCalcRequiredIndicator;
        private DirtyValue<string?>? _percentageOfOwnership;
        private DirtyValue<decimal?>? _percentageOwnershipInterest;
        private DirtyValue<bool?>? _pmiIndicator;
        private DirtyList<PostClosingConditionLog>? _postClosingConditionLogs;
        private DirtyList<PreliminaryConditionLog>? _preliminaryConditionLogs;
        private DirtyValue<bool?>? _prepaymentPenaltyTerm;
        private Prequalification? _prequalification;
        private DirtyValue<decimal?>? _principalAndInterestMonthlyPaymentAmount;
        private DirtyValue<StringEnumValue<Print2003Application>>? _print2003Application;
        private DirtyValue<bool?>? _printLenderPages;
        private DirtyList<PrintLog>? _printLogs;
        private DirtyValue<bool?>? _printULIAndLoanNoURLA;
        private DirtyValue<bool?>? _printULIonURLA;
        private PrivacyPolicy? _privacyPolicy;
        private DirtyValue<string?>? _productDescription;
        private ProfitManagement? _profitManagement;
        private DirtyValue<StringEnumValue<ProjectLegalStructureType>>? _projectLegalStructureType;
        private Property? _property;
        private DirtyValue<int?>? _propertyAppraisedValueAmount;
        private DirtyValue<bool?>? _propertyEnergyEfficientHomeIndicator;
        private DirtyValue<int?>? _propertyEstimatedValueAmount;
        private DirtyValue<bool?>? _propertyExistingCleanEnergyLienIndicator;
        private DirtyList<PropertyValuation>? _propertyValuations;
        private DirtyValue<string?>? _proposedDuesAmount;
        private DirtyValue<decimal?>? _proposedFirstMortgageAmount;
        private DirtyValue<decimal?>? _proposedGroundRentAmount;
        private DirtyValue<string?>? _proposedHazardInsuranceAmount;
        private DirtyValue<decimal?>? _proposedHousingExpenseTotal;
        private DirtyValue<string?>? _proposedMortgageInsuranceAmount;
        private DirtyValue<decimal?>? _proposedOtherAmount;
        private DirtyValue<decimal?>? _proposedOtherMortgagesAmount;
        private DirtyValue<string?>? _proposedRealEstateTaxesAmount;
        private DirtyValue<bool?>? _pUDIndicator;
        private DirtyList<PurchaseConditionLog>? _purchaseConditionLogs;
        private DirtyList<PurchaseCredit>? _purchaseCredits;
        private DirtyValue<decimal?>? _purchasePriceAmount;
        private RateLock? _rateLock;
        private DirtyValue<string?>? _referralAddress;
        private DirtyValue<string?>? _referralCity;
        private DirtyValue<decimal?>? _referralFeeAmount;
        private DirtyValue<string?>? _referralPostalCode;
        private DirtyValue<string?>? _referralSource;
        private DirtyValue<EntityReference?>? _referralSourceContact;
        private DirtyValue<StringEnumValue<State>>? _referralState;
        private DirtyValue<StringEnumValue<RefinanceCashOutDeterminationType>>? _refinanceCashOutDeterminationType;
        private DirtyValue<decimal?>? _refinanceIncludingDebtsToBePaidOffAmount;
        private DirtyList<RegistrationLog>? _registrationLogs;
        private RegulationZ? _regulationZ;
        private DirtyValue<StringEnumValue<RelationshipVestingType>>? _relationshipVestingType;
        private DirtyValue<string?>? _relationshipVestingTypeOtherDescription;
        private DirtyList<RemovedLogRecord>? _removedLogRecords;
        private DirtyValue<bool?>? _renovationLoanIndicator;
        private DirtyValue<decimal?>? _rentalEstimatedNetMonthlyRentAmount;
        private DirtyValue<bool?>? _rentalIncomeSectionIndicator;
        private DirtyValue<decimal?>? _repurchaseCostAmount;
        private DirtyValue<DateTime?>? _repurchaseDate;
        private DirtyValue<decimal?>? _requestedInterestRatePercent;
        private DirtyValue<string?>? _requestedInterestRatePercentUI;
        private DirtyValue<decimal?>? _salesConcessionAmount;
        private DirtyValue<decimal?>? _secondSubordinateAmount;
        private Section32? _section32;
        private DirtyValue<StringEnumValue<SectionOfActType>>? _sectionOfActType;
        private SelectedHomeCounselingProvider? _selectedHomeCounselingProvider;
        private DirtyList<SellConditionLog>? _sellConditionLogs;
        private DirtyValue<decimal?>? _sellerPaidClosingCostsAmount;
        private DirtyValue<DateTime?>? _serverDateTimeDDMApplied;
        private DirtyValue<string?>? _serviceProviderAdditionalInfo;
        private DirtyList<ServiceProviderContact>? _serviceProviderContacts;
        private DirtyValue<DateTime?>? _serviceProviderDateIssued;
        private ServicingDisclosure? _servicingDisclosure;
        private DirtyList<ServicingPrintLog>? _servicingPrintLogs;
        private DirtyValue<bool?>? _setForSettlementServicesOfAnAttorney;
        private DirtyValue<bool?>? _setForTheSettlementServicesListed;
        private DirtyValue<DateTime?>? _settlementAgentDisbursedFundsDate;
        private DirtyList<SettlementServiceCharge>? _settlementServiceCharges;
        private Shipping? _shipping;
        private DirtyValue<bool?>? _simpleRefinanceType;
        private DirtyValue<string?>? _sourceEntityUrn;
        private DirtyList<SpecialFeatureCode>? _specialFeatureCodes;
        private DirtyValue<decimal?>? _startingAdjPrice;
        private DirtyValue<decimal?>? _startingAdjRate;
        private StateDisclosure? _stateDisclosure;
        private StatementCreditDenial? _statementCreditDenial;
        private DirtyList<StatusOnlineLog>? _statusOnlineLogs;
        private DirtyValue<decimal?>? _subjectPropertyGrossRentalIncomeAmount;
        private DirtyValue<decimal?>? _subjectPropertyOccupancyPercent;
        private DirtyValue<decimal?>? _subordinateLienAmount;
        private DirtyValue<decimal?>? _supplementalPropertyInsuranceAmount;
        private DirtyValue<string?>? _systemIdGuid;
        private DirtyValue<decimal?>? _targetCLTV;
        private DirtyValue<decimal?>? _targetHCLTV;
        private DirtyList<TargetTradeLog>? _targetTradeLogs;
        private DirtyValue<string?>? _temporaryBuydown;
        private DirtyValue<bool?>? _temporaryOrInitialInterestRateBuydown;
        private DirtyValue<DateTime?>? _tilApplicationDate;
        private DirtyValue<string?>? _titleHolderFullName;
        private DirtyValue<string?>? _titleHolderName1;
        private DirtyValue<string?>? _titleHolderName2;
        private DirtyValue<string?>? _titleWillBeFullName;
        private DirtyValue<decimal?>? _tltv;
        private DirtyValue<decimal?>? _totalAdditionalMortgages;
        private DirtyValue<decimal?>? _totalClosingCostsAmount;
        private DirtyValue<decimal?>? _totalDeductionsAmount;
        private DirtyValue<decimal?>? _totalFeesCostAmount;
        private DirtyValue<decimal?>? _totalFeesCreditAmount;
        private DirtyValue<decimal?>? _totalNonborrowerPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _totalNonSubjectPropertyDebtsToBePaidOffAmount;
        private DirtyValue<decimal?>? _totalOfGiftsGrants;
        private DirtyValue<decimal?>? _totalOtherAssetToLoan;
        private DirtyValue<decimal?>? _totalPaidOutsideClosingAmount;
        private DirtyValue<decimal?>? _totalPaidToBrokerAmount;
        private DirtyValue<decimal?>? _totalSubordinateFinancingAmount;
        private DirtyValue<decimal?>? _totalWireTransferAmount;
        private TPO? _tPO;
        private DirtyValue<bool?>? _tPOMigrationDone;
        private TQL? _tQL;
        private TrustAccount? _trustAccount;
        private DirtyValue<StringEnumValue<TrustClassificationType>>? _trustClassificationType;
        private Tsum? _tsum;
        private DirtyValue<bool?>? _twelveMonthMortgageRentalHistoryIndicator;
        private DirtyValue<string?>? _uCDCaseFileID;
        private DirtyValue<string?>? _uCDFNMACasefileStatusType;
        private DirtyValue<string?>? _uCDFNMACasefileWarningIndicator;
        private DirtyValue<string?>? _uCDLoanCLSMatchStatusType;
        private DirtyValue<DateTime?>? _uCDOrigSubmissionDate;
        private DirtyValue<DateTime?>? _uCDSubmissionDate;
        private Uldd? _uldd;
        private UnderwriterSummary? _underwriterSummary;
        private DirtyList<UnderwritingConditionLog>? _underwritingConditionLogs;
        private DirtyValue<bool?>? _underwritingEscrowIndicator;
        private DirtyValue<decimal?>? _undiscountedRate;
        private DirtyValue<int?>? _unimprovedAppraisedValue;
        private DirtyValue<int?>? _unimprovedEstimatedValue;
        private DirtyValue<string?>? _uRLALoanIdentifier;
        private DirtyValue<decimal?>? _uRLATotalCreditsAmount;
        private DirtyValue<decimal?>? _uRLATotalMortgageLoansAmount;
        private DirtyValue<decimal?>? _uRLATotalOtherCreditsAmount;
        private DirtyValue<string?>? _urlPage4Comments;
        private Usda? _usda;
        private DirtyValue<StringEnumValue<UsdaGovernmentLoanType>>? _usdaGovernmentLoanType;
        private DirtyValue<bool?>? _use2018DiIndicator;
        private DirtyValue<bool?>? _useEnhancedConditionIndicator;
        private DirtyValue<StringEnumValue<UseNew2015FormsIndicator>>? _useNew2015FormsIndicator;
        private DirtyValue<bool?>? _useNewHudIndicator;
        private DirtyValue<decimal?>? _vAEntitlementAmount;
        private VaLoanData? _vaLoanData;
        private DirtyValue<decimal?>? _valuationUsed;
        private DirtyList<VerificationLog>? _verificationLogs;
        private DirtyDictionary<string, string?>? _virtualFields;
        private DirtyValue<string?>? _websiteId;
        private DirtyValue<string?>? _workFlowId;

        /// <summary>
        /// 4b. Other New Mortgage Loans on the Property You are Buying or Refinancing Does not Apply [URLA.X237]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
        public bool? AdditionalLoanDoesNotApply { get => _additionalLoanDoesNotApply; set => SetField(ref _additionalLoanDoesNotApply, value); }

        /// <summary>
        /// Loan AdditionalRequests
        /// </summary>
        [AllowNull]
        public AdditionalRequests AdditionalRequests { get => GetField(ref _additionalRequests); set => SetField(ref _additionalRequests, value); }

        /// <summary>
        /// Trans Details Current Status Date [749]
        /// </summary>
        public DateTime? AdverseActionDate { get => _adverseActionDate; set => SetField(ref _adverseActionDate, value); }

        /// <summary>
        /// Loan AffiliatedBusinessArrangements
        /// </summary>
        [AllowNull]
        public IList<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get => GetField(ref _affiliatedBusinessArrangements); set => SetField(ref _affiliatedBusinessArrangements, value); }

        /// <summary>
        /// Affordable Loan Indicator [URLA.X210]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan \"}")]
        public bool? AffordableLoan { get => _affordableLoan; set => SetField(ref _affordableLoan, value); }

        /// <summary>
        /// Trans Details Agency Case # [1040]
        /// </summary>
        public string? AgencyCaseIdentifier { get => _agencyCaseIdentifier; set => SetField(ref _agencyCaseIdentifier, value); }

        /// <summary>
        /// Loan Aiq
        /// </summary>
        [AllowNull]
        public Aiq Aiq { get => GetField(ref _aiq); set => SetField(ref _aiq, value); }

        /// <summary>
        /// Good Faith Change of Circumstance - Apply to LEorCD [4462]
        /// </summary>
        public string? AlertChangeCircumstanceApplyLECD { get => _alertChangeCircumstanceApplyLECD; set => SetField(ref _alertChangeCircumstanceApplyLECD, value); }

        /// <summary>
        /// Loan AlertChangeCircumstances
        /// </summary>
        [AllowNull]
        public IList<AlertChangeCircumstance> AlertChangeCircumstances { get => GetField(ref _alertChangeCircumstances); set => SetField(ref _alertChangeCircumstances, value); }

        /// <summary>
        /// Loan AllowPrint2003Application
        /// </summary>
        public bool? AllowPrint2003Application { get => _allowPrint2003Application; set => SetField(ref _allowPrint2003Application, value); }

        /// <summary>
        /// Trans Details Alterations [967]
        /// </summary>
        public decimal? AlterationsImprovementsOrRepairsAmount { get => _alterationsImprovementsOrRepairsAmount; set => SetField(ref _alterationsImprovementsOrRepairsAmount, value); }

        /// <summary>
        /// Loan Applications
        /// </summary>
        [AllowNull]
        public IList<Application> Applications { get => GetField(ref _applications); set => SetField(ref _applications, value); }

        /// <summary>
        /// Trans Details Application Taken By [479]
        /// </summary>
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => SetField(ref _applicationTakenMethodType, value); }

        /// <summary>
        /// Trans Details Date APR Disclosed [363]
        /// </summary>
        public DateTime? AprDisclosureDate { get => _aprDisclosureDate; set => SetField(ref _aprDisclosureDate, value); }

        /// <summary>
        /// Loan Info ARM Descr [248]
        /// </summary>
        public string? ArmTypeDescription { get => _armTypeDescription; set => SetField(ref _armTypeDescription, value); }

        /// <summary>
        /// Loan ATRQMCommon
        /// </summary>
        [AllowNull]
        public ATRQMCommon ATRQMCommon { get => GetField(ref _aTRQMCommon); set => SetField(ref _aTRQMCommon, value); }

        /// <summary>
        /// Average Representative Credit Score [4752]
        /// </summary>
        public int? AverageRepresentativeCreditScore { get => _averageRepresentativeCreditScore; set => SetField(ref _averageRepresentativeCreditScore, value); }

        /// <summary>
        /// Trans Details Total Loan Amt (w/ MIP/FF) [2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }

        /// <summary>
        /// Fannie Mae Seller Prov Below Mkt Financing [MORNET.X12]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Seller Provided Below Market Financing\"}")]
        public bool? BelowMarketSubordinateFinancingIndicator { get => _belowMarketSubordinateFinancingIndicator; set => SetField(ref _belowMarketSubordinateFinancingIndicator, value); }

        /// <summary>
        /// Billing Category [BILLINGCATEGORY]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? BillingCategory { get => _billingCategory; set => SetField(ref _billingCategory, value); }

        /// <summary>
        /// Biweekly Payment [3034]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BiweeklyPaymentAmount { get => _biweeklyPaymentAmount; set => SetField(ref _biweeklyPaymentAmount, value); }

        /// <summary>
        /// Base LTV Ratio Percent [4012]
        /// </summary>
        public int? BLTV { get => _bLTV; set => SetField(ref _bLTV, value); }

        /// <summary>
        /// BORROWER Community Property State Resident Indicator [URLA.X129]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"At least one borrower lives in a community property state.\"}")]
        public bool? BorrCommunityPropertyStateResidentIndicator { get => _borrCommunityPropertyStateResidentIndicator; set => SetField(ref _borrCommunityPropertyStateResidentIndicator, value); }

        /// <summary>
        /// Estimated Closing Costs Amount [URLA.X146]
        /// </summary>
        public decimal? BorrEstimatedClosingCostsAmount { get => _borrEstimatedClosingCostsAmount; set => SetField(ref _borrEstimatedClosingCostsAmount, value); }

        /// <summary>
        /// Borr/Co-Borr Married Indicator [100]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Borrower / Co-Borrower are Married\"}")]
        public bool? BorrowerCoBorrowerMarriedIndicator { get => _borrowerCoBorrowerMarriedIndicator; set => SetField(ref _borrowerCoBorrowerMarriedIndicator, value); }

        /// <summary>
        /// Borrower count  [URLA.X194]
        /// </summary>
        public string? BorrowerCount { get => _borrowerCount; set => SetField(ref _borrowerCount, value); }

        /// <summary>
        /// Borrower Full Name [URLA.X158]
        /// </summary>
        public string? BorrowerFullName { get => _borrowerFullName; set => SetField(ref _borrowerFullName, value); }

        /// <summary>
        /// Fees Total Closing Costs Borr [BORPCC]
        /// </summary>
        public decimal? BorrowerPaidClosingCostsAmount { get => _borrowerPaidClosingCostsAmount; set => SetField(ref _borrowerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Fees Loan Discount Fee Borr [1093]
        /// </summary>
        public decimal? BorrowerPaidDiscountPointsAmount { get => _borrowerPaidDiscountPointsAmount; set => SetField(ref _borrowerPaidDiscountPointsAmount, value); }

        /// <summary>
        /// Fees Total FHA Closing Costs Borr [1132]
        /// </summary>
        public decimal? BorrowerPaidFHAVAClosingCostsAmount { get => _borrowerPaidFHAVAClosingCostsAmount; set => SetField(ref _borrowerPaidFHAVAClosingCostsAmount, value); }

        /// <summary>
        /// Number of Borrower Pairs [4460]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BorrowerPairCount { get => _borrowerPairCount; set => SetField(ref _borrowerPairCount, value); }

        /// <summary>
        /// Trans Details Loan Amt [1109]
        /// </summary>
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => SetField(ref _borrowerRequestedLoanAmount, value); }

        /// <summary>
        /// Borrower Requested Loan Amount [URLA.X70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BorrowerRequestedLoanAmountURLA { get => _borrowerRequestedLoanAmountURLA; set => SetField(ref _borrowerRequestedLoanAmountURLA, value); }

        /// <summary>
        /// Fees Total Closing Costs Broker [BKRPCC]
        /// </summary>
        public decimal? BrokerPaidClosingCostsAmount { get => _brokerPaidClosingCostsAmount; set => SetField(ref _brokerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Loan Info Buydown [425]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Buydown\"}")]
        public bool? BuydownIndicator { get => _buydownIndicator; set => SetField(ref _buydownIndicator, value); }

        /// <summary>
        /// Monthly Buydown Payment [BUYDOWNPAYMENT]
        /// </summary>
        public decimal? BuydownMonthlyPaymentAmount { get => _buydownMonthlyPaymentAmount; set => SetField(ref _buydownMonthlyPaymentAmount, value); }

        /// <summary>
        /// FHA MCAW Buydown Rate [964]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => SetField(ref _buydownRatePercent, value); }

        /// <summary>
        /// Calculated Draw Amount [4525]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CalculatedDrawAmount { get => _calculatedDrawAmount; set => SetField(ref _calculatedDrawAmount, value); }

        /// <summary>
        /// Calculated Loan Amount [4526]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CalculatedLoanAmount { get => _calculatedLoanAmount; set => SetField(ref _calculatedLoanAmount, value); }

        /// <summary>
        /// Trans Details Cash From Borr [142]
        /// </summary>
        public decimal? CashFromToBorrowerAmount { get => _cashFromToBorrowerAmount; set => SetField(ref _cashFromToBorrowerAmount, value); }

        /// <summary>
        /// Loan Info Channel [2626]
        /// </summary>
        public StringEnumValue<Channel> Channel { get => _channel; set => SetField(ref _channel, value); }

        /// <summary>
        /// Closed End Primary Mortgage Loan Amount [4487]
        /// </summary>
        public decimal? ClosedEndPrimaryMortgageLoanAmount { get => _closedEndPrimaryMortgageLoanAmount; set => SetField(ref _closedEndPrimaryMortgageLoanAmount, value); }

        /// <summary>
        /// Closed End Subordinate Mortgage Loan Amount [4488]
        /// </summary>
        public decimal? ClosedEndSubordinateMortgageLoanAmount { get => _closedEndSubordinateMortgageLoanAmount; set => SetField(ref _closedEndSubordinateMortgageLoanAmount, value); }

        /// <summary>
        /// Closing Date for Billing Purposes [3260]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? ClosingBillingDate { get => _closingBillingDate; set => SetField(ref _closingBillingDate, value); }

        /// <summary>
        /// Loan ClosingCost
        /// </summary>
        [AllowNull]
        public ClosingCost ClosingCost { get => GetField(ref _closingCost); set => SetField(ref _closingCost, value); }

        /// <summary>
        /// Trans Details Closing Cost Program [1785]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ClosingCostProgram { get => _closingCostProgram; set => SetField(ref _closingCostProgram, value); }

        /// <summary>
        /// Trans Details CC From Second [1851]
        /// </summary>
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get => _closingCostsAndPrepaidsFromOtherLienAmount; set => SetField(ref _closingCostsAndPrepaidsFromOtherLienAmount, value); }

        /// <summary>
        /// Trans Details CC Paid By Broker/Lender/Other [1852]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ClosingCostsPaidByOthersAmount { get => _closingCostsPaidByOthersAmount; set => SetField(ref _closingCostsPaidByOthersAmount, value); }

        /// <summary>
        /// Closing Document Stacking Order [Closing.DocStkOrdr]
        /// </summary>
        public string? ClosingDocsStackingOrder { get => _closingDocsStackingOrder; set => SetField(ref _closingDocsStackingOrder, value); }

        /// <summary>
        /// Loan ClosingDocument
        /// </summary>
        [AllowNull]
        public ClosingDocument ClosingDocument { get => GetField(ref _closingDocument); set => SetField(ref _closingDocument, value); }

        /// <summary>
        /// Collateral Manager Score # [3356]
        /// </summary>
        public int? CollateralManagerScore { get => _collateralManagerScore; set => SetField(ref _collateralManagerScore, value); }

        /// <summary>
        /// Loan CollateralTracking
        /// </summary>
        [AllowNull]
        public CollateralTracking CollateralTracking { get => GetField(ref _collateralTracking); set => SetField(ref _collateralTracking, value); }

        /// <summary>
        /// Trans Details Comb Loan to Value (CLTV) [976]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CombinedLtv { get => _combinedLtv; set => SetField(ref _combinedLtv, value); }

        /// <summary>
        /// Commitment Number [3907]
        /// </summary>
        public string? CommitmentNumber { get => _commitmentNumber; set => SetField(ref _commitmentNumber, value); }

        /// <summary>
        /// Loan CommitmentTerms
        /// </summary>
        [AllowNull]
        public CommitmentTerms CommitmentTerms { get => GetField(ref _commitmentTerms); set => SetField(ref _commitmentTerms, value); }

        /// <summary>
        /// Community Property State Resident Indicator [URLA.X130]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"The property is in a community property state.\"}")]
        public bool? CommunityPropertyStateResidentIndicator { get => _communityPropertyStateResidentIndicator; set => SetField(ref _communityPropertyStateResidentIndicator, value); }

        /// <summary>
        /// Compliance Review Type [4721]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Correspondent Compliance Review\",\"N\":\"Retail Compliance Review\"}")]
        public bool? ComplianceReviewType { get => _complianceReviewType; set => SetField(ref _complianceReviewType, value); }

        /// <summary>
        /// Loan ComplianceTestLogs
        /// </summary>
        [AllowNull]
        public IList<ComplianceTestLog> ComplianceTestLogs { get => GetField(ref _complianceTestLogs); set => SetField(ref _complianceTestLogs, value); }

        /// <summary>
        /// Condominium Project Type Indicator [URLA.X205]
        /// </summary>
        public bool? CondominiumIndicator { get => _condominiumIndicator; set => SetField(ref _condominiumIndicator, value); }

        /// <summary>
        /// Conforming Loan Indicator [3331]
        /// </summary>
        public StringEnumValue<ConformingJumbo> ConformingJumbo { get => _conformingJumbo; set => SetField(ref _conformingJumbo, value); }

        /// <summary>
        /// Construction Loan Indicator [URLA.X133]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Construction-Conversion/Construction-to-Permanent\"}")]
        public bool? ConstructionLoanIndicator { get => _constructionLoanIndicator; set => SetField(ref _constructionLoanIndicator, value); }

        /// <summary>
        /// Loan ConstructionManagement
        /// </summary>
        [AllowNull]
        public ConstructionManagement ConstructionManagement { get => GetField(ref _constructionManagement); set => SetField(ref _constructionManagement, value); }

        /// <summary>
        /// Construction To Permanent Closing Type [URLA.X134]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"OneClosing\":\"Single Closing\"}")]
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => _constructionToPermanentClosingType; set => SetField(ref _constructionToPermanentClosingType, value); }

        /// <summary>
        /// Consumer Connect SiteID [ConsumerConnectSiteID]
        /// </summary>
        public string? ConsumerConnectSiteID { get => _consumerConnectSiteID; set => SetField(ref _consumerConnectSiteID, value); }

        /// <summary>
        /// Loan Contacts
        /// </summary>
        [AllowNull]
        public IList<Contact> Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }

        /// <summary>
        /// Loan Info Contact Update [2821]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? ContactUpdatedIndicator { get => _contactUpdatedIndicator; set => SetField(ref _contactUpdatedIndicator, value); }

        /// <summary>
        /// Contract Seller Credit Amount [NEWHUD2.X23]
        /// </summary>
        public decimal? ContractSellerCreditAmount { get => _contractSellerCreditAmount; set => SetField(ref _contractSellerCreditAmount, value); }

        /// <summary>
        /// Loan ConversationLogs
        /// </summary>
        [AllowNull]
        public IList<ConversationLog> ConversationLogs { get => GetField(ref _conversationLogs); set => SetField(ref _conversationLogs, value); }

        /// <summary>
        /// Conversion Of Contract For Deed Indicator [URLA.X131]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Conversion of Contract for Deed or Land Contract\"}")]
        public bool? ConversionOfContractForDeedIndicator { get => _conversionOfContractForDeedIndicator; set => SetField(ref _conversionOfContractForDeedIndicator, value); }

        /// <summary>
        /// Cooperative Project Type Indicator [URLA.X206]
        /// </summary>
        public bool? CooperativeIndicator { get => _cooperativeIndicator; set => SetField(ref _cooperativeIndicator, value); }

        /// <summary>
        /// Trans Details Copy to Lender Check Box [1969]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copy to Lender\"}")]
        public bool? CopyBrokerToLenderIndicator { get => _copyBrokerToLenderIndicator; set => SetField(ref _copyBrokerToLenderIndicator, value); }

        /// <summary>
        /// Trans Details Copy Loan # to Case # [1481]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copy Loan Number to lender case number\",\"N\":\"\"}")]
        public StringEnumValue<YOrN> CopyLoanNumLenderCaseNum { get => _copyLoanNumLenderCaseNum; set => SetField(ref _copyLoanNumLenderCaseNum, value); }

        /// <summary>
        /// Loan Correspondent
        /// </summary>
        [AllowNull]
        public Correspondent Correspondent { get => GetField(ref _correspondent); set => SetField(ref _correspondent, value); }

        /// <summary>
        /// Counseling Borrower Full Name [URLA.X164]
        /// </summary>
        public string? CounselingBorrowerFullName { get => _counselingBorrowerFullName; set => SetField(ref _counselingBorrowerFullName, value); }

        /// <summary>
        /// Counseling Completed Date [URLA.X163]
        /// </summary>
        public DateTime? CounselingCompletedDate { get => _counselingCompletedDate; set => SetField(ref _counselingCompletedDate, value); }

        /// <summary>
        /// Lock Request Credit Score for Decision Making [2853]
        /// </summary>
        public string? CreditScoreToUse { get => _creditScoreToUse; set => SetField(ref _creditScoreToUse, value); }

        /// <summary>
        /// Loan CrmLogs
        /// </summary>
        [AllowNull]
        public IList<CrmLog> CrmLogs { get => GetField(ref _crmLogs); set => SetField(ref _crmLogs, value); }

        /// <summary>
        /// Loan CurrentApplicationIndex
        /// </summary>
        public int? CurrentApplicationIndex { get => _currentApplicationIndex; set => SetField(ref _currentApplicationIndex, value); }

        /// <summary>
        /// Loan CurrentApplicationIsPrimary
        /// </summary>
        public bool? CurrentApplicationIsPrimary { get => _currentApplicationIsPrimary; set => SetField(ref _currentApplicationIsPrimary, value); }

        /// <summary>
        /// Trans Details First Mtg Owner [991]
        /// </summary>
        public StringEnumValue<CurrentFirstMortgageHolderType> CurrentFirstMortgageHolderType { get => _currentFirstMortgageHolderType; set => SetField(ref _currentFirstMortgageHolderType, value); }

        /// <summary>
        /// Loan CustomFields
        /// </summary>
        [AllowNull]
        public IList<CustomField> CustomFields { get => GetField(ref _customFields); set => SetField(ref _customFields, value); }

        /// <summary>
        /// Loan CustomModelFields
        /// </summary>
        public CustomModelFields? CustomModelFields { get => _customModelFields; set => SetField(ref _customModelFields, value); }

        /// <summary>
        /// Loan DataTracLogs
        /// </summary>
        [AllowNull]
        public IList<DataTracLog> DataTracLogs { get => GetField(ref _dataTracLogs); set => SetField(ref _dataTracLogs, value); }

        /// <summary>
        /// Loan DBIndicator
        /// </summary>
        public bool? DBIndicator { get => _dBIndicator; set => SetField(ref _dBIndicator, value); }

        /// <summary>
        /// Trans Details Deduct Overwire Amt From Broker Check [2833]
        /// </summary>
        public bool? DeductOverwireAmountIndicator { get => _deductOverwireAmountIndicator; set => SetField(ref _deductOverwireAmountIndicator, value); }

        /// <summary>
        /// Disable eConsent Alert [4072]
        /// </summary>
        public bool? DisableESignConsentAlert { get => _disableESignConsentAlert; set => SetField(ref _disableESignConsentAlert, value); }

        /// <summary>
        /// Disable Key Pricing Alert [4062]
        /// </summary>
        public bool? DisableKeyPricingAlert { get => _disableKeyPricingAlert; set => SetField(ref _disableKeyPricingAlert, value); }

        /// <summary>
        /// Loan DisclosureNotices
        /// </summary>
        [AllowNull]
        public DisclosureNotices DisclosureNotices { get => GetField(ref _disclosureNotices); set => SetField(ref _disclosureNotices, value); }

        /// <summary>
        /// Loan DisclosureTracking2015Logs
        /// </summary>
        [AllowNull]
        public IList<DisclosureTracking2015Log> DisclosureTracking2015Logs { get => GetField(ref _disclosureTracking2015Logs); set => SetField(ref _disclosureTracking2015Logs, value); }

        /// <summary>
        /// Loan DisclosureTrackingLogs
        /// </summary>
        [AllowNull]
        public IList<DisclosureTrackingLog> DisclosureTrackingLogs { get => GetField(ref _disclosureTrackingLogs); set => SetField(ref _disclosureTrackingLogs, value); }

        /// <summary>
        /// Trans Detail Discount Point [1010]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DiscountPoint { get => _discountPoint; set => SetField(ref _discountPoint, value); }

        /// <summary>
        /// Ellie Mae Document Engine Version [Docs.Engine]
        /// </summary>
        public StringEnumValue<DocEngine> DocEngine { get => _docEngine; set => SetField(ref _docEngine, value); }

        /// <summary>
        /// Loan DocumentLogs
        /// </summary>
        [AllowNull]
        public IList<DocumentLog> DocumentLogs { get => GetField(ref _documentLogs); set => SetField(ref _documentLogs, value); }

        /// <summary>
        /// Loan DocumentOrderLogs
        /// </summary>
        [AllowNull]
        public IList<DocumentOrderLog> DocumentOrderLogs { get => GetField(ref _documentOrderLogs); set => SetField(ref _documentOrderLogs, value); }

        /// <summary>
        /// Loan DocumentTrackingLogs
        /// </summary>
        [AllowNull]
        public IList<DocumentTrackingLog> DocumentTrackingLogs { get => GetField(ref _documentTrackingLogs); set => SetField(ref _documentTrackingLogs, value); }

        /// <summary>
        /// Do Not Check Email When Loan File Is Saved [3040]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DoNotCheckEmail { get => _doNotCheckEmail; set => SetField(ref _doNotCheckEmail, value); }

        /// <summary>
        /// Fees Do not print line 824 and 825 Check Box [1970]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Do not print line 824 and 825\"}")]
        public bool? DoNotPrintCompensationFees { get => _doNotPrintCompensationFees; set => SetField(ref _doNotPrintCompensationFees, value); }

        /// <summary>
        /// Loan DownloadLogs
        /// </summary>
        [AllowNull]
        public IList<DownloadLog> DownloadLogs { get => GetField(ref _downloadLogs); set => SetField(ref _downloadLogs, value); }

        /// <summary>
        /// Loan DownPayment
        /// </summary>
        [AllowNull]
        public DownPayment DownPayment { get => GetField(ref _downPayment); set => SetField(ref _downPayment, value); }

        /// <summary>
        /// Trans Details Down Pmt % [1771]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => SetField(ref _downPaymentPercent, value); }

        /// <summary>
        /// eDelivery - Version [EDELIVERY.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? EDeliveryVersion { get => _eDeliveryVersion; set => SetField(ref _eDeliveryVersion, value); }

        /// <summary>
        /// Loan EdmLogs
        /// </summary>
        [AllowNull]
        public IList<EdmLog> EdmLogs { get => GetField(ref _edmLogs); set => SetField(ref _edmLogs, value); }

        /// <summary>
        /// Loan ElliUCDFields
        /// </summary>
        public ElliUCDDetail? ElliUCDFields { get => _elliUCDFields; set => SetField(ref _elliUCDFields, value); }

        /// <summary>
        /// Loan EmailTriggerLogs
        /// </summary>
        [AllowNull]
        public IList<EmailTriggerLog> EmailTriggerLogs { get => GetField(ref _emailTriggerLogs); set => SetField(ref _emailTriggerLogs, value); }

        /// <summary>
        /// Loan EmDocument
        /// </summary>
        [AllowNull]
        public EmDocument EmDocument { get => GetField(ref _emDocument); set => SetField(ref _emDocument, value); }

        /// <summary>
        /// Loan EmDocumentInvestor
        /// </summary>
        [AllowNull]
        public EmDocumentInvestor EmDocumentInvestor { get => GetField(ref _emDocumentInvestor); set => SetField(ref _emDocumentInvestor, value); }

        /// <summary>
        /// Loan EmDocumentLender
        /// </summary>
        [AllowNull]
        public EmDocumentLender EmDocumentLender { get => GetField(ref _emDocumentLender); set => SetField(ref _emDocumentLender, value); }

        /// <summary>
        /// Loan EmXmlVersionId [1000]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? EmXmlVersionId { get => _emXmlVersionId; set => SetField(ref _emXmlVersionId, value); }

        /// <summary>
        /// Loan Info Loan ID [GUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? EncompassId { get => _encompassId; set => SetField(ref _encompassId, value); }

        /// <summary>
        /// Encompass Version [SYS.X611]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? EncompassVersion { get => _encompassVersion; set => SetField(ref _encompassVersion, value); }

        /// <summary>
        /// Energy Improvement Amount [4785]
        /// </summary>
        public decimal? EnergyImprovementAmount { get => _energyImprovementAmount; set => SetField(ref _energyImprovementAmount, value); }

        /// <summary>
        /// Enforce County Loan Limit [3894]
        /// </summary>
        public bool? EnforceCountyLoanLimit { get => _enforceCountyLoanLimit; set => SetField(ref _enforceCountyLoanLimit, value); }

        /// <summary>
        /// Loan EnhancedConditionLogs
        /// </summary>
        [AllowNull]
        public IList<EnhancedConditionLog> EnhancedConditionLogs { get => GetField(ref _enhancedConditionLogs); set => SetField(ref _enhancedConditionLogs, value); }

        /// <summary>
        /// eNote Authoritative Copy [4728]
        /// </summary>
        public bool? EnoteAuthoritativeCopy { get => _enoteAuthoritativeCopy; set => SetField(ref _enoteAuthoritativeCopy, value); }

        /// <summary>
        /// eNote Controller Org Id [4729]
        /// </summary>
        public string? EnoteControllerOrgId { get => _enoteControllerOrgId; set => SetField(ref _enoteControllerOrgId, value); }

        /// <summary>
        /// eNote Controller Org Name [4730]
        /// </summary>
        public string? EnoteControllerOrgName { get => _enoteControllerOrgName; set => SetField(ref _enoteControllerOrgName, value); }

        /// <summary>
        /// eNote Delagatee for Transfer Org Id [4741]
        /// </summary>
        public string? EnoteDelagateeForTransferOrgId { get => _enoteDelagateeForTransferOrgId; set => SetField(ref _enoteDelagateeForTransferOrgId, value); }

        /// <summary>
        /// eNote Delagatee for Transfer Org Name [4742]
        /// </summary>
        public string? EnoteDelagateeForTransferOrgName { get => _enoteDelagateeForTransferOrgName; set => SetField(ref _enoteDelagateeForTransferOrgName, value); }

        /// <summary>
        /// eNote Lender Name [4725]
        /// </summary>
        public string? EnoteLenderName { get => _enoteLenderName; set => SetField(ref _enoteLenderName, value); }

        /// <summary>
        /// eNote Location Org Id [4731]
        /// </summary>
        public string? EnoteLocationOrgId { get => _enoteLocationOrgId; set => SetField(ref _enoteLocationOrgId, value); }

        /// <summary>
        /// eNote Location Org Name [4732]
        /// </summary>
        public string? EnoteLocationOrgName { get => _enoteLocationOrgName; set => SetField(ref _enoteLocationOrgName, value); }

        /// <summary>
        /// eNote Master Servicer Org Id [4733]
        /// </summary>
        public string? EnoteMasterServiceOrgId { get => _enoteMasterServiceOrgId; set => SetField(ref _enoteMasterServiceOrgId, value); }

        /// <summary>
        /// eNote Master Servicer Org Name [4734]
        /// </summary>
        public string? EnoteMasterServiceOrgName { get => _enoteMasterServiceOrgName; set => SetField(ref _enoteMasterServiceOrgName, value); }

        /// <summary>
        /// eNote MERS MIN Number [4726]
        /// </summary>
        public string? EnoteMersMinNumber { get => _enoteMersMinNumber; set => SetField(ref _enoteMersMinNumber, value); }

        /// <summary>
        /// eNote Registered DateTime [4727]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EnoteRegisteredDateTime { get => _enoteRegisteredDateTime; set => SetField(ref _enoteRegisteredDateTime, value); }

        /// <summary>
        /// eNote Secured Party Delagatee Org Id [4739]
        /// </summary>
        public string? EnoteSecuredPartyDelagateeOrgId { get => _enoteSecuredPartyDelagateeOrgId; set => SetField(ref _enoteSecuredPartyDelagateeOrgId, value); }

        /// <summary>
        /// eNote Secured Party Delagatee Org Name [4740]
        /// </summary>
        public string? EnoteSecuredPartyDelagateeOrgName { get => _enoteSecuredPartyDelagateeOrgName; set => SetField(ref _enoteSecuredPartyDelagateeOrgName, value); }

        /// <summary>
        /// eNote Secured Party Org Id [4737]
        /// </summary>
        public string? EnoteSecuredPartyOrgId { get => _enoteSecuredPartyOrgId; set => SetField(ref _enoteSecuredPartyOrgId, value); }

        /// <summary>
        /// eNote Secured Party Org Name [4738]
        /// </summary>
        public string? EnoteSecuredPartyOrgName { get => _enoteSecuredPartyOrgName; set => SetField(ref _enoteSecuredPartyOrgName, value); }

        /// <summary>
        /// eNote Subservicer Org Id [4735]
        /// </summary>
        public string? EnoteSubservicerOrgId { get => _enoteSubservicerOrgId; set => SetField(ref _enoteSubservicerOrgId, value); }

        /// <summary>
        /// eNote Subservicer Org Name [4736]
        /// </summary>
        public string? EnoteSubservicerOrgName { get => _enoteSubservicerOrgName; set => SetField(ref _enoteSubservicerOrgName, value); }

        /// <summary>
        /// eNote Transfer Effective Date [4743]
        /// </summary>
        public DateTime? EnoteTransferEffectiveDate { get => _enoteTransferEffectiveDate; set => SetField(ref _enoteTransferEffectiveDate, value); }

        /// <summary>
        /// eNote Transfer Status [4744]
        /// </summary>
        public StringEnumValue<EnoteTransferStatus> EnoteTransferStatus { get => _enoteTransferStatus; set => SetField(ref _enoteTransferStatus, value); }

        /// <summary>
        /// Trans Details Est Closing Costs [137]
        /// </summary>
        public decimal? EstimatedClosingCostsAmount { get => _estimatedClosingCostsAmount; set => SetField(ref _estimatedClosingCostsAmount, value); }

        /// <summary>
        /// Trans Details Estimated Construction Interest [4088]
        /// </summary>
        public decimal? EstimatedConstructionInterest { get => _estimatedConstructionInterest; set => SetField(ref _estimatedConstructionInterest, value); }

        /// <summary>
        /// Trans Details Est Prepaids [138]
        /// </summary>
        public decimal? EstimatedPrepaidItemsAmount { get => _estimatedPrepaidItemsAmount; set => SetField(ref _estimatedPrepaidItemsAmount, value); }

        /// <summary>
        /// Existing Liens And Draw Used [4521]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLiensAndDrawUsed { get => _existingLiensAndDrawUsed; set => SetField(ref _existingLiensAndDrawUsed, value); }

        /// <summary>
        /// Existing Liens Used [4522]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLiensUsed { get => _existingLiensUsed; set => SetField(ref _existingLiensUsed, value); }

        /// <summary>
        /// Expected Borrower Count [URLA.X261]
        /// </summary>
        public int? ExpectedBorrowerCount { get => _expectedBorrowerCount; set => SetField(ref _expectedBorrowerCount, value); }

        /// <summary>
        /// Export Investor or Lender Loan Number [2573]
        /// </summary>
        public StringEnumValue<ExportLoanNumber> ExportLoanNumber { get => _exportLoanNumber; set => SetField(ref _exportLoanNumber, value); }

        /// <summary>
        /// Loan ExportLogs
        /// </summary>
        [AllowNull]
        public IList<ExportLog> ExportLogs { get => GetField(ref _exportLogs); set => SetField(ref _exportLogs, value); }

        /// <summary>
        /// Loan FannieMae
        /// </summary>
        [AllowNull]
        public FannieMae FannieMae { get => GetField(ref _fannieMae); set => SetField(ref _fannieMae, value); }

        /// <summary>
        /// Loan FannieServiceDuLogs
        /// </summary>
        [AllowNull]
        public IList<FannieServiceDuLog> FannieServiceDuLogs { get => GetField(ref _fannieServiceDuLogs); set => SetField(ref _fannieServiceDuLogs, value); }

        /// <summary>
        /// Loan FannieServiceEcLogs
        /// </summary>
        [AllowNull]
        public IList<FannieServiceEcLog> FannieServiceEcLogs { get => GetField(ref _fannieServiceEcLogs); set => SetField(ref _fannieServiceEcLogs, value); }

        /// <summary>
        /// Loan Fees
        /// </summary>
        [AllowNull]
        public IList<Fee> Fees { get => GetField(ref _fees); set => SetField(ref _fees, value); }

        /// <summary>
        /// FHA MIP Refund Amt [1134]
        /// </summary>
        public decimal? FhaMiPremiumRefundAmount { get => _fhaMiPremiumRefundAmount; set => SetField(ref _fhaMiPremiumRefundAmount, value); }

        /// <summary>
        /// Loan FhaVaLoan
        /// </summary>
        [AllowNull]
        public FhaVaLoan FhaVaLoan { get => GetField(ref _fhaVaLoan); set => SetField(ref _fhaVaLoan, value); }

        /// <summary>
        /// Loan FHAVALoanOriginatorIdentifier
        /// </summary>
        public string? FHAVALoanOriginatorIdentifier { get => _fHAVALoanOriginatorIdentifier; set => SetField(ref _fHAVALoanOriginatorIdentifier, value); }

        /// <summary>
        /// Loan FieldLockData
        /// </summary>
        [AllowNull]
        public IList<FieldLockData> FieldLockData { get => GetField(ref _fieldLockData); set => SetField(ref _fieldLockData, value); }

        /// <summary>
        /// First Adjustment Minimum Value [3557]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FirstAdjustmentMinimum { get => _firstAdjustmentMinimum; set => SetField(ref _firstAdjustmentMinimum, value); }

        /// <summary>
        /// Trans Details Sub Fin First Mtg Loan Amt [427]
        /// </summary>
        public decimal? FirstSubordinateLienAmount { get => _firstSubordinateLienAmount; set => SetField(ref _firstSubordinateLienAmount, value); }

        /// <summary>
        /// Borr First Time Homebuyer [934]
        /// </summary>
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => SetField(ref _firstTimeHomebuyersIndicator, value); }

        /// <summary>
        /// Fannie Mae Community Lending Product [MORNET.X27]
        /// </summary>
        public StringEnumValue<FnmCommunityLendingProductName> FnmCommunityLendingProductName { get => _fnmCommunityLendingProductName; set => SetField(ref _fnmCommunityLendingProductName, value); }

        /// <summary>
        /// Fannie Mae Community Seconds [MORNET.X29]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Seconds\"}")]
        public bool? FnmCommunitySecondsIndicator { get => _fnmCommunitySecondsIndicator; set => SetField(ref _fnmCommunitySecondsIndicator, value); }

        /// <summary>
        /// Fannie Mae FannieNeighbors Elig [MORNET.X28]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"FannieNeighbors Eligible\"}")]
        public bool? FnmNeighborsMortgageEligibilityIndicator { get => _fnmNeighborsMortgageEligibilityIndicator; set => SetField(ref _fnmNeighborsMortgageEligibilityIndicator, value); }

        /// <summary>
        /// Loan Forms
        /// </summary>
        [AllowNull]
        public IList<Form> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

        /// <summary>
        /// Fraud Score # [3340]
        /// </summary>
        public int? FraudScore { get => _fraudScore; set => SetField(ref _fraudScore, value); }

        /// <summary>
        /// Loan FreddieMac
        /// </summary>
        [AllowNull]
        public FreddieMac FreddieMac { get => GetField(ref _freddieMac); set => SetField(ref _freddieMac, value); }

        /// <summary>
        /// Loan FreddieServiceLpaLogs
        /// </summary>
        [AllowNull]
        public IList<FreddieServiceLpaLog> FreddieServiceLpaLogs { get => GetField(ref _freddieServiceLpaLogs); set => SetField(ref _freddieServiceLpaLogs, value); }

        /// <summary>
        /// Loan FreddieServiceLqaLogs
        /// </summary>
        [AllowNull]
        public IList<FreddieServiceLqaLog> FreddieServiceLqaLogs { get => GetField(ref _freddieServiceLqaLogs); set => SetField(ref _freddieServiceLqaLogs, value); }

        /// <summary>
        /// Loan Funding
        /// </summary>
        [AllowNull]
        public Funding Funding { get => GetField(ref _funding); set => SetField(ref _funding, value); }

        /// <summary>
        /// Funding Worksheet Deduction Items [2971]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FundingDeductionList { get => _fundingDeductionList; set => SetField(ref _fundingDeductionList, value); }

        /// <summary>
        /// Funding Worksheet Fee List [2972]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FundingFeeList { get => _fundingFeeList; set => SetField(ref _fundingFeeList, value); }

        /// <summary>
        /// Loan FundingFees
        /// </summary>
        [AllowNull]
        public IList<FundingFee> FundingFees { get => GetField(ref _fundingFees); set => SetField(ref _fundingFees, value); }

        /// <summary>
        /// Loan Gfe
        /// </summary>
        [AllowNull]
        public Gfe Gfe { get => GetField(ref _gfe); set => SetField(ref _gfe, value); }

        /// <summary>
        /// Loan GoodFaithFeeVarianceCureLogs
        /// </summary>
        [AllowNull]
        public IList<GoodFaithFeeVarianceCureLog> GoodFaithFeeVarianceCureLogs { get => GetField(ref _goodFaithFeeVarianceCureLogs); set => SetField(ref _goodFaithFeeVarianceCureLogs, value); }

        /// <summary>
        /// Loan GovernmentLoanLenderIdentifier
        /// </summary>
        public string? GovernmentLoanLenderIdentifier { get => _governmentLoanLenderIdentifier; set => SetField(ref _governmentLoanLenderIdentifier, value); }

        /// <summary>
        /// Loan GovernmentLoanSponsorIdentifier
        /// </summary>
        public string? GovernmentLoanSponsorIdentifier { get => _governmentLoanSponsorIdentifier; set => SetField(ref _governmentLoanSponsorIdentifier, value); }

        /// <summary>
        /// Fannie Mae Mortgage Credit [MORNET.X33]
        /// </summary>
        public decimal? GovernmentMortgageCreditCertificateAmount { get => _governmentMortgageCreditCertificateAmount; set => SetField(ref _governmentMortgageCreditCertificateAmount, value); }

        /// <summary>
        /// Government Refinance Type [URLA.X166]
        /// </summary>
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => _governmentRefinanceType; set => SetField(ref _governmentRefinanceType, value); }

        /// <summary>
        /// Government Refinance Type Other Description [URLA.X167]
        /// </summary>
        public StringEnumValue<GovernmentRefinanceTypeOtherDescription> GovernmentRefinanceTypeOtherDescription { get => _governmentRefinanceTypeOtherDescription; set => SetField(ref _governmentRefinanceTypeOtherDescription, value); }

        /// <summary>
        /// Disclosure Bus Affiliate Name [AFF.X2]
        /// </summary>
        public string? HasAbusinessRelationshipWith { get => _hasAbusinessRelationshipWith; set => SetField(ref _hasAbusinessRelationshipWith, value); }

        /// <summary>
        /// Trans Details HCLTV/HTLTV [1540]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? HcltvHtltv { get => _hcltvHtltv; set => SetField(ref _hcltvHtltv, value); }

        /// <summary>
        /// HELOC Teaser Rate [1482]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? HelocTeaserRate { get => _helocTeaserRate; set => SetField(ref _helocTeaserRate, value); }

        /// <summary>
        /// Loan Hmda
        /// </summary>
        [AllowNull]
        public Hmda Hmda { get => GetField(ref _hmda); set => SetField(ref _hmda, value); }

        /// <summary>
        /// Loan HomeCounselingProviders
        /// </summary>
        [AllowNull]
        public IList<HomeCounselingProvider> HomeCounselingProviders { get => GetField(ref _homeCounselingProviders); set => SetField(ref _homeCounselingProviders, value); }

        /// <summary>
        /// Home Counseling Provider - Settings - Distance [HCSETTING.DISTANCE]
        /// </summary>
        public string? HomeCounselingProvidersDistance { get => _homeCounselingProvidersDistance; set => SetField(ref _homeCounselingProvidersDistance, value); }

        /// <summary>
        /// Home Counseling Provider - Settings - Language Names [HCSETTING.LANGUAGES]
        /// </summary>
        public string? HomeCounselingProvidersLanguageNames { get => _homeCounselingProvidersLanguageNames; set => SetField(ref _homeCounselingProvidersLanguageNames, value); }

        /// <summary>
        /// Home Counseling Provider - Settings - Service Names [HCSETTING.SERVICES]
        /// </summary>
        public string? HomeCounselingProvidersServiceNames { get => _homeCounselingProvidersServiceNames; set => SetField(ref _homeCounselingProvidersServiceNames, value); }

        /// <summary>
        /// Loan HouseholdSizeCount
        /// </summary>
        public int? HouseholdSizeCount { get => _householdSizeCount; set => SetField(ref _householdSizeCount, value); }

        /// <summary>
        /// Housing Counseling Agency [URLA.X156]
        /// </summary>
        public string? HousingCounselingAgency { get => _housingCounselingAgency; set => SetField(ref _housingCounselingAgency, value); }

        /// <summary>
        /// Housing Counseling Agency FullName [URLA.X162]
        /// </summary>
        public string? HousingCounselingAgencyFullName { get => _housingCounselingAgencyFullName; set => SetField(ref _housingCounselingAgencyFullName, value); }

        /// <summary>
        /// Loan HtmlEmailLogs
        /// </summary>
        [AllowNull]
        public IList<HtmlEmailLog> HtmlEmailLogs { get => GetField(ref _htmlEmailLogs); set => SetField(ref _htmlEmailLogs, value); }

        /// <summary>
        /// Loan Hud1Es
        /// </summary>
        [AllowNull]
        public Hud1Es Hud1Es { get => GetField(ref _hud1Es); set => SetField(ref _hud1Es, value); }

        /// <summary>
        /// Fannie Mae Income Limit Adj Factor [MORNET.X31]
        /// </summary>
        public decimal? HudIncomeLimitAdjustmentFactor { get => _hudIncomeLimitAdjustmentFactor; set => SetField(ref _hudIncomeLimitAdjustmentFactor, value); }

        /// <summary>
        /// Fannie Mae Community Lending Inc Limit [MORNET.X32]
        /// </summary>
        public decimal? HudLendingIncomeLimitAmount { get => _hudLendingIncomeLimitAmount; set => SetField(ref _hudLendingIncomeLimitAmount, value); }

        /// <summary>
        /// Loan HudLoanData
        /// </summary>
        [AllowNull]
        public HudLoanData HudLoanData { get => GetField(ref _hudLoanData); set => SetField(ref _hudLoanData, value); }

        /// <summary>
        /// Fannie Mae HUD Median Income [MORNET.X30]
        /// </summary>
        public decimal? HudMedianIncomeAmount { get => _hudMedianIncomeAmount; set => SetField(ref _hudMedianIncomeAmount, value); }

        /// <summary>
        /// Loan Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Trans Details Include USDA Upfront Guarantee Fee in Closing [3551]
        /// </summary>
        public bool? IncludeUSDAFeeInClosing { get => _includeUSDAFeeInClosing; set => SetField(ref _includeUSDAFeeInClosing, value); }

        /// <summary>
        /// Initial Interest Rate [4113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InitialInterestRate { get => _initialInterestRate; set => SetField(ref _initialInterestRate, value); }

        /// <summary>
        /// Initial Interest Rate - Display field with KBYO rounding rules  [KBYO.XD4113]
        /// </summary>
        public string? InitialInterestRateUI { get => _initialInterestRateUI; set => SetField(ref _initialInterestRateUI, value); }

        /// <summary>
        /// Trans Details Insurance Authorization Indicator [1984]
        /// </summary>
        public string? InsuranceAuthorizationIndicator { get => _insuranceAuthorizationIndicator; set => SetField(ref _insuranceAuthorizationIndicator, value); }

        /// <summary>
        /// Loan InterimServicing
        /// </summary>
        [AllowNull]
        public InterimServicing InterimServicing { get => GetField(ref _interimServicing); set => SetField(ref _interimServicing, value); }

        /// <summary>
        /// Fannie Mae Interview Date [MORNET.X69]
        /// </summary>
        public DateTime? InterviewerApplicationSignedDate { get => _interviewerApplicationSignedDate; set => SetField(ref _interviewerApplicationSignedDate, value); }

        /// <summary>
        /// Trans Details Interviewer Email [3968]
        /// </summary>
        public string? InterviewerEmail { get => _interviewerEmail; set => SetField(ref _interviewerEmail, value); }

        /// <summary>
        /// Interviewer's License Number [2306]
        /// </summary>
        public string? InterviewerLicenseIdentifier { get => _interviewerLicenseIdentifier; set => SetField(ref _interviewerLicenseIdentifier, value); }

        /// <summary>
        /// Trans Details Interviewer Phone [1823]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? InterviewerPhoneNumber { get => _interviewerPhoneNumber; set => SetField(ref _interviewerPhoneNumber, value); }

        /// <summary>
        /// The state license number for the interviewer's company. [3629]
        /// </summary>
        public string? InterviewersCompanyStateLicense { get => _interviewersCompanyStateLicense; set => SetField(ref _interviewersCompanyStateLicense, value); }

        /// <summary>
        /// Trans Details Interviewer ID [3239]
        /// </summary>
        public string? InterviewersId { get => _interviewersId; set => SetField(ref _interviewersId, value); }

        /// <summary>
        /// Trans Details Interviewer Name [1612]
        /// </summary>
        public string? InverviewerName { get => _inverviewerName; set => SetField(ref _inverviewerName, value); }

        /// <summary>
        /// Loan InvestorDeliveryLogs
        /// </summary>
        [AllowNull]
        public IList<InvestorDeliveryLog> InvestorDeliveryLogs { get => GetField(ref _investorDeliveryLogs); set => SetField(ref _investorDeliveryLogs, value); }

        /// <summary>
        /// Trans Details Creditor Prohibits Borrower from making interest Payments [4087]
        /// </summary>
        public bool? IsCreditorProhibitsBorrower { get => _isCreditorProhibitsBorrower; set => SetField(ref _isCreditorProhibitsBorrower, value); }

        /// <summary>
        /// Is Employee Loan? [4181]
        /// </summary>
        public bool? IsEmployeeLoan { get => _isEmployeeLoan; set => SetField(ref _isEmployeeLoan, value); }

        /// <summary>
        ///  Loan Amount Rounding Indicator [4745]
        /// </summary>
        public bool? IsLoanAmountRounding { get => _isLoanAmountRounding; set => SetField(ref _isLoanAmountRounding, value); }

        /// <summary>
        /// Indicator for loan link sync type [4117]
        /// </summary>
        public bool? IsLSSecondaryFile { get => _isLSSecondaryFile; set => SetField(ref _isLSSecondaryFile, value); }

        /// <summary>
        /// Trans Details Required Interest Reserve (Compound Interest) [4086]
        /// </summary>
        public bool? IsRequiredInterestReserveCompoundInterest { get => _isRequiredInterestReserveCompoundInterest; set => SetField(ref _isRequiredInterestReserveCompoundInterest, value); }

        /// <summary>
        /// Trans Details Land [968]
        /// </summary>
        public decimal? LandIfAcquiredSeperatelyAmount { get => _landIfAcquiredSeperatelyAmount; set => SetField(ref _landIfAcquiredSeperatelyAmount, value); }

        /// <summary>
        /// Loan Info Lead Source [2976]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LeadSource { get => _leadSource; set => SetField(ref _leadSource, value); }

        /// <summary>
        /// Loan Info Lead Source ID [4495]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LeadSourceID { get => _leadSourceID; set => SetField(ref _leadSourceID, value); }

        /// <summary>
        /// File Contacts Lender Case # [305]
        /// </summary>
        public string? LenderCaseIdentifier { get => _lenderCaseIdentifier; set => SetField(ref _lenderCaseIdentifier, value); }

        /// <summary>
        /// Lender Channel [3332]
        /// </summary>
        public StringEnumValue<LenderChannel> LenderChannel { get => _lenderChannel; set => SetField(ref _lenderChannel, value); }

        /// <summary>
        /// Trans Details Lender Credits In Funding [4083]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LenderCreditsInFunding { get => _lenderCreditsInFunding; set => SetField(ref _lenderCreditsInFunding, value); }

        /// <summary>
        /// File Contacts Investor Code [476]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LenderInvestorCode { get => _lenderInvestorCode; set => SetField(ref _lenderInvestorCode, value); }

        /// <summary>
        /// Fees Total Closing Costs Lender In Details of Transaction [LENPCCINDOT]
        /// </summary>
        public decimal? LenderPaidClosignCostsDotAmount { get => _lenderPaidClosignCostsDotAmount; set => SetField(ref _lenderPaidClosignCostsDotAmount, value); }

        /// <summary>
        /// Fees Total Closing Costs Lender [LENPCC]
        /// </summary>
        public decimal? LenderPaidClosingCostsAmount { get => _lenderPaidClosingCostsAmount; set => SetField(ref _lenderPaidClosingCostsAmount, value); }

        /// <summary>
        /// Lesser of Appraised Value or Original Sales Price [MORNET.X42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LesserAppraisedValueOrSalesPrice { get => _lesserAppraisedValueOrSalesPrice; set => SetField(ref _lesserAppraisedValueOrSalesPrice, value); }

        /// <summary>
        /// Trans Details Total Mo Pymt w/ Life Ins [1560]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LifeInsuranceCoverageAmount { get => _lifeInsuranceCoverageAmount; set => SetField(ref _lifeInsuranceCoverageAmount, value); }

        /// <summary>
        /// Insurance Est Mo Life Ins Pmt [1558]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LifeInsuranceEstimatedMonthlyAmount { get => _lifeInsuranceEstimatedMonthlyAmount; set => SetField(ref _lifeInsuranceEstimatedMonthlyAmount, value); }

        /// <summary>
        /// Insurance Life Insurance Coverage [1559]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get => _lifeInsuranceTotalProtectedMonthlyAmount; set => SetField(ref _lifeInsuranceTotalProtectedMonthlyAmount, value); }

        /// <summary>
        /// Trans Details Loan Amt - Copied from Linked Loan [LINK_1109]
        /// </summary>
        public decimal? LinkedBorrowerRequestedLoanAmount { get => _linkedBorrowerRequestedLoanAmount; set => SetField(ref _linkedBorrowerRequestedLoanAmount, value); }

        /// <summary>
        /// Loan LinkId [LINKGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LinkId { get => _linkId; set => SetField(ref _linkId, value); }

        /// <summary>
        /// Loan LoanActionLogs
        /// </summary>
        [AllowNull]
        public IList<LoanActionLog> LoanActionLogs { get => GetField(ref _loanActionLogs); set => SetField(ref _loanActionLogs, value); }

        /// <summary>
        /// Trans Details Term (Mos) [4]
        /// </summary>
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => SetField(ref _loanAmortizationTermMonths, value); }

        /// <summary>
        /// Trans Details Amort Type [608]
        /// </summary>
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }

        /// <summary>
        /// Loan LoanCreatedDate
        /// </summary>
        public string? LoanCreatedDate { get => _loanCreatedDate; set => SetField(ref _loanCreatedDate, value); }

        /// <summary>
        /// Loan Info Loan Created Date [2025]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
        public DateTime? LoanCreatedDateUtc { get => _loanCreatedDateUtc; set => SetField(ref _loanCreatedDateUtc, value); }

        /// <summary>
        /// Loan Features Other Indicator [URLA.X242]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Other\"}")]
        public bool? LoanFeaturesOtherIndicator { get => _loanFeaturesOtherIndicator; set => SetField(ref _loanFeaturesOtherIndicator, value); }

        /// <summary>
        /// Loan ID # [4063]
        /// </summary>
        public string? LoanIdNumber { get => _loanIdNumber; set => SetField(ref _loanIdNumber, value); }

        /// <summary>
        /// Loan Info Loan Import Status [3051]
        /// </summary>
        public bool? LoanImportStatusIndicator { get => _loanImportStatusIndicator; set => SetField(ref _loanImportStatusIndicator, value); }

        /// <summary>
        /// Loan Link Sync Type [4185]
        /// </summary>
        public StringEnumValue<LoanLinkSyncType> LoanLinkSyncType { get => _loanLinkSyncType; set => SetField(ref _loanLinkSyncType, value); }

        /// <summary>
        /// Trans Details Loan # [364]
        /// </summary>
        public string? LoanNumber { get => _loanNumber; set => SetField(ref _loanNumber, value); }

        /// <summary>
        /// Loan LoanProductData
        /// </summary>
        [AllowNull]
        public LoanProductData LoanProductData { get => GetField(ref _loanProductData); set => SetField(ref _loanProductData, value); }

        /// <summary>
        /// Trans Details Loan Program [1401]
        /// </summary>
        public string? LoanProgramName { get => _loanProgramName; set => SetField(ref _loanProgramName, value); }

        /// <summary>
        /// Loan LoanPrograms
        /// </summary>
        [AllowNull]
        public IList<LoanProgram> LoanPrograms { get => GetField(ref _loanPrograms); set => SetField(ref _loanPrograms, value); }

        /// <summary>
        /// Refinance Type [MORNET.X40]
        /// </summary>
        public StringEnumValue<LoanPurposeOfRefinanceType> LoanPurposeOfRefinanceType { get => _loanPurposeOfRefinanceType; set => SetField(ref _loanPurposeOfRefinanceType, value); }

        /// <summary>
        /// Loan Info Loan Source [2024]
        /// </summary>
        public string? LoanSource { get => _loanSource; set => SetField(ref _loanSource, value); }

        /// <summary>
        /// Loan LoanSubmission
        /// </summary>
        [AllowNull]
        public LoanSubmission LoanSubmission { get => GetField(ref _loanSubmission); set => SetField(ref _loanSubmission, value); }

        /// <summary>
        /// VA Mo Shelter Exp Est Maintenance [1147]
        /// </summary>
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get => _loanTotalProposedMonthlyMaintenanceAmount; set => SetField(ref _loanTotalProposedMonthlyMaintenanceAmount, value); }

        /// <summary>
        /// VA Mo Shelter Exp Est Utilities [1148]
        /// </summary>
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get => _loanTotalProposedMonthlyUtilitiesAmount; set => SetField(ref _loanTotalProposedMonthlyUtilitiesAmount, value); }

        /// <summary>
        /// Loan LoanUnderwriterCHUMSIdentifier
        /// </summary>
        public string? LoanUnderwriterCHUMSIdentifier { get => _loanUnderwriterCHUMSIdentifier; set => SetField(ref _loanUnderwriterCHUMSIdentifier, value); }

        /// <summary>
        /// Loan LoanVALoanProcedureType
        /// </summary>
        public string? LoanVALoanProcedureType { get => _loanVALoanProcedureType; set => SetField(ref _loanVALoanProcedureType, value); }

        /// <summary>
        /// Loan LoanVARateReductionInitialComputationTotalAmount
        /// </summary>
        public decimal? LoanVARateReductionInitialComputationTotalAmount { get => _loanVARateReductionInitialComputationTotalAmount; set => SetField(ref _loanVARateReductionInitialComputationTotalAmount, value); }

        /// <summary>
        /// Loan LoanVAResidualIncomeAmount
        /// </summary>
        public decimal? LoanVAResidualIncomeAmount { get => _loanVAResidualIncomeAmount; set => SetField(ref _loanVAResidualIncomeAmount, value); }

        /// <summary>
        /// Loan LoanVersionId
        /// </summary>
        public int? LoanVersionId { get => _loanVersionId; set => SetField(ref _loanVersionId, value); }

        /// <summary>
        /// Loan LockCancellationLogs
        /// </summary>
        [AllowNull]
        public IList<LockCancellationLog> LockCancellationLogs { get => GetField(ref _lockCancellationLogs); set => SetField(ref _lockCancellationLogs, value); }

        /// <summary>
        /// Loan LockConfirmLogs
        /// </summary>
        [AllowNull]
        public IList<LockConfirmLog> LockConfirmLogs { get => GetField(ref _lockConfirmLogs); set => SetField(ref _lockConfirmLogs, value); }

        /// <summary>
        /// Loan LockDenialLogs
        /// </summary>
        [AllowNull]
        public IList<LockDenialLog> LockDenialLogs { get => GetField(ref _lockDenialLogs); set => SetField(ref _lockDenialLogs, value); }

        /// <summary>
        /// Loan LockRemovedLogs
        /// </summary>
        [AllowNull]
        public IList<LockRemovedLog> LockRemovedLogs { get => GetField(ref _lockRemovedLogs); set => SetField(ref _lockRemovedLogs, value); }

        /// <summary>
        /// Loan LockRequestLogs
        /// </summary>
        [AllowNull]
        public IList<LockRequestLog> LockRequestLogs { get => GetField(ref _lockRequestLogs); set => SetField(ref _lockRequestLogs, value); }

        /// <summary>
        /// Loan LockVoidLogs
        /// </summary>
        [AllowNull]
        public IList<LockVoidLog> LockVoidLogs { get => GetField(ref _lockVoidLogs); set => SetField(ref _lockVoidLogs, value); }

        /// <summary>
        /// Loan LOCompensation
        /// </summary>
        [AllowNull]
        public ElliLOCompensation LOCompensation { get => GetField(ref _lOCompensation); set => SetField(ref _lOCompensation, value); }

        /// <summary>
        /// Loan LogEntryLogs
        /// </summary>
        [AllowNull]
        public IList<LogEntryLog> LogEntryLogs { get => GetField(ref _logEntryLogs); set => SetField(ref _logEntryLogs, value); }

        /// <summary>
        /// Constr Loan Info - Lot Acquired Date [URLA.X236]
        /// </summary>
        public DateTime? LotAcquiredDate { get => _lotAcquiredDate; set => SetField(ref _lotAcquiredDate, value); }

        /// <summary>
        /// Freddie Mac Loan To Value (LTV) [353]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

        /// <summary>
        /// Subject Property Value for LTV [358]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LtvPropertyValue { get => _ltvPropertyValue; set => SetField(ref _ltvPropertyValue, value); }

        /// <summary>
        /// Master Commitment Number [3908]
        /// </summary>
        public string? MasterCommitmentNumber { get => _masterCommitmentNumber; set => SetField(ref _masterCommitmentNumber, value); }

        /// <summary>
        /// Trans Details Loan Maturity Date [78]
        /// </summary>
        public DateTime? MaturityDate { get => _maturityDate; set => SetField(ref _maturityDate, value); }

        /// <summary>
        /// Prequal Qual Ratio Bottom [1791]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxBackRatio { get => _maxBackRatio; set => SetField(ref _maxBackRatio, value); }

        /// <summary>
        /// Prequal Qual Ratio Top [1790]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxFrontRatio { get => _maxFrontRatio; set => SetField(ref _maxFrontRatio, value); }

        /// <summary>
        /// Loan Mcaw
        /// </summary>
        [AllowNull]
        public Mcaw Mcaw { get => GetField(ref _mcaw); set => SetField(ref _mcaw, value); }

        /// <summary>
        /// Trans Details MERS MIN # [1051]
        /// </summary>
        public string? MersNumber { get => _mersNumber; set => SetField(ref _mersNumber, value); }

        /// <summary>
        /// Shipping MERS Registration Date [2023]
        /// </summary>
        public DateTime? MersNumberRegistrationDate { get => _mersNumberRegistrationDate; set => SetField(ref _mersNumberRegistrationDate, value); }

        /// <summary>
        /// MERS Organization ID [4722]
        /// </summary>
        public string? MersOrgId { get => _mersOrgId; set => SetField(ref _mersOrgId, value); }

        /// <summary>
        /// Trans Details PMI/MIP/FF Financed [1045]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => SetField(ref _miAndFundingFeeFinancedAmount, value); }

        /// <summary>
        /// Trans Details PMI/MIP/FF Amt [969]
        /// </summary>
        public decimal? MiAndFundingFeeTotalAmount { get => _miAndFundingFeeTotalAmount; set => SetField(ref _miAndFundingFeeTotalAmount, value); }

        /// <summary>
        /// Tracking - Approved Milestone Date [MS.APP]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneApprovedDate { get => _milestoneApprovedDate; set => SetField(ref _milestoneApprovedDate, value); }

        /// <summary>
        /// Tracking - Approved Milestone Due Date [MS.APP.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneApprovedDueDate { get => _milestoneApprovedDueDate; set => SetField(ref _milestoneApprovedDueDate, value); }

        /// <summary>
        /// Tracking - Completed Milestone Date [MS.CLO]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneCompletedDate { get => _milestoneCompletedDate; set => SetField(ref _milestoneCompletedDate, value); }

        /// <summary>
        /// Tracking - Completed Milestone Due Date [MS.CLO.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneCompletedDueDate { get => _milestoneCompletedDueDate; set => SetField(ref _milestoneCompletedDueDate, value); }

        /// <summary>
        /// Tracking - Current Milestone Date [MS.STATUSDATE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
        public DateTime? MilestoneCurrentDateUtc { get => _milestoneCurrentDateUtc; set => SetField(ref _milestoneCurrentDateUtc, value); }

        /// <summary>
        /// Tracking - Current Milestone Name [MS.STATUS]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<MilestoneCurrentName> MilestoneCurrentName { get => _milestoneCurrentName; set => SetField(ref _milestoneCurrentName, value); }

        /// <summary>
        /// Tracking - Doc Signed Milestone Date [MS.DOC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneDocSignedDate { get => _milestoneDocSignedDate; set => SetField(ref _milestoneDocSignedDate, value); }

        /// <summary>
        /// Tracking - Doc Signed Milestone Due Date [MS.DOC.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneDocSignedDueDate { get => _milestoneDocSignedDueDate; set => SetField(ref _milestoneDocSignedDueDate, value); }

        /// <summary>
        /// Tracking - Loan Milestone Duration [MS.LOANDURATION]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? MilestoneDuration { get => _milestoneDuration; set => SetField(ref _milestoneDuration, value); }

        /// <summary>
        /// Tracking - File Started Milestone Date [MS.START]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneFileStartedDate { get => _milestoneFileStartedDate; set => SetField(ref _milestoneFileStartedDate, value); }

        /// <summary>
        /// Loan MilestoneFreeRoleLogs
        /// </summary>
        [AllowNull]
        public IList<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get => GetField(ref _milestoneFreeRoleLogs); set => SetField(ref _milestoneFreeRoleLogs, value); }

        /// <summary>
        /// Tracking - Funded Milestone Date [MS.FUN]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneFundedDate { get => _milestoneFundedDate; set => SetField(ref _milestoneFundedDate, value); }

        /// <summary>
        /// Tracking - Funded Milestone Due Date [MS.FUN.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneFundedDueDate { get => _milestoneFundedDueDate; set => SetField(ref _milestoneFundedDueDate, value); }

        /// <summary>
        /// Loan MilestoneHistoryLogs
        /// </summary>
        [AllowNull]
        public IList<MilestoneHistoryLog> MilestoneHistoryLogs { get => GetField(ref _milestoneHistoryLogs); set => SetField(ref _milestoneHistoryLogs, value); }

        /// <summary>
        /// Loan MilestoneLogs
        /// </summary>
        [AllowNull]
        public IList<MilestoneLog> MilestoneLogs { get => GetField(ref _milestoneLogs); set => SetField(ref _milestoneLogs, value); }

        /// <summary>
        /// Tracking - Processed Milestone Date [MS.PROC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneProcessedDate { get => _milestoneProcessedDate; set => SetField(ref _milestoneProcessedDate, value); }

        /// <summary>
        /// Tracking - Milestone Stage [1601]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MilestoneStage { get => _milestoneStage; set => SetField(ref _milestoneStage, value); }

        /// <summary>
        /// Tracking - Submitted Milestone Date [MS.SUB]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneSubmittedDate { get => _milestoneSubmittedDate; set => SetField(ref _milestoneSubmittedDate, value); }

        /// <summary>
        /// Tracking - Submitted Milestone Due Date [MS.SUB.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MilestoneSubmittedDueDate { get => _milestoneSubmittedDueDate; set => SetField(ref _milestoneSubmittedDueDate, value); }

        /// <summary>
        /// Loan MilestoneTaskLogs
        /// </summary>
        [AllowNull]
        public IList<MilestoneTaskLog> MilestoneTaskLogs { get => GetField(ref _milestoneTaskLogs); set => SetField(ref _milestoneTaskLogs, value); }

        /// <summary>
        /// Loan MilestoneTemplateLogs
        /// </summary>
        [AllowNull]
        public IList<MilestoneTemplateLog> MilestoneTemplateLogs { get => GetField(ref _milestoneTemplateLogs); set => SetField(ref _milestoneTemplateLogs, value); }

        /// <summary>
        /// PMI Prepaid in Cash by Borrower [3033]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MipBorrowerPaidInCashAmount { get => _mipBorrowerPaidInCashAmount; set => SetField(ref _mipBorrowerPaidInCashAmount, value); }

        /// <summary>
        /// Expenses Calc MIP/PMI Amt Paid In Cash [1760]
        /// </summary>
        public decimal? MipPaidInCashAmount { get => _mipPaidInCashAmount; set => SetField(ref _mipPaidInCashAmount, value); }

        /// <summary>
        /// Loan Miscellaneous
        /// </summary>
        [AllowNull]
        public Miscellaneous Miscellaneous { get => GetField(ref _miscellaneous); set => SetField(ref _miscellaneous, value); }

        /// <summary>
        /// Loan MIServiceArchLogs
        /// </summary>
        [AllowNull]
        public IList<MIServiceArchLog> MIServiceArchLogs { get => GetField(ref _mIServiceArchLogs); set => SetField(ref _mIServiceArchLogs, value); }

        /// <summary>
        /// Loan MIServiceMgicLogs
        /// </summary>
        [AllowNull]
        public IList<MIServiceMgicLog> MIServiceMgicLogs { get => GetField(ref _mIServiceMgicLogs); set => SetField(ref _mIServiceMgicLogs, value); }

        /// <summary>
        /// Loan MIServiceRadianLogs
        /// </summary>
        [AllowNull]
        public IList<MIServiceRadianLog> MIServiceRadianLogs { get => GetField(ref _mIServiceRadianLogs); set => SetField(ref _mIServiceRadianLogs, value); }

        /// <summary>
        /// MERS Original Mortgagee (MOM) [4723]
        /// </summary>
        public bool? Mom { get => _mom; set => SetField(ref _mom, value); }

        /// <summary>
        /// Trans Details Monthly PI Payment Amount For LE1 and CD1 [4085]
        /// </summary>
        public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get => _monthlyPIPaymentAmountForLE1andCD1; set => SetField(ref _monthlyPIPaymentAmountForLE1andCD1, value); }

        /// <summary>
        /// Loan MortgageInsurancePremiumFHARefundAmount
        /// </summary>
        public decimal? MortgageInsurancePremiumFHARefundAmount { get => _mortgageInsurancePremiumFHARefundAmount; set => SetField(ref _mortgageInsurancePremiumFHARefundAmount, value); }

        /// <summary>
        /// Insurance Mtg Ins Upfront Factor [1107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => _mortgageInsurancePremiumUpfrontFactorPercent; set => SetField(ref _mortgageInsurancePremiumUpfrontFactorPercent, value); }

        /// <summary>
        /// Trans Details Loan Type [1172]
        /// </summary>
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

        /// <summary>
        /// Fannie Mae Metro Stat Area/County [MORNET.X26]
        /// </summary>
        public string? MsaIdentifier { get => _msaIdentifier; set => SetField(ref _msaIdentifier, value); }

        /// <summary>
        /// Trust Classification Type [URLA.X141]
        /// </summary>
        public StringEnumValue<NativeAmericanLandsType> NativeAmericanLandsType { get => _nativeAmericanLandsType; set => SetField(ref _nativeAmericanLandsType, value); }

        /// <summary>
        /// Native American Lands Type Other Description [URLA.X142]
        /// </summary>
        public StringEnumValue<NativeAmericanLandsTypeOtherDescription> NativeAmericanLandsTypeOtherDescription { get => _nativeAmericanLandsTypeOtherDescription; set => SetField(ref _nativeAmericanLandsTypeOtherDescription, value); }

        /// <summary>
        /// Negative Amortization Indicator [URLA.X239]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Negative Amortization\"}")]
        public bool? NegativeAmortization { get => _negativeAmortization; set => SetField(ref _negativeAmortization, value); }

        /// <summary>
        /// Loan NetTangibleBenefit
        /// </summary>
        [AllowNull]
        public NetTangibleBenefit NetTangibleBenefit { get => GetField(ref _netTangibleBenefit); set => SetField(ref _netTangibleBenefit, value); }

        /// <summary>
        /// Trans Details New First Mtg [1845]
        /// </summary>
        public decimal? NewFirstMortgageAmount { get => _newFirstMortgageAmount; set => SetField(ref _newFirstMortgageAmount, value); }

        /// <summary>
        /// URLA Loan originator last name [URLA.X186]
        /// </summary>
        public string? NewHELOCCreditorName { get => _newHELOCCreditorName; set => SetField(ref _newHELOCCreditorName, value); }

        /// <summary>
        /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X187]
        /// </summary>
        public decimal? NewHELOCMonthlyPayment { get => _newHELOCMonthlyPayment; set => SetField(ref _newHELOCMonthlyPayment, value); }

        /// <summary>
        /// URLA First New Mortgage Creditor Name [URLA.X182]
        /// </summary>
        public string? NewMortgageCreditorName { get => _newMortgageCreditorName; set => SetField(ref _newMortgageCreditorName, value); }

        /// <summary>
        /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X183]
        /// </summary>
        public decimal? NewMortgageMonthlyPayment { get => _newMortgageMonthlyPayment; set => SetField(ref _newMortgageMonthlyPayment, value); }

        /// <summary>
        /// URLA Loan originator last name [URLA.X184]
        /// </summary>
        public string? NewSubordinateCreditorName { get => _newSubordinateCreditorName; set => SetField(ref _newSubordinateCreditorName, value); }

        /// <summary>
        /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X185]
        /// </summary>
        public decimal? NewSubordinateMonthlyPayment { get => _newSubordinateMonthlyPayment; set => SetField(ref _newSubordinateMonthlyPayment, value); }

        /// <summary>
        /// NMLS Loan Originator ID [3238]
        /// </summary>
        public string? NmlsLoanOriginatorId { get => _nmlsLoanOriginatorId; set => SetField(ref _nmlsLoanOriginatorId, value); }

        /// <summary>
        /// Rate Lock No Closing Cost Option [3891]
        /// </summary>
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => SetField(ref _noClosingCostOption, value); }

        /// <summary>
        /// Loan NonBorrowingOwners
        /// </summary>
        [AllowNull]
        public IList<NonBorrowingOwner> NonBorrowingOwners { get => GetField(ref _nonBorrowingOwners); set => SetField(ref _nonBorrowingOwners, value); }

        /// <summary>
        /// Loan NonVols
        /// </summary>
        [AllowNull]
        public IList<NonVol> NonVols { get => GetField(ref _nonVols); set => SetField(ref _nonVols, value); }

        /// <summary>
        /// Property is not located in a project Indicator [URLA.X208]
        /// </summary>
        public bool? NotInProjectIndicator { get => _notInProjectIndicator; set => SetField(ref _notInProjectIndicator, value); }

        /// <summary>
        /// Disclosure Purchase Sale or Refi [AFF.X6]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"purchase, sale, or refinance of, the subject property.\"}")]
        public bool? NotRequiredForPurchaseSaleOrRefinance { get => _notRequiredForPurchaseSaleOrRefinance; set => SetField(ref _notRequiredForPurchaseSaleOrRefinance, value); }

        /// <summary>
        /// Disclosure Settlement of Loan [AFF.X5]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"settlement of your loan on,\"}")]
        public bool? NotRequiredForSettlementOfYourLoan { get => _notRequiredForSettlementOfYourLoan; set => SetField(ref _notRequiredForSettlementOfYourLoan, value); }

        /// <summary>
        /// Occupancy Type [3335]
        /// </summary>
        public StringEnumValue<OccupancyType> OccupancyType { get => _occupancyType; set => SetField(ref _occupancyType, value); }

        /// <summary>
        /// Disclosures - Investor Code [Opening.InvCd]
        /// </summary>
        public string? OpeningDocsInvestorCode { get => _openingDocsInvestorCode; set => SetField(ref _openingDocsInvestorCode, value); }

        /// <summary>
        /// Disclosures - Plan Code Type [Opening.LoanProgTyp]
        /// </summary>
        public StringEnumValue<DocsLoanProgramType> OpeningDocsLoanProgramType { get => _openingDocsLoanProgramType; set => SetField(ref _openingDocsLoanProgramType, value); }

        /// <summary>
        /// Disclosures - Plan Description [Opening.PlanDesc]
        /// </summary>
        public string? OpeningDocsPlanDescription { get => _openingDocsPlanDescription; set => SetField(ref _openingDocsPlanDescription, value); }

        /// <summary>
        /// Disclosures - Ellie Mae Plan ID [Opening.PlanID]
        /// </summary>
        public string? OpeningDocsPlanId { get => _openingDocsPlanId; set => SetField(ref _openingDocsPlanId, value); }

        /// <summary>
        /// Disclosures - Program Code [Opening.ProgCd]
        /// </summary>
        public string? OpeningDocsProgramCode { get => _openingDocsProgramCode; set => SetField(ref _openingDocsProgramCode, value); }

        /// <summary>
        /// Opening Document Stacking Order [Opening.DocStkOrdr]
        /// </summary>
        public string? OpeningDocsStackingOrder { get => _openingDocsStackingOrder; set => SetField(ref _openingDocsStackingOrder, value); }

        /// <summary>
        /// Company - Users Organization Code [ORGID]
        /// </summary>
        public string? OrganizationCode { get => _organizationCode; set => SetField(ref _organizationCode, value); }

        /// <summary>
        /// Trans Details Application Date [745]
        /// </summary>
        public DateTime? OriginationDate { get => _originationDate; set => SetField(ref _originationDate, value); }

        /// <summary>
        /// Loan Originator Address Line Text [URLA.X188]
        /// </summary>
        public string? OriginatorAddressLineText { get => _originatorAddressLineText; set => SetField(ref _originatorAddressLineText, value); }

        /// <summary>
        /// Loan Originator Unit Type Identifier [URLA.X189]
        /// </summary>
        public StringEnumValue<UnitType> OriginatorAddressUnitDesignatorType { get => _originatorAddressUnitDesignatorType; set => SetField(ref _originatorAddressUnitDesignatorType, value); }

        /// <summary>
        /// Loan Originator Address Unit Identifier [URLA.X190]
        /// </summary>
        public string? OriginatorAddressUnitIdentifier { get => _originatorAddressUnitIdentifier; set => SetField(ref _originatorAddressUnitIdentifier, value); }

        /// <summary>
        /// URLA Loan Originator first name [URLA.X170]
        /// </summary>
        public string? OriginatorFirstName { get => _originatorFirstName; set => SetField(ref _originatorFirstName, value); }

        /// <summary>
        /// URLA Loan originator last name [URLA.X172]
        /// </summary>
        public string? OriginatorLastName { get => _originatorLastName; set => SetField(ref _originatorLastName, value); }

        /// <summary>
        /// URLA Loan originator middle name [URLA.X171]
        /// </summary>
        public string? OriginatorMiddleName { get => _originatorMiddleName; set => SetField(ref _originatorMiddleName, value); }

        /// <summary>
        /// URLA Loan originator suffix name [URLA.X173]
        /// </summary>
        public string? OriginatorSuffixName { get => _originatorSuffixName; set => SetField(ref _originatorSuffixName, value); }

        /// <summary>
        /// Trans Details Amort Type Other Descr [994]
        /// </summary>
        public string? OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }

        /// <summary>
        /// Trans Details Loan Type Other [1063]
        /// </summary>
        public string? OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => SetField(ref _otherMortgageTypeDescription, value); }

        /// <summary>
        /// Fees Total Closing Costs Other [OTHPCC]
        /// </summary>
        public decimal? OtherPaidClosingCostsAmount { get => _otherPaidClosingCostsAmount; set => SetField(ref _otherPaidClosingCostsAmount, value); }

        /// <summary>
        /// Trans Details Overwire Amount [2005]
        /// </summary>
        public decimal? OverwireAmount { get => _overwireAmount; set => SetField(ref _overwireAmount, value); }

        /// <summary>
        /// Ownership Completed Date [URLA.X157]
        /// </summary>
        public DateTime? OwnershipCompletedDate { get => _ownershipCompletedDate; set => SetField(ref _ownershipCompletedDate, value); }

        /// <summary>
        /// PACE Loan Payoff Amount [4786]
        /// </summary>
        public decimal? PaceLoanPayoffAmount { get => _paceLoanPayoffAmount; set => SetField(ref _paceLoanPayoffAmount, value); }

        /// <summary>
        ///  Payment Deferred for First Five Years Indicator [URLA.X209]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment Deferred for First Five Years\"}")]
        public bool? PaymentDeferredFirstFiveYears { get => _paymentDeferredFirstFiveYears; set => SetField(ref _paymentDeferredFirstFiveYears, value); }

        /// <summary>
        /// Payment Schedule Calculation is Required [CALCREQUIRED]
        /// </summary>
        public bool? PaymentScheduleCalcRequiredIndicator { get => _paymentScheduleCalcRequiredIndicator; set => SetField(ref _paymentScheduleCalcRequiredIndicator, value); }

        /// <summary>
        /// Disclosure Bus Affiliate Relationship/% [AFF.X3]
        /// </summary>
        public string? PercentageOfOwnership { get => _percentageOfOwnership; set => SetField(ref _percentageOfOwnership, value); }

        /// <summary>
        /// The Percentage of Ownership Interest is [AFF.X32]
        /// </summary>
        public decimal? PercentageOwnershipInterest { get => _percentageOwnershipInterest; set => SetField(ref _percentageOwnershipInterest, value); }

        /// <summary>
        /// Private Mortgage Insurance Indicator [3336]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"PMI Included\",\"N\":\"PMI Not Included\"}")]
        public bool? PmiIndicator { get => _pmiIndicator; set => SetField(ref _pmiIndicator, value); }

        /// <summary>
        /// Loan PostClosingConditionLogs
        /// </summary>
        [AllowNull]
        public IList<PostClosingConditionLog> PostClosingConditionLogs { get => GetField(ref _postClosingConditionLogs); set => SetField(ref _postClosingConditionLogs, value); }

        /// <summary>
        /// Loan PreliminaryConditionLogs
        /// </summary>
        [AllowNull]
        public IList<PreliminaryConditionLog> PreliminaryConditionLogs { get => GetField(ref _preliminaryConditionLogs); set => SetField(ref _preliminaryConditionLogs, value); }

        /// <summary>
        /// Undefined [URLA.X240]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prepayment Penalty / Prepayment Penalty Term\"}")]
        public bool? PrepaymentPenaltyTerm { get => _prepaymentPenaltyTerm; set => SetField(ref _prepaymentPenaltyTerm, value); }

        /// <summary>
        /// Loan Prequalification
        /// </summary>
        [AllowNull]
        public Prequalification Prequalification { get => GetField(ref _prequalification); set => SetField(ref _prequalification, value); }

        /// <summary>
        /// Trans Details Mo Pymt (P&amp;I) [5]
        /// </summary>
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => _principalAndInterestMonthlyPaymentAmount; set => SetField(ref _principalAndInterestMonthlyPaymentAmount, value); }

        /// <summary>
        /// Trans Details Print 2003 Appl [1825]
        /// </summary>
        public StringEnumValue<Print2003Application> Print2003Application { get => _print2003Application; set => SetField(ref _print2003Application, value); }

        /// <summary>
        /// PrintLenderPages [URLA.X231]
        /// </summary>
        public bool? PrintLenderPages { get => _printLenderPages; set => SetField(ref _printLenderPages, value); }

        /// <summary>
        /// Loan PrintLogs
        /// </summary>
        [AllowNull]
        public IList<PrintLog> PrintLogs { get => GetField(ref _printLogs); set => SetField(ref _printLogs, value); }

        /// <summary>
        /// Print both ULI / NULI and Loan Number [URLA.X238]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print both ULI / NULI and Loan Number\"}")]
        public bool? PrintULIAndLoanNoURLA { get => _printULIAndLoanNoURLA; set => SetField(ref _printULIAndLoanNoURLA, value); }

        /// <summary>
        /// Print ULI on URLA [URLA.X119]
        /// </summary>
        public bool? PrintULIonURLA { get => _printULIonURLA; set => SetField(ref _printULIonURLA, value); }

        /// <summary>
        /// Loan PrivacyPolicy
        /// </summary>
        [AllowNull]
        public PrivacyPolicy PrivacyPolicy { get => GetField(ref _privacyPolicy); set => SetField(ref _privacyPolicy, value); }

        /// <summary>
        /// Product Description [URLA.X143]
        /// </summary>
        public string? ProductDescription { get => _productDescription; set => SetField(ref _productDescription, value); }

        /// <summary>
        /// Loan ProfitManagement
        /// </summary>
        [AllowNull]
        public ProfitManagement ProfitManagement { get => GetField(ref _profitManagement); set => SetField(ref _profitManagement, value); }

        /// <summary>
        /// Government Refinance Type [URLA.X168]
        /// </summary>
        public StringEnumValue<ProjectLegalStructureType> ProjectLegalStructureType { get => _projectLegalStructureType; set => SetField(ref _projectLegalStructureType, value); }

        /// <summary>
        /// Loan Property
        /// </summary>
        [AllowNull]
        public Property Property { get => GetField(ref _property); set => SetField(ref _property, value); }

        /// <summary>
        /// Subject Property Appraised Value [356]
        /// </summary>
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => SetField(ref _propertyAppraisedValueAmount, value); }

        /// <summary>
        /// Fannie Mae Energy Effic Mtg Indicator [157]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Energy Efficient Mortgage\"}")]
        public bool? PropertyEnergyEfficientHomeIndicator { get => _propertyEnergyEfficientHomeIndicator; set => SetField(ref _propertyEnergyEfficientHomeIndicator, value); }

        /// <summary>
        /// Subject Property Est Value [1821]
        /// </summary>
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => SetField(ref _propertyEstimatedValueAmount, value); }

        /// <summary>
        /// Property Existing Clean Energy Lien Indicator [URLA.X135]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Property is currently subject to a lien that could take priority over the first mortgage lien, such as a clean energy lien paid through property taxes (e.g., the Property Assessed  Clean Energy program).\"}")]
        public bool? PropertyExistingCleanEnergyLienIndicator { get => _propertyExistingCleanEnergyLienIndicator; set => SetField(ref _propertyExistingCleanEnergyLienIndicator, value); }

        /// <summary>
        /// Loan PropertyValuations
        /// </summary>
        [AllowNull]
        public IList<PropertyValuation> PropertyValuations { get => GetField(ref _propertyValuations); set => SetField(ref _propertyValuations, value); }

        /// <summary>
        /// Expenses Proposed HOA [233]
        /// </summary>
        public string? ProposedDuesAmount { get => _proposedDuesAmount; set => SetField(ref _proposedDuesAmount, value); }

        /// <summary>
        /// Expenses Proposed Mtg Pymt [228]
        /// </summary>
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => SetField(ref _proposedFirstMortgageAmount, value); }

        /// <summary>
        /// Loan ProposedGroundRentAmount
        /// </summary>
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => SetField(ref _proposedGroundRentAmount, value); }

        /// <summary>
        /// Expenses Proposed Haz Ins [230]
        /// </summary>
        public string? ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => SetField(ref _proposedHazardInsuranceAmount, value); }

        /// <summary>
        /// Expenses Proposed Total Housing [912]
        /// </summary>
        public decimal? ProposedHousingExpenseTotal { get => _proposedHousingExpenseTotal; set => SetField(ref _proposedHousingExpenseTotal, value); }

        /// <summary>
        /// Expenses Proposed Mtg Ins [232]
        /// </summary>
        public string? ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => SetField(ref _proposedMortgageInsuranceAmount, value); }

        /// <summary>
        /// Expenses Proposed Other Housing [234]
        /// </summary>
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => SetField(ref _proposedOtherAmount, value); }

        /// <summary>
        /// Expenses Proposed Other Pymt [229]
        /// </summary>
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => SetField(ref _proposedOtherMortgagesAmount, value); }

        /// <summary>
        /// Expenses Proposed Taxes [1405]
        /// </summary>
        public string? ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => SetField(ref _proposedRealEstateTaxesAmount, value); }

        /// <summary>
        /// Planned Unit Development Project Type Indicator [URLA.X207]
        /// </summary>
        public bool? PUDIndicator { get => _pUDIndicator; set => SetField(ref _pUDIndicator, value); }

        /// <summary>
        /// Loan PurchaseConditionLogs
        /// </summary>
        [AllowNull]
        public IList<PurchaseConditionLog> PurchaseConditionLogs { get => GetField(ref _purchaseConditionLogs); set => SetField(ref _purchaseConditionLogs, value); }

        /// <summary>
        /// Loan PurchaseCredits
        /// </summary>
        [AllowNull]
        public IList<PurchaseCredit> PurchaseCredits { get => GetField(ref _purchaseCredits); set => SetField(ref _purchaseCredits, value); }

        /// <summary>
        /// Trans Details Purchase Price [136]
        /// </summary>
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => SetField(ref _purchasePriceAmount, value); }

        /// <summary>
        /// Loan RateLock
        /// </summary>
        [AllowNull]
        public RateLock RateLock { get => GetField(ref _rateLock); set => SetField(ref _rateLock, value); }

        /// <summary>
        /// File Contacts Referral Addr [1830]
        /// </summary>
        public string? ReferralAddress { get => _referralAddress; set => SetField(ref _referralAddress, value); }

        /// <summary>
        /// File Contacts Referral City [1831]
        /// </summary>
        public string? ReferralCity { get => _referralCity; set => SetField(ref _referralCity, value); }

        /// <summary>
        /// File Contacts Referral Fee [1834]
        /// </summary>
        public decimal? ReferralFeeAmount { get => _referralFeeAmount; set => SetField(ref _referralFeeAmount, value); }

        /// <summary>
        /// File Contacts Referral Zip [1833]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? ReferralPostalCode { get => _referralPostalCode; set => SetField(ref _referralPostalCode, value); }

        /// <summary>
        /// File Contacts Referral Name [1822]
        /// </summary>
        public string? ReferralSource { get => _referralSource; set => SetField(ref _referralSource, value); }

        /// <summary>
        /// Loan ReferralSourceContact
        /// </summary>
        public EntityReference? ReferralSourceContact { get => _referralSourceContact; set => SetField(ref _referralSourceContact, value); }

        /// <summary>
        /// File Contacts Referral State [1832]
        /// </summary>
        public StringEnumValue<State> ReferralState { get => _referralState; set => SetField(ref _referralState, value); }

        /// <summary>
        /// Refinance Cash Out Determination Type [URLA.X165]
        /// </summary>
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => _refinanceCashOutDeterminationType; set => SetField(ref _refinanceCashOutDeterminationType, value); }

        /// <summary>
        /// Trans Details Refinance [1092]
        /// </summary>
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get => _refinanceIncludingDebtsToBePaidOffAmount; set => SetField(ref _refinanceIncludingDebtsToBePaidOffAmount, value); }

        /// <summary>
        /// Loan RegistrationLogs
        /// </summary>
        [AllowNull]
        public IList<RegistrationLog> RegistrationLogs { get => GetField(ref _registrationLogs); set => SetField(ref _registrationLogs, value); }

        /// <summary>
        /// Loan RegulationZ
        /// </summary>
        [AllowNull]
        public RegulationZ RegulationZ { get => GetField(ref _regulationZ); set => SetField(ref _regulationZ, value); }

        /// <summary>
        /// Relationship Vesting Type [URLA.X138]
        /// </summary>
        public StringEnumValue<RelationshipVestingType> RelationshipVestingType { get => _relationshipVestingType; set => SetField(ref _relationshipVestingType, value); }

        /// <summary>
        /// Relationship Vesting Type Other Description [URLA.X139]
        /// </summary>
        public string? RelationshipVestingTypeOtherDescription { get => _relationshipVestingTypeOtherDescription; set => SetField(ref _relationshipVestingTypeOtherDescription, value); }

        /// <summary>
        /// Loan RemovedLogRecords
        /// </summary>
        [AllowNull]
        public IList<RemovedLogRecord> RemovedLogRecords { get => GetField(ref _removedLogRecords); set => SetField(ref _removedLogRecords, value); }

        /// <summary>
        /// Renovation Loan Indicator [URLA.X132]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Renovation\"}")]
        public bool? RenovationLoanIndicator { get => _renovationLoanIndicator; set => SetField(ref _renovationLoanIndicator, value); }

        /// <summary>
        /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X81]
        /// </summary>
        public decimal? RentalEstimatedNetMonthlyRentAmount { get => _rentalEstimatedNetMonthlyRentAmount; set => SetField(ref _rentalEstimatedNetMonthlyRentAmount, value); }

        /// <summary>
        /// 4c. Rental Income onthe Property You want to Purchase - For Purchase Only Does not Apply [URLA.X80]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
        public bool? RentalIncomeSectionIndicator { get => _rentalIncomeSectionIndicator; set => SetField(ref _rentalIncomeSectionIndicator, value); }

        /// <summary>
        /// Repurchase Cost [3313]
        /// </summary>
        public decimal? RepurchaseCostAmount { get => _repurchaseCostAmount; set => SetField(ref _repurchaseCostAmount, value); }

        /// <summary>
        /// Repurchase Date [3312]
        /// </summary>
        public DateTime? RepurchaseDate { get => _repurchaseDate; set => SetField(ref _repurchaseDate, value); }

        /// <summary>
        /// Trans Details Interest Rate [3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => SetField(ref _requestedInterestRatePercent, value); }

        /// <summary>
        /// Trans Details Interest Rate - Display field with KBYO rounding rules [KBYO.XD3]
        /// </summary>
        public string? RequestedInterestRatePercentUI { get => _requestedInterestRatePercentUI; set => SetField(ref _requestedInterestRatePercentUI, value); }

        /// <summary>
        /// Fannie Mae Seller Concessions [MORNET.X71]
        /// </summary>
        public decimal? SalesConcessionAmount { get => _salesConcessionAmount; set => SetField(ref _salesConcessionAmount, value); }

        /// <summary>
        /// Trans Details Sub Fin Second Mtg Loan Amt [428]
        /// </summary>
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => SetField(ref _secondSubordinateAmount, value); }

        /// <summary>
        /// Loan Section32
        /// </summary>
        [AllowNull]
        public Section32 Section32 { get => GetField(ref _section32); set => SetField(ref _section32, value); }

        /// <summary>
        /// Loan Info Section of Housing Act [1039]
        /// </summary>
        public StringEnumValue<SectionOfActType> SectionOfActType { get => _sectionOfActType; set => SetField(ref _sectionOfActType, value); }

        /// <summary>
        /// Loan SelectedHomeCounselingProvider
        /// </summary>
        [AllowNull]
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get => GetField(ref _selectedHomeCounselingProvider); set => SetField(ref _selectedHomeCounselingProvider, value); }

        /// <summary>
        /// Loan SellConditionLogs
        /// </summary>
        [AllowNull]
        public IList<SellConditionLog> SellConditionLogs { get => GetField(ref _sellConditionLogs); set => SetField(ref _sellConditionLogs, value); }

        /// <summary>
        /// Fees Total Closing Costs Seller [143]
        /// </summary>
        public decimal? SellerPaidClosingCostsAmount { get => _sellerPaidClosingCostsAmount; set => SetField(ref _sellerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Server Date Time DDM Applied [DMDDM.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
        public DateTime? ServerDateTimeDDMApplied { get => _serverDateTimeDDMApplied; set => SetField(ref _serverDateTimeDDMApplied, value); }

        /// <summary>
        /// Settlement Service Provided - Additional Information [SP.ADDITIONALINFO]
        /// </summary>
        public string? ServiceProviderAdditionalInfo { get => _serviceProviderAdditionalInfo; set => SetField(ref _serviceProviderAdditionalInfo, value); }

        /// <summary>
        /// Loan ServiceProviderContacts
        /// </summary>
        [AllowNull]
        public IList<ServiceProviderContact> ServiceProviderContacts { get => GetField(ref _serviceProviderContacts); set => SetField(ref _serviceProviderContacts, value); }

        /// <summary>
        /// Settlement Service Provided - Date Issued [SP.DATEISSUED]
        /// </summary>
        public DateTime? ServiceProviderDateIssued { get => _serviceProviderDateIssued; set => SetField(ref _serviceProviderDateIssued, value); }

        /// <summary>
        /// Loan ServicingDisclosure
        /// </summary>
        [AllowNull]
        public ServicingDisclosure ServicingDisclosure { get => GetField(ref _servicingDisclosure); set => SetField(ref _servicingDisclosure, value); }

        /// <summary>
        /// Loan ServicingPrintLogs
        /// </summary>
        [AllowNull]
        public IList<ServicingPrintLog> ServicingPrintLogs { get => GetField(ref _servicingPrintLogs); set => SetField(ref _servicingPrintLogs, value); }

        /// <summary>
        /// Disclosure Required to Use Listed Provider [AFF.X31]
        /// </summary>
        public bool? SetForSettlementServicesOfAnAttorney { get => _setForSettlementServicesOfAnAttorney; set => SetField(ref _setForSettlementServicesOfAnAttorney, value); }

        /// <summary>
        /// Disclosure Not required to Use Listed Provider [AFF.X4]
        /// </summary>
        public bool? SetForTheSettlementServicesListed { get => _setForTheSettlementServicesListed; set => SetField(ref _setForTheSettlementServicesListed, value); }

        /// <summary>
        /// Settlement Agent Disbursed Funds Date [4724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SettlementAgentDisbursedFundsDate { get => _settlementAgentDisbursedFundsDate; set => SetField(ref _settlementAgentDisbursedFundsDate, value); }

        /// <summary>
        /// Loan SettlementServiceCharges
        /// </summary>
        [AllowNull]
        public IList<SettlementServiceCharge> SettlementServiceCharges { get => GetField(ref _settlementServiceCharges); set => SetField(ref _settlementServiceCharges, value); }

        /// <summary>
        /// Loan Shipping
        /// </summary>
        [AllowNull]
        public Shipping Shipping { get => GetField(ref _shipping); set => SetField(ref _shipping, value); }

        /// <summary>
        /// Simple Refinance (FHA to FHA) [MORNET.X41]
        /// </summary>
        public bool? SimpleRefinanceType { get => _simpleRefinanceType; set => SetField(ref _simpleRefinanceType, value); }

        /// <summary>
        /// Loan SourceEntityUrn
        /// </summary>
        public string? SourceEntityUrn { get => _sourceEntityUrn; set => SetField(ref _sourceEntityUrn, value); }

        /// <summary>
        /// Loan SpecialFeatureCodes
        /// </summary>
        [AllowNull]
        public IList<SpecialFeatureCode> SpecialFeatureCodes { get => GetField(ref _specialFeatureCodes); set => SetField(ref _specialFeatureCodes, value); }

        /// <summary>
        /// Loan StartingAdjPrice
        /// </summary>
        public decimal? StartingAdjPrice { get => _startingAdjPrice; set => SetField(ref _startingAdjPrice, value); }

        /// <summary>
        /// Loan StartingAdjRate
        /// </summary>
        public decimal? StartingAdjRate { get => _startingAdjRate; set => SetField(ref _startingAdjRate, value); }

        /// <summary>
        /// Loan StateDisclosure
        /// </summary>
        [AllowNull]
        public StateDisclosure StateDisclosure { get => GetField(ref _stateDisclosure); set => SetField(ref _stateDisclosure, value); }

        /// <summary>
        /// Loan StatementCreditDenial
        /// </summary>
        [AllowNull]
        public StatementCreditDenial StatementCreditDenial { get => GetField(ref _statementCreditDenial); set => SetField(ref _statementCreditDenial, value); }

        /// <summary>
        /// Loan StatusOnlineLogs
        /// </summary>
        [AllowNull]
        public IList<StatusOnlineLog> StatusOnlineLogs { get => GetField(ref _statusOnlineLogs); set => SetField(ref _statusOnlineLogs, value); }

        /// <summary>
        /// Subject Property Gross Rent [1005]
        /// </summary>
        public decimal? SubjectPropertyGrossRentalIncomeAmount { get => _subjectPropertyGrossRentalIncomeAmount; set => SetField(ref _subjectPropertyGrossRentalIncomeAmount, value); }

        /// <summary>
        /// Subject Property Occupancy Rate [1487]
        /// </summary>
        public decimal? SubjectPropertyOccupancyPercent { get => _subjectPropertyOccupancyPercent; set => SetField(ref _subjectPropertyOccupancyPercent, value); }

        /// <summary>
        /// Trans Details Subordinate Financing [140]
        /// </summary>
        public decimal? SubordinateLienAmount { get => _subordinateLienAmount; set => SetField(ref _subordinateLienAmount, value); }

        /// <summary>
        /// Proposed Supplemental Property Insurance Amount [URLA.X144]
        /// </summary>
        public decimal? SupplementalPropertyInsuranceAmount { get => _supplementalPropertyInsuranceAmount; set => SetField(ref _supplementalPropertyInsuranceAmount, value); }

        /// <summary>
        /// LE Latest Guid [SYS.X610]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SystemIdGuid { get => _systemIdGuid; set => SetField(ref _systemIdGuid, value); }

        /// <summary>
        /// Target CLTV [4523]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? TargetCLTV { get => _targetCLTV; set => SetField(ref _targetCLTV, value); }

        /// <summary>
        /// Target HCLTV [4524]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? TargetHCLTV { get => _targetHCLTV; set => SetField(ref _targetHCLTV, value); }

        /// <summary>
        /// Loan TargetTradeLogs
        /// </summary>
        [AllowNull]
        public IList<TargetTradeLog> TargetTradeLogs { get => GetField(ref _targetTradeLogs); set => SetField(ref _targetTradeLogs, value); }

        /// <summary>
        /// Temporary Buydown [4645]
        /// </summary>
        public string? TemporaryBuydown { get => _temporaryBuydown; set => SetField(ref _temporaryBuydown, value); }

        /// <summary>
        /// Temporary Interest Rate Buydown/Initial Buydown Rate [URLA.X241]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Temporary Interest Rate Buydown/Initial Buydown Rate\"}")]
        public bool? TemporaryOrInitialInterestRateBuydown { get => _temporaryOrInitialInterestRateBuydown; set => SetField(ref _temporaryOrInitialInterestRateBuydown, value); }

        /// <summary>
        /// TIL Application Date [3292]
        /// </summary>
        public DateTime? TilApplicationDate { get => _tilApplicationDate; set => SetField(ref _tilApplicationDate, value); }

        /// <summary>
        /// Title Full Name [URLA.X137]
        /// </summary>
        public string? TitleHolderFullName { get => _titleHolderFullName; set => SetField(ref _titleHolderFullName, value); }

        /// <summary>
        /// Subject Property Title Name 1 [31]
        /// </summary>
        public string? TitleHolderName1 { get => _titleHolderName1; set => SetField(ref _titleHolderName1, value); }

        /// <summary>
        /// Subject Property Title Name 2 [1602]
        /// </summary>
        public string? TitleHolderName2 { get => _titleHolderName2; set => SetField(ref _titleHolderName2, value); }

        /// <summary>
        /// Title Will Be Full Name [URLA.X136]
        /// </summary>
        public string? TitleWillBeFullName { get => _titleWillBeFullName; set => SetField(ref _titleWillBeFullName, value); }

        /// <summary>
        /// Freddie Mac Total Loan to Value (TLTV) [975]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Tltv { get => _tltv; set => SetField(ref _tltv, value); }

        /// <summary>
        /// Total Additional Mortgages [URLA.X211]
        /// </summary>
        public decimal? TotalAdditionalMortgages { get => _totalAdditionalMortgages; set => SetField(ref _totalAdditionalMortgages, value); }

        /// <summary>
        /// Fees Total Closing Costs [TOTPCC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalClosingCostsAmount { get => _totalClosingCostsAmount; set => SetField(ref _totalClosingCostsAmount, value); }

        /// <summary>
        /// Trans Details Total Deductions [1989]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalDeductionsAmount { get => _totalDeductionsAmount; set => SetField(ref _totalDeductionsAmount, value); }

        /// <summary>
        /// Fees Total Costs [1073]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalFeesCostAmount { get => _totalFeesCostAmount; set => SetField(ref _totalFeesCostAmount, value); }

        /// <summary>
        /// Fees Total Credits [1844]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalFeesCreditAmount { get => _totalFeesCreditAmount; set => SetField(ref _totalFeesCreditAmount, value); }

        /// <summary>
        /// Fees Total Closing Costs Non-Borr [TNBPCC]
        /// </summary>
        public decimal? TotalNonborrowerPaidClosingCostsAmount { get => _totalNonborrowerPaidClosingCostsAmount; set => SetField(ref _totalNonborrowerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Total Non Subject Property Debts ToBe Paid Off Amount [URLA.X145]
        /// </summary>
        public decimal? TotalNonSubjectPropertyDebtsToBePaidOffAmount { get => _totalNonSubjectPropertyDebtsToBePaidOffAmount; set => SetField(ref _totalNonSubjectPropertyDebtsToBePaidOffAmount, value); }

        /// <summary>
        /// URLA Total Total Of Gifts Grants [URLA.X150]
        /// </summary>
        public decimal? TotalOfGiftsGrants { get => _totalOfGiftsGrants; set => SetField(ref _totalOfGiftsGrants, value); }

        /// <summary>
        /// URLA Total Total Other Asset To Loan [URLA.X151]
        /// </summary>
        public decimal? TotalOtherAssetToLoan { get => _totalOtherAssetToLoan; set => SetField(ref _totalOtherAssetToLoan, value); }

        /// <summary>
        /// Fees Total Paid Outside of Closing (Oth Summaries) [TOTPOC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPaidOutsideClosingAmount { get => _totalPaidOutsideClosingAmount; set => SetField(ref _totalPaidOutsideClosingAmount, value); }

        /// <summary>
        /// Trans Details Total Paid To [1988]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPaidToBrokerAmount { get => _totalPaidToBrokerAmount; set => SetField(ref _totalPaidToBrokerAmount, value); }

        /// <summary>
        /// Total Subordinate Financing Amount [URLA.X147]
        /// </summary>
        public decimal? TotalSubordinateFinancingAmount { get => _totalSubordinateFinancingAmount; set => SetField(ref _totalSubordinateFinancingAmount, value); }

        /// <summary>
        /// Trans Details Total Wire Transfer [1990]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalWireTransferAmount { get => _totalWireTransferAmount; set => SetField(ref _totalWireTransferAmount, value); }

        /// <summary>
        /// Loan TPO
        /// </summary>
        [AllowNull]
        public TPO TPO { get => GetField(ref _tPO); set => SetField(ref _tPO, value); }

        /// <summary>
        /// Flag to indicate TPO Migration process is done [TPO_MIGRATION]
        /// </summary>
        public bool? TPOMigrationDone { get => _tPOMigrationDone; set => SetField(ref _tPOMigrationDone, value); }

        /// <summary>
        /// Loan TQL
        /// </summary>
        [AllowNull]
        public TQL TQL { get => GetField(ref _tQL); set => SetField(ref _tQL, value); }

        /// <summary>
        /// Loan TrustAccount
        /// </summary>
        [AllowNull]
        public TrustAccount TrustAccount { get => GetField(ref _trustAccount); set => SetField(ref _trustAccount, value); }

        /// <summary>
        /// Trust Classification Type [URLA.X140]
        /// </summary>
        public StringEnumValue<TrustClassificationType> TrustClassificationType { get => _trustClassificationType; set => SetField(ref _trustClassificationType, value); }

        /// <summary>
        /// Loan Tsum
        /// </summary>
        [AllowNull]
        public Tsum Tsum { get => GetField(ref _tsum); set => SetField(ref _tsum, value); }

        /// <summary>
        /// Borrower Can Demonstrate 12-Month Mortgage/Rental History [3515]
        /// </summary>
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => SetField(ref _twelveMonthMortgageRentalHistoryIndicator, value); }

        /// <summary>
        /// UCD Case File ID [4486]
        /// </summary>
        public string? UCDCaseFileID { get => _uCDCaseFileID; set => SetField(ref _uCDCaseFileID, value); }

        /// <summary>
        /// UCD Fannie Mae Case File Status Type [4503]
        /// </summary>
        public string? UCDFNMACasefileStatusType { get => _uCDFNMACasefileStatusType; set => SetField(ref _uCDFNMACasefileStatusType, value); }

        /// <summary>
        /// UCD Fannie Mae Case File Warning Indicator [4504]
        /// </summary>
        public string? UCDFNMACasefileWarningIndicator { get => _uCDFNMACasefileWarningIndicator; set => SetField(ref _uCDFNMACasefileWarningIndicator, value); }

        /// <summary>
        /// UCD Loan Closing Match Status Type [4507]
        /// </summary>
        public string? UCDLoanCLSMatchStatusType { get => _uCDLoanCLSMatchStatusType; set => SetField(ref _uCDLoanCLSMatchStatusType, value); }

        /// <summary>
        /// UCD Original Submission Date [4506]
        /// </summary>
        public DateTime? UCDOrigSubmissionDate { get => _uCDOrigSubmissionDate; set => SetField(ref _uCDOrigSubmissionDate, value); }

        /// <summary>
        /// UCD Submission Date [4505]
        /// </summary>
        public DateTime? UCDSubmissionDate { get => _uCDSubmissionDate; set => SetField(ref _uCDSubmissionDate, value); }

        /// <summary>
        /// Loan Uldd
        /// </summary>
        [AllowNull]
        public Uldd Uldd { get => GetField(ref _uldd); set => SetField(ref _uldd, value); }

        /// <summary>
        /// Loan UnderwriterSummary
        /// </summary>
        [AllowNull]
        public UnderwriterSummary UnderwriterSummary { get => GetField(ref _underwriterSummary); set => SetField(ref _underwriterSummary, value); }

        /// <summary>
        /// Loan UnderwritingConditionLogs
        /// </summary>
        [AllowNull]
        public IList<UnderwritingConditionLog> UnderwritingConditionLogs { get => GetField(ref _underwritingConditionLogs); set => SetField(ref _underwritingConditionLogs, value); }

        /// <summary>
        /// Underwriting Escrow [1550]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow (T&I)\"}")]
        public bool? UnderwritingEscrowIndicator { get => _underwritingEscrowIndicator; set => SetField(ref _underwritingEscrowIndicator, value); }

        /// <summary>
        /// UnDiscounted Rate [3293]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? UndiscountedRate { get => _undiscountedRate; set => SetField(ref _undiscountedRate, value); }

        /// <summary>
        /// Construction Management - Basic Info - Unimproved Appraised Value [4090]
        /// </summary>
        public int? UnimprovedAppraisedValue { get => _unimprovedAppraisedValue; set => SetField(ref _unimprovedAppraisedValue, value); }

        /// <summary>
        /// Construction Management - Basic Info - Unimproved Estimated Value [4089]
        /// </summary>
        public int? UnimprovedEstimatedValue { get => _unimprovedEstimatedValue; set => SetField(ref _unimprovedEstimatedValue, value); }

        /// <summary>
        /// URLA Loan Identifier [URLA.X120]
        /// </summary>
        public string? URLALoanIdentifier { get => _uRLALoanIdentifier; set => SetField(ref _uRLALoanIdentifier, value); }

        /// <summary>
        /// URLA Total Credits Amount [URLA.X152]
        /// </summary>
        public decimal? URLATotalCreditsAmount { get => _uRLATotalCreditsAmount; set => SetField(ref _uRLATotalCreditsAmount, value); }

        /// <summary>
        /// URLA Total Mortgage Loans Amount [URLA.X148]
        /// </summary>
        public decimal? URLATotalMortgageLoansAmount { get => _uRLATotalMortgageLoansAmount; set => SetField(ref _uRLATotalMortgageLoansAmount, value); }

        /// <summary>
        /// URLA Total Other Credits Amount [URLA.X149]
        /// </summary>
        public decimal? URLATotalOtherCreditsAmount { get => _uRLATotalOtherCreditsAmount; set => SetField(ref _uRLATotalOtherCreditsAmount, value); }

        /// <summary>
        /// 1003 Page 4 Comments [1003p4]
        /// </summary>
        public string? UrlPage4Comments { get => _urlPage4Comments; set => SetField(ref _urlPage4Comments, value); }

        /// <summary>
        /// Loan Usda
        /// </summary>
        [AllowNull]
        public Usda Usda { get => GetField(ref _usda); set => SetField(ref _usda, value); }

        /// <summary>
        /// USDA-RHS Government Loan Type [Terms.USDAGovtType]
        /// </summary>
        public StringEnumValue<UsdaGovernmentLoanType> UsdaGovernmentLoanType { get => _usdaGovernmentLoanType; set => SetField(ref _usdaGovernmentLoanType, value); }

        /// <summary>
        /// Use 2018 DI [4142]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Use 2018 DI\"}")]
        public bool? Use2018DiIndicator { get => _use2018DiIndicator; set => SetField(ref _use2018DiIndicator, value); }

        /// <summary>
        /// Apply Enhanced Conditions to Loan [ENHANCEDCOND.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? UseEnhancedConditionIndicator { get => _useEnhancedConditionIndicator; set => SetField(ref _useEnhancedConditionIndicator, value); }

        /// <summary>
        /// Use New LE, CD, GFE And HUD [3969]
        /// </summary>
        public StringEnumValue<UseNew2015FormsIndicator> UseNew2015FormsIndicator { get => _useNew2015FormsIndicator; set => SetField(ref _useNew2015FormsIndicator, value); }

        /// <summary>
        /// Use New GFE And HUD [NEWHUD.X354]
        /// </summary>
        public bool? UseNewHudIndicator { get => _useNewHudIndicator; set => SetField(ref _useNewHudIndicator, value); }

        /// <summary>
        /// VA Loan Summ Entitlement Amt [VASUMM.X3]
        /// </summary>
        public decimal? VAEntitlementAmount { get => _vAEntitlementAmount; set => SetField(ref _vAEntitlementAmount, value); }

        /// <summary>
        /// Loan VaLoanData
        /// </summary>
        [AllowNull]
        public VaLoanData VaLoanData { get => GetField(ref _vaLoanData); set => SetField(ref _vaLoanData, value); }

        /// <summary>
        /// Valuation Used for LTV [4520]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ValuationUsed { get => _valuationUsed; set => SetField(ref _valuationUsed, value); }

        /// <summary>
        /// Loan VerificationLogs
        /// </summary>
        [AllowNull]
        public IList<VerificationLog> VerificationLogs { get => GetField(ref _verificationLogs); set => SetField(ref _verificationLogs, value); }

        /// <summary>
        /// Loan VirtualFields
        /// </summary>
        [AllowNull]
        public IDictionary<string, string?> VirtualFields { get => GetField(ref _virtualFields); set => SetField(ref _virtualFields, value); }

        /// <summary>
        /// Website ID [WEBSITEID]
        /// </summary>
        public string? WebsiteId { get => _websiteId; set => SetField(ref _websiteId, value); }

        /// <summary>
        /// Loan Workflow Id [4685]
        /// </summary>
        public string? WorkFlowId { get => _workFlowId; set => SetField(ref _workFlowId, value); }
    }
}