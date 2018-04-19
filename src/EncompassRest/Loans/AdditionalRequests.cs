using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalRequests
    /// </summary>
    public sealed partial class AdditionalRequests : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _appraisalContactCellPhone;
        /// <summary>
        /// Request Appraisal Access Information Contact Cell Phone [REQUEST.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Request Appraisal Access Information Contact Cell Phone")]
        public string AppraisalContactCellPhone { get => _appraisalContactCellPhone; set => _appraisalContactCellPhone = value; }
        private DirtyValue<string> _appraisalContactEmail;
        /// <summary>
        /// Request Appraisal Access Information Contact Email [REQUEST.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Access Information Contact Email")]
        public string AppraisalContactEmail { get => _appraisalContactEmail; set => _appraisalContactEmail = value; }
        private DirtyValue<StringEnumValue<AppraisalContactForEntry>> _appraisalContactForEntry;
        /// <summary>
        /// Request Appraisal Contact for Entry [REQUEST.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Contact for Entry")]
        public StringEnumValue<AppraisalContactForEntry> AppraisalContactForEntry { get => _appraisalContactForEntry; set => _appraisalContactForEntry = value; }
        private DirtyValue<string> _appraisalContactHomePhone;
        /// <summary>
        /// Request Appraisal Access Information Contact Home Phone [REQUEST.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Request Appraisal Access Information Contact Home Phone")]
        public string AppraisalContactHomePhone { get => _appraisalContactHomePhone; set => _appraisalContactHomePhone = value; }
        private DirtyValue<string> _appraisalContactName;
        /// <summary>
        /// Request Appraisal Access Information Contact Name [REQUEST.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Access Information Contact Name")]
        public string AppraisalContactName { get => _appraisalContactName; set => _appraisalContactName = value; }
        private DirtyValue<string> _appraisalContactWorkPhone;
        /// <summary>
        /// Request Appraisal Access Information Contact Business Phone [REQUEST.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Request Appraisal Access Information Contact Business Phone")]
        public string AppraisalContactWorkPhone { get => _appraisalContactWorkPhone; set => _appraisalContactWorkPhone = value; }
        private DirtyValue<DateTime?> _appraisalDateOrdered;
        /// <summary>
        /// Request Appraisal Date Ordered [REQUEST.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Date Ordered")]
        public DateTime? AppraisalDateOrdered { get => _appraisalDateOrdered; set => _appraisalDateOrdered = value; }
        private DirtyValue<string> _appraisalDescription1;
        /// <summary>
        /// Request Appraisal Comments 1 [REQUEST.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Comments 1")]
        public string AppraisalDescription1 { get => _appraisalDescription1; set => _appraisalDescription1 = value; }
        private DirtyValue<string> _appraisalDescription2;
        /// <summary>
        /// Request Appraisal Comments 2 [REQUEST.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Comments 2")]
        public string AppraisalDescription2 { get => _appraisalDescription2; set => _appraisalDescription2 = value; }
        private DirtyValue<string> _appraisalDescription3;
        /// <summary>
        /// Request Appraisal Comments 3 [REQUEST.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Comments 3")]
        public string AppraisalDescription3 { get => _appraisalDescription3; set => _appraisalDescription3 = value; }
        private DirtyValue<bool?> _appraisalKeyPickUp;
        /// <summary>
        /// Request Appraisal Prprty Access Key Pick Up [REQUEST.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Prprty Access Key Pick Up", OptionsJson = "{\"true\":\"Key Pick Up\"}")]
        public bool? AppraisalKeyPickUp { get => _appraisalKeyPickUp; set => _appraisalKeyPickUp = value; }
        private DirtyValue<bool?> _appraisalLockBox;
        /// <summary>
        /// Request Appraisal Prprty Access Lockbox [REQUEST.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Prprty Access Lockbox", OptionsJson = "{\"true\":\"Lock Box\"}")]
        public bool? AppraisalLockBox { get => _appraisalLockBox; set => _appraisalLockBox = value; }
        private DirtyValue<bool?> _appraisalVacant;
        /// <summary>
        /// Request Appraisal Prprty Access Vacant [REQUEST.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Request Appraisal Prprty Access Vacant", OptionsJson = "{\"true\":\"Vacant\"}")]
        public bool? AppraisalVacant { get => _appraisalVacant; set => _appraisalVacant = value; }
        private DirtyValue<string> _floodDescription1;
        /// <summary>
        /// Request Flood Ins Comments 1 [REQUEST.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Request Flood Ins Comments 1")]
        public string FloodDescription1 { get => _floodDescription1; set => _floodDescription1 = value; }
        private DirtyValue<string> _floodDescription2;
        /// <summary>
        /// Request Flood Ins Comments 2 [REQUEST.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Request Flood Ins Comments 2")]
        public string FloodDescription2 { get => _floodDescription2; set => _floodDescription2 = value; }
        private DirtyValue<string> _floodDescription3;
        /// <summary>
        /// Request Flood Ins Comments 3 [REQUEST.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Request Flood Ins Comments 3")]
        public string FloodDescription3 { get => _floodDescription3; set => _floodDescription3 = value; }
        private DirtyValue<bool?> _floodInsuranceEscrowed;
        /// <summary>
        /// Request Flood Ins Escrowed Yes/No [REQUEST.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Request Flood Ins Escrowed Yes/No")]
        public bool? FloodInsuranceEscrowed { get => _floodInsuranceEscrowed; set => _floodInsuranceEscrowed = value; }
        private DirtyValue<string> _floodReplacementValue;
        /// <summary>
        /// Request Flood Ins Replacement Value [REQUEST.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Request Flood Ins Replacement Value")]
        public string FloodReplacementValue { get => _floodReplacementValue; set => _floodReplacementValue = value; }
        private DirtyValue<string> _hazardDescription1;
        /// <summary>
        /// Request Hazard Ins Comments 1 [REQUEST.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Request Hazard Ins Comments 1")]
        public string HazardDescription1 { get => _hazardDescription1; set => _hazardDescription1 = value; }
        private DirtyValue<string> _hazardDescription2;
        /// <summary>
        /// Request Hazard Ins Comments 2 [REQUEST.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Request Hazard Ins Comments 2")]
        public string HazardDescription2 { get => _hazardDescription2; set => _hazardDescription2 = value; }
        private DirtyValue<string> _hazardDescription3;
        /// <summary>
        /// Request Hazard Ins Comments 3 [REQUEST.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Request Hazard Ins Comments 3")]
        public string HazardDescription3 { get => _hazardDescription3; set => _hazardDescription3 = value; }
        private DirtyValue<bool?> _hazardInsuranceEscrowed;
        /// <summary>
        /// Request Hazard Ins Escrowed Yes/No [REQUEST.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Request Hazard Ins Escrowed Yes/No")]
        public bool? HazardInsuranceEscrowed { get => _hazardInsuranceEscrowed; set => _hazardInsuranceEscrowed = value; }
        private DirtyValue<string> _hazardReplacementValue;
        /// <summary>
        /// Request Hazard Ins Replacement Value [REQUEST.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Request Hazard Ins Replacement Value")]
        public string HazardReplacementValue { get => _hazardReplacementValue; set => _hazardReplacementValue = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AdditionalRequests Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _maximumDeductibleFloodAmount;
        /// <summary>
        /// Maximum Deductible Flood Amount [REQUEST.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Maximum Deductible Flood Amount")]
        public decimal? MaximumDeductibleFloodAmount { get => _maximumDeductibleFloodAmount; set => _maximumDeductibleFloodAmount = value; }
        private DirtyValue<decimal?> _maximumDeductibleFloodPercentage;
        /// <summary>
        /// Maximum Deductible Flood Percentage [REQUEST.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Maximum Deductible Flood Percentage")]
        public decimal? MaximumDeductibleFloodPercentage { get => _maximumDeductibleFloodPercentage; set => _maximumDeductibleFloodPercentage = value; }
        private DirtyValue<decimal?> _maximumDeductibleHazardAmount;
        /// <summary>
        /// Maximum Deductible Hazard Amount [REQUEST.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Maximum Deductible Hazard Amount")]
        public decimal? MaximumDeductibleHazardAmount { get => _maximumDeductibleHazardAmount; set => _maximumDeductibleHazardAmount = value; }
        private DirtyValue<decimal?> _maximumDeductibleHazardPercentage;
        /// <summary>
        /// Maximum Deductible Hazard Percentage [REQUEST.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Maximum Deductible Hazard Percentage")]
        public decimal? MaximumDeductibleHazardPercentage { get => _maximumDeductibleHazardPercentage; set => _maximumDeductibleHazardPercentage = value; }
        private DirtyValue<bool?> _titleContract;
        /// <summary>
        /// Request Title Commit Attach Contract [REQUEST.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Attach Contract", OptionsJson = "{\"true\":\"Contract\"}")]
        public bool? TitleContract { get => _titleContract; set => _titleContract = value; }
        private DirtyValue<string> _titleDescription1;
        /// <summary>
        /// Request Title Commit Comments 1 [REQUEST.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Comments 1")]
        public string TitleDescription1 { get => _titleDescription1; set => _titleDescription1 = value; }
        private DirtyValue<string> _titleDescription2;
        /// <summary>
        /// Request Title Commit Comments 2 [REQUEST.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Comments 2")]
        public string TitleDescription2 { get => _titleDescription2; set => _titleDescription2 = value; }
        private DirtyValue<string> _titleDescription3;
        /// <summary>
        /// Request Title Commit Comments 3 [REQUEST.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Comments 3")]
        public string TitleDescription3 { get => _titleDescription3; set => _titleDescription3 = value; }
        private DirtyValue<bool?> _titleInsRequirements;
        /// <summary>
        /// Request Title Commit Attach Title Ins Req [REQUEST.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Attach Title Ins Req", OptionsJson = "{\"true\":\"Title Insurance Requirements\"}")]
        public bool? TitleInsRequirements { get => _titleInsRequirements; set => _titleInsRequirements = value; }
        private DirtyValue<bool?> _titleMailAway;
        /// <summary>
        /// Request Title Commit Mail Yes/No [REQUEST.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Mail Yes/No")]
        public bool? TitleMailAway { get => _titleMailAway; set => _titleMailAway = value; }
        private DirtyValue<bool?> _titlePriorTitlePolicy;
        /// <summary>
        /// Request Title Commit Attach Prior Title Policy [REQUEST.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Attach Prior Title Policy", OptionsJson = "{\"true\":\"Prior Title Policy\"}")]
        public bool? TitlePriorTitlePolicy { get => _titlePriorTitlePolicy; set => _titlePriorTitlePolicy = value; }
        private DirtyValue<bool?> _titleSurvey;
        /// <summary>
        /// Request Title Commit Attach Survey [REQUEST.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Attach Survey", OptionsJson = "{\"true\":\"Survey\"}")]
        public bool? TitleSurvey { get => _titleSurvey; set => _titleSurvey = value; }
        private DirtyValue<string> _titleTypeOfProperty;
        /// <summary>
        /// Request Title Commit Policy Type [REQUEST.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Policy Type")]
        public string TitleTypeOfProperty { get => _titleTypeOfProperty; set => _titleTypeOfProperty = value; }
        private DirtyValue<bool?> _titleWarrantyDeed;
        /// <summary>
        /// Request Title Commit Attach Warranty Deed [REQUEST.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Request Title Commit Attach Warranty Deed", OptionsJson = "{\"true\":\"Warranty Deed\"}")]
        public bool? TitleWarrantyDeed { get => _titleWarrantyDeed; set => _titleWarrantyDeed = value; }
        internal override bool DirtyInternal
        {
            get => _appraisalContactCellPhone.Dirty
                || _appraisalContactEmail.Dirty
                || _appraisalContactForEntry.Dirty
                || _appraisalContactHomePhone.Dirty
                || _appraisalContactName.Dirty
                || _appraisalContactWorkPhone.Dirty
                || _appraisalDateOrdered.Dirty
                || _appraisalDescription1.Dirty
                || _appraisalDescription2.Dirty
                || _appraisalDescription3.Dirty
                || _appraisalKeyPickUp.Dirty
                || _appraisalLockBox.Dirty
                || _appraisalVacant.Dirty
                || _floodDescription1.Dirty
                || _floodDescription2.Dirty
                || _floodDescription3.Dirty
                || _floodInsuranceEscrowed.Dirty
                || _floodReplacementValue.Dirty
                || _hazardDescription1.Dirty
                || _hazardDescription2.Dirty
                || _hazardDescription3.Dirty
                || _hazardInsuranceEscrowed.Dirty
                || _hazardReplacementValue.Dirty
                || _id.Dirty
                || _maximumDeductibleFloodAmount.Dirty
                || _maximumDeductibleFloodPercentage.Dirty
                || _maximumDeductibleHazardAmount.Dirty
                || _maximumDeductibleHazardPercentage.Dirty
                || _titleContract.Dirty
                || _titleDescription1.Dirty
                || _titleDescription2.Dirty
                || _titleDescription3.Dirty
                || _titleInsRequirements.Dirty
                || _titleMailAway.Dirty
                || _titlePriorTitlePolicy.Dirty
                || _titleSurvey.Dirty
                || _titleTypeOfProperty.Dirty
                || _titleWarrantyDeed.Dirty;
            set
            {
                _appraisalContactCellPhone.Dirty = value;
                _appraisalContactEmail.Dirty = value;
                _appraisalContactForEntry.Dirty = value;
                _appraisalContactHomePhone.Dirty = value;
                _appraisalContactName.Dirty = value;
                _appraisalContactWorkPhone.Dirty = value;
                _appraisalDateOrdered.Dirty = value;
                _appraisalDescription1.Dirty = value;
                _appraisalDescription2.Dirty = value;
                _appraisalDescription3.Dirty = value;
                _appraisalKeyPickUp.Dirty = value;
                _appraisalLockBox.Dirty = value;
                _appraisalVacant.Dirty = value;
                _floodDescription1.Dirty = value;
                _floodDescription2.Dirty = value;
                _floodDescription3.Dirty = value;
                _floodInsuranceEscrowed.Dirty = value;
                _floodReplacementValue.Dirty = value;
                _hazardDescription1.Dirty = value;
                _hazardDescription2.Dirty = value;
                _hazardDescription3.Dirty = value;
                _hazardInsuranceEscrowed.Dirty = value;
                _hazardReplacementValue.Dirty = value;
                _id.Dirty = value;
                _maximumDeductibleFloodAmount.Dirty = value;
                _maximumDeductibleFloodPercentage.Dirty = value;
                _maximumDeductibleHazardAmount.Dirty = value;
                _maximumDeductibleHazardPercentage.Dirty = value;
                _titleContract.Dirty = value;
                _titleDescription1.Dirty = value;
                _titleDescription2.Dirty = value;
                _titleDescription3.Dirty = value;
                _titleInsRequirements.Dirty = value;
                _titleMailAway.Dirty = value;
                _titlePriorTitlePolicy.Dirty = value;
                _titleSurvey.Dirty = value;
                _titleTypeOfProperty.Dirty = value;
                _titleWarrantyDeed.Dirty = value;
            }
        }
    }
}