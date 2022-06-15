using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Valuation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Valuation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Correspondent Appraisal Address County [VALNN03]
    /// </summary>
    public string? AppraisalAddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Appt Date [VALNN04]
    /// </summary>
    public DateTime? AppraisalApptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal County Name [VALNN05]
    /// </summary>
    public string? AppraisalCountyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Date [VALNN06]
    /// </summary>
    public DateTime? AppraisalFinalInspectionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Flag [VALNN07]
    /// </summary>
    public bool? AppraisalFinalInspectionFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Zone [VALNN08]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"None\",\"A1\",\"A2\",\"A3\",\"A4\",\"A5\",\"A6\",\"A7\",\"A8\",\"A9\",\"A10\",\"A11\",\"A12\",\"A13\",\"A14\",\"A15\",\"A16\",\"A17\",\"A18\",\"A19\",\"A20\",\"A21\",\"A22\",\"A23\",\"A24\",\"A25\",\"A26\",\"A27\",\"A28\",\"A29\",\"A30\",\"V1\",\"V2\",\"V3\",\"V4\",\"V5\",\"V6\",\"V7\",\"V8\",\"V9\",\"V10\",\"V11\",\"V12\",\"V13\",\"V14\",\"V15\",\"V16\",\"V17\",\"V18\",\"V19\",\"V20\",\"V21\",\"V22\",\"V23\",\"V24\",\"V25\",\"V26\",\"V27\",\"V28\",\"V29\",\"V30\"]")]
    public StringEnumValue<FloodZone> AppraisalFloodZone { get => GetValue<StringEnumValue<FloodZone>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 1 [VALNN34]
    /// </summary>
    public string? AppraisalLegalDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 2 [VALNN35]
    /// </summary>
    public string? AppraisalLegalDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VALNN09]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => GetValue<StringEnumValue<AppraisalPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Usage [VALNN63]
    /// </summary>
    public string? AppraisalUsage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Condition [VALNN10]
    /// </summary>
    public string? AppraisedCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Value [VALNN11]
    /// </summary>
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Name [VALNN12]
    /// </summary>
    public string? AppraiserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers License Number [VALNN14]
    /// </summary>
    public string? AppraisersLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 1 [VALNN16]
    /// </summary>
    public string? AppraisersPropertyAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 2 [VALNN17]
    /// </summary>
    public string? AppraisersPropertyAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers State License Number [VALNN15]
    /// </summary>
    public string? AppraisersStateLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Supervisors Name [VALNN13]
    /// </summary>
    public string? AppraiserSupervisorsName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Appraised Value [VALNN19]
    /// </summary>
    public decimal? AvmAppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Confidence Score [VALNN20]
    /// </summary>
    public string? AvmConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Date [VALNN22]
    /// </summary>
    public DateTime? AvmOrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Number [VALNN21]
    /// </summary>
    public string? AvmOrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Type [VALNN23]
    /// </summary>
    public string? AvmType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Building Status [VALNN24]
    /// </summary>
    public StringEnumValue<BuildingStatusType> BuildingStatus { get => GetValue<StringEnumValue<BuildingStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Census Tract [VALNN25]
    /// </summary>
    public string? CensusTrack { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Condo Project Status Type [VALNN68]
    /// </summary>
    public string? CondoProjectStatusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Date Of Sale [VALNN26]
    /// </summary>
    public DateTime? DateOfSale { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Energy Efficient Indicator [VALNN27]
    /// </summary>
    public bool? EnergyEfficientIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Valuation EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Estimated Value Of Repairs [VALNN28]
    /// </summary>
    public decimal? EstValueOfRepairs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Final Inspection Req Indicator [VALNN29]
    /// </summary>
    public bool? FinalInspectionReqIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Assessment Income [VALNN30]
    /// </summary>
    public decimal? HoaBudgetedAssessmentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Replacement Reserves [VALNN31]
    /// </summary>
    public decimal? HoaBudgetedReplacementReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Litigation Status [VALNN32]
    /// </summary>
    public string? HoaLitigationStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Valuation Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Improve Indicator [VALNN33]
    /// </summary>
    public bool? IsSubjectPropertyImproved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Living Area [VALNN36]
    /// </summary>
    public decimal? LivingArea { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit3 [VALNN37]
    /// </summary>
    public decimal? MonthlyRentAmountUnit3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit4 [VALNN38]
    /// </summary>
    public decimal? MonthlyRentAmountUnit4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel date [VALNN39]
    /// </summary>
    public DateTime? NfipPaneldate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel Number [VALNN40]
    /// </summary>
    public string? NfipPanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms [VALNN41]
    /// </summary>
    public int? NumberofBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 1 [VALNN42]
    /// </summary>
    public int? NumberofBedroomsUnit1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 2 [VALNN43]
    /// </summary>
    public int? NumberofBedroomsUnit2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 3 [VALNN01]
    /// </summary>
    public int? NumberOfBedroomUnit3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 4 [VALNN02]
    /// </summary>
    public int? NumberOfBedroomUnit4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Units [VALNN44]
    /// </summary>
    public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Order Type [VALNN69]
    /// </summary>
    public string? OrderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Panel Number [VALNN45]
    /// </summary>
    public string? PanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zip Code 4 digits [VALNN65]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Project Attachment Type [VALNN67]
    /// </summary>
    public string? ProjectAttachmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VALNN46]
    /// </summary>
    public string? PropertyAppraisalType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Unit Number [VALNN62]
    /// </summary>
    public string? PropertyAppraisalUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Attachment Type [VALNN47]
    /// </summary>
    public StringEnumValue<AttachmentType> PropertyAttachmentType { get => GetValue<StringEnumValue<AttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Usage Code [VALNN48]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Value [VALNN49]
    /// </summary>
    public decimal? PropertyValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Contract Sales Price [VALNN50]
    /// </summary>
    public decimal? PurchaseContractSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 1 [VALNN51]
    /// </summary>
    public decimal? RentAmountUnit1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 2 [VALNN52]
    /// </summary>
    public decimal? RentAmountUnit2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Site Value [VALNN53]
    /// </summary>
    public decimal? SiteValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Standard Deviation [VALNN54]
    /// </summary>
    public string? StandardDeviation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Gross Rent [VALNN56]
    /// </summary>
    public decimal? StatedGrossRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Condition [VALNN57]
    /// </summary>
    public string? StatedPropertyCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Type [VALNN58]
    /// </summary>
    public StringEnumValue<PropertyType> StatedPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Address City [VALNN59]
    /// </summary>
    public string? SubjectAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State [VALNN55]
    /// </summary>
    public StringEnumValue<State> SubjectPropertyState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Unit Number [VALNN60]
    /// </summary>
    public string? SubjectPropertyUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Supervisory Appraisal License # [VALNN61]
    /// </summary>
    public string? SupervisoryAppraisalLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Valuation Method [VALNN18]
    /// </summary>
    public string? ValuationMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Year Built [VALNN64]
    /// </summary>
    public string? YearBuilt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zoning Compliance [VALNN66]
    /// </summary>
    public string? ZoningCompliance { get => GetValue<string?>(); set => SetValue(value); }
}