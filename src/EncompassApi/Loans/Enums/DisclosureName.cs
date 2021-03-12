using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DisclosureName
    /// </summary>
    public enum DisclosureName
    {
        /// <summary>
        /// TrusteeName
        /// </summary>
        TrusteeName = 0,
        /// <summary>
        /// TrusteeTitle
        /// </summary>
        TrusteeTitle = 1,
        /// <summary>
        /// TrustAgreementDate
        /// </summary>
        TrustAgreementDate = 2,
        /// <summary>
        /// TrustNumber
        /// </summary>
        TrustNumber = 3,
        /// <summary>
        /// LendersRepresentativeName
        /// </summary>
        LendersRepresentativeName = 4,
        /// <summary>
        /// LenderRepresentativeTitle
        /// </summary>
        LenderRepresentativeTitle = 5,
        /// <summary>
        /// LenderInstitutionalTrustee
        /// </summary>
        LenderInstitutionalTrustee = 6,
        /// <summary>
        /// LTVReaches78OrLess
        /// </summary>
        LTVReaches78OrLess = 7,
        /// <summary>
        /// LTVReaches80OrLess
        /// </summary>
        LTVReaches80OrLess = 8,
        /// <summary>
        /// PMICancellationConditionsOtherStatus1
        /// </summary>
        PMICancellationConditionsOtherStatus1 = 9,
        /// <summary>
        /// PMICancellationConditionsOtherStatus2
        /// </summary>
        PMICancellationConditionsOtherStatus2 = 10,
        /// <summary>
        /// PMICancellationConditionsOtherText1
        /// </summary>
        PMICancellationConditionsOtherText1 = 11,
        /// <summary>
        /// PMICancellationConditionsOtherText2
        /// </summary>
        PMICancellationConditionsOtherText2 = 12,
        /// <summary>
        /// ImpCostPriorClosingAmount
        /// </summary>
        ImpCostPriorClosingAmount = 13,
        /// <summary>
        /// ConstructionCommitmentLetter_AssumptionConditions
        /// </summary>
        [EnumMember(Value = "ConstructionCommitmentLetter_AssumptionConditions")]
        ConstructionCommitmentLetterAssumptionConditions = 14,
        /// <summary>
        /// MoneyLien_MortgageAssignedTo
        /// </summary>
        [EnumMember(Value = "MoneyLien_MortgageAssignedTo")]
        MoneyLienMortgageAssignedTo = 15,
        /// <summary>
        /// MoneyLien_AssignmentDated
        /// </summary>
        [EnumMember(Value = "MoneyLien_AssignmentDated")]
        MoneyLienAssignmentDated = 16,
        /// <summary>
        /// MoneyLien_AssignmentRecordedDate
        /// </summary>
        [EnumMember(Value = "MoneyLien_AssignmentRecordedDate")]
        MoneyLienAssignmentRecordedDate = 17,
        /// <summary>
        /// MoneyLien_AssignmentRecordedTitle
        /// </summary>
        [EnumMember(Value = "MoneyLien_AssignmentRecordedTitle")]
        MoneyLienAssignmentRecordedTitle = 18,
        /// <summary>
        /// MoneyLien_AssignmentRecordedJurisdiction
        /// </summary>
        [EnumMember(Value = "MoneyLien_AssignmentRecordedJurisdiction")]
        MoneyLienAssignmentRecordedJurisdiction = 19,
        /// <summary>
        /// MoneyLien1_MortgageHolder
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageHolder")]
        MoneyLien1MortgageHolder = 20,
        /// <summary>
        /// MoneyLien1_MortgageDated
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageDated")]
        MoneyLien1MortgageDated = 21,
        /// <summary>
        /// MoneyLien1_Holder
        /// </summary>
        [EnumMember(Value = "MoneyLien1_Holder")]
        MoneyLien1Holder = 22,
        /// <summary>
        /// MoneyLien1_Principal
        /// </summary>
        [EnumMember(Value = "MoneyLien1_Principal")]
        MoneyLien1Principal = 23,
        /// <summary>
        /// MoneyLien1_UnpaidPrincipal
        /// </summary>
        [EnumMember(Value = "MoneyLien1_UnpaidPrincipal")]
        MoneyLien1UnpaidPrincipal = 24,
        /// <summary>
        /// MoneyLien1_NoteDate
        /// </summary>
        [EnumMember(Value = "MoneyLien1_NoteDate")]
        MoneyLien1NoteDate = 25,
        /// <summary>
        /// MoneyLien1_MortgageAssignedTo
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageAssignedTo")]
        MoneyLien1MortgageAssignedTo = 26,
        /// <summary>
        /// MoneyLien1_AssignmentDated
        /// </summary>
        [EnumMember(Value = "MoneyLien1_AssignmentDated")]
        MoneyLien1AssignmentDated = 27,
        /// <summary>
        /// MoneyLien1_AssignmentRecordedDate
        /// </summary>
        [EnumMember(Value = "MoneyLien1_AssignmentRecordedDate")]
        MoneyLien1AssignmentRecordedDate = 28,
        /// <summary>
        /// MoneyLien1_AssignmentRecordedTitle
        /// </summary>
        [EnumMember(Value = "MoneyLien1_AssignmentRecordedTitle")]
        MoneyLien1AssignmentRecordedTitle = 29,
        /// <summary>
        /// MoneyLien1_AssignmentRecordedJurisdiction
        /// </summary>
        [EnumMember(Value = "MoneyLien1_AssignmentRecordedJurisdiction")]
        MoneyLien1AssignmentRecordedJurisdiction = 30,
        /// <summary>
        /// MoneyLien1_AssignmentRecordedDescription
        /// </summary>
        [EnumMember(Value = "MoneyLien1_AssignmentRecordedDescription")]
        MoneyLien1AssignmentRecordedDescription = 31,
        /// <summary>
        /// MoneyLien2_MortgageHolder
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageHolder")]
        MoneyLien2MortgageHolder = 32,
        /// <summary>
        /// MoneyLien2_MortgageDated
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageDated")]
        MoneyLien2MortgageDated = 33,
        /// <summary>
        /// MoneyLien2_Holder
        /// </summary>
        [EnumMember(Value = "MoneyLien2_Holder")]
        MoneyLien2Holder = 34,
        /// <summary>
        /// MoneyLien2_Principal
        /// </summary>
        [EnumMember(Value = "MoneyLien2_Principal")]
        MoneyLien2Principal = 35,
        /// <summary>
        /// MoneyLien2_UnpaidPrincipal
        /// </summary>
        [EnumMember(Value = "MoneyLien2_UnpaidPrincipal")]
        MoneyLien2UnpaidPrincipal = 36,
        /// <summary>
        /// MoneyLien2_NoteDate
        /// </summary>
        [EnumMember(Value = "MoneyLien2_NoteDate")]
        MoneyLien2NoteDate = 37,
        /// <summary>
        /// MoneyLien2_MortgageAssignedTo
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageAssignedTo")]
        MoneyLien2MortgageAssignedTo = 38,
        /// <summary>
        /// MoneyLien2_AssignmentDated
        /// </summary>
        [EnumMember(Value = "MoneyLien2_AssignmentDated")]
        MoneyLien2AssignmentDated = 39,
        /// <summary>
        /// MoneyLien2_AssignmentRecordedDate
        /// </summary>
        [EnumMember(Value = "MoneyLien2_AssignmentRecordedDate")]
        MoneyLien2AssignmentRecordedDate = 40,
        /// <summary>
        /// MoneyLien2_AssignmentRecordedTitle
        /// </summary>
        [EnumMember(Value = "MoneyLien2_AssignmentRecordedTitle")]
        MoneyLien2AssignmentRecordedTitle = 41,
        /// <summary>
        /// MoneyLien2_AssignmentRecordedJurisdiction
        /// </summary>
        [EnumMember(Value = "MoneyLien2_AssignmentRecordedJurisdiction")]
        MoneyLien2AssignmentRecordedJurisdiction = 42,
        /// <summary>
        /// MoneyLien2_AssignmentRecordedDescription
        /// </summary>
        [EnumMember(Value = "MoneyLien2_AssignmentRecordedDescription")]
        MoneyLien2AssignmentRecordedDescription = 43,
        /// <summary>
        /// RegulatorName
        /// </summary>
        RegulatorName = 44,
        /// <summary>
        /// RegulatorAddress
        /// </summary>
        RegulatorAddress = 45,
        /// <summary>
        /// RegulatorAddress2
        /// </summary>
        RegulatorAddress2 = 46,
        /// <summary>
        /// RegulatorAssignedToServicerCity
        /// </summary>
        RegulatorAssignedToServicerCity = 47,
        /// <summary>
        /// RegulatorAssignedToServicerState
        /// </summary>
        RegulatorAssignedToServicerState = 48,
        /// <summary>
        /// RegulatorAssignedToServicerZipcode
        /// </summary>
        RegulatorAssignedToServicerZipcode = 49,
        /// <summary>
        /// RegulatorAssignedToServicerPhone
        /// </summary>
        RegulatorAssignedToServicerPhone = 50,
        /// <summary>
        /// ApplicationFeeRefundableIndicator
        /// </summary>
        ApplicationFeeRefundableIndicator = 51,
        /// <summary>
        /// OriginationFeeRefundableIndicator
        /// </summary>
        OriginationFeeRefundableIndicator = 52,
        /// <summary>
        /// LockinFeeRefundableIndicator
        /// </summary>
        LockinFeeRefundableIndicator = 53,
        /// <summary>
        /// CommitmentFeeRefundableIndicator
        /// </summary>
        CommitmentFeeRefundableIndicator = 54,
        /// <summary>
        /// DiscountPointsRefundableIndicator
        /// </summary>
        DiscountPointsRefundableIndicator = 55,
        /// <summary>
        /// BrokerFeeRefundableIndicator
        /// </summary>
        BrokerFeeRefundableIndicator = 56,
        /// <summary>
        /// AppraisalFeeRefundableIndicator
        /// </summary>
        AppraisalFeeRefundableIndicator = 57,
        /// <summary>
        /// CreditReportFeeRefundableIndicator
        /// </summary>
        CreditReportFeeRefundableIndicator = 58,
        /// <summary>
        /// HOEPADisclosureWaiver
        /// </summary>
        HOEPADisclosureWaiver = 59,
        /// <summary>
        /// IsAdvancePaymentsRequired
        /// </summary>
        IsAdvancePaymentsRequired = 60,
        /// <summary>
        /// IsHighCostLoanCounselingReceived
        /// </summary>
        IsHighCostLoanCounselingReceived = 61,
        /// <summary>
        /// IsHomeContractorPaymentsFromLoan
        /// </summary>
        IsHomeContractorPaymentsFromLoan = 62,
        /// <summary>
        /// IsInterestRateIncreaseAfterDefault
        /// </summary>
        IsInterestRateIncreaseAfterDefault = 63,
        /// <summary>
        /// ReverseMortgageCounselor
        /// </summary>
        ReverseMortgageCounselor = 64,
        /// <summary>
        /// ReverseMortgageDisclosureDate
        /// </summary>
        ReverseMortgageDisclosureDate = 65,
        /// <summary>
        /// SupportRegistrantsName
        /// </summary>
        SupportRegistrantsName = 66,
        /// <summary>
        /// SupportRegistrantsNMLSID
        /// </summary>
        SupportRegistrantsNMLSID = 67,
        /// <summary>
        /// AbbrLegalPage1DeedOfTrust
        /// </summary>
        AbbrLegalPage1DeedOfTrust = 68,
        /// <summary>
        /// BorrowerElectsToPayLowerInterestRateIndicator
        /// </summary>
        BorrowerElectsToPayLowerInterestRateIndicator = 69,
        /// <summary>
        /// TotalInitialAdvanceAtClosing
        /// </summary>
        TotalInitialAdvanceAtClosing = 70,
        /// <summary>
        /// AmountOfInitialAdvance
        /// </summary>
        AmountOfInitialAdvance = 71,
        /// <summary>
        /// MoneyLien_MortgageTaxAmount
        /// </summary>
        [EnumMember(Value = "MoneyLien_MortgageTaxAmount")]
        MoneyLienMortgageTaxAmount = 72,
        /// <summary>
        /// MoneyLien1_MortgageTaxAmount
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageTaxAmount")]
        MoneyLien1MortgageTaxAmount = 73,
        /// <summary>
        /// MoneyLien2_MortgageTaxAmount
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageTaxAmount")]
        MoneyLien2MortgageTaxAmount = 74,
        /// <summary>
        /// TitleInsuranceProducer
        /// </summary>
        TitleInsuranceProducer = 75,
        /// <summary>
        /// TitleInsuranceProducerLicenseNumber
        /// </summary>
        TitleInsuranceProducerLicenseNumber = 76,
        /// <summary>
        /// TitleInsuranceUnderwriterName
        /// </summary>
        TitleInsuranceUnderwriterName = 77,
        /// <summary>
        /// TitleOpinionAttorneyName
        /// </summary>
        TitleOpinionAttorneyName = 78,
        /// <summary>
        /// TitleOpinionAttorneyBarRollNumber
        /// </summary>
        TitleOpinionAttorneyBarRollNumber = 79,
        /// <summary>
        /// LenderNotOfferRateLock
        /// </summary>
        LenderNotOfferRateLock = 80,
        /// <summary>
        /// LenderBrokerAgreed
        /// </summary>
        LenderBrokerAgreed = 81,
        /// <summary>
        /// BrokerHasRateLockAgreement
        /// </summary>
        BrokerHasRateLockAgreement = 82,
        /// <summary>
        /// EmployeeofMortgageLenderOther
        /// </summary>
        EmployeeofMortgageLenderOther = 83,
        /// <summary>
        /// Estimated
        /// </summary>
        Estimated = 84,
        /// <summary>
        /// FrontEndLowAmount
        /// </summary>
        FrontEndLowAmount = 85,
        /// <summary>
        /// BackEndLowAmount
        /// </summary>
        BackEndLowAmount = 86,
        /// <summary>
        /// TotalLowAmount
        /// </summary>
        TotalLowAmount = 87,
        /// <summary>
        /// OtherForms
        /// </summary>
        OtherForms = 88,
        /// <summary>
        /// BrokerInColorado
        /// </summary>
        BrokerInColorado = 89,
        /// <summary>
        /// PMIConditions1
        /// </summary>
        PMIConditions1 = 90,
        /// <summary>
        /// PMIConditions2
        /// </summary>
        PMIConditions2 = 91,
        /// <summary>
        /// PMIConditions3
        /// </summary>
        PMIConditions3 = 92,
        /// <summary>
        /// PMIPercentage
        /// </summary>
        PMIPercentage = 93,
        /// <summary>
        /// ApplicationFeeAmount
        /// </summary>
        ApplicationFeeAmount = 94,
        /// <summary>
        /// CreditReportFeeAmount
        /// </summary>
        CreditReportFeeAmount = 95,
        /// <summary>
        /// AppraisalFeeAmount
        /// </summary>
        AppraisalFeeAmount = 96,
        /// <summary>
        /// OtherFee1Amount
        /// </summary>
        OtherFee1Amount = 97,
        /// <summary>
        /// OtherFee2Amount
        /// </summary>
        OtherFee2Amount = 98,
        /// <summary>
        /// OtherFee3Amount
        /// </summary>
        OtherFee3Amount = 99,
        /// <summary>
        /// OtherFee1Description
        /// </summary>
        OtherFee1Description = 100,
        /// <summary>
        /// OtherFee2Description
        /// </summary>
        OtherFee2Description = 101,
        /// <summary>
        /// OtherFee3Description
        /// </summary>
        OtherFee3Description = 102,
        /// <summary>
        /// OtherFee1Explanation
        /// </summary>
        OtherFee1Explanation = 103,
        /// <summary>
        /// OtherFee2Explanation
        /// </summary>
        OtherFee2Explanation = 104,
        /// <summary>
        /// OtherFee3Explanation
        /// </summary>
        OtherFee3Explanation = 105,
        /// <summary>
        /// CommitmentConditions1
        /// </summary>
        CommitmentConditions1 = 106,
        /// <summary>
        /// CommitmentConditions2
        /// </summary>
        CommitmentConditions2 = 107,
        /// <summary>
        /// CommitmentConditions3
        /// </summary>
        CommitmentConditions3 = 108,
        /// <summary>
        /// MethodOfCommitment
        /// </summary>
        MethodOfCommitment = 109,
        /// <summary>
        /// FinancingExpirationDate
        /// </summary>
        FinancingExpirationDate = 110,
        /// <summary>
        /// FinalAgreement
        /// </summary>
        FinalAgreement = 111,
        /// <summary>
        /// ServicesPerformedBy1
        /// </summary>
        ServicesPerformedBy1 = 112,
        /// <summary>
        /// ServicesPerformedBy2
        /// </summary>
        ServicesPerformedBy2 = 113,
        /// <summary>
        /// ServicesPerformedBy3
        /// </summary>
        ServicesPerformedBy3 = 114,
        /// <summary>
        /// AttorneyServiceHours
        /// </summary>
        AttorneyServiceHours = 115,
        /// <summary>
        /// AttorneyServiceMinutes
        /// </summary>
        AttorneyServiceMinutes = 116,
        /// <summary>
        /// AttorneyHourRate
        /// </summary>
        AttorneyHourRate = 117,
        /// <summary>
        /// TotalAmountAttorneyService
        /// </summary>
        TotalAmountAttorneyService = 118,
        /// <summary>
        /// BasisForAttorneyServices
        /// </summary>
        BasisForAttorneyServices = 119,
        /// <summary>
        /// MandatoryBindingFlag
        /// </summary>
        MandatoryBindingFlag = 120,
        /// <summary>
        /// MDRight
        /// </summary>
        MDRight = 121,
        /// <summary>
        /// MD72HourNotice
        /// </summary>
        MD72HourNotice = 122,
        /// <summary>
        /// LimitedDocumentation
        /// </summary>
        LimitedDocumentation = 123,
        /// <summary>
        /// BorIncomeInLimitedDocument
        /// </summary>
        BorIncomeInLimitedDocument = 124,
        /// <summary>
        /// BorSourceIncomeInLimitedDocument
        /// </summary>
        BorSourceIncomeInLimitedDocument = 125,
        /// <summary>
        /// DiffInRate
        /// </summary>
        DiffInRate = 126,
        /// <summary>
        /// DiffInLoanCharge
        /// </summary>
        DiffInLoanCharge = 127,
        /// <summary>
        /// DiffOtherDescription
        /// </summary>
        DiffOtherDescription = 128,
        /// <summary>
        /// MaxIntRateByBroker
        /// </summary>
        MaxIntRateByBroker = 129,
        /// <summary>
        /// BrokerAgreementExpirationDate
        /// </summary>
        BrokerAgreementExpirationDate = 130,
        /// <summary>
        /// LocationForAdvanceFees
        /// </summary>
        LocationForAdvanceFees = 131,
        /// <summary>
        /// TrustAcctNumber
        /// </summary>
        TrustAcctNumber = 132,
        /// <summary>
        /// BrokerFeesEstimatedAmount
        /// </summary>
        BrokerFeesEstimatedAmount = 133,
        /// <summary>
        /// MaxBrokerFees
        /// </summary>
        MaxBrokerFees = 134,
        /// <summary>
        /// Last12MonthPercentage
        /// </summary>
        Last12MonthPercentage = 135,
        /// <summary>
        /// ServicesByDate
        /// </summary>
        ServicesByDate = 136,
        /// <summary>
        /// MethodForLock
        /// </summary>
        MethodForLock = 137,
        /// <summary>
        /// ReqActionByBorrower1
        /// </summary>
        ReqActionByBorrower1 = 138,
        /// <summary>
        /// ReqActionByBorrower2
        /// </summary>
        ReqActionByBorrower2 = 139,
        /// <summary>
        /// ReqActionByBorrower3
        /// </summary>
        ReqActionByBorrower3 = 140,
        /// <summary>
        /// ReqActionByLender1
        /// </summary>
        ReqActionByLender1 = 141,
        /// <summary>
        /// ReqActionByLender2
        /// </summary>
        ReqActionByLender2 = 142,
        /// <summary>
        /// ReqActionByLender3
        /// </summary>
        ReqActionByLender3 = 143,
        /// <summary>
        /// LowerRatePermittedCondition1
        /// </summary>
        LowerRatePermittedCondition1 = 144,
        /// <summary>
        /// LowerRatePermittedCondition2
        /// </summary>
        LowerRatePermittedCondition2 = 145,
        /// <summary>
        /// LowerRatePermittedCondition3
        /// </summary>
        LowerRatePermittedCondition3 = 146,
        /// <summary>
        /// LowerInvestmentLoan
        /// </summary>
        LowerInvestmentLoan = 147,
        /// <summary>
        /// RateLockAgreement1
        /// </summary>
        RateLockAgreement1 = 148,
        /// <summary>
        /// RateLockAgreement2
        /// </summary>
        RateLockAgreement2 = 149,
        /// <summary>
        /// RateLockAgreement3
        /// </summary>
        RateLockAgreement3 = 150,
        /// <summary>
        /// Commitment1
        /// </summary>
        Commitment1 = 151,
        /// <summary>
        /// Commitment2
        /// </summary>
        Commitment2 = 152,
        /// <summary>
        /// Commitment3
        /// </summary>
        Commitment3 = 153,
        /// <summary>
        /// BrokerNegotiatesWith
        /// </summary>
        BrokerNegotiatesWith = 154,
        /// <summary>
        /// LoanDocumentType
        /// </summary>
        LoanDocumentType = 155,
        /// <summary>
        /// IncomeVerifiedBySalaryDotCom
        /// </summary>
        IncomeVerifiedBySalaryDotCom = 156,
        /// <summary>
        /// IncomeVerifiedByUSDepartment
        /// </summary>
        IncomeVerifiedByUSDepartment = 157,
        /// <summary>
        /// IncomeVerifiedByOther
        /// </summary>
        IncomeVerifiedByOther = 158,
        /// <summary>
        /// LoanDocumentTypeOtherDescription
        /// </summary>
        LoanDocumentTypeOtherDescription = 159,
        /// <summary>
        /// IncomeVerifiedByOtherDescription
        /// </summary>
        IncomeVerifiedByOtherDescription = 160,
        /// <summary>
        /// SalesAgentName
        /// </summary>
        SalesAgentName = 161,
        /// <summary>
        /// RealEstateCompanyName
        /// </summary>
        RealEstateCompanyName = 162,
        /// <summary>
        /// CompanyNameHasBusinessRelationship
        /// </summary>
        CompanyNameHasBusinessRelationship = 163,
        /// <summary>
        /// NatureOfRelationship
        /// </summary>
        NatureOfRelationship = 164,
        /// <summary>
        /// BrokerHasPersonalInvolvement
        /// </summary>
        BrokerHasPersonalInvolvement = 165,
        /// <summary>
        /// BrokerIsOwnedByCompany
        /// </summary>
        BrokerIsOwnedByCompany = 166,
        /// <summary>
        /// RefundableAmount
        /// </summary>
        RefundableAmount = 167,
        /// <summary>
        /// ParticipatingLenders1
        /// </summary>
        ParticipatingLenders1 = 168,
        /// <summary>
        /// ParticipatingLenders2
        /// </summary>
        ParticipatingLenders2 = 169,
        /// <summary>
        /// ParticipatingLenders3
        /// </summary>
        ParticipatingLenders3 = 170,
        /// <summary>
        /// BalloonMortgageGuaranteedByLender
        /// </summary>
        BalloonMortgageGuaranteedByLender = 171,
        /// <summary>
        /// PMINoLongerRequired1
        /// </summary>
        PMINoLongerRequired1 = 172,
        /// <summary>
        /// PMINoLongerRequired2
        /// </summary>
        PMINoLongerRequired2 = 173,
        /// <summary>
        /// ExplanationOther
        /// </summary>
        ExplanationOther = 174,
        /// <summary>
        /// LoanBrokerYears
        /// </summary>
        LoanBrokerYears = 175,
        /// <summary>
        /// BrokerOfficer1
        /// </summary>
        BrokerOfficer1 = 176,
        /// <summary>
        /// BrokerOfficer2
        /// </summary>
        BrokerOfficer2 = 177,
        /// <summary>
        /// BrokerOfficer3
        /// </summary>
        BrokerOfficer3 = 178,
        /// <summary>
        /// BrokerOfficer4
        /// </summary>
        BrokerOfficer4 = 179,
        /// <summary>
        /// BrokerDirector1
        /// </summary>
        BrokerDirector1 = 180,
        /// <summary>
        /// BrokerDirector2
        /// </summary>
        BrokerDirector2 = 181,
        /// <summary>
        /// BrokerDirector3
        /// </summary>
        BrokerDirector3 = 182,
        /// <summary>
        /// BrokerDirector4
        /// </summary>
        BrokerDirector4 = 183,
        /// <summary>
        /// BrokerTrustee1
        /// </summary>
        BrokerTrustee1 = 184,
        /// <summary>
        /// BrokerTrustee2
        /// </summary>
        BrokerTrustee2 = 185,
        /// <summary>
        /// BrokerTrustee3
        /// </summary>
        BrokerTrustee3 = 186,
        /// <summary>
        /// BrokerTrustee4
        /// </summary>
        BrokerTrustee4 = 187,
        /// <summary>
        /// BrokerGeneralPartner1
        /// </summary>
        BrokerGeneralPartner1 = 188,
        /// <summary>
        /// BrokerGeneralPartner2
        /// </summary>
        BrokerGeneralPartner2 = 189,
        /// <summary>
        /// BrokerGeneralPartner3
        /// </summary>
        BrokerGeneralPartner3 = 190,
        /// <summary>
        /// BrokerGeneralPartner4
        /// </summary>
        BrokerGeneralPartner4 = 191,
        /// <summary>
        /// BrokerGeneralManager1
        /// </summary>
        BrokerGeneralManager1 = 192,
        /// <summary>
        /// BrokerGeneralManager2
        /// </summary>
        BrokerGeneralManager2 = 193,
        /// <summary>
        /// BrokerGeneralManager3
        /// </summary>
        BrokerGeneralManager3 = 194,
        /// <summary>
        /// BrokerGeneralManager4
        /// </summary>
        BrokerGeneralManager4 = 195,
        /// <summary>
        /// BrokerPrincipalExecutive1
        /// </summary>
        BrokerPrincipalExecutive1 = 196,
        /// <summary>
        /// BrokerPrincipalExecutive2
        /// </summary>
        BrokerPrincipalExecutive2 = 197,
        /// <summary>
        /// BrokerPrincipalExecutive3
        /// </summary>
        BrokerPrincipalExecutive3 = 198,
        /// <summary>
        /// BrokerPrincipalExecutive4
        /// </summary>
        BrokerPrincipalExecutive4 = 199,
        /// <summary>
        /// BrokerAuthorizedRep1
        /// </summary>
        BrokerAuthorizedRep1 = 200,
        /// <summary>
        /// BrokerAuthorizedRep2
        /// </summary>
        BrokerAuthorizedRep2 = 201,
        /// <summary>
        /// BrokerAuthorizedRep3
        /// </summary>
        BrokerAuthorizedRep3 = 202,
        /// <summary>
        /// BrokerAuthorizedRep4
        /// </summary>
        BrokerAuthorizedRep4 = 203,
        /// <summary>
        /// BrokerEmployee1
        /// </summary>
        BrokerEmployee1 = 204,
        /// <summary>
        /// BrokerEmployee2
        /// </summary>
        BrokerEmployee2 = 205,
        /// <summary>
        /// BrokerEmployee3
        /// </summary>
        BrokerEmployee3 = 206,
        /// <summary>
        /// BrokerEmployee4
        /// </summary>
        BrokerEmployee4 = 207,
        /// <summary>
        /// AccountNumber
        /// </summary>
        AccountNumber = 208,
        /// <summary>
        /// TrustAccountLocation
        /// </summary>
        TrustAccountLocation = 209,
        /// <summary>
        /// ServiceRefundable
        /// </summary>
        ServiceRefundable = 210,
        /// <summary>
        /// EscrowAccountSelected
        /// </summary>
        EscrowAccountSelected = 211,
        /// <summary>
        /// LenderTaxesAndInsurance
        /// </summary>
        LenderTaxesAndInsurance = 212,
        /// <summary>
        /// DirectlyEnter
        /// </summary>
        DirectlyEnter = 213,
        /// <summary>
        /// LoanIsVariableRate
        /// </summary>
        LoanIsVariableRate = 214,
        /// <summary>
        /// LoanIsNotVariableRate
        /// </summary>
        LoanIsNotVariableRate = 215,
        /// <summary>
        /// LoanIsVariableRateChanged
        /// </summary>
        LoanIsVariableRateChanged = 216,
        /// <summary>
        /// LoanIsVariableRateUnknown
        /// </summary>
        LoanIsVariableRateUnknown = 217,
        /// <summary>
        /// LoanHasPrepayPenalty
        /// </summary>
        LoanHasPrepayPenalty = 218,
        /// <summary>
        /// LoanHasNotPrepayPenalty
        /// </summary>
        LoanHasNotPrepayPenalty = 219,
        /// <summary>
        /// LoanHasPrepayPenaltyChanged
        /// </summary>
        LoanHasPrepayPenaltyChanged = 220,
        /// <summary>
        /// LoanHasPrepayPenaltyUnknown
        /// </summary>
        LoanHasPrepayPenaltyUnknown = 221,
        /// <summary>
        /// LoanHasBalloonPayment
        /// </summary>
        LoanHasBalloonPayment = 222,
        /// <summary>
        /// LoanHasNotBalloonPayment
        /// </summary>
        LoanHasNotBalloonPayment = 223,
        /// <summary>
        /// LoanHasBalloonPaymentChanged
        /// </summary>
        LoanHasBalloonPaymentChanged = 224,
        /// <summary>
        /// LoanHasBalloonPaymentUnknown
        /// </summary>
        LoanHasBalloonPaymentUnknown = 225,
        /// <summary>
        /// LoanIsNegativeAmortization
        /// </summary>
        LoanIsNegativeAmortization = 226,
        /// <summary>
        /// LoanIsNotNegativeAmortization
        /// </summary>
        LoanIsNotNegativeAmortization = 227,
        /// <summary>
        /// LoanIsNegativeAmortizationChanged
        /// </summary>
        LoanIsNegativeAmortizationChanged = 228,
        /// <summary>
        /// LoanIsNegativeAmortizationUnknown
        /// </summary>
        LoanIsNegativeAmortizationUnknown = 229,
        /// <summary>
        /// TotalDepositAmount
        /// </summary>
        TotalDepositAmount = 230,
        /// <summary>
        /// LockInDays
        /// </summary>
        LockInDays = 231,
        /// <summary>
        /// AssumptionFees
        /// </summary>
        AssumptionFees = 232,
        /// <summary>
        /// ConditionsToAssumability
        /// </summary>
        ConditionsToAssumability = 233,
        /// <summary>
        /// AssumptionPeriodDescription
        /// </summary>
        AssumptionPeriodDescription = 234,
        /// <summary>
        /// LimitationsOnAssumptionTerm
        /// </summary>
        LimitationsOnAssumptionTerm = 235,
        /// <summary>
        /// CommitmentFeePayWithinDays
        /// </summary>
        CommitmentFeePayWithinDays = 236,
        /// <summary>
        /// PrevailingRateDays
        /// </summary>
        PrevailingRateDays = 237,
        /// <summary>
        /// CommitmentPeriodDays
        /// </summary>
        CommitmentPeriodDays = 238,
        /// <summary>
        /// FrontEndHighAmount
        /// </summary>
        FrontEndHighAmount = 239,
        /// <summary>
        /// BackEndHighAmount
        /// </summary>
        BackEndHighAmount = 240,
        /// <summary>
        /// TotalHighAmount
        /// </summary>
        TotalHighAmount = 241,
        /// <summary>
        /// JudicialDistrict
        /// </summary>
        JudicialDistrict = 242,
        /// <summary>
        /// OriginationFeeRefundable
        /// </summary>
        OriginationFeeRefundable = 243,
        /// <summary>
        /// DiscountFeeRefundable
        /// </summary>
        DiscountFeeRefundable = 244,
        /// <summary>
        /// ProcessingFeeRefundable
        /// </summary>
        ProcessingFeeRefundable = 245,
        /// <summary>
        /// OtherFeeRefundable
        /// </summary>
        OtherFeeRefundable = 246,
        /// <summary>
        /// OtherRefundableDesc1
        /// </summary>
        OtherRefundableDesc1 = 247,
        /// <summary>
        /// OtherRefundableDesc2
        /// </summary>
        OtherRefundableDesc2 = 248,
        /// <summary>
        /// OtherRefundableDesc3
        /// </summary>
        OtherRefundableDesc3 = 249,
        /// <summary>
        /// OtherRefundableDesc4
        /// </summary>
        OtherRefundableDesc4 = 250,
        /// <summary>
        /// OtherRefundableDesc5
        /// </summary>
        OtherRefundableDesc5 = 251,
        /// <summary>
        /// Service1
        /// </summary>
        Service1 = 252,
        /// <summary>
        /// Service2
        /// </summary>
        Service2 = 253,
        /// <summary>
        /// Service3
        /// </summary>
        Service3 = 254,
        /// <summary>
        /// Service4
        /// </summary>
        Service4 = 255,
        /// <summary>
        /// Service5
        /// </summary>
        Service5 = 256,
        /// <summary>
        /// Service6
        /// </summary>
        Service6 = 257,
        /// <summary>
        /// Service7
        /// </summary>
        Service7 = 258,
        /// <summary>
        /// Service8
        /// </summary>
        Service8 = 259,
        /// <summary>
        /// Service9
        /// </summary>
        Service9 = 260,
        /// <summary>
        /// Service10
        /// </summary>
        Service10 = 261,
        /// <summary>
        /// Service11
        /// </summary>
        Service11 = 262,
        /// <summary>
        /// Service12
        /// </summary>
        Service12 = 263,
        /// <summary>
        /// Service13
        /// </summary>
        Service13 = 264,
        /// <summary>
        /// Service14
        /// </summary>
        Service14 = 265,
        /// <summary>
        /// OtherServiceDesc
        /// </summary>
        OtherServiceDesc = 266,
        /// <summary>
        /// RateLockDaysPriorClosing
        /// </summary>
        RateLockDaysPriorClosing = 267,
        /// <summary>
        /// SetRateDaysBeforeLoanCloses
        /// </summary>
        SetRateDaysBeforeLoanCloses = 268,
        /// <summary>
        /// AdditionalConstractual
        /// </summary>
        AdditionalConstractual = 269,
        /// <summary>
        /// PARInterestRate
        /// </summary>
        PARInterestRate = 270,
        /// <summary>
        /// PARInterestRateComparison
        /// </summary>
        PARInterestRateComparison = 271,
        /// <summary>
        /// BrokerTotalOriginationPoints
        /// </summary>
        BrokerTotalOriginationPoints = 272,
        /// <summary>
        /// LessBrokerTotalPoints
        /// </summary>
        LessBrokerTotalPoints = 273,
        /// <summary>
        /// PrepaymentPenaltyFormula
        /// </summary>
        PrepaymentPenaltyFormula = 274,
        /// <summary>
        /// PrevailingRateDaysAt
        /// </summary>
        PrevailingRateDaysAt = 275,
        /// <summary>
        /// CommitmentFeePaidAt
        /// </summary>
        CommitmentFeePaidAt = 276,
        /// <summary>
        /// CommitmentFeePaidOtherDesc
        /// </summary>
        CommitmentFeePaidOtherDesc = 277,
        /// <summary>
        /// LockInFeeMustBePaidAt
        /// </summary>
        LockInFeeMustBePaidAt = 278,
        /// <summary>
        /// LockInFeeMustBePaidOtherDesc
        /// </summary>
        LockInFeeMustBePaidOtherDesc = 279,
        /// <summary>
        /// AmountObtainedIn12Months
        /// </summary>
        AmountObtainedIn12Months = 280,
        /// <summary>
        /// MaterialFactsAffectBorrower
        /// </summary>
        MaterialFactsAffectBorrower = 281,
        /// <summary>
        /// ConditionBorrowerObligated1
        /// </summary>
        ConditionBorrowerObligated1 = 282,
        /// <summary>
        /// ConditionBorrowerObligated2
        /// </summary>
        ConditionBorrowerObligated2 = 283,
        /// <summary>
        /// BrokerNameToDoBusiness
        /// </summary>
        BrokerNameToDoBusiness = 284,
        /// <summary>
        /// AdditionalBrokerEmail
        /// </summary>
        AdditionalBrokerEmail = 285,
        /// <summary>
        /// AdditionalBrokerURL
        /// </summary>
        AdditionalBrokerURL = 286,
        /// <summary>
        /// AgreementCancellationEndsDate
        /// </summary>
        AgreementCancellationEndsDate = 287,
        /// <summary>
        /// BrokerAgentName
        /// </summary>
        BrokerAgentName = 288,
        /// <summary>
        /// BrokerAgentAddress
        /// </summary>
        BrokerAgentAddress = 289,
        /// <summary>
        /// BrokerAgentCity
        /// </summary>
        BrokerAgentCity = 290,
        /// <summary>
        /// BrokerAgentState
        /// </summary>
        BrokerAgentState = 291,
        /// <summary>
        /// BrokerAgentPostalCode
        /// </summary>
        BrokerAgentPostalCode = 292,
        /// <summary>
        /// BrokerAgentPhone
        /// </summary>
        BrokerAgentPhone = 293,
        /// <summary>
        /// BrokerAgentEmail
        /// </summary>
        BrokerAgentEmail = 294,
        /// <summary>
        /// BrokerAgentURL
        /// </summary>
        BrokerAgentURL = 295,
        /// <summary>
        /// LockPeriodExtensionFee
        /// </summary>
        LockPeriodExtensionFee = 296,
        /// <summary>
        /// AuthorizationRequested
        /// </summary>
        AuthorizationRequested = 297,
        /// <summary>
        /// RefuseToAcceptLoanCommitment
        /// </summary>
        RefuseToAcceptLoanCommitment = 298,
        /// <summary>
        /// RefuseToAcceptPercent
        /// </summary>
        RefuseToAcceptPercent = 299,
        /// <summary>
        /// MoneyBrokerContract_DescriptionOfDutiesAndConditions
        /// </summary>
        [EnumMember(Value = "MoneyBrokerContract_DescriptionOfDutiesAndConditions")]
        MoneyBrokerContractDescriptionOfDutiesAndConditions = 300,
        /// <summary>
        /// TotalNonRefundableCosts
        /// </summary>
        TotalNonRefundableCosts = 301,
        /// <summary>
        /// BorrowerReply
        /// </summary>
        BorrowerReply = 302,
        /// <summary>
        /// LenderRoleMayChange
        /// </summary>
        LenderRoleMayChange = 303,
        /// <summary>
        /// DateToDelivered
        /// </summary>
        DateToDelivered = 304,
        /// <summary>
        /// DeliveredLessThan24Hours
        /// </summary>
        DeliveredLessThan24Hours = 305,
        /// <summary>
        /// DeliveredLessThan24HoursExplanation
        /// </summary>
        DeliveredLessThan24HoursExplanation = 306,
        /// <summary>
        /// DateToAccept
        /// </summary>
        DateToAccept = 307,
        /// <summary>
        /// UnderwriterInPrivateBusiness
        /// </summary>
        UnderwriterInPrivateBusiness = 308,
        /// <summary>
        /// ConditionBorrowerObligated3
        /// </summary>
        ConditionBorrowerObligated3 = 309,
        /// <summary>
        /// ConditionBorrowerObligated4
        /// </summary>
        ConditionBorrowerObligated4 = 310,
        /// <summary>
        /// ConditionsChange
        /// </summary>
        ConditionsChange = 311,
        /// <summary>
        /// BorrowerSelectedTitleInsurer
        /// </summary>
        BorrowerSelectedTitleInsurer = 312,
        /// <summary>
        /// BorrowerSelectedTitleInsurerName
        /// </summary>
        BorrowerSelectedTitleInsurerName = 313,
        /// <summary>
        /// BorrowerSelectedTitleInsurerAddress
        /// </summary>
        BorrowerSelectedTitleInsurerAddress = 314,
        /// <summary>
        /// BorrowerSelectedTitleInsurerCity
        /// </summary>
        BorrowerSelectedTitleInsurerCity = 315,
        /// <summary>
        /// BorrowerSelectedTitleInsurerState
        /// </summary>
        BorrowerSelectedTitleInsurerState = 316,
        /// <summary>
        /// BorrowerSelectedTitleInsurerZipcode
        /// </summary>
        BorrowerSelectedTitleInsurerZipcode = 317,
        /// <summary>
        /// BorrowerSelectedTitleInsurerPhone
        /// </summary>
        BorrowerSelectedTitleInsurerPhone = 318,
        /// <summary>
        /// NoticeChange1
        /// </summary>
        NoticeChange1 = 319,
        /// <summary>
        /// NoticeChangeExplanation1
        /// </summary>
        NoticeChangeExplanation1 = 320,
        /// <summary>
        /// NoticeChange2
        /// </summary>
        NoticeChange2 = 321,
        /// <summary>
        /// NoticeChangeExplanation2
        /// </summary>
        NoticeChangeExplanation2 = 322,
        /// <summary>
        /// NoticeChange3
        /// </summary>
        NoticeChange3 = 323,
        /// <summary>
        /// NoticeChangeExplanation3
        /// </summary>
        NoticeChangeExplanation3 = 324,
        /// <summary>
        /// NoticeChange4
        /// </summary>
        NoticeChange4 = 325,
        /// <summary>
        /// NoticeChangeExplanation4
        /// </summary>
        NoticeChangeExplanation4 = 326,
        /// <summary>
        /// NoticeChange5
        /// </summary>
        NoticeChange5 = 327,
        /// <summary>
        /// NoticeChangeExplanation5
        /// </summary>
        NoticeChangeExplanation5 = 328,
        /// <summary>
        /// NoticeChange6
        /// </summary>
        NoticeChange6 = 329,
        /// <summary>
        /// NoticeChangeExplanation6
        /// </summary>
        NoticeChangeExplanation6 = 330,
        /// <summary>
        /// NoticeChange7
        /// </summary>
        NoticeChange7 = 331,
        /// <summary>
        /// NoticeChangeExplanation7
        /// </summary>
        NoticeChangeExplanation7 = 332,
        /// <summary>
        /// BorrowerElectionEscrow
        /// </summary>
        BorrowerElectionEscrow = 333,
        /// <summary>
        /// InterestRatePrepaymentPenalty
        /// </summary>
        InterestRatePrepaymentPenalty = 334,
        /// <summary>
        /// InterestRateNoPrepaymentPenalty
        /// </summary>
        InterestRateNoPrepaymentPenalty = 335,
        /// <summary>
        /// LenderCompensationToBrokerDesc1
        /// </summary>
        LenderCompensationToBrokerDesc1 = 336,
        /// <summary>
        /// LenderCompensationToBrokerAmount1
        /// </summary>
        LenderCompensationToBrokerAmount1 = 337,
        /// <summary>
        /// LenderCompensationToBrokerDesc2
        /// </summary>
        LenderCompensationToBrokerDesc2 = 338,
        /// <summary>
        /// LenderCompensationToBrokerAmount2
        /// </summary>
        LenderCompensationToBrokerAmount2 = 339,
        /// <summary>
        /// LenderCompensationToBrokerDesc3
        /// </summary>
        LenderCompensationToBrokerDesc3 = 340,
        /// <summary>
        /// LenderCompensationToBrokerAmount3
        /// </summary>
        LenderCompensationToBrokerAmount3 = 341,
        /// <summary>
        /// LenderCompensationToBrokerDesc4
        /// </summary>
        LenderCompensationToBrokerDesc4 = 342,
        /// <summary>
        /// LenderCompensationToBrokerAmount4
        /// </summary>
        LenderCompensationToBrokerAmount4 = 343,
        /// <summary>
        /// EffectInterestRateOnBrokerCompensation
        /// </summary>
        EffectInterestRateOnBrokerCompensation = 344,
        /// <summary>
        /// CommitmentFeeToBeChargedIndicator
        /// </summary>
        CommitmentFeeToBeChargedIndicator = 345,
        /// <summary>
        /// ConflictOfInterestRelatedPartyName
        /// </summary>
        ConflictOfInterestRelatedPartyName = 346,
        /// <summary>
        /// MethodUsedToDetermineLockInInterestRateDescription
        /// </summary>
        MethodUsedToDetermineLockInInterestRateDescription = 347,
        /// <summary>
        /// LoanTypeSubjectToChangeIndicator
        /// </summary>
        LoanTypeSubjectToChangeIndicator = 348,
        /// <summary>
        /// LoanAmountSubjectToChangeIndicator
        /// </summary>
        LoanAmountSubjectToChangeIndicator = 349,
        /// <summary>
        /// InterestRateSubjectToChangeIndicator
        /// </summary>
        InterestRateSubjectToChangeIndicator = 350,
        /// <summary>
        /// MethodBasisOrIndexUsedToDetermineInterestRateAtClosingIndicator
        /// </summary>
        MethodBasisOrIndexUsedToDetermineInterestRateAtClosingIndicator = 351,
        /// <summary>
        /// MethodBasisOrIndexUsedToDetermineInterestRateAtClosingDescription
        /// </summary>
        MethodBasisOrIndexUsedToDetermineInterestRateAtClosingDescription = 352,
        /// <summary>
        /// InterestRateEstablishedByLenderIndicator
        /// </summary>
        InterestRateEstablishedByLenderIndicator = 353,
        /// <summary>
        /// DiscountPointsSubjectToChangeIndicator
        /// </summary>
        DiscountPointsSubjectToChangeIndicator = 354,
        /// <summary>
        /// LoanFeesSubjectToChangeIndicator
        /// </summary>
        LoanFeesSubjectToChangeIndicator = 355,
        /// <summary>
        /// OtherTermsOfCommitmentAgreementSubjectToChangeIndicator
        /// </summary>
        OtherTermsOfCommitmentAgreementSubjectToChangeIndicator = 356,
        /// <summary>
        /// OtherTermsOfCommitmentAgreementSubjectToChangeDescription
        /// </summary>
        OtherTermsOfCommitmentAgreementSubjectToChangeDescription = 357,
        /// <summary>
        /// CommitmentAreEstimatesIndicator
        /// </summary>
        CommitmentAreEstimatesIndicator = 358,
        /// <summary>
        /// EstimateWillBeRevisedDescription
        /// </summary>
        EstimateWillBeRevisedDescription = 359,
        /// <summary>
        /// InitialDisclosureProvidedByFaxIndicator
        /// </summary>
        InitialDisclosureProvidedByFaxIndicator = 360,
        /// <summary>
        /// InitialDisclosureProvidedInPersonIndicator
        /// </summary>
        InitialDisclosureProvidedInPersonIndicator = 361,
        /// <summary>
        /// InitialDisclosureProvidedByInternetIndicator
        /// </summary>
        InitialDisclosureProvidedByInternetIndicator = 362,
        /// <summary>
        /// InitialDisclosureProvidedByMailIndicator
        /// </summary>
        InitialDisclosureProvidedByMailIndicator = 363,
        /// <summary>
        /// InitialDisclosureProvidedByOtherMethodTypeIndicator
        /// </summary>
        InitialDisclosureProvidedByOtherMethodTypeIndicator = 364,
        /// <summary>
        /// InitialDisclosureProvidedByOtherMethodTypeDescription
        /// </summary>
        InitialDisclosureProvidedByOtherMethodTypeDescription = 365,
        /// <summary>
        /// PrepaymentPenaltyPlanDescription
        /// </summary>
        PrepaymentPenaltyPlanDescription = 366,
        /// <summary>
        /// PrepaymentPenaltyCostEstimatedAmount
        /// </summary>
        PrepaymentPenaltyCostEstimatedAmount = 367,
        /// <summary>
        /// MaxLTV
        /// </summary>
        MaxLTV = 368,
        /// <summary>
        /// ReceivedSignedApplication
        /// </summary>
        ReceivedSignedApplication = 369,
        /// <summary>
        /// CreditReportIsViewed
        /// </summary>
        CreditReportIsViewed = 370,
        /// <summary>
        /// CreditScoreViewed
        /// </summary>
        CreditScoreViewed = 371,
        /// <summary>
        /// AdditionalItemsViewed
        /// </summary>
        AdditionalItemsViewed = 372,
        /// <summary>
        /// InformationProvidedVerballyIndicator
        /// </summary>
        InformationProvidedVerballyIndicator = 373,
        /// <summary>
        /// InformationProvidedInWritingIndicator
        /// </summary>
        InformationProvidedInWritingIndicator = 374,
        /// <summary>
        /// IncomeProvidedIndicator
        /// </summary>
        IncomeProvidedIndicator = 375,
        /// <summary>
        /// ClosingCostProvidedIndicator
        /// </summary>
        ClosingCostProvidedIndicator = 376,
        /// <summary>
        /// DebtsProvidedIndicator
        /// </summary>
        DebtsProvidedIndicator = 377,
        /// <summary>
        /// OtherAssetsProvidedIndicator
        /// </summary>
        OtherAssetsProvidedIndicator = 378,
        /// <summary>
        /// AdditionalItemsForApproval
        /// </summary>
        AdditionalItemsForApproval = 379,
        /// <summary>
        /// SecondaryFinancingTerms
        /// </summary>
        SecondaryFinancingTerms = 380,
        /// <summary>
        /// CreditReportAndScoreProvidedIndicator
        /// </summary>
        CreditReportAndScoreProvidedIndicator = 381,
        /// <summary>
        /// IncomeVerifiedIndicator
        /// </summary>
        IncomeVerifiedIndicator = 382,
        /// <summary>
        /// ClosingCostVerifiedIndicator
        /// </summary>
        ClosingCostVerifiedIndicator = 383,
        /// <summary>
        /// OtherAssetsVerifiedIndicator
        /// </summary>
        OtherAssetsVerifiedIndicator = 384,
        /// <summary>
        /// AdditionalCondition1
        /// </summary>
        AdditionalCondition1 = 385,
        /// <summary>
        /// AdditionalCondition2
        /// </summary>
        AdditionalCondition2 = 386,
        /// <summary>
        /// AdditionalCondition3
        /// </summary>
        AdditionalCondition3 = 387,
        /// <summary>
        /// AdditionalCondition4
        /// </summary>
        AdditionalCondition4 = 388,
        /// <summary>
        /// ConditionalApprovalExpirationDate
        /// </summary>
        ConditionalApprovalExpirationDate = 389,
        /// <summary>
        /// Texas50a4
        /// </summary>
        Texas50a4 = 390,
        /// <summary>
        /// AdvanceFeeRefundCondition1
        /// </summary>
        AdvanceFeeRefundCondition1 = 391,
        /// <summary>
        /// AdvanceFeeRefundCondition2
        /// </summary>
        AdvanceFeeRefundCondition2 = 392,
        /// <summary>
        /// AdvanceFeeRefundCondition3
        /// </summary>
        AdvanceFeeRefundCondition3 = 393,
        /// <summary>
        /// AdvanceFeeRefundCondition4
        /// </summary>
        AdvanceFeeRefundCondition4 = 394,
        /// <summary>
        /// AdvanceFeeRefundCondition5
        /// </summary>
        AdvanceFeeRefundCondition5 = 395,
        /// <summary>
        /// AdvanceFeeRefundCondition6
        /// </summary>
        AdvanceFeeRefundCondition6 = 396,
        /// <summary>
        /// LicensedCorrespondentIndicator
        /// </summary>
        LicensedCorrespondentIndicator = 397,
        /// <summary>
        /// InterestRateIncreasedIndicator
        /// </summary>
        InterestRateIncreasedIndicator = 398,
        /// <summary>
        /// InterestRateAtClosingIndicator
        /// </summary>
        InterestRateAtClosingIndicator = 399,
        /// <summary>
        /// InterestRateAtLenderIndicator
        /// </summary>
        InterestRateAtLenderIndicator = 400,
        /// <summary>
        /// InterestRateAtLenderNoLaterThan
        /// </summary>
        InterestRateAtLenderNoLaterThan = 401,
        /// <summary>
        /// SettlementServicesPaidByBorrowerIndicator
        /// </summary>
        SettlementServicesPaidByBorrowerIndicator = 402,
        /// <summary>
        /// SettlementServiceFeeDescription1
        /// </summary>
        SettlementServiceFeeDescription1 = 403,
        /// <summary>
        /// SettlementServiceFeeAmount1
        /// </summary>
        SettlementServiceFeeAmount1 = 404,
        /// <summary>
        /// FeeRefundCondition1
        /// </summary>
        FeeRefundCondition1 = 405,
        /// <summary>
        /// SettlementServiceFeeDescription2
        /// </summary>
        SettlementServiceFeeDescription2 = 406,
        /// <summary>
        /// SettlementServiceFeeAmount2
        /// </summary>
        SettlementServiceFeeAmount2 = 407,
        /// <summary>
        /// FeeRefundCondition2
        /// </summary>
        FeeRefundCondition2 = 408,
        /// <summary>
        /// SettlementServiceFeeDescription3
        /// </summary>
        SettlementServiceFeeDescription3 = 409,
        /// <summary>
        /// SettlementServiceFeeAmount3
        /// </summary>
        SettlementServiceFeeAmount3 = 410,
        /// <summary>
        /// FeeRefundCondition3
        /// </summary>
        FeeRefundCondition3 = 411,
        /// <summary>
        /// SettlementServiceFeeDescription4
        /// </summary>
        SettlementServiceFeeDescription4 = 412,
        /// <summary>
        /// SettlementServiceFeeAmount4
        /// </summary>
        SettlementServiceFeeAmount4 = 413,
        /// <summary>
        /// FeeRefundCondition4
        /// </summary>
        FeeRefundCondition4 = 414,
        /// <summary>
        /// TrustFundsAmount
        /// </summary>
        TrustFundsAmount = 415,
        /// <summary>
        /// TrustFundsPurpose
        /// </summary>
        TrustFundsPurpose = 416,
        /// <summary>
        /// PeriodTrustFundsBeHeld
        /// </summary>
        PeriodTrustFundsBeHeld = 417,
        /// <summary>
        /// ConditionToBeMetForTrustFundsDescription1
        /// </summary>
        ConditionToBeMetForTrustFundsDescription1 = 418,
        /// <summary>
        /// ConditionToBeMetForTrustFundsDescription2
        /// </summary>
        ConditionToBeMetForTrustFundsDescription2 = 419,
        /// <summary>
        /// ConditionToBeMetForTrustFundsDescription3
        /// </summary>
        ConditionToBeMetForTrustFundsDescription3 = 420,
        /// <summary>
        /// ConditionToBeMetForTrustFundsDescription4
        /// </summary>
        ConditionToBeMetForTrustFundsDescription4 = 421,
        /// <summary>
        /// BorrowerPayCertifiedCheckFee
        /// </summary>
        BorrowerPayCertifiedCheckFee = 422,
        /// <summary>
        /// BorrowerPayCashiersCheckFee
        /// </summary>
        BorrowerPayCashiersCheckFee = 423,
        /// <summary>
        /// BorrowerPayTellersCheckFee
        /// </summary>
        BorrowerPayTellersCheckFee = 424,
        /// <summary>
        /// BorrowerPayBankCheckFee
        /// </summary>
        BorrowerPayBankCheckFee = 425,
        /// <summary>
        /// BorrowerPayElectronicFundsTransferFee
        /// </summary>
        BorrowerPayElectronicFundsTransferFee = 426,
        /// <summary>
        /// BorrowerPayOtherFeeDescription
        /// </summary>
        BorrowerPayOtherFeeDescription = 427,
        /// <summary>
        /// BorrowerPayOtherFee
        /// </summary>
        BorrowerPayOtherFee = 428,
        /// <summary>
        /// DateBrokerageAgreementIsSignedIndicator
        /// </summary>
        DateBrokerageAgreementIsSignedIndicator = 429,
        /// <summary>
        /// DateBrokerageAgreementIsSigned
        /// </summary>
        DateBrokerageAgreementIsSigned = 430,
        /// <summary>
        /// AnyPersonPerformedAsBrokerIndicator
        /// </summary>
        AnyPersonPerformedAsBrokerIndicator = 431,
        /// <summary>
        /// RealEstateBrokerIndicator
        /// </summary>
        RealEstateBrokerIndicator = 432,
        /// <summary>
        /// InterestChargeDisclosureIndicator
        /// </summary>
        InterestChargeDisclosureIndicator = 433,
        /// <summary>
        /// AdditionalPerDimAmount
        /// </summary>
        AdditionalPerDimAmount = 434,
        /// <summary>
        /// AdvancePOCFeesEstimatedTotal
        /// </summary>
        AdvancePOCFeesEstimatedTotal = 435,
        /// <summary>
        /// AdvancePOCFeesPaidByDate
        /// </summary>
        AdvancePOCFeesPaidByDate = 436,
        /// <summary>
        /// ChooseDateForInterestRateIndicator
        /// </summary>
        ChooseDateForInterestRateIndicator = 437,
        /// <summary>
        /// InterestRateDisclosureAt
        /// </summary>
        InterestRateDisclosureAt = 438,
        /// <summary>
        /// DaysInterestSetPriorClosing
        /// </summary>
        DaysInterestSetPriorClosing = 439,
        /// <summary>
        /// NegativeAmortizationFeatureIndicator
        /// </summary>
        NegativeAmortizationFeatureIndicator = 440,
        /// <summary>
        /// LockInFeeIncludedInOriginationFeeIndicator
        /// </summary>
        LockInFeeIncludedInOriginationFeeIndicator = 441,
        /// <summary>
        /// CommitmentFeeIncludedInOriginationFeeIncator
        /// </summary>
        CommitmentFeeIncludedInOriginationFeeIncator = 442,
        /// <summary>
        /// BasisForPremiumPricingPaymentDescription
        /// </summary>
        BasisForPremiumPricingPaymentDescription = 443,
        /// <summary>
        /// BorrowerWillPayMortgageBrokerIndicator
        /// </summary>
        BorrowerWillPayMortgageBrokerIndicator = 444,
        /// <summary>
        /// BorrowerWillPayMortgageBrokerUpon
        /// </summary>
        BorrowerWillPayMortgageBrokerUpon = 445,
        /// <summary>
        /// MortgageBrokerReceivesLenderPaidIndicator
        /// </summary>
        MortgageBrokerReceivesLenderPaidIndicator = 446,
        /// <summary>
        /// MortgageBrokerReceivesLenderPaid
        /// </summary>
        MortgageBrokerReceivesLenderPaid = 447,
        /// <summary>
        /// BasisForBonusDescription
        /// </summary>
        BasisForBonusDescription = 448,
        /// <summary>
        /// ConsistBonusIndicator
        /// </summary>
        ConsistBonusIndicator = 449,
        /// <summary>
        /// BorrowerWillBeNotifiedIndicator
        /// </summary>
        BorrowerWillBeNotifiedIndicator = 450,
        /// <summary>
        /// BonusConsistsDescription
        /// </summary>
        BonusConsistsDescription = 451,
        /// <summary>
        /// LineOfCreditVariableAPRIndicator
        /// </summary>
        LineOfCreditVariableAPRIndicator = 452,
        /// <summary>
        /// InterestRateIncreaseCircumstances
        /// </summary>
        InterestRateIncreaseCircumstances = 453,
        /// <summary>
        /// InterestRateIncreaseLimitations
        /// </summary>
        InterestRateIncreaseLimitations = 454,
        /// <summary>
        /// InterestRateIncreaseOtherDescription
        /// </summary>
        InterestRateIncreaseOtherDescription = 455,
        /// <summary>
        /// DisclosureSummaryInitialOrRevised
        /// </summary>
        DisclosureSummaryInitialOrRevised = 456,
        /// <summary>
        /// SignedAgreementIndicator
        /// </summary>
        SignedAgreementIndicator = 457,
        /// <summary>
        /// MethodProvideSignedAgreement
        /// </summary>
        MethodProvideSignedAgreement = 458,
        /// <summary>
        /// IncludeBrokerageAggreement
        /// </summary>
        IncludeBrokerageAggreement = 459,
        /// <summary>
        /// LenderLicensingActDescription
        /// </summary>
        LenderLicensingActDescription = 460,
        /// <summary>
        /// BrokerLicensingActDescription
        /// </summary>
        BrokerLicensingActDescription = 461,
        /// <summary>
        /// LoanOriginatorLicensingActDescription
        /// </summary>
        LoanOriginatorLicensingActDescription = 462,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription1
        /// </summary>
        DisclosureSellerPaidFeeDescription1 = 463,
        /// <summary>
        /// DisclosureSellerPaidFee1
        /// </summary>
        DisclosureSellerPaidFee1 = 464,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription2
        /// </summary>
        DisclosureSellerPaidFeeDescription2 = 465,
        /// <summary>
        /// DisclosureSellerPaidFee2
        /// </summary>
        DisclosureSellerPaidFee2 = 466,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription3
        /// </summary>
        DisclosureSellerPaidFeeDescription3 = 467,
        /// <summary>
        /// DisclosureSellerPaidFee3
        /// </summary>
        DisclosureSellerPaidFee3 = 468,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription4
        /// </summary>
        DisclosureSellerPaidFeeDescription4 = 469,
        /// <summary>
        /// DisclosureSellerPaidFee4
        /// </summary>
        DisclosureSellerPaidFee4 = 470,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription5
        /// </summary>
        DisclosureSellerPaidFeeDescription5 = 471,
        /// <summary>
        /// DisclosureSellerPaidFee5
        /// </summary>
        DisclosureSellerPaidFee5 = 472,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription6
        /// </summary>
        DisclosureSellerPaidFeeDescription6 = 473,
        /// <summary>
        /// DisclosureSellerPaidFee6
        /// </summary>
        DisclosureSellerPaidFee6 = 474,
        /// <summary>
        /// DisclosureSellerPaidFeeDescription7
        /// </summary>
        DisclosureSellerPaidFeeDescription7 = 475,
        /// <summary>
        /// DisclosureSellerPaidFee7
        /// </summary>
        DisclosureSellerPaidFee7 = 476,
        /// <summary>
        /// RefinanceSubordination1
        /// </summary>
        RefinanceSubordination1 = 477,
        /// <summary>
        /// RefinanceSubordination2
        /// </summary>
        RefinanceSubordination2 = 478,
        /// <summary>
        /// RefinanceSubordination3
        /// </summary>
        RefinanceSubordination3 = 479,
        /// <summary>
        /// RefinanceSubordination4
        /// </summary>
        RefinanceSubordination4 = 480,
        /// <summary>
        /// RefinanceSubordination5
        /// </summary>
        RefinanceSubordination5 = 481,
        /// <summary>
        /// CompanyName
        /// </summary>
        CompanyName = 482,
        /// <summary>
        /// CompanyAddress
        /// </summary>
        CompanyAddress = 483,
        /// <summary>
        /// CompanyCity
        /// </summary>
        CompanyCity = 484,
        /// <summary>
        /// CompanyState
        /// </summary>
        CompanyState = 485,
        /// <summary>
        /// CompanyZip
        /// </summary>
        CompanyZip = 486,
        /// <summary>
        /// CompanyNmlsLicenseIdentifier
        /// </summary>
        CompanyNmlsLicenseIdentifier = 487,
        /// <summary>
        /// CompanyRepresentative
        /// </summary>
        CompanyRepresentative = 488,
        /// <summary>
        /// CompanyTitle
        /// </summary>
        CompanyTitle = 489,
        /// <summary>
        /// ContactIndividualName
        /// </summary>
        ContactIndividualName = 490,
        /// <summary>
        /// ContactAddress
        /// </summary>
        ContactAddress = 491,
        /// <summary>
        /// ContactCity
        /// </summary>
        ContactCity = 492,
        /// <summary>
        /// ContactState
        /// </summary>
        ContactState = 493,
        /// <summary>
        /// ContactZip
        /// </summary>
        ContactZip = 494,
        /// <summary>
        /// ContactNmlsLicenseIdentifier
        /// </summary>
        ContactNmlsLicenseIdentifier = 495,
        /// <summary>
        /// AffidavitOf
        /// </summary>
        AffidavitOf = 496,
        /// <summary>
        /// AffirmationDate
        /// </summary>
        AffirmationDate = 497,
        /// <summary>
        /// FeeDescription1
        /// </summary>
        FeeDescription1 = 498,
        /// <summary>
        /// ExplainationFeeIncrease1
        /// </summary>
        ExplainationFeeIncrease1 = 499,
        /// <summary>
        /// FeeDescription2
        /// </summary>
        FeeDescription2 = 500,
        /// <summary>
        /// ExplainationFeeIncrease2
        /// </summary>
        ExplainationFeeIncrease2 = 501,
        /// <summary>
        /// FeeDescription3
        /// </summary>
        FeeDescription3 = 502,
        /// <summary>
        /// ExplainationFeeIncrease3
        /// </summary>
        ExplainationFeeIncrease3 = 503,
        /// <summary>
        /// MoneyLien1_MortgageRecordedOnDate
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageRecordedOnDate")]
        MoneyLien1MortgageRecordedOnDate = 504,
        /// <summary>
        /// MoneyLien1_MortgageRecordedTitle
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageRecordedTitle")]
        MoneyLien1MortgageRecordedTitle = 505,
        /// <summary>
        /// MoneyLien1_MortgageRecordedJurisdiction
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageRecordedJurisdiction")]
        MoneyLien1MortgageRecordedJurisdiction = 506,
        /// <summary>
        /// MoneyLien1_MortgageRecordedDescription
        /// </summary>
        [EnumMember(Value = "MoneyLien1_MortgageRecordedDescription")]
        MoneyLien1MortgageRecordedDescription = 507,
        /// <summary>
        /// MoneyLien2_MortgageRecordedOnDate
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageRecordedOnDate")]
        MoneyLien2MortgageRecordedOnDate = 508,
        /// <summary>
        /// MoneyLien2_MortgageRecordedTitle
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageRecordedTitle")]
        MoneyLien2MortgageRecordedTitle = 509,
        /// <summary>
        /// MoneyLien2_MortgageRecordedJurisdiction
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageRecordedJurisdiction")]
        MoneyLien2MortgageRecordedJurisdiction = 510,
        /// <summary>
        /// MoneyLien2_MortgageRecordedDescription
        /// </summary>
        [EnumMember(Value = "MoneyLien2_MortgageRecordedDescription")]
        MoneyLien2MortgageRecordedDescription = 511,
        /// <summary>
        /// FeeDisclosureAlternative
        /// </summary>
        FeeDisclosureAlternative = 512,
        /// <summary>
        /// BorrowerElectsRightAttorney
        /// </summary>
        BorrowerElectsRightAttorney = 513,
        /// <summary>
        /// BrokerReceiveOriginationFeeTerm
        /// </summary>
        BrokerReceiveOriginationFeeTerm = 514,
        /// <summary>
        /// ProductsAndServicesProviderCost
        /// </summary>
        ProductsAndServicesProviderCost = 515,
        /// <summary>
        /// ProductsAndServicesProviderCostRangeFrom
        /// </summary>
        ProductsAndServicesProviderCostRangeFrom = 516,
        /// <summary>
        /// ProductsAndServicesProviderCostRangeTo
        /// </summary>
        ProductsAndServicesProviderCostRangeTo = 517,
        /// <summary>
        /// AddendumLoanAmountChange
        /// </summary>
        AddendumLoanAmountChange = 518,
        /// <summary>
        /// AddendumLoanProgramChange
        /// </summary>
        AddendumLoanProgramChange = 519,
        /// <summary>
        /// AddendumLoanRelocked
        /// </summary>
        AddendumLoanRelocked = 520,
        /// <summary>
        /// AddendumPaymentMethodChange
        /// </summary>
        AddendumPaymentMethodChange = 521,
        /// <summary>
        /// BorrowerWillAddBroker
        /// </summary>
        BorrowerWillAddBroker = 522,
        /// <summary>
        /// ThirdPartiesWillPayBroker
        /// </summary>
        ThirdPartiesWillPayBroker = 523,
        /// <summary>
        /// BorrowerAddAmount
        /// </summary>
        BorrowerAddAmount = 524,
        /// <summary>
        /// ThirdPartiesPayAmount
        /// </summary>
        ThirdPartiesPayAmount = 525,
        /// <summary>
        /// LenderPay
        /// </summary>
        LenderPay = 526,
        /// <summary>
        /// LenderPayAmount
        /// </summary>
        LenderPayAmount = 527,
        /// <summary>
        /// DirectPayAmount
        /// </summary>
        DirectPayAmount = 528,
        /// <summary>
        /// IncludeOptionalFormInDisclosurePackageIndicator
        /// </summary>
        IncludeOptionalFormInDisclosurePackageIndicator = 529,
        /// <summary>
        /// LenderChargeFeeDescription
        /// </summary>
        LenderChargeFeeDescription = 530,
        /// <summary>
        /// LenderChargeAmount
        /// </summary>
        LenderChargeAmount = 531,
        /// <summary>
        /// LenderCharge3rdPartyName
        /// </summary>
        LenderCharge3rdPartyName = 532,
        /// <summary>
        /// LenderChargeAddress
        /// </summary>
        LenderChargeAddress = 533,
        /// <summary>
        /// LenderChargeCity
        /// </summary>
        LenderChargeCity = 534,
        /// <summary>
        /// LenderChargeState
        /// </summary>
        LenderChargeState = 535,
        /// <summary>
        /// LenderChargeZipCode
        /// </summary>
        LenderChargeZipCode = 536,
        /// <summary>
        /// BeforeChangeInLoanType
        /// </summary>
        BeforeChangeInLoanType = 537,
        /// <summary>
        /// BeforeChangeInLoanTerm
        /// </summary>
        BeforeChangeInLoanTerm = 538,
        /// <summary>
        /// BeforeChangeInLoanRate
        /// </summary>
        BeforeChangeInLoanRate = 539,
        /// <summary>
        /// BeforeChangeInMonthyPayment
        /// </summary>
        BeforeChangeInMonthyPayment = 540,
        /// <summary>
        /// BeforeChangeInEscrowPayment
        /// </summary>
        BeforeChangeInEscrowPayment = 541,
        /// <summary>
        /// AfterChangeInEscrowPayment
        /// </summary>
        AfterChangeInEscrowPayment = 542,
        /// <summary>
        /// BeforeChangeInMIPayment
        /// </summary>
        BeforeChangeInMIPayment = 543,
        /// <summary>
        /// AfterChangeInMIPayment
        /// </summary>
        AfterChangeInMIPayment = 544,
        /// <summary>
        /// BeforeChangeInClosingCost
        /// </summary>
        BeforeChangeInClosingCost = 545,
        /// <summary>
        /// AfterChangeInClosingCost
        /// </summary>
        AfterChangeInClosingCost = 546,
        /// <summary>
        /// AfterChangeInEscrowPaymentForCalculation
        /// </summary>
        AfterChangeInEscrowPaymentForCalculation = 547,
        /// <summary>
        /// AfterChangeInMIPaymentForCalculation
        /// </summary>
        AfterChangeInMIPaymentForCalculation = 548,
        /// <summary>
        /// AfterChangeInClosingCostForCalculation
        /// </summary>
        AfterChangeInClosingCostForCalculation = 549,
        /// <summary>
        /// LenderChargeFeeDescription2
        /// </summary>
        LenderChargeFeeDescription2 = 550,
        /// <summary>
        /// LenderChargeAmount2
        /// </summary>
        LenderChargeAmount2 = 551,
        /// <summary>
        /// LenderCharge3rdPartyName2
        /// </summary>
        LenderCharge3rdPartyName2 = 552,
        /// <summary>
        /// LenderChargeAddress2
        /// </summary>
        LenderChargeAddress2 = 553,
        /// <summary>
        /// LenderChargeCity2
        /// </summary>
        LenderChargeCity2 = 554,
        /// <summary>
        /// LenderChargeState2
        /// </summary>
        LenderChargeState2 = 555,
        /// <summary>
        /// LenderChargeZipCode2
        /// </summary>
        LenderChargeZipCode2 = 556,
        /// <summary>
        /// BankerInterestRateAtLenderNoLaterThan
        /// </summary>
        BankerInterestRateAtLenderNoLaterThan = 557,
        /// <summary>
        /// BankerChooseDateForInterestRateIndicator
        /// </summary>
        BankerChooseDateForInterestRateIndicator = 558,
        /// <summary>
        /// BorrowerAcknowledgesDocument
        /// </summary>
        BorrowerAcknowledgesDocument = 559,
        /// <summary>
        /// AfterChangeInLoanType
        /// </summary>
        AfterChangeInLoanType = 560,
        /// <summary>
        /// AttorneyProvidedBy
        /// </summary>
        AttorneyProvidedBy = 561,
        /// <summary>
        /// InsuranceAgentProvidedBy
        /// </summary>
        InsuranceAgentProvidedBy = 562,
        /// <summary>
        /// RateLockAgmtGrnteedFlag
        /// </summary>
        RateLockAgmtGrnteedFlag = 563,
        /// <summary>
        /// LockInPeriodExtendedDate
        /// </summary>
        LockInPeriodExtendedDate = 564,
        /// <summary>
        /// LockInPeriodExtensionExpirationDate
        /// </summary>
        LockInPeriodExtensionExpirationDate = 565,
        /// <summary>
        /// LockInPeriodExtensionFeePaidbyParty
        /// </summary>
        LockInPeriodExtensionFeePaidbyParty = 566,
        /// <summary>
        /// LockInDate
        /// </summary>
        LockInDate = 567,
        /// <summary>
        /// LockInExpirationDate
        /// </summary>
        LockInExpirationDate = 568,
        /// <summary>
        /// FundNotByBroker
        /// </summary>
        FundNotByBroker = 569,
        /// <summary>
        /// EstablishEscrowAccount
        /// </summary>
        EstablishEscrowAccount = 570,
        /// <summary>
        /// DoNotExerciseRightToAttorney
        /// </summary>
        DoNotExerciseRightToAttorney = 571,
        /// <summary>
        /// LenderAttorneyToRenderServicesForLenderIndicator
        /// </summary>
        LenderAttorneyToRenderServicesForLenderIndicator = 572,
        /// <summary>
        /// BrkrPrtnTotFeesAmt
        /// </summary>
        BrkrPrtnTotFeesAmt = 573,
        /// <summary>
        /// BrkrPrtnTotFeesPct
        /// </summary>
        BrkrPrtnTotFeesPct = 574,
        /// <summary>
        /// LndPrtnTotFeesAmt
        /// </summary>
        LndPrtnTotFeesAmt = 575,
        /// <summary>
        /// LndPrtnTotFeesPct
        /// </summary>
        LndPrtnTotFeesPct = 576,
        /// <summary>
        /// LockInFeeDueDt
        /// </summary>
        LockInFeeDueDt = 577,
        /// <summary>
        /// CmtmtFeeDueDt
        /// </summary>
        CmtmtFeeDueDt = 578,
        /// <summary>
        /// AppraisalFeeFor3rdPartyIndicator
        /// </summary>
        AppraisalFeeFor3rdPartyIndicator = 579,
        /// <summary>
        /// CreditReportFeeFor3rdPartyIndicator
        /// </summary>
        CreditReportFeeFor3rdPartyIndicator = 580,
        /// <summary>
        /// TaxServiceFeeFor3rdPartyIndicator
        /// </summary>
        TaxServiceFeeFor3rdPartyIndicator = 581,
        /// <summary>
        /// FloodCertificationFeeFor3rdPartyIndicator
        /// </summary>
        FloodCertificationFeeFor3rdPartyIndicator = 582,
        /// <summary>
        /// RefundableUnderTermConditionDescription
        /// </summary>
        RefundableUnderTermConditionDescription = 583,
        /// <summary>
        /// PropertyAppraisalWorkProductsIndicator
        /// </summary>
        PropertyAppraisalWorkProductsIndicator = 584,
        /// <summary>
        /// CreditReportWorkProductsIndicator
        /// </summary>
        CreditReportWorkProductsIndicator = 585,
        /// <summary>
        /// PropertyTaxServiceWorkProductsIndicator
        /// </summary>
        PropertyTaxServiceWorkProductsIndicator = 586,
        /// <summary>
        /// FloodCertificationWorkProductsIndicator
        /// </summary>
        FloodCertificationWorkProductsIndicator = 587,
        /// <summary>
        /// OtherWorkProductsIndicator
        /// </summary>
        OtherWorkProductsIndicator = 588,
        /// <summary>
        /// OtherWorkProductsDescription1
        /// </summary>
        OtherWorkProductsDescription1 = 589,
        /// <summary>
        /// OtherWorkProductsDescription2
        /// </summary>
        OtherWorkProductsDescription2 = 590,
        /// <summary>
        /// OtherWorkProductsDescription3
        /// </summary>
        OtherWorkProductsDescription3 = 591,
        /// <summary>
        /// CanbeTransferredToAnotherMortgageIndicator
        /// </summary>
        CanbeTransferredToAnotherMortgageIndicator = 592,
        /// <summary>
        /// CanbeTransferredToAnotherMortgageDescription
        /// </summary>
        CanbeTransferredToAnotherMortgageDescription = 593,
        /// <summary>
        /// RMLANamePreceding10Years
        /// </summary>
        RMLANamePreceding10Years = 594,
        /// <summary>
        /// ParentAffiliatedCoName
        /// </summary>
        ParentAffiliatedCoName = 595,
        /// <summary>
        /// WeConductBusiness
        /// </summary>
        WeConductBusiness = 596,
        /// <summary>
        /// OriginalRecordingDate
        /// </summary>
        OriginalRecordingDate = 597,
        /// <summary>
        /// OriginalRecordingBookNumber
        /// </summary>
        OriginalRecordingBookNumber = 598,
        /// <summary>
        /// OriginalRecordingPageNumber
        /// </summary>
        OriginalRecordingPageNumber = 599,
        /// <summary>
        /// OriginalRecordingClerkOfficeCountyName
        /// </summary>
        OriginalRecordingClerkOfficeCountyName = 600,
        /// <summary>
        /// RecordedInstrumentType
        /// </summary>
        RecordedInstrumentType = 601,
        /// <summary>
        /// RecordedInstrumentTypeOther
        /// </summary>
        RecordedInstrumentTypeOther = 602,
        /// <summary>
        /// RecordedInstrumentBookNumber
        /// </summary>
        RecordedInstrumentBookNumber = 603,
        /// <summary>
        /// RecordedInstrumentPageNumber
        /// </summary>
        RecordedInstrumentPageNumber = 604,
        /// <summary>
        /// RecordedInstrumentNumber
        /// </summary>
        RecordedInstrumentNumber = 605,
        /// <summary>
        /// RecordedInstrumentRegisterCountyOffice
        /// </summary>
        RecordedInstrumentRegisterCountyOffice = 606,
        /// <summary>
        /// BonaFideEmergencyGoodCause
        /// </summary>
        BonaFideEmergencyGoodCause = 607,
        /// <summary>
        /// DescriptionofEmergencyGoodCause1
        /// </summary>
        DescriptionofEmergencyGoodCause1 = 608,
        /// <summary>
        /// DescriptionofEmergencyGoodCause2
        /// </summary>
        DescriptionofEmergencyGoodCause2 = 609,
        /// <summary>
        /// DescriptionofEmergencyGoodCause3
        /// </summary>
        DescriptionofEmergencyGoodCause3 = 610,
        /// <summary>
        /// OptionalEscrow
        /// </summary>
        OptionalEscrow = 611,
        /// <summary>
        /// OriginationFeeAmount
        /// </summary>
        OriginationFeeAmount = 612,
        /// <summary>
        /// OtherFee4Amount
        /// </summary>
        OtherFee4Amount = 613,
        /// <summary>
        /// OtherFee1Name
        /// </summary>
        OtherFee1Name = 614,
        /// <summary>
        /// OtherFee2Name
        /// </summary>
        OtherFee2Name = 615,
        /// <summary>
        /// OtherFee3Name
        /// </summary>
        OtherFee3Name = 616,
        /// <summary>
        /// OtherFee4Name
        /// </summary>
        OtherFee4Name = 617,
        /// <summary>
        /// IsOtherFee1Refundable
        /// </summary>
        IsOtherFee1Refundable = 618,
        /// <summary>
        /// IsOtherFee2Refundable
        /// </summary>
        IsOtherFee2Refundable = 619,
        /// <summary>
        /// IsOtherFee3Refundable
        /// </summary>
        IsOtherFee3Refundable = 620,
        /// <summary>
        /// IsOtherFee4Refundable
        /// </summary>
        IsOtherFee4Refundable = 621,
        /// <summary>
        /// AdditionalPaymentsDisclosureOther
        /// </summary>
        AdditionalPaymentsDisclosureOther = 622,
        /// <summary>
        /// AdditionalPaymentsDisclosureHELOC
        /// </summary>
        AdditionalPaymentsDisclosureHELOC = 623,
        /// <summary>
        /// CommitmentExpiredDate
        /// </summary>
        CommitmentExpiredDate = 624,
        /// <summary>
        /// PayToThirdParty
        /// </summary>
        PayToThirdParty = 625,
        /// <summary>
        /// ReceiveFromThirdParty
        /// </summary>
        ReceiveFromThirdParty = 626,
        /// <summary>
        /// RMLA
        /// </summary>
        RMLA = 627,
        /// <summary>
        /// MICancelCondType
        /// </summary>
        MICancelCondType = 628,
        /// <summary>
        /// MICancelOtherCondDescr
        /// </summary>
        MICancelOtherCondDescr = 629,
        /// <summary>
        /// PreQualExpirationDate
        /// </summary>
        PreQualExpirationDate = 630,
        /// <summary>
        /// ClosingDeadline
        /// </summary>
        ClosingDeadline = 631,
        /// <summary>
        /// FirstTimeHomebuyer
        /// </summary>
        FirstTimeHomebuyer = 632,
        /// <summary>
        /// AdditionalTermsConditions
        /// </summary>
        AdditionalTermsConditions = 633
    }
}