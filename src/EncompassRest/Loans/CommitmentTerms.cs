using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CommitmentTerms
    {
        public Value<DateTime?> ActionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActionDate() => !ActionDate.Clean;
        public Value<string> AdditionalConditions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalConditions() => !AdditionalConditions.Clean;
        public Value<string> AdditionalItems1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalItems1() => !AdditionalItems1.Clean;
        public Value<string> AdditionalItems2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalItems2() => !AdditionalItems2.Clean;
        public Value<string> AdditionalItems3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalItems3() => !AdditionalItems3.Clean;
        public Value<bool?> AppraisalDone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDone() => !AppraisalDone.Clean;
        public Value<decimal?> AssuranceOfCompletion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssuranceOfCompletion() => !AssuranceOfCompletion.Clean;
        public Value<DateTime?> CommitmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentDate() => !CommitmentDate.Clean;
        public Value<DateTime?> CommitmentExpired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentExpired() => !CommitmentExpired.Clean;
        public Value<DateTime?> CommitmentIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssued() => !CommitmentIssued.Clean;
        public Value<bool?> ConditionalCommitmentUnderActg { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionalCommitmentUnderActg() => !ConditionalCommitmentUnderActg.Clean;
        public Value<bool?> EligibleForHighLtv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEligibleForHighLtv() => !EligibleForHighLtv.Clean;
        public Value<int?> EstimatedRemainingYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedRemainingYears() => !EstimatedRemainingYears.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> ImprovedLivingAreas { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImprovedLivingAreas() => !ImprovedLivingAreas.Clean;
        public Value<bool?> ManufacturedHousing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHousing() => !ManufacturedHousing.Clean;
        public Value<decimal?> MaxInsurableMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxInsurableMortgage() => !MaxInsurableMortgage.Clean;
        public Value<string> MortgageeAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageeAddress() => !MortgageeAddress.Clean;
        public Value<string> MortgageeCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageeCity() => !MortgageeCity.Clean;
        public Value<string> MortgageeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageeName() => !MortgageeName.Clean;
        public Value<string> MortgageePostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageePostalCode() => !MortgageePostalCode.Clean;
        public Value<string> MortgageeState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageeState() => !MortgageeState.Clean;
        public Value<string> OtherMonthlyExpenseDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMonthlyExpenseDescription() => !OtherMonthlyExpenseDescription.Clean;
        public Value<DateTime?> ReportDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportDate() => !ReportDate.Clean;
        public Value<string> RequirementsNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequirementsNumber() => !RequirementsNumber.Clean;
        public Value<string> SubdivisionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubdivisionDescription() => !SubdivisionDescription.Clean;
        public Value<string> SubdivisionRequirements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubdivisionRequirements() => !SubdivisionRequirements.Clean;
        public Value<decimal?> TotalMonthlyExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyExpense() => !TotalMonthlyExpense.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActionDate.Clean
                    && AdditionalConditions.Clean
                    && AdditionalItems1.Clean
                    && AdditionalItems2.Clean
                    && AdditionalItems3.Clean
                    && AppraisalDone.Clean
                    && AssuranceOfCompletion.Clean
                    && CommitmentDate.Clean
                    && CommitmentExpired.Clean
                    && CommitmentIssued.Clean
                    && ConditionalCommitmentUnderActg.Clean
                    && EligibleForHighLtv.Clean
                    && EstimatedRemainingYears.Clean
                    && Id.Clean
                    && ImprovedLivingAreas.Clean
                    && ManufacturedHousing.Clean
                    && MaxInsurableMortgage.Clean
                    && MortgageeAddress.Clean
                    && MortgageeCity.Clean
                    && MortgageeName.Clean
                    && MortgageePostalCode.Clean
                    && MortgageeState.Clean
                    && OtherMonthlyExpenseDescription.Clean
                    && ReportDate.Clean
                    && RequirementsNumber.Clean
                    && SubdivisionDescription.Clean
                    && SubdivisionRequirements.Clean
                    && TotalMonthlyExpense.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActionDate; v0.Clean = value; ActionDate = v0;
                var v1 = AdditionalConditions; v1.Clean = value; AdditionalConditions = v1;
                var v2 = AdditionalItems1; v2.Clean = value; AdditionalItems1 = v2;
                var v3 = AdditionalItems2; v3.Clean = value; AdditionalItems2 = v3;
                var v4 = AdditionalItems3; v4.Clean = value; AdditionalItems3 = v4;
                var v5 = AppraisalDone; v5.Clean = value; AppraisalDone = v5;
                var v6 = AssuranceOfCompletion; v6.Clean = value; AssuranceOfCompletion = v6;
                var v7 = CommitmentDate; v7.Clean = value; CommitmentDate = v7;
                var v8 = CommitmentExpired; v8.Clean = value; CommitmentExpired = v8;
                var v9 = CommitmentIssued; v9.Clean = value; CommitmentIssued = v9;
                var v10 = ConditionalCommitmentUnderActg; v10.Clean = value; ConditionalCommitmentUnderActg = v10;
                var v11 = EligibleForHighLtv; v11.Clean = value; EligibleForHighLtv = v11;
                var v12 = EstimatedRemainingYears; v12.Clean = value; EstimatedRemainingYears = v12;
                var v13 = Id; v13.Clean = value; Id = v13;
                var v14 = ImprovedLivingAreas; v14.Clean = value; ImprovedLivingAreas = v14;
                var v15 = ManufacturedHousing; v15.Clean = value; ManufacturedHousing = v15;
                var v16 = MaxInsurableMortgage; v16.Clean = value; MaxInsurableMortgage = v16;
                var v17 = MortgageeAddress; v17.Clean = value; MortgageeAddress = v17;
                var v18 = MortgageeCity; v18.Clean = value; MortgageeCity = v18;
                var v19 = MortgageeName; v19.Clean = value; MortgageeName = v19;
                var v20 = MortgageePostalCode; v20.Clean = value; MortgageePostalCode = v20;
                var v21 = MortgageeState; v21.Clean = value; MortgageeState = v21;
                var v22 = OtherMonthlyExpenseDescription; v22.Clean = value; OtherMonthlyExpenseDescription = v22;
                var v23 = ReportDate; v23.Clean = value; ReportDate = v23;
                var v24 = RequirementsNumber; v24.Clean = value; RequirementsNumber = v24;
                var v25 = SubdivisionDescription; v25.Clean = value; SubdivisionDescription = v25;
                var v26 = SubdivisionRequirements; v26.Clean = value; SubdivisionRequirements = v26;
                var v27 = TotalMonthlyExpense; v27.Clean = value; TotalMonthlyExpense = v27;
                _settingClean = 0;
            }
        }
    }
}