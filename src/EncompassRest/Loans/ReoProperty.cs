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
                var v0 = _acquiredDate; v0.Clean = value; _acquiredDate = v0;
                var v1 = _city; v1.Clean = value; _city = v1;
                var v2 = _dispositionStatusType; v2.Clean = value; _dispositionStatusType = v2;
                var v3 = _entityDeleted; v3.Clean = value; _entityDeleted = v3;
                var v4 = _gsePropertyType; v4.Clean = value; _gsePropertyType = v4;
                var v5 = _id; v5.Clean = value; _id = v5;
                var v6 = _isEmpty; v6.Clean = value; _isEmpty = v6;
                var v7 = _lienInstallmentAmount; v7.Clean = value; _lienInstallmentAmount = v7;
                var v8 = _lienUpbAmount; v8.Clean = value; _lienUpbAmount = v8;
                var v9 = _maintenanceExpenseAmount; v9.Clean = value; _maintenanceExpenseAmount = v9;
                var v10 = _marketValueAmount; v10.Clean = value; _marketValueAmount = v10;
                var v11 = _noLinkToDocTrackIndicator; v11.Clean = value; _noLinkToDocTrackIndicator = v11;
                var v12 = _participationPercentage; v12.Clean = value; _participationPercentage = v12;
                var v13 = _percentageofRental; v13.Clean = value; _percentageofRental = v13;
                var v14 = _postalCode; v14.Clean = value; _postalCode = v14;
                var v15 = _printAttachIndicator; v15.Clean = value; _printAttachIndicator = v15;
                var v16 = _printUserNameIndicator; v16.Clean = value; _printUserNameIndicator = v16;
                var v17 = _propertyUsageType; v17.Clean = value; _propertyUsageType = v17;
                var v18 = _purchasePrice; v18.Clean = value; _purchasePrice = v18;
                var v19 = _rentalIncomeGrossAmount; v19.Clean = value; _rentalIncomeGrossAmount = v19;
                var v20 = _rentalIncomeNetAmount; v20.Clean = value; _rentalIncomeNetAmount = v20;
                var v21 = _reoComments; v21.Clean = value; _reoComments = v21;
                var v22 = _reoId; v22.Clean = value; _reoId = v22;
                var v23 = _reoPropertyIndex; v23.Clean = value; _reoPropertyIndex = v23;
                var v24 = _requestDate; v24.Clean = value; _requestDate = v24;
                var v25 = _state; v25.Clean = value; _state = v25;
                var v26 = _streetAddress; v26.Clean = value; _streetAddress = v26;
                var v27 = _subjectIndicator; v27.Clean = value; _subjectIndicator = v27;
                var v28 = _title; v28.Clean = value; _title = v28;
                var v29 = _titleFax; v29.Clean = value; _titleFax = v29;
                var v30 = _titlePhone; v30.Clean = value; _titlePhone = v30;
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