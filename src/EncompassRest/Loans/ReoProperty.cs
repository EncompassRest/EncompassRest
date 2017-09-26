using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ReoProperty : IDirty
    {
        private Value<DateTime?> _acquiredDate;
        public DateTime? AcquiredDate { get { return _acquiredDate; } set { _acquiredDate = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _dispositionStatusType;
        public string DispositionStatusType { get { return _dispositionStatusType; } set { _dispositionStatusType = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _gsePropertyType;
        public string GsePropertyType { get { return _gsePropertyType; } set { _gsePropertyType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private Value<decimal?> _lienInstallmentAmount;
        public decimal? LienInstallmentAmount { get { return _lienInstallmentAmount; } set { _lienInstallmentAmount = value; } }
        private Value<decimal?> _lienUpbAmount;
        public decimal? LienUpbAmount { get { return _lienUpbAmount; } set { _lienUpbAmount = value; } }
        private Value<string> _maintenanceExpenseAmount;
        public string MaintenanceExpenseAmount { get { return _maintenanceExpenseAmount; } set { _maintenanceExpenseAmount = value; } }
        private Value<decimal?> _marketValueAmount;
        public decimal? MarketValueAmount { get { return _marketValueAmount; } set { _marketValueAmount = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<decimal?> _participationPercentage;
        public decimal? ParticipationPercentage { get { return _participationPercentage; } set { _participationPercentage = value; } }
        private Value<decimal?> _percentageofRental;
        public decimal? PercentageofRental { get { return _percentageofRental; } set { _percentageofRental = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<bool?> _printAttachIndicator;
        public bool? PrintAttachIndicator { get { return _printAttachIndicator; } set { _printAttachIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private Value<int?> _purchasePrice;
        public int? PurchasePrice { get { return _purchasePrice; } set { _purchasePrice = value; } }
        private Value<decimal?> _rentalIncomeGrossAmount;
        public decimal? RentalIncomeGrossAmount { get { return _rentalIncomeGrossAmount; } set { _rentalIncomeGrossAmount = value; } }
        private Value<decimal?> _rentalIncomeNetAmount;
        public decimal? RentalIncomeNetAmount { get { return _rentalIncomeNetAmount; } set { _rentalIncomeNetAmount = value; } }
        private Value<string> _reoComments;
        public string ReoComments { get { return _reoComments; } set { _reoComments = value; } }
        private Value<string> _reoId;
        public string ReoId { get { return _reoId; } set { _reoId = value; } }
        private Value<int?> _reoPropertyIndex;
        public int? ReoPropertyIndex { get { return _reoPropertyIndex; } set { _reoPropertyIndex = value; } }
        private Value<DateTime?> _requestDate;
        public DateTime? RequestDate { get { return _requestDate; } set { _requestDate = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _streetAddress;
        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        private Value<bool?> _subjectIndicator;
        public bool? SubjectIndicator { get { return _subjectIndicator; } set { _subjectIndicator = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _acquiredDate.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}