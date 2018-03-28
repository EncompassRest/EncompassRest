#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Liability : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        public string AccountIdentifier { get => _accountIdentifier; set => _accountIdentifier = value; }
        private DirtyValue<bool?> _accountIndicator;
        public bool? AccountIndicator { get => _accountIndicator; set => _accountIndicator = value; }
        private DirtyValue<string> _attention;
        public string Attention { get => _attention; set => _attention = value; }
        private EntityReference _contact;
        public EntityReference Contact { get => _contact ?? (_contact = new EntityReference()); set => _contact = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _descriptionOfPurpose;
        public string DescriptionOfPurpose { get => _descriptionOfPurpose; set => _descriptionOfPurpose = value; }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<bool?> _exclusionIndicator;
        public bool? ExclusionIndicator { get => _exclusionIndicator; set => _exclusionIndicator = value; }
        private DirtyValue<string> _holderAddressCity;
        public string HolderAddressCity { get => _holderAddressCity; set => _holderAddressCity = value; }
        private DirtyValue<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => _holderAddressPostalCode = value; }
        private DirtyValue<string> _holderAddressState;
        public string HolderAddressState { get => _holderAddressState; set => _holderAddressState = value; }
        private DirtyValue<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => _holderAddressStreetLine1 = value; }
        private DirtyValue<string> _holderComments;
        public string HolderComments { get => _holderComments; set => _holderComments = value; }
        private DirtyValue<string> _holderEmail;
        public string HolderEmail { get => _holderEmail; set => _holderEmail = value; }
        private DirtyValue<string> _holderFax;
        public string HolderFax { get => _holderFax; set => _holderFax = value; }
        private DirtyValue<string> _holderName;
        public string HolderName { get => _holderName; set => _holderName = value; }
        private DirtyValue<string> _holderPhone;
        public string HolderPhone { get => _holderPhone; set => _holderPhone = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isDebtNotSecuredToSubjectPropertyIndicator;
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get => _isDebtNotSecuredToSubjectPropertyIndicator; set => _isDebtNotSecuredToSubjectPropertyIndicator = value; }
        private DirtyValue<int?> _lates12Month120Day;
        public int? Lates12Month120Day { get => _lates12Month120Day; set => _lates12Month120Day = value; }
        private DirtyValue<int?> _lates12Month150Day;
        public int? Lates12Month150Day { get => _lates12Month150Day; set => _lates12Month150Day = value; }
        private DirtyValue<int?> _lates12Month30Day;
        public int? Lates12Month30Day { get => _lates12Month30Day; set => _lates12Month30Day = value; }
        private DirtyValue<int?> _lates12Month60Day;
        public int? Lates12Month60Day { get => _lates12Month60Day; set => _lates12Month60Day = value; }
        private DirtyValue<int?> _lates12Month90Day;
        public int? Lates12Month90Day { get => _lates12Month90Day; set => _lates12Month90Day = value; }
        private DirtyValue<int?> _lates24Month120Day;
        public int? Lates24Month120Day { get => _lates24Month120Day; set => _lates24Month120Day = value; }
        private DirtyValue<int?> _lates24Month150Day;
        public int? Lates24Month150Day { get => _lates24Month150Day; set => _lates24Month150Day = value; }
        private DirtyValue<int?> _lates24Month30Day;
        public int? Lates24Month30Day { get => _lates24Month30Day; set => _lates24Month30Day = value; }
        private DirtyValue<int?> _lates24Month60Day;
        public int? Lates24Month60Day { get => _lates24Month60Day; set => _lates24Month60Day = value; }
        private DirtyValue<int?> _lates24Month90Day;
        public int? Lates24Month90Day { get => _lates24Month90Day; set => _lates24Month90Day = value; }
        private DirtyValue<int?> _lates25Month120Day;
        public int? Lates25Month120Day { get => _lates25Month120Day; set => _lates25Month120Day = value; }
        private DirtyValue<int?> _lates25Month150Day;
        public int? Lates25Month150Day { get => _lates25Month150Day; set => _lates25Month150Day = value; }
        private DirtyValue<int?> _lates25Month30Day;
        public int? Lates25Month30Day { get => _lates25Month30Day; set => _lates25Month30Day = value; }
        private DirtyValue<int?> _lates25Month60Day;
        public int? Lates25Month60Day { get => _lates25Month60Day; set => _lates25Month60Day = value; }
        private DirtyValue<int?> _lates25Month90Day;
        public int? Lates25Month90Day { get => _lates25Month90Day; set => _lates25Month90Day = value; }
        private DirtyValue<int?> _liabilityIndex;
        public int? LiabilityIndex { get => _liabilityIndex; set => _liabilityIndex = value; }
        private DirtyValue<StringEnumValue<LiabilityType>> _liabilityType;
        public StringEnumValue<LiabilityType> LiabilityType { get => _liabilityType; set => _liabilityType = value; }
        private DirtyValue<decimal?> _monthlyPaymentAmount;
        public decimal? MonthlyPaymentAmount { get => _monthlyPaymentAmount; set => _monthlyPaymentAmount = value; }
        private DirtyValue<int?> _monthsToExclude;
        public int? MonthsToExclude { get => _monthsToExclude; set => _monthsToExclude = value; }
        private DirtyValue<string> _nameInAccount;
        public string NameInAccount { get => _nameInAccount; set => _nameInAccount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<StringEnumValue<Owner>> _owner;
        public StringEnumValue<Owner> Owner { get => _owner; set => _owner = value; }
        private DirtyValue<bool?> _payoffIncludedIndicator;
        public bool? PayoffIncludedIndicator { get => _payoffIncludedIndicator; set => _payoffIncludedIndicator = value; }
        private DirtyValue<bool?> _payoffStatusIndicator;
        public bool? PayoffStatusIndicator { get => _payoffStatusIndicator; set => _payoffStatusIndicator = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => _prepaymentPenaltyAmount = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<int?> _remainingTermMonths;
        public int? RemainingTermMonths { get => _remainingTermMonths; set => _remainingTermMonths = value; }
        private DirtyValue<string> _reoId;
        public string ReoId { get => _reoId; set => _reoId = value; }
        private DirtyValue<string> _requestId;
        public string RequestId { get => _requestId; set => _requestId = value; }
        private DirtyValue<bool?> _subjectLoanResubordinationIndicator;
        public bool? SubjectLoanResubordinationIndicator { get => _subjectLoanResubordinationIndicator; set => _subjectLoanResubordinationIndicator = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        private DirtyValue<decimal?> _toBePaidOffAmount;
        public decimal? ToBePaidOffAmount { get => _toBePaidOffAmount; set => _toBePaidOffAmount = value; }
        private DirtyValue<StringEnumValue<UCDPayoffType>> _uCDPayoffType;
        public StringEnumValue<UCDPayoffType> UCDPayoffType { get => _uCDPayoffType; set => _uCDPayoffType = value; }
        private DirtyValue<decimal?> _unpaidBalanceAmount;
        public decimal? UnpaidBalanceAmount { get => _unpaidBalanceAmount; set => _unpaidBalanceAmount = value; }
        private DirtyValue<int?> _volIndex;
        public int? VolIndex { get => _volIndex; set => _volIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _accountIdentifier.Dirty
                    || _accountIndicator.Dirty
                    || _attention.Dirty
                    || _date.Dirty
                    || _description.Dirty
                    || _descriptionOfPurpose.Dirty
                    || _entityDeleted.Dirty
                    || _exclusionIndicator.Dirty
                    || _holderAddressCity.Dirty
                    || _holderAddressPostalCode.Dirty
                    || _holderAddressState.Dirty
                    || _holderAddressStreetLine1.Dirty
                    || _holderComments.Dirty
                    || _holderEmail.Dirty
                    || _holderFax.Dirty
                    || _holderName.Dirty
                    || _holderPhone.Dirty
                    || _id.Dirty
                    || _isDebtNotSecuredToSubjectPropertyIndicator.Dirty
                    || _lates12Month120Day.Dirty
                    || _lates12Month150Day.Dirty
                    || _lates12Month30Day.Dirty
                    || _lates12Month60Day.Dirty
                    || _lates12Month90Day.Dirty
                    || _lates24Month120Day.Dirty
                    || _lates24Month150Day.Dirty
                    || _lates24Month30Day.Dirty
                    || _lates24Month60Day.Dirty
                    || _lates24Month90Day.Dirty
                    || _lates25Month120Day.Dirty
                    || _lates25Month150Day.Dirty
                    || _lates25Month30Day.Dirty
                    || _lates25Month60Day.Dirty
                    || _lates25Month90Day.Dirty
                    || _liabilityIndex.Dirty
                    || _liabilityType.Dirty
                    || _monthlyPaymentAmount.Dirty
                    || _monthsToExclude.Dirty
                    || _nameInAccount.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _owner.Dirty
                    || _payoffIncludedIndicator.Dirty
                    || _payoffStatusIndicator.Dirty
                    || _prepaymentPenaltyAmount.Dirty
                    || _printAttachmentIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _remainingTermMonths.Dirty
                    || _reoId.Dirty
                    || _requestId.Dirty
                    || _subjectLoanResubordinationIndicator.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty
                    || _toBePaidOffAmount.Dirty
                    || _uCDPayoffType.Dirty
                    || _unpaidBalanceAmount.Dirty
                    || _volIndex.Dirty
                    || _contact?.Dirty == true;
            }
            set
            {
                _accountIdentifier.Dirty = value;
                _accountIndicator.Dirty = value;
                _attention.Dirty = value;
                _date.Dirty = value;
                _description.Dirty = value;
                _descriptionOfPurpose.Dirty = value;
                _entityDeleted.Dirty = value;
                _exclusionIndicator.Dirty = value;
                _holderAddressCity.Dirty = value;
                _holderAddressPostalCode.Dirty = value;
                _holderAddressState.Dirty = value;
                _holderAddressStreetLine1.Dirty = value;
                _holderComments.Dirty = value;
                _holderEmail.Dirty = value;
                _holderFax.Dirty = value;
                _holderName.Dirty = value;
                _holderPhone.Dirty = value;
                _id.Dirty = value;
                _isDebtNotSecuredToSubjectPropertyIndicator.Dirty = value;
                _lates12Month120Day.Dirty = value;
                _lates12Month150Day.Dirty = value;
                _lates12Month30Day.Dirty = value;
                _lates12Month60Day.Dirty = value;
                _lates12Month90Day.Dirty = value;
                _lates24Month120Day.Dirty = value;
                _lates24Month150Day.Dirty = value;
                _lates24Month30Day.Dirty = value;
                _lates24Month60Day.Dirty = value;
                _lates24Month90Day.Dirty = value;
                _lates25Month120Day.Dirty = value;
                _lates25Month150Day.Dirty = value;
                _lates25Month30Day.Dirty = value;
                _lates25Month60Day.Dirty = value;
                _lates25Month90Day.Dirty = value;
                _liabilityIndex.Dirty = value;
                _liabilityType.Dirty = value;
                _monthlyPaymentAmount.Dirty = value;
                _monthsToExclude.Dirty = value;
                _nameInAccount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _owner.Dirty = value;
                _payoffIncludedIndicator.Dirty = value;
                _payoffStatusIndicator.Dirty = value;
                _prepaymentPenaltyAmount.Dirty = value;
                _printAttachmentIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _remainingTermMonths.Dirty = value;
                _reoId.Dirty = value;
                _requestId.Dirty = value;
                _subjectLoanResubordinationIndicator.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
                _toBePaidOffAmount.Dirty = value;
                _uCDPayoffType.Dirty = value;
                _unpaidBalanceAmount.Dirty = value;
                _volIndex.Dirty = value;
                if (_contact != null) _contact.Dirty = value;
            }
        }
    }
}