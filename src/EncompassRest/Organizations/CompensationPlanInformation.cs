using System;

namespace EncompassRest.Organizations
{
    public sealed class CompensationPlanInformation : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?> _endDate;
        private DirtyValue<EntityReference> _plan;
        private DirtyValue<DateTime?> _startDate;

        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        public EntityReference Plan { get => _plan; set => SetField(ref _plan, value); }

        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
    }
}