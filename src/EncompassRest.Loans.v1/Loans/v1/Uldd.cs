using System;
using EncompassRest.Loans.v1.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Uldd
    /// </summary>
    public sealed partial class Uldd : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _aCHABARoutingAndTransitIdentifier;
        private DirtyValue<string?>? _aCHABARoutingAndTransitNumber;
        private DirtyValue<string?>? _aCHBankAccountDescription;
        private DirtyValue<string?>? _aCHBankAccountIdentifier;
        private DirtyValue<string?>? _aCHBankAccountPurposeTransitIdentifier;
        private DirtyValue<StringEnumValue<ACHBankAccountPurposeType>>? _aCHBankAccountPurposeType;
        private DirtyValue<string?>? _aCHInstitutionTelegraphicAbbreviationName;
        private DirtyValue<string?>? _aCHReceiverSubaccountName;
        private DirtyValue<bool?>? _additionalPrincipalAmountIndicator;
        private DirtyValue<decimal?>? _aggregateLoanCurtailmentAmount;
        private DirtyValue<string?>? _appraisalIdentifier;
        private DirtyValue<StringEnumValue<AttachmentType>>? _attachmentType;
        private DirtyValue<StringEnumValue<AVMModelNameType>>? _aVMModelNameType;
        private DirtyValue<bool?>? _balloonResetIndicator;
        private DirtyValue<decimal?>? _baseGuarantyFeePercent;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _bondFinancePool;
        private DirtyValue<string?>? _bondFinanceProgramName;
        private DirtyValue<StringEnumValue<BondFinanceProgramType>>? _bondFinanceProgramType;
        private DirtyValue<bool?>? _borrowerMailToAddressSameasPropertyIndicator;
        private DirtyValue<StringEnumValue<UlddBorrowerType>>? _borrowerType;
        private DirtyValue<bool?>? _capitalizedLoanIndicator;
        private DirtyValue<string?>? _certificateIdentifier;
        private DirtyValue<DateTime?>? _certificateMaturityDate;
        private DirtyValue<decimal?>? _certificatePrincipalBalanceAmount;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _certificateType;
        private DirtyValue<decimal?>? _closingCost2ContributionAmount;
        private DirtyValue<StringEnumValue<ClosingCostFundsType>>? _closingCost2FundsType;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _closingCost2FundsTypeOtherDescription;
        private DirtyValue<StringEnumValue<ClosingCostSourceType>>? _closingCost2SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _closingCost2SourceTypeOtherDescription;
        private DirtyValue<decimal?>? _closingCost3ContributionAmount;
        private DirtyValue<StringEnumValue<ClosingCostFundsType>>? _closingCost3FundsType;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _closingCost3FundsTypeOtherDescription;
        private DirtyValue<StringEnumValue<ClosingCostSourceType>>? _closingCost3SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _closingCost3SourceTypeOtherDescription;
        private DirtyValue<decimal?>? _closingCost4ContributionAmount;
        private DirtyValue<StringEnumValue<ClosingCostFundsType>>? _closingCost4FundsType;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _closingCost4FundsTypeOtherDescription;
        private DirtyValue<StringEnumValue<ClosingCostSourceType>>? _closingCost4SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _closingCost4SourceTypeOtherDescription;
        private DirtyValue<decimal?>? _closingCostContributionAmount;
        private DirtyValue<StringEnumValue<ClosingCostFundsType>>? _closingCostFundsType;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _closingCostFundsTypeOtherDescription;
        private DirtyValue<StringEnumValue<ClosingCostSourceType>>? _closingCostSourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _closingCostSourceTypeOtherDescription;
        private DirtyValue<string?>? _coBorrowerCountryCode;
        private DirtyValue<bool?>? _coBorrowerMailToAddressSameasPropertyIndicator;
        private DirtyValue<StringEnumValue<UlddBorrowerType>>? _coBorrowerType;
        private DirtyValue<StringEnumValue<CondominiumProjectStatusType>>? _condominiumProjectStatusType;
        private DirtyValue<StringEnumValue<ConstructionMethodType>>? _constructionMethodType;
        private DirtyValue<string?>? _constructionMethodTypeOtherDescription;
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingFeatureType>>? _constructionToPermanentClosingFeatureType;
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingType>>? _constructionToPermanentClosingType;
        private DirtyValue<StringEnumValue<ConvertibleStatusType>>? _convertibleStatusType;
        private DirtyValue<StringEnumValue<CounselingFormatType>>? _counselingFormatType;
        private DirtyValue<StringEnumValue<CounselingFormatTypeOtherDescription>>? _counselingFormatTypeOtherDescription;
        private DirtyValue<StringEnumValue<CounselTypeOther>>? _counselTypeOther;
        private DirtyValue<string?>? _countryCode;
        private DirtyValue<StringEnumValue<CreditRepositorySourceType>>? _creditRepositorySourceType;
        private DirtyValue<StringEnumValue<CreditScoreImpairmentType>>? _creditScoreImpairmentType;
        private DirtyValue<decimal?>? _currentAccruedInterestAmount;
        private DirtyValue<int?>? _delinquentPaymentsOverPastTwelveMonthsCount;
        private DirtyValue<string?>? _documentCustodianID;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _documentRequiredIndicator;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _documentSubmissionIndicator;
        private DirtyValue<StringEnumValue<DownPaymentFundsType>>? _downPaymentFundsType;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _downPaymentOtherTypeDescription;
        private DirtyValue<StringEnumValue<DownPaymentSourceType>>? _downPaymentSourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _downPaymentSourceTypeOtherDescription;
        private DirtyValue<bool?>? _eNoteIndicator;
        private DirtyValue<StringEnumValue<FannieARMIndexType>>? _fannieARMIndexType;
        private DirtyValue<StringEnumValue<FannieAutoUWDec>>? _fannieAutoUWDec;
        private DirtyValue<int?>? _fannieBLTV;
        private DirtyValue<string?>? _fannieBorrowerFirstName;
        private DirtyValue<string?>? _fannieBorrowerMiddleName;
        private DirtyValue<StringEnumValue<FannieBuydownContributer>>? _fannieBuydownContributer;
        private DirtyValue<int?>? _fannieCLTV;
        private DirtyValue<string?>? _fannieCoBorrowerFirstName;
        private DirtyValue<string?>? _fannieCoBorrowerMiddleName;
        private DirtyValue<string?>? _fannieCreditScoreProviderName;
        private DirtyValue<StringEnumValue<FannieFloodSpecialFeatureCode>>? _fannieFloodSpecialFeatureCode;
        private DirtyValue<int?>? _fannieHCLTV;
        private DirtyValue<int?>? _fannieInvestorOwnershipPercent;
        private DirtyValue<StringEnumValue<FannieLegalEntityType>>? _fannieLegalEntityType;
        private DirtyValue<StringEnumValue<FannieLegalEntityTypeOther>>? _fannieLegalEntityTypeOther;
        private DirtyValue<decimal?>? _fannieLenderPaidMIInterestRateAdjustmentPercent;
        private DirtyValue<StringEnumValue<FannieLoanProgramIdentifier>>? _fannieLoanProgramIdentifier;
        private DirtyValue<int?>? _fannieLTV;
        private DirtyValue<StringEnumValue<FannieMICompanyNameTypeOther>>? _fannieMICompanyNameTypeOther;
        private DirtyValue<int?>? _fannieMICoveragePercent;
        private DirtyValue<int?>? _fanniePoolOwnershipPercent;
        private DirtyValue<StringEnumValue<FannieProjectClassificationType>>? _fannieProjectClassificationType;
        private DirtyValue<StringEnumValue<FanniePropertyFormType>>? _fanniePropertyFormType;
        private DirtyValue<decimal?>? _fannieRateSpread;
        private DirtyValue<StringEnumValue<FannieRefinanceType>>? _fannieRefinanceType;
        private DirtyValue<string?>? _fannieRelatedInvestorLoanID;
        private DirtyValue<StringEnumValue<FannieRelatedLoanAmortizationType>>? _fannieRelatedLoanAmortizationType;
        private DirtyValue<StringEnumValue<FannieRelatedLoanLienPosition>>? _fannieRelatedLoanLienPosition;
        private DirtyValue<StringEnumValue<FannieRelatedLoanType>>? _fannieRelatedLoanType;
        private DirtyValue<StringEnumValue<FannieSectionOfAct>>? _fannieSectionOfAct;
        private DirtyValue<int?>? _fannieTLTV;
        private DirtyValue<string?>? _fannieTrustName;
        private DirtyValue<StringEnumValue<FannnieMortgageType>>? _fannnieMortgageType;
        private DirtyValue<int?>? _financedUnitCount;
        private DirtyValue<DateTime?>? _firstRateChangePaymentEffectiveDate;
        private DirtyValue<StringEnumValue<FNMHomeImprovementProductType>>? _fNMHomeImprovementProductType;
        private DirtyValue<StringEnumValue<FreddieARMIndexType>>? _freddieARMIndexType;
        private DirtyValue<StringEnumValue<FreddieAutoUWDec>>? _freddieAutoUWDec;
        private DirtyValue<StringEnumValue<FreddieAVMModelNameTypeExpl>>? _freddieAVMModelNameTypeExpl;
        private DirtyValue<StringEnumValue<FreddieBorrowerAlienStatus>>? _freddieBorrowerAlienStatus;
        private DirtyValue<StringEnumValue<FreddieBorrowerAlienStatus>>? _freddieCoBorrowerAlienStatus;
        private DirtyValue<string?>? _freddieCreditScoreProviderName;
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>>? _freddieDownPaymentType;
        private DirtyValue<StringEnumValue<DownPaymentSourceType>>? _freddieDownPmt2SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _freddieDownPmt2SourceTypeExpl;
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>>? _freddieDownPmt2Type;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _freddieDownPmt2TypeExpl;
        private DirtyValue<decimal?>? _freddieDownPmt3Amt;
        private DirtyValue<StringEnumValue<DownPaymentSourceType>>? _freddieDownPmt3SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _freddieDownPmt3SourceTypeExpl;
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>>? _freddieDownPmt3Type;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _freddieDownPmt3TypeExpl;
        private DirtyValue<decimal?>? _freddieDownPmt4Amt;
        private DirtyValue<StringEnumValue<DownPaymentSourceType>>? _freddieDownPmt4SourceType;
        private DirtyValue<StringEnumValue<SourceTypeDescription>>? _freddieDownPmt4SourceTypeExpl;
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>>? _freddieDownPmt4Type;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _freddieDownPmt4TypeExpl;
        private DirtyValue<StringEnumValue<FundsTypeDescription>>? _freddieExplanationOfDownPayment;
        private DirtyValue<StringEnumValue<FreddieInvestorCollateralProgramIdentifier>>? _freddieInvestorCollateralProgramIdentifier;
        private DirtyValue<string?>? _freddieInvestorFeatureIdentifier;
        private DirtyValue<StringEnumValue<FreddieLegalEntityType>>? _freddieLegalEntityType;
        private DirtyValue<StringEnumValue<FreddieLegalEntityTypeOther>>? _freddieLegalEntityTypeOther;
        private DirtyValue<StringEnumValue<FreddieLoanProgramIdentifier>>? _freddieLoanProgramIdentifier;
        private DirtyValue<StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator>>? _freddieLoanTypePublicAndIndianHousingIndicator;
        private DirtyValue<StringEnumValue<FreddieMICompanyNameTypeOther>>? _freddieMICompanyNameTypeOther;
        private DirtyValue<StringEnumValue<FreddieMortgageType>>? _freddieMortgageType;
        private DirtyValue<StringEnumValue<FreddieProjectClassificationType>>? _freddieProjectClassificationType;
        private DirtyValue<StringEnumValue<PropertyFormType>>? _freddiePropertyFormType;
        private DirtyValue<StringEnumValue<FreddieRefinanceCashOutDeterminationType>>? _freddieRefinanceCashOutDeterminationType;
        private DirtyValue<StringEnumValue<FreddieRefinanceType>>? _freddieRefinanceType;
        private DirtyValue<bool?>? _freddieRelatedClosedEndSecondIndicator;
        private DirtyValue<string?>? _freddieRelatedInvestorLoanID;
        private DirtyValue<StringEnumValue<FreddieRelatedLoanInvestorType>>? _freddieRelatedLoanInvestorType;
        private DirtyValue<StringEnumValue<FreddieRelatedLoanLienPosition>>? _freddieRelatedLoanLienPosition;
        private DirtyValue<StringEnumValue<FreddieRelatedLoanType>>? _freddieRelatedLoanType;
        private DirtyValue<StringEnumValue<FreddieSectionOfAct>>? _freddieSectionOfAct;
        private DirtyValue<StringEnumValue<FreddieUnderwritingTypeOther>>? _freddieUnderwritingTypeOther;
        private DirtyValue<StringEnumValue<GinnieConstructionMethodType>>? _ginnieConstructionMethodType;
        private DirtyValue<decimal?>? _ginnieGovernmentAnnualPremiumAmount;
        private DirtyValue<StringEnumValue<GinnieMortgageType>>? _ginnieMortgageType;
        private DirtyValue<string?>? _ginnieOtherConstructionMethodType;
        private DirtyValue<decimal?>? _governmentAnnualPremiumPercent;
        private DirtyValue<StringEnumValue<GovernmentRefinanceType>>? _governmentRefinanceType;
        private DirtyValue<decimal?>? _governmentUpfrontPremiumAmount;
        private DirtyValue<decimal?>? _governmentUpfrontPremiumPercent;
        private DirtyValue<StringEnumValue<GSEProjectType>>? _gSEProjectType;
        private DirtyValue<bool?>? _guaranteeFeeAddOnIndicator;
        private DirtyValue<decimal?>? _guarantyFeeAfterAlternatePaymentMethodPercent;
        private DirtyValue<decimal?>? _guarantyFeePercent;
        private DirtyValue<decimal?>? _guarantyPercent;
        private DirtyValue<string?>? _homeOwnerAssociationEin;
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<IndexType>>? _indexType;
        private DirtyValue<int?>? _initialFixedPeriodEffectiveMonthsCount;
        private DirtyValue<StringEnumValue<InterestAccrualType>>? _interestAccrualType;
        private DirtyValue<int?>? _interestAndPaymentAdjustmentIndexLeadDaysCount;
        private DirtyValue<StringEnumValue<InterestCalculationBasisType>>? _interestCalculationBasisType;
        private DirtyValue<int?>? _interestCalculationEffectiveMonthsCount;
        private DirtyValue<StringEnumValue<InterestCalculationType>>? _interestCalculationType;
        private DirtyValue<StringEnumValue<InvestorCollateralProgramIdentifier>>? _investorCollateralProgramIdentifier;
        private DirtyValue<string?>? _investorCommitmentIdentifier;
        private DirtyValue<string?>? _investorFeatureIdentifier;
        private DirtyValue<string?>? _investorFeatureIdPool;
        private DirtyValue<decimal?>? _investorOwnershipPercent;
        private DirtyValue<string?>? _investorProductPlanIdentifier;
        private DirtyValue<int?>? _investorRemittanceDay;
        private DirtyValue<StringEnumValue<InvestorRemittanceType>>? _investorRemittanceType;
        private DirtyValue<string?>? _issuerIdentifier;
        private DirtyValue<DateTime?>? _lastPaidInstallmentDueDate;
        private DirtyValue<DateTime?>? _lastPaymentReceivedDate;
        private DirtyValue<DateTime?>? _latestConversionEffectiveDate;
        private DirtyValue<decimal?>? _lenderPaidMIInterestRateAdjustmentPercent;
        private DirtyValue<DateTime?>? _lendersDeliveryDate;
        private DirtyValue<decimal?>? _loanAcquisitionScheduledUPBAmount;
        private DirtyValue<int?>? _loanAmortizationMaximumTermMonthsCount;
        private DirtyValue<int?>? _loanBuyupBuydownBasisPointNumber;
        private DirtyValue<StringEnumValue<LoanBuyupBuydownType>>? _loanBuyupBuydownType;
        private DirtyValue<StringEnumValue<LoanDefaultLossPartyType>>? _loanDefaultLossPartyType;
        private DirtyValue<bool?>? _loanDeliveredThroughServicingReleasedProcessIndicator;
        private DirtyValue<StringEnumValue<LoanIdentifierValueType>>? _loanIdentifierValueType;
        private DirtyValue<DateTime?>? _loanInterestAccrualStartDate;
        private DirtyValue<bool?>? _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        private DirtyValue<StringEnumValue<LoanLevelCreditScoreSelectionMethodType>>? _loanLevelCreditScoreSelectionMethodType;
        private DirtyValue<int?>? _loanLevelCreditScoreValue;
        private DirtyValue<DateTime?>? _loanModificationEffectiveDate;
        private DirtyValue<DateTime?>? _loanStateDate;
        private DirtyValue<StringEnumValue<ManufacturedHomeWidthType>>? _manufacturedHomeWidthType;
        private DirtyValue<bool?>? _mBSWeightedMarginIndicator;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _mERSOriginalMortgageeOfRecordIndicator;
        private DirtyValue<StringEnumValue<MICompanyNameType>>? _mICompanyNameType;
        private DirtyValue<StringEnumValue<MIPremiumSourceType>>? _mIPremiumSourceType;
        private DirtyValue<DateTime?>? _monetaryEventAppliedDate;
        private DirtyValue<decimal?>? _monetaryEventGrossPrincipalAmount;
        private DirtyValue<StringEnumValue<MonetaryEventType>>? _monetaryEventType;
        private DirtyValue<bool?>? _mortgageBackedSecurityIndicator;
        private DirtyValue<bool?>? _mortgageModificationIndicator;
        private DirtyValue<StringEnumValue<UlddMortgageOriginator>>? _mortgageOriginator;
        private DirtyValue<StringEnumValue<MortgageProgramType>>? _mortgageProgramType;
        private DirtyValue<bool?>? _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        private DirtyValue<DateTime?>? _nextRateAdjustmentEffectiveDate;
        private DirtyValue<string?>? _notePayToName;
        private DirtyValue<int?>? _numberOfUnitsSold;
        private DirtyValue<string?>? _otherDownPaymentFundsType;
        private DirtyValue<decimal?>? _otherFundsCollectedAtClosingAmount;
        private DirtyValue<StringEnumValue<OtherFundsCollectedAtClosingType>>? _otherFundsCollectedAtClosingType;
        private DirtyValue<string?>? _payeeID;
        private DirtyValue<int?>? _paymentBillingStatementLeadDaysCount;
        private DirtyValue<decimal?>? _perChangeMaximumDecreaseRatePercent;
        private DirtyValue<decimal?>? _perChangeMaximumIncreaseRatePercent;
        private DirtyValue<decimal?>? _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        private DirtyValue<DateTime?>? _perChangeRateAdjustmentEffectiveDate;
        private DirtyValue<int?>? _perChangeRateAdjustmentFrequencyMonthsCount;
        private DirtyValue<StringEnumValue<PoolAccrualRateStructureType>>? _poolAccrualRateStructureType;
        private DirtyValue<StringEnumValue<PoolAmortizationType>>? _poolAmortizationType;
        private DirtyValue<bool?>? _poolAssumabilityIndicator;
        private DirtyValue<bool?>? _poolBalloonIndicator;
        private DirtyValue<DateTime?>? _poolCertificatePaymentDate;
        private DirtyValue<StringEnumValue<PoolClassType>>? _poolClassType;
        private DirtyValue<StringEnumValue<TrueOrFalse>>? _poolConcurrentTransferIndicator;
        private DirtyValue<int?>? _poolCurrentLoanCount;
        private DirtyValue<decimal?>? _poolCurrentPrincipalBalanceAmount;
        private DirtyValue<string?>? _poolDocumentCustodianID;
        private DirtyValue<decimal?>? _poolFixedServicingFeePercent;
        private DirtyValue<string?>? _poolIdentifier;
        private DirtyValue<StringEnumValue<PoolingMethodType>>? _poolingMethodType;
        private DirtyValue<DateTime?>? _poolInterestAdjustmentEffectiveDate;
        private DirtyValue<int?>? _poolInterestAdjustmentIndexLeadDaysCount;
        private DirtyValue<int?>? _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        private DirtyValue<bool?>? _poolInterestOnlyIndicator;
        private DirtyValue<decimal?>? _poolInterestRateRoundingPercent;
        private DirtyValue<StringEnumValue<PoolInterestRateRoundingType>>? _poolInterestRateRoundingType;
        private DirtyValue<string?>? _poolInvestorProductPlanIdentifier;
        private DirtyValue<DateTime?>? _poolIssueDate;
        private DirtyValue<string?>? _poolIssuerTransferee;
        private DirtyValue<decimal?>? _poolMarginRatePercent;
        private DirtyValue<DateTime?>? _poolMaturityDate;
        private DirtyValue<int?>? _poolMaturityPeriodCount;
        private DirtyValue<decimal?>? _poolMaximumAccrualRatePercent;
        private DirtyValue<decimal?>? _poolMinimumAccrualRatePercent;
        private DirtyValue<StringEnumValue<PoolMortgageType>>? _poolMortgageType;
        private DirtyValue<int?>? _poolScheduledRemittancePaymentDay;
        private DirtyValue<decimal?>? _poolSecurityIssueDateInterestRatePercent;
        private DirtyValue<string?>? _poolSellerID;
        private DirtyValue<string?>? _poolServicerID;
        private DirtyValue<StringEnumValue<PoolStructureType>>? _poolStructureType;
        private DirtyValue<string?>? _poolSuffixIdentifier;
        private DirtyValue<DateTime?>? _priceLockDatetime;
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonType>>? _primaryMIAbsenceReasonType;
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription>>? _primaryMIAbsenceReasonTypeOtherDescription;
        private DirtyValue<StringEnumValue<ProjectAttachmentType>>? _projectAttachmentType;
        private DirtyValue<StringEnumValue<ProjectDesignType>>? _projectDesignType;
        private DirtyValue<int?>? _projectUnitCount;
        private DirtyValue<StringEnumValue<PropertyRightsType>>? _propertyEstateType;
        private DirtyValue<DateTime?>? _propertyValuationEffectiveDate;
        private DirtyValue<StringEnumValue<PropertyValuationMethodType>>? _propertyValuationMethodType;
        private DirtyValue<StringEnumValue<PropertyValuationOther>>? _propertyValuationOther;
        private DirtyValue<decimal?>? _refinanceCashOutAmount;
        private DirtyValue<StringEnumValue<RefinanceCashOutDeterminationType>>? _refinanceCashOutDeterminationType;
        private DirtyValue<bool?>? _relatedLoanAffordableIndicator;
        private DirtyValue<bool?>? _relatedLoanBalloonIndicator;
        private DirtyValue<bool?>? _relatedLoanHELOCIndicator;
        private DirtyValue<bool?>? _relatedLoanIndicator;
        private DirtyValue<StringEnumValue<RelatedLoanInvestorType>>? _relatedLoanInvestorType;
        private DirtyValue<int?>? _relatedLoanMaturityPeriodCount;
        private DirtyValue<DateTime?>? _relatedLoanNoteDate;
        private DirtyValue<DateTime?>? _relatedLoanScheduledFirstPaymentDate;
        private DirtyValue<DateTime?>? _relatedLoanStateDateAtClosing;
        private DirtyValue<decimal?>? _relatedLoanUnpaidPrincipalBalanceAmount;
        private DirtyValue<bool?>? _relocationLoanIndicator;
        private DirtyValue<StringEnumValue<PartyType>>? _rEOMarketingPartyType;
        private DirtyValue<bool?>? _secondLienIsDeliveredIndicator;
        private DirtyValue<decimal?>? _securityOriginalSubscriptionAmount;
        private DirtyValue<DateTime?>? _securityTradeBookEntryDate;
        private DirtyValue<string?>? _sellerID;
        private DirtyValue<string?>? _sellerLoanIdentifier;
        private DirtyValue<string?>? _servicerID;
        private DirtyValue<string?>? _servicerLoanIdentifier;
        private DirtyValue<bool?>? _sharedEquityIndicator;
        private DirtyValue<bool?>? _siteBuiltIndicator;
        private DirtyValue<bool?>? _specialFloodHazardAreaIndicator;
        private DirtyValue<decimal?>? _subsequentPerChangeMaximumDecreaseRatePercent;
        private DirtyValue<decimal?>? _subsequentPerChangeMaximumIncreaseRatePercent;
        private DirtyValue<DateTime?>? _subsequentPerChangeRateAdjustmentEffectiveDate;
        private DirtyValue<int?>? _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        private DirtyValue<bool?>? _temporaryBuydownIndicator;
        private DirtyValue<int?>? _totalMortgagedPropertiesCount;
        private DirtyValue<decimal?>? _unit1SubjectPropertyGrossRentalIncome;
        private DirtyValue<int?>? _unit1TotalBedrooms;
        private DirtyValue<decimal?>? _unit2SubjectPropertyGrossRentalIncome;
        private DirtyValue<int?>? _unit2TotalBedrooms;
        private DirtyValue<decimal?>? _unit3SubjectPropertyGrossRentalIncome;
        private DirtyValue<int?>? _unit3TotalBedrooms;
        private DirtyValue<decimal?>? _unit4SubjectPropertyGrossRentalIncome;
        private DirtyValue<int?>? _unit4TotalBedrooms;
        private DirtyValue<decimal?>? _uPBAmount;
        private DirtyValue<string?>? _wareHouseLenderId;
        private DirtyValue<bool?>? _wareHouseLenderIndicator;

        /// <summary>
        /// ACH ABA Routing And Transit Identifier [ULDD.GNM.ACHABARoutingAndTransitIdentifier]
        /// </summary>
        public string? ACHABARoutingAndTransitIdentifier { get => _aCHABARoutingAndTransitIdentifier; set => SetField(ref _aCHABARoutingAndTransitIdentifier, value); }

        /// <summary>
        /// ACH ABARouting And Transit # [ULDD.GNM.ACHABARtngAndTrnstNmbr]
        /// </summary>
        public string? ACHABARoutingAndTransitNumber { get => _aCHABARoutingAndTransitNumber; set => SetField(ref _aCHABARoutingAndTransitNumber, value); }

        /// <summary>
        /// ACH Bank Account Description [ULDD.GNM.ACHBnkAccntDscr]
        /// </summary>
        public string? ACHBankAccountDescription { get => _aCHBankAccountDescription; set => SetField(ref _aCHBankAccountDescription, value); }

        /// <summary>
        /// ACH Bank Account Identifier [ULDD.GNM.ACHBnkAccntIdentfr]
        /// </summary>
        public string? ACHBankAccountIdentifier { get => _aCHBankAccountIdentifier; set => SetField(ref _aCHBankAccountIdentifier, value); }

        /// <summary>
        /// ACH Bank Account Purpose Transit Identifier [ULDD.GNM.ACHBnkAccntPrpsTrnstIdntfr]
        /// </summary>
        public string? ACHBankAccountPurposeTransitIdentifier { get => _aCHBankAccountPurposeTransitIdentifier; set => SetField(ref _aCHBankAccountPurposeTransitIdentifier, value); }

        /// <summary>
        /// ACH Bank Account Purpose Type [ULDD.GNM.ACHBnkAccntPrpsTyp]
        /// </summary>
        public StringEnumValue<ACHBankAccountPurposeType> ACHBankAccountPurposeType { get => _aCHBankAccountPurposeType; set => SetField(ref _aCHBankAccountPurposeType, value); }

        /// <summary>
        /// ACH Institution Telegraphic Name [ULDD.GNM.ACHInstttnTlgrphcAbbrName]
        /// </summary>
        public string? ACHInstitutionTelegraphicAbbreviationName { get => _aCHInstitutionTelegraphicAbbreviationName; set => SetField(ref _aCHInstitutionTelegraphicAbbreviationName, value); }

        /// <summary>
        /// ACH Receiver Subaccount Name [ULDD.GNM.ACHRcvrSbccntName]
        /// </summary>
        public string? ACHReceiverSubaccountName { get => _aCHReceiverSubaccountName; set => SetField(ref _aCHReceiverSubaccountName, value); }

        /// <summary>
        /// ULDD - Additional Principal Amount has been Paid from Origination to Date [ULDD.X2]
        /// </summary>
        public bool? AdditionalPrincipalAmountIndicator { get => _additionalPrincipalAmountIndicator; set => SetField(ref _additionalPrincipalAmountIndicator, value); }

        /// <summary>
        /// ULDD - Aggregate Loan Curtailment Amount [ULDD.X3]
        /// </summary>
        public decimal? AggregateLoanCurtailmentAmount { get => _aggregateLoanCurtailmentAmount; set => SetField(ref _aggregateLoanCurtailmentAmount, value); }

        /// <summary>
        /// ULDD - Appraisal ID [ULDD.X31]
        /// </summary>
        public string? AppraisalIdentifier { get => _appraisalIdentifier; set => SetField(ref _appraisalIdentifier, value); }

        /// <summary>
        /// ULDD Attachment Type [ULDD.X177]
        /// </summary>
        public StringEnumValue<AttachmentType> AttachmentType { get => _attachmentType; set => SetField(ref _attachmentType, value); }

        /// <summary>
        /// ULDD - AVM Model Name Type [ULDD.X32]
        /// </summary>
        public StringEnumValue<AVMModelNameType> AVMModelNameType { get => _aVMModelNameType; set => SetField(ref _aVMModelNameType, value); }

        /// <summary>
        /// Balloon Reset [ULDD.X159]
        /// </summary>
        public bool? BalloonResetIndicator { get => _balloonResetIndicator; set => SetField(ref _balloonResetIndicator, value); }

        /// <summary>
        /// ULDD - Base Guaranty Fee [ULDD.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BaseGuarantyFeePercent { get => _baseGuarantyFeePercent; set => SetField(ref _baseGuarantyFeePercent, value); }

        /// <summary>
        /// ULDD Ginnie Bond Finance Pool Indicator [ULDD.GNM.BondFinPoolIndic]
        /// </summary>
        public StringEnumValue<TrueOrFalse> BondFinancePool { get => _bondFinancePool; set => SetField(ref _bondFinancePool, value); }

        /// <summary>
        /// ULDD Ginnie Bond Finance Program Name [ULDD.GNM.BondFinProgName]
        /// </summary>
        public string? BondFinanceProgramName { get => _bondFinanceProgramName; set => SetField(ref _bondFinanceProgramName, value); }

        /// <summary>
        /// ULDD Ginnie Bond Finance Program Type [ULDD.GNM.BondFinProgType]
        /// </summary>
        public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get => _bondFinanceProgramType; set => SetField(ref _bondFinanceProgramType, value); }

        /// <summary>
        /// ULDD - Borrower Mailing Address is same as the Property Address [ULDD.X26]
        /// </summary>
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get => _borrowerMailToAddressSameasPropertyIndicator; set => SetField(ref _borrowerMailToAddressSameasPropertyIndicator, value); }

        /// <summary>
        /// Borrower Type [ULDD.X150]
        /// </summary>
        public StringEnumValue<UlddBorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// ULDD - Capitalized Loan [ULDD.X7]
        /// </summary>
        public bool? CapitalizedLoanIndicator { get => _capitalizedLoanIndicator; set => SetField(ref _capitalizedLoanIndicator, value); }

        /// <summary>
        /// ULDD Ginnie Certificate Identifier [ULDD.GNM.CertId]
        /// </summary>
        public string? CertificateIdentifier { get => _certificateIdentifier; set => SetField(ref _certificateIdentifier, value); }

        /// <summary>
        /// ULDD Ginnie Certificate Maturity Date [ULDD.GNM.CertMaturityDate]
        /// </summary>
        public DateTime? CertificateMaturityDate { get => _certificateMaturityDate; set => SetField(ref _certificateMaturityDate, value); }

        /// <summary>
        /// ULDD Ginnie Certificate Principal Balance Amount [ULDD.GNM.CertPrinBalAmt]
        /// </summary>
        public decimal? CertificatePrincipalBalanceAmount { get => _certificatePrincipalBalanceAmount; set => SetField(ref _certificatePrincipalBalanceAmount, value); }

        /// <summary>
        /// ULDD Ginnie Certificate Type [ULDD.GNM.CertType]
        /// </summary>
        public StringEnumValue<TrueOrFalse> CertificateType { get => _certificateType; set => SetField(ref _certificateType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST2CONTRIBUTIONAMOUNT]
        /// </summary>
        public decimal? ClosingCost2ContributionAmount { get => _closingCost2ContributionAmount; set => SetField(ref _closingCost2ContributionAmount, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST2FUNDSTYPE]
        /// </summary>
        public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get => _closingCost2FundsType; set => SetField(ref _closingCost2FundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST2FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
        public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get => _closingCost2FundsTypeOtherDescription; set => SetField(ref _closingCost2FundsTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST2SOURCETYPE]
        /// </summary>
        public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get => _closingCost2SourceType; set => SetField(ref _closingCost2SourceType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST2SOURCETYPEOTHERDESC]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get => _closingCost2SourceTypeOtherDescription; set => SetField(ref _closingCost2SourceTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST3CONTRIBUTIONAMOUNT]
        /// </summary>
        public decimal? ClosingCost3ContributionAmount { get => _closingCost3ContributionAmount; set => SetField(ref _closingCost3ContributionAmount, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST3FUNDSTYPE]
        /// </summary>
        public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get => _closingCost3FundsType; set => SetField(ref _closingCost3FundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST3FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
        public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get => _closingCost3FundsTypeOtherDescription; set => SetField(ref _closingCost3FundsTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST3SOURCETYPE]
        /// </summary>
        public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get => _closingCost3SourceType; set => SetField(ref _closingCost3SourceType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST3SOURCETYPEOTHERDESC]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get => _closingCost3SourceTypeOtherDescription; set => SetField(ref _closingCost3SourceTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST4CONTRIBUTIONAMOUNT]
        /// </summary>
        public decimal? ClosingCost4ContributionAmount { get => _closingCost4ContributionAmount; set => SetField(ref _closingCost4ContributionAmount, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST4FUNDSTYPE]
        /// </summary>
        public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get => _closingCost4FundsType; set => SetField(ref _closingCost4FundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST4FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
        public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get => _closingCost4FundsTypeOtherDescription; set => SetField(ref _closingCost4FundsTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST4SOURCETYPE]
        /// </summary>
        public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get => _closingCost4SourceType; set => SetField(ref _closingCost4SourceType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST4SOURCETYPEOTHERDESC]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get => _closingCost4SourceTypeOtherDescription; set => SetField(ref _closingCost4SourceTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.X105]
        /// </summary>
        public decimal? ClosingCostContributionAmount { get => _closingCostContributionAmount; set => SetField(ref _closingCostContributionAmount, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.X106]
        /// </summary>
        public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get => _closingCostFundsType; set => SetField(ref _closingCostFundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.X107]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
        public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get => _closingCostFundsTypeOtherDescription; set => SetField(ref _closingCostFundsTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.X108]
        /// </summary>
        public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get => _closingCostSourceType; set => SetField(ref _closingCostSourceType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.X109]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get => _closingCostSourceTypeOtherDescription; set => SetField(ref _closingCostSourceTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Co-Borrower Country Code [ULDD.X155]
        /// </summary>
        public string? CoBorrowerCountryCode { get => _coBorrowerCountryCode; set => SetField(ref _coBorrowerCountryCode, value); }

        /// <summary>
        /// ULDD - Co-Borrower Mailing Address is same as the Property Address [ULDD.X154]
        /// </summary>
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get => _coBorrowerMailToAddressSameasPropertyIndicator; set => SetField(ref _coBorrowerMailToAddressSameasPropertyIndicator, value); }

        /// <summary>
        /// co Borrower Type [ULDD.X151]
        /// </summary>
        public StringEnumValue<UlddBorrowerType> CoBorrowerType { get => _coBorrowerType; set => SetField(ref _coBorrowerType, value); }

        /// <summary>
        /// ULDD - Project Status Type [ULDD.X28]
        /// </summary>
        public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get => _condominiumProjectStatusType; set => SetField(ref _condominiumProjectStatusType, value); }

        /// <summary>
        /// ULDD Construction Method Type [ULDD.X172]
        /// </summary>
        public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get => _constructionMethodType; set => SetField(ref _constructionMethodType, value); }

        /// <summary>
        /// Construction Method Type [ULDD.GNM.CnstrctnMthdTypOthrDscr]
        /// </summary>
        public string? ConstructionMethodTypeOtherDescription { get => _constructionMethodTypeOtherDescription; set => SetField(ref _constructionMethodTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - Construction - Perm Closing Feature [ULDD.X63]
        /// </summary>
        public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get => _constructionToPermanentClosingFeatureType; set => SetField(ref _constructionToPermanentClosingFeatureType, value); }

        /// <summary>
        /// ULDD - Construction - Perm Closing Type [ULDD.X64]
        /// </summary>
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => _constructionToPermanentClosingType; set => SetField(ref _constructionToPermanentClosingType, value); }

        /// <summary>
        /// ULDD - Convertible Status Type [ULDD.X91]
        /// </summary>
        public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get => _convertibleStatusType; set => SetField(ref _convertibleStatusType, value); }

        /// <summary>
        /// ULDD - Counseling Format [ULDD.X24]
        /// </summary>
        public StringEnumValue<CounselingFormatType> CounselingFormatType { get => _counselingFormatType; set => SetField(ref _counselingFormatType, value); }

        /// <summary>
        /// ULDD - Counseling Format Type Other Description [ULDD.X25]
        /// </summary>
        public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get => _counselingFormatTypeOtherDescription; set => SetField(ref _counselingFormatTypeOtherDescription, value); }

        /// <summary>
        /// Counsel Type Other [ULDD.X152]
        /// </summary>
        public StringEnumValue<CounselTypeOther> CounselTypeOther { get => _counselTypeOther; set => SetField(ref _counselTypeOther, value); }

        /// <summary>
        /// ULDD - Country Code [ULDD.X27]
        /// </summary>
        public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

        /// <summary>
        /// ULDD - Credit Repository Source Type [ULDD.X198]
        /// </summary>
        public StringEnumValue<CreditRepositorySourceType> CreditRepositorySourceType { get => _creditRepositorySourceType; set => SetField(ref _creditRepositorySourceType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Credit Score Impairment Type [ULDD.X104]
        /// </summary>
        public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get => _creditScoreImpairmentType; set => SetField(ref _creditScoreImpairmentType, value); }

        /// <summary>
        /// ULDD - Current Accrued Interest [ULDD.X15]
        /// </summary>
        public decimal? CurrentAccruedInterestAmount { get => _currentAccruedInterestAmount; set => SetField(ref _currentAccruedInterestAmount, value); }

        /// <summary>
        /// ULDD - Number of Delinquent Payments Over Past 12 Months [ULDD.X56]
        /// </summary>
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get => _delinquentPaymentsOverPastTwelveMonthsCount; set => SetField(ref _delinquentPaymentsOverPastTwelveMonthsCount, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Document Custodian ID [ULDD.X114]
        /// </summary>
        public string? DocumentCustodianID { get => _documentCustodianID; set => SetField(ref _documentCustodianID, value); }

        /// <summary>
        /// ULDD Ginnie Document Required Indicator [ULDD.GNM.DocReqIndic]
        /// </summary>
        public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get => _documentRequiredIndicator; set => SetField(ref _documentRequiredIndicator, value); }

        /// <summary>
        /// ULDD Ginnie Document Submission Indicator [ULDD.GNM.DocSubmissionIndic]
        /// </summary>
        public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get => _documentSubmissionIndicator; set => SetField(ref _documentSubmissionIndicator, value); }

        /// <summary>
        /// Down Payment Funds Type [ULDD.GNM.DwnPymntFndsType]
        /// </summary>
        public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get => _downPaymentFundsType; set => SetField(ref _downPaymentFundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Down Payment Other Type Description [ULDD.X113]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
        public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get => _downPaymentOtherTypeDescription; set => SetField(ref _downPaymentOtherTypeDescription, value); }

        /// <summary>
        /// ULDD - Down Payment Source Type [ULDD.X89]
        /// </summary>
        public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get => _downPaymentSourceType; set => SetField(ref _downPaymentSourceType, value); }

        /// <summary>
        /// ULDD - Down Payment SourceType Other Description [ULDD.X90]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get => _downPaymentSourceTypeOtherDescription; set => SetField(ref _downPaymentSourceTypeOtherDescription, value); }

        /// <summary>
        /// ULDD - eNote Indicator [ULDD.X196]
        /// </summary>
        public bool? eNoteIndicator { get => _eNoteIndicator; set => SetField(ref _eNoteIndicator, value); }

        /// <summary>
        /// ULDD Fannie ARM Index Type [ULDD.FNM.ARMIndexType]
        /// </summary>
        public StringEnumValue<FannieARMIndexType> FannieARMIndexType { get => _fannieARMIndexType; set => SetField(ref _fannieARMIndexType, value); }

        /// <summary>
        /// Fannie Automatic Underwriting Decision [ULDD.FNM.AutoUWDec]
        /// </summary>
        public StringEnumValue<FannieAutoUWDec> FannieAutoUWDec { get => _fannieAutoUWDec; set => SetField(ref _fannieAutoUWDec, value); }

        /// <summary>
        /// Base LTV Ratio Percent [ULDD.X186]
        /// </summary>
        public int? FannieBLTV { get => _fannieBLTV; set => SetField(ref _fannieBLTV, value); }

        /// <summary>
        /// Uldd FannieBorrowerFirstName
        /// </summary>
        public string? FannieBorrowerFirstName { get => _fannieBorrowerFirstName; set => SetField(ref _fannieBorrowerFirstName, value); }

        /// <summary>
        /// Uldd FannieBorrowerMiddleName
        /// </summary>
        public string? FannieBorrowerMiddleName { get => _fannieBorrowerMiddleName; set => SetField(ref _fannieBorrowerMiddleName, value); }

        /// <summary>
        /// Fannie Buy down Contributer [ULDD.X137]
        /// </summary>
        public StringEnumValue<FannieBuydownContributer> FannieBuydownContributer { get => _fannieBuydownContributer; set => SetField(ref _fannieBuydownContributer, value); }

        /// <summary>
        /// ULDD Fannie Mae MORNETPlus CLTV [ULDD.FNM.MORNET.X76]
        /// </summary>
        public int? FannieCLTV { get => _fannieCLTV; set => SetField(ref _fannieCLTV, value); }

        /// <summary>
        /// Uldd FannieCoBorrowerFirstName
        /// </summary>
        public string? FannieCoBorrowerFirstName { get => _fannieCoBorrowerFirstName; set => SetField(ref _fannieCoBorrowerFirstName, value); }

        /// <summary>
        /// Uldd FannieCoBorrowerMiddleName
        /// </summary>
        public string? FannieCoBorrowerMiddleName { get => _fannieCoBorrowerMiddleName; set => SetField(ref _fannieCoBorrowerMiddleName, value); }

        /// <summary>
        /// Credit Score Provider Name [ULDD.FNM.CreditScoreProviderName]
        /// </summary>
        public string? FannieCreditScoreProviderName { get => _fannieCreditScoreProviderName; set => SetField(ref _fannieCreditScoreProviderName, value); }

        /// <summary>
        /// ULDD Fannie Flood Special Feature Code [ULDD.FNM.FloodSpecialFeatureCode]
        /// </summary>
        public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get => _fannieFloodSpecialFeatureCode; set => SetField(ref _fannieFloodSpecialFeatureCode, value); }

        /// <summary>
        /// ULDD Fannie Mae MORNETPlus HCLTV and HTLTV [ULDD.FNM.MORNET.X77]
        /// </summary>
        public int? FannieHCLTV { get => _fannieHCLTV; set => SetField(ref _fannieHCLTV, value); }

        /// <summary>
        /// ULDD Fannie - Investor Ownership of the Loan [ULDD.FNM.X43]
        /// </summary>
        public int? FannieInvestorOwnershipPercent { get => _fannieInvestorOwnershipPercent; set => SetField(ref _fannieInvestorOwnershipPercent, value); }

        /// <summary>
        /// Borr Fannie Legal Entity Type [ULDD.X120]
        /// </summary>
        public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get => _fannieLegalEntityType; set => SetField(ref _fannieLegalEntityType, value); }

        /// <summary>
        /// Borr Fannie Legal Entity Type Other [ULDD.X122]
        /// </summary>
        public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get => _fannieLegalEntityTypeOther; set => SetField(ref _fannieLegalEntityTypeOther, value); }

        /// <summary>
        /// ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.FNM.X50]
        /// </summary>
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get => _fannieLenderPaidMIInterestRateAdjustmentPercent; set => SetField(ref _fannieLenderPaidMIInterestRateAdjustmentPercent, value); }

        /// <summary>
        /// ULDD Fannie Mae Loan Program Identifier [ULDD.FNM.LoanProgramIdentifier]
        /// </summary>
        public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get => _fannieLoanProgramIdentifier; set => SetField(ref _fannieLoanProgramIdentifier, value); }

        /// <summary>
        /// ULDD Fannie Mae MORNETPlus LTV [ULDD.FNM.MORNET.X75]
        /// </summary>
        public int? FannieLTV { get => _fannieLTV; set => SetField(ref _fannieLTV, value); }

        /// <summary>
        /// Fannie MI Company Name Type Other [ULDD.X136]
        /// </summary>
        public StringEnumValue<FannieMICompanyNameTypeOther> FannieMICompanyNameTypeOther { get => _fannieMICompanyNameTypeOther; set => SetField(ref _fannieMICompanyNameTypeOther, value); }

        /// <summary>
        /// Fannie Insurance Mtg Ins Coverage Factor [ULDD.FNM.430]
        /// </summary>
        public int? FannieMICoveragePercent { get => _fannieMICoveragePercent; set => SetField(ref _fannieMICoveragePercent, value); }

        /// <summary>
        /// ULDD Fannie - Pool Ownership [ULDD.FNM.X70]
        /// </summary>
        public int? FanniePoolOwnershipPercent { get => _fanniePoolOwnershipPercent; set => SetField(ref _fanniePoolOwnershipPercent, value); }

        /// <summary>
        /// Fannie Project Classification Type [ULDD.X142]
        /// </summary>
        public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get => _fannieProjectClassificationType; set => SetField(ref _fannieProjectClassificationType, value); }

        /// <summary>
        /// Property Valuation Form Type [ULDD.FNM.PropertyFormType]
        /// </summary>
        public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get => _fanniePropertyFormType; set => SetField(ref _fanniePropertyFormType, value); }

        /// <summary>
        /// ULDD Trans Details Rate Spread [ULDD.FNM.HMDA.X15]
        /// </summary>
        public decimal? FannieRateSpread { get => _fannieRateSpread; set => SetField(ref _fannieRateSpread, value); }

        /// <summary>
        /// Fannie Refinance Type [ULDD.X129]
        /// </summary>
        public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get => _fannieRefinanceType; set => SetField(ref _fannieRefinanceType, value); }

        /// <summary>
        /// ULDD Fannie Related Investor Loan ID [ULDD.FNM.RelatedInvestorLoanID]
        /// </summary>
        public string? FannieRelatedInvestorLoanID { get => _fannieRelatedInvestorLoanID; set => SetField(ref _fannieRelatedInvestorLoanID, value); }

        /// <summary>
        /// Fannie Related Loan Amortization Type [ULDD.X131]
        /// </summary>
        public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get => _fannieRelatedLoanAmortizationType; set => SetField(ref _fannieRelatedLoanAmortizationType, value); }

        /// <summary>
        /// Fannie Related Loan Lien Position [ULDD.X147]
        /// </summary>
        public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get => _fannieRelatedLoanLienPosition; set => SetField(ref _fannieRelatedLoanLienPosition, value); }

        /// <summary>
        /// Fannie Related Loan Type [ULDD.X128]
        /// </summary>
        public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get => _fannieRelatedLoanType; set => SetField(ref _fannieRelatedLoanType, value); }

        /// <summary>
        /// ULDD Fannie Section of the Act [ULDD.FNM.SectionOfAct]
        /// </summary>
        public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get => _fannieSectionOfAct; set => SetField(ref _fannieSectionOfAct, value); }

        /// <summary>
        /// ULDD Trans Details Total Loan to Value (TLTV) [ULDD.FNM.975]
        /// </summary>
        public int? FannieTLTV { get => _fannieTLTV; set => SetField(ref _fannieTLTV, value); }

        /// <summary>
        /// Fannie Borrower Vesting Borr 1 Corp/Trust Name [ULDD.FNM.1859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FannieTrustName { get => _fannieTrustName; set => SetField(ref _fannieTrustName, value); }

        /// <summary>
        /// Trans Details Loan Type [ULDD.FNM.X1172]
        /// </summary>
        public StringEnumValue<FannnieMortgageType> FannnieMortgageType { get => _fannnieMortgageType; set => SetField(ref _fannnieMortgageType, value); }

        /// <summary>
        /// Financed Unit Count [ULDD.X139]
        /// </summary>
        public int? FinancedUnitCount { get => _financedUnitCount; set => SetField(ref _financedUnitCount, value); }

        /// <summary>
        /// First Rate Change Payment Effective Date [ULDD.X185]
        /// </summary>
        public DateTime? FirstRateChangePaymentEffectiveDate { get => _firstRateChangePaymentEffectiveDate; set => SetField(ref _firstRateChangePaymentEffectiveDate, value); }

        /// <summary>
        /// ULDD - Fannie Mae Home Impovement Product [ULDD.X23]
        /// </summary>
        public StringEnumValue<FNMHomeImprovementProductType> FNMHomeImprovementProductType { get => _fNMHomeImprovementProductType; set => SetField(ref _fNMHomeImprovementProductType, value); }

        /// <summary>
        /// ULDD Freddie ARM Index Type [ULDD.FRE.ARMIndexType]
        /// </summary>
        public StringEnumValue<FreddieARMIndexType> FreddieARMIndexType { get => _freddieARMIndexType; set => SetField(ref _freddieARMIndexType, value); }

        /// <summary>
        /// Freddie Automatic Underwriting Decision [ULDD.FRE.AutoUWDec]
        /// </summary>
        public StringEnumValue<FreddieAutoUWDec> FreddieAutoUWDec { get => _freddieAutoUWDec; set => SetField(ref _freddieAutoUWDec, value); }

        /// <summary>
        /// ULDD Freddie - AVM Model Name Type Other Description [ULDD.FRE.AVMModelNameExpl]
        /// </summary>
        public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAVMModelNameTypeExpl { get => _freddieAVMModelNameTypeExpl; set => SetField(ref _freddieAVMModelNameTypeExpl, value); }

        /// <summary>
        /// Freddie Borr Declarations Alien Status [ULDD.X123]
        /// </summary>
        public StringEnumValue<FreddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get => _freddieBorrowerAlienStatus; set => SetField(ref _freddieBorrowerAlienStatus, value); }

        /// <summary>
        /// Freddie Co Borr Declarations Alien Status [ULDD.X148]
        /// </summary>
        public StringEnumValue<FreddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get => _freddieCoBorrowerAlienStatus; set => SetField(ref _freddieCoBorrowerAlienStatus, value); }

        /// <summary>
        /// Credit Score Provider Name [ULDD.FRE.CreditScoreProviderName]
        /// </summary>
        public string? FreddieCreditScoreProviderName { get => _freddieCreditScoreProviderName; set => SetField(ref _freddieCreditScoreProviderName, value); }

        /// <summary>
        /// ULDD Freddie Down Payment Type [ULDD.FRE.DownPaymentType]
        /// </summary>
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get => _freddieDownPaymentType; set => SetField(ref _freddieDownPaymentType, value); }

        /// <summary>
        /// ULDD - Down Payment 2 Source Type [ULDD.FRE.DownPmt2SourceType]
        /// </summary>
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get => _freddieDownPmt2SourceType; set => SetField(ref _freddieDownPmt2SourceType, value); }

        /// <summary>
        /// ULDD - Down Payment 2 SourceType Other Description [ULDD.FRE.DownPmt2SourceTypeExpl]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get => _freddieDownPmt2SourceTypeExpl; set => SetField(ref _freddieDownPmt2SourceTypeExpl, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 2 Type [ULDD.FRE.DownPmt2Type]
        /// </summary>
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get => _freddieDownPmt2Type; set => SetField(ref _freddieDownPmt2Type, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 2 Type Explanation [ULDD.FRE.DownPmt2TypeExpl]
        /// </summary>
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get => _freddieDownPmt2TypeExpl; set => SetField(ref _freddieDownPmt2TypeExpl, value); }

        /// <summary>
        /// Freddie Down Payment 3 Amount [ULDD.FRE.DownPmt3Amt]
        /// </summary>
        public decimal? FreddieDownPmt3Amt { get => _freddieDownPmt3Amt; set => SetField(ref _freddieDownPmt3Amt, value); }

        /// <summary>
        /// ULDD - Down Payment 3 Source Type [ULDD.FRE.DownPmt3SourceType]
        /// </summary>
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get => _freddieDownPmt3SourceType; set => SetField(ref _freddieDownPmt3SourceType, value); }

        /// <summary>
        /// ULDD - Down Payment 3 SourceType Other Description [ULDD.FRE.DownPmt3SourceTypeExpl]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get => _freddieDownPmt3SourceTypeExpl; set => SetField(ref _freddieDownPmt3SourceTypeExpl, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 3 Type [ULDD.FRE.DownPmt3Type]
        /// </summary>
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get => _freddieDownPmt3Type; set => SetField(ref _freddieDownPmt3Type, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 3 Type Explanation [ULDD.FRE.DownPmt3TypeExpl]
        /// </summary>
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get => _freddieDownPmt3TypeExpl; set => SetField(ref _freddieDownPmt3TypeExpl, value); }

        /// <summary>
        /// Freddie Down Payment 4 Amount [ULDD.FRE.DownPmt4Amt]
        /// </summary>
        public decimal? FreddieDownPmt4Amt { get => _freddieDownPmt4Amt; set => SetField(ref _freddieDownPmt4Amt, value); }

        /// <summary>
        /// ULDD - Down Payment 4 Source Type [ULDD.FRE.DownPmt4SourceType]
        /// </summary>
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get => _freddieDownPmt4SourceType; set => SetField(ref _freddieDownPmt4SourceType, value); }

        /// <summary>
        /// ULDD - Down Payment 4 SourceType Other Description [ULDD.FRE.DownPmt4SourceTypeExpl]
        /// </summary>
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get => _freddieDownPmt4SourceTypeExpl; set => SetField(ref _freddieDownPmt4SourceTypeExpl, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 4 Type [ULDD.FRE.DownPmt4Type]
        /// </summary>
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get => _freddieDownPmt4Type; set => SetField(ref _freddieDownPmt4Type, value); }

        /// <summary>
        /// ULDD Freddie Down Payment 4 Type Explanation [ULDD.FRE.DownPmt4TypeExpl]
        /// </summary>
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get => _freddieDownPmt4TypeExpl; set => SetField(ref _freddieDownPmt4TypeExpl, value); }

        /// <summary>
        /// ULDD Freddie Explanation of Down Payment [ULDD.FRE.ExplanationOfDownPayment]
        /// </summary>
        public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get => _freddieExplanationOfDownPayment; set => SetField(ref _freddieExplanationOfDownPayment, value); }

        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X95]
        /// </summary>
        public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get => _freddieInvestorCollateralProgramIdentifier; set => SetField(ref _freddieInvestorCollateralProgramIdentifier, value); }

        /// <summary>
        /// ULDD - Freddie Investor Feature ID [ULDD.X179]
        /// </summary>
        public string? FreddieInvestorFeatureIdentifier { get => _freddieInvestorFeatureIdentifier; set => SetField(ref _freddieInvestorFeatureIdentifier, value); }

        /// <summary>
        /// Borr Freddie Legal Entity Type [ULDD.X119]
        /// </summary>
        public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get => _freddieLegalEntityType; set => SetField(ref _freddieLegalEntityType, value); }

        /// <summary>
        /// Borr Freddie Legal Entity Type Other [ULDD.X121]
        /// </summary>
        public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get => _freddieLegalEntityTypeOther; set => SetField(ref _freddieLegalEntityTypeOther, value); }

        /// <summary>
        /// ULDD Freddie Loan Program Identifier [ULDD.FRE.LoanProgramIdentifier]
        /// </summary>
        public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get => _freddieLoanProgramIdentifier; set => SetField(ref _freddieLoanProgramIdentifier, value); }

        /// <summary>
        /// Freddie Loan Type Other [ULDD.X153]
        /// </summary>
        public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get => _freddieLoanTypePublicAndIndianHousingIndicator; set => SetField(ref _freddieLoanTypePublicAndIndianHousingIndicator, value); }

        /// <summary>
        /// Freddie MI Company Name Type Other [ULDD.X135]
        /// </summary>
        public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMICompanyNameTypeOther { get => _freddieMICompanyNameTypeOther; set => SetField(ref _freddieMICompanyNameTypeOther, value); }

        /// <summary>
        /// Trans Details Loan Type [ULDD.FRE.X1172]
        /// </summary>
        public StringEnumValue<FreddieMortgageType> FreddieMortgageType { get => _freddieMortgageType; set => SetField(ref _freddieMortgageType, value); }

        /// <summary>
        /// Freddie Project Classification Type [ULDD.X141]
        /// </summary>
        public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get => _freddieProjectClassificationType; set => SetField(ref _freddieProjectClassificationType, value); }

        /// <summary>
        /// Property Valuation Form Type [ULDD.FRE.PropertyFormType]
        /// </summary>
        public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get => _freddiePropertyFormType; set => SetField(ref _freddiePropertyFormType, value); }

        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X180]
        /// </summary>
        public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get => _freddieRefinanceCashOutDeterminationType; set => SetField(ref _freddieRefinanceCashOutDeterminationType, value); }

        /// <summary>
        /// Freddie Refinance Type [ULDD.X130]
        /// </summary>
        public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get => _freddieRefinanceType; set => SetField(ref _freddieRefinanceType, value); }

        /// <summary>
        /// ULDD Freddie Related Closed End Second Indicator [ULDD.FRE.RelatedClosedEndSecondIndicator]
        /// </summary>
        public bool? FreddieRelatedClosedEndSecondIndicator { get => _freddieRelatedClosedEndSecondIndicator; set => SetField(ref _freddieRelatedClosedEndSecondIndicator, value); }

        /// <summary>
        /// ULDD Freddie Related Investor Loan ID [ULDD.FRE.RelatedInvestorLoanID]
        /// </summary>
        public string? FreddieRelatedInvestorLoanID { get => _freddieRelatedInvestorLoanID; set => SetField(ref _freddieRelatedInvestorLoanID, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Related Loan Investor Type [ULDD.X99]
        /// </summary>
        public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get => _freddieRelatedLoanInvestorType; set => SetField(ref _freddieRelatedLoanInvestorType, value); }

        /// <summary>
        /// Uldd FreddieRelatedLoanLienPosition [ULDD.X145]
        /// </summary>
        public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get => _freddieRelatedLoanLienPosition; set => SetField(ref _freddieRelatedLoanLienPosition, value); }

        /// <summary>
        /// Freddie Related Loan Type [ULDD.X127]
        /// </summary>
        public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get => _freddieRelatedLoanType; set => SetField(ref _freddieRelatedLoanType, value); }

        /// <summary>
        /// ULDD Freddie Section of the Act [ULDD.FRE.SectionOfAct]
        /// </summary>
        public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get => _freddieSectionOfAct; set => SetField(ref _freddieSectionOfAct, value); }

        /// <summary>
        /// Freddie Underwriting Type Other [ULDD.X149]
        /// </summary>
        public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get => _freddieUnderwritingTypeOther; set => SetField(ref _freddieUnderwritingTypeOther, value); }

        /// <summary>
        /// ULDD Construction Method Type [ULDD.X187]
        /// </summary>
        public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get => _ginnieConstructionMethodType; set => SetField(ref _ginnieConstructionMethodType, value); }

        /// <summary>
        /// ULDD Ginnie Government Annual Premium Amount [ULDD.GNM.GovAnnlPrmAmt]
        /// </summary>
        public decimal? GinnieGovernmentAnnualPremiumAmount { get => _ginnieGovernmentAnnualPremiumAmount; set => SetField(ref _ginnieGovernmentAnnualPremiumAmount, value); }

        /// <summary>
        /// Trans Details Loan Type [ULDD.GNM.X1172]
        /// </summary>
        public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get => _ginnieMortgageType; set => SetField(ref _ginnieMortgageType, value); }

        /// <summary>
        /// ULDD Other Construction Method Type [ULDD.X188]
        /// </summary>
        public string? GinnieOtherConstructionMethodType { get => _ginnieOtherConstructionMethodType; set => SetField(ref _ginnieOtherConstructionMethodType, value); }

        /// <summary>
        /// Government Annual Premium Percent [ULDD.GNM.GovAnnlPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GovernmentAnnualPremiumPercent { get => _governmentAnnualPremiumPercent; set => SetField(ref _governmentAnnualPremiumPercent, value); }

        /// <summary>
        /// Government Refinance Type [ULDD.GNM.GovRefType]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"FullDocumentation\":\"FullDocumentation\",\"InterestRateReductionRefinanceLoan\":\"InterestRateReductionRefinanceLoan\",\"StreamlineWithAppraisal\":\"StreamlineWithAppraisal\",\"StreamlineWithoutAppraisal\":\"StreamlineWithoutAppraisal\"}")]
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => _governmentRefinanceType; set => SetField(ref _governmentRefinanceType, value); }

        /// <summary>
        /// Government Upfront Premium Amount [ULDD.GNM.GovUpFrontPrmAmt]
        /// </summary>
        public decimal? GovernmentUpfrontPremiumAmount { get => _governmentUpfrontPremiumAmount; set => SetField(ref _governmentUpfrontPremiumAmount, value); }

        /// <summary>
        /// Government Upfront Premium Percent [ULDD.GNM.GovUpFrontPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GovernmentUpfrontPremiumPercent { get => _governmentUpfrontPremiumPercent; set => SetField(ref _governmentUpfrontPremiumPercent, value); }

        /// <summary>
        /// Subject Property Project Classification [ULDD.X182]
        /// </summary>
        public StringEnumValue<GSEProjectType> GSEProjectType { get => _gSEProjectType; set => SetField(ref _gSEProjectType, value); }

        /// <summary>
        /// ULDD - Guaranty Fee Add On [ULDD.X96]
        /// </summary>
        public bool? GuaranteeFeeAddOnIndicator { get => _guaranteeFeeAddOnIndicator; set => SetField(ref _guaranteeFeeAddOnIndicator, value); }

        /// <summary>
        /// ULDD - Guaranty Fee After Alternate Payment Method [ULDD.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get => _guarantyFeeAfterAlternatePaymentMethodPercent; set => SetField(ref _guarantyFeeAfterAlternatePaymentMethodPercent, value); }

        /// <summary>
        /// ULDD - Guaranty Fee [ULDD.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GuarantyFeePercent { get => _guarantyFeePercent; set => SetField(ref _guarantyFeePercent, value); }

        /// <summary>
        /// Guaranty Percent [ULDD.GNM.GrntyPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GuarantyPercent { get => _guarantyPercent; set => SetField(ref _guarantyPercent, value); }

        /// <summary>
        /// ULDD Home Owner Association EIN [ULDD.X192]
        /// </summary>
        public string? HomeOwnerAssociationEin { get => _homeOwnerAssociationEin; set => SetField(ref _homeOwnerAssociationEin, value); }

        /// <summary>
        /// Uldd Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Index Type [ULDD.GNM.IndxType]
        /// </summary>
        public StringEnumValue<IndexType> IndexType { get => _indexType; set => SetField(ref _indexType, value); }

        /// <summary>
        /// ULDD - Initial Fixed Period [ULDD.X6]
        /// </summary>
        public int? InitialFixedPeriodEffectiveMonthsCount { get => _initialFixedPeriodEffectiveMonthsCount; set => SetField(ref _initialFixedPeriodEffectiveMonthsCount, value); }

        /// <summary>
        /// ULDD - Interest Accrual Type [ULDD.X12]
        /// </summary>
        public StringEnumValue<InterestAccrualType> InterestAccrualType { get => _interestAccrualType; set => SetField(ref _interestAccrualType, value); }

        /// <summary>
        /// ULDD - Interest and Payment Adjustment Index Lead Days [ULDD.X10]
        /// </summary>
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get => _interestAndPaymentAdjustmentIndexLeadDaysCount; set => SetField(ref _interestAndPaymentAdjustmentIndexLeadDaysCount, value); }

        /// <summary>
        /// ULDD - Interest Calculation Basis Type [ULDD.X13]
        /// </summary>
        public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get => _interestCalculationBasisType; set => SetField(ref _interestCalculationBasisType, value); }

        /// <summary>
        /// ULDD - Interest Calculation Effective Months [ULDD.X14]
        /// </summary>
        public int? InterestCalculationEffectiveMonthsCount { get => _interestCalculationEffectiveMonthsCount; set => SetField(ref _interestCalculationEffectiveMonthsCount, value); }

        /// <summary>
        /// ULDD - Interest Calculation Type [ULDD.X11]
        /// </summary>
        public StringEnumValue<InterestCalculationType> InterestCalculationType { get => _interestCalculationType; set => SetField(ref _interestCalculationType, value); }

        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X38]
        /// </summary>
        public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get => _investorCollateralProgramIdentifier; set => SetField(ref _investorCollateralProgramIdentifier, value); }

        /// <summary>
        /// ULDD - Investor Commitment ID [ULDD.X37]
        /// </summary>
        public string? InvestorCommitmentIdentifier { get => _investorCommitmentIdentifier; set => SetField(ref _investorCommitmentIdentifier, value); }

        /// <summary>
        /// ULDD - Investor Feature ID [ULDD.X36]
        /// </summary>
        public string? InvestorFeatureIdentifier { get => _investorFeatureIdentifier; set => SetField(ref _investorFeatureIdentifier, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Investor Feature ID Pool [ULDD.X115]
        /// </summary>
        public string? InvestorFeatureIdPool { get => _investorFeatureIdPool; set => SetField(ref _investorFeatureIdPool, value); }

        /// <summary>
        /// ULDD - Investor Ownership of the Loan [ULDD.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InvestorOwnershipPercent { get => _investorOwnershipPercent; set => SetField(ref _investorOwnershipPercent, value); }

        /// <summary>
        /// ULDD - Investor Product Plan ID [ULDD.X35]
        /// </summary>
        public string? InvestorProductPlanIdentifier { get => _investorProductPlanIdentifier; set => SetField(ref _investorProductPlanIdentifier, value); }

        /// <summary>
        /// ULDD - Investor Remittance Day [ULDD.X45]
        /// </summary>
        public int? InvestorRemittanceDay { get => _investorRemittanceDay; set => SetField(ref _investorRemittanceDay, value); }

        /// <summary>
        /// ULDD - Investor Remittance Type [ULDD.X44]
        /// </summary>
        public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get => _investorRemittanceType; set => SetField(ref _investorRemittanceType, value); }

        /// <summary>
        /// ULDD Ginnie Issuer Identifier [ULDD.GNM.IssuerId]
        /// </summary>
        public string? IssuerIdentifier { get => _issuerIdentifier; set => SetField(ref _issuerIdentifier, value); }

        /// <summary>
        /// ULDD - Last Paid Installment Due Date [ULDD.X54]
        /// </summary>
        public DateTime? LastPaidInstallmentDueDate { get => _lastPaidInstallmentDueDate; set => SetField(ref _lastPaidInstallmentDueDate, value); }

        /// <summary>
        /// ULDD - Last Payment Received Date [ULDD.X53]
        /// </summary>
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => SetField(ref _lastPaymentReceivedDate, value); }

        /// <summary>
        /// ULDD - Latest Conversion Effective Date [ULDD.X92]
        /// </summary>
        public DateTime? LatestConversionEffectiveDate { get => _latestConversionEffectiveDate; set => SetField(ref _latestConversionEffectiveDate, value); }

        /// <summary>
        /// ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get => _lenderPaidMIInterestRateAdjustmentPercent; set => SetField(ref _lenderPaidMIInterestRateAdjustmentPercent, value); }

        /// <summary>
        /// Lender's Delivery Date [ULDD.X133]
        /// </summary>
        public DateTime? LendersDeliveryDate { get => _lendersDeliveryDate; set => SetField(ref _lendersDeliveryDate, value); }

        /// <summary>
        /// ULDD - Loan Acquisition UPB [ULDD.X42]
        /// </summary>
        public decimal? LoanAcquisitionScheduledUPBAmount { get => _loanAcquisitionScheduledUPBAmount; set => SetField(ref _loanAcquisitionScheduledUPBAmount, value); }

        /// <summary>
        /// ULDD - Maximum Amortization Term [ULDD.X19]
        /// </summary>
        public int? LoanAmortizationMaximumTermMonthsCount { get => _loanAmortizationMaximumTermMonthsCount; set => SetField(ref _loanAmortizationMaximumTermMonthsCount, value); }

        /// <summary>
        /// ULDD - Loan Level Basis Points [ULDD.X98]
        /// </summary>
        public int? LoanBuyupBuydownBasisPointNumber { get => _loanBuyupBuydownBasisPointNumber; set => SetField(ref _loanBuyupBuydownBasisPointNumber, value); }

        /// <summary>
        /// ULDD - Loan Feature [ULDD.X97]
        /// </summary>
        public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get => _loanBuyupBuydownType; set => SetField(ref _loanBuyupBuydownType, value); }

        /// <summary>
        /// ULDD - Loan Default Loss Party [ULDD.X47]
        /// </summary>
        public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get => _loanDefaultLossPartyType; set => SetField(ref _loanDefaultLossPartyType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Loan delivered through the servicing released process [ULDD.X100]
        /// </summary>
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get => _loanDeliveredThroughServicingReleasedProcessIndicator; set => SetField(ref _loanDeliveredThroughServicingReleasedProcessIndicator, value); }

        /// <summary>
        /// ULDD Loan Identifier Value Type [ULDD.LoanIdentifierValueType]
        /// </summary>
        public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get => _loanIdentifierValueType; set => SetField(ref _loanIdentifierValueType, value); }

        /// <summary>
        /// ULDD - Loan Interest Accrual Start Date [ULDD.X16]
        /// </summary>
        public DateTime? LoanInterestAccrualStartDate { get => _loanInterestAccrualStartDate; set => SetField(ref _loanInterestAccrualStartDate, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description [ULDD.X103]
        /// </summary>
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; set => SetField(ref _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score  Method [ULDD.X102]
        /// </summary>
        public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get => _loanLevelCreditScoreSelectionMethodType; set => SetField(ref _loanLevelCreditScoreSelectionMethodType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Value [ULDD.X101]
        /// </summary>
        public int? LoanLevelCreditScoreValue { get => _loanLevelCreditScoreValue; set => SetField(ref _loanLevelCreditScoreValue, value); }

        /// <summary>
        /// ULDD - Loan Modification Effective Date [ULDD.X5]
        /// </summary>
        public DateTime? LoanModificationEffectiveDate { get => _loanModificationEffectiveDate; set => SetField(ref _loanModificationEffectiveDate, value); }

        /// <summary>
        /// ULDD - Loan State Date [ULDD.X88]
        /// </summary>
        public DateTime? LoanStateDate { get => _loanStateDate; set => SetField(ref _loanStateDate, value); }

        /// <summary>
        /// ULDD Manufactured Home Width Type [ULDD.ManufacturedHomeWidthType]
        /// </summary>
        public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get => _manufacturedHomeWidthType; set => SetField(ref _manufacturedHomeWidthType, value); }

        /// <summary>
        /// ULDD - MBS has weighted Margin [ULDD.X34]
        /// </summary>
        public bool? MBSWeightedMarginIndicator { get => _mBSWeightedMarginIndicator; set => SetField(ref _mBSWeightedMarginIndicator, value); }

        /// <summary>
        /// MERS Original Mortgagee of Record Indicator [ULDD.GNM.MERSOrgnalMrtggeeOfRcrdIndctr]
        /// </summary>
        public StringEnumValue<TrueOrFalse> MERSOriginalMortgageeOfRecordIndicator { get => _mERSOriginalMortgageeOfRecordIndicator; set => SetField(ref _mERSOriginalMortgageeOfRecordIndicator, value); }

        /// <summary>
        /// MI Company Name Type [ULDD.X134]
        /// </summary>
        public StringEnumValue<MICompanyNameType> MICompanyNameType { get => _mICompanyNameType; set => SetField(ref _mICompanyNameType, value); }

        /// <summary>
        /// ULDD - Mortgage Insurance Premium Source Type [ULDD.X49]
        /// </summary>
        public StringEnumValue<MIPremiumSourceType> MIPremiumSourceType { get => _mIPremiumSourceType; set => SetField(ref _mIPremiumSourceType, value); }

        /// <summary>
        /// Monetary Event Applied Date [ULDD.GNM.MntryEvntAppldDt]
        /// </summary>
        public DateTime? MonetaryEventAppliedDate { get => _monetaryEventAppliedDate; set => SetField(ref _monetaryEventAppliedDate, value); }

        /// <summary>
        /// Monetary Event Gross Principal Amount [ULDD.GNM.MntryEvntGrssPrncpalAmnt]
        /// </summary>
        public decimal? MonetaryEventGrossPrincipalAmount { get => _monetaryEventGrossPrincipalAmount; set => SetField(ref _monetaryEventGrossPrincipalAmount, value); }

        /// <summary>
        /// Monetary Event Type [ULDD.GNM.MntryEvntTyp]
        /// </summary>
        public StringEnumValue<MonetaryEventType> MonetaryEventType { get => _monetaryEventType; set => SetField(ref _monetaryEventType, value); }

        /// <summary>
        /// ULDD - Mortgage-Backed Security [ULDD.X33]
        /// </summary>
        public bool? MortgageBackedSecurityIndicator { get => _mortgageBackedSecurityIndicator; set => SetField(ref _mortgageBackedSecurityIndicator, value); }

        /// <summary>
        /// ULDD - Mortgage Modification [ULDD.X4]
        /// </summary>
        public bool? MortgageModificationIndicator { get => _mortgageModificationIndicator; set => SetField(ref _mortgageModificationIndicator, value); }

        /// <summary>
        /// Trans Details Mtg Originator [ULDD.GNM.MortgageOriginator]
        /// </summary>
        public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => SetField(ref _mortgageOriginator, value); }

        /// <summary>
        /// Mortgage Program Type [ULDD.GNM.MrtggPrgrmType]
        /// </summary>
        public StringEnumValue<MortgageProgramType> MortgageProgramType { get => _mortgageProgramType; set => SetField(ref _mortgageProgramType, value); }

        /// <summary>
        /// More than one concurrently closing lien on the subject property [ULDD.X124]
        /// </summary>
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; set => SetField(ref _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator, value); }

        /// <summary>
        /// ULDD - Next Rate Adjustment Effective Date [ULDD.X62]
        /// </summary>
        public DateTime? NextRateAdjustmentEffectiveDate { get => _nextRateAdjustmentEffectiveDate; set => SetField(ref _nextRateAdjustmentEffectiveDate, value); }

        /// <summary>
        /// Note Pay To Name [ULDD.X184]
        /// </summary>
        public string? NotePayToName { get => _notePayToName; set => SetField(ref _notePayToName, value); }

        /// <summary>
        /// Number of Units Sold [ULDD.X138]
        /// </summary>
        public int? NumberOfUnitsSold { get => _numberOfUnitsSold; set => SetField(ref _numberOfUnitsSold, value); }

        /// <summary>
        /// Other Down Payment Funds Type [ULDD.GNM.OtherDwnPymntFndsType]
        /// </summary>
        public string? OtherDownPaymentFundsType { get => _otherDownPaymentFundsType; set => SetField(ref _otherDownPaymentFundsType, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Other Funds Collected at Closing [ULDD.X110]
        /// </summary>
        public decimal? OtherFundsCollectedAtClosingAmount { get => _otherFundsCollectedAtClosingAmount; set => SetField(ref _otherFundsCollectedAtClosingAmount, value); }

        /// <summary>
        /// ULDD - Freddie Mac - Other Funds collected at Closing for [ULDD.X111]
        /// </summary>
        public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get => _otherFundsCollectedAtClosingType; set => SetField(ref _otherFundsCollectedAtClosingType, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Payee ID [ULDD.X117]
        /// </summary>
        public string? PayeeID { get => _payeeID; set => SetField(ref _payeeID, value); }

        /// <summary>
        /// ULDD - Billing Statement and Payment Lead Days [ULDD.X55]
        /// </summary>
        public int? PaymentBillingStatementLeadDaysCount { get => _paymentBillingStatementLeadDaysCount; set => SetField(ref _paymentBillingStatementLeadDaysCount, value); }

        /// <summary>
        /// ULDD - Maximum Decrease Rate [ULDD.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PerChangeMaximumDecreaseRatePercent { get => _perChangeMaximumDecreaseRatePercent; set => SetField(ref _perChangeMaximumDecreaseRatePercent, value); }

        /// <summary>
        /// ULDD - Maximum Increase Rate [ULDD.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PerChangeMaximumIncreaseRatePercent { get => _perChangeMaximumIncreaseRatePercent; set => SetField(ref _perChangeMaximumIncreaseRatePercent, value); }

        /// <summary>
        /// ULDD - Payment Adjustment [ULDD.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get => _perChangePrincipalAndInterestPaymentAdjustmentPercent; set => SetField(ref _perChangePrincipalAndInterestPaymentAdjustmentPercent, value); }

        /// <summary>
        /// ULDD - Rate Adjustment Effective Date [ULDD.X58]
        /// </summary>
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get => _perChangeRateAdjustmentEffectiveDate; set => SetField(ref _perChangeRateAdjustmentEffectiveDate, value); }

        /// <summary>
        /// ULDD - Rate Adjustment Frequency [ULDD.X59]
        /// </summary>
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get => _perChangeRateAdjustmentFrequencyMonthsCount; set => SetField(ref _perChangeRateAdjustmentFrequencyMonthsCount, value); }

        /// <summary>
        /// ULDD - Pool Accrual Rate Structure Type [ULDD.X73]
        /// </summary>
        public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get => _poolAccrualRateStructureType; set => SetField(ref _poolAccrualRateStructureType, value); }

        /// <summary>
        /// ULDD - Pool Amortization Type [ULDD.X66]
        /// </summary>
        public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get => _poolAmortizationType; set => SetField(ref _poolAmortizationType, value); }

        /// <summary>
        /// ULDD - Pool Assumability Indicator [ULDD.X83]
        /// </summary>
        public bool? PoolAssumabilityIndicator { get => _poolAssumabilityIndicator; set => SetField(ref _poolAssumabilityIndicator, value); }

        /// <summary>
        /// ULDD - Pool Balloon Indicator [ULDD.X84]
        /// </summary>
        public bool? PoolBalloonIndicator { get => _poolBalloonIndicator; set => SetField(ref _poolBalloonIndicator, value); }

        /// <summary>
        /// ULDD Ginnie Pool Certificate Payment Date [ULDD.GNM.PoolCertPaymtDate]
        /// </summary>
        public DateTime? PoolCertificatePaymentDate { get => _poolCertificatePaymentDate; set => SetField(ref _poolCertificatePaymentDate, value); }

        /// <summary>
        /// ULDD Ginnie Pool Class Type [ULDD.GNM.PoolClassType]
        /// </summary>
        public StringEnumValue<PoolClassType> PoolClassType { get => _poolClassType; set => SetField(ref _poolClassType, value); }

        /// <summary>
        /// ULDD Ginnie Pool Concurrent Transfer Indicator [ULDD.GNM.PoolConcurTrnsfrIndic]
        /// </summary>
        public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get => _poolConcurrentTransferIndicator; set => SetField(ref _poolConcurrentTransferIndicator, value); }

        /// <summary>
        /// ULDD Ginnie Pool Current Loan Count [ULDD.GNM.PoolCurLoanCount]
        /// </summary>
        public int? PoolCurrentLoanCount { get => _poolCurrentLoanCount; set => SetField(ref _poolCurrentLoanCount, value); }

        /// <summary>
        /// ULDD Ginnie Pool Current Princial Balance Amount [ULDD.GNM.PoolCurPrinBalAmt]
        /// </summary>
        public decimal? PoolCurrentPrincipalBalanceAmount { get => _poolCurrentPrincipalBalanceAmount; set => SetField(ref _poolCurrentPrincipalBalanceAmount, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Pool Document Custodian ID [ULDD.X156]
        /// </summary>
        public string? PoolDocumentCustodianID { get => _poolDocumentCustodianID; set => SetField(ref _poolDocumentCustodianID, value); }

        /// <summary>
        /// ULDD - Pool Fixed Servicing Fee Percent [ULDD.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolFixedServicingFeePercent { get => _poolFixedServicingFeePercent; set => SetField(ref _poolFixedServicingFeePercent, value); }

        /// <summary>
        /// ULDD - Pool ID [ULDD.X65]
        /// </summary>
        public string? PoolIdentifier { get => _poolIdentifier; set => SetField(ref _poolIdentifier, value); }

        /// <summary>
        /// ULDD Ginnie Pooling Method Type [ULDD.GNM.PoolingMethodType]
        /// </summary>
        public StringEnumValue<PoolingMethodType> PoolingMethodType { get => _poolingMethodType; set => SetField(ref _poolingMethodType, value); }

        /// <summary>
        /// ULDD Ginnie Pool Interest Adjustment Effective Date [ULDD.GNM.PoolIntAdjEffDate]
        /// </summary>
        public DateTime? PoolInterestAdjustmentEffectiveDate { get => _poolInterestAdjustmentEffectiveDate; set => SetField(ref _poolInterestAdjustmentEffectiveDate, value); }

        /// <summary>
        /// ULDD - Pool Interest Adjustment Index Lead Days [ULDD.X82]
        /// </summary>
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get => _poolInterestAdjustmentIndexLeadDaysCount; set => SetField(ref _poolInterestAdjustmentIndexLeadDaysCount, value); }

        /// <summary>
        /// ULDD - Pool Interest and Payment Adjustment Index Lead Days [ULDD.X81]
        /// </summary>
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; set => SetField(ref _poolInterestAndPaymentAdjustmentIndexLeadDaysCount, value); }

        /// <summary>
        /// ULDD - Pool Interest Only [ULDD.X80]
        /// </summary>
        public bool? PoolInterestOnlyIndicator { get => _poolInterestOnlyIndicator; set => SetField(ref _poolInterestOnlyIndicator, value); }

        /// <summary>
        /// ULDD - Pool Interest Rate Rounding [ULDD.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolInterestRateRoundingPercent { get => _poolInterestRateRoundingPercent; set => SetField(ref _poolInterestRateRoundingPercent, value); }

        /// <summary>
        /// ULDD - Pool Interest Rate Rounding Type [ULDD.X78]
        /// </summary>
        public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get => _poolInterestRateRoundingType; set => SetField(ref _poolInterestRateRoundingType, value); }

        /// <summary>
        /// ULDD - Pool Investor Product Plan ID [ULDD.X67]
        /// </summary>
        public string? PoolInvestorProductPlanIdentifier { get => _poolInvestorProductPlanIdentifier; set => SetField(ref _poolInvestorProductPlanIdentifier, value); }

        /// <summary>
        /// ULDD - Pool Issue Date [ULDD.X68]
        /// </summary>
        public DateTime? PoolIssueDate { get => _poolIssueDate; set => SetField(ref _poolIssueDate, value); }

        /// <summary>
        /// ULDD Ginnie Pool Issuer Transferee [ULDD.GNM.PoolIssuerTransferee]
        /// </summary>
        public string? PoolIssuerTransferee { get => _poolIssuerTransferee; set => SetField(ref _poolIssuerTransferee, value); }

        /// <summary>
        /// ULDD - Pool Margin Rate [ULDD.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolMarginRatePercent { get => _poolMarginRatePercent; set => SetField(ref _poolMarginRatePercent, value); }

        /// <summary>
        /// ULDD Ginnie Pool Maturity Date [ULDD.GNM.PoolMaturityDate]
        /// </summary>
        public DateTime? PoolMaturityDate { get => _poolMaturityDate; set => SetField(ref _poolMaturityDate, value); }

        /// <summary>
        /// ULDD Ginnie Pool Maturity Period Count [ULDD.GNM.PoolMaturityPeriodCount]
        /// </summary>
        public int? PoolMaturityPeriodCount { get => _poolMaturityPeriodCount; set => SetField(ref _poolMaturityPeriodCount, value); }

        /// <summary>
        /// ULDD - Pool Maximum Accrual Rate [ULDD.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolMaximumAccrualRatePercent { get => _poolMaximumAccrualRatePercent; set => SetField(ref _poolMaximumAccrualRatePercent, value); }

        /// <summary>
        /// ULDD - Pool Minimum Accrual Rate [ULDD.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolMinimumAccrualRatePercent { get => _poolMinimumAccrualRatePercent; set => SetField(ref _poolMinimumAccrualRatePercent, value); }

        /// <summary>
        /// ULDD - Pool Mortgage Type [ULDD.X69]
        /// </summary>
        public StringEnumValue<PoolMortgageType> PoolMortgageType { get => _poolMortgageType; set => SetField(ref _poolMortgageType, value); }

        /// <summary>
        /// ULDD - Pool Scheduled Remittance Payment Day [ULDD.X86]
        /// </summary>
        public int? PoolScheduledRemittancePaymentDay { get => _poolScheduledRemittancePaymentDay; set => SetField(ref _poolScheduledRemittancePaymentDay, value); }

        /// <summary>
        /// ULDD - Pool Security Issue Date Interest Rate [ULDD.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PoolSecurityIssueDateInterestRatePercent { get => _poolSecurityIssueDateInterestRatePercent; set => SetField(ref _poolSecurityIssueDateInterestRatePercent, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Pool Seller ID [ULDD.X157]
        /// </summary>
        public string? PoolSellerID { get => _poolSellerID; set => SetField(ref _poolSellerID, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Pool Servicer ID [ULDD.X158]
        /// </summary>
        public string? PoolServicerID { get => _poolServicerID; set => SetField(ref _poolServicerID, value); }

        /// <summary>
        /// ULDD - Pool Structure Type [ULDD.X71]
        /// </summary>
        public StringEnumValue<PoolStructureType> PoolStructureType { get => _poolStructureType; set => SetField(ref _poolStructureType, value); }

        /// <summary>
        /// ULDD - Pool Suffix ID [ULDD.X72]
        /// </summary>
        public string? PoolSuffixIdentifier { get => _poolSuffixIdentifier; set => SetField(ref _poolSuffixIdentifier, value); }

        /// <summary>
        /// ULDD - Price Lock Date Time [ULDD.X17]
        /// </summary>
        public DateTime? PriceLockDatetime { get => _priceLockDatetime; set => SetField(ref _priceLockDatetime, value); }

        /// <summary>
        /// ULDD - Primary Mortgage Insurance Absence Reason [ULDD.X51]
        /// </summary>
        public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMIAbsenceReasonType { get => _primaryMIAbsenceReasonType; set => SetField(ref _primaryMIAbsenceReasonType, value); }

        /// <summary>
        /// ULDD - Primary MI Absence Reason Type Other Description [ULDD.X52]
        /// </summary>
        public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMIAbsenceReasonTypeOtherDescription { get => _primaryMIAbsenceReasonTypeOtherDescription; set => SetField(ref _primaryMIAbsenceReasonTypeOtherDescription, value); }

        /// <summary>
        /// Project Attachment Type [ULDD.X143]
        /// </summary>
        public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get => _projectAttachmentType; set => SetField(ref _projectAttachmentType, value); }

        /// <summary>
        /// Project Design Type [ULDD.X140]
        /// </summary>
        public StringEnumValue<ProjectDesignType> ProjectDesignType { get => _projectDesignType; set => SetField(ref _projectDesignType, value); }

        /// <summary>
        /// ULDD Project Unit Count [ULDD.X176]
        /// </summary>
        public int? ProjectUnitCount { get => _projectUnitCount; set => SetField(ref _projectUnitCount, value); }

        /// <summary>
        /// ULDD - Property Estate Type [ULDD.X197]
        /// </summary>
        public StringEnumValue<PropertyRightsType> PropertyEstateType { get => _propertyEstateType; set => SetField(ref _propertyEstateType, value); }

        /// <summary>
        /// ULDD - Property Valuation Effective Date [ULDD.X30]
        /// </summary>
        public DateTime? PropertyValuationEffectiveDate { get => _propertyValuationEffectiveDate; set => SetField(ref _propertyValuationEffectiveDate, value); }

        /// <summary>
        /// ULDD - Property Valuation Method Type [ULDD.X29]
        /// </summary>
        public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get => _propertyValuationMethodType; set => SetField(ref _propertyValuationMethodType, value); }

        /// <summary>
        /// ULDD Property Valuation Method Type "Other" [ULDD.X190]
        /// </summary>
        public StringEnumValue<PropertyValuationOther> PropertyValuationOther { get => _propertyValuationOther; set => SetField(ref _propertyValuationOther, value); }

        /// <summary>
        /// Refinance Cash Out Amount [ULDD.RefinanceCashOutAmount]
        /// </summary>
        public decimal? RefinanceCashOutAmount { get => _refinanceCashOutAmount; set => SetField(ref _refinanceCashOutAmount, value); }

        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X18]
        /// </summary>
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => _refinanceCashOutDeterminationType; set => SetField(ref _refinanceCashOutDeterminationType, value); }

        /// <summary>
        /// Related Loan Affordable Indicator [ULDD.X194]
        /// </summary>
        public bool? RelatedLoanAffordableIndicator { get => _relatedLoanAffordableIndicator; set => SetField(ref _relatedLoanAffordableIndicator, value); }

        /// <summary>
        /// ULDD Related Loan Balloon Indicator [ULDD.X175]
        /// </summary>
        public bool? RelatedLoanBalloonIndicator { get => _relatedLoanBalloonIndicator; set => SetField(ref _relatedLoanBalloonIndicator, value); }

        /// <summary>
        /// Related Loan HELOC Indicator [ULDD.X132]
        /// </summary>
        public bool? RelatedLoanHELOCIndicator { get => _relatedLoanHELOCIndicator; set => SetField(ref _relatedLoanHELOCIndicator, value); }

        /// <summary>
        /// Related Loan [ULDD.X126]
        /// </summary>
        public bool? RelatedLoanIndicator { get => _relatedLoanIndicator; set => SetField(ref _relatedLoanIndicator, value); }

        /// <summary>
        /// ULDD - Related Loan Investor Type [ULDD.X46]
        /// </summary>
        public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get => _relatedLoanInvestorType; set => SetField(ref _relatedLoanInvestorType, value); }

        /// <summary>
        /// ULDD Related Loan Maturity Period Count [ULDD.X173]
        /// </summary>
        public int? RelatedLoanMaturityPeriodCount { get => _relatedLoanMaturityPeriodCount; set => SetField(ref _relatedLoanMaturityPeriodCount, value); }

        /// <summary>
        /// Related Loan Note Date [ULDD.X183]
        /// </summary>
        public DateTime? RelatedLoanNoteDate { get => _relatedLoanNoteDate; set => SetField(ref _relatedLoanNoteDate, value); }

        /// <summary>
        /// ULDD Related Loan Scheduled First Payment Date [ULDD.X174]
        /// </summary>
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get => _relatedLoanScheduledFirstPaymentDate; set => SetField(ref _relatedLoanScheduledFirstPaymentDate, value); }

        /// <summary>
        /// ULDD - Related Loan State Date At Closing [ULDD.X112]
        /// </summary>
        public DateTime? RelatedLoanStateDateAtClosing { get => _relatedLoanStateDateAtClosing; set => SetField(ref _relatedLoanStateDateAtClosing, value); }

        /// <summary>
        /// ULDD - Related Loan Unpaid Principal Balance Amount [ULDD.X118]
        /// </summary>
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get => _relatedLoanUnpaidPrincipalBalanceAmount; set => SetField(ref _relatedLoanUnpaidPrincipalBalanceAmount, value); }

        /// <summary>
        /// ULDD - Relocation Loan [ULDD.X8]
        /// </summary>
        public bool? RelocationLoanIndicator { get => _relocationLoanIndicator; set => SetField(ref _relocationLoanIndicator, value); }

        /// <summary>
        /// ULDD - REO Marketing Party [ULDD.X48]
        /// </summary>
        public StringEnumValue<PartyType> REOMarketingPartyType { get => _rEOMarketingPartyType; set => SetField(ref _rEOMarketingPartyType, value); }

        /// <summary>
        /// Second lien is being delivered with this loan [ULDD.X125]
        /// </summary>
        public bool? SecondLienIsDeliveredIndicator { get => _secondLienIsDeliveredIndicator; set => SetField(ref _secondLienIsDeliveredIndicator, value); }

        /// <summary>
        /// ULDD Ginnie Security Original Subscription Amount [ULDD.GNM.SecurityOrigSubscrAmt]
        /// </summary>
        public decimal? SecurityOriginalSubscriptionAmount { get => _securityOriginalSubscriptionAmount; set => SetField(ref _securityOriginalSubscriptionAmount, value); }

        /// <summary>
        /// ULDD - Security Trade Book Entry Date [ULDD.X87]
        /// </summary>
        public DateTime? SecurityTradeBookEntryDate { get => _securityTradeBookEntryDate; set => SetField(ref _securityTradeBookEntryDate, value); }

        /// <summary>
        /// Uldd SellerID
        /// </summary>
        public string? SellerID { get => _sellerID; set => SetField(ref _sellerID, value); }

        /// <summary>
        /// ULDD - Seller Loan ID [ULDD.X21]
        /// </summary>
        public string? SellerLoanIdentifier { get => _sellerLoanIdentifier; set => SetField(ref _sellerLoanIdentifier, value); }

        /// <summary>
        /// ULDD - Fannie Mae - Servicer ID [ULDD.X116]
        /// </summary>
        public string? ServicerID { get => _servicerID; set => SetField(ref _servicerID, value); }

        /// <summary>
        /// ULDD - Servicer Loan ID [ULDD.X94]
        /// </summary>
        public string? ServicerLoanIdentifier { get => _servicerLoanIdentifier; set => SetField(ref _servicerLoanIdentifier, value); }

        /// <summary>
        /// ULDD - Shared Equity [ULDD.X9]
        /// </summary>
        public bool? SharedEquityIndicator { get => _sharedEquityIndicator; set => SetField(ref _sharedEquityIndicator, value); }

        /// <summary>
        /// Site Built [ULDD.X144]
        /// </summary>
        public bool? SiteBuiltIndicator { get => _siteBuiltIndicator; set => SetField(ref _siteBuiltIndicator, value); }

        /// <summary>
        /// ULDD Special Flood Hazard Area [ULDD.X178]
        /// </summary>
        public bool? SpecialFloodHazardAreaIndicator { get => _specialFloodHazardAreaIndicator; set => SetField(ref _specialFloodHazardAreaIndicator, value); }

        /// <summary>
        /// ULDD - Subsequent Maximum Decrease Rate [ULDD.X168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get => _subsequentPerChangeMaximumDecreaseRatePercent; set => SetField(ref _subsequentPerChangeMaximumDecreaseRatePercent, value); }

        /// <summary>
        /// ULDD - Subsequent Maximum Increase Rate [ULDD.X169]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get => _subsequentPerChangeMaximumIncreaseRatePercent; set => SetField(ref _subsequentPerChangeMaximumIncreaseRatePercent, value); }

        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Effective Date [ULDD.X166]
        /// </summary>
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get => _subsequentPerChangeRateAdjustmentEffectiveDate; set => SetField(ref _subsequentPerChangeRateAdjustmentEffectiveDate, value); }

        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Frequency [ULDD.X167]
        /// </summary>
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; set => SetField(ref _subsequentPerChangeRateAdjustmentFrequencyMonthsCount, value); }

        /// <summary>
        /// ULDD - Temporary Buydown [ULDD.X181]
        /// </summary>
        public bool? TemporaryBuydownIndicator { get => _temporaryBuydownIndicator; set => SetField(ref _temporaryBuydownIndicator, value); }

        /// <summary>
        /// Total Mortgaged Properties Count [ULDD.TotalMortgagedPropertiesCount]
        /// </summary>
        public int? TotalMortgagedPropertiesCount { get => _totalMortgagedPropertiesCount; set => SetField(ref _totalMortgagedPropertiesCount, value); }

        /// <summary>
        /// ULDD - First Unit Subject Property Gross Rent [ULDD.X171]
        /// </summary>
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get => _unit1SubjectPropertyGrossRentalIncome; set => SetField(ref _unit1SubjectPropertyGrossRentalIncome, value); }

        /// <summary>
        /// ULDD - First Unit Bedrooms [ULDD.X170]
        /// </summary>
        public int? Unit1TotalBedrooms { get => _unit1TotalBedrooms; set => SetField(ref _unit1TotalBedrooms, value); }

        /// <summary>
        /// ULDD - Second Unit Subject Property Gross Rent [ULDD.X161]
        /// </summary>
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get => _unit2SubjectPropertyGrossRentalIncome; set => SetField(ref _unit2SubjectPropertyGrossRentalIncome, value); }

        /// <summary>
        /// ULDD - Second Unit Bedrooms [ULDD.X160]
        /// </summary>
        public int? Unit2TotalBedrooms { get => _unit2TotalBedrooms; set => SetField(ref _unit2TotalBedrooms, value); }

        /// <summary>
        /// ULDD - Third Unit Subject Property Gross Rent [ULDD.X163]
        /// </summary>
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get => _unit3SubjectPropertyGrossRentalIncome; set => SetField(ref _unit3SubjectPropertyGrossRentalIncome, value); }

        /// <summary>
        /// ULDD - Third Unit Bedrooms [ULDD.X162]
        /// </summary>
        public int? Unit3TotalBedrooms { get => _unit3TotalBedrooms; set => SetField(ref _unit3TotalBedrooms, value); }

        /// <summary>
        /// ULDD - Fourth Unit Subject Property Gross Rent [ULDD.X165]
        /// </summary>
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get => _unit4SubjectPropertyGrossRentalIncome; set => SetField(ref _unit4SubjectPropertyGrossRentalIncome, value); }

        /// <summary>
        /// ULDD - Fourth Unit Bedrooms [ULDD.X164]
        /// </summary>
        public int? Unit4TotalBedrooms { get => _unit4TotalBedrooms; set => SetField(ref _unit4TotalBedrooms, value); }

        /// <summary>
        /// ULDD - Unpaid Principal Balance Amount [ULDD.X1]
        /// </summary>
        public decimal? UPBAmount { get => _uPBAmount; set => SetField(ref _uPBAmount, value); }

        /// <summary>
        /// ULDD WareHouse Lender ID [ULDD.X191]
        /// </summary>
        public string? WareHouseLenderId { get => _wareHouseLenderId; set => SetField(ref _wareHouseLenderId, value); }

        /// <summary>
        /// WareHouse Lender Indicator [ULDD.X193]
        /// </summary>
        public bool? WareHouseLenderIndicator { get => _wareHouseLenderIndicator; set => SetField(ref _wareHouseLenderIndicator, value); }
    }
}