using System;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContactLicense : ExtensibleObject
    {
        private DirtyValue<string> _licenseAuthName;
        public string LicenseAuthName { get => _licenseAuthName; set => _licenseAuthName = value; }
        private DirtyValue<string> _licenseAuthType;
        public string LicenseAuthType { get => _licenseAuthType; set => _licenseAuthType = value; }
        private DirtyValue<DateTime?> _licenseIssueDate;
        public DateTime? LicenseIssueDate { get => _licenseIssueDate; set => _licenseIssueDate = value; }
        private DirtyValue<string> _licenseNumber;
        public string LicenseNumber { get => _licenseNumber; set => _licenseNumber = value; }
        private DirtyValue<string> _licenseStateCode;
        public string LicenseStateCode { get => _licenseStateCode; set => _licenseStateCode = value; }
    }
}