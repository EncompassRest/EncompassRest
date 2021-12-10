using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Vol
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Vol : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountIdentifier;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _attention;
    private DirtyValue<bool?>? _bankLiabilityConsideredIndicator;
    private DirtyValue<string?>? _country;
    private DirtyValue<decimal?>? _creditLimit;
    private DirtyValue<StringEnumValue<LienPosition>>? _currentLienPosition;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _descriptionOfPurpose;
    private DirtyValue<bool?>? _energyEfficientDebts;
    private DirtyValue<bool?>? _exclusionIndicator;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderComments;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _includeTaxesAndInsuranceIndicator;
    private DirtyValue<bool?>? _isDebtNotSecuredToSubjectPropertyIndicator;
    private DirtyValue<int?>? _lates12Month120Day;
    private DirtyValue<int?>? _lates12Month150Day;
    private DirtyValue<int?>? _lates12Month30Day;
    private DirtyValue<int?>? _lates12Month60Day;
    private DirtyValue<int?>? _lates12Month90Day;
    private DirtyValue<int?>? _lates24Month120Day;
    private DirtyValue<int?>? _lates24Month150Day;
    private DirtyValue<int?>? _lates24Month30Day;
    private DirtyValue<int?>? _lates24Month60Day;
    private DirtyValue<int?>? _lates24Month90Day;
    private DirtyValue<int?>? _lates25Month120Day;
    private DirtyValue<int?>? _lates25Month150Day;
    private DirtyValue<int?>? _lates25Month30Day;
    private DirtyValue<int?>? _lates25Month60Day;
    private DirtyValue<int?>? _lates25Month90Day;
    private DirtyValue<StringEnumValue<LiabilityType>>? _liabilityType;
    private DirtyValue<decimal?>? _monthlyPaymentAmount;
    private DirtyValue<int?>? _monthsToExclude;
    private DirtyValue<StringEnumValue<LoanType>>? _mortgageType;
    private DirtyValue<string?>? _nameInAccount;
    private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
    private DirtyValue<string?>? _otherDescription;
    private DirtyValue<StringEnumValue<Owner>>? _owner;
    private DirtyValue<bool?>? _payoffIncludedIndicator;
    private DirtyValue<bool?>? _payoffStatusIndicator;
    private DirtyValue<decimal?>? _prepaymentPenaltyAmount;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<StringEnumValue<LienPosition>>? _proposedLienPosition;
    private DirtyValue<int?>? _remainingTermMonths;
    private EntityReference? _reoProperty;
    private DirtyValue<string?>? _requestId;
    private DirtyValue<bool?>? _subjectLoanResubordinationIndicator;
    private DirtyValue<bool?>? _subjectPropertyIndicator;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;
    private DirtyValue<decimal?>? _toBePaidOffAmount;
    private DirtyValue<StringEnumValue<UCDPayoffType>>? _ucdPayoffType;
    private DirtyValue<decimal?>? _unpaidBalanceAmount;

    /// <summary>
    /// Liability Account Number [FL0010]
    /// </summary>
    public string? AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

    /// <summary>
    /// VolContract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Liability Creditor Contact [FL0003]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Bank Liability Considered in Exposure Indicator [FL0030]
    /// </summary>
    public bool? BankLiabilityConsideredIndicator { get => _bankLiabilityConsideredIndicator; set => SetField(ref _bankLiabilityConsideredIndicator, value); }

    /// <summary>
    /// Liability Creditor Country [FL0068]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Credit Limit [FL0031]
    /// </summary>
    public decimal? CreditLimit { get => _creditLimit; set => SetField(ref _creditLimit, value); }

    /// <summary>
    /// Current Lien Position [FL0028]
    /// </summary>
    public StringEnumValue<LienPosition> CurrentLienPosition { get => _currentLienPosition; set => SetField(ref _currentLienPosition, value); }

    /// <summary>
    /// Liability Request Date [FL0098]
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// .Description Of Purpose [FL0043]
    /// </summary>
    public string? DescriptionOfPurpose { get => _descriptionOfPurpose; set => SetField(ref _descriptionOfPurpose, value); }

    /// <summary>
    /// Energy Efficient Debts including PACE loans [FL0069]
    /// </summary>
    public bool? EnergyEfficientDebts { get => _energyEfficientDebts; set => SetField(ref _energyEfficientDebts, value); }

    /// <summary>
    /// Liability Exclude from URLA Total [FL0017]
    /// </summary>
    public bool? ExclusionIndicator { get => _exclusionIndicator; set => SetField(ref _exclusionIndicator, value); }

    /// <summary>
    /// Liability Creditor Foreign Address Indicator [FL0067]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// Liability Creditor City [FL0005]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Liability Creditor Zipcode [FL0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Liability Creditor State [FL0006]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Liability Creditor Address [FL0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Liability Creditor Comments [FL0023]
    /// </summary>
    public string? HolderComments { get => _holderComments; set => SetField(ref _holderComments, value); }

    /// <summary>
    /// Liability Creditor Email [FL0022]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Liability Creditor Fax [FL0021]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Liability Creditor Name [FL0002]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Liability Creditor Phone [FL0020]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// VolContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Payment includes Taxes and Insurance [FL0066]
    /// </summary>
    public bool? IncludeTaxesAndInsuranceIndicator { get => _includeTaxesAndInsuranceIndicator; set => SetField(ref _includeTaxesAndInsuranceIndicator, value); }

    /// <summary>
    /// Liability Debt is NOT secured to Subject Property [FL0061]
    /// </summary>
    public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => _isDebtNotSecuredToSubjectPropertyIndicator; set => SetField(ref _isDebtNotSecuredToSubjectPropertyIndicator, value); }

    /// <summary>
    /// Liability 12 Month 120 Day Lates [FL0055]
    /// </summary>
    public int? Lates12Month120Day { get => _lates12Month120Day; set => SetField(ref _lates12Month120Day, value); }

    /// <summary>
    /// Liability 12 Month 150 Day Lates [FL0058]
    /// </summary>
    public int? Lates12Month150Day { get => _lates12Month150Day; set => SetField(ref _lates12Month150Day, value); }

    /// <summary>
    /// Liability 12 Month 30 Day Lates [FL0046]
    /// </summary>
    public int? Lates12Month30Day { get => _lates12Month30Day; set => SetField(ref _lates12Month30Day, value); }

    /// <summary>
    /// Liability 12 Month 60 Day Lates [FL0049]
    /// </summary>
    public int? Lates12Month60Day { get => _lates12Month60Day; set => SetField(ref _lates12Month60Day, value); }

    /// <summary>
    /// Liability 12 Month 90 Day Lates [FL0052]
    /// </summary>
    public int? Lates12Month90Day { get => _lates12Month90Day; set => SetField(ref _lates12Month90Day, value); }

    /// <summary>
    /// Liability 24 Month 120 Day Lates [FL0056]
    /// </summary>
    public int? Lates24Month120Day { get => _lates24Month120Day; set => SetField(ref _lates24Month120Day, value); }

    /// <summary>
    /// Liability 24 Month 150 Day Lates [FL0059]
    /// </summary>
    public int? Lates24Month150Day { get => _lates24Month150Day; set => SetField(ref _lates24Month150Day, value); }

    /// <summary>
    /// Liability 24 Month 30 Day Lates [FL0047]
    /// </summary>
    public int? Lates24Month30Day { get => _lates24Month30Day; set => SetField(ref _lates24Month30Day, value); }

    /// <summary>
    /// Liability 24 Month 60 Day Lates [FL0050]
    /// </summary>
    public int? Lates24Month60Day { get => _lates24Month60Day; set => SetField(ref _lates24Month60Day, value); }

    /// <summary>
    /// Liability 24 Month 90 Day Lates [FL0053]
    /// </summary>
    public int? Lates24Month90Day { get => _lates24Month90Day; set => SetField(ref _lates24Month90Day, value); }

    /// <summary>
    /// Liability 25 Month 120 Day Lates [FL0057]
    /// </summary>
    public int? Lates25Month120Day { get => _lates25Month120Day; set => SetField(ref _lates25Month120Day, value); }

    /// <summary>
    /// Liability 25 Month 150 Day Lates [FL0060]
    /// </summary>
    public int? Lates25Month150Day { get => _lates25Month150Day; set => SetField(ref _lates25Month150Day, value); }

    /// <summary>
    /// Liability 25 Month 30 Day Lates [FL0048]
    /// </summary>
    public int? Lates25Month30Day { get => _lates25Month30Day; set => SetField(ref _lates25Month30Day, value); }

    /// <summary>
    /// Liability 25 Month 60 Day Lates [FL0051]
    /// </summary>
    public int? Lates25Month60Day { get => _lates25Month60Day; set => SetField(ref _lates25Month60Day, value); }

    /// <summary>
    /// Liability 25 Month 90 Day Lates [FL0054]
    /// </summary>
    public int? Lates25Month90Day { get => _lates25Month90Day; set => SetField(ref _lates25Month90Day, value); }

    /// <summary>
    /// Liability Account Type [FL0008]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"JobRelatedExpenses\",\"Alimony\"]")]
    public StringEnumValue<LiabilityType> LiabilityType { get => _liabilityType; set => SetField(ref _liabilityType, value); }

    /// <summary>
    /// Liability Monthly Payment [FL0011]
    /// </summary>
    public decimal? MonthlyPaymentAmount { get => _monthlyPaymentAmount; set => SetField(ref _monthlyPaymentAmount, value); }

    /// <summary>
    /// Liabilities Install Mos to Exclude [FL0014]
    /// </summary>
    public int? MonthsToExclude { get => _monthsToExclude; set => SetField(ref _monthsToExclude, value); }

    /// <summary>
    /// Mortgage Type [FL0032]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"HELOC\"]")]
    public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

    /// <summary>
    /// Liability Account Name [FL0009]
    /// </summary>
    public string? NameInAccount { get => _nameInAccount; set => SetField(ref _nameInAccount, value); }

    /// <summary>
    /// Liability No Link to Doc Tracking [FL0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

    /// <summary>
    /// Other Account Type Description [FL0065]
    /// </summary>
    public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// Liability Verif is For [FL0015]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [FL0063]
    /// </summary>
    public bool? PayoffIncludedIndicator { get => _payoffIncludedIndicator; set => SetField(ref _payoffIncludedIndicator, value); }

    /// <summary>
    /// Liability Will be Paid Off [FL0018]
    /// </summary>
    public bool? PayoffStatusIndicator { get => _payoffStatusIndicator; set => SetField(ref _payoffStatusIndicator, value); }

    /// <summary>
    /// Liability Prepayment Penalty [FL0039]
    /// </summary>
    public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => SetField(ref _prepaymentPenaltyAmount, value); }

    /// <summary>
    /// Liability Print - See Attached Authorization [FL0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Liability Print User Job Title [FL0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Liability Print User Name as Title [FL0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Proposed Lien Position [FL0029]
    /// </summary>
    public StringEnumValue<LienPosition> ProposedLienPosition { get => _proposedLienPosition; set => SetField(ref _proposedLienPosition, value); }

    /// <summary>
    /// Liability Months Remaining [FL0012]
    /// </summary>
    public int? RemainingTermMonths { get => _remainingTermMonths; set => SetField(ref _remainingTermMonths, value); }

    /// <summary>
    /// VolContract ReoProperty
    /// </summary>
    [AllowNull]
    public EntityReference ReoProperty { get => GetField(ref _reoProperty); set => SetField(ref _reoProperty, value); }

    /// <summary>
    /// Liability Request ID [FL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequestId { get => _requestId; set => SetField(ref _requestId, value); }

    /// <summary>
    /// Liability Resubordinated Indicator [FL0026]
    /// </summary>
    public bool? SubjectLoanResubordinationIndicator { get => _subjectLoanResubordinationIndicator; set => SetField(ref _subjectLoanResubordinationIndicator, value); }

    /// <summary>
    /// Subject Property Indicator [FL0027]
    /// </summary>
    public bool? SubjectPropertyIndicator { get => _subjectPropertyIndicator; set => SetField(ref _subjectPropertyIndicator, value); }

    /// <summary>
    /// Liability From Title [FL0037]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Liability From Fax [FL0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Liability From Phone [FL0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

    /// <summary>
    /// Liability Payoff Amount [FL0016]
    /// </summary>
    public decimal? ToBePaidOffAmount { get => _toBePaidOffAmount; set => SetField(ref _toBePaidOffAmount, value); }

    /// <summary>
    /// Liability UCD Payoff Type [FL0062]
    /// </summary>
    public StringEnumValue<UCDPayoffType> UcdPayoffType { get => _ucdPayoffType; set => SetField(ref _ucdPayoffType, value); }

    /// <summary>
    /// Liability Balance [FL0013]
    /// </summary>
    public decimal? UnpaidBalanceAmount { get => _unpaidBalanceAmount; set => SetField(ref _unpaidBalanceAmount, value); }
}