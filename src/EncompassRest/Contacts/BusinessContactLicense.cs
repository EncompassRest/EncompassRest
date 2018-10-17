using System;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContactLicense : DirtyExtensibleObject
    {
        private DirtyValue<string> _licenseAuthName;
        private DirtyValue<string> _licenseAuthType;
        private DirtyValue<DateTime?> _licenseIssueDate;
        private DirtyValue<string> _licenseNumber;
        private DirtyValue<string> _licenseStateCode;

        public string LicenseAuthName { get => _licenseAuthName; set => SetField(ref _licenseAuthName, value); }

        public string LicenseAuthType { get => _licenseAuthType; set => SetField(ref _licenseAuthType, value); }

        public DateTime? LicenseIssueDate { get => _licenseIssueDate; set => SetField(ref _licenseIssueDate, value); }

        public string LicenseNumber { get => _licenseNumber; set => SetField(ref _licenseNumber, value); }

        public string LicenseStateCode { get => _licenseStateCode; set => SetField(ref _licenseStateCode, value); }
    }
}