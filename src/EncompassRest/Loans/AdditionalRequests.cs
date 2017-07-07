using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalRequests : IClean
    {
        private Value<string> _appraisalContactCellPhone;
        public string AppraisalContactCellPhone { get { return _appraisalContactCellPhone; } set { _appraisalContactCellPhone = value; } }
        private Value<string> _appraisalContactEmail;
        public string AppraisalContactEmail { get { return _appraisalContactEmail; } set { _appraisalContactEmail = value; } }
        private Value<string> _appraisalContactForEntry;
        public string AppraisalContactForEntry { get { return _appraisalContactForEntry; } set { _appraisalContactForEntry = value; } }
        private Value<string> _appraisalContactHomePhone;
        public string AppraisalContactHomePhone { get { return _appraisalContactHomePhone; } set { _appraisalContactHomePhone = value; } }
        private Value<string> _appraisalContactName;
        public string AppraisalContactName { get { return _appraisalContactName; } set { _appraisalContactName = value; } }
        private Value<string> _appraisalContactWorkPhone;
        public string AppraisalContactWorkPhone { get { return _appraisalContactWorkPhone; } set { _appraisalContactWorkPhone = value; } }
        private Value<DateTime?> _appraisalDateOrdered;
        public DateTime? AppraisalDateOrdered { get { return _appraisalDateOrdered; } set { _appraisalDateOrdered = value; } }
        private Value<string> _appraisalDescription1;
        public string AppraisalDescription1 { get { return _appraisalDescription1; } set { _appraisalDescription1 = value; } }
        private Value<string> _appraisalDescription2;
        public string AppraisalDescription2 { get { return _appraisalDescription2; } set { _appraisalDescription2 = value; } }
        private Value<string> _appraisalDescription3;
        public string AppraisalDescription3 { get { return _appraisalDescription3; } set { _appraisalDescription3 = value; } }
        private Value<bool?> _appraisalKeyPickUp;
        public bool? AppraisalKeyPickUp { get { return _appraisalKeyPickUp; } set { _appraisalKeyPickUp = value; } }
        private Value<bool?> _appraisalLockBox;
        public bool? AppraisalLockBox { get { return _appraisalLockBox; } set { _appraisalLockBox = value; } }
        private Value<bool?> _appraisalVacant;
        public bool? AppraisalVacant { get { return _appraisalVacant; } set { _appraisalVacant = value; } }
        private Value<string> _floodDescription1;
        public string FloodDescription1 { get { return _floodDescription1; } set { _floodDescription1 = value; } }
        private Value<string> _floodDescription2;
        public string FloodDescription2 { get { return _floodDescription2; } set { _floodDescription2 = value; } }
        private Value<string> _floodDescription3;
        public string FloodDescription3 { get { return _floodDescription3; } set { _floodDescription3 = value; } }
        private Value<bool?> _floodInsuranceEscrowed;
        public bool? FloodInsuranceEscrowed { get { return _floodInsuranceEscrowed; } set { _floodInsuranceEscrowed = value; } }
        private Value<string> _floodReplacementValue;
        public string FloodReplacementValue { get { return _floodReplacementValue; } set { _floodReplacementValue = value; } }
        private Value<string> _hazardDescription1;
        public string HazardDescription1 { get { return _hazardDescription1; } set { _hazardDescription1 = value; } }
        private Value<string> _hazardDescription2;
        public string HazardDescription2 { get { return _hazardDescription2; } set { _hazardDescription2 = value; } }
        private Value<string> _hazardDescription3;
        public string HazardDescription3 { get { return _hazardDescription3; } set { _hazardDescription3 = value; } }
        private Value<bool?> _hazardInsuranceEscrowed;
        public bool? HazardInsuranceEscrowed { get { return _hazardInsuranceEscrowed; } set { _hazardInsuranceEscrowed = value; } }
        private Value<string> _hazardReplacementValue;
        public string HazardReplacementValue { get { return _hazardReplacementValue; } set { _hazardReplacementValue = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _maximumDeductibleFloodAmount;
        public decimal? MaximumDeductibleFloodAmount { get { return _maximumDeductibleFloodAmount; } set { _maximumDeductibleFloodAmount = value; } }
        private Value<decimal?> _maximumDeductibleFloodPercentage;
        public decimal? MaximumDeductibleFloodPercentage { get { return _maximumDeductibleFloodPercentage; } set { _maximumDeductibleFloodPercentage = value; } }
        private Value<decimal?> _maximumDeductibleHazardAmount;
        public decimal? MaximumDeductibleHazardAmount { get { return _maximumDeductibleHazardAmount; } set { _maximumDeductibleHazardAmount = value; } }
        private Value<decimal?> _maximumDeductibleHazardPercentage;
        public decimal? MaximumDeductibleHazardPercentage { get { return _maximumDeductibleHazardPercentage; } set { _maximumDeductibleHazardPercentage = value; } }
        private Value<bool?> _titleContract;
        public bool? TitleContract { get { return _titleContract; } set { _titleContract = value; } }
        private Value<string> _titleDescription1;
        public string TitleDescription1 { get { return _titleDescription1; } set { _titleDescription1 = value; } }
        private Value<string> _titleDescription2;
        public string TitleDescription2 { get { return _titleDescription2; } set { _titleDescription2 = value; } }
        private Value<string> _titleDescription3;
        public string TitleDescription3 { get { return _titleDescription3; } set { _titleDescription3 = value; } }
        private Value<bool?> _titleInsRequirements;
        public bool? TitleInsRequirements { get { return _titleInsRequirements; } set { _titleInsRequirements = value; } }
        private Value<bool?> _titleMailAway;
        public bool? TitleMailAway { get { return _titleMailAway; } set { _titleMailAway = value; } }
        private Value<bool?> _titlePriorTitlePolicy;
        public bool? TitlePriorTitlePolicy { get { return _titlePriorTitlePolicy; } set { _titlePriorTitlePolicy = value; } }
        private Value<bool?> _titleSurvey;
        public bool? TitleSurvey { get { return _titleSurvey; } set { _titleSurvey = value; } }
        private Value<string> _titleTypeOfProperty;
        public string TitleTypeOfProperty { get { return _titleTypeOfProperty; } set { _titleTypeOfProperty = value; } }
        private Value<bool?> _titleWarrantyDeed;
        public bool? TitleWarrantyDeed { get { return _titleWarrantyDeed; } set { _titleWarrantyDeed = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisalContactCellPhone.Clean
                    && _appraisalContactEmail.Clean
                    && _appraisalContactForEntry.Clean
                    && _appraisalContactHomePhone.Clean
                    && _appraisalContactName.Clean
                    && _appraisalContactWorkPhone.Clean
                    && _appraisalDateOrdered.Clean
                    && _appraisalDescription1.Clean
                    && _appraisalDescription2.Clean
                    && _appraisalDescription3.Clean
                    && _appraisalKeyPickUp.Clean
                    && _appraisalLockBox.Clean
                    && _appraisalVacant.Clean
                    && _floodDescription1.Clean
                    && _floodDescription2.Clean
                    && _floodDescription3.Clean
                    && _floodInsuranceEscrowed.Clean
                    && _floodReplacementValue.Clean
                    && _hazardDescription1.Clean
                    && _hazardDescription2.Clean
                    && _hazardDescription3.Clean
                    && _hazardInsuranceEscrowed.Clean
                    && _hazardReplacementValue.Clean
                    && _id.Clean
                    && _maximumDeductibleFloodAmount.Clean
                    && _maximumDeductibleFloodPercentage.Clean
                    && _maximumDeductibleHazardAmount.Clean
                    && _maximumDeductibleHazardPercentage.Clean
                    && _titleContract.Clean
                    && _titleDescription1.Clean
                    && _titleDescription2.Clean
                    && _titleDescription3.Clean
                    && _titleInsRequirements.Clean
                    && _titleMailAway.Clean
                    && _titlePriorTitlePolicy.Clean
                    && _titleSurvey.Clean
                    && _titleTypeOfProperty.Clean
                    && _titleWarrantyDeed.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var appraisalContactCellPhone = _appraisalContactCellPhone; appraisalContactCellPhone.Clean = value; _appraisalContactCellPhone = appraisalContactCellPhone;
                var appraisalContactEmail = _appraisalContactEmail; appraisalContactEmail.Clean = value; _appraisalContactEmail = appraisalContactEmail;
                var appraisalContactForEntry = _appraisalContactForEntry; appraisalContactForEntry.Clean = value; _appraisalContactForEntry = appraisalContactForEntry;
                var appraisalContactHomePhone = _appraisalContactHomePhone; appraisalContactHomePhone.Clean = value; _appraisalContactHomePhone = appraisalContactHomePhone;
                var appraisalContactName = _appraisalContactName; appraisalContactName.Clean = value; _appraisalContactName = appraisalContactName;
                var appraisalContactWorkPhone = _appraisalContactWorkPhone; appraisalContactWorkPhone.Clean = value; _appraisalContactWorkPhone = appraisalContactWorkPhone;
                var appraisalDateOrdered = _appraisalDateOrdered; appraisalDateOrdered.Clean = value; _appraisalDateOrdered = appraisalDateOrdered;
                var appraisalDescription1 = _appraisalDescription1; appraisalDescription1.Clean = value; _appraisalDescription1 = appraisalDescription1;
                var appraisalDescription2 = _appraisalDescription2; appraisalDescription2.Clean = value; _appraisalDescription2 = appraisalDescription2;
                var appraisalDescription3 = _appraisalDescription3; appraisalDescription3.Clean = value; _appraisalDescription3 = appraisalDescription3;
                var appraisalKeyPickUp = _appraisalKeyPickUp; appraisalKeyPickUp.Clean = value; _appraisalKeyPickUp = appraisalKeyPickUp;
                var appraisalLockBox = _appraisalLockBox; appraisalLockBox.Clean = value; _appraisalLockBox = appraisalLockBox;
                var appraisalVacant = _appraisalVacant; appraisalVacant.Clean = value; _appraisalVacant = appraisalVacant;
                var floodDescription1 = _floodDescription1; floodDescription1.Clean = value; _floodDescription1 = floodDescription1;
                var floodDescription2 = _floodDescription2; floodDescription2.Clean = value; _floodDescription2 = floodDescription2;
                var floodDescription3 = _floodDescription3; floodDescription3.Clean = value; _floodDescription3 = floodDescription3;
                var floodInsuranceEscrowed = _floodInsuranceEscrowed; floodInsuranceEscrowed.Clean = value; _floodInsuranceEscrowed = floodInsuranceEscrowed;
                var floodReplacementValue = _floodReplacementValue; floodReplacementValue.Clean = value; _floodReplacementValue = floodReplacementValue;
                var hazardDescription1 = _hazardDescription1; hazardDescription1.Clean = value; _hazardDescription1 = hazardDescription1;
                var hazardDescription2 = _hazardDescription2; hazardDescription2.Clean = value; _hazardDescription2 = hazardDescription2;
                var hazardDescription3 = _hazardDescription3; hazardDescription3.Clean = value; _hazardDescription3 = hazardDescription3;
                var hazardInsuranceEscrowed = _hazardInsuranceEscrowed; hazardInsuranceEscrowed.Clean = value; _hazardInsuranceEscrowed = hazardInsuranceEscrowed;
                var hazardReplacementValue = _hazardReplacementValue; hazardReplacementValue.Clean = value; _hazardReplacementValue = hazardReplacementValue;
                var id = _id; id.Clean = value; _id = id;
                var maximumDeductibleFloodAmount = _maximumDeductibleFloodAmount; maximumDeductibleFloodAmount.Clean = value; _maximumDeductibleFloodAmount = maximumDeductibleFloodAmount;
                var maximumDeductibleFloodPercentage = _maximumDeductibleFloodPercentage; maximumDeductibleFloodPercentage.Clean = value; _maximumDeductibleFloodPercentage = maximumDeductibleFloodPercentage;
                var maximumDeductibleHazardAmount = _maximumDeductibleHazardAmount; maximumDeductibleHazardAmount.Clean = value; _maximumDeductibleHazardAmount = maximumDeductibleHazardAmount;
                var maximumDeductibleHazardPercentage = _maximumDeductibleHazardPercentage; maximumDeductibleHazardPercentage.Clean = value; _maximumDeductibleHazardPercentage = maximumDeductibleHazardPercentage;
                var titleContract = _titleContract; titleContract.Clean = value; _titleContract = titleContract;
                var titleDescription1 = _titleDescription1; titleDescription1.Clean = value; _titleDescription1 = titleDescription1;
                var titleDescription2 = _titleDescription2; titleDescription2.Clean = value; _titleDescription2 = titleDescription2;
                var titleDescription3 = _titleDescription3; titleDescription3.Clean = value; _titleDescription3 = titleDescription3;
                var titleInsRequirements = _titleInsRequirements; titleInsRequirements.Clean = value; _titleInsRequirements = titleInsRequirements;
                var titleMailAway = _titleMailAway; titleMailAway.Clean = value; _titleMailAway = titleMailAway;
                var titlePriorTitlePolicy = _titlePriorTitlePolicy; titlePriorTitlePolicy.Clean = value; _titlePriorTitlePolicy = titlePriorTitlePolicy;
                var titleSurvey = _titleSurvey; titleSurvey.Clean = value; _titleSurvey = titleSurvey;
                var titleTypeOfProperty = _titleTypeOfProperty; titleTypeOfProperty.Clean = value; _titleTypeOfProperty = titleTypeOfProperty;
                var titleWarrantyDeed = _titleWarrantyDeed; titleWarrantyDeed.Clean = value; _titleWarrantyDeed = titleWarrantyDeed;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public AdditionalRequests()
        {
            Clean = true;
        }
    }
}