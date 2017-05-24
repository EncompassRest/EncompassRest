using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Liability
    {
        private Value<string> _accountIdentifier;
        public string AccountIdentifier { get { return _accountIdentifier; } set { _accountIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountIdentifier() => !_accountIdentifier.Clean;
        private Value<bool?> _accountIndicator;
        public bool? AccountIndicator { get { return _accountIndicator; } set { _accountIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountIndicator() => !_accountIndicator.Clean;
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttention() => !_attention.Clean;
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !_date.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<string> _descriptionOfPurpose;
        public string DescriptionOfPurpose { get { return _descriptionOfPurpose; } set { _descriptionOfPurpose = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionOfPurpose() => !_descriptionOfPurpose.Clean;
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !_entityDeleted.Clean;
        private Value<bool?> _exclusionIndicator;
        public bool? ExclusionIndicator { get { return _exclusionIndicator; } set { _exclusionIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExclusionIndicator() => !_exclusionIndicator.Clean;
        private Value<string> _holderAddressCity;
        public string HolderAddressCity { get { return _holderAddressCity; } set { _holderAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressCity() => !_holderAddressCity.Clean;
        private Value<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get { return _holderAddressPostalCode; } set { _holderAddressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressPostalCode() => !_holderAddressPostalCode.Clean;
        private Value<string> _holderAddressState;
        public string HolderAddressState { get { return _holderAddressState; } set { _holderAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressState() => !_holderAddressState.Clean;
        private Value<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get { return _holderAddressStreetLine1; } set { _holderAddressStreetLine1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressStreetLine1() => !_holderAddressStreetLine1.Clean;
        private Value<string> _holderComments;
        public string HolderComments { get { return _holderComments; } set { _holderComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderComments() => !_holderComments.Clean;
        private Value<string> _holderEmail;
        public string HolderEmail { get { return _holderEmail; } set { _holderEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderEmail() => !_holderEmail.Clean;
        private Value<string> _holderFax;
        public string HolderFax { get { return _holderFax; } set { _holderFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderFax() => !_holderFax.Clean;
        private Value<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderName() => !_holderName.Clean;
        private Value<string> _holderPhone;
        public string HolderPhone { get { return _holderPhone; } set { _holderPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderPhone() => !_holderPhone.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isDebtNotSecuredToSubjectPropertyIndicator;
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get { return _isDebtNotSecuredToSubjectPropertyIndicator; } set { _isDebtNotSecuredToSubjectPropertyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDebtNotSecuredToSubjectPropertyIndicator() => !_isDebtNotSecuredToSubjectPropertyIndicator.Clean;
        private Value<int?> _lates12Month120Day;
        public int? Lates12Month120Day { get { return _lates12Month120Day; } set { _lates12Month120Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month120Day() => !_lates12Month120Day.Clean;
        private Value<int?> _lates12Month150Day;
        public int? Lates12Month150Day { get { return _lates12Month150Day; } set { _lates12Month150Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month150Day() => !_lates12Month150Day.Clean;
        private Value<int?> _lates12Month30Day;
        public int? Lates12Month30Day { get { return _lates12Month30Day; } set { _lates12Month30Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month30Day() => !_lates12Month30Day.Clean;
        private Value<int?> _lates12Month60Day;
        public int? Lates12Month60Day { get { return _lates12Month60Day; } set { _lates12Month60Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month60Day() => !_lates12Month60Day.Clean;
        private Value<int?> _lates12Month90Day;
        public int? Lates12Month90Day { get { return _lates12Month90Day; } set { _lates12Month90Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates12Month90Day() => !_lates12Month90Day.Clean;
        private Value<int?> _lates24Month120Day;
        public int? Lates24Month120Day { get { return _lates24Month120Day; } set { _lates24Month120Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month120Day() => !_lates24Month120Day.Clean;
        private Value<int?> _lates24Month150Day;
        public int? Lates24Month150Day { get { return _lates24Month150Day; } set { _lates24Month150Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month150Day() => !_lates24Month150Day.Clean;
        private Value<int?> _lates24Month30Day;
        public int? Lates24Month30Day { get { return _lates24Month30Day; } set { _lates24Month30Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month30Day() => !_lates24Month30Day.Clean;
        private Value<int?> _lates24Month60Day;
        public int? Lates24Month60Day { get { return _lates24Month60Day; } set { _lates24Month60Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month60Day() => !_lates24Month60Day.Clean;
        private Value<int?> _lates24Month90Day;
        public int? Lates24Month90Day { get { return _lates24Month90Day; } set { _lates24Month90Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates24Month90Day() => !_lates24Month90Day.Clean;
        private Value<int?> _lates25Month120Day;
        public int? Lates25Month120Day { get { return _lates25Month120Day; } set { _lates25Month120Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month120Day() => !_lates25Month120Day.Clean;
        private Value<int?> _lates25Month150Day;
        public int? Lates25Month150Day { get { return _lates25Month150Day; } set { _lates25Month150Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month150Day() => !_lates25Month150Day.Clean;
        private Value<int?> _lates25Month30Day;
        public int? Lates25Month30Day { get { return _lates25Month30Day; } set { _lates25Month30Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month30Day() => !_lates25Month30Day.Clean;
        private Value<int?> _lates25Month60Day;
        public int? Lates25Month60Day { get { return _lates25Month60Day; } set { _lates25Month60Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month60Day() => !_lates25Month60Day.Clean;
        private Value<int?> _lates25Month90Day;
        public int? Lates25Month90Day { get { return _lates25Month90Day; } set { _lates25Month90Day = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLates25Month90Day() => !_lates25Month90Day.Clean;
        private Value<int?> _liabilityIndex;
        public int? LiabilityIndex { get { return _liabilityIndex; } set { _liabilityIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityIndex() => !_liabilityIndex.Clean;
        private Value<string> _liabilityType;
        public string LiabilityType { get { return _liabilityType; } set { _liabilityType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityType() => !_liabilityType.Clean;
        private Value<decimal?> _monthlyPaymentAmount;
        public decimal? MonthlyPaymentAmount { get { return _monthlyPaymentAmount; } set { _monthlyPaymentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentAmount() => !_monthlyPaymentAmount.Clean;
        private Value<int?> _monthsToExclude;
        public int? MonthsToExclude { get { return _monthsToExclude; } set { _monthsToExclude = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthsToExclude() => !_monthsToExclude.Clean;
        private Value<string> _nameInAccount;
        public string NameInAccount { get { return _nameInAccount; } set { _nameInAccount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameInAccount() => !_nameInAccount.Clean;
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !_noLinkToDocTrackIndicator.Clean;
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !_owner.Clean;
        private Value<bool?> _payoffIncludedIndicator;
        public bool? PayoffIncludedIndicator { get { return _payoffIncludedIndicator; } set { _payoffIncludedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIncludedIndicator() => !_payoffIncludedIndicator.Clean;
        private Value<bool?> _payoffStatusIndicator;
        public bool? PayoffStatusIndicator { get { return _payoffStatusIndicator; } set { _payoffStatusIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffStatusIndicator() => !_payoffStatusIndicator.Clean;
        private Value<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get { return _prepaymentPenaltyAmount; } set { _prepaymentPenaltyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyAmount() => !_prepaymentPenaltyAmount.Clean;
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !_printAttachmentIndicator.Clean;
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !_printUserNameIndicator.Clean;
        private Value<int?> _remainingTermMonths;
        public int? RemainingTermMonths { get { return _remainingTermMonths; } set { _remainingTermMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingTermMonths() => !_remainingTermMonths.Clean;
        private Value<string> _reoId;
        public string ReoId { get { return _reoId; } set { _reoId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoId() => !_reoId.Clean;
        private Value<string> _requestId;
        public string RequestId { get { return _requestId; } set { _requestId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestId() => !_requestId.Clean;
        private Value<bool?> _subjectLoanResubordinationIndicator;
        public bool? SubjectLoanResubordinationIndicator { get { return _subjectLoanResubordinationIndicator; } set { _subjectLoanResubordinationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectLoanResubordinationIndicator() => !_subjectLoanResubordinationIndicator.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !_titleFax.Clean;
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !_titlePhone.Clean;
        private Value<decimal?> _toBePaidOffAmount;
        public decimal? ToBePaidOffAmount { get { return _toBePaidOffAmount; } set { _toBePaidOffAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeToBePaidOffAmount() => !_toBePaidOffAmount.Clean;
        private Value<string> _uCDPayoffType;
        public string UCDPayoffType { get { return _uCDPayoffType; } set { _uCDPayoffType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDPayoffType() => !_uCDPayoffType.Clean;
        private Value<decimal?> _unpaidBalanceAmount;
        public decimal? UnpaidBalanceAmount { get { return _unpaidBalanceAmount; } set { _unpaidBalanceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidBalanceAmount() => !_unpaidBalanceAmount.Clean;
        private Value<int?> _volIndex;
        public int? VolIndex { get { return _volIndex; } set { _volIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVolIndex() => !_volIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountIdentifier.Clean
                    && _accountIndicator.Clean
                    && _attention.Clean
                    && _date.Clean
                    && _description.Clean
                    && _descriptionOfPurpose.Clean
                    && _entityDeleted.Clean
                    && _exclusionIndicator.Clean
                    && _holderAddressCity.Clean
                    && _holderAddressPostalCode.Clean
                    && _holderAddressState.Clean
                    && _holderAddressStreetLine1.Clean
                    && _holderComments.Clean
                    && _holderEmail.Clean
                    && _holderFax.Clean
                    && _holderName.Clean
                    && _holderPhone.Clean
                    && _id.Clean
                    && _isDebtNotSecuredToSubjectPropertyIndicator.Clean
                    && _lates12Month120Day.Clean
                    && _lates12Month150Day.Clean
                    && _lates12Month30Day.Clean
                    && _lates12Month60Day.Clean
                    && _lates12Month90Day.Clean
                    && _lates24Month120Day.Clean
                    && _lates24Month150Day.Clean
                    && _lates24Month30Day.Clean
                    && _lates24Month60Day.Clean
                    && _lates24Month90Day.Clean
                    && _lates25Month120Day.Clean
                    && _lates25Month150Day.Clean
                    && _lates25Month30Day.Clean
                    && _lates25Month60Day.Clean
                    && _lates25Month90Day.Clean
                    && _liabilityIndex.Clean
                    && _liabilityType.Clean
                    && _monthlyPaymentAmount.Clean
                    && _monthsToExclude.Clean
                    && _nameInAccount.Clean
                    && _noLinkToDocTrackIndicator.Clean
                    && _owner.Clean
                    && _payoffIncludedIndicator.Clean
                    && _payoffStatusIndicator.Clean
                    && _prepaymentPenaltyAmount.Clean
                    && _printAttachmentIndicator.Clean
                    && _printUserNameIndicator.Clean
                    && _remainingTermMonths.Clean
                    && _reoId.Clean
                    && _requestId.Clean
                    && _subjectLoanResubordinationIndicator.Clean
                    && _title.Clean
                    && _titleFax.Clean
                    && _titlePhone.Clean
                    && _toBePaidOffAmount.Clean
                    && _uCDPayoffType.Clean
                    && _unpaidBalanceAmount.Clean
                    && _volIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _accountIdentifier; v0.Clean = value; _accountIdentifier = v0;
                var v1 = _accountIndicator; v1.Clean = value; _accountIndicator = v1;
                var v2 = _attention; v2.Clean = value; _attention = v2;
                var v3 = _date; v3.Clean = value; _date = v3;
                var v4 = _description; v4.Clean = value; _description = v4;
                var v5 = _descriptionOfPurpose; v5.Clean = value; _descriptionOfPurpose = v5;
                var v6 = _entityDeleted; v6.Clean = value; _entityDeleted = v6;
                var v7 = _exclusionIndicator; v7.Clean = value; _exclusionIndicator = v7;
                var v8 = _holderAddressCity; v8.Clean = value; _holderAddressCity = v8;
                var v9 = _holderAddressPostalCode; v9.Clean = value; _holderAddressPostalCode = v9;
                var v10 = _holderAddressState; v10.Clean = value; _holderAddressState = v10;
                var v11 = _holderAddressStreetLine1; v11.Clean = value; _holderAddressStreetLine1 = v11;
                var v12 = _holderComments; v12.Clean = value; _holderComments = v12;
                var v13 = _holderEmail; v13.Clean = value; _holderEmail = v13;
                var v14 = _holderFax; v14.Clean = value; _holderFax = v14;
                var v15 = _holderName; v15.Clean = value; _holderName = v15;
                var v16 = _holderPhone; v16.Clean = value; _holderPhone = v16;
                var v17 = _id; v17.Clean = value; _id = v17;
                var v18 = _isDebtNotSecuredToSubjectPropertyIndicator; v18.Clean = value; _isDebtNotSecuredToSubjectPropertyIndicator = v18;
                var v19 = _lates12Month120Day; v19.Clean = value; _lates12Month120Day = v19;
                var v20 = _lates12Month150Day; v20.Clean = value; _lates12Month150Day = v20;
                var v21 = _lates12Month30Day; v21.Clean = value; _lates12Month30Day = v21;
                var v22 = _lates12Month60Day; v22.Clean = value; _lates12Month60Day = v22;
                var v23 = _lates12Month90Day; v23.Clean = value; _lates12Month90Day = v23;
                var v24 = _lates24Month120Day; v24.Clean = value; _lates24Month120Day = v24;
                var v25 = _lates24Month150Day; v25.Clean = value; _lates24Month150Day = v25;
                var v26 = _lates24Month30Day; v26.Clean = value; _lates24Month30Day = v26;
                var v27 = _lates24Month60Day; v27.Clean = value; _lates24Month60Day = v27;
                var v28 = _lates24Month90Day; v28.Clean = value; _lates24Month90Day = v28;
                var v29 = _lates25Month120Day; v29.Clean = value; _lates25Month120Day = v29;
                var v30 = _lates25Month150Day; v30.Clean = value; _lates25Month150Day = v30;
                var v31 = _lates25Month30Day; v31.Clean = value; _lates25Month30Day = v31;
                var v32 = _lates25Month60Day; v32.Clean = value; _lates25Month60Day = v32;
                var v33 = _lates25Month90Day; v33.Clean = value; _lates25Month90Day = v33;
                var v34 = _liabilityIndex; v34.Clean = value; _liabilityIndex = v34;
                var v35 = _liabilityType; v35.Clean = value; _liabilityType = v35;
                var v36 = _monthlyPaymentAmount; v36.Clean = value; _monthlyPaymentAmount = v36;
                var v37 = _monthsToExclude; v37.Clean = value; _monthsToExclude = v37;
                var v38 = _nameInAccount; v38.Clean = value; _nameInAccount = v38;
                var v39 = _noLinkToDocTrackIndicator; v39.Clean = value; _noLinkToDocTrackIndicator = v39;
                var v40 = _owner; v40.Clean = value; _owner = v40;
                var v41 = _payoffIncludedIndicator; v41.Clean = value; _payoffIncludedIndicator = v41;
                var v42 = _payoffStatusIndicator; v42.Clean = value; _payoffStatusIndicator = v42;
                var v43 = _prepaymentPenaltyAmount; v43.Clean = value; _prepaymentPenaltyAmount = v43;
                var v44 = _printAttachmentIndicator; v44.Clean = value; _printAttachmentIndicator = v44;
                var v45 = _printUserNameIndicator; v45.Clean = value; _printUserNameIndicator = v45;
                var v46 = _remainingTermMonths; v46.Clean = value; _remainingTermMonths = v46;
                var v47 = _reoId; v47.Clean = value; _reoId = v47;
                var v48 = _requestId; v48.Clean = value; _requestId = v48;
                var v49 = _subjectLoanResubordinationIndicator; v49.Clean = value; _subjectLoanResubordinationIndicator = v49;
                var v50 = _title; v50.Clean = value; _title = v50;
                var v51 = _titleFax; v51.Clean = value; _titleFax = v51;
                var v52 = _titlePhone; v52.Clean = value; _titlePhone = v52;
                var v53 = _toBePaidOffAmount; v53.Clean = value; _toBePaidOffAmount = v53;
                var v54 = _uCDPayoffType; v54.Clean = value; _uCDPayoffType = v54;
                var v55 = _unpaidBalanceAmount; v55.Clean = value; _unpaidBalanceAmount = v55;
                var v56 = _volIndex; v56.Clean = value; _volIndex = v56;
                _settingClean = 0;
            }
        }
    }
}