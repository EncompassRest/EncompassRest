using System;

namespace EncompassRest.Company
{
    /// <summary>
    /// Object containing information about the entity's compensation plans.
    /// </summary>
    public sealed class CompensationPlan : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?>? _startDate;
        private DirtyValue<DateTime?>? _endDate;
        private DirtyValue<EntityReference?>? _plan;

        /// <summary>
        /// The start date for the entity's compensation plan. The date that the plan will go into effect for the entity.
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        /// <summary>
        /// The end date for the entity's compensation plan.
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        /// <summary>
        /// Details about each compensation plan.
        /// </summary>
        public EntityReference? Plan { get => _plan; set => SetField(ref _plan, value); }
    }
}