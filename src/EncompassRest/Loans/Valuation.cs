using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
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
        private DirtyValue<bool?>? _entityDeleted;
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
        private DirtyValue<StringEnumValue<State>>? _subjectPropertyState;
        private DirtyValue<string?>? _subjectPropertyUnitNumber;
        private DirtyValue<string?>? _supervisoryAppraisalLicenseNumber;
        private DirtyValue<string?>? _valuationMethod;
        private DirtyValue<string?>? _yearBuilt;
        private DirtyValue<string?>? _zoningCompliance;

        /// <summary>
        /// Correspondent Appraisal Address County [VALNN03]
        /// </summary>
        public string? AppraisalAddressCounty { get => _appraisalAddressCounty; set => SetField(ref _appraisalAddressCounty, value); }

        /// <summary>
        /// Correspondent Appraisal Appt Date [VALNN04]
        /// </summary>
        public DateTime? AppraisalApptDate { get => _appraisalApptDate; set => SetField(ref _appraisalApptDate, value); }

        /// <summary>
        /// Correspondent Appraisal County Name [VALNN05]
        /// </summary>
        public string? AppraisalCountyName { get => _appraisalCountyName; set => SetField(ref _appraisalCountyName, value); }

        /// <summary>
        /// Correspondent Appraisal Final Inspection Date [VALNN06]
        /// </summary>
        public DateTime? AppraisalFinalInspectionDate { get => _appraisalFinalInspectionDate; set => SetField(ref _appraisalFinalInspectionDate, value); }

        /// <summary>
        /// Correspondent Appraisal Final Inspection Flag [VALNN07]
        /// </summary>
        public bool? AppraisalFinalInspectionFlag { get => _appraisalFinalInspectionFlag; set => SetField(ref _appraisalFinalInspectionFlag, value); }

        /// <summary>
        /// Correspondent Flood Zone [VALNN08]
        /// </summary>
        public StringEnumValue<FloodZone> AppraisalFloodZone { get => _appraisalFloodZone; set => SetField(ref _appraisalFloodZone, value); }

        /// <summary>
        /// Correspondent Appraisal Legal Description 1 [VALNN34]
        /// </summary>
        public string? AppraisalLegalDescription1 { get => _appraisalLegalDescription1; set => SetField(ref _appraisalLegalDescription1, value); }

        /// <summary>
        /// Correspondent Appraisal Legal Description 2 [VALNN35]
        /// </summary>
        public string? AppraisalLegalDescription2 { get => _appraisalLegalDescription2; set => SetField(ref _appraisalLegalDescription2, value); }

        /// <summary>
        /// Correspondent Property Appraisal Type [VALNN09]
        /// </summary>
        public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => _appraisalPropertyType; set => SetField(ref _appraisalPropertyType, value); }

        /// <summary>
        /// Correspondent Property Appraisal Usage [VALNN63]
        /// </summary>
        public string? AppraisalUsage { get => _appraisalUsage; set => SetField(ref _appraisalUsage, value); }

        /// <summary>
        /// Correspondent Appraised Condition [VALNN10]
        /// </summary>
        public string? AppraisedCondition { get => _appraisedCondition; set => SetField(ref _appraisedCondition, value); }

        /// <summary>
        /// Correspondent Appraised Value [VALNN11]
        /// </summary>
        public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

        /// <summary>
        /// Correspondent Appraiser Name [VALNN12]
        /// </summary>
        public string? AppraiserName { get => _appraiserName; set => SetField(ref _appraiserName, value); }

        /// <summary>
        /// Correspondent Appraisers License Number [VALNN14]
        /// </summary>
        public string? AppraisersLicenseNumber { get => _appraisersLicenseNumber; set => SetField(ref _appraisersLicenseNumber, value); }

        /// <summary>
        /// Correspondent Appraisers Property Address 1 [VALNN16]
        /// </summary>
        public string? AppraisersPropertyAddress1 { get => _appraisersPropertyAddress1; set => SetField(ref _appraisersPropertyAddress1, value); }

        /// <summary>
        /// Correspondent Appraisers Property Address 2 [VALNN17]
        /// </summary>
        public string? AppraisersPropertyAddress2 { get => _appraisersPropertyAddress2; set => SetField(ref _appraisersPropertyAddress2, value); }

        /// <summary>
        /// Correspondent Appraisers State License Number [VALNN15]
        /// </summary>
        public string? AppraisersStateLicenseNumber { get => _appraisersStateLicenseNumber; set => SetField(ref _appraisersStateLicenseNumber, value); }

        /// <summary>
        /// Correspondent Appraiser Supervisors Name [VALNN13]
        /// </summary>
        public string? AppraiserSupervisorsName { get => _appraiserSupervisorsName; set => SetField(ref _appraiserSupervisorsName, value); }

        /// <summary>
        /// Correspondent AVM Appraised Value [VALNN19]
        /// </summary>
        public decimal? AvmAppraisedValue { get => _avmAppraisedValue; set => SetField(ref _avmAppraisedValue, value); }

        /// <summary>
        /// Correspondent AVM Confidence Score [VALNN20]
        /// </summary>
        public string? AvmConfidenceScore { get => _avmConfidenceScore; set => SetField(ref _avmConfidenceScore, value); }

        /// <summary>
        /// Correspondent AVM Order Date [VALNN22]
        /// </summary>
        public DateTime? AvmOrderDate { get => _avmOrderDate; set => SetField(ref _avmOrderDate, value); }

        /// <summary>
        /// Correspondent AVM Order Number [VALNN21]
        /// </summary>
        public string? AvmOrderNumber { get => _avmOrderNumber; set => SetField(ref _avmOrderNumber, value); }

        /// <summary>
        /// Correspondent AVM Type [VALNN23]
        /// </summary>
        public string? AvmType { get => _avmType; set => SetField(ref _avmType, value); }

        /// <summary>
        /// Correspondent Building Status [VALNN24]
        /// </summary>
        public StringEnumValue<BuildingStatusType> BuildingStatus { get => _buildingStatus; set => SetField(ref _buildingStatus, value); }

        /// <summary>
        /// Correspondent Census Tract [VALNN25]
        /// </summary>
        public string? CensusTrack { get => _censusTrack; set => SetField(ref _censusTrack, value); }

        /// <summary>
        /// Correspondent Condo Project Status Type [VALNN68]
        /// </summary>
        public string? CondoProjectStatusType { get => _condoProjectStatusType; set => SetField(ref _condoProjectStatusType, value); }

        /// <summary>
        /// Correspondent Date Of Sale [VALNN26]
        /// </summary>
        public DateTime? DateOfSale { get => _dateOfSale; set => SetField(ref _dateOfSale, value); }

        /// <summary>
        /// Correspondent Energy Efficient Indicator [VALNN27]
        /// </summary>
        public bool? EnergyEfficientIndicator { get => _energyEfficientIndicator; set => SetField(ref _energyEfficientIndicator, value); }

        /// <summary>
        /// Valuation EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Correspondent Estimated Value Of Repairs [VALNN28]
        /// </summary>
        public decimal? EstValueOfRepairs { get => _estValueOfRepairs; set => SetField(ref _estValueOfRepairs, value); }

        /// <summary>
        /// Correspondent Final Inspection Req Indicator [VALNN29]
        /// </summary>
        public bool? FinalInspectionReqIndicator { get => _finalInspectionReqIndicator; set => SetField(ref _finalInspectionReqIndicator, value); }

        /// <summary>
        /// Correspondent HOA Budgeted Assessment Income [VALNN30]
        /// </summary>
        public decimal? HoaBudgetedAssessmentIncome { get => _hoaBudgetedAssessmentIncome; set => SetField(ref _hoaBudgetedAssessmentIncome, value); }

        /// <summary>
        /// Correspondent HOA Budgeted Replacement Reserves [VALNN31]
        /// </summary>
        public decimal? HoaBudgetedReplacementReserves { get => _hoaBudgetedReplacementReserves; set => SetField(ref _hoaBudgetedReplacementReserves, value); }

        /// <summary>
        /// Correspondent HOA Litigation Status [VALNN32]
        /// </summary>
        public string? HoaLitigationStatus { get => _hoaLitigationStatus; set => SetField(ref _hoaLitigationStatus, value); }

        /// <summary>
        /// Valuation Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Correspondent Subject Property Improve Indicator [VALNN33]
        /// </summary>
        public bool? IsSubjectPropertyImproved { get => _isSubjectPropertyImproved; set => SetField(ref _isSubjectPropertyImproved, value); }

        /// <summary>
        /// Correspondent Living Area [VALNN36]
        /// </summary>
        public decimal? LivingArea { get => _livingArea; set => SetField(ref _livingArea, value); }

        /// <summary>
        /// Correspondent Monthly Rent Amount Unit3 [VALNN37]
        /// </summary>
        public decimal? MonthlyRentAmountUnit3 { get => _monthlyRentAmountUnit3; set => SetField(ref _monthlyRentAmountUnit3, value); }

        /// <summary>
        /// Correspondent Monthly Rent Amount Unit4 [VALNN38]
        /// </summary>
        public decimal? MonthlyRentAmountUnit4 { get => _monthlyRentAmountUnit4; set => SetField(ref _monthlyRentAmountUnit4, value); }

        /// <summary>
        /// Correspondent NFIP Panel date [VALNN39]
        /// </summary>
        public DateTime? NfipPaneldate { get => _nfipPaneldate; set => SetField(ref _nfipPaneldate, value); }

        /// <summary>
        /// Correspondent NFIP Panel Number [VALNN40]
        /// </summary>
        public string? NfipPanelNumber { get => _nfipPanelNumber; set => SetField(ref _nfipPanelNumber, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms [VALNN41]
        /// </summary>
        public int? NumberofBedrooms { get => _numberofBedrooms; set => SetField(ref _numberofBedrooms, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms Unit 1 [VALNN42]
        /// </summary>
        public int? NumberofBedroomsUnit1 { get => _numberofBedroomsUnit1; set => SetField(ref _numberofBedroomsUnit1, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms Unit 2 [VALNN43]
        /// </summary>
        public int? NumberofBedroomsUnit2 { get => _numberofBedroomsUnit2; set => SetField(ref _numberofBedroomsUnit2, value); }

        /// <summary>
        /// Correspondent Number Of Bedroom Unit 3 [VALNN01]
        /// </summary>
        public int? NumberOfBedroomUnit3 { get => _numberOfBedroomUnit3; set => SetField(ref _numberOfBedroomUnit3, value); }

        /// <summary>
        /// Correspondent Number Of Bedroom Unit 4 [VALNN02]
        /// </summary>
        public int? NumberOfBedroomUnit4 { get => _numberOfBedroomUnit4; set => SetField(ref _numberOfBedroomUnit4, value); }

        /// <summary>
        /// Correspondent Number of Units [VALNN44]
        /// </summary>
        public int? NumberOfUnits { get => _numberOfUnits; set => SetField(ref _numberOfUnits, value); }

        /// <summary>
        /// Correspondent Order Type [VALNN69]
        /// </summary>
        public string? OrderType { get => _orderType; set => SetField(ref _orderType, value); }

        /// <summary>
        /// Correspondent Panel Number [VALNN45]
        /// </summary>
        public string? PanelNumber { get => _panelNumber; set => SetField(ref _panelNumber, value); }

        /// <summary>
        /// Correspondent Zip Code 4 digits [VALNN65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Correspondent Project Attachment Type [VALNN67]
        /// </summary>
        public string? ProjectAttachmentType { get => _projectAttachmentType; set => SetField(ref _projectAttachmentType, value); }

        /// <summary>
        /// Correspondent Property Appraisal Type [VALNN46]
        /// </summary>
        public string? PropertyAppraisalType { get => _propertyAppraisalType; set => SetField(ref _propertyAppraisalType, value); }

        /// <summary>
        /// Correspondent Property Appraisal Unit Number [VALNN62]
        /// </summary>
        public string? PropertyAppraisalUnitNumber { get => _propertyAppraisalUnitNumber; set => SetField(ref _propertyAppraisalUnitNumber, value); }

        /// <summary>
        /// Correspondent Property Attachment Type [VALNN47]
        /// </summary>
        public StringEnumValue<AttachmentType> PropertyAttachmentType { get => _propertyAttachmentType; set => SetField(ref _propertyAttachmentType, value); }

        /// <summary>
        /// Correspondent Property Usage Code [VALNN48]
        /// </summary>
        public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => _propertyUsageCode; set => SetField(ref _propertyUsageCode, value); }

        /// <summary>
        /// Correspondent Property Value [VALNN49]
        /// </summary>
        public decimal? PropertyValue { get => _propertyValue; set => SetField(ref _propertyValue, value); }

        /// <summary>
        /// Correspondent Purchase Contract Sales Price [VALNN50]
        /// </summary>
        public decimal? PurchaseContractSalesPrice { get => _purchaseContractSalesPrice; set => SetField(ref _purchaseContractSalesPrice, value); }

        /// <summary>
        /// Correspondent Rent Amount Unit 1 [VALNN51]
        /// </summary>
        public decimal? RentAmountUnit1 { get => _rentAmountUnit1; set => SetField(ref _rentAmountUnit1, value); }

        /// <summary>
        /// Correspondent Rent Amount Unit 2 [VALNN52]
        /// </summary>
        public decimal? RentAmountUnit2 { get => _rentAmountUnit2; set => SetField(ref _rentAmountUnit2, value); }

        /// <summary>
        /// Correspondent Site Value [VALNN53]
        /// </summary>
        public decimal? SiteValue { get => _siteValue; set => SetField(ref _siteValue, value); }

        /// <summary>
        /// Correspondent Standard Deviation [VALNN54]
        /// </summary>
        public string? StandardDeviation { get => _standardDeviation; set => SetField(ref _standardDeviation, value); }

        /// <summary>
        /// Correspondent Stated Gross Rent [VALNN56]
        /// </summary>
        public decimal? StatedGrossRent { get => _statedGrossRent; set => SetField(ref _statedGrossRent, value); }

        /// <summary>
        /// Correspondent Stated Property Condition [VALNN57]
        /// </summary>
        public string? StatedPropertyCondition { get => _statedPropertyCondition; set => SetField(ref _statedPropertyCondition, value); }

        /// <summary>
        /// Correspondent Stated Property Type [VALNN58]
        /// </summary>
        public StringEnumValue<PropertyType> StatedPropertyType { get => _statedPropertyType; set => SetField(ref _statedPropertyType, value); }

        /// <summary>
        /// Correspondent Subject Address City [VALNN59]
        /// </summary>
        public string? SubjectAddressCity { get => _subjectAddressCity; set => SetField(ref _subjectAddressCity, value); }

        /// <summary>
        /// Correspondent State [VALNN55]
        /// </summary>
        public StringEnumValue<State> SubjectPropertyState { get => _subjectPropertyState; set => SetField(ref _subjectPropertyState, value); }

        /// <summary>
        /// Correspondent Subject Property Unit Number [VALNN60]
        /// </summary>
        public string? SubjectPropertyUnitNumber { get => _subjectPropertyUnitNumber; set => SetField(ref _subjectPropertyUnitNumber, value); }

        /// <summary>
        /// Correspondent Supervisory Appraisal License # [VALNN61]
        /// </summary>
        public string? SupervisoryAppraisalLicenseNumber { get => _supervisoryAppraisalLicenseNumber; set => SetField(ref _supervisoryAppraisalLicenseNumber, value); }

        /// <summary>
        /// Correspondent Appraisers Valuation Method [VALNN18]
        /// </summary>
        public string? ValuationMethod { get => _valuationMethod; set => SetField(ref _valuationMethod, value); }

        /// <summary>
        /// Correspondent Year Built [VALNN64]
        /// </summary>
        public string? YearBuilt { get => _yearBuilt; set => SetField(ref _yearBuilt, value); }

        /// <summary>
        /// Correspondent Zoning Compliance [VALNN66]
        /// </summary>
        public string? ZoningCompliance { get => _zoningCompliance; set => SetField(ref _zoningCompliance, value); }
    }
}