using System.Collections.Generic;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// UserCompensation
    /// </summary>
    public sealed class UserCompensation : DirtyExtensibleObject
    {
        private DirtyValue<bool> _useParentInformation;
        private DirtyList<UserCompensationPlan> _plans;

        /// <summary>
        /// UserCompensation UseParentInformation
        /// </summary>
        public bool UseParentInformation { get => _useParentInformation; set => SetField(ref _useParentInformation, value); }

        /// <summary>
        /// UserCompensation Plans
        /// </summary>
        public IList<UserCompensationPlan> Plans { get => GetField(ref _plans); set => SetField(ref _plans, value); }
    }
}