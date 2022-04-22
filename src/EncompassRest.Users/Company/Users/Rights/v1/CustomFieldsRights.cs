using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsRights
    /// </summary>
    public sealed class CustomFieldsRights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsRights CustomFieldsTab1
        /// </summary>
        [AllowNull]
        public CustomFieldsTab1Rights CustomFieldsTab1 { get => GetEntity<CustomFieldsTab1Rights>(); set => SetEntity(value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab2
        /// </summary>
        [AllowNull]
        public CustomFieldsTab2Rights CustomFieldsTab2 { get => GetEntity<CustomFieldsTab2Rights>(); set => SetEntity(value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab3
        /// </summary>
        [AllowNull]
        public CustomFieldsTab3Rights CustomFieldsTab3 { get => GetEntity<CustomFieldsTab3Rights>(); set => SetEntity(value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab4
        /// </summary>
        [AllowNull]
        public CustomFieldsTab4Rights CustomFieldsTab4 { get => GetEntity<CustomFieldsTab4Rights>(); set => SetEntity(value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab5
        /// </summary>
        [AllowNull]
        public CustomFieldsTab5Rights CustomFieldsTab5 { get => GetEntity<CustomFieldsTab5Rights>(); set => SetEntity(value); }
    }
}