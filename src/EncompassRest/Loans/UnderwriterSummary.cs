using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwriterSummary
    {
        public Value<string> Appraisal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisal() => !Appraisal.Clean;
        public Value<DateTime?> AppraisalCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalCompletedDate() => !AppraisalCompletedDate.Clean;
        public Value<DateTime?> AppraisalExpiredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalExpiredDate() => !AppraisalExpiredDate.Clean;
        public Value<DateTime?> AppraisalOrderedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalOrderedDate() => !AppraisalOrderedDate.Clean;
        public Value<string> AppraisalType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalType() => !AppraisalType.Clean;
        public Value<DateTime?> ApprovalExpiredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovalExpiredDate() => !ApprovalExpiredDate.Clean;
        public Value<string> ApprovedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovedBy() => !ApprovedBy.Clean;
        public Value<DateTime?> ApprovedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovedDate() => !ApprovedDate.Clean;
        public Value<string> AusNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAusNumber() => !AusNumber.Clean;
        public Value<DateTime?> AusRunDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAusRunDate() => !AusRunDate.Clean;
        public Value<string> AusSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAusSource() => !AusSource.Clean;
        public Value<bool?> BenefitRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBenefitRequiredIndicator() => !BenefitRequiredIndicator.Clean;
        public Value<DateTime?> ClearToCloseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClearToCloseDate() => !ClearToCloseDate.Clean;
        public Value<string> Concerns { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConcerns() => !Concerns.Clean;
        public Value<string> Conditions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditions() => !Conditions.Clean;
        public Value<string> Credit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCredit() => !Credit.Clean;
        public Value<DateTime?> CreditApprovalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditApprovalDate() => !CreditApprovalDate.Clean;
        public Value<string> DeniedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedBy() => !DeniedBy.Clean;
        public Value<DateTime?> DeniedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedDate() => !DeniedDate.Clean;
        public Value<DateTime?> DifferentApprovalExpiredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDifferentApprovalExpiredDate() => !DifferentApprovalExpiredDate.Clean;
        public Value<string> DifferentApprovedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDifferentApprovedBy() => !DifferentApprovedBy.Clean;
        public Value<DateTime?> DifferentApprovedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDifferentApprovedDate() => !DifferentApprovedDate.Clean;
        public Value<string> Exceptions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExceptions() => !Exceptions.Clean;
        public Value<string> ExceptionSignOffBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExceptionSignOffBy() => !ExceptionSignOffBy.Clean;
        public Value<DateTime?> ExceptionSignOffDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExceptionSignOffDate() => !ExceptionSignOffDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsAgencyManually { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsAgencyManually() => !IsAgencyManually.Clean;
        public Value<bool?> IsAgencyWaiver { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsAgencyWaiver() => !IsAgencyWaiver.Clean;
        public Value<bool?> IsAgencyWithAgreement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsAgencyWithAgreement() => !IsAgencyWithAgreement.Clean;
        public Value<decimal?> MaxRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxRate() => !MaxRate.Clean;
        public Value<DateTime?> MiOrderedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiOrderedDate() => !MiOrderedDate.Clean;
        public Value<DateTime?> MiReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiReceivedDate() => !MiReceivedDate.Clean;
        public Value<decimal?> ModifiedLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedLoanAmount() => !ModifiedLoanAmount.Clean;
        public Value<decimal?> ModifiedLoanRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedLoanRate() => !ModifiedLoanRate.Clean;
        public Value<int?> ModifiedLoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedLoanTerm() => !ModifiedLoanTerm.Clean;
        public Value<decimal?> ModifiedLtv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedLtv() => !ModifiedLtv.Clean;
        public Value<decimal?> ModifiedMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedMonthlyPayment() => !ModifiedMonthlyPayment.Clean;
        public Value<string> OriginalAppraiser { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalAppraiser() => !OriginalAppraiser.Clean;
        public Value<decimal?> OriginalAppraisersValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalAppraisersValue() => !OriginalAppraisersValue.Clean;
        public Value<DateTime?> ResubmittedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResubmittedDate() => !ResubmittedDate.Clean;
        public Value<string> ReviewAppraiser { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewAppraiser() => !ReviewAppraiser.Clean;
        public Value<DateTime?> ReviewCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewCompletedDate() => !ReviewCompletedDate.Clean;
        public Value<DateTime?> ReviewRequestedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewRequestedDate() => !ReviewRequestedDate.Clean;
        public Value<string> ReviewType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewType() => !ReviewType.Clean;
        public Value<decimal?> ReviewValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewValue() => !ReviewValue.Clean;
        public Value<DateTime?> SentToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSentToDate() => !SentToDate.Clean;
        public Value<string> SignOffBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignOffBy() => !SignOffBy.Clean;
        public Value<DateTime?> SignOffDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignOffDate() => !SignOffDate.Clean;
        public Value<string> Strengths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStrengths() => !Strengths.Clean;
        public Value<DateTime?> SubmittedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittedDate() => !SubmittedDate.Clean;
        public Value<string> SupervisoryAppraiserLicenseNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSupervisoryAppraiserLicenseNumber() => !SupervisoryAppraiserLicenseNumber.Clean;
        public Value<string> SuspendedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuspendedBy() => !SuspendedBy.Clean;
        public Value<DateTime?> SuspendedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuspendedDate() => !SuspendedDate.Clean;
        public Value<string> SuspendedReasons { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuspendedReasons() => !SuspendedReasons.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Appraisal.Clean
                    && AppraisalCompletedDate.Clean
                    && AppraisalExpiredDate.Clean
                    && AppraisalOrderedDate.Clean
                    && AppraisalType.Clean
                    && ApprovalExpiredDate.Clean
                    && ApprovedBy.Clean
                    && ApprovedDate.Clean
                    && AusNumber.Clean
                    && AusRunDate.Clean
                    && AusSource.Clean
                    && BenefitRequiredIndicator.Clean
                    && ClearToCloseDate.Clean
                    && Concerns.Clean
                    && Conditions.Clean
                    && Credit.Clean
                    && CreditApprovalDate.Clean
                    && DeniedBy.Clean
                    && DeniedDate.Clean
                    && DifferentApprovalExpiredDate.Clean
                    && DifferentApprovedBy.Clean
                    && DifferentApprovedDate.Clean
                    && Exceptions.Clean
                    && ExceptionSignOffBy.Clean
                    && ExceptionSignOffDate.Clean
                    && Id.Clean
                    && IsAgencyManually.Clean
                    && IsAgencyWaiver.Clean
                    && IsAgencyWithAgreement.Clean
                    && MaxRate.Clean
                    && MiOrderedDate.Clean
                    && MiReceivedDate.Clean
                    && ModifiedLoanAmount.Clean
                    && ModifiedLoanRate.Clean
                    && ModifiedLoanTerm.Clean
                    && ModifiedLtv.Clean
                    && ModifiedMonthlyPayment.Clean
                    && OriginalAppraiser.Clean
                    && OriginalAppraisersValue.Clean
                    && ResubmittedDate.Clean
                    && ReviewAppraiser.Clean
                    && ReviewCompletedDate.Clean
                    && ReviewRequestedDate.Clean
                    && ReviewType.Clean
                    && ReviewValue.Clean
                    && SentToDate.Clean
                    && SignOffBy.Clean
                    && SignOffDate.Clean
                    && Strengths.Clean
                    && SubmittedDate.Clean
                    && SupervisoryAppraiserLicenseNumber.Clean
                    && SuspendedBy.Clean
                    && SuspendedDate.Clean
                    && SuspendedReasons.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Appraisal; v0.Clean = value; Appraisal = v0;
                var v1 = AppraisalCompletedDate; v1.Clean = value; AppraisalCompletedDate = v1;
                var v2 = AppraisalExpiredDate; v2.Clean = value; AppraisalExpiredDate = v2;
                var v3 = AppraisalOrderedDate; v3.Clean = value; AppraisalOrderedDate = v3;
                var v4 = AppraisalType; v4.Clean = value; AppraisalType = v4;
                var v5 = ApprovalExpiredDate; v5.Clean = value; ApprovalExpiredDate = v5;
                var v6 = ApprovedBy; v6.Clean = value; ApprovedBy = v6;
                var v7 = ApprovedDate; v7.Clean = value; ApprovedDate = v7;
                var v8 = AusNumber; v8.Clean = value; AusNumber = v8;
                var v9 = AusRunDate; v9.Clean = value; AusRunDate = v9;
                var v10 = AusSource; v10.Clean = value; AusSource = v10;
                var v11 = BenefitRequiredIndicator; v11.Clean = value; BenefitRequiredIndicator = v11;
                var v12 = ClearToCloseDate; v12.Clean = value; ClearToCloseDate = v12;
                var v13 = Concerns; v13.Clean = value; Concerns = v13;
                var v14 = Conditions; v14.Clean = value; Conditions = v14;
                var v15 = Credit; v15.Clean = value; Credit = v15;
                var v16 = CreditApprovalDate; v16.Clean = value; CreditApprovalDate = v16;
                var v17 = DeniedBy; v17.Clean = value; DeniedBy = v17;
                var v18 = DeniedDate; v18.Clean = value; DeniedDate = v18;
                var v19 = DifferentApprovalExpiredDate; v19.Clean = value; DifferentApprovalExpiredDate = v19;
                var v20 = DifferentApprovedBy; v20.Clean = value; DifferentApprovedBy = v20;
                var v21 = DifferentApprovedDate; v21.Clean = value; DifferentApprovedDate = v21;
                var v22 = Exceptions; v22.Clean = value; Exceptions = v22;
                var v23 = ExceptionSignOffBy; v23.Clean = value; ExceptionSignOffBy = v23;
                var v24 = ExceptionSignOffDate; v24.Clean = value; ExceptionSignOffDate = v24;
                var v25 = Id; v25.Clean = value; Id = v25;
                var v26 = IsAgencyManually; v26.Clean = value; IsAgencyManually = v26;
                var v27 = IsAgencyWaiver; v27.Clean = value; IsAgencyWaiver = v27;
                var v28 = IsAgencyWithAgreement; v28.Clean = value; IsAgencyWithAgreement = v28;
                var v29 = MaxRate; v29.Clean = value; MaxRate = v29;
                var v30 = MiOrderedDate; v30.Clean = value; MiOrderedDate = v30;
                var v31 = MiReceivedDate; v31.Clean = value; MiReceivedDate = v31;
                var v32 = ModifiedLoanAmount; v32.Clean = value; ModifiedLoanAmount = v32;
                var v33 = ModifiedLoanRate; v33.Clean = value; ModifiedLoanRate = v33;
                var v34 = ModifiedLoanTerm; v34.Clean = value; ModifiedLoanTerm = v34;
                var v35 = ModifiedLtv; v35.Clean = value; ModifiedLtv = v35;
                var v36 = ModifiedMonthlyPayment; v36.Clean = value; ModifiedMonthlyPayment = v36;
                var v37 = OriginalAppraiser; v37.Clean = value; OriginalAppraiser = v37;
                var v38 = OriginalAppraisersValue; v38.Clean = value; OriginalAppraisersValue = v38;
                var v39 = ResubmittedDate; v39.Clean = value; ResubmittedDate = v39;
                var v40 = ReviewAppraiser; v40.Clean = value; ReviewAppraiser = v40;
                var v41 = ReviewCompletedDate; v41.Clean = value; ReviewCompletedDate = v41;
                var v42 = ReviewRequestedDate; v42.Clean = value; ReviewRequestedDate = v42;
                var v43 = ReviewType; v43.Clean = value; ReviewType = v43;
                var v44 = ReviewValue; v44.Clean = value; ReviewValue = v44;
                var v45 = SentToDate; v45.Clean = value; SentToDate = v45;
                var v46 = SignOffBy; v46.Clean = value; SignOffBy = v46;
                var v47 = SignOffDate; v47.Clean = value; SignOffDate = v47;
                var v48 = Strengths; v48.Clean = value; Strengths = v48;
                var v49 = SubmittedDate; v49.Clean = value; SubmittedDate = v49;
                var v50 = SupervisoryAppraiserLicenseNumber; v50.Clean = value; SupervisoryAppraiserLicenseNumber = v50;
                var v51 = SuspendedBy; v51.Clean = value; SuspendedBy = v51;
                var v52 = SuspendedDate; v52.Clean = value; SuspendedDate = v52;
                var v53 = SuspendedReasons; v53.Clean = value; SuspendedReasons = v53;
                _settingClean = 0;
            }
        }
    }
}