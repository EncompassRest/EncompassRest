using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Valuation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Valuation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Correspondent Appraisal Address County [VAL0003]
    /// </summary>
    public string? AppraisalAddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Appt Date [VAL0004]
    /// </summary>
    public DateTime? AppraisalApptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal County Name [VAL0005]
    /// </summary>
    public string? AppraisalCountyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Date [VAL0006]
    /// </summary>
    public DateTime? AppraisalFinalInspectionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Flag [VAL0007]
    /// </summary>
    public bool? AppraisalFinalInspectionFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Zone [VAL0008]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"None\",\"A1\",\"A2\",\"A3\",\"A4\",\"A5\",\"A6\",\"A7\",\"A8\",\"A9\",\"A10\",\"A11\",\"A12\",\"A13\",\"A14\",\"A15\",\"A16\",\"A17\",\"A18\",\"A19\",\"A20\",\"A21\",\"A22\",\"A23\",\"A24\",\"A25\",\"A26\",\"A27\",\"A28\",\"A29\",\"A30\",\"V1\",\"V2\",\"V3\",\"V4\",\"V5\",\"V6\",\"V7\",\"V8\",\"V9\",\"V10\",\"V11\",\"V12\",\"V13\",\"V14\",\"V15\",\"V16\",\"V17\",\"V18\",\"V19\",\"V20\",\"V21\",\"V22\",\"V23\",\"V24\",\"V25\",\"V26\",\"V27\",\"V28\",\"V29\",\"V30\"]")]
    public StringEnumValue<FloodZone> AppraisalFloodZone { get => GetValue<StringEnumValue<FloodZone>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 1 [VAL0034]
    /// </summary>
    public string? AppraisalLegalDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 2 [VAL0035]
    /// </summary>
    public string? AppraisalLegalDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VAL0009]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => GetValue<StringEnumValue<AppraisalPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Usage [VAL0063]
    /// </summary>
    public string? AppraisalUsage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Condition [VAL0010]
    /// </summary>
    public string? AppraisedCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Value [VAL0011]
    /// </summary>
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Name [VAL0012]
    /// </summary>
    public string? AppraiserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers License Number [VAL0014]
    /// </summary>
    public string? AppraisersLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 1 [VAL0016]
    /// </summary>
    public string? AppraisersPropertyAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 2 [VAL0017]
    /// </summary>
    public string? AppraisersPropertyAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers State License Number [VAL0015]
    /// </summary>
    public string? AppraisersStateLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Supervisors Name [VAL0013]
    /// </summary>
    public string? AppraiserSupervisorsName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Appraised Value [VAL0019]
    /// </summary>
    public decimal? AvmAppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Confidence Score [VAL0020]
    /// </summary>
    public string? AvmConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Date [VAL0022]
    /// </summary>
    public DateTime? AvmOrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Number [VAL0021]
    /// </summary>
    public string? AvmOrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Type [VAL0023]
    /// </summary>
    public string? AvmType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Building Status [VAL0024]
    /// </summary>
    public StringEnumValue<BuildingStatusType> BuildingStatus { get => GetValue<StringEnumValue<BuildingStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Census Tract [VAL0025]
    /// </summary>
    public string? CensusTrack { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Condo Project Status Type [VAL0068]
    /// </summary>
    public string? CondoProjectStatusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Date Of Sale [VAL0026]
    /// </summary>
    public DateTime? DateOfSale { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Energy Efficient Indicator [VAL0027]
    /// </summary>
    public bool? EnergyEfficientIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Estimated Value Of Repairs [VAL0028]
    /// </summary>
    public decimal? EstValueOfRepairs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Final Inspection Req Indicator [VAL0029]
    /// </summary>
    public bool? FinalInspectionReqIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Assessment Income [VAL0030]
    /// </summary>
    public decimal? HoaBudgetedAssessmentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Replacement Reserves [VAL0031]
    /// </summary>
    public decimal? HoaBudgetedReplacementReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Litigation Status [VAL0032]
    /// </summary>
    public string? HoaLitigationStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Valuation Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Improve Indicator [VAL0033]
    /// </summary>
    public bool? IsSubjectPropertyImproved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Living Area [VAL0036]
    /// </summary>
    public decimal? LivingArea { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit3 [VAL0037]
    /// </summary>
    public decimal? MonthlyRentAmountUnit3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit4 [VAL0038]
    /// </summary>
    public decimal? MonthlyRentAmountUnit4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel date [VAL0039]
    /// </summary>
    public DateTime? NfipPaneldate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel Number [VAL0040]
    /// </summary>
    public string? NfipPanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms [VAL0041]
    /// </summary>
    public int? NumberofBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 1 [VAL0042]
    /// </summary>
    public int? NumberofBedroomsUnit1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 2 [VAL0043]
    /// </summary>
    public int? NumberofBedroomsUnit2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 3 [VAL0001]
    /// </summary>
    public int? NumberOfBedroomUnit3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 4 [VAL0002]
    /// </summary>
    public int? NumberOfBedroomUnit4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Units [VAL0044]
    /// </summary>
    public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Order Type [VAL0069]
    /// </summary>
    public string? OrderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Panel Number [VAL0045]
    /// </summary>
    public string? PanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zip Code 4 digits [VAL0065]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Project Attachment Type [VAL0067]
    /// </summary>
    public string? ProjectAttachmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VAL0046]
    /// </summary>
    public string? PropertyAppraisalType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Unit Number [VAL0062]
    /// </summary>
    public string? PropertyAppraisalUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Attachment Type [VAL0047]
    /// </summary>
    public StringEnumValue<AttachmentType> PropertyAttachmentType { get => GetValue<StringEnumValue<AttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Usage Code [VAL0048]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Value [VAL0049]
    /// </summary>
    public decimal? PropertyValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Contract Sales Price [VAL0050]
    /// </summary>
    public decimal? PurchaseContractSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 1 [VAL0051]
    /// </summary>
    public decimal? RentAmountUnit1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 2 [VAL0052]
    /// </summary>
    public decimal? RentAmountUnit2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Site Value [VAL0053]
    /// </summary>
    public decimal? SiteValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Standard Deviation [VAL0054]
    /// </summary>
    public string? StandardDeviation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Gross Rent [VAL0056]
    /// </summary>
    public decimal? StatedGrossRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Condition [VAL0057]
    /// </summary>
    public string? StatedPropertyCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Type [VAL0058]
    /// </summary>
    public StringEnumValue<PropertyType> StatedPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Address City [VAL0059]
    /// </summary>
    public string? SubjectAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State [VAL0055]
    /// </summary>
    public string? SubjectPropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Unit Number [VAL0060]
    /// </summary>
    public string? SubjectPropertyUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Supervisory Appraisal License # [VAL0061]
    /// </summary>
    public string? SupervisoryAppraisalLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Valuation Method [VAL0018]
    /// </summary>
    public string? ValuationMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Year Built [VAL0064]
    /// </summary>
    public string? YearBuilt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zoning Compliance [VAL0066]
    /// </summary>
    public string? ZoningCompliance { get => GetValue<string?>(); set => SetValue(value); }
}