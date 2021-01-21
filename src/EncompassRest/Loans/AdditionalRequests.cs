using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalRequests
    /// </summary>
    public sealed partial class AdditionalRequests : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _appraisalContactCellPhone;
        private DirtyValue<string?>? _appraisalContactEmail;
        private DirtyValue<StringEnumValue<AppraisalContactForEntry>>? _appraisalContactForEntry;
        private DirtyValue<string?>? _appraisalContactHomePhone;
        private DirtyValue<string?>? _appraisalContactName;
        private DirtyValue<string?>? _appraisalContactWorkPhone;
        private DirtyValue<DateTime?>? _appraisalDateOrdered;
        private DirtyValue<string?>? _appraisalDescription1;
        private DirtyValue<string?>? _appraisalDescription2;
        private DirtyValue<string?>? _appraisalDescription3;
        private DirtyValue<bool?>? _appraisalKeyPickUp;
        private DirtyValue<bool?>? _appraisalLockBox;
        private DirtyValue<bool?>? _appraisalVacant;
        private DirtyValue<string?>? _floodDescription1;
        private DirtyValue<string?>? _floodDescription2;
        private DirtyValue<string?>? _floodDescription3;
        private DirtyValue<bool?>? _floodInsuranceEscrowed;
        private DirtyValue<string?>? _floodReplacementValue;
        private DirtyValue<string?>? _hazardDescription1;
        private DirtyValue<string?>? _hazardDescription2;
        private DirtyValue<string?>? _hazardDescription3;
        private DirtyValue<bool?>? _hazardInsuranceEscrowed;
        private DirtyValue<string?>? _hazardReplacementValue;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _maximumDeductibleFloodAmount;
        private DirtyValue<decimal?>? _maximumDeductibleFloodPercentage;
        private DirtyValue<decimal?>? _maximumDeductibleHazardAmount;
        private DirtyValue<decimal?>? _maximumDeductibleHazardPercentage;
        private DirtyValue<bool?>? _titleContract;
        private DirtyValue<string?>? _titleDescription1;
        private DirtyValue<string?>? _titleDescription2;
        private DirtyValue<string?>? _titleDescription3;
        private DirtyValue<bool?>? _titleInsRequirements;
        private DirtyValue<bool?>? _titleMailAway;
        private DirtyValue<bool?>? _titlePriorTitlePolicy;
        private DirtyValue<bool?>? _titleSurvey;
        private DirtyValue<string?>? _titleTypeOfProperty;
        private DirtyValue<bool?>? _titleWarrantyDeed;

        /// <summary>
        /// Request Appraisal Access Information Contact Cell Phone [REQUEST.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? AppraisalContactCellPhone { get => _appraisalContactCellPhone; set => SetField(ref _appraisalContactCellPhone, value); }

        /// <summary>
        /// Request Appraisal Access Information Contact Email [REQUEST.X33]
        /// </summary>
        public string? AppraisalContactEmail { get => _appraisalContactEmail; set => SetField(ref _appraisalContactEmail, value); }

        /// <summary>
        /// Request Appraisal Contact for Entry [REQUEST.X25]
        /// </summary>
        public StringEnumValue<AppraisalContactForEntry> AppraisalContactForEntry { get => _appraisalContactForEntry; set => SetField(ref _appraisalContactForEntry, value); }

        /// <summary>
        /// Request Appraisal Access Information Contact Home Phone [REQUEST.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? AppraisalContactHomePhone { get => _appraisalContactHomePhone; set => SetField(ref _appraisalContactHomePhone, value); }

        /// <summary>
        /// Request Appraisal Access Information Contact Name [REQUEST.X29]
        /// </summary>
        public string? AppraisalContactName { get => _appraisalContactName; set => SetField(ref _appraisalContactName, value); }

        /// <summary>
        /// Request Appraisal Access Information Contact Business Phone [REQUEST.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? AppraisalContactWorkPhone { get => _appraisalContactWorkPhone; set => SetField(ref _appraisalContactWorkPhone, value); }

        /// <summary>
        /// Request Appraisal Date Ordered [REQUEST.X21]
        /// </summary>
        public DateTime? AppraisalDateOrdered { get => _appraisalDateOrdered; set => SetField(ref _appraisalDateOrdered, value); }

        /// <summary>
        /// Request Appraisal Comments 1 [REQUEST.X26]
        /// </summary>
        public string? AppraisalDescription1 { get => _appraisalDescription1; set => SetField(ref _appraisalDescription1, value); }

        /// <summary>
        /// Request Appraisal Comments 2 [REQUEST.X27]
        /// </summary>
        public string? AppraisalDescription2 { get => _appraisalDescription2; set => SetField(ref _appraisalDescription2, value); }

        /// <summary>
        /// Request Appraisal Comments 3 [REQUEST.X28]
        /// </summary>
        public string? AppraisalDescription3 { get => _appraisalDescription3; set => SetField(ref _appraisalDescription3, value); }

        /// <summary>
        /// Request Appraisal Prprty Access Key Pick Up [REQUEST.X24]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Key Pick Up\"}")]
        public bool? AppraisalKeyPickUp { get => _appraisalKeyPickUp; set => SetField(ref _appraisalKeyPickUp, value); }

        /// <summary>
        /// Request Appraisal Prprty Access Lockbox [REQUEST.X23]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Lock Box\"}")]
        public bool? AppraisalLockBox { get => _appraisalLockBox; set => SetField(ref _appraisalLockBox, value); }

        /// <summary>
        /// Request Appraisal Prprty Access Vacant [REQUEST.X22]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Vacant\"}")]
        public bool? AppraisalVacant { get => _appraisalVacant; set => SetField(ref _appraisalVacant, value); }

        /// <summary>
        /// Request Flood Ins Comments 1 [REQUEST.X8]
        /// </summary>
        public string? FloodDescription1 { get => _floodDescription1; set => SetField(ref _floodDescription1, value); }

        /// <summary>
        /// Request Flood Ins Comments 2 [REQUEST.X9]
        /// </summary>
        public string? FloodDescription2 { get => _floodDescription2; set => SetField(ref _floodDescription2, value); }

        /// <summary>
        /// Request Flood Ins Comments 3 [REQUEST.X10]
        /// </summary>
        public string? FloodDescription3 { get => _floodDescription3; set => SetField(ref _floodDescription3, value); }

        /// <summary>
        /// Request Flood Ins Escrowed Yes/No [REQUEST.X7]
        /// </summary>
        public bool? FloodInsuranceEscrowed { get => _floodInsuranceEscrowed; set => SetField(ref _floodInsuranceEscrowed, value); }

        /// <summary>
        /// Request Flood Ins Replacement Value [REQUEST.X6]
        /// </summary>
        public string? FloodReplacementValue { get => _floodReplacementValue; set => SetField(ref _floodReplacementValue, value); }

        /// <summary>
        /// Request Hazard Ins Comments 1 [REQUEST.X3]
        /// </summary>
        public string? HazardDescription1 { get => _hazardDescription1; set => SetField(ref _hazardDescription1, value); }

        /// <summary>
        /// Request Hazard Ins Comments 2 [REQUEST.X4]
        /// </summary>
        public string? HazardDescription2 { get => _hazardDescription2; set => SetField(ref _hazardDescription2, value); }

        /// <summary>
        /// Request Hazard Ins Comments 3 [REQUEST.X5]
        /// </summary>
        public string? HazardDescription3 { get => _hazardDescription3; set => SetField(ref _hazardDescription3, value); }

        /// <summary>
        /// Request Hazard Ins Escrowed Yes/No [REQUEST.X2]
        /// </summary>
        public bool? HazardInsuranceEscrowed { get => _hazardInsuranceEscrowed; set => SetField(ref _hazardInsuranceEscrowed, value); }

        /// <summary>
        /// Request Hazard Ins Replacement Value [REQUEST.X1]
        /// </summary>
        public string? HazardReplacementValue { get => _hazardReplacementValue; set => SetField(ref _hazardReplacementValue, value); }

        /// <summary>
        /// AdditionalRequests Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Maximum Deductible Flood Amount [REQUEST.X37]
        /// </summary>
        public decimal? MaximumDeductibleFloodAmount { get => _maximumDeductibleFloodAmount; set => SetField(ref _maximumDeductibleFloodAmount, value); }

        /// <summary>
        /// Maximum Deductible Flood Percentage [REQUEST.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaximumDeductibleFloodPercentage { get => _maximumDeductibleFloodPercentage; set => SetField(ref _maximumDeductibleFloodPercentage, value); }

        /// <summary>
        /// Maximum Deductible Hazard Amount [REQUEST.X35]
        /// </summary>
        public decimal? MaximumDeductibleHazardAmount { get => _maximumDeductibleHazardAmount; set => SetField(ref _maximumDeductibleHazardAmount, value); }

        /// <summary>
        /// Maximum Deductible Hazard Percentage [REQUEST.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaximumDeductibleHazardPercentage { get => _maximumDeductibleHazardPercentage; set => SetField(ref _maximumDeductibleHazardPercentage, value); }

        /// <summary>
        /// Request Title Commit Attach Contract [REQUEST.X13]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Contract\"}")]
        public bool? TitleContract { get => _titleContract; set => SetField(ref _titleContract, value); }

        /// <summary>
        /// Request Title Commit Comments 1 [REQUEST.X18]
        /// </summary>
        public string? TitleDescription1 { get => _titleDescription1; set => SetField(ref _titleDescription1, value); }

        /// <summary>
        /// Request Title Commit Comments 2 [REQUEST.X19]
        /// </summary>
        public string? TitleDescription2 { get => _titleDescription2; set => SetField(ref _titleDescription2, value); }

        /// <summary>
        /// Request Title Commit Comments 3 [REQUEST.X20]
        /// </summary>
        public string? TitleDescription3 { get => _titleDescription3; set => SetField(ref _titleDescription3, value); }

        /// <summary>
        /// Request Title Commit Attach Title Ins Req [REQUEST.X12]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Title Insurance Requirements\"}")]
        public bool? TitleInsRequirements { get => _titleInsRequirements; set => SetField(ref _titleInsRequirements, value); }

        /// <summary>
        /// Request Title Commit Mail Yes/No [REQUEST.X17]
        /// </summary>
        public bool? TitleMailAway { get => _titleMailAway; set => SetField(ref _titleMailAway, value); }

        /// <summary>
        /// Request Title Commit Attach Prior Title Policy [REQUEST.X11]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prior Title Policy\"}")]
        public bool? TitlePriorTitlePolicy { get => _titlePriorTitlePolicy; set => SetField(ref _titlePriorTitlePolicy, value); }

        /// <summary>
        /// Request Title Commit Attach Survey [REQUEST.X15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Survey\"}")]
        public bool? TitleSurvey { get => _titleSurvey; set => SetField(ref _titleSurvey, value); }

        /// <summary>
        /// Request Title Commit Policy Type [REQUEST.X16]
        /// </summary>
        public string? TitleTypeOfProperty { get => _titleTypeOfProperty; set => SetField(ref _titleTypeOfProperty, value); }

        /// <summary>
        /// Request Title Commit Attach Warranty Deed [REQUEST.X14]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Warranty Deed\"}")]
        public bool? TitleWarrantyDeed { get => _titleWarrantyDeed; set => SetField(ref _titleWarrantyDeed, value); }
    }
}