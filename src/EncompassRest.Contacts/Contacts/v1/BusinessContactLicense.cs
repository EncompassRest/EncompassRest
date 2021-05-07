using System;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// BusinessContactLicense
    /// </summary>
    public sealed class BusinessContactLicense : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _licenseAuthName;
        private DirtyValue<string?>? _licenseAuthType;
        private DirtyValue<DateTime?>? _licenseIssueDate;
        private DirtyValue<string?>? _licenseNumber;
        private DirtyValue<string?>? _licenseStateCode;

        /// <summary>
        /// Name of the licensing authority.
        /// </summary>
        public string? LicenseAuthName { get => _licenseAuthName; set => SetField(ref _licenseAuthName, value); }

        /// <summary>
        /// Type of license.
        /// </summary>
        public string? LicenseAuthType { get => _licenseAuthType; set => SetField(ref _licenseAuthType, value); }

        /// <summary>
        /// Date the license was issued.
        /// </summary>
        public DateTime? LicenseIssueDate { get => _licenseIssueDate; set => SetField(ref _licenseIssueDate, value); }

        /// <summary>
        /// License number.
        /// </summary>
        public string? LicenseNumber { get => _licenseNumber; set => SetField(ref _licenseNumber, value); }

        /// <summary>
        /// State the license was issued.
        /// </summary>
        public string? LicenseStateCode { get => _licenseStateCode; set => SetField(ref _licenseStateCode, value); }
    }
}