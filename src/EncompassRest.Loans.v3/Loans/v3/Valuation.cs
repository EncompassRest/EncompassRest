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
    private DirtyValue<string?>? _appraisalAddressCounty;
    private DirtyValue<DateTime?>? _appraisalApptDate;
    private DirtyValue<string?>? _appraisalCountyName;
    private DirtyValue<DateTime?>? _appraisalFinalInspectionDate;
    private DirtyValue<bool?>? _appraisalFinalInspectionFlag;
    private DirtyValue<StringEnumValue<FloodZone>>? _appraisalFloodZone;
    private DirtyValue<string?>? _appraisalLegalDescription1;
    private DirtyValue<string?>? _appraisalLegalDescription2;
    private DirtyValue<StringEnumValue<AppraisalPropertyType>>? _appraisalPropertyType;
    private DirtyValue<string?>? _appraisalUsage;
    private DirtyValue<string?>? _appraisedCondition;
    private DirtyValue<int?>? _appraisedValue;
    private DirtyValue<string?>? _appraiserName;
    private DirtyValue<string?>? _appraisersLicenseNumber;
    private DirtyValue<string?>? _appraisersPropertyAddress1;
    private DirtyValue<string?>? _appraisersPropertyAddress2;
    private DirtyValue<string?>? _appraisersStateLicenseNumber;
    private DirtyValue<string?>? _appraiserSupervisorsName;
    private DirtyValue<decimal?>? _avmAppraisedValue;
    private DirtyValue<string?>? _avmConfidenceScore;
    private DirtyValue<DateTime?>? _avmOrderDate;
    private DirtyValue<string?>? _avmOrderNumber;
    private DirtyValue<string?>? _avmType;
    private DirtyValue<StringEnumValue<BuildingStatusType>>? _buildingStatus;
    private DirtyValue<string?>? _censusTrack;
    private DirtyValue<string?>? _condoProjectStatusType;
    private DirtyValue<DateTime?>? _dateOfSale;
    private DirtyValue<bool?>? _energyEfficientIndicator;
    private DirtyValue<decimal?>? _estValueOfRepairs;
    private DirtyValue<bool?>? _finalInspectionReqIndicator;
    private DirtyValue<decimal?>? _hoaBudgetedAssessmentIncome;
    private DirtyValue<decimal?>? _hoaBudgetedReplacementReserves;
    private DirtyValue<string?>? _hoaLitigationStatus;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isSubjectPropertyImproved;
    private DirtyValue<decimal?>? _livingArea;
    private DirtyValue<decimal?>? _monthlyRentAmountUnit3;
    private DirtyValue<decimal?>? _monthlyRentAmountUnit4;
    private DirtyValue<DateTime?>? _nfipPaneldate;
    private DirtyValue<string?>? _nfipPanelNumber;
    private DirtyValue<int?>? _numberofBedrooms;
    private DirtyValue<int?>? _numberofBedroomsUnit1;
    private DirtyValue<int?>? _numberofBedroomsUnit2;
    private DirtyValue<int?>? _numberOfBedroomUnit3;
    private DirtyValue<int?>? _numberOfBedroomUnit4;
    private DirtyValue<int?>? _numberOfUnits;
    private DirtyValue<string?>? _orderType;
    private DirtyValue<string?>? _panelNumber;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<string?>? _projectAttachmentType;
    private DirtyValue<string?>? _propertyAppraisalType;
    private DirtyValue<string?>? _propertyAppraisalUnitNumber;
    private DirtyValue<StringEnumValue<AttachmentType>>? _propertyAttachmentType;
    private DirtyValue<StringEnumValue<PropertyUsageType>>? _propertyUsageCode;
    private DirtyValue<decimal?>? _propertyValue;
    private DirtyValue<decimal?>? _purchaseContractSalesPrice;
    private DirtyValue<decimal?>? _rentAmountUnit1;
    private DirtyValue<decimal?>? _rentAmountUnit2;
    private DirtyValue<decimal?>? _siteValue;
    private DirtyValue<string?>? _standardDeviation;
    private DirtyValue<decimal?>? _statedGrossRent;
    private DirtyValue<string?>? _statedPropertyCondition;
    private DirtyValue<StringEnumValue<PropertyType>>? _statedPropertyType;
    private DirtyValue<string?>? _subjectAddressCity;
    private DirtyValue<string?>? _subjectPropertyState;
    private DirtyValue<string?>? _subjectPropertyUnitNumber;
    private DirtyValue<string?>? _supervisoryAppraisalLicenseNumber;
    private DirtyValue<string?>? _valuationMethod;
    private DirtyValue<string?>? _yearBuilt;
    private DirtyValue<string?>? _zoningCompliance;

    /// <summary>
    /// Correspondent Appraisal Address County [VAL0003]
    /// </summary>
    public string? AppraisalAddressCounty { get => _appraisalAddressCounty; set => SetField(ref _appraisalAddressCounty, value); }

    /// <summary>
    /// Correspondent Appraisal Appt Date [VAL0004]
    /// </summary>
    public DateTime? AppraisalApptDate { get => _appraisalApptDate; set => SetField(ref _appraisalApptDate, value); }

    /// <summary>
    /// Correspondent Appraisal County Name [VAL0005]
    /// </summary>
    public string? AppraisalCountyName { get => _appraisalCountyName; set => SetField(ref _appraisalCountyName, value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Date [VAL0006]
    /// </summary>
    public DateTime? AppraisalFinalInspectionDate { get => _appraisalFinalInspectionDate; set => SetField(ref _appraisalFinalInspectionDate, value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Flag [VAL0007]
    /// </summary>
    public bool? AppraisalFinalInspectionFlag { get => _appraisalFinalInspectionFlag; set => SetField(ref _appraisalFinalInspectionFlag, value); }

    /// <summary>
    /// Correspondent Flood Zone [VAL0008]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"None\"]")]
    public StringEnumValue<FloodZone> AppraisalFloodZone { get => _appraisalFloodZone; set => SetField(ref _appraisalFloodZone, value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 1 [VAL0034]
    /// </summary>
    public string? AppraisalLegalDescription1 { get => _appraisalLegalDescription1; set => SetField(ref _appraisalLegalDescription1, value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 2 [VAL0035]
    /// </summary>
    public string? AppraisalLegalDescription2 { get => _appraisalLegalDescription2; set => SetField(ref _appraisalLegalDescription2, value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VAL0009]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => _appraisalPropertyType; set => SetField(ref _appraisalPropertyType, value); }

    /// <summary>
    /// Correspondent Property Appraisal Usage [VAL0063]
    /// </summary>
    public string? AppraisalUsage { get => _appraisalUsage; set => SetField(ref _appraisalUsage, value); }

    /// <summary>
    /// Correspondent Appraised Condition [VAL0010]
    /// </summary>
    public string? AppraisedCondition { get => _appraisedCondition; set => SetField(ref _appraisedCondition, value); }

    /// <summary>
    /// Correspondent Appraised Value [VAL0011]
    /// </summary>
    public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

    /// <summary>
    /// Correspondent Appraiser Name [VAL0012]
    /// </summary>
    public string? AppraiserName { get => _appraiserName; set => SetField(ref _appraiserName, value); }

    /// <summary>
    /// Correspondent Appraisers License Number [VAL0014]
    /// </summary>
    public string? AppraisersLicenseNumber { get => _appraisersLicenseNumber; set => SetField(ref _appraisersLicenseNumber, value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 1 [VAL0016]
    /// </summary>
    public string? AppraisersPropertyAddress1 { get => _appraisersPropertyAddress1; set => SetField(ref _appraisersPropertyAddress1, value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 2 [VAL0017]
    /// </summary>
    public string? AppraisersPropertyAddress2 { get => _appraisersPropertyAddress2; set => SetField(ref _appraisersPropertyAddress2, value); }

    /// <summary>
    /// Correspondent Appraisers State License Number [VAL0015]
    /// </summary>
    public string? AppraisersStateLicenseNumber { get => _appraisersStateLicenseNumber; set => SetField(ref _appraisersStateLicenseNumber, value); }

    /// <summary>
    /// Correspondent Appraiser Supervisors Name [VAL0013]
    /// </summary>
    public string? AppraiserSupervisorsName { get => _appraiserSupervisorsName; set => SetField(ref _appraiserSupervisorsName, value); }

    /// <summary>
    /// Correspondent AVM Appraised Value [VAL0019]
    /// </summary>
    public decimal? AvmAppraisedValue { get => _avmAppraisedValue; set => SetField(ref _avmAppraisedValue, value); }

    /// <summary>
    /// Correspondent AVM Confidence Score [VAL0020]
    /// </summary>
    public string? AvmConfidenceScore { get => _avmConfidenceScore; set => SetField(ref _avmConfidenceScore, value); }

    /// <summary>
    /// Correspondent AVM Order Date [VAL0022]
    /// </summary>
    public DateTime? AvmOrderDate { get => _avmOrderDate; set => SetField(ref _avmOrderDate, value); }

    /// <summary>
    /// Correspondent AVM Order Number [VAL0021]
    /// </summary>
    public string? AvmOrderNumber { get => _avmOrderNumber; set => SetField(ref _avmOrderNumber, value); }

    /// <summary>
    /// Correspondent AVM Type [VAL0023]
    /// </summary>
    public string? AvmType { get => _avmType; set => SetField(ref _avmType, value); }

    /// <summary>
    /// Correspondent Building Status [VAL0024]
    /// </summary>
    public StringEnumValue<BuildingStatusType> BuildingStatus { get => _buildingStatus; set => SetField(ref _buildingStatus, value); }

    /// <summary>
    /// Correspondent Census Tract [VAL0025]
    /// </summary>
    public string? CensusTrack { get => _censusTrack; set => SetField(ref _censusTrack, value); }

    /// <summary>
    /// Correspondent Condo Project Status Type [VAL0068]
    /// </summary>
    public string? CondoProjectStatusType { get => _condoProjectStatusType; set => SetField(ref _condoProjectStatusType, value); }

    /// <summary>
    /// Correspondent Date Of Sale [VAL0026]
    /// </summary>
    public DateTime? DateOfSale { get => _dateOfSale; set => SetField(ref _dateOfSale, value); }

    /// <summary>
    /// Correspondent Energy Efficient Indicator [VAL0027]
    /// </summary>
    public bool? EnergyEfficientIndicator { get => _energyEfficientIndicator; set => SetField(ref _energyEfficientIndicator, value); }

    /// <summary>
    /// Correspondent Estimated Value Of Repairs [VAL0028]
    /// </summary>
    public decimal? EstValueOfRepairs { get => _estValueOfRepairs; set => SetField(ref _estValueOfRepairs, value); }

    /// <summary>
    /// Correspondent Final Inspection Req Indicator [VAL0029]
    /// </summary>
    public bool? FinalInspectionReqIndicator { get => _finalInspectionReqIndicator; set => SetField(ref _finalInspectionReqIndicator, value); }

    /// <summary>
    /// Correspondent HOA Budgeted Assessment Income [VAL0030]
    /// </summary>
    public decimal? HoaBudgetedAssessmentIncome { get => _hoaBudgetedAssessmentIncome; set => SetField(ref _hoaBudgetedAssessmentIncome, value); }

    /// <summary>
    /// Correspondent HOA Budgeted Replacement Reserves [VAL0031]
    /// </summary>
    public decimal? HoaBudgetedReplacementReserves { get => _hoaBudgetedReplacementReserves; set => SetField(ref _hoaBudgetedReplacementReserves, value); }

    /// <summary>
    /// Correspondent HOA Litigation Status [VAL0032]
    /// </summary>
    public string? HoaLitigationStatus { get => _hoaLitigationStatus; set => SetField(ref _hoaLitigationStatus, value); }

    /// <summary>
    /// ValuationContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Correspondent Subject Property Improve Indicator [VAL0033]
    /// </summary>
    public bool? IsSubjectPropertyImproved { get => _isSubjectPropertyImproved; set => SetField(ref _isSubjectPropertyImproved, value); }

    /// <summary>
    /// Correspondent Living Area [VAL0036]
    /// </summary>
    public decimal? LivingArea { get => _livingArea; set => SetField(ref _livingArea, value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit3 [VAL0037]
    /// </summary>
    public decimal? MonthlyRentAmountUnit3 { get => _monthlyRentAmountUnit3; set => SetField(ref _monthlyRentAmountUnit3, value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit4 [VAL0038]
    /// </summary>
    public decimal? MonthlyRentAmountUnit4 { get => _monthlyRentAmountUnit4; set => SetField(ref _monthlyRentAmountUnit4, value); }

    /// <summary>
    /// Correspondent NFIP Panel date [VAL0039]
    /// </summary>
    public DateTime? NfipPaneldate { get => _nfipPaneldate; set => SetField(ref _nfipPaneldate, value); }

    /// <summary>
    /// Correspondent NFIP Panel Number [VAL0040]
    /// </summary>
    public string? NfipPanelNumber { get => _nfipPanelNumber; set => SetField(ref _nfipPanelNumber, value); }

    /// <summary>
    /// Correspondent Number of Bedrooms [VAL0041]
    /// </summary>
    public int? NumberofBedrooms { get => _numberofBedrooms; set => SetField(ref _numberofBedrooms, value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 1 [VAL0042]
    /// </summary>
    public int? NumberofBedroomsUnit1 { get => _numberofBedroomsUnit1; set => SetField(ref _numberofBedroomsUnit1, value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 2 [VAL0043]
    /// </summary>
    public int? NumberofBedroomsUnit2 { get => _numberofBedroomsUnit2; set => SetField(ref _numberofBedroomsUnit2, value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 3 [VAL0001]
    /// </summary>
    public int? NumberOfBedroomUnit3 { get => _numberOfBedroomUnit3; set => SetField(ref _numberOfBedroomUnit3, value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 4 [VAL0002]
    /// </summary>
    public int? NumberOfBedroomUnit4 { get => _numberOfBedroomUnit4; set => SetField(ref _numberOfBedroomUnit4, value); }

    /// <summary>
    /// Correspondent Number of Units [VAL0044]
    /// </summary>
    public int? NumberOfUnits { get => _numberOfUnits; set => SetField(ref _numberOfUnits, value); }

    /// <summary>
    /// Correspondent Order Type [VAL0069]
    /// </summary>
    public string? OrderType { get => _orderType; set => SetField(ref _orderType, value); }

    /// <summary>
    /// Correspondent Panel Number [VAL0045]
    /// </summary>
    public string? PanelNumber { get => _panelNumber; set => SetField(ref _panelNumber, value); }

    /// <summary>
    /// Correspondent Zip Code 4 digits [VAL0065]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// Correspondent Project Attachment Type [VAL0067]
    /// </summary>
    public string? ProjectAttachmentType { get => _projectAttachmentType; set => SetField(ref _projectAttachmentType, value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [VAL0046]
    /// </summary>
    public string? PropertyAppraisalType { get => _propertyAppraisalType; set => SetField(ref _propertyAppraisalType, value); }

    /// <summary>
    /// Correspondent Property Appraisal Unit Number [VAL0062]
    /// </summary>
    public string? PropertyAppraisalUnitNumber { get => _propertyAppraisalUnitNumber; set => SetField(ref _propertyAppraisalUnitNumber, value); }

    /// <summary>
    /// Correspondent Property Attachment Type [VAL0047]
    /// </summary>
    public StringEnumValue<AttachmentType> PropertyAttachmentType { get => _propertyAttachmentType; set => SetField(ref _propertyAttachmentType, value); }

    /// <summary>
    /// Correspondent Property Usage Code [VAL0048]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => _propertyUsageCode; set => SetField(ref _propertyUsageCode, value); }

    /// <summary>
    /// Correspondent Property Value [VAL0049]
    /// </summary>
    public decimal? PropertyValue { get => _propertyValue; set => SetField(ref _propertyValue, value); }

    /// <summary>
    /// Correspondent Purchase Contract Sales Price [VAL0050]
    /// </summary>
    public decimal? PurchaseContractSalesPrice { get => _purchaseContractSalesPrice; set => SetField(ref _purchaseContractSalesPrice, value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 1 [VAL0051]
    /// </summary>
    public decimal? RentAmountUnit1 { get => _rentAmountUnit1; set => SetField(ref _rentAmountUnit1, value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 2 [VAL0052]
    /// </summary>
    public decimal? RentAmountUnit2 { get => _rentAmountUnit2; set => SetField(ref _rentAmountUnit2, value); }

    /// <summary>
    /// Correspondent Site Value [VAL0053]
    /// </summary>
    public decimal? SiteValue { get => _siteValue; set => SetField(ref _siteValue, value); }

    /// <summary>
    /// Correspondent Standard Deviation [VAL0054]
    /// </summary>
    public string? StandardDeviation { get => _standardDeviation; set => SetField(ref _standardDeviation, value); }

    /// <summary>
    /// Correspondent Stated Gross Rent [VAL0056]
    /// </summary>
    public decimal? StatedGrossRent { get => _statedGrossRent; set => SetField(ref _statedGrossRent, value); }

    /// <summary>
    /// Correspondent Stated Property Condition [VAL0057]
    /// </summary>
    public string? StatedPropertyCondition { get => _statedPropertyCondition; set => SetField(ref _statedPropertyCondition, value); }

    /// <summary>
    /// Correspondent Stated Property Type [VAL0058]
    /// </summary>
    public StringEnumValue<PropertyType> StatedPropertyType { get => _statedPropertyType; set => SetField(ref _statedPropertyType, value); }

    /// <summary>
    /// Correspondent Subject Address City [VAL0059]
    /// </summary>
    public string? SubjectAddressCity { get => _subjectAddressCity; set => SetField(ref _subjectAddressCity, value); }

    /// <summary>
    /// Correspondent State [VAL0055]
    /// </summary>
    public string? SubjectPropertyState { get => _subjectPropertyState; set => SetField(ref _subjectPropertyState, value); }

    /// <summary>
    /// Correspondent Subject Property Unit Number [VAL0060]
    /// </summary>
    public string? SubjectPropertyUnitNumber { get => _subjectPropertyUnitNumber; set => SetField(ref _subjectPropertyUnitNumber, value); }

    /// <summary>
    /// Correspondent Supervisory Appraisal License # [VAL0061]
    /// </summary>
    public string? SupervisoryAppraisalLicenseNumber { get => _supervisoryAppraisalLicenseNumber; set => SetField(ref _supervisoryAppraisalLicenseNumber, value); }

    /// <summary>
    /// Correspondent Appraisers Valuation Method [VAL0018]
    /// </summary>
    public string? ValuationMethod { get => _valuationMethod; set => SetField(ref _valuationMethod, value); }

    /// <summary>
    /// Correspondent Year Built [VAL0064]
    /// </summary>
    public string? YearBuilt { get => _yearBuilt; set => SetField(ref _yearBuilt, value); }

    /// <summary>
    /// Correspondent Zoning Compliance [VAL0066]
    /// </summary>
    public string? ZoningCompliance { get => _zoningCompliance; set => SetField(ref _zoningCompliance, value); }
}