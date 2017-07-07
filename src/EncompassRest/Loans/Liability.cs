using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Liability : IClean
    {
        private Value<string> _accountIdentifier;
        public string AccountIdentifier { get { return _accountIdentifier; } set { _accountIdentifier = value; } }
        private Value<bool?> _accountIndicator;
        public bool? AccountIndicator { get { return _accountIndicator; } set { _accountIndicator = value; } }
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _descriptionOfPurpose;
        public string DescriptionOfPurpose { get { return _descriptionOfPurpose; } set { _descriptionOfPurpose = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<bool?> _exclusionIndicator;
        public bool? ExclusionIndicator { get { return _exclusionIndicator; } set { _exclusionIndicator = value; } }
        private Value<string> _holderAddressCity;
        public string HolderAddressCity { get { return _holderAddressCity; } set { _holderAddressCity = value; } }
        private Value<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get { return _holderAddressPostalCode; } set { _holderAddressPostalCode = value; } }
        private Value<string> _holderAddressState;
        public string HolderAddressState { get { return _holderAddressState; } set { _holderAddressState = value; } }
        private Value<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get { return _holderAddressStreetLine1; } set { _holderAddressStreetLine1 = value; } }
        private Value<string> _holderComments;
        public string HolderComments { get { return _holderComments; } set { _holderComments = value; } }
        private Value<string> _holderEmail;
        public string HolderEmail { get { return _holderEmail; } set { _holderEmail = value; } }
        private Value<string> _holderFax;
        public string HolderFax { get { return _holderFax; } set { _holderFax = value; } }
        private Value<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        private Value<string> _holderPhone;
        public string HolderPhone { get { return _holderPhone; } set { _holderPhone = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isDebtNotSecuredToSubjectPropertyIndicator;
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get { return _isDebtNotSecuredToSubjectPropertyIndicator; } set { _isDebtNotSecuredToSubjectPropertyIndicator = value; } }
        private Value<int?> _lates12Month120Day;
        public int? Lates12Month120Day { get { return _lates12Month120Day; } set { _lates12Month120Day = value; } }
        private Value<int?> _lates12Month150Day;
        public int? Lates12Month150Day { get { return _lates12Month150Day; } set { _lates12Month150Day = value; } }
        private Value<int?> _lates12Month30Day;
        public int? Lates12Month30Day { get { return _lates12Month30Day; } set { _lates12Month30Day = value; } }
        private Value<int?> _lates12Month60Day;
        public int? Lates12Month60Day { get { return _lates12Month60Day; } set { _lates12Month60Day = value; } }
        private Value<int?> _lates12Month90Day;
        public int? Lates12Month90Day { get { return _lates12Month90Day; } set { _lates12Month90Day = value; } }
        private Value<int?> _lates24Month120Day;
        public int? Lates24Month120Day { get { return _lates24Month120Day; } set { _lates24Month120Day = value; } }
        private Value<int?> _lates24Month150Day;
        public int? Lates24Month150Day { get { return _lates24Month150Day; } set { _lates24Month150Day = value; } }
        private Value<int?> _lates24Month30Day;
        public int? Lates24Month30Day { get { return _lates24Month30Day; } set { _lates24Month30Day = value; } }
        private Value<int?> _lates24Month60Day;
        public int? Lates24Month60Day { get { return _lates24Month60Day; } set { _lates24Month60Day = value; } }
        private Value<int?> _lates24Month90Day;
        public int? Lates24Month90Day { get { return _lates24Month90Day; } set { _lates24Month90Day = value; } }
        private Value<int?> _lates25Month120Day;
        public int? Lates25Month120Day { get { return _lates25Month120Day; } set { _lates25Month120Day = value; } }
        private Value<int?> _lates25Month150Day;
        public int? Lates25Month150Day { get { return _lates25Month150Day; } set { _lates25Month150Day = value; } }
        private Value<int?> _lates25Month30Day;
        public int? Lates25Month30Day { get { return _lates25Month30Day; } set { _lates25Month30Day = value; } }
        private Value<int?> _lates25Month60Day;
        public int? Lates25Month60Day { get { return _lates25Month60Day; } set { _lates25Month60Day = value; } }
        private Value<int?> _lates25Month90Day;
        public int? Lates25Month90Day { get { return _lates25Month90Day; } set { _lates25Month90Day = value; } }
        private Value<int?> _liabilityIndex;
        public int? LiabilityIndex { get { return _liabilityIndex; } set { _liabilityIndex = value; } }
        private Value<string> _liabilityType;
        public string LiabilityType { get { return _liabilityType; } set { _liabilityType = value; } }
        private Value<decimal?> _monthlyPaymentAmount;
        public decimal? MonthlyPaymentAmount { get { return _monthlyPaymentAmount; } set { _monthlyPaymentAmount = value; } }
        private Value<int?> _monthsToExclude;
        public int? MonthsToExclude { get { return _monthsToExclude; } set { _monthsToExclude = value; } }
        private Value<string> _nameInAccount;
        public string NameInAccount { get { return _nameInAccount; } set { _nameInAccount = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private Value<bool?> _payoffIncludedIndicator;
        public bool? PayoffIncludedIndicator { get { return _payoffIncludedIndicator; } set { _payoffIncludedIndicator = value; } }
        private Value<bool?> _payoffStatusIndicator;
        public bool? PayoffStatusIndicator { get { return _payoffStatusIndicator; } set { _payoffStatusIndicator = value; } }
        private Value<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get { return _prepaymentPenaltyAmount; } set { _prepaymentPenaltyAmount = value; } }
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<int?> _remainingTermMonths;
        public int? RemainingTermMonths { get { return _remainingTermMonths; } set { _remainingTermMonths = value; } }
        private Value<string> _reoId;
        public string ReoId { get { return _reoId; } set { _reoId = value; } }
        private Value<string> _requestId;
        public string RequestId { get { return _requestId; } set { _requestId = value; } }
        private Value<bool?> _subjectLoanResubordinationIndicator;
        public bool? SubjectLoanResubordinationIndicator { get { return _subjectLoanResubordinationIndicator; } set { _subjectLoanResubordinationIndicator = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private Value<decimal?> _toBePaidOffAmount;
        public decimal? ToBePaidOffAmount { get { return _toBePaidOffAmount; } set { _toBePaidOffAmount = value; } }
        private Value<string> _uCDPayoffType;
        public string UCDPayoffType { get { return _uCDPayoffType; } set { _uCDPayoffType = value; } }
        private Value<decimal?> _unpaidBalanceAmount;
        public decimal? UnpaidBalanceAmount { get { return _unpaidBalanceAmount; } set { _unpaidBalanceAmount = value; } }
        private Value<int?> _volIndex;
        public int? VolIndex { get { return _volIndex; } set { _volIndex = value; } }
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
                var accountIdentifier = _accountIdentifier; accountIdentifier.Clean = value; _accountIdentifier = accountIdentifier;
                var accountIndicator = _accountIndicator; accountIndicator.Clean = value; _accountIndicator = accountIndicator;
                var attention = _attention; attention.Clean = value; _attention = attention;
                var date = _date; date.Clean = value; _date = date;
                var description = _description; description.Clean = value; _description = description;
                var descriptionOfPurpose = _descriptionOfPurpose; descriptionOfPurpose.Clean = value; _descriptionOfPurpose = descriptionOfPurpose;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var exclusionIndicator = _exclusionIndicator; exclusionIndicator.Clean = value; _exclusionIndicator = exclusionIndicator;
                var holderAddressCity = _holderAddressCity; holderAddressCity.Clean = value; _holderAddressCity = holderAddressCity;
                var holderAddressPostalCode = _holderAddressPostalCode; holderAddressPostalCode.Clean = value; _holderAddressPostalCode = holderAddressPostalCode;
                var holderAddressState = _holderAddressState; holderAddressState.Clean = value; _holderAddressState = holderAddressState;
                var holderAddressStreetLine1 = _holderAddressStreetLine1; holderAddressStreetLine1.Clean = value; _holderAddressStreetLine1 = holderAddressStreetLine1;
                var holderComments = _holderComments; holderComments.Clean = value; _holderComments = holderComments;
                var holderEmail = _holderEmail; holderEmail.Clean = value; _holderEmail = holderEmail;
                var holderFax = _holderFax; holderFax.Clean = value; _holderFax = holderFax;
                var holderName = _holderName; holderName.Clean = value; _holderName = holderName;
                var holderPhone = _holderPhone; holderPhone.Clean = value; _holderPhone = holderPhone;
                var id = _id; id.Clean = value; _id = id;
                var isDebtNotSecuredToSubjectPropertyIndicator = _isDebtNotSecuredToSubjectPropertyIndicator; isDebtNotSecuredToSubjectPropertyIndicator.Clean = value; _isDebtNotSecuredToSubjectPropertyIndicator = isDebtNotSecuredToSubjectPropertyIndicator;
                var lates12Month120Day = _lates12Month120Day; lates12Month120Day.Clean = value; _lates12Month120Day = lates12Month120Day;
                var lates12Month150Day = _lates12Month150Day; lates12Month150Day.Clean = value; _lates12Month150Day = lates12Month150Day;
                var lates12Month30Day = _lates12Month30Day; lates12Month30Day.Clean = value; _lates12Month30Day = lates12Month30Day;
                var lates12Month60Day = _lates12Month60Day; lates12Month60Day.Clean = value; _lates12Month60Day = lates12Month60Day;
                var lates12Month90Day = _lates12Month90Day; lates12Month90Day.Clean = value; _lates12Month90Day = lates12Month90Day;
                var lates24Month120Day = _lates24Month120Day; lates24Month120Day.Clean = value; _lates24Month120Day = lates24Month120Day;
                var lates24Month150Day = _lates24Month150Day; lates24Month150Day.Clean = value; _lates24Month150Day = lates24Month150Day;
                var lates24Month30Day = _lates24Month30Day; lates24Month30Day.Clean = value; _lates24Month30Day = lates24Month30Day;
                var lates24Month60Day = _lates24Month60Day; lates24Month60Day.Clean = value; _lates24Month60Day = lates24Month60Day;
                var lates24Month90Day = _lates24Month90Day; lates24Month90Day.Clean = value; _lates24Month90Day = lates24Month90Day;
                var lates25Month120Day = _lates25Month120Day; lates25Month120Day.Clean = value; _lates25Month120Day = lates25Month120Day;
                var lates25Month150Day = _lates25Month150Day; lates25Month150Day.Clean = value; _lates25Month150Day = lates25Month150Day;
                var lates25Month30Day = _lates25Month30Day; lates25Month30Day.Clean = value; _lates25Month30Day = lates25Month30Day;
                var lates25Month60Day = _lates25Month60Day; lates25Month60Day.Clean = value; _lates25Month60Day = lates25Month60Day;
                var lates25Month90Day = _lates25Month90Day; lates25Month90Day.Clean = value; _lates25Month90Day = lates25Month90Day;
                var liabilityIndex = _liabilityIndex; liabilityIndex.Clean = value; _liabilityIndex = liabilityIndex;
                var liabilityType = _liabilityType; liabilityType.Clean = value; _liabilityType = liabilityType;
                var monthlyPaymentAmount = _monthlyPaymentAmount; monthlyPaymentAmount.Clean = value; _monthlyPaymentAmount = monthlyPaymentAmount;
                var monthsToExclude = _monthsToExclude; monthsToExclude.Clean = value; _monthsToExclude = monthsToExclude;
                var nameInAccount = _nameInAccount; nameInAccount.Clean = value; _nameInAccount = nameInAccount;
                var noLinkToDocTrackIndicator = _noLinkToDocTrackIndicator; noLinkToDocTrackIndicator.Clean = value; _noLinkToDocTrackIndicator = noLinkToDocTrackIndicator;
                var owner = _owner; owner.Clean = value; _owner = owner;
                var payoffIncludedIndicator = _payoffIncludedIndicator; payoffIncludedIndicator.Clean = value; _payoffIncludedIndicator = payoffIncludedIndicator;
                var payoffStatusIndicator = _payoffStatusIndicator; payoffStatusIndicator.Clean = value; _payoffStatusIndicator = payoffStatusIndicator;
                var prepaymentPenaltyAmount = _prepaymentPenaltyAmount; prepaymentPenaltyAmount.Clean = value; _prepaymentPenaltyAmount = prepaymentPenaltyAmount;
                var printAttachmentIndicator = _printAttachmentIndicator; printAttachmentIndicator.Clean = value; _printAttachmentIndicator = printAttachmentIndicator;
                var printUserNameIndicator = _printUserNameIndicator; printUserNameIndicator.Clean = value; _printUserNameIndicator = printUserNameIndicator;
                var remainingTermMonths = _remainingTermMonths; remainingTermMonths.Clean = value; _remainingTermMonths = remainingTermMonths;
                var reoId = _reoId; reoId.Clean = value; _reoId = reoId;
                var requestId = _requestId; requestId.Clean = value; _requestId = requestId;
                var subjectLoanResubordinationIndicator = _subjectLoanResubordinationIndicator; subjectLoanResubordinationIndicator.Clean = value; _subjectLoanResubordinationIndicator = subjectLoanResubordinationIndicator;
                var title = _title; title.Clean = value; _title = title;
                var titleFax = _titleFax; titleFax.Clean = value; _titleFax = titleFax;
                var titlePhone = _titlePhone; titlePhone.Clean = value; _titlePhone = titlePhone;
                var toBePaidOffAmount = _toBePaidOffAmount; toBePaidOffAmount.Clean = value; _toBePaidOffAmount = toBePaidOffAmount;
                var uCDPayoffType = _uCDPayoffType; uCDPayoffType.Clean = value; _uCDPayoffType = uCDPayoffType;
                var unpaidBalanceAmount = _unpaidBalanceAmount; unpaidBalanceAmount.Clean = value; _unpaidBalanceAmount = unpaidBalanceAmount;
                var volIndex = _volIndex; volIndex.Clean = value; _volIndex = volIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Liability()
        {
            Clean = true;
        }
    }
}