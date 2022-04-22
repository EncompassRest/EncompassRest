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
    /// <summary>
    /// Liability Account Number [FL0010]
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vol AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Contact [FL0003]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Bank Liability Considered in Exposure Indicator [FL0030]
    /// </summary>
    public bool? BankLiabilityConsideredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Country [FL0068]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Credit Limit [FL0031]
    /// </summary>
    public decimal? CreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Current Lien Position [FL0028]
    /// </summary>
    public StringEnumValue<LienPosition> CurrentLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Request Date [FL0098]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// .Description Of Purpose [FL0043]
    /// </summary>
    public string? DescriptionOfPurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Energy Efficient Debts including PACE loans [FL0069]
    /// </summary>
    public bool? EnergyEfficientDebts { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Exclude from URLA Total [FL0017]
    /// </summary>
    public bool? ExclusionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Foreign Address Indicator [FL0067]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor City [FL0005]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Zipcode [FL0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor State [FL0006]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Address [FL0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Comments [FL0023]
    /// </summary>
    public string? HolderComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Email [FL0022]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Fax [FL0021]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Name [FL0002]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Phone [FL0020]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vol Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Payment includes Taxes and Insurance [FL0066]
    /// </summary>
    public bool? IncludeTaxesAndInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Debt is NOT secured to Subject Property [FL0061]
    /// </summary>
    public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 120 Day Lates [FL0055]
    /// </summary>
    public int? Lates12Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 150 Day Lates [FL0058]
    /// </summary>
    public int? Lates12Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 30 Day Lates [FL0046]
    /// </summary>
    public int? Lates12Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 60 Day Lates [FL0049]
    /// </summary>
    public int? Lates12Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 90 Day Lates [FL0052]
    /// </summary>
    public int? Lates12Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 120 Day Lates [FL0056]
    /// </summary>
    public int? Lates24Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 150 Day Lates [FL0059]
    /// </summary>
    public int? Lates24Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 30 Day Lates [FL0047]
    /// </summary>
    public int? Lates24Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 60 Day Lates [FL0050]
    /// </summary>
    public int? Lates24Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 90 Day Lates [FL0053]
    /// </summary>
    public int? Lates24Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 120 Day Lates [FL0057]
    /// </summary>
    public int? Lates25Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 150 Day Lates [FL0060]
    /// </summary>
    public int? Lates25Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 30 Day Lates [FL0048]
    /// </summary>
    public int? Lates25Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 60 Day Lates [FL0051]
    /// </summary>
    public int? Lates25Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 90 Day Lates [FL0054]
    /// </summary>
    public int? Lates25Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Account Type [FL0008]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"JobRelatedExpenses\",\"Alimony\"]")]
    public StringEnumValue<LiabilityType> LiabilityType { get => GetValue<StringEnumValue<LiabilityType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Monthly Payment [FL0011]
    /// </summary>
    public decimal? MonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Install Mos to Exclude [FL0014]
    /// </summary>
    public int? MonthsToExclude { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Type [FL0032]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"HELOC\"]")]
    public StringEnumValue<LoanType> MortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Account Name [FL0009]
    /// </summary>
    public string? NameInAccount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability No Link to Doc Tracking [FL0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Account Type Description [FL0065]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Verif is For [FL0015]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [FL0063]
    /// </summary>
    public bool? PayoffIncludedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off [FL0018]
    /// </summary>
    public bool? PayoffStatusIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Prepayment Penalty [FL0039]
    /// </summary>
    public decimal? PrepaymentPenaltyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print - See Attached Authorization [FL0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print User Job Title [FL0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print User Name as Title [FL0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Proposed Lien Position [FL0029]
    /// </summary>
    public StringEnumValue<LienPosition> ProposedLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Months Remaining [FL0012]
    /// </summary>
    public int? RemainingTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Vol ReoProperty
    /// </summary>
    [AllowNull]
    public EntityReference ReoProperty { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Liability Request ID [FL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequestId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Resubordinated Indicator [FL0026]
    /// </summary>
    public bool? SubjectLoanResubordinationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Indicator [FL0027]
    /// </summary>
    public bool? SubjectPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Title [FL0037]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Fax [FL0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Phone [FL0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Payoff Amount [FL0016]
    /// </summary>
    public decimal? ToBePaidOffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability UCD Payoff Type [FL0062]
    /// </summary>
    public StringEnumValue<UCDPayoffType> UcdPayoffType { get => GetValue<StringEnumValue<UCDPayoffType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Balance [FL0013]
    /// </summary>
    public decimal? UnpaidBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}