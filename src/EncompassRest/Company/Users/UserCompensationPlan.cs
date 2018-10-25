using System;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// UserCompensationPlan
    /// </summary>
    public sealed class UserCompensationPlan : DirtyExtensibleObject
    {
        private DirtyValue<DateTime> _startDate;
        private EntityReference _plan;

        /// <summary>
        /// UserCompensationPlan StartDate
        /// </summary>
        public DateTime StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        /// <summary>
        /// UserCompensationPlan Plan
        /// </summary>
        public EntityReference Plan { get => GetField(ref _plan); set => SetField(ref _plan, value); }
    }
}