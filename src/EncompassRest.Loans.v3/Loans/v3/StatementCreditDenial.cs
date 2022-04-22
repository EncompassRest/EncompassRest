using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StatementCreditDenial
/// </summary>
public sealed partial class StatementCreditDenial : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Denial Discl Additional Stmt [DENIAL.X26]
    /// </summary>
    public bool? AdditionalStatement { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Bankruptcy [DENIAL.X40]
    /// </summary>
    public bool? Bankruptcy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Value or Type of Collateral is Not Sufficient [DENIAL.X80]
    /// </summary>
    public bool? CollateralNotSufficient { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Credit Appl Incomplete [DENIAL.X57]
    /// </summary>
    public bool? CreditApplicationIncomplete { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info Obtained Your Credit Score from this Consumer Reporting Agency  [DENIAL.X76]
    /// </summary>
    public bool? CreditReportObtainedFromConsumerReportingAgency { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Delinq Credit Oblig [DENIAL.X39]
    /// </summary>
    public bool? DelinquentCreditObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Date [DENIAL.X69]
    /// </summary>
    public DateTime? DenialDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Additional Stmt Detail [DENIAL.X27]
    /// </summary>
    public string? DenialDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Mailed Date [DENIAL.X11]
    /// </summary>
    public DateTime? DenialMailedOn { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Other 1 [DENIAL.X65]
    /// </summary>
    public bool? DenialOther1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Other 2 [DENIAL.X67]
    /// </summary>
    public bool? DenialOther2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Other 1 Descr [DENIAL.X66]
    /// </summary>
    public string? DenialOtherDesc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Other 2 Descr [DENIAL.X68]
    /// </summary>
    public string? DenialOtherDesc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denied By [DENIAL.X70]
    /// </summary>
    public string? DeniedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By FHLMC [DENIAL.X53]
    /// </summary>
    public bool? DeniedByFhlmc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By FNMA [DENIAL.X52]
    /// </summary>
    public bool? DeniedByFnma { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By HUD [DENIAL.X50]
    /// </summary>
    public bool? DeniedByHud { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By Other [DENIAL.X54]
    /// </summary>
    public bool? DeniedByOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By VA [DENIAL.X51]
    /// </summary>
    public bool? DeniedByVa { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Statement of Denial - Description of Account, Transaction or Request Credit Line 1 [DENIAL.X71]
    /// </summary>
    public string? DescriptionofAccount1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Statement of Denial - Description of Account, Transaction or Request Credit Line 2 [DENIAL.X72]
    /// </summary>
    public string? DescriptionofAccount2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Statement of Denial - Description of Account, Transaction or Request Credit Line 3 [DENIAL.X73]
    /// </summary>
    public string? DescriptionofAccount3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Statement of Denial - Description of Action Taken Line 1 [DENIAL.X74]
    /// </summary>
    public string? DescriptionofActionTaken1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Statement of Denial - Description of Action Taken Line 2 [DENIAL.X75]
    /// </summary>
    public string? DescriptionofActionTaken2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA Addr [ECOA_ADDR]
    /// </summary>
    public string? EcoaAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA Addr2 [ECOA_ADDR2]
    /// </summary>
    public string? EcoaAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA City [ECOA_CITY]
    /// </summary>
    public string? EcoaCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA Name [ECOA_NAME]
    /// </summary>
    public string? EcoaName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA Phone [ECOA_PHONE]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EcoaPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA Zip [ECOA_ZIP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? EcoaPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial ECOA State [ECOA_ST]
    /// </summary>
    public string? EcoaState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Excessive Obligations [DENIAL.X35]
    /// </summary>
    public bool? ExcessiveObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Garnish, Attach, Foreclsr, Repo, Suit [DENIAL.X34]
    /// </summary>
    public bool? Garnishment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Inadequate Collateral [DENIAL.X58]
    /// </summary>
    public bool? InadequateCollateral { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Info from Credit Rpt Agency [DENIAL.X41]
    /// </summary>
    public bool? InformationFromAConsumerReportingAgency { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info From Other Source [DENIAL.X25]
    /// </summary>
    public bool? InformationObtainedFromOutsideSource { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Discl Info Obtained from Credit Rpt Agency [DENIAL.X12]
    /// </summary>
    public bool? InformationObtainedInReportFromCra { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Insuff File [DENIAL.X32]
    /// </summary>
    public bool? InsufficientCreditFile { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Insuff Reference [DENIAL.X31]
    /// </summary>
    public bool? InsufficientCreditReference { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Inadequate Collateral Insuff Prpty Info [DENIAL.X60]
    /// </summary>
    public bool? InsufficientData { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Insuff Funds to Close [DENIAL.X56]
    /// </summary>
    public bool? InsufficientFundsToCloseLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Excess Oblig/Insuff Income [DENIAL.X36]
    /// </summary>
    public bool? InsufficientIncomeForTotalObligations { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Income - Insuff [DENIAL.X45]
    /// </summary>
    public bool? InsufficientStabilityOfIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Excess Oblig/Lack Cash Resrvs [DENIAL.X38]
    /// </summary>
    public bool? LackOfCashReserves { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Addr [DENIAL.X92]
    /// </summary>
    public string? LenderInvestorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts City [DENIAL.X93]
    /// </summary>
    public string? LenderInvestorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Co Name [DENIAL.X91]
    /// </summary>
    public string? LenderInvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Phone [DENIAL.X96]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderInvestorPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Zip [DENIAL.X95]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LenderInvestorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts State [DENIAL.X94]
    /// </summary>
    public string? LenderInvestorState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Empl Status - Length [DENIAL.X43]
    /// </summary>
    public bool? LengthOfEmployment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - No File [DENIAL.X30]
    /// </summary>
    public bool? NoCreditFile { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Number of Recent Inquiries on Credit Bureau Report [DENIAL.X79]
    /// </summary>
    public bool? NumberRecentInquiriesCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial - Denied By Other Descr [DENIAL.X55]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Poor Credit Performance With Us [DENIAL.X78]
    /// </summary>
    public bool? PoorCreditPerformance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Empl Status - Temp or Irregular [DENIAL.X44]
    /// </summary>
    public bool? TemporaryOrIrregularEmployment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Residency Temp [DENIAL.X47]
    /// </summary>
    public bool? TemporaryResidence { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Residency Too Short [DENIAL.X48]
    /// </summary>
    public bool? ToShortPeriodOfResidence { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Unable to Verify Refs [DENIAL.X33]
    /// </summary>
    public bool? UnableToVerifyCreditReferences { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Empl Status - Unable to Verify [DENIAL.X42]
    /// </summary>
    public bool? UnableToVerifyEmployment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Income - Unable to Verify [DENIAL.X46]
    /// </summary>
    public bool? UnableToVerifyIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Residency Unable to Verify [DENIAL.X49]
    /// </summary>
    public bool? UnableToVerifyResidence { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Inadequate Collateral Apprais Unaccept [DENIAL.X61]
    /// </summary>
    public bool? UnacceptableAppraisal { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Unacceptable Type of Credit References Provided [DENIAL.X77]
    /// </summary>
    public bool? UnacceptableCreditReferencesProvided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Inadequate Collateral Unaccept Leasehld [DENIAL.X62]
    /// </summary>
    public bool? UnacceptableLeaseholdEstate { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Credit - Excess Oblig/Unaccept Pymt Record [DENIAL.X37]
    /// </summary>
    public bool? UnacceptablePaymentRecordOnPreviousMtg { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Inadequate Collateral Prpty Unaccept [DENIAL.X59]
    /// </summary>
    public bool? UnacceptableProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - we do not grant credit to any appl on? [DENIAL.X63]
    /// </summary>
    public bool? WeDoNotGrantCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Other - Withdrawn by Applicant [DENIAL.X64]
    /// </summary>
    public bool? WithdrawnByApplicant { get => GetValue<bool?>(); set => SetValue(value); }
}