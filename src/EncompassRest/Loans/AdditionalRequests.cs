using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalRequests : IDirty
    {
        private DirtyValue<string> _appraisalContactCellPhone;
        public string AppraisalContactCellPhone { get { return _appraisalContactCellPhone; } set { _appraisalContactCellPhone = value; } }
        private DirtyValue<string> _appraisalContactEmail;
        public string AppraisalContactEmail { get { return _appraisalContactEmail; } set { _appraisalContactEmail = value; } }
        private DirtyValue<string> _appraisalContactForEntry;
        public string AppraisalContactForEntry { get { return _appraisalContactForEntry; } set { _appraisalContactForEntry = value; } }
        private DirtyValue<string> _appraisalContactHomePhone;
        public string AppraisalContactHomePhone { get { return _appraisalContactHomePhone; } set { _appraisalContactHomePhone = value; } }
        private DirtyValue<string> _appraisalContactName;
        public string AppraisalContactName { get { return _appraisalContactName; } set { _appraisalContactName = value; } }
        private DirtyValue<string> _appraisalContactWorkPhone;
        public string AppraisalContactWorkPhone { get { return _appraisalContactWorkPhone; } set { _appraisalContactWorkPhone = value; } }
        private DirtyValue<DateTime?> _appraisalDateOrdered;
        public DateTime? AppraisalDateOrdered { get { return _appraisalDateOrdered; } set { _appraisalDateOrdered = value; } }
        private DirtyValue<string> _appraisalDescription1;
        public string AppraisalDescription1 { get { return _appraisalDescription1; } set { _appraisalDescription1 = value; } }
        private DirtyValue<string> _appraisalDescription2;
        public string AppraisalDescription2 { get { return _appraisalDescription2; } set { _appraisalDescription2 = value; } }
        private DirtyValue<string> _appraisalDescription3;
        public string AppraisalDescription3 { get { return _appraisalDescription3; } set { _appraisalDescription3 = value; } }
        private DirtyValue<bool?> _appraisalKeyPickUp;
        public bool? AppraisalKeyPickUp { get { return _appraisalKeyPickUp; } set { _appraisalKeyPickUp = value; } }
        private DirtyValue<bool?> _appraisalLockBox;
        public bool? AppraisalLockBox { get { return _appraisalLockBox; } set { _appraisalLockBox = value; } }
        private DirtyValue<bool?> _appraisalVacant;
        public bool? AppraisalVacant { get { return _appraisalVacant; } set { _appraisalVacant = value; } }
        private DirtyValue<string> _floodDescription1;
        public string FloodDescription1 { get { return _floodDescription1; } set { _floodDescription1 = value; } }
        private DirtyValue<string> _floodDescription2;
        public string FloodDescription2 { get { return _floodDescription2; } set { _floodDescription2 = value; } }
        private DirtyValue<string> _floodDescription3;
        public string FloodDescription3 { get { return _floodDescription3; } set { _floodDescription3 = value; } }
        private DirtyValue<bool?> _floodInsuranceEscrowed;
        public bool? FloodInsuranceEscrowed { get { return _floodInsuranceEscrowed; } set { _floodInsuranceEscrowed = value; } }
        private DirtyValue<string> _floodReplacementValue;
        public string FloodReplacementValue { get { return _floodReplacementValue; } set { _floodReplacementValue = value; } }
        private DirtyValue<string> _hazardDescription1;
        public string HazardDescription1 { get { return _hazardDescription1; } set { _hazardDescription1 = value; } }
        private DirtyValue<string> _hazardDescription2;
        public string HazardDescription2 { get { return _hazardDescription2; } set { _hazardDescription2 = value; } }
        private DirtyValue<string> _hazardDescription3;
        public string HazardDescription3 { get { return _hazardDescription3; } set { _hazardDescription3 = value; } }
        private DirtyValue<bool?> _hazardInsuranceEscrowed;
        public bool? HazardInsuranceEscrowed { get { return _hazardInsuranceEscrowed; } set { _hazardInsuranceEscrowed = value; } }
        private DirtyValue<string> _hazardReplacementValue;
        public string HazardReplacementValue { get { return _hazardReplacementValue; } set { _hazardReplacementValue = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _maximumDeductibleFloodAmount;
        public decimal? MaximumDeductibleFloodAmount { get { return _maximumDeductibleFloodAmount; } set { _maximumDeductibleFloodAmount = value; } }
        private DirtyValue<decimal?> _maximumDeductibleFloodPercentage;
        public decimal? MaximumDeductibleFloodPercentage { get { return _maximumDeductibleFloodPercentage; } set { _maximumDeductibleFloodPercentage = value; } }
        private DirtyValue<decimal?> _maximumDeductibleHazardAmount;
        public decimal? MaximumDeductibleHazardAmount { get { return _maximumDeductibleHazardAmount; } set { _maximumDeductibleHazardAmount = value; } }
        private DirtyValue<decimal?> _maximumDeductibleHazardPercentage;
        public decimal? MaximumDeductibleHazardPercentage { get { return _maximumDeductibleHazardPercentage; } set { _maximumDeductibleHazardPercentage = value; } }
        private DirtyValue<bool?> _titleContract;
        public bool? TitleContract { get { return _titleContract; } set { _titleContract = value; } }
        private DirtyValue<string> _titleDescription1;
        public string TitleDescription1 { get { return _titleDescription1; } set { _titleDescription1 = value; } }
        private DirtyValue<string> _titleDescription2;
        public string TitleDescription2 { get { return _titleDescription2; } set { _titleDescription2 = value; } }
        private DirtyValue<string> _titleDescription3;
        public string TitleDescription3 { get { return _titleDescription3; } set { _titleDescription3 = value; } }
        private DirtyValue<bool?> _titleInsRequirements;
        public bool? TitleInsRequirements { get { return _titleInsRequirements; } set { _titleInsRequirements = value; } }
        private DirtyValue<bool?> _titleMailAway;
        public bool? TitleMailAway { get { return _titleMailAway; } set { _titleMailAway = value; } }
        private DirtyValue<bool?> _titlePriorTitlePolicy;
        public bool? TitlePriorTitlePolicy { get { return _titlePriorTitlePolicy; } set { _titlePriorTitlePolicy = value; } }
        private DirtyValue<bool?> _titleSurvey;
        public bool? TitleSurvey { get { return _titleSurvey; } set { _titleSurvey = value; } }
        private DirtyValue<string> _titleTypeOfProperty;
        public string TitleTypeOfProperty { get { return _titleTypeOfProperty; } set { _titleTypeOfProperty = value; } }
        private DirtyValue<bool?> _titleWarrantyDeed;
        public bool? TitleWarrantyDeed { get { return _titleWarrantyDeed; } set { _titleWarrantyDeed = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _appraisalContactCellPhone.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}