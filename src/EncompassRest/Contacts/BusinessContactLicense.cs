using System;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContactLicense : DirtyExtensibleObject
    {
        private DirtyValue<string> _licenseAuthName;
        public string LicenseAuthName { get => _licenseAuthName; set => SetField(ref _licenseAuthName, value); }
        private DirtyValue<string> _licenseAuthType;
        public string LicenseAuthType { get => _licenseAuthType; set => SetField(ref _licenseAuthType, value); }
        private DirtyValue<DateTime?> _licenseIssueDate;
        public DateTime? LicenseIssueDate { get => _licenseIssueDate; set => SetField(ref _licenseIssueDate, value); }
        private DirtyValue<string> _licenseNumber;
        public string LicenseNumber { get => _licenseNumber; set => SetField(ref _licenseNumber, value); }
        private DirtyValue<string> _licenseStateCode;
        public string LicenseStateCode { get => _licenseStateCode; set => SetField(ref _licenseStateCode, value); }
    }
}