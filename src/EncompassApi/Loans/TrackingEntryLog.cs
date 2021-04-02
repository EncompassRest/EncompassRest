using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// TrackingEntryLog
    /// </summary>
    public sealed partial class TrackingEntryLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?>? _date;
        private DirtyValue<bool?>? _isChecked;
        private DirtyValue<string?>? _status;
        private DirtyValue<EntityReference?>? _user;

        /// <summary>
        /// TrackingEntryLog Date
        /// </summary>
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// TrackingEntryLog IsChecked
        /// </summary>
        public bool? IsChecked { get => _isChecked; set => SetField(ref _isChecked, value); }

        /// <summary>
        /// TrackingEntryLog Status
        /// </summary>
        public string? Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// TrackingEntryLog User
        /// </summary>
        public EntityReference? User { get => _user; set => SetField(ref _user, value); }
    }
}