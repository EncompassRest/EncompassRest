using System.Collections.Generic;

namespace EncompassRest.Organizations
{
    public sealed class CompensationPlansInformation : ParentInformation
    {
        private DirtyList<CompensationPlanInformation> _plans;

        public IList<CompensationPlanInformation> Plans { get => GetField(ref _plans); set => SetField(ref _plans, value); }
    }
}