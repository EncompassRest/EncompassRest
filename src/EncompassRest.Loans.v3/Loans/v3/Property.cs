using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Property
/// </summary>
public sealed partial class Property : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Property Address Line Text [URLA.X73]
    /// </summary>
    public string? AddressLineText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address Unit Type Identifier [URLA.X74]
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Property Address Unit Identifier [URLA.X75]
    /// </summary>
    public string? AddressUnitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Parcel # [1894]
    /// </summary>
    public string? AssessorsParcelIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Block Identifier [2974]
    /// </summary>
    public string? BlockIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property is Borrower's Homestead [3198]
    /// </summary>
    public bool? BorrowerHomesteadIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Building Status [601]
    /// </summary>
    public StringEnumValue<BuildingStatusType> BuildingStatusType { get => GetValue<StringEnumValue<BuildingStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property City [12]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Is Condotel [3315]
    /// </summary>
    public bool? CondotelIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Improvement Cost [23]
    /// </summary>
    public decimal? ConstructionImprovementCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property County [13]
    /// </summary>
    public string? County { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Secondary Residence Indicator [URLA.X76]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Secondary Residence\"}")]
    public bool? FhaSecondaryResidenceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property # Units [16]
    /// </summary>
    public int? FinancedNumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Flood Certification Identifier [2977]
    /// </summary>
    public string? FloodCertificationIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Cash Out Amt [CASASRN.X79]
    /// </summary>
    public decimal? FreCashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Purpose [299]
    /// </summary>
    public StringEnumValue<RefinancePurpose> GseRefinancePurposeType { get => GetValue<StringEnumValue<RefinancePurpose>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Manner Held [33]
    /// </summary>
    public StringEnumValue<GseTitleMannerHeldDescription> GseTitleMannerHeldDescription { get => GetValue<StringEnumValue<GseTitleMannerHeldDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Construction Phase Disclosed Separately [4084]
    /// </summary>
    public bool? IsConstructionPhaseDisclosedSeparately { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Lot Value [22]
    /// </summary>
    public decimal? LandEstimatedValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Desc1 [17]
    /// </summary>
    public string? LegalDescriptionText1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr 2 [1824]
    /// </summary>
    public string? LegalDescriptionText2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Linked Affordable Loan Indicator [LINK_URLA.X210]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan\"}")]
    public bool? LinkedAffordableLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Amount Apply To Down Payment - Copied from Linked Loan [LINK_4493]
    /// </summary>
    public decimal? LinkedAmountApplyToDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Linked Trans Details Total Loan Amt (w/ MIP/FF) [LINK_2]
    /// </summary>
    public decimal? LinkedBaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closed End Primary Mortgage Loan Amount Copied from Linked Loan [LINK_4487]
    /// </summary>
    public decimal? LinkedClosedEndPrimaryMortgageLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closed End Subordinate Mortgage Loan Amount - Copied from Linked Loan [LINK_4488]
    /// </summary>
    public decimal? LinkedClosedEndSubordinateMortgageLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Lien Position - Copied from Linked Loan [LINK_4494]
    /// </summary>
    public StringEnumValue<LienPosition> LinkedHelocLienPosition { get => GetValue<StringEnumValue<LienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Heloc New Financing Not Linked Credit Limit - Copied from Linked Loan [LINK_4490]
    /// </summary>
    public decimal? LinkedHelocNewFinancingNotLinkedCreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc New Financing Not Linked Draw Amount - Copied from Linked Loan [LINK_4489]
    /// </summary>
    public decimal? LinkedHelocNewFinancingNotLinkedDrawAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Initial Advance - Copied from Linked Loan [LINK_1888]
    /// </summary>
    public decimal? LinkedInitialAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Construction Phase Disclosed Separately - Copied from Linked Loan [LINK_4084]
    /// </summary>
    public bool? LinkedIsConstructionPhaseDisclosedSeparately { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Linked File Contacts Lender Co Name [LINK_1264]
    /// </summary>
    public string? LinkedLenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Lien Position - Copied from Linked Loan [LINK_420]
    /// </summary>
    public StringEnumValue<LienType> LinkedLienPriorityType { get => GetValue<StringEnumValue<LienType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan # - Copied from Linked Loan [LINK_364]
    /// </summary>
    public string? LinkedLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Purpose - Copied from Linked Loan [LINK_19]
    /// </summary>
    public string? LinkedLoanPurposeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Linked ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [LINK_QM.X337]
    /// </summary>
    public decimal? LinkedMax5YrsPrincipleAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type - Copied from Linked Loan [LINK_1172]
    /// </summary>
    public StringEnumValue<LoanType> LinkedMortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Linked Expenses Proposed Mtg Pymt [LINK_228]
    /// </summary>
    public decimal? LinkedProposedFirstMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Linked Expenses Proposed Other Housing [LINK_234]
    /// </summary>
    public decimal? LinkedProposedOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Linked Expenses Proposed Other Pymt [LINK_229]
    /// </summary>
    public decimal? LinkedProposedOtherMortgagesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Linked Trans Details Interest Rate [LINK_3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LinkedRequestedInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Purpose [19]
    /// </summary>
    public StringEnumValue<LoanPurposeType> LoanPurposeType { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Purpose Other Description URLA [URLA.X72]
    /// </summary>
    public string? LoanPurposeTypeOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Display Loan Purpose Type for Property [URLA.X71]
    /// </summary>
    public StringEnumValue<LoanPurposeTypeURLA> LoanPurposeTypeUrla { get => GetValue<StringEnumValue<LoanPurposeTypeURLA>>(); set => SetValue(value); }

    /// <summary>
    /// Property Info # of Lot Acres [3543]
    /// </summary>
    public decimal? LotAcres { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Lot Identifier [2973]
    /// </summary>
    public string? LotIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Name of Recording Jurisdiction [3559]
    /// </summary>
    public string? NameRecordingJurisdiction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Is Non-Warrantable Project [3316]
    /// </summary>
    public bool? NonwarrantableProjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Number of Stories [3245]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_1)]
    public decimal? NumberOfStories { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Property Address Occupancy Display Field [URLA.X108]
    /// </summary>
    public string? OccupancyDisplayField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Type one time close  [URLA.X192]
    /// </summary>
    public bool? OneTimeClose { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Purpose other [9]
    /// </summary>
    public string? OtherLoanPurposeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Zip [15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded [3553]
    /// </summary>
    public string? PriorLoanRecordationBookNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage [3556]
    /// </summary>
    public decimal? PriorLoanRecordationCurrentPrincipalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// The date of the prior mortgage as recorded [4241]
    /// </summary>
    public DateTime? PriorLoanRecordationDated { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// The original loan number of the prior mortgage [4240]
    /// </summary>
    public string? PriorLoanRecordationOriginalLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info The Original Principal Amount of The Prior Mortgage as Recorded [3555]
    /// </summary>
    public decimal? PriorLoanRecordationOriginalPrincipalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded [3554]
    /// </summary>
    public string? PriorLoanRecordationPageNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ATR\QM Management Tool - Basic Info - Subject Property is in an Underserved Area [3850]
    /// </summary>
    public bool? ProdIsSpInUnderservedArea { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Yr Acquired [20]
    /// </summary>
    public string? PropertyAcquiredYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Existing Lien [10]
    /// </summary>
    public decimal? PropertyExistingLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Leasehold Expir Date [1034]
    /// </summary>
    public DateTime? PropertyLeaseholdExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mixed Use Property Indicator [URLA.X77]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"If you will occupy the property, will you set aside space within the property to operate your own business?\"}")]
    public bool? PropertyMixedUsageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Original Cost [21]
    /// </summary>
    public decimal? PropertyOriginalCostAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Estate Held [1066]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Other\"]")]
    public StringEnumValue<PropertyRightsType> PropertyRightsType { get => GetValue<StringEnumValue<PropertyRightsType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Use Type [190]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyUsageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Improvement Cost [29]
    /// </summary>
    public decimal? RefinanceImprovementCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Improve made/to be made [30]
    /// </summary>
    public StringEnumValue<PropertyImprovementsType> RefinanceImprovementsType { get => GetValue<StringEnumValue<PropertyImprovementsType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Yr Acquired [24]
    /// </summary>
    public string? RefinancePropertyAcquiredYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Existing Lien [26]
    /// </summary>
    public decimal? RefinancePropertyExistingLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Original Cost [25]
    /// </summary>
    public decimal? RefinancePropertyOriginalCostAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Refi Improvement Descr [205]
    /// </summary>
    public string? RefinanceProposedImprovementsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Is Rural Area [3314]
    /// </summary>
    public bool? RuralAreaIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Section Identifier [2975]
    /// </summary>
    public string? SectionIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Square [4792]
    /// </summary>
    public string? Square { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property State [14]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Street [11]
    /// </summary>
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Street 2 [3893]
    /// </summary>
    public string? StreetAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Yr Built [18]
    /// </summary>
    public string? StructureBuiltYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Continuous Money Loan (Texas Only) [3199]
    /// </summary>
    public bool? TexasContinuousMoneyLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Total [1074]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalConstructionValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Constrution Type two time close [URLA.X193]
    /// </summary>
    public bool? TwoTimeClose { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Type of Recording Jurisdiction [3558]
    /// </summary>
    public string? TypeRecordingJurisdiction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Unincorporated Area Name [3258]
    /// </summary>
    public string? UnincorporatedAreaName { get => GetValue<string?>(); set => SetValue(value); }
}