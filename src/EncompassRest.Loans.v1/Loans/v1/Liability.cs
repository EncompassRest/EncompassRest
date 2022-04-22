using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Liability
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AccountIndicator) + "," + nameof(LiabilityType), SerializeWholeListWhenDirty = true)]
public sealed partial class Liability : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Liability AccountIdentifier [255], [1058]
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability AccountIndicator
    /// </summary>
    public bool? AccountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Contact [FLNN03]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Bank Liability Considered in Exposure Indicator [FLNN30]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Bank Liability Considered in Exposure Indicator\"}")]
    public bool? BankLiabilityConsideredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Country [FLNN68]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Credit Limit [FLNN31]
    /// </summary>
    public decimal? CreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Current Lien Position [FLNN28]
    /// </summary>
    public StringEnumValue<LienPosition> CurrentLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Request Date [FLNN98]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Alimony/Child Support Descr [271]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// .Description Of Purpose [FLNN43]
    /// </summary>
    public string? DescriptionOfPurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Energy Efficient Debts including PACE loans [FLNN69]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"PACE Loan\",\"N\":\"Energy Improvement\"}")]
    public bool? EnergyEfficientDebts { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Exclude from URLA Total [FLNN17]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Exclude from URLA page 2 Liabilities Total\"}")]
    public bool? ExclusionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Foreign Address Indicator [FLNN67]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor City [FLNN05]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Zipcode [FLNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor State [FLNN06]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Address [FLNN04]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Comments [FLNN23]
    /// </summary>
    public string? HolderComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Email [FLNN22]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Fax [FLNN21]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Name [FLNN02]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Creditor Phone [FLNN20]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Payment includes Taxes and Insurance [FLNN66]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment includes Taxes and Insurance\"}")]
    public bool? IncludeTaxesAndInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Debt is NOT secured to Subject Property [FLNN61]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"This Debt is NOT secured to Subject Property?\"}")]
    public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 120 Day Lates [FLNN55]
    /// </summary>
    public int? Lates12Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 150 Day Lates [FLNN58]
    /// </summary>
    public int? Lates12Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 30 Day Lates [FLNN46]
    /// </summary>
    public int? Lates12Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 60 Day Lates [FLNN49]
    /// </summary>
    public int? Lates12Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 12 Month 90 Day Lates [FLNN52]
    /// </summary>
    public int? Lates12Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 120 Day Lates [FLNN56]
    /// </summary>
    public int? Lates24Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 150 Day Lates [FLNN59]
    /// </summary>
    public int? Lates24Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 30 Day Lates [FLNN47]
    /// </summary>
    public int? Lates24Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 60 Day Lates [FLNN50]
    /// </summary>
    public int? Lates24Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 24 Month 90 Day Lates [FLNN53]
    /// </summary>
    public int? Lates24Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 120 Day Lates [FLNN57]
    /// </summary>
    public int? Lates25Month120Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 150 Day Lates [FLNN60]
    /// </summary>
    public int? Lates25Month150Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 30 Day Lates [FLNN48]
    /// </summary>
    public int? Lates25Month30Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 60 Day Lates [FLNN51]
    /// </summary>
    public int? Lates25Month60Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability 25 Month 90 Day Lates [FLNN54]
    /// </summary>
    public int? Lates25Month90Day { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability LiabilityIndex
    /// </summary>
    public int? LiabilityIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Account Type [FLNN08]
    /// </summary>
    public StringEnumValue<LiabilityType> LiabilityType { get => GetValue<StringEnumValue<LiabilityType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability MonthlyPaymentAmount [FLNN11]
    /// </summary>
    public decimal? MonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Install Mos to Exclude [FLNN14]
    /// </summary>
    public int? MonthsToExclude { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Type [FLNN32]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"HELOC\"]")]
    public StringEnumValue<LoanType> MortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Account Name [FLNN09]
    /// </summary>
    public string? NameInAccount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability No Link to Doc Tracking [FLNN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Account Type Description [FLNN65]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Verif is For [FLNN15]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off and will be included [FLNN63]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Paid off (*) will be included\"}")]
    public bool? PayoffIncludedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Will be Paid Off [FLNN18]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Will be paid off (*)\"}")]
    public bool? PayoffStatusIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Prepayment Penalty [FLNN39]
    /// </summary>
    public decimal? PrepaymentPenaltyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print - See Attached Authorization [FLNN36]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print User Job Title [FLNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Print User Name as Title [FLNN38]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Proposed Lien Position [FLNN29]
    /// </summary>
    public StringEnumValue<LienPosition> ProposedLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Liability RemainingTermMonths [FLNN12]
    /// </summary>
    public int? RemainingTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Liability REO ID [FLNN25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReoId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Request ID [FLNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequestId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Resubordinated Indicator [FLNN26]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Resubordinated Indicator\"}")]
    public bool? SubjectLoanResubordinationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Indicator [FLNN27]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Subject Property Indicator\"}")]
    public bool? SubjectPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Title [FLNN37]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Fax [FLNN45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability From Phone [FLNN44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Payoff Amount [FLNN16]
    /// </summary>
    public decimal? ToBePaidOffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability UCD Payoff Type [FLNN62]
    /// </summary>
    public StringEnumValue<UCDPayoffType> UCDPayoffType { get => GetValue<StringEnumValue<UCDPayoffType>>(); set => SetValue(value); }

    /// <summary>
    /// Liability Balance [FLNN13]
    /// </summary>
    public decimal? UnpaidBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability VolIndex
    /// </summary>
    public int? VolIndex { get => GetValue<int?>(); set => SetValue(value); }
}