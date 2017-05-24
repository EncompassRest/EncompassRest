using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalRequests
    {
        public Value<string> AppraisalContactCellPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactCellPhone() => !AppraisalContactCellPhone.Clean;
        public Value<string> AppraisalContactEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactEmail() => !AppraisalContactEmail.Clean;
        public Value<string> AppraisalContactForEntry { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactForEntry() => !AppraisalContactForEntry.Clean;
        public Value<string> AppraisalContactHomePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactHomePhone() => !AppraisalContactHomePhone.Clean;
        public Value<string> AppraisalContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactName() => !AppraisalContactName.Clean;
        public Value<string> AppraisalContactWorkPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContactWorkPhone() => !AppraisalContactWorkPhone.Clean;
        public Value<DateTime?> AppraisalDateOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDateOrdered() => !AppraisalDateOrdered.Clean;
        public Value<string> AppraisalDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDescription1() => !AppraisalDescription1.Clean;
        public Value<string> AppraisalDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDescription2() => !AppraisalDescription2.Clean;
        public Value<string> AppraisalDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDescription3() => !AppraisalDescription3.Clean;
        public Value<bool?> AppraisalKeyPickUp { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalKeyPickUp() => !AppraisalKeyPickUp.Clean;
        public Value<bool?> AppraisalLockBox { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalLockBox() => !AppraisalLockBox.Clean;
        public Value<bool?> AppraisalVacant { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalVacant() => !AppraisalVacant.Clean;
        public Value<string> FloodDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodDescription1() => !FloodDescription1.Clean;
        public Value<string> FloodDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodDescription2() => !FloodDescription2.Clean;
        public Value<string> FloodDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodDescription3() => !FloodDescription3.Clean;
        public Value<bool?> FloodInsuranceEscrowed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsuranceEscrowed() => !FloodInsuranceEscrowed.Clean;
        public Value<string> FloodReplacementValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodReplacementValue() => !FloodReplacementValue.Clean;
        public Value<string> HazardDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardDescription1() => !HazardDescription1.Clean;
        public Value<string> HazardDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardDescription2() => !HazardDescription2.Clean;
        public Value<string> HazardDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardDescription3() => !HazardDescription3.Clean;
        public Value<bool?> HazardInsuranceEscrowed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardInsuranceEscrowed() => !HazardInsuranceEscrowed.Clean;
        public Value<string> HazardReplacementValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardReplacementValue() => !HazardReplacementValue.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> MaximumDeductibleFloodAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDeductibleFloodAmount() => !MaximumDeductibleFloodAmount.Clean;
        public Value<decimal?> MaximumDeductibleFloodPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDeductibleFloodPercentage() => !MaximumDeductibleFloodPercentage.Clean;
        public Value<decimal?> MaximumDeductibleHazardAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDeductibleHazardAmount() => !MaximumDeductibleHazardAmount.Clean;
        public Value<decimal?> MaximumDeductibleHazardPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDeductibleHazardPercentage() => !MaximumDeductibleHazardPercentage.Clean;
        public Value<bool?> TitleContract { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleContract() => !TitleContract.Clean;
        public Value<string> TitleDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleDescription1() => !TitleDescription1.Clean;
        public Value<string> TitleDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleDescription2() => !TitleDescription2.Clean;
        public Value<string> TitleDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleDescription3() => !TitleDescription3.Clean;
        public Value<bool?> TitleInsRequirements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleInsRequirements() => !TitleInsRequirements.Clean;
        public Value<bool?> TitleMailAway { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleMailAway() => !TitleMailAway.Clean;
        public Value<bool?> TitlePriorTitlePolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePriorTitlePolicy() => !TitlePriorTitlePolicy.Clean;
        public Value<bool?> TitleSurvey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleSurvey() => !TitleSurvey.Clean;
        public Value<string> TitleTypeOfProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleTypeOfProperty() => !TitleTypeOfProperty.Clean;
        public Value<bool?> TitleWarrantyDeed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleWarrantyDeed() => !TitleWarrantyDeed.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AppraisalContactCellPhone.Clean
                    && AppraisalContactEmail.Clean
                    && AppraisalContactForEntry.Clean
                    && AppraisalContactHomePhone.Clean
                    && AppraisalContactName.Clean
                    && AppraisalContactWorkPhone.Clean
                    && AppraisalDateOrdered.Clean
                    && AppraisalDescription1.Clean
                    && AppraisalDescription2.Clean
                    && AppraisalDescription3.Clean
                    && AppraisalKeyPickUp.Clean
                    && AppraisalLockBox.Clean
                    && AppraisalVacant.Clean
                    && FloodDescription1.Clean
                    && FloodDescription2.Clean
                    && FloodDescription3.Clean
                    && FloodInsuranceEscrowed.Clean
                    && FloodReplacementValue.Clean
                    && HazardDescription1.Clean
                    && HazardDescription2.Clean
                    && HazardDescription3.Clean
                    && HazardInsuranceEscrowed.Clean
                    && HazardReplacementValue.Clean
                    && Id.Clean
                    && MaximumDeductibleFloodAmount.Clean
                    && MaximumDeductibleFloodPercentage.Clean
                    && MaximumDeductibleHazardAmount.Clean
                    && MaximumDeductibleHazardPercentage.Clean
                    && TitleContract.Clean
                    && TitleDescription1.Clean
                    && TitleDescription2.Clean
                    && TitleDescription3.Clean
                    && TitleInsRequirements.Clean
                    && TitleMailAway.Clean
                    && TitlePriorTitlePolicy.Clean
                    && TitleSurvey.Clean
                    && TitleTypeOfProperty.Clean
                    && TitleWarrantyDeed.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AppraisalContactCellPhone; v0.Clean = value; AppraisalContactCellPhone = v0;
                var v1 = AppraisalContactEmail; v1.Clean = value; AppraisalContactEmail = v1;
                var v2 = AppraisalContactForEntry; v2.Clean = value; AppraisalContactForEntry = v2;
                var v3 = AppraisalContactHomePhone; v3.Clean = value; AppraisalContactHomePhone = v3;
                var v4 = AppraisalContactName; v4.Clean = value; AppraisalContactName = v4;
                var v5 = AppraisalContactWorkPhone; v5.Clean = value; AppraisalContactWorkPhone = v5;
                var v6 = AppraisalDateOrdered; v6.Clean = value; AppraisalDateOrdered = v6;
                var v7 = AppraisalDescription1; v7.Clean = value; AppraisalDescription1 = v7;
                var v8 = AppraisalDescription2; v8.Clean = value; AppraisalDescription2 = v8;
                var v9 = AppraisalDescription3; v9.Clean = value; AppraisalDescription3 = v9;
                var v10 = AppraisalKeyPickUp; v10.Clean = value; AppraisalKeyPickUp = v10;
                var v11 = AppraisalLockBox; v11.Clean = value; AppraisalLockBox = v11;
                var v12 = AppraisalVacant; v12.Clean = value; AppraisalVacant = v12;
                var v13 = FloodDescription1; v13.Clean = value; FloodDescription1 = v13;
                var v14 = FloodDescription2; v14.Clean = value; FloodDescription2 = v14;
                var v15 = FloodDescription3; v15.Clean = value; FloodDescription3 = v15;
                var v16 = FloodInsuranceEscrowed; v16.Clean = value; FloodInsuranceEscrowed = v16;
                var v17 = FloodReplacementValue; v17.Clean = value; FloodReplacementValue = v17;
                var v18 = HazardDescription1; v18.Clean = value; HazardDescription1 = v18;
                var v19 = HazardDescription2; v19.Clean = value; HazardDescription2 = v19;
                var v20 = HazardDescription3; v20.Clean = value; HazardDescription3 = v20;
                var v21 = HazardInsuranceEscrowed; v21.Clean = value; HazardInsuranceEscrowed = v21;
                var v22 = HazardReplacementValue; v22.Clean = value; HazardReplacementValue = v22;
                var v23 = Id; v23.Clean = value; Id = v23;
                var v24 = MaximumDeductibleFloodAmount; v24.Clean = value; MaximumDeductibleFloodAmount = v24;
                var v25 = MaximumDeductibleFloodPercentage; v25.Clean = value; MaximumDeductibleFloodPercentage = v25;
                var v26 = MaximumDeductibleHazardAmount; v26.Clean = value; MaximumDeductibleHazardAmount = v26;
                var v27 = MaximumDeductibleHazardPercentage; v27.Clean = value; MaximumDeductibleHazardPercentage = v27;
                var v28 = TitleContract; v28.Clean = value; TitleContract = v28;
                var v29 = TitleDescription1; v29.Clean = value; TitleDescription1 = v29;
                var v30 = TitleDescription2; v30.Clean = value; TitleDescription2 = v30;
                var v31 = TitleDescription3; v31.Clean = value; TitleDescription3 = v31;
                var v32 = TitleInsRequirements; v32.Clean = value; TitleInsRequirements = v32;
                var v33 = TitleMailAway; v33.Clean = value; TitleMailAway = v33;
                var v34 = TitlePriorTitlePolicy; v34.Clean = value; TitlePriorTitlePolicy = v34;
                var v35 = TitleSurvey; v35.Clean = value; TitleSurvey = v35;
                var v36 = TitleTypeOfProperty; v36.Clean = value; TitleTypeOfProperty = v36;
                var v37 = TitleWarrantyDeed; v37.Clean = value; TitleWarrantyDeed = v37;
                _settingClean = 0;
            }
        }
    }
}