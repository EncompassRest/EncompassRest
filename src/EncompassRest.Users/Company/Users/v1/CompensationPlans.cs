using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.v1
{
    /// <summary>
    /// Object containing information about the entity's compensation plans.
    /// </summary>
    public sealed class CompensationPlans : ParentInformation
    {
        /// <summary>
        /// Object containing information about the entity's compensation plans.
        /// </summary>
        [AllowNull]
        public IList<CompensationPlan> Plans { get => GetList<CompensationPlan>(); set => SetList(value); }
    }
}