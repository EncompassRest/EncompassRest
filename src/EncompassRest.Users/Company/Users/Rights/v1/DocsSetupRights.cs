namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DocsSetupRights
    /// </summary>
    public sealed class DocsSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _closingPlanCodes;
        private DirtyValue<bool?>? _closingStackingTemplates;
        private DirtyValue<bool?>? _complianceAuditSettings;
        private DirtyValue<bool?>? _eDisclosurePackages;
        private DirtyValue<bool?>? _eDisclosurePlanCodes;
        private DirtyValue<bool?>? _eDisclosureStackingTemplates;

        /// <summary>
        /// DocsSetupRights ClosingPlanCodes
        /// </summary>
        public bool? ClosingPlanCodes { get => _closingPlanCodes; set => SetField(ref _closingPlanCodes, value); }

        /// <summary>
        /// DocsSetupRights ClosingStackingTemplates
        /// </summary>
        public bool? ClosingStackingTemplates { get => _closingStackingTemplates; set => SetField(ref _closingStackingTemplates, value); }

        /// <summary>
        /// DocsSetupRights ComplianceAuditSettings
        /// </summary>
        public bool? ComplianceAuditSettings { get => _complianceAuditSettings; set => SetField(ref _complianceAuditSettings, value); }

        /// <summary>
        /// DocsSetupRights EDisclosurePackages
        /// </summary>
        public bool? EDisclosurePackages { get => _eDisclosurePackages; set => SetField(ref _eDisclosurePackages, value); }

        /// <summary>
        /// DocsSetupRights EDisclosurePlanCodes
        /// </summary>
        public bool? EDisclosurePlanCodes { get => _eDisclosurePlanCodes; set => SetField(ref _eDisclosurePlanCodes, value); }

        /// <summary>
        /// DocsSetupRights EDisclosureStackingTemplates
        /// </summary>
        public bool? EDisclosureStackingTemplates { get => _eDisclosureStackingTemplates; set => SetField(ref _eDisclosureStackingTemplates, value); }
    }
}