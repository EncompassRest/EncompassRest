#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ReoProperty : ExtensibleObject
    {
        private DirtyValue<DateTime?> _acquiredDate;
        public DateTime? AcquiredDate { get => _acquiredDate; set => _acquiredDate = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<StringEnumValue<DispositionStatusType>> _dispositionStatusType;
        public StringEnumValue<DispositionStatusType> DispositionStatusType { get => _dispositionStatusType; set => _dispositionStatusType = value; }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<StringEnumValue<GsePropertyType>> _gsePropertyType;
        public StringEnumValue<GsePropertyType> GsePropertyType { get => _gsePropertyType; set => _gsePropertyType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<decimal?> _lienInstallmentAmount;
        public decimal? LienInstallmentAmount { get => _lienInstallmentAmount; set => _lienInstallmentAmount = value; }
        private DirtyValue<decimal?> _lienUpbAmount;
        public decimal? LienUpbAmount { get => _lienUpbAmount; set => _lienUpbAmount = value; }
        private DirtyValue<string> _maintenanceExpenseAmount;
        public string MaintenanceExpenseAmount { get => _maintenanceExpenseAmount; set => _maintenanceExpenseAmount = value; }
        private DirtyValue<decimal?> _marketValueAmount;
        public decimal? MarketValueAmount { get => _marketValueAmount; set => _marketValueAmount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<decimal?> _participationPercentage;
        public decimal? ParticipationPercentage { get => _participationPercentage; set => _participationPercentage = value; }
        private DirtyValue<decimal?> _percentageofRental;
        public decimal? PercentageofRental { get => _percentageofRental; set => _percentageofRental = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<bool?> _printAttachIndicator;
        public bool? PrintAttachIndicator { get => _printAttachIndicator; set => _printAttachIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<int?> _purchasePrice;
        public int? PurchasePrice { get => _purchasePrice; set => _purchasePrice = value; }
        private DirtyValue<decimal?> _rentalIncomeGrossAmount;
        public decimal? RentalIncomeGrossAmount { get => _rentalIncomeGrossAmount; set => _rentalIncomeGrossAmount = value; }
        private DirtyValue<decimal?> _rentalIncomeNetAmount;
        public decimal? RentalIncomeNetAmount { get => _rentalIncomeNetAmount; set => _rentalIncomeNetAmount = value; }
        private DirtyValue<string> _reoComments;
        public string ReoComments { get => _reoComments; set => _reoComments = value; }
        private DirtyValue<string> _reoId;
        public string ReoId { get => _reoId; set => _reoId = value; }
        private DirtyValue<int?> _reoPropertyIndex;
        public int? ReoPropertyIndex { get => _reoPropertyIndex; set => _reoPropertyIndex = value; }
        private DirtyValue<DateTime?> _requestDate;
        public DateTime? RequestDate { get => _requestDate; set => _requestDate = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _streetAddress;
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private DirtyValue<bool?> _subjectIndicator;
        public bool? SubjectIndicator { get => _subjectIndicator; set => _subjectIndicator = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _acquiredDate.Dirty
                    || _city.Dirty
                    || _dispositionStatusType.Dirty
                    || _entityDeleted.Dirty
                    || _gsePropertyType.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _lienInstallmentAmount.Dirty
                    || _lienUpbAmount.Dirty
                    || _maintenanceExpenseAmount.Dirty
                    || _marketValueAmount.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _participationPercentage.Dirty
                    || _percentageofRental.Dirty
                    || _postalCode.Dirty
                    || _printAttachIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _propertyUsageType.Dirty
                    || _purchasePrice.Dirty
                    || _rentalIncomeGrossAmount.Dirty
                    || _rentalIncomeNetAmount.Dirty
                    || _reoComments.Dirty
                    || _reoId.Dirty
                    || _reoPropertyIndex.Dirty
                    || _requestDate.Dirty
                    || _state.Dirty
                    || _streetAddress.Dirty
                    || _subjectIndicator.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty;
            }
            set
            {
                _acquiredDate.Dirty = value;
                _city.Dirty = value;
                _dispositionStatusType.Dirty = value;
                _entityDeleted.Dirty = value;
                _gsePropertyType.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _lienInstallmentAmount.Dirty = value;
                _lienUpbAmount.Dirty = value;
                _maintenanceExpenseAmount.Dirty = value;
                _marketValueAmount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _participationPercentage.Dirty = value;
                _percentageofRental.Dirty = value;
                _postalCode.Dirty = value;
                _printAttachIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _propertyUsageType.Dirty = value;
                _purchasePrice.Dirty = value;
                _rentalIncomeGrossAmount.Dirty = value;
                _rentalIncomeNetAmount.Dirty = value;
                _reoComments.Dirty = value;
                _reoId.Dirty = value;
                _reoPropertyIndex.Dirty = value;
                _requestDate.Dirty = value;
                _state.Dirty = value;
                _streetAddress.Dirty = value;
                _subjectIndicator.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
            }
        }
    }
}