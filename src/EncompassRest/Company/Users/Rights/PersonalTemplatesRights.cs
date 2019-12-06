namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PersonalTemplatesRights
    /// </summary>
    public sealed class PersonalTemplatesRights : ParentAccessRights
    {
        private DirtyValue<bool?> _affiliatedBusinessArrangementTemplates;
        private DirtyValue<bool?> _closingCosts;
        private DirtyValue<bool?> _customPrintForms;
        private DirtyValue<bool?> _dataTemplates;
        private DirtyValue<bool?> _documentSets;
        private DirtyValue<bool?> _inputFormSets;
        private LoanProgramsRights _loanPrograms;
        private DirtyValue<bool?> _loanTemplateSets;
        private DirtyValue<bool?> _printFormGroups;
        private DirtyValue<bool?> _settlementServiceProviders;
        private DirtyValue<bool?> _taskSets;

        /// <summary>
        /// PersonalTemplatesRights AffiliatedBusinessArrangementTemplates
        /// </summary>
        public bool? AffiliatedBusinessArrangementTemplates { get => _affiliatedBusinessArrangementTemplates; set => SetField(ref _affiliatedBusinessArrangementTemplates, value); }

        /// <summary>
        /// PersonalTemplatesRights ClosingCosts
        /// </summary>
        public bool? ClosingCosts { get => _closingCosts; set => SetField(ref _closingCosts, value); }

        /// <summary>
        /// PersonalTemplatesRights CustomPrintForms
        /// </summary>
        public bool? CustomPrintForms { get => _customPrintForms; set => SetField(ref _customPrintForms, value); }

        /// <summary>
        /// PersonalTemplatesRights DataTemplates
        /// </summary>
        public bool? DataTemplates { get => _dataTemplates; set => SetField(ref _dataTemplates, value); }

        /// <summary>
        /// PersonalTemplatesRights DocumentSets
        /// </summary>
        public bool? DocumentSets { get => _documentSets; set => SetField(ref _documentSets, value); }

        /// <summary>
        /// PersonalTemplatesRights InputFormSets
        /// </summary>
        public bool? InputFormSets { get => _inputFormSets; set => SetField(ref _inputFormSets, value); }

        /// <summary>
        /// PersonalTemplatesRights LoanPrograms
        /// </summary>
        public LoanProgramsRights LoanPrograms { get => GetField(ref _loanPrograms); set => SetField(ref _loanPrograms, value); }

        /// <summary>
        /// PersonalTemplatesRights LoanTemplateSets
        /// </summary>
        public bool? LoanTemplateSets { get => _loanTemplateSets; set => SetField(ref _loanTemplateSets, value); }

        /// <summary>
        /// PersonalTemplatesRights PrintFormGroups
        /// </summary>
        public bool? PrintFormGroups { get => _printFormGroups; set => SetField(ref _printFormGroups, value); }

        /// <summary>
        /// PersonalTemplatesRights SettlementServiceProviders
        /// </summary>
        public bool? SettlementServiceProviders { get => _settlementServiceProviders; set => SetField(ref _settlementServiceProviders, value); }

        /// <summary>
        /// PersonalTemplatesRights TaskSets
        /// </summary>
        public bool? TaskSets { get => _taskSets; set => SetField(ref _taskSets, value); }
    }
}