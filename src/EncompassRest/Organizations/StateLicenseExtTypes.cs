using System;

namespace EncompassRest.Organizations
{
    public sealed class StateLicenseExtTypes : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?> _endDate;
        private DirtyValue<bool?> _isApproved;
        private DirtyValue<bool?> _isExempted;
        private DirtyValue<bool?> _isSelected;
        private DirtyValue<DateTime?> _issueDate;
        private DirtyValue<DateTime?> _lastChecked;
        private DirtyValue<string> _licenseNo;
        private DirtyValue<StringEnumValue<LicenseStatus>> _licenseStatus;
        private DirtyValue<string> _licenseType;
        private DirtyValue<DateTime?> _startDate;
        private DirtyValue<StringEnumValue<State>> _stateAbbreviation;
        private DirtyValue<DateTime?> _statusDate;

        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        public bool? IsApproved { get => _isApproved; set => SetField(ref _isApproved, value); }

        public bool? IsExempted { get => _isExempted; set => SetField(ref _isExempted, value); }

        public bool? IsSelected { get => _isSelected; set => SetField(ref _isSelected, value); }

        public DateTime? IssueDate { get => _issueDate; set => SetField(ref _issueDate, value); }

        public DateTime? LastChecked { get => _lastChecked; set => SetField(ref _lastChecked, value); }

        public string LicenseNo { get => _licenseNo; set => SetField(ref _licenseNo, value); }

        public StringEnumValue<LicenseStatus> LicenseStatus { get => _licenseStatus; set => SetField(ref _licenseStatus, value); }

        public string LicenseType { get => _licenseType; set => SetField(ref _licenseType, value); }

        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        public StringEnumValue<State> StateAbbreviation { get => _stateAbbreviation; set => SetField(ref _stateAbbreviation, value); }

        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }
    }
}