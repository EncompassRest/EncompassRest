using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Liability
    {
        public Value<string> AccountIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountIdentifier() => !AccountIdentifier.Clean;
        public Value<bool?> AccountIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountIndicator() => !AccountIndicator.Clean;
        public Value<string> Attention { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttention() => !Attention.Clean;
        public Value<DateTime?> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> DescriptionOfPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionOfPurpose() => !DescriptionOfPurpose.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<bool?> ExclusionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExclusionIndicator() => !ExclusionIndicator.Clean;
        public Value<string> HolderAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressCity() => !HolderAddressCity.Clean;
        public Value<string> HolderAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressPostalCode() => !HolderAddressPostalCode.Clean;
        public Value<string> HolderAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressState() => !HolderAddressState.Clean;
        public Value<string> HolderAddressStreetLine1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressStreetLine1() => !HolderAddressStreetLine1.Clean;
        public Value<string> HolderComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderComments() => !HolderComments.Clean;
        public Value<string> HolderEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderEmail() => !HolderEmail.Clean;
        public Value<string> HolderFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderFax() => !HolderFax.Clean;
        public Value<string> HolderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderName() => !HolderName.Clean;
        public Value<string> HolderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderPhone() => !HolderPhone.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsDebtNotSecuredToSubjectPropertyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDebtNotSecuredToSubjectPropertyIndicator() => !IsDebtNotSecuredToSubjectPropertyIndicator.Clean;
        public Value<int?> Lates12Month120Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month120Day() => !Lates12Month120Day.Clean;
        public Value<int?> Lates12Month150Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month150Day() => !Lates12Month150Day.Clean;
        public Value<int?> Lates12Month30Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month30Day() => !Lates12Month30Day.Clean;
        public Value<int?> Lates12Month60Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month60Day() => !Lates12Month60Day.Clean;
        public Value<int?> Lates12Month90Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month90Day() => !Lates12Month90Day.Clean;
        public Value<int?> Lates24Month120Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month120Day() => !Lates24Month120Day.Clean;
        public Value<int?> Lates24Month150Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month150Day() => !Lates24Month150Day.Clean;
        public Value<int?> Lates24Month30Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month30Day() => !Lates24Month30Day.Clean;
        public Value<int?> Lates24Month60Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month60Day() => !Lates24Month60Day.Clean;
        public Value<int?> Lates24Month90Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month90Day() => !Lates24Month90Day.Clean;
        public Value<int?> Lates25Month120Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month120Day() => !Lates25Month120Day.Clean;
        public Value<int?> Lates25Month150Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month150Day() => !Lates25Month150Day.Clean;
        public Value<int?> Lates25Month30Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month30Day() => !Lates25Month30Day.Clean;
        public Value<int?> Lates25Month60Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month60Day() => !Lates25Month60Day.Clean;
        public Value<int?> Lates25Month90Day { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month90Day() => !Lates25Month90Day.Clean;
        public Value<int?> LiabilityIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityIndex() => !LiabilityIndex.Clean;
        public Value<string> LiabilityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityType() => !LiabilityType.Clean;
        public Value<decimal?> MonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentAmount() => !MonthlyPaymentAmount.Clean;
        public Value<int?> MonthsToExclude { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthsToExclude() => !MonthsToExclude.Clean;
        public Value<string> NameInAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameInAccount() => !NameInAccount.Clean;
        public Value<bool?> NoLinkToDocTrackIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !NoLinkToDocTrackIndicator.Clean;
        public Value<string> Owner { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !Owner.Clean;
        public Value<bool?> PayoffIncludedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIncludedIndicator() => !PayoffIncludedIndicator.Clean;
        public Value<bool?> PayoffStatusIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffStatusIndicator() => !PayoffStatusIndicator.Clean;
        public Value<decimal?> PrepaymentPenaltyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyAmount() => !PrepaymentPenaltyAmount.Clean;
        public Value<bool?> PrintAttachmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !PrintAttachmentIndicator.Clean;
        public Value<bool?> PrintUserNameIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !PrintUserNameIndicator.Clean;
        public Value<int?> RemainingTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingTermMonths() => !RemainingTermMonths.Clean;
        public Value<string> ReoId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoId() => !ReoId.Clean;
        public Value<string> RequestId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestId() => !RequestId.Clean;
        public Value<bool?> SubjectLoanResubordinationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectLoanResubordinationIndicator() => !SubjectLoanResubordinationIndicator.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !TitleFax.Clean;
        public Value<string> TitlePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !TitlePhone.Clean;
        public Value<decimal?> ToBePaidOffAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeToBePaidOffAmount() => !ToBePaidOffAmount.Clean;
        public Value<string> UCDPayoffType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDPayoffType() => !UCDPayoffType.Clean;
        public Value<decimal?> UnpaidBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidBalanceAmount() => !UnpaidBalanceAmount.Clean;
        public Value<int?> VolIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVolIndex() => !VolIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccountIdentifier.Clean
                    && AccountIndicator.Clean
                    && Attention.Clean
                    && Date.Clean
                    && Description.Clean
                    && DescriptionOfPurpose.Clean
                    && EntityDeleted.Clean
                    && ExclusionIndicator.Clean
                    && HolderAddressCity.Clean
                    && HolderAddressPostalCode.Clean
                    && HolderAddressState.Clean
                    && HolderAddressStreetLine1.Clean
                    && HolderComments.Clean
                    && HolderEmail.Clean
                    && HolderFax.Clean
                    && HolderName.Clean
                    && HolderPhone.Clean
                    && Id.Clean
                    && IsDebtNotSecuredToSubjectPropertyIndicator.Clean
                    && Lates12Month120Day.Clean
                    && Lates12Month150Day.Clean
                    && Lates12Month30Day.Clean
                    && Lates12Month60Day.Clean
                    && Lates12Month90Day.Clean
                    && Lates24Month120Day.Clean
                    && Lates24Month150Day.Clean
                    && Lates24Month30Day.Clean
                    && Lates24Month60Day.Clean
                    && Lates24Month90Day.Clean
                    && Lates25Month120Day.Clean
                    && Lates25Month150Day.Clean
                    && Lates25Month30Day.Clean
                    && Lates25Month60Day.Clean
                    && Lates25Month90Day.Clean
                    && LiabilityIndex.Clean
                    && LiabilityType.Clean
                    && MonthlyPaymentAmount.Clean
                    && MonthsToExclude.Clean
                    && NameInAccount.Clean
                    && NoLinkToDocTrackIndicator.Clean
                    && Owner.Clean
                    && PayoffIncludedIndicator.Clean
                    && PayoffStatusIndicator.Clean
                    && PrepaymentPenaltyAmount.Clean
                    && PrintAttachmentIndicator.Clean
                    && PrintUserNameIndicator.Clean
                    && RemainingTermMonths.Clean
                    && ReoId.Clean
                    && RequestId.Clean
                    && SubjectLoanResubordinationIndicator.Clean
                    && Title.Clean
                    && TitleFax.Clean
                    && TitlePhone.Clean
                    && ToBePaidOffAmount.Clean
                    && UCDPayoffType.Clean
                    && UnpaidBalanceAmount.Clean
                    && VolIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountIdentifier; v0.Clean = value; AccountIdentifier = v0;
                var v1 = AccountIndicator; v1.Clean = value; AccountIndicator = v1;
                var v2 = Attention; v2.Clean = value; Attention = v2;
                var v3 = Date; v3.Clean = value; Date = v3;
                var v4 = Description; v4.Clean = value; Description = v4;
                var v5 = DescriptionOfPurpose; v5.Clean = value; DescriptionOfPurpose = v5;
                var v6 = EntityDeleted; v6.Clean = value; EntityDeleted = v6;
                var v7 = ExclusionIndicator; v7.Clean = value; ExclusionIndicator = v7;
                var v8 = HolderAddressCity; v8.Clean = value; HolderAddressCity = v8;
                var v9 = HolderAddressPostalCode; v9.Clean = value; HolderAddressPostalCode = v9;
                var v10 = HolderAddressState; v10.Clean = value; HolderAddressState = v10;
                var v11 = HolderAddressStreetLine1; v11.Clean = value; HolderAddressStreetLine1 = v11;
                var v12 = HolderComments; v12.Clean = value; HolderComments = v12;
                var v13 = HolderEmail; v13.Clean = value; HolderEmail = v13;
                var v14 = HolderFax; v14.Clean = value; HolderFax = v14;
                var v15 = HolderName; v15.Clean = value; HolderName = v15;
                var v16 = HolderPhone; v16.Clean = value; HolderPhone = v16;
                var v17 = Id; v17.Clean = value; Id = v17;
                var v18 = IsDebtNotSecuredToSubjectPropertyIndicator; v18.Clean = value; IsDebtNotSecuredToSubjectPropertyIndicator = v18;
                var v19 = Lates12Month120Day; v19.Clean = value; Lates12Month120Day = v19;
                var v20 = Lates12Month150Day; v20.Clean = value; Lates12Month150Day = v20;
                var v21 = Lates12Month30Day; v21.Clean = value; Lates12Month30Day = v21;
                var v22 = Lates12Month60Day; v22.Clean = value; Lates12Month60Day = v22;
                var v23 = Lates12Month90Day; v23.Clean = value; Lates12Month90Day = v23;
                var v24 = Lates24Month120Day; v24.Clean = value; Lates24Month120Day = v24;
                var v25 = Lates24Month150Day; v25.Clean = value; Lates24Month150Day = v25;
                var v26 = Lates24Month30Day; v26.Clean = value; Lates24Month30Day = v26;
                var v27 = Lates24Month60Day; v27.Clean = value; Lates24Month60Day = v27;
                var v28 = Lates24Month90Day; v28.Clean = value; Lates24Month90Day = v28;
                var v29 = Lates25Month120Day; v29.Clean = value; Lates25Month120Day = v29;
                var v30 = Lates25Month150Day; v30.Clean = value; Lates25Month150Day = v30;
                var v31 = Lates25Month30Day; v31.Clean = value; Lates25Month30Day = v31;
                var v32 = Lates25Month60Day; v32.Clean = value; Lates25Month60Day = v32;
                var v33 = Lates25Month90Day; v33.Clean = value; Lates25Month90Day = v33;
                var v34 = LiabilityIndex; v34.Clean = value; LiabilityIndex = v34;
                var v35 = LiabilityType; v35.Clean = value; LiabilityType = v35;
                var v36 = MonthlyPaymentAmount; v36.Clean = value; MonthlyPaymentAmount = v36;
                var v37 = MonthsToExclude; v37.Clean = value; MonthsToExclude = v37;
                var v38 = NameInAccount; v38.Clean = value; NameInAccount = v38;
                var v39 = NoLinkToDocTrackIndicator; v39.Clean = value; NoLinkToDocTrackIndicator = v39;
                var v40 = Owner; v40.Clean = value; Owner = v40;
                var v41 = PayoffIncludedIndicator; v41.Clean = value; PayoffIncludedIndicator = v41;
                var v42 = PayoffStatusIndicator; v42.Clean = value; PayoffStatusIndicator = v42;
                var v43 = PrepaymentPenaltyAmount; v43.Clean = value; PrepaymentPenaltyAmount = v43;
                var v44 = PrintAttachmentIndicator; v44.Clean = value; PrintAttachmentIndicator = v44;
                var v45 = PrintUserNameIndicator; v45.Clean = value; PrintUserNameIndicator = v45;
                var v46 = RemainingTermMonths; v46.Clean = value; RemainingTermMonths = v46;
                var v47 = ReoId; v47.Clean = value; ReoId = v47;
                var v48 = RequestId; v48.Clean = value; RequestId = v48;
                var v49 = SubjectLoanResubordinationIndicator; v49.Clean = value; SubjectLoanResubordinationIndicator = v49;
                var v50 = Title; v50.Clean = value; Title = v50;
                var v51 = TitleFax; v51.Clean = value; TitleFax = v51;
                var v52 = TitlePhone; v52.Clean = value; TitlePhone = v52;
                var v53 = ToBePaidOffAmount; v53.Clean = value; ToBePaidOffAmount = v53;
                var v54 = UCDPayoffType; v54.Clean = value; UCDPayoffType = v54;
                var v55 = UnpaidBalanceAmount; v55.Clean = value; UnpaidBalanceAmount = v55;
                var v56 = VolIndex; v56.Clean = value; VolIndex = v56;
                _settingClean = 0;
            }
        }
    }
}