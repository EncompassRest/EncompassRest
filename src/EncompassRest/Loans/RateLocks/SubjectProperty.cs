using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// Rate Lock Investor
    /// </summary>
    public sealed partial class SubjectProperty : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _address;
        private DirtyValue<string?>? _city;
        private DirtyValue<string?>? _state;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<string?>? _county;
        private DirtyValue<int?>? _estimatedAmount;
        private DirtyValue<int?>? _appraisedAmount;
        private DirtyValue<decimal?>? _purchasePrice;
        private DirtyValue<string?>? _usageType;
        private DirtyValue<int?>? _numberOfUnits;
        private DirtyValue<string?>? _gsePropertyType;
        private DirtyValue<bool?>? _isCondotelProperty;
        private DirtyValue<bool?>? _isNonWarrantableProjectProperty;

        /// <summary>
        /// Address of the subject property.
        /// </summary>
        public string? Address { get => _address; set => SetField(ref _address, value); }

        /// <summary>
        /// City of the subject property.
        /// </summary>
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// State of the subject property.
        /// </summary>
        public string? State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Postal code of the subject property.
        /// </summary>
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// County of the subject property.
        /// </summary>
        public string? County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// Estimated Amount of the subject property.
        /// </summary>
        public int? EstimatedAmount { get => _estimatedAmount; set => SetField(ref _estimatedAmount, value); }

        /// <summary>
        /// Appraised Amount of the subject property.
        /// </summary>
        public int? AppraisedAmount { get => _appraisedAmount; set => SetField(ref _appraisedAmount, value); }

        /// <summary>
        /// Purchase Price of the subject property.
        /// </summary>
        public decimal? PurchasePrice { get => _purchasePrice; set => SetField(ref _purchasePrice, value); }

        /// <summary>
        /// Usage Type of the subject property.
        /// </summary>
        public string? UsageType { get => _usageType; set => SetField(ref _usageType, value); }

        /// <summary>
        /// Number Of Units in the subject property.
        /// </summary>
        public int? NumberOfUnits { get => _numberOfUnits; set => SetField(ref _numberOfUnits, value); }

        /// <summary>
        /// GSE property type.
        /// </summary>
        public string? GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }

        /// <summary>
        /// Indicates whether the subject property is a Condotel Property.
        /// </summary>
        public bool? IsCondotelProperty { get => _isCondotelProperty; set => SetField(ref _isCondotelProperty, value); }

        /// <summary>
        /// Indicates whether the subject property is a Non-Warrantable Project Property.
        /// </summary>
        public bool? IsNonWarrantableProjectProperty { get => _isNonWarrantableProjectProperty; set => SetField(ref _isNonWarrantableProjectProperty, value); }

    }
}