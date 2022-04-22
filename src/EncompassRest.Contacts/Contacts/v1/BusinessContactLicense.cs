using System;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// BusinessContactLicense
    /// </summary>
    public sealed class BusinessContactLicense : DirtyExtensibleObject
    {
        /// <summary>
        /// Name of the licensing authority.
        /// </summary>
        public string? LicenseAuthName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Type of license.
        /// </summary>
        public string? LicenseAuthType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date the license was issued.
        /// </summary>
        public DateTime? LicenseIssueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// License number.
        /// </summary>
        public string? LicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// State the license was issued.
        /// </summary>
        public string? LicenseStateCode { get => GetValue<string?>(); set => SetValue(value); }
    }
}