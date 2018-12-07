using System;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// UserLicenseDetail
    /// </summary>
    public sealed class UserLicenseDetail : DirtyExtensibleObject
    {
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<bool> _enabled;
        private DirtyValue<string> _license;
        private DirtyValue<DateTime?> _expirationDate;

        /// <summary>
        /// UserLicenseDetail State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// UserLicenseDetail Enabled
        /// </summary>
        public bool Enabled { get => _enabled; set => SetField(ref _enabled, value); }

        /// <summary>
        /// UserLicenseDetail License
        /// </summary>
        public string License { get => _license; set => SetField(ref _license, value); }

        /// <summary>
        /// UserLicenseDetail ExpirationDate
        /// </summary>
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }
    }
}