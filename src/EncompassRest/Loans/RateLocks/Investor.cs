using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// Rate Lock Investor
    /// </summary>
    public sealed partial class Investor : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?>? _lockedDate;
        private DirtyValue<string?>? _deliveryDate;
        private DirtyValue<string?>? _targetDeliveryDate;
        private DirtyValue<string?>? _name;
        private DirtyValue<string?>? _contact;
        private DirtyValue<string?>? _phone;
        private DirtyValue<string?>? _email;
        private DirtyValue<string?>? _city;
        private DirtyValue<string?>? _state;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<string?>? _website;
        private DirtyValue<string?>? _lockType;
        private DirtyValue<string?>? _status;
        private DirtyValue<DateTime?>? _statusDate;
        private DirtyValue<string?>? _commitment;


        /// <summary>
        /// Investor Locked Date
        /// </summary>
        public DateTime? LockedDate { get => _lockedDate; set => SetField(ref _lockedDate, value); }

        /// <summary>
        /// Investor Delivery Date
        /// </summary>
        public string? DeliveryDate { get => _deliveryDate; set => SetField(ref _deliveryDate, value); }

        /// <summary>
        /// Investor Target Delivery Date
        /// </summary>
        public string? TargetDeliveryDate { get => _targetDeliveryDate; set => SetField(ref _targetDeliveryDate, value); }

        /// <summary>
        /// Investor Name
        /// </summary>
        public string? Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// Investor Contact
        /// </summary>
        public string? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Investor Contact Phone
        /// </summary>
        public string? Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// Investor Contact Email
        /// </summary>
        public string? Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// Investor Contact City
        /// </summary>
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Investor Contact State
        /// </summary>
        public string? State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Investor Contact PostalCode
        /// </summary>
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Investor Contact Website
        /// </summary>
        public string? Website { get => _website; set => SetField(ref _website, value); }

        /// <summary>
        /// Investor Lock type. Possible values are Mandatory or Best Efforts
        /// </summary>
        public string? LockType { get => _lockType; set => SetField(ref _lockType, value); }

        /// <summary>
        /// Investor status
        /// </summary>
        public string? Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// Investor Status Date
        /// </summary>
        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

        /// <summary>
        /// Investor Commitment Identifier
        /// </summary>
        public string? Commitment { get => _commitment; set => SetField(ref _commitment, value); }
    }
}