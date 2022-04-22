namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DocsSetupRights
    /// </summary>
    public sealed class DocsSetupRights : ParentAccessRights
    {
        /// <summary>
        /// DocsSetupRights ClosingPlanCodes
        /// </summary>
        public bool? ClosingPlanCodes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DocsSetupRights ClosingStackingTemplates
        /// </summary>
        public bool? ClosingStackingTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DocsSetupRights ComplianceAuditSettings
        /// </summary>
        public bool? ComplianceAuditSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DocsSetupRights EDisclosurePackages
        /// </summary>
        public bool? EDisclosurePackages { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DocsSetupRights EDisclosurePlanCodes
        /// </summary>
        public bool? EDisclosurePlanCodes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DocsSetupRights EDisclosureStackingTemplates
        /// </summary>
        public bool? EDisclosureStackingTemplates { get => GetValue<bool?>(); set => SetValue(value); }
    }
}