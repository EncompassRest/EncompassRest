namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// BusinessRulesRights
    /// </summary>
    public sealed class BusinessRulesRights : ParentAccessRights
    {
        private DirtyValue<bool?> _appraisalOrderManagement;
        private DirtyValue<bool?> _automatedConditions;
        private DirtyValue<bool?> _automatedPurchaseConditions;
        private DirtyValue<bool?> _collateralTracking;
        private DirtyValue<bool?> _fieldDataEntry;
        private DirtyValue<bool?> _fieldTriggers;
        private DirtyValue<bool?> _inputFormList;
        private DirtyValue<bool?> _loanActionCompletion;
        private DirtyValue<bool?> _loanFolderBusinessRule;
        private DirtyValue<bool?> _loanFormPrinting;
        private DirtyValue<bool?> _lOCompensationRule;
        private DirtyValue<bool?> _milestoneCompletion;
        private DirtyValue<bool?> _personaAccesstoFields;
        private DirtyValue<bool?> _personaAccesstoLoanActions;
        private DirtyValue<bool?> _personaAccesstoLoans;
        private DirtyValue<bool?> _printAutoSelection;
        private DirtyValue<bool?> _roleAccesstoDocuments;

        /// <summary>
        /// BusinessRulesRights AppraisalOrderManagement
        /// </summary>
        public bool? AppraisalOrderManagement { get => _appraisalOrderManagement; set => SetField(ref _appraisalOrderManagement, value); }

        /// <summary>
        /// BusinessRulesRights AutomatedConditions
        /// </summary>
        public bool? AutomatedConditions { get => _automatedConditions; set => SetField(ref _automatedConditions, value); }

        /// <summary>
        /// BusinessRulesRights AutomatedPurchaseConditions
        /// </summary>
        public bool? AutomatedPurchaseConditions { get => _automatedPurchaseConditions; set => SetField(ref _automatedPurchaseConditions, value); }

        /// <summary>
        /// BusinessRulesRights CollateralTracking
        /// </summary>
        public bool? CollateralTracking { get => _collateralTracking; set => SetField(ref _collateralTracking, value); }

        /// <summary>
        /// BusinessRulesRights FieldDataEntry
        /// </summary>
        public bool? FieldDataEntry { get => _fieldDataEntry; set => SetField(ref _fieldDataEntry, value); }

        /// <summary>
        /// BusinessRulesRights FieldTriggers
        /// </summary>
        public bool? FieldTriggers { get => _fieldTriggers; set => SetField(ref _fieldTriggers, value); }

        /// <summary>
        /// BusinessRulesRights InputFormList
        /// </summary>
        public bool? InputFormList { get => _inputFormList; set => SetField(ref _inputFormList, value); }

        /// <summary>
        /// BusinessRulesRights LoanActionCompletion
        /// </summary>
        public bool? LoanActionCompletion { get => _loanActionCompletion; set => SetField(ref _loanActionCompletion, value); }

        /// <summary>
        /// BusinessRulesRights LoanFolderBusinessRule
        /// </summary>
        public bool? LoanFolderBusinessRule { get => _loanFolderBusinessRule; set => SetField(ref _loanFolderBusinessRule, value); }

        /// <summary>
        /// BusinessRulesRights LoanFormPrinting
        /// </summary>
        public bool? LoanFormPrinting { get => _loanFormPrinting; set => SetField(ref _loanFormPrinting, value); }

        /// <summary>
        /// BusinessRulesRights LOCompensationRule
        /// </summary>
        public bool? LOCompensationRule { get => _lOCompensationRule; set => SetField(ref _lOCompensationRule, value); }

        /// <summary>
        /// BusinessRulesRights MilestoneCompletion
        /// </summary>
        public bool? MilestoneCompletion { get => _milestoneCompletion; set => SetField(ref _milestoneCompletion, value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoFields
        /// </summary>
        public bool? PersonaAccesstoFields { get => _personaAccesstoFields; set => SetField(ref _personaAccesstoFields, value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoLoanActions
        /// </summary>
        public bool? PersonaAccesstoLoanActions { get => _personaAccesstoLoanActions; set => SetField(ref _personaAccesstoLoanActions, value); }

        /// <summary>
        /// BusinessRulesRights PersonaAccesstoLoans
        /// </summary>
        public bool? PersonaAccesstoLoans { get => _personaAccesstoLoans; set => SetField(ref _personaAccesstoLoans, value); }

        /// <summary>
        /// BusinessRulesRights PrintAutoSelection
        /// </summary>
        public bool? PrintAutoSelection { get => _printAutoSelection; set => SetField(ref _printAutoSelection, value); }

        /// <summary>
        /// BusinessRulesRights RoleAccesstoDocuments
        /// </summary>
        public bool? RoleAccesstoDocuments { get => _roleAccesstoDocuments; set => SetField(ref _roleAccesstoDocuments, value); }
    }
}