using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Borrower
/// </summary>
public sealed partial class Borrower : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Borrower AccountCheckAssetId [FANNIESERVICE.X3], [FANNIESERVICE.X4]
    /// </summary>
    public string? AccountCheckAssetId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ActiveDuty [URLA.X123], [URLA.X126]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently serving on active duty\"}")]
    public bool? ActiveDuty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AdditionalEmploymentDoesNotApply [URLA.X201], [URLA.X202]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? AdditionalEmploymentDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Additional Income to Primary Employment (Commission, Bonus, Overtime, Automobile Allowance, Mortgage Differential, Tips, Military, Secondary Employment, Seasonal Employment, Unemployment) [USDA.X168]
    /// </summary>
    public decimal? AdditionalIncomeFromPrimaryEmployment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AdditionalInformation [URLA.X213], [URLA.X214]
    /// </summary>
    public string? AdditionalInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AdditionalOtherIncome [URLA.X42], [URLA.X43]
    /// </summary>
    public decimal? AdditionalOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Adjusted Annual income for the household [USDA.X17]
    /// </summary>
    public decimal? AdjustedAnnualIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AgeAtApplicationYearsCount [38], [70]
    /// </summary>
    public int? AgeAtApplicationYearsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AliasName [1869], [1874]
    /// </summary>
    public string? AliasName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AlimonyChildSupportObligationIndicator [173], [179]
    /// </summary>
    public bool? AlimonyChildSupportObligationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual income for the household [USDA.X16]
    /// </summary>
    public decimal? AnnualIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ApplicantType
    /// </summary>
    public string? ApplicantType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ApplicationTakenMethodType [4131], [4143]
    /// </summary>
    public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => GetValue<StringEnumValue<ApplicationTakenMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Asset Income (Income from household assets as described in 1980.347(d) of RD Instruction 1980-D) [USDA.X170]
    /// </summary>
    public decimal? AssetIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Asset Validation Message [MORNET.X114]
    /// </summary>
    public string? AssetRepAndWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Asset Validation [MORNET.X117]
    /// </summary>
    public bool? AssetRepAndWarrantyReliefAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AuthorizedCreditReportDate [4074], [4077]
    /// </summary>
    public DateTime? AuthorizedCreditReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AuthorizedCreditReportIndicator [4073], [4076]
    /// </summary>
    public bool? AuthorizedCreditReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower AuthorizedToSignIndicator [2968], [2969]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
    public bool? AuthorizedToSignIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankAccountNumber [CAPIAP.X122], [CAPIAP.X129]
    /// </summary>
    public string? BankAccountNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankAccountType [CAPIAP.X120], [CAPIAP.X127]
    /// </summary>
    public StringEnumValue<BankAccountType> BankAccountType { get => GetValue<StringEnumValue<BankAccountType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankContactAddress [CAPIAP.X123], [CAPIAP.X130]
    /// </summary>
    public string? BankContactAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankContactCity [CAPIAP.X124], [CAPIAP.X131]
    /// </summary>
    public string? BankContactCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankContactName [CAPIAP.X121], [CAPIAP.X128]
    /// </summary>
    public string? BankContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankContactPostalCode [CAPIAP.X126], [CAPIAP.X133]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BankContactPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankContactState [CAPIAP.X125], [CAPIAP.X132]
    /// </summary>
    public string? BankContactState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Date of Bankruptcy [2340]
    /// </summary>
    public DateTime? BankruptcyDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankruptcyIndicator [265], [266]
    /// </summary>
    public bool? BankruptcyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterEleven [URLA.X175], [URLA.X179]
    /// </summary>
    public bool? BankruptcyIndicatorChapterEleven { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterSeven [URLA.X174], [URLA.X178]
    /// </summary>
    public bool? BankruptcyIndicatorChapterSeven { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterThirteen [URLA.X177], [URLA.X181]
    /// </summary>
    public bool? BankruptcyIndicatorChapterThirteen { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterTwelve [URLA.X176], [URLA.X180]
    /// </summary>
    public bool? BankruptcyIndicatorChapterTwelve { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Bankruptcy Status [2570]
    /// </summary>
    public StringEnumValue<BankruptcyForeclosureStatus> BankruptcyStatus { get => GetValue<StringEnumValue<BankruptcyForeclosureStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BaseIncome [USDA.X164], [USDA.X165]
    /// </summary>
    public decimal? BaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BaseIncomeValidationMessage [MORNET.X132], [MORNET.X144]
    /// </summary>
    public string? BaseIncomeValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BaseMonthlyIncomeAmount [1088], [1089]
    /// </summary>
    public decimal? BaseMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BirthDate [1402], [1403]
    /// </summary>
    public DateTime? BirthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BonusValidationMessage [MORNET.X133], [MORNET.X145]
    /// </summary>
    public string? BonusValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BorrowedDownPaymentIndicator [174], [180]
    /// </summary>
    public bool? BorrowedDownPaymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BorrowerConsentRequestDate [4108], [4109]
    /// </summary>
    public DateTime? BorrowerConsentRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BorrowerType [1871], [1876]
    /// </summary>
    public StringEnumValue<BorrowerType> BorrowerType { get => GetValue<StringEnumValue<BorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower BorrowerTypeInSummary [4008], [4009]
    /// </summary>
    public StringEnumValue<BorrowerType> BorrowerTypeInSummary { get => GetValue<StringEnumValue<BorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Bottom Ratio [MORNET.X159]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BottomRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CaivrsIdentifier [1018], [1144]
    /// </summary>
    public string? CaivrsIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CdDeliveryMethod [CORRESPONDENT.X388], [CORRESPONDENT.X389]
    /// </summary>
    public string? CdDeliveryMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CitizenshipResidencyType [BORCIT], [COBORCIT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CitizenshipResidencyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CoBorrower Attended Same Counseling [URLA.X215]
    /// </summary>
    public bool? CoBorrAttendedSameCounselingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CoMakerEndorserOfNoteIndicator [171], [177]
    /// </summary>
    public bool? CoMakerEndorserOfNoteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Credit Report Comment [4079]
    /// </summary>
    public string? CommentOfCreditReport { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CommissionValidationMessage [MORNET.X135], [MORNET.X147]
    /// </summary>
    public string? CommissionValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrbkec [MORNET.X152], [MORNET.X156]
    /// </summary>
    public bool? ConfirmedCrbkec { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrbkIncorrect [MORNET.X151], [MORNET.X155]
    /// </summary>
    public bool? ConfirmedCrbkIncorrect { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrdil [MORNET.X81], [MORNET.X87]
    /// </summary>
    public bool? ConfirmedCrdil { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrfcec [MORNET.X80], [MORNET.X86]
    /// </summary>
    public bool? ConfirmedCrfcec { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrfcIncorrect [MORNET.X79], [MORNET.X85]
    /// </summary>
    public bool? ConfirmedCrfcIncorrect { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedCrpfs [MORNET.X82], [MORNET.X88]
    /// </summary>
    public bool? ConfirmedCrpfs { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedMtgDelIncorrect [MORNET.X153], [MORNET.X154]
    /// </summary>
    public bool? ConfirmedMtgDelIncorrect { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedOther [MORNET.X83], [MORNET.X89]
    /// </summary>
    public bool? ConfirmedOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ConfirmedOtherDescription [MORNET.X84], [MORNET.X90]
    /// </summary>
    public string? ConfirmedOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ContactRef
    /// </summary>
    [AllowNull]
    public EntityReference ContactRef { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Borrower CounselingConfirmationType [CORRESPONDENT.X440], [CORRESPONDENT.X441]
    /// </summary>
    public string? CounselingConfirmationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CounselingConfirmationTypeDescription [CORRESPONDENT.X442], [CORRESPONDENT.X443]
    /// </summary>
    public string? CounselingConfirmationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CounselingFormatTypeDescription [CORRESPONDENT.X444], [CORRESPONDENT.X452]
    /// </summary>
    public string? CounselingFormatTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Credit Counseling [2566]
    /// </summary>
    public bool? CreditCounseling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Credit Received Date [2336]
    /// </summary>
    public DateTime? CreditReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CreditReportAuthorizationMethod [4075], [4078]
    /// </summary>
    public StringEnumValue<CreditReportAuthorizationMethod> CreditReportAuthorizationMethod { get => GetValue<StringEnumValue<CreditReportAuthorizationMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CreditReports
    /// </summary>
    [AllowNull]
    public IList<CreditReport> CreditReports { get => GetList<CreditReport>(); set => SetList(value); }

    /// <summary>
    /// Borrower CreditScoreIndicator [USDA.X12], [USDA.X15]
    /// </summary>
    public bool? CreditScoreIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower CurrentEmploymentDoesNotApply [URLA.X199], [URLA.X200]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? CurrentEmploymentDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - DataVerify [GSEVENDOR.X3]
    /// </summary>
    public string? DataVerify { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DeclarationsJIndicator [965], [985]
    /// </summary>
    public bool? DeclarationsJIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DeclarationsKIndicator [466], [467]
    /// </summary>
    public bool? DeclarationsKIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DependentCount [53], [85]
    /// </summary>
    public int? DependentCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DependentsAgesDescription [54], [86]
    /// </summary>
    public string? DependentsAgesDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DisabledIndicator [USDA.X2], [USDA.X5]
    /// </summary>
    public bool? DisabledIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DomesticRelationshipType [URLA.X113], [URLA.X114]
    /// </summary>
    public StringEnumValue<DomesticRelationshipType> DomesticRelationshipType { get => GetValue<StringEnumValue<DomesticRelationshipType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DuVerificationEmploymentIncomeIndicator [TQL.X100], [TQL.X98]
    /// </summary>
    public bool? DuVerificationEmploymentIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower DuVerificationEmploymentIncomeMessage [TQL.X101], [TQL.X99]
    /// </summary>
    public string? DuVerificationEmploymentIncomeMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EmailAddressText [1240], [1268]
    /// </summary>
    public string? EmailAddressText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Employment
    /// </summary>
    [AllowNull]
    public IList<Employment> Employment { get => GetList<Employment>(); set => SetList(value); }

    /// <summary>
    /// Borrower EmploymentVerificationAvailable [MORNET.X129], [MORNET.X141]
    /// </summary>
    public bool? EmploymentVerificationAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EmploymentVerificationMessage [MORNET.X131], [MORNET.X143]
    /// </summary>
    public string? EmploymentVerificationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Equifax 120 Days [2335]
    /// </summary>
    public int? Equifax120Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Equifax 150 Days [2557]
    /// </summary>
    public int? Equifax150Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Equifax 30 Days [2332]
    /// </summary>
    public int? Equifax30Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Equifax 60 Days [2333]
    /// </summary>
    public int? Equifax60Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Equifax 90 Days [2334]
    /// </summary>
    public int? Equifax90Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxCreditScoreForDisclosure [DISCLOSURE.X629], [DISCLOSURE.X630]
    /// </summary>
    public bool? EquifaxCreditScoreForDisclosure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxCreditScoreRanksPercent [DISCLOSURE.X635], [DISCLOSURE.X636]
    /// </summary>
    public int? EquifaxCreditScoreRanksPercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxDatePulled [DISCLOSURE.X51], [DISCLOSURE.X52]
    /// </summary>
    public DateTime? EquifaxDatePulled { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxFactorCode1 [DISCLOSURE.X1017], [DISCLOSURE.X1022]
    /// </summary>
    public string? EquifaxFactorCode1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxFactorCode2 [DISCLOSURE.X1018], [DISCLOSURE.X1023]
    /// </summary>
    public string? EquifaxFactorCode2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxFactorCode3 [DISCLOSURE.X1019], [DISCLOSURE.X1024]
    /// </summary>
    public string? EquifaxFactorCode3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxFactorCode4 [DISCLOSURE.X1020], [DISCLOSURE.X1025]
    /// </summary>
    public string? EquifaxFactorCode4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxFactorCode5 [DISCLOSURE.X1021], [DISCLOSURE.X1026]
    /// </summary>
    public string? EquifaxFactorCode5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor1 [DISCLOSURE.X53], [DISCLOSURE.X57]
    /// </summary>
    public string? EquifaxKeyFactor1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor2 [DISCLOSURE.X54], [DISCLOSURE.X58]
    /// </summary>
    public string? EquifaxKeyFactor2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor3 [DISCLOSURE.X55], [DISCLOSURE.X59]
    /// </summary>
    public string? EquifaxKeyFactor3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor4 [DISCLOSURE.X56], [DISCLOSURE.X60]
    /// </summary>
    public string? EquifaxKeyFactor4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor5 [DISCLOSURE.X175], [DISCLOSURE.X178]
    /// </summary>
    public bool? EquifaxKeyFactor5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxMaterialTermsCreditByScore [DISCLOSURE.X947], [DISCLOSURE.X948]
    /// </summary>
    public bool? EquifaxMaterialTermsCreditByScore { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower EquifaxScore [1414], [1415]
    /// </summary>
    public string? EquifaxScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Experian 120 Days [2327]
    /// </summary>
    public int? Experian120Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Experian 150 Days [2555]
    /// </summary>
    public int? Experian150Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Experian 30 Days [2324]
    /// </summary>
    public int? Experian30Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Experian 60 Days [2325]
    /// </summary>
    public int? Experian60Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Experian 90 Days [2326]
    /// </summary>
    public int? Experian90Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianCreditScore [60], [67]
    /// </summary>
    public string? ExperianCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianCreditScoreForDisclosure [DISCLOSURE.X625], [DISCLOSURE.X626]
    /// </summary>
    public bool? ExperianCreditScoreForDisclosure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianCreditScoreRanksPercent [DISCLOSURE.X631], [DISCLOSURE.X632]
    /// </summary>
    public int? ExperianCreditScoreRanksPercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianDatePulled [DISCLOSURE.X11], [DISCLOSURE.X12]
    /// </summary>
    public DateTime? ExperianDatePulled { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianFactorCode1 [DISCLOSURE.X1002], [DISCLOSURE.X997]
    /// </summary>
    public string? ExperianFactorCode1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianFactorCode2 [DISCLOSURE.X1003], [DISCLOSURE.X998]
    /// </summary>
    public string? ExperianFactorCode2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianFactorCode3 [DISCLOSURE.X1004], [DISCLOSURE.X999]
    /// </summary>
    public string? ExperianFactorCode3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianFactorCode4 [DISCLOSURE.X1000], [DISCLOSURE.X1005]
    /// </summary>
    public string? ExperianFactorCode4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianFactorCode5 [DISCLOSURE.X1001], [DISCLOSURE.X1006]
    /// </summary>
    public string? ExperianFactorCode5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianKeyFactor1 [DISCLOSURE.X13], [DISCLOSURE.X17]
    /// </summary>
    public string? ExperianKeyFactor1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianKeyFactor2 [DISCLOSURE.X14], [DISCLOSURE.X18]
    /// </summary>
    public string? ExperianKeyFactor2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianKeyFactor3 [DISCLOSURE.X15], [DISCLOSURE.X19]
    /// </summary>
    public string? ExperianKeyFactor3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianKeyFactor4 [DISCLOSURE.X16], [DISCLOSURE.X20]
    /// </summary>
    public string? ExperianKeyFactor4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianKeyFactor5 [DISCLOSURE.X173], [DISCLOSURE.X176]
    /// </summary>
    public bool? ExperianKeyFactor5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ExperianMaterialTermsCreditByScore [DISCLOSURE.X943], [DISCLOSURE.X944]
    /// </summary>
    public bool? ExperianMaterialTermsCreditByScore { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FannieFirstName [ULDD.FNM.4000], [ULDD.FNM.4004]
    /// </summary>
    public string? FannieFirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FannieMiddleName [ULDD.FNM.4001], [ULDD.FNM.4005]
    /// </summary>
    public string? FannieMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Final1003Provided [CORRESPONDENT.X455], [CORRESPONDENT.X456]
    /// </summary>
    public bool? Final1003Provided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FirstName [4000], [4004]
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FirstNameWithMiddleName [36], [68]
    /// </summary>
    public string? FirstNameWithMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FirstTimeHomeBuyer [USDA.X3], [USDA.X6]
    /// </summary>
    public bool? FirstTimeHomeBuyer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Date of Foreclosure [2341]
    /// </summary>
    public DateTime? ForeclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Foreclosure Satisfied [2571]
    /// </summary>
    public DateTime? ForeclosureSatisfied { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Foreclosure Status [2572]
    /// </summary>
    public StringEnumValue<BankruptcyForeclosureStatus> ForeclosureStatus { get => GetValue<StringEnumValue<BankruptcyForeclosureStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FreddieAlienStatus [4709], [4710]
    /// </summary>
    public StringEnumValue<FreddieBorrowerAlienStatus> FreddieAlienStatus { get => GetValue<StringEnumValue<FreddieBorrowerAlienStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FreddieMacPerson1 [CASASRN.X170], [CASASRN.X180]
    /// </summary>
    public string? FreddieMacPerson1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FreddieMacPerson2 [CASASRN.X171], [CASASRN.X181]
    /// </summary>
    public string? FreddieMacPerson2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FullName
    /// </summary>
    public string? FullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower FullNameWithSuffix [1868], [1873]
    /// </summary>
    public string? FullNameWithSuffix { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower GiftsAndGrantsIndicatorBor [URLA.X82], [URLA.X83]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
    public bool? GiftsAndGrantsIndicatorBor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Highest Credit Limit [2567]
    /// </summary>
    public decimal? HighestCreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Hmda2003OtherRaceNationalOriginDescription [1136], [1300]
    /// </summary>
    public string? Hmda2003OtherRaceNationalOriginDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Hmda2003RaceNationalOriginType [470], [477]
    /// </summary>
    public StringEnumValue<Hmda2003RaceNationalOriginType> Hmda2003RaceNationalOriginType { get => GetValue<StringEnumValue<Hmda2003RaceNationalOriginType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Hmda2CreditScoreForDecisionMaking [HMDA.X116], [HMDA.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_STRING)]
    public StringEnumValue<HmdaCreditScoreForDecisionMaking> Hmda2CreditScoreForDecisionMaking { get => GetValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Hmda2CreditScoringModel [HMDA.X117], [HMDA.X119]
    /// </summary>
    public StringEnumValue<HmdaCreditScoringModel> Hmda2CreditScoringModel { get => GetValue<StringEnumValue<HmdaCreditScoringModel>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAfricanAmericanIndicator [1526], [1534]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Black or African American\"}")]
    public bool? HmdaAfricanAmericanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAge [4183], [4184]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public StringEnumValue<HmdaAge> HmdaAge { get => GetValue<StringEnumValue<HmdaAge>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAmericanIndianIndicator [1524], [1532]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"American Indian or Alaska Native\"}")]
    public bool? HmdaAmericanIndianIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAmericanIndianTribe [4126], [4137]
    /// </summary>
    public string? HmdaAmericanIndianTribe { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAsianIndianIndicator [4148], [4163]
    /// </summary>
    public bool? HmdaAsianIndianIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAsianIndicator [1525], [1533]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Asian\"}")]
    public bool? HmdaAsianIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaAsianOtherRaceIndicator [4154], [4169]
    /// </summary>
    public bool? HmdaAsianOtherRaceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaChineseIndicator [4149], [4164]
    /// </summary>
    public bool? HmdaChineseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaCreditScoreForDecisionMaking [4174], [4177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_STRING, MissingOptionsJson = "[\"Exempt\"]")]
    public StringEnumValue<HmdaCreditScoreForDecisionMaking> HmdaCreditScoreForDecisionMaking { get => GetValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaCreditScoringModel [4175], [4178]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Exempt\"]")]
    public StringEnumValue<HmdaCreditScoringModel> HmdaCreditScoringModel { get => GetValue<StringEnumValue<HmdaCreditScoringModel>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaCubanIndicator [4146], [4161]
    /// </summary>
    public bool? HmdaCubanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityDoNotWishIndicator [4205], [4206]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaEthnicityDoNotWishIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityHispanicLatinoIndicator [4210], [4213]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Hispanic or Latino\"}")]
    public bool? HmdaEthnicityHispanicLatinoIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityInfoNotProvided [4243], [4246]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaEthnicityInfoNotProvided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityNotApplicableIndicator [4212], [4215]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
    public bool? HmdaEthnicityNotApplicableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityNotHispanicLatinoIndicator [4211], [4214]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Hispanic or Latino\"}")]
    public bool? HmdaEthnicityNotHispanicLatinoIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField1 [4221], [4231]
    /// </summary>
    public string? HmdaEthnicityReportedField1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField2 [4222], [4232]
    /// </summary>
    public string? HmdaEthnicityReportedField2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField3 [4223], [4233]
    /// </summary>
    public string? HmdaEthnicityReportedField3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField4 [4224], [4234]
    /// </summary>
    public string? HmdaEthnicityReportedField4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField5 [4225], [4235]
    /// </summary>
    public string? HmdaEthnicityReportedField5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedFields [4236], [4238]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaEthnicityReportedFields { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaEthnicityType [1523], [1531]
    /// </summary>
    public StringEnumValue<HmdaEthnicityType> HmdaEthnicityType { get => GetValue<StringEnumValue<HmdaEthnicityType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaFilipinoIndicator [4150], [4165]
    /// </summary>
    public bool? HmdaFilipinoIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGenderType [471], [478]
    /// </summary>
    public StringEnumValue<HmdaGenderType> HmdaGenderType { get => GetValue<StringEnumValue<HmdaGenderType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGendertypeDoNotWishIndicator [4195], [4199]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaGendertypeDoNotWishIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGendertypeFemaleIndicator [4193], [4197]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Female\"}")]
    public bool? HmdaGendertypeFemaleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGendertypeMaleIndicator [4194], [4198]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Male\"}")]
    public bool? HmdaGendertypeMaleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGendertypeNotApplicableIndicator [4196], [4200]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
    public bool? HmdaGendertypeNotApplicableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaGuamanianOrChamorroIndicator [4156], [4171]
    /// </summary>
    public bool? HmdaGuamanianOrChamorroIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaHispanicLatinoOtherOriginIndicator [4147], [4162]
    /// </summary>
    public bool? HmdaHispanicLatinoOtherOriginIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaJapaneseIndicator [4151], [4166]
    /// </summary>
    public bool? HmdaJapaneseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaKoreanIndicator [4152], [4167]
    /// </summary>
    public bool? HmdaKoreanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaMexicanIndicator [4144], [4159]
    /// </summary>
    public bool? HmdaMexicanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaNativeHawaiianIndicator [4155], [4170]
    /// </summary>
    public bool? HmdaNativeHawaiianIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// No Co-applicant Indicator [3840]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No Co-applicant\"}")]
    public bool? HmdaNoCoApplicantIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaNotApplicableIndicator [1530], [1538]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not applicable\"}")]
    public bool? HmdaNotApplicableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaNotProvidedIndicator [1529], [1537]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaNotProvidedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaOtherAsianRace [4128], [4139]
    /// </summary>
    public string? HmdaOtherAsianRace { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaOtherHispanicLatinoOrigin [4125], [4136]
    /// </summary>
    public string? HmdaOtherHispanicLatinoOrigin { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaOtherPacificIslanderRace [4130], [4141]
    /// </summary>
    public string? HmdaOtherPacificIslanderRace { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaOtherScoringModel [4176], [4179]
    /// </summary>
    public string? HmdaOtherScoringModel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaPacificIslanderIndicator [1527], [1535]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Native Hawaiian or Other Pacific Islander\"}")]
    public bool? HmdaPacificIslanderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaPacificIslanderOtherIndicator [4158], [4173]
    /// </summary>
    public bool? HmdaPacificIslanderOtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaPuertoRicanIndicator [4145], [4160]
    /// </summary>
    public bool? HmdaPuertoRicanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceDoNotWishProvideIndicator [4252], [4253]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaRaceDoNotWishProvideIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceInfoNotProvided [4244], [4247]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaRaceInfoNotProvided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField1 [4216], [4226]
    /// </summary>
    public string? HmdaRaceReportedField1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField2 [4217], [4227]
    /// </summary>
    public string? HmdaRaceReportedField2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField3 [4218], [4228]
    /// </summary>
    public string? HmdaRaceReportedField3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField4 [4219], [4229]
    /// </summary>
    public string? HmdaRaceReportedField4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField5 [4220], [4230]
    /// </summary>
    public string? HmdaRaceReportedField5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRaceReportedFields [4237], [4239]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaRaceReportedFields { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaRefusalIndicator [188], [189]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to furnish this info\"}")]
    public bool? HmdaRefusalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaSamoanIndicator [4157], [4172]
    /// </summary>
    public bool? HmdaSamoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaSexInfoNotProvided [4245], [4248]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaSexInfoNotProvided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaVietnameseIndicator [4153], [4168]
    /// </summary>
    public bool? HmdaVietnameseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HmdaWhiteIndicator [1528], [1536]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"White\"}")]
    public bool? HmdaWhiteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HomeCounselingAgencyName [URLA.X232], [URLA.X244]
    /// </summary>
    public string? HomeCounselingAgencyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HomeCounselingCompletionDate [URLA.X233], [URLA.X243]
    /// </summary>
    public DateTime? HomeCounselingCompletionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HomeownerPastThreeYearsIndicator [403], [1108]
    /// </summary>
    public bool? HomeownerPastThreeYearsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower HomePhoneNumber [66], [98]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IncomeRepAndWarrantyMessage [MORNET.X113], [MORNET.X99]
    /// </summary>
    public string? IncomeRepAndWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IncomeRepAndWarrantyReliefAvailable [MORNET.X104], [MORNET.X118]
    /// </summary>
    public bool? IncomeRepAndWarrantyReliefAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Initial1003Provided [CORRESPONDENT.X453], [CORRESPONDENT.X454]
    /// </summary>
    public bool? Initial1003Provided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IntentToOccupyIndicator [418], [1343]
    /// </summary>
    public bool? IntentToOccupyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IntuitReportId [FANNIESERVICE.X5], [FANNIESERVICE.X6]
    /// </summary>
    public string? IntuitReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsBaseIncomeAvailable [MORNET.X105], [MORNET.X119]
    /// </summary>
    public bool? IsBaseIncomeAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsBonusAvailable [MORNET.X106], [MORNET.X120]
    /// </summary>
    public bool? IsBonusAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsBorrower
    /// </summary>
    public bool? IsBorrower { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsCommissionAvailable [MORNET.X108], [MORNET.X122]
    /// </summary>
    public bool? IsCommissionAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsEthnicityBasedOnVisual [4121], [4132]
    /// </summary>
    public StringEnumValue<YNOrNA> IsEthnicityBasedOnVisual { get => GetValue<StringEnumValue<YNOrNA>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsOvertimeAvailable [MORNET.X107], [MORNET.X121]
    /// </summary>
    public bool? IsOvertimeAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsRaceBasedOnVisual [4122], [4133]
    /// </summary>
    public StringEnumValue<YNOrNA> IsRaceBasedOnVisual { get => GetValue<StringEnumValue<YNOrNA>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsSelfEmployed [MORNET.X110], [MORNET.X124]
    /// </summary>
    public bool? IsSelfEmployed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsSexBasedOnVisual [4123], [4134]
    /// </summary>
    public StringEnumValue<YNOrNA> IsSexBasedOnVisual { get => GetValue<StringEnumValue<YNOrNA>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsSocialSecurityAvailable [MORNET.X109], [MORNET.X123]
    /// </summary>
    public bool? IsSocialSecurityAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower IsTaxReturnAvailable [MORNET.X128], [MORNET.X140]
    /// </summary>
    public bool? IsTaxReturnAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower JointAssetLiabilityReportingIndicator [URLA.X3], [URLA.X4]
    /// </summary>
    public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator { get => GetValue<StringEnumValue<JointAssetLiabilityReportingIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Assets/Liabilities Completed Jointly/Not Jointly [URLA.X234]
    /// </summary>
    public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator1 { get => GetValue<StringEnumValue<JointAssetLiabilityReportingIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LanguageCodeOtherDescription [URLA.X35], [URLA.X36]
    /// </summary>
    public string? LanguageCodeOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LanguagePreference [URLA.X21], [URLA.X22]
    /// </summary>
    public StringEnumValue<LanguagePreference> LanguagePreference { get => GetValue<StringEnumValue<LanguagePreference>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LastName [4002], [4006]
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LastNameWithSuffix [37], [69]
    /// </summary>
    public string? LastNameWithSuffix { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LeaveAndEarningsStatement [CORRESPONDENT.X457], [CORRESPONDENT.X458]
    /// </summary>
    public bool? LeaveAndEarningsStatement { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LeDeliveryMethod [CORRESPONDENT.X386], [CORRESPONDENT.X387]
    /// </summary>
    public string? LeDeliveryMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LegacyId
    /// </summary>
    public string? LegacyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LegalOtherThanSpouse [URLA.X111], [URLA.X112]
    /// </summary>
    public bool? LegalOtherThanSpouse { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LiabilitiesDoesNotApply [URLA.X59], [URLA.X60]
    /// </summary>
    public bool? LiabilitiesDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LoanForeclosureOrJudgementIndicator [1057], [1197]
    /// </summary>
    public bool? LoanForeclosureOrJudgementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower LpdGsa [940], [942]
    /// </summary>
    public string? LpdGsa { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MailingAddress
    /// </summary>
    [AllowNull]
    public MailingAddress MailingAddress { get => GetEntity<MailingAddress>(); set => SetEntity(value); }

    /// <summary>
    /// Borrower MailingAddressSameAsPresentIndicator [1819], [1820]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Same as present address\"}")]
    public bool? MailingAddressSameAsPresentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MaritalStatusType [52], [84]
    /// </summary>
    public StringEnumValue<MaritalStatusType> MaritalStatusType { get => GetValue<StringEnumValue<MaritalStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MiddleCreditScore [USDA.X194], [USDA.X195]
    /// </summary>
    public int? MiddleCreditScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MiddleFicoScore [2849], [2850]
    /// </summary>
    public string? MiddleFicoScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MiddleName [4001], [4005]
    /// </summary>
    public string? MiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MilitaryServiceExpectedCompletionDate [URLA.X17], [URLA.X18]
    /// </summary>
    public DateTime? MilitaryServiceExpectedCompletionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MinFicoScore [1484], [1502]
    /// </summary>
    public string? MinFicoScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower MobilePhone [1480], [1490]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MobilePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgage on Credit [2563]
    /// </summary>
    public bool? MortgageOnCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NameToObtainLoanFromRhs [USDA.X45], [USDA.X47]
    /// </summary>
    public string? NameToObtainLoanFromRhs { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeAddress [CAPIAP.X10], [CAPIAP.X17]
    /// </summary>
    public string? NearestRelativeAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeCity [CAPIAP.X11], [CAPIAP.X18]
    /// </summary>
    public string? NearestRelativeCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeCountry [CAPIAP.X64], [CAPIAP.X65]
    /// </summary>
    public string? NearestRelativeCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeForeignAddressIndicator [CAPIAP.X62], [CAPIAP.X63]
    /// </summary>
    public bool? NearestRelativeForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeName [CAPIAP.X16], [CAPIAP.X9]
    /// </summary>
    public string? NearestRelativeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativePhone [CAPIAP.X15], [CAPIAP.X22]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? NearestRelativePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativePostalCode [CAPIAP.X13], [CAPIAP.X20]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? NearestRelativePostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeRelationship [CAPIAP.X14], [CAPIAP.X21]
    /// </summary>
    public string? NearestRelativeRelationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NearestRelativeState [CAPIAP.X12], [CAPIAP.X19]
    /// </summary>
    public string? NearestRelativeState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower NetRentalIncome [CORRESPONDENT.X43], [CORRESPONDENT.X44]
    /// </summary>
    public decimal? NetRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower No3rdPartyEmailIndicator [2857], [2858]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Co-Borrower No Third-Party Email for HomePoints\"}")]
    public bool? No3rdPartyEmailIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borr Ethnicity No Co Applicant [4188]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
    public bool? NoCoApplicantEthnicityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borr Race No Co Applicant [3174]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
    public bool? NoCoApplicantIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borr Sex No Co Applicant [4189]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
    public bool? NoCoApplicantSexIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Number of Tradelines [2564]
    /// </summary>
    public int? NumberofTradelines { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ObtainLoanFromRhsIndicator [USDA.X44], [USDA.X46]
    /// </summary>
    public bool? ObtainLoanFromRhsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Open Bankruptcy [2568]
    /// </summary>
    public StringEnumValue<OpenBankruptcy> OpenBankruptcy2 { get => GetValue<StringEnumValue<OpenBankruptcy>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherAssetsDoesNotApply [URLA.X51], [URLA.X52]
    /// </summary>
    public bool? OtherAssetsDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherLiabilitiesDoesNotApply [URLA.X63], [URLA.X64]
    /// </summary>
    public bool? OtherLiabilitiesDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherMonthlyIncomeAmount [1145], [1146]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherRelationshipTypeDescription [URLA.X115], [URLA.X116]
    /// </summary>
    public string? OtherRelationshipTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherSrcIncomeDoesNotApply [URLA.X40], [URLA.X41]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? OtherSrcIncomeDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OtherSumAmount [108], [117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherSumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OutstandingJudgementsIndicator [169], [175]
    /// </summary>
    public bool? OutstandingJudgementsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OvertimeValidationMessage [MORNET.X134], [MORNET.X146]
    /// </summary>
    public string? OvertimeValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OwnershipConfirmationIndicator [URLA.X153], [URLA.X159]
    /// </summary>
    public bool? OwnershipConfirmationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OwnershipFormatType [URLA.X154], [URLA.X160]
    /// </summary>
    public StringEnumValue<OwnershipFormatType> OwnershipFormatType { get => GetValue<StringEnumValue<OwnershipFormatType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower OwnershipPartyRoleIdentifier [URLA.X155], [URLA.X161]
    /// </summary>
    public string? OwnershipPartyRoleIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PartyToLawsuitIndicator [172], [178]
    /// </summary>
    public bool? PartyToLawsuitIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PartyToLawsuitIndicatorUrla [URLA.X100], [URLA.X101]
    /// </summary>
    public bool? PartyToLawsuitIndicatorUrla { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgage 120 Days [2561]
    /// </summary>
    public int? Pass120Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgage 150 Days [2562]
    /// </summary>
    public int? Pass150Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgage 30 Days [2558]
    /// </summary>
    public int? Pass30Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgaget 60 Days [2559]
    /// </summary>
    public int? Pass60Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Mortgage 90 Days [2560]
    /// </summary>
    public int? Pass90Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PensionRetireIncomeMessage [MORNET.X130], [MORNET.X142]
    /// </summary>
    public string? PensionRetireIncomeMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PersonFaxNumber [1188], [1241]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PersonFaxNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PersonHoursPerWeek [HRSPERWEEK1], [HRSPERWEEK2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PersonHoursPerWeek { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PersonIncomeAmount [INCOMEAMT1], [INCOMEAMT2]
    /// </summary>
    public decimal? PersonIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PersonIncomeFrequencyType [INCOMEFREQ1], [INCOMEFREQ2]
    /// </summary>
    public string? PersonIncomeFrequencyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PersonMonthlyIncome [MONTHLYINCOME1], [MONTHLYINCOME2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PersonMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PiwAccepted [MORNET.X101], [MORNET.X115]
    /// </summary>
    public bool? PiwAccepted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Coborrower - PIW Message [MORNET.X111]
    /// </summary>
    public string? PiwMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PoaOccupancyIntent [Borr.OccupancyIntent], [CoBorr.OccupancyIntent]
    /// </summary>
    public StringEnumValue<OccupancyIntent> PoaOccupancyIntent { get => GetValue<StringEnumValue<OccupancyIntent>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PoaSignatureText [Borr.POASigTxt], [CoBorr.POASigTxt]
    /// </summary>
    public string? PoaSignatureText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PositiveCashFlow [1169], [1170]
    /// </summary>
    public decimal? PositiveCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PowerOfAttorneyName [1870], [1875]
    /// </summary>
    public string? PowerOfAttorneyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PowerOfAttorneyTitleDescription [1872], [1877]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PowerOfAttorneyTitleDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PresentlyDelinquentIndicator [463], [464]
    /// </summary>
    public bool? PresentlyDelinquentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PresentlyDelinquentIndicatorUrla [URLA.X98], [URLA.X99]
    /// </summary>
    public bool? PresentlyDelinquentIndicatorUrla { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PreviousEmploymentDoesNotApply [URLA.X203], [URLA.X204]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? PreviousEmploymentDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PreviousGrossMonthlyIncome [URLA.X245], [URLA.X246]
    /// </summary>
    public decimal? PreviousGrossMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PrintOnAdditionalBorrowerPage [URLA.X121], [URLA.X122]
    /// </summary>
    public bool? PrintOnAdditionalBorrowerPage { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Prior Bankruptcy [2569]
    /// </summary>
    public DateTime? PriorBankruptcy2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Prior Foreclosure [2339]
    /// </summary>
    public bool? PriorForeclosure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorPropertyDeedInLieuConveyedIndicator [URLA.X102], [URLA.X103]
    /// </summary>
    public bool? PriorPropertyDeedInLieuConveyedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorPropertyForeclosureCompletedIndicator [URLA.X106], [URLA.X107]
    /// </summary>
    public bool? PriorPropertyForeclosureCompletedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorPropertyShortSaleCompletedIndicator [URLA.X104], [URLA.X105]
    /// </summary>
    public bool? PriorPropertyShortSaleCompletedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorPropertyTitleType [1069], [1070]
    /// </summary>
    public StringEnumValue<PriorPropertyTitleType> PriorPropertyTitleType { get => GetValue<StringEnumValue<PriorPropertyTitleType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorPropertyUsageType [981], [1015]
    /// </summary>
    public StringEnumValue<PriorPropertyUsageType> PriorPropertyUsageType { get => GetValue<StringEnumValue<PriorPropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PriorResidenceDoesNotApply [URLA.X265], [URLA.X266]
    /// </summary>
    public bool? PriorResidenceDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PropertyForeclosedPastSevenYearsIndicator [170], [176]
    /// </summary>
    public bool? PropertyForeclosedPastSevenYearsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower PropertyProposedCleanEnergyLienIndicator [URLA.X94], [URLA.X95]
    /// </summary>
    public bool? PropertyProposedCleanEnergyLienIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RealEstateDoesNotApply [URLA.X110], [URLA.X69]
    /// </summary>
    public bool? RealEstateDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RelationshipDescription [USDA.X11], [USDA.X14]
    /// </summary>
    public string? RelationshipDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RelationshipWithRdEmployeeIndicator [USDA.X10], [USDA.X13]
    /// </summary>
    public bool? RelationshipWithRdEmployeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ReserveNationalGuardReserveActivated [URLA.X125], [URLA.X128]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Only period of service was as a non-activated member of the Reserve or National Guard\"}")]
    public bool? ReserveNationalGuardReserveActivated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Residences
    /// </summary>
    [AllowNull]
    public IList<Residence> Residences { get => GetList<Residence>(); set => SetList(value); }

    /// <summary>
    /// Borrower RetirementPensionIncomeAvailable [MORNET.X127], [MORNET.X139]
    /// </summary>
    public bool? RetirementPensionIncomeAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe1Date [TQL.X147], [TQL.X197]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe1Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe1Description [TQL.X142], [TQL.X192]
    /// </summary>
    public string? RwtFannieVoe1Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Date [TQL.X148], [TQL.X198]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe2Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Description [TQL.X143], [TQL.X193]
    /// </summary>
    public string? RwtFannieVoe2Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Message [TQL.X150], [TQL.X200]
    /// </summary>
    public string? RwtFannieVoe2Message { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Status [TQL.X145], [TQL.X195]
    /// </summary>
    public string? RwtFannieVoe2Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Date [TQL.X149], [TQL.X199]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe3Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Description [TQL.X144], [TQL.X194]
    /// </summary>
    public string? RwtFannieVoe3Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Message [TQL.X151], [TQL.X201]
    /// </summary>
    public string? RwtFannieVoe3Message { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Status [TQL.X146], [TQL.X196]
    /// </summary>
    public string? RwtFannieVoe3Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiBaseIncomeDate [TQL.X164], [TQL.X214]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiBaseIncomeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiBonusDate [TQL.X165], [TQL.X215]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiBonusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiCommissionDate [TQL.X167], [TQL.X217]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiCommissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiOvertimeDate [TQL.X166], [TQL.X216]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiOvertimeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiRetirementDate [TQL.X169], [TQL.X219]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiRetirementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiSelfEmployedDate [TQL.X170], [TQL.X220]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiSelfEmployedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFannieVoiSocialSecurityDate [TQL.X168], [TQL.X218]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiSocialSecurityDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Date [TQL.X158], [TQL.X208]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe1Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Description [TQL.X152], [TQL.X202]
    /// </summary>
    public string? RwtFreddieVoe1Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Message [TQL.X161], [TQL.X211]
    /// </summary>
    public string? RwtFreddieVoe1Message { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Status [TQL.X155], [TQL.X205]
    /// </summary>
    public string? RwtFreddieVoe1Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Date [TQL.X159], [TQL.X209]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe2Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Description [TQL.X153], [TQL.X203]
    /// </summary>
    public string? RwtFreddieVoe2Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Message [TQL.X162], [TQL.X212]
    /// </summary>
    public string? RwtFreddieVoe2Message { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Status [TQL.X156], [TQL.X206]
    /// </summary>
    public string? RwtFreddieVoe2Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Date [TQL.X160], [TQL.X210]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe3Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Description [TQL.X154], [TQL.X204]
    /// </summary>
    public string? RwtFreddieVoe3Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Message [TQL.X163], [TQL.X213]
    /// </summary>
    public string? RwtFreddieVoe3Message { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Status [TQL.X157], [TQL.X207]
    /// </summary>
    public string? RwtFreddieVoe3Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportDate [TQL.X183], [TQL.X233]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiChildSupportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportMessage [TQL.X190], [TQL.X240]
    /// </summary>
    public string? RwtFreddieVoiChildSupportMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportStatus [TQL.X176], [TQL.X226]
    /// </summary>
    public string? RwtFreddieVoiChildSupportStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryDate [TQL.X182], [TQL.X232]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiMilitaryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryMessage [TQL.X189], [TQL.X239]
    /// </summary>
    public string? RwtFreddieVoiMilitaryMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryStatus [TQL.X175], [TQL.X225]
    /// </summary>
    public string? RwtFreddieVoiMilitaryStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollDate [TQL.X178], [TQL.X228]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiPayrollDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollMessage [TQL.X185], [TQL.X235]
    /// </summary>
    public string? RwtFreddieVoiPayrollMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollStatus [TQL.X171], [TQL.X221]
    /// </summary>
    public string? RwtFreddieVoiPayrollStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionDate [TQL.X179], [TQL.X229]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiPensionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionMessage [TQL.X186], [TQL.X236]
    /// </summary>
    public string? RwtFreddieVoiPensionMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionStatus [TQL.X172], [TQL.X222]
    /// </summary>
    public string? RwtFreddieVoiPensionStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedDate [TQL.X184], [TQL.X234]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiSelfEmployedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedMessage [TQL.X191], [TQL.X241]
    /// </summary>
    public string? RwtFreddieVoiSelfEmployedMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedStatus [TQL.X177], [TQL.X227]
    /// </summary>
    public string? RwtFreddieVoiSelfEmployedStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityDate [TQL.X180], [TQL.X230]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiSocialSecurityDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityMessage [TQL.X187], [TQL.X237]
    /// </summary>
    public string? RwtFreddieVoiSocialSecurityMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityStatus [TQL.X173], [TQL.X223]
    /// </summary>
    public string? RwtFreddieVoiSocialSecurityStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsDate [TQL.X181], [TQL.X231]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiVaBenefitsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsMessage [TQL.X188], [TQL.X238]
    /// </summary>
    public string? RwtFreddieVoiVaBenefitsMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsStatus [TQL.X174], [TQL.X224]
    /// </summary>
    public string? RwtFreddieVoiVaBenefitsStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SchoolingTermYears [39], [71]
    /// </summary>
    public int? SchoolingTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionAExplanation [URLA.X216], [URLA.X271]
    /// </summary>
    public string? SectionAExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionAprintexplanation [URLA.X247], [URLA.X285]
    /// </summary>
    public bool? SectionAprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionBExplanation [URLA.X217], [URLA.X272]
    /// </summary>
    public string? SectionBExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionBprintexplanation [URLA.X248], [URLA.X286]
    /// </summary>
    public bool? SectionBprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionCExplanation [URLA.X218], [URLA.X273]
    /// </summary>
    public string? SectionCExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionCprintexplanation [URLA.X249], [URLA.X287]
    /// </summary>
    public bool? SectionCprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionD1printexplanation [URLA.X250], [URLA.X288]
    /// </summary>
    public bool? SectionD1printexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionD2Explanation [URLA.X235], [URLA.X275]
    /// </summary>
    public string? SectionD2Explanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionD2printexplanation [URLA.X251], [URLA.X289]
    /// </summary>
    public bool? SectionD2printexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionDExplanation [URLA.X219], [URLA.X274]
    /// </summary>
    public string? SectionDExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionEExplanation [URLA.X220], [URLA.X276]
    /// </summary>
    public string? SectionEExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionEprintexplanation [URLA.X252], [URLA.X290]
    /// </summary>
    public bool? SectionEprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionFExplanation [URLA.X221], [URLA.X277]
    /// </summary>
    public string? SectionFExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionFprintexplanation [URLA.X253], [URLA.X291]
    /// </summary>
    public bool? SectionFprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionGExplanation [URLA.X222], [URLA.X278]
    /// </summary>
    public string? SectionGExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionGprintexplanation [URLA.X254], [URLA.X292]
    /// </summary>
    public bool? SectionGprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionHExplanation [URLA.X223], [URLA.X279]
    /// </summary>
    public string? SectionHExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionHprintexplanation [URLA.X255], [URLA.X293]
    /// </summary>
    public bool? SectionHprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionIExplanation [URLA.X224], [URLA.X280]
    /// </summary>
    public string? SectionIExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionIprintexplanation [URLA.X256], [URLA.X294]
    /// </summary>
    public bool? SectionIprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionJExplanation [URLA.X225], [URLA.X281]
    /// </summary>
    public string? SectionJExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionJprintexplanation [URLA.X257], [URLA.X295]
    /// </summary>
    public bool? SectionJprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionKExplanation [URLA.X226], [URLA.X282]
    /// </summary>
    public string? SectionKExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionKprintexplanation [URLA.X258], [URLA.X296]
    /// </summary>
    public bool? SectionKprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionLExplanation [URLA.X227], [URLA.X283]
    /// </summary>
    public string? SectionLExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionLprintexplanation [URLA.X259], [URLA.X297]
    /// </summary>
    public bool? SectionLprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionMExplanation [URLA.X228], [URLA.X284]
    /// </summary>
    public string? SectionMExplanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SectionMprintexplanation [URLA.X260], [URLA.X298]
    /// </summary>
    public bool? SectionMprintexplanation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SelfDeclaredMilitaryServiceIndicator [URLA.X13], [URLA.X14]
    /// </summary>
    public bool? SelfDeclaredMilitaryServiceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SelfEmployedValidationMessage [MORNET.X137], [MORNET.X149]
    /// </summary>
    public string? SelfEmployedValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SpecialBorrowerSellerRelationshipIndicator [URLA.X84], [URLA.X85]
    /// </summary>
    public bool? SpecialBorrowerSellerRelationshipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SpousalVaBenefitsEligibilityIndicator [URLA.X19], [URLA.X20]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Surviving Spouse\"}")]
    public bool? SpousalVaBenefitsEligibilityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89ApplyForLoan [4717], [4718]
    /// </summary>
    public bool? Ssa89ApplyForLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89BackgroundCheckIndicator [3862], [3868]
    /// </summary>
    public bool? Ssa89BackgroundCheckIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89BankingServiceIndicator [3861], [3867]
    /// </summary>
    public bool? Ssa89BankingServiceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89CreditCheckIndicator [3864], [3870]
    /// </summary>
    public bool? Ssa89CreditCheckIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89DescriptionForOther [4719], [4720]
    /// </summary>
    public string? Ssa89DescriptionForOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89LicenseRequirementIndicator [3863], [3869]
    /// </summary>
    public bool? Ssa89LicenseRequirementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89MortgageServiceIndicator [3860], [3866]
    /// </summary>
    public bool? Ssa89MortgageServiceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89OpenRetirementAcct [4715], [4716]
    /// </summary>
    public bool? Ssa89OpenRetirementAcct { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Ssa89OtherIndicator [3865], [3871]
    /// </summary>
    public bool? Ssa89OtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SsnValidationMessage [MORNET.X136], [MORNET.X148]
    /// </summary>
    public string? SsnValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower State [URLA.X117], [URLA.X118]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Subtotal Liquid Assets [915]
    /// </summary>
    public decimal? SubtotalLiquidAssetsMinusGiftAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower SuffixToName [4003], [4007]
    /// </summary>
    public string? SuffixToName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Investor [TQL.X7]
    /// </summary>
    public string? Tax4506LastInvestor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Order Number [TQL.X6]
    /// </summary>
    public string? Tax4506LastOrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Year 1 [TQL.X8]
    /// </summary>
    public int? Tax4506LastOrderYear1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Year 2 [TQL.X9]
    /// </summary>
    public int? Tax4506LastOrderYear2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Year 3 [TQL.X10]
    /// </summary>
    public int? Tax4506LastOrderYear3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Year 4 [TQL.X11]
    /// </summary>
    public int? Tax4506LastOrderYear4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Products Ordered [TQL.X12]
    /// </summary>
    public string? Tax4506LastProductsOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Status [TQL.X5]
    /// </summary>
    public string? Tax4506LastStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Borrower 4506T Orders - Last 4506T Transcript Type [TQL.X13]
    /// </summary>
    public string? Tax4506LastTranscriptType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Last User ID of Person Who Ordered 4506T [TQL.X26]
    /// </summary>
    public string? Tax4506LastUserIdWhoOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome1 [3319], [3323]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome2 [3320], [3324]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome3 [TQL.X14], [TQL.X16]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome4 [TQL.X15], [TQL.X17]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Year 1 Total Joint Income Borr and Co-Borrower [3327]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Year 2 Total Joint Income Borr and Co-Borrower [3328]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 3 Total Joint Income Borr and Co-Borrower [TQL.X18]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 4 Total Joint Income Borr and Co-Borrower [TQL.X19]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome1 [3321], [3325]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome2 [3322], [3326]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome3 [TQL.X20], [TQL.X22]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome4 [TQL.X21], [TQL.X23]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Year 1 Total Variance Joint Income Borr and Co-Borrower [3329]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Year 2 Total Variance Joint Income Borr and Co-Borrower [3330]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 3 Total Variance Joint Income Borr and Co-Borrower [TQL.X24]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 4 Total Variance Joint Income Borr and Co-Borrower [TQL.X25]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TaxIdentificationIdentifier [65], [97]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? TaxIdentificationIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TaxReturnValidationMessage [MORNET.X138], [MORNET.X150]
    /// </summary>
    public string? TaxReturnValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Top Ratio [MORNET.X158]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TopRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Liabilities Amount [URLA.X61]
    /// </summary>
    public decimal? TotalAdditionalLiabilitiesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Other Liabilities Amount [URLA.X67]
    /// </summary>
    public decimal? TotalAdditionalOtherLiabilitiesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalAnnualIncome [CORRESPONDENT.X45], [CORRESPONDENT.X46]
    /// </summary>
    public decimal? TotalAnnualIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalAssets [URLA.X55], [URLA.X56]
    /// </summary>
    public decimal? TotalAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Total Mo Income (Borr/Co-Borr) [MORNET.X160]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalGrossMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalGrossMonthlySalary [CORRESPONDENT.X47], [CORRESPONDENT.X48]
    /// </summary>
    public decimal? TotalGrossMonthlySalary { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Liabilities Amount [URLA.X62]
    /// </summary>
    public decimal? TotalLiabilitiesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Total Liability Balance [733]
    /// </summary>
    public decimal? TotalLiabilitiesBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalMonthlyIncomeAmount [1758], [1759]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalMonthlyIncomeMinusNetRentalAmount [910], [911]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalOtherAssets [URLA.X57], [URLA.X58]
    /// </summary>
    public decimal? TotalOtherAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalOtherIncome [CORRESPONDENT.X49], [CORRESPONDENT.X50]
    /// </summary>
    public decimal? TotalOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalOtherLiabilities [URLA.X65], [URLA.X66]
    /// </summary>
    public decimal? TotalOtherLiabilities { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Other Liabilities Amount [URLA.X68]
    /// </summary>
    public decimal? TotalOtherLiabilitiesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TotalOtherMonthlyLiability [CORRESPONDENT.X51], [CORRESPONDENT.X52]
    /// </summary>
    public decimal? TotalOtherMonthlyLiability { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Present Total Housing [737]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPresentHousingExpenseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransactionPurposeDescription [3249], [3251]
    /// </summary>
    public string? TransactionPurposeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Trans Union 120 Days [2331]
    /// </summary>
    public int? TransUnion120Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Trans Union 150 Days [2556]
    /// </summary>
    public int? TransUnion150Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Trans Union 30 Days [2328]
    /// </summary>
    public int? TransUnion30Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Trans Union 60 Days [2329]
    /// </summary>
    public int? TransUnion60Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Trans Union 90 Days [2330]
    /// </summary>
    public int? TransUnion90Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionCreditScoreForDisclosure [DISCLOSURE.X627], [DISCLOSURE.X628]
    /// </summary>
    public bool? TransUnionCreditScoreForDisclosure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionCreditScoreRanksPercent [DISCLOSURE.X633], [DISCLOSURE.X634]
    /// </summary>
    public int? TransUnionCreditScoreRanksPercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionDatePulled [DISCLOSURE.X31], [DISCLOSURE.X32]
    /// </summary>
    public DateTime? TransUnionDatePulled { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionFactorCode1 [DISCLOSURE.X1007], [DISCLOSURE.X1012]
    /// </summary>
    public string? TransUnionFactorCode1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionFactorCode2 [DISCLOSURE.X1008], [DISCLOSURE.X1013]
    /// </summary>
    public string? TransUnionFactorCode2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionFactorCode3 [DISCLOSURE.X1009], [DISCLOSURE.X1014]
    /// </summary>
    public string? TransUnionFactorCode3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionFactorCode4 [DISCLOSURE.X1010], [DISCLOSURE.X1015]
    /// </summary>
    public string? TransUnionFactorCode4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionFactorCode5 [DISCLOSURE.X1011], [DISCLOSURE.X1016]
    /// </summary>
    public string? TransUnionFactorCode5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor1 [DISCLOSURE.X33], [DISCLOSURE.X37]
    /// </summary>
    public string? TransUnionKeyFactor1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor2 [DISCLOSURE.X34], [DISCLOSURE.X38]
    /// </summary>
    public string? TransUnionKeyFactor2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor3 [DISCLOSURE.X35], [DISCLOSURE.X39]
    /// </summary>
    public string? TransUnionKeyFactor3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor4 [DISCLOSURE.X36], [DISCLOSURE.X40]
    /// </summary>
    public string? TransUnionKeyFactor4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor5 [DISCLOSURE.X174], [DISCLOSURE.X177]
    /// </summary>
    public bool? TransUnionKeyFactor5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionMaterialTermsCreditByScore [DISCLOSURE.X945], [DISCLOSURE.X946]
    /// </summary>
    public bool? TransUnionMaterialTermsCreditByScore { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower TransUnionScore [1450], [1452]
    /// </summary>
    public string? TransUnionScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UndisclosedBorrowedFundsAmount [URLA.X88], [URLA.X89]
    /// </summary>
    public decimal? UndisclosedBorrowedFundsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UndisclosedBorrowedFundsIndicator [URLA.X86], [URLA.X87]
    /// </summary>
    public bool? UndisclosedBorrowedFundsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UndisclosedComakerOfNoteIndicator [URLA.X96], [URLA.X97]
    /// </summary>
    public bool? UndisclosedComakerOfNoteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UndisclosedCreditApplicationIndicator [URLA.X92], [URLA.X93]
    /// </summary>
    public bool? UndisclosedCreditApplicationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UndisclosedMortgageApplicationIndicator [URLA.X90], [URLA.X91]
    /// </summary>
    public bool? UndisclosedMortgageApplicationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Urla2020CitizenshipResidencyType [URLA.X1], [URLA.X2]
    /// </summary>
    public StringEnumValue<Urla2020CitizenshipResidencyType> Urla2020CitizenshipResidencyType { get => GetValue<StringEnumValue<Urla2020CitizenshipResidencyType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Urla2020CountryOfCitizenship [URLA.X263], [URLA.X264]
    /// </summary>
    public string? Urla2020CountryOfCitizenship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UrlaAliasName [URLA.X195], [URLA.X196]
    /// </summary>
    public string? UrlaAliasName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower UrlaAlternateNames
    /// </summary>
    [AllowNull]
    public IList<UrlaAlternateName> UrlaAlternateNames { get => GetList<UrlaAlternateName>(); set => SetList(value); }

    /// <summary>
    /// Borrower UserDefinedIncome [1815], [1816]
    /// </summary>
    public decimal? UserDefinedIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaFederalTaxAmount [1156], [1306]
    /// </summary>
    public decimal? VaFederalTaxAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower ValidDaysForConsentCount [3250], [3252]
    /// </summary>
    public int? ValidDaysForConsentCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Value Rep and Warranty [MORNET.X116]
    /// </summary>
    public bool? ValueRepAndWarrantyAvailable { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Value Rep and Warranty Message [MORNET.X112]
    /// </summary>
    public string? ValueRepAndWarrantyMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaNetTakeHomePayAmount [1313], [1314]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaNetTakeHomePayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaOtherAmount [1309], [VALA.X19]
    /// </summary>
    public decimal? VaOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaOtherNetIncomeAmount [1316], [1317]
    /// </summary>
    public decimal? VaOtherNetIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaRetirementAmount [1159], [1308]
    /// </summary>
    public decimal? VaRetirementAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaStateTaxAmount [1158], [1307]
    /// </summary>
    public decimal? VaStateTaxAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaTotalIncomeDeductionsAmount [1310], [1311]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaTotalIncomeDeductionsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VaTotalNetIncomeAmount [1319], [1320]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaTotalNetIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor1 [GSEVENDOR.X1], [GSEVENDOR.X2]
    /// </summary>
    public string? Vendor1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Inco-Check (Bor,CoBor) [GSEVENDOR.X17]
    /// </summary>
    public string? Vendor10 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Meridian Link (Bor,CoBor) [GSEVENDOR.X18]
    /// </summary>
    public string? Vendor11 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - NCS (Bor,CoBor) [GSEVENDOR.X19]
    /// </summary>
    public string? Vendor12 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Plaid (Bor,CoBor) [GSEVENDOR.X20]
    /// </summary>
    public string? Vendor13 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - PointServ (VOE/VOI/4506T/Asset) (Bor,CoBor) [GSEVENDOR.X21]
    /// </summary>
    public string? Vendor14 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - SharperLending (Bor,CoBor) [GSEVENDOR.X22]
    /// </summary>
    public string? Vendor15 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - VeriTax (Bor,CoBor) [GSEVENDOR.X23]
    /// </summary>
    public string? Vendor16 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Yodlee (Bor,CoBor) [GSEVENDOR.X24]
    /// </summary>
    public string? Vendor17 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - BankVOD (Bor,CoBor) [GSEVENDOR.X25]
    /// </summary>
    public string? Vendor18 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - LendSnap (Bor,CoBor) [GSEVENDOR.X26]
    /// </summary>
    public string? Vendor19 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor2 [GSEVENDOR.X4], [GSEVENDOR.X5]
    /// </summary>
    public string? Vendor2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Quovo (Bor,CoBor) [GSEVENDOR.X27]
    /// </summary>
    public string? Vendor20 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Roostify (Bor,CoBor) [GSEVENDOR.X28]
    /// </summary>
    public string? Vendor21 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - CoreLogic (VOE/VOI) (Bor,CoBor) [GSEVENDOR.X29]
    /// </summary>
    public string? Vendor22 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Advanced Data (4506-T, VOE, VOI) (Bor,CoBor) [GSEVENDOR.X30]
    /// </summary>
    public string? Vendor23 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Partners Credit (IncomeVerify) (Bor,CoBor) [GSEVENDOR.X31]
    /// </summary>
    public string? Vendor24 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Taxdoor 4506-T Service (Chronos) (Bor,CoBor) [GSEVENDOR.X32]
    /// </summary>
    public string? Vendor25 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - ComplianceEase IRS Tax Transcript (Bor,CoBor) [GSEVENDOR.X33]
    /// </summary>
    public string? Vendor26 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Private Eyes (4506-Transcripts.com) (Bor,CoBor) [GSEVENDOR.X34]
    /// </summary>
    public string? Vendor27 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - BankVOD IRS (Bor,CoBor) [GSEVENDOR.X35]
    /// </summary>
    public string? Vendor28 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - QuestSoft (Bor,CoBor) [GSEVENDOR.X36]
    /// </summary>
    public string? Vendor29 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor3 [GSEVENDOR.X6], [GSEVENDOR.X7]
    /// </summary>
    public string? Vendor3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor30 [GSEVENDOR.X37], [GSEVENDOR.X38]
    /// </summary>
    public string? Vendor30 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor31 [GSEVENDOR.X47], [GSEVENDOR.X48]
    /// </summary>
    public string? Vendor31 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor32 [GSEVENDOR.X49], [GSEVENDOR.X50]
    /// </summary>
    public string? Vendor32 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor33 [GSEVENDOR.X51], [GSEVENDOR.X52]
    /// </summary>
    public string? Vendor33 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor34 [GSEVENDOR.X53], [GSEVENDOR.X54]
    /// </summary>
    public string? Vendor34 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor35 [GSEVENDOR.X55], [GSEVENDOR.X56]
    /// </summary>
    public string? Vendor35 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor36 [GSEVENDOR.X57], [GSEVENDOR.X58]
    /// </summary>
    public string? Vendor36 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor37 [GSEVENDOR.X39], [GSEVENDOR.X40]
    /// </summary>
    public string? Vendor37 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor38 [GSEVENDOR.X41], [GSEVENDOR.X42]
    /// </summary>
    public string? Vendor38 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor39 [GSEVENDOR.X43], [GSEVENDOR.X44]
    /// </summary>
    public string? Vendor39 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor4 [GSEVENDOR.X8], [GSEVENDOR.X9]
    /// </summary>
    public string? Vendor4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor40 [GSEVENDOR.X45], [GSEVENDOR.X46]
    /// </summary>
    public string? Vendor40 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor5 [GSEVENDOR.X10], [GSEVENDOR.X11]
    /// </summary>
    public string? Vendor5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vendor6 [GSEVENDOR.X12], [GSEVENDOR.X13]
    /// </summary>
    public string? Vendor6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Corvius (Bor,CoBor) [GSEVENDOR.X14]
    /// </summary>
    public string? Vendor7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - Finlocker (Bor,CoBor) [GSEVENDOR.X15]
    /// </summary>
    public string? Vendor8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Vendor Provider Data - FirstAmerican (Bor,CoBor) [GSEVENDOR.X16]
    /// </summary>
    public string? Vendor9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VestingTrusteeOfType [Borr.TrusteeOf], [CoBorr.TrusteeOf]
    /// </summary>
    public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => GetValue<StringEnumValue<VestingTrusteeOfType>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Veteran [URLA.X124], [URLA.X127]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently retired, discharged, or separated from service\"}")]
    public bool? Veteran { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VeteranIndicator [USDA.X1], [USDA.X4]
    /// </summary>
    public bool? VeteranIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower VvoeWorkNumberDate [CORRESPONDENT.X459], [CORRESPONDENT.X460]
    /// </summary>
    public DateTime? VvoeWorkNumberDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower WorkEmailAddress [1178], [1179]
    /// </summary>
    public string? WorkEmailAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower WorkPhoneNumber [4533], [4534]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? WorkPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Years of Credit on File [2565]
    /// </summary>
    public int? YearsofCreditOnFile { get => GetValue<int?>(); set => SetValue(value); }
}