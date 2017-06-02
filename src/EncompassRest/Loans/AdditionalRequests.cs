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
                var v0 = _appraisalContactCellPhone; v0.Clean = value; _appraisalContactCellPhone = v0;
                var v1 = _appraisalContactEmail; v1.Clean = value; _appraisalContactEmail = v1;
                var v2 = _appraisalContactForEntry; v2.Clean = value; _appraisalContactForEntry = v2;
                var v3 = _appraisalContactHomePhone; v3.Clean = value; _appraisalContactHomePhone = v3;
                var v4 = _appraisalContactName; v4.Clean = value; _appraisalContactName = v4;
                var v5 = _appraisalContactWorkPhone; v5.Clean = value; _appraisalContactWorkPhone = v5;
                var v6 = _appraisalDateOrdered; v6.Clean = value; _appraisalDateOrdered = v6;
                var v7 = _appraisalDescription1; v7.Clean = value; _appraisalDescription1 = v7;
                var v8 = _appraisalDescription2; v8.Clean = value; _appraisalDescription2 = v8;
                var v9 = _appraisalDescription3; v9.Clean = value; _appraisalDescription3 = v9;
                var v10 = _appraisalKeyPickUp; v10.Clean = value; _appraisalKeyPickUp = v10;
                var v11 = _appraisalLockBox; v11.Clean = value; _appraisalLockBox = v11;
                var v12 = _appraisalVacant; v12.Clean = value; _appraisalVacant = v12;
                var v13 = _floodDescription1; v13.Clean = value; _floodDescription1 = v13;
                var v14 = _floodDescription2; v14.Clean = value; _floodDescription2 = v14;
                var v15 = _floodDescription3; v15.Clean = value; _floodDescription3 = v15;
                var v16 = _floodInsuranceEscrowed; v16.Clean = value; _floodInsuranceEscrowed = v16;
                var v17 = _floodReplacementValue; v17.Clean = value; _floodReplacementValue = v17;
                var v18 = _hazardDescription1; v18.Clean = value; _hazardDescription1 = v18;
                var v19 = _hazardDescription2; v19.Clean = value; _hazardDescription2 = v19;
                var v20 = _hazardDescription3; v20.Clean = value; _hazardDescription3 = v20;
                var v21 = _hazardInsuranceEscrowed; v21.Clean = value; _hazardInsuranceEscrowed = v21;
                var v22 = _hazardReplacementValue; v22.Clean = value; _hazardReplacementValue = v22;
                var v23 = _id; v23.Clean = value; _id = v23;
                var v24 = _maximumDeductibleFloodAmount; v24.Clean = value; _maximumDeductibleFloodAmount = v24;
                var v25 = _maximumDeductibleFloodPercentage; v25.Clean = value; _maximumDeductibleFloodPercentage = v25;
                var v26 = _maximumDeductibleHazardAmount; v26.Clean = value; _maximumDeductibleHazardAmount = v26;
                var v27 = _maximumDeductibleHazardPercentage; v27.Clean = value; _maximumDeductibleHazardPercentage = v27;
                var v28 = _titleContract; v28.Clean = value; _titleContract = v28;
                var v29 = _titleDescription1; v29.Clean = value; _titleDescription1 = v29;
                var v30 = _titleDescription2; v30.Clean = value; _titleDescription2 = v30;
                var v31 = _titleDescription3; v31.Clean = value; _titleDescription3 = v31;
                var v32 = _titleInsRequirements; v32.Clean = value; _titleInsRequirements = v32;
                var v33 = _titleMailAway; v33.Clean = value; _titleMailAway = v33;
                var v34 = _titlePriorTitlePolicy; v34.Clean = value; _titlePriorTitlePolicy = v34;
                var v35 = _titleSurvey; v35.Clean = value; _titleSurvey = v35;
                var v36 = _titleTypeOfProperty; v36.Clean = value; _titleTypeOfProperty = v36;
                var v37 = _titleWarrantyDeed; v37.Clean = value; _titleWarrantyDeed = v37;
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