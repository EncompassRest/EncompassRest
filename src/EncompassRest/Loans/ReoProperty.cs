using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ReoProperty : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acquiredDate.Clean
                    && _city.Clean
                    && _dispositionStatusType.Clean
                    && _entityDeleted.Clean
                    && _gsePropertyType.Clean
                    && _id.Clean
                    && _isEmpty.Clean
                    && _lienInstallmentAmount.Clean
                    && _lienUpbAmount.Clean
                    && _maintenanceExpenseAmount.Clean
                    && _marketValueAmount.Clean
                    && _noLinkToDocTrackIndicator.Clean
                    && _participationPercentage.Clean
                    && _percentageofRental.Clean
                    && _postalCode.Clean
                    && _printAttachIndicator.Clean
                    && _printUserNameIndicator.Clean
                    && _propertyUsageType.Clean
                    && _purchasePrice.Clean
                    && _rentalIncomeGrossAmount.Clean
                    && _rentalIncomeNetAmount.Clean
                    && _reoComments.Clean
                    && _reoId.Clean
                    && _reoPropertyIndex.Clean
                    && _requestDate.Clean
                    && _state.Clean
                    && _streetAddress.Clean
                    && _subjectIndicator.Clean
                    && _title.Clean
                    && _titleFax.Clean
                    && _titlePhone.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var acquiredDate = _acquiredDate; acquiredDate.Clean = value; _acquiredDate = acquiredDate;
                var city = _city; city.Clean = value; _city = city;
                var dispositionStatusType = _dispositionStatusType; dispositionStatusType.Clean = value; _dispositionStatusType = dispositionStatusType;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var gsePropertyType = _gsePropertyType; gsePropertyType.Clean = value; _gsePropertyType = gsePropertyType;
                var id = _id; id.Clean = value; _id = id;
                var isEmpty = _isEmpty; isEmpty.Clean = value; _isEmpty = isEmpty;
                var lienInstallmentAmount = _lienInstallmentAmount; lienInstallmentAmount.Clean = value; _lienInstallmentAmount = lienInstallmentAmount;
                var lienUpbAmount = _lienUpbAmount; lienUpbAmount.Clean = value; _lienUpbAmount = lienUpbAmount;
                var maintenanceExpenseAmount = _maintenanceExpenseAmount; maintenanceExpenseAmount.Clean = value; _maintenanceExpenseAmount = maintenanceExpenseAmount;
                var marketValueAmount = _marketValueAmount; marketValueAmount.Clean = value; _marketValueAmount = marketValueAmount;
                var noLinkToDocTrackIndicator = _noLinkToDocTrackIndicator; noLinkToDocTrackIndicator.Clean = value; _noLinkToDocTrackIndicator = noLinkToDocTrackIndicator;
                var participationPercentage = _participationPercentage; participationPercentage.Clean = value; _participationPercentage = participationPercentage;
                var percentageofRental = _percentageofRental; percentageofRental.Clean = value; _percentageofRental = percentageofRental;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var printAttachIndicator = _printAttachIndicator; printAttachIndicator.Clean = value; _printAttachIndicator = printAttachIndicator;
                var printUserNameIndicator = _printUserNameIndicator; printUserNameIndicator.Clean = value; _printUserNameIndicator = printUserNameIndicator;
                var propertyUsageType = _propertyUsageType; propertyUsageType.Clean = value; _propertyUsageType = propertyUsageType;
                var purchasePrice = _purchasePrice; purchasePrice.Clean = value; _purchasePrice = purchasePrice;
                var rentalIncomeGrossAmount = _rentalIncomeGrossAmount; rentalIncomeGrossAmount.Clean = value; _rentalIncomeGrossAmount = rentalIncomeGrossAmount;
                var rentalIncomeNetAmount = _rentalIncomeNetAmount; rentalIncomeNetAmount.Clean = value; _rentalIncomeNetAmount = rentalIncomeNetAmount;
                var reoComments = _reoComments; reoComments.Clean = value; _reoComments = reoComments;
                var reoId = _reoId; reoId.Clean = value; _reoId = reoId;
                var reoPropertyIndex = _reoPropertyIndex; reoPropertyIndex.Clean = value; _reoPropertyIndex = reoPropertyIndex;
                var requestDate = _requestDate; requestDate.Clean = value; _requestDate = requestDate;
                var state = _state; state.Clean = value; _state = state;
                var streetAddress = _streetAddress; streetAddress.Clean = value; _streetAddress = streetAddress;
                var subjectIndicator = _subjectIndicator; subjectIndicator.Clean = value; _subjectIndicator = subjectIndicator;
                var title = _title; title.Clean = value; _title = title;
                var titleFax = _titleFax; titleFax.Clean = value; _titleFax = titleFax;
                var titlePhone = _titlePhone; titlePhone.Clean = value; _titlePhone = titlePhone;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ReoProperty()
        {
            Clean = true;
        }
    }
}