namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// BusinessRulesRights
    /// </summary>
    public sealed class BusinessRulesRights : ParentAccessRights
    {
        /// <summary>
        /// BusinessRulesRights AppraisalOrderManagement
        /// </summary>
        public bool? AppraisalOrderManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights AutomatedConditions
        /// </summary>
        public bool? AutomatedConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights AutomatedEnhancedConditions
        /// </summary>
        public bool? AutomatedEnhancedConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights AutomatedPurchaseConditions
        /// </summary>
        public bool? AutomatedPurchaseConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights CollateralTracking
        /// </summary>
        public bool? CollateralTracking { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights FieldDataEntry
        /// </summary>
        public bool? FieldDataEntry { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights FieldTriggers
        /// </summary>
        public bool? FieldTriggers { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights InputFormList
        /// </summary>
        public bool? InputFormList { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights LoanActionCompletion
        /// </summary>
        public bool? LoanActionCompletion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights LoanFolderBusinessRule
        /// </summary>
        public bool? LoanFolderBusinessRule { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights LoanFormPrinting
        /// </summary>
        public bool? LoanFormPrinting { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights LOCompensationRule
        /// </summary>
        public bool? LOCompensationRule { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights MilestoneCompletion
        /// </summary>
        public bool? MilestoneCompletion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoFields
        /// </summary>
        public bool? PersonaAccesstoFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoLoanActions
        /// </summary>
        public bool? PersonaAccesstoLoanActions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoLoans
        /// </summary>
        public bool? PersonaAccesstoLoans { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights PrintAutoSelection
        /// </summary>
        public bool? PrintAutoSelection { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessRulesRights RoleAccesstoDocuments
        /// </summary>
        public bool? RoleAccesstoDocuments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}