using System;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// UserLicenseDetail
    /// </summary>
    public sealed class UserLicenseDetail : DirtyExtensibleObject
    {
        /// <summary>
        /// UserLicenseDetail State
        /// </summary>
        public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

        /// <summary>
        /// UserLicenseDetail Enabled
        /// </summary>
        public bool Enabled { get => GetValue<bool>(); set => SetValue(value); }

        /// <summary>
        /// UserLicenseDetail License
        /// </summary>
        public string? License { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// UserLicenseDetail ExpirationDate
        /// </summary>
        public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// UserLicenseDetail IssueDate
        /// </summary>
        public DateTime? IssueDate { get => GetValue<DateTime?>(); set => SetValue(value); }
    }
}