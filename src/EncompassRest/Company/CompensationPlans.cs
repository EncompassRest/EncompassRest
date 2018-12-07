using System.Collections.Generic;

namespace EncompassRest.Company
{
    /// <summary>
    /// Object containing information about the entity's compensation plans.
    /// </summary>
    public sealed class CompensationPlans : ParentInformation
    {
        private DirtyList<CompensationPlan> _plans;

        /// <summary>
        /// Object containing information about the entity's compensation plans.
        /// </summary>
        public IList<CompensationPlan> Plans { get => GetField(ref _plans); set => SetField(ref _plans, value); }
    }
}