using System;

namespace EncompassRest.Company.v1
{
    /// <summary>
    /// Object containing information about the entity's compensation plans.
    /// </summary>
    public sealed class CompensationPlan : DirtyExtensibleObject
    {
        /// <summary>
        /// The start date for the entity's compensation plan. The date that the plan will go into effect for the entity.
        /// </summary>
        public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The end date for the entity's compensation plan.
        /// </summary>
        public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Details about each compensation plan.
        /// </summary>
        public EntityReference? Plan { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}