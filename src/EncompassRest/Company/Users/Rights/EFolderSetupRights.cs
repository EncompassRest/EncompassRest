using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EFolderSetupRights
    /// </summary>
    public sealed class EFolderSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?> _conditions;
        private DirtyValue<bool?> _conditionSets;
        private DirtyValue<bool?> _documentConversion;
        private DirtyValue<bool?> _documentExportTemplates;
        private DirtyValue<bool?> _documentGroups;
        private DirtyValue<bool?> _documentIdentification;
        private DirtyValue<bool?> _documents;
        private DirtyValue<bool?> _documentStackingTemplates;
        private DirtyValue<bool?> _documentTraining;
        private DirtyValue<bool?> _hTMLEmailTemplates;
        private DirtyValue<bool?> _postClosingConditionSets;
        private DirtyValue<bool?> _postClosingConditions;
        private DirtyValue<bool?> _purchaseConditionOptions;
        private DirtyValue<bool?> _purchaseConditions;
        private DirtyValue<bool?> _purchaseConditionSets;
        private DirtyValue<bool?> _webCenterConfiguration;

        /// <summary>
        /// EFolderSetupRights Conditions
        /// </summary>
        public bool? Conditions { get => _conditions; set => SetField(ref _conditions, value); }

        /// <summary>
        /// EFolderSetupRights ConditionSets
        /// </summary>
        public bool? ConditionSets { get => _conditionSets; set => SetField(ref _conditionSets, value); }

        /// <summary>
        /// EFolderSetupRights DocumentConversion
        /// </summary>
        public bool? DocumentConversion { get => _documentConversion; set => SetField(ref _documentConversion, value); }

        /// <summary>
        /// EFolderSetupRights DocumentExportTemplates
        /// </summary>
        public bool? DocumentExportTemplates { get => _documentExportTemplates; set => SetField(ref _documentExportTemplates, value); }

        /// <summary>
        /// EFolderSetupRights DocumentGroups
        /// </summary>
        public bool? DocumentGroups { get => _documentGroups; set => SetField(ref _documentGroups, value); }

        /// <summary>
        /// EFolderSetupRights DocumentIdentification
        /// </summary>
        public bool? DocumentIdentification { get => _documentIdentification; set => SetField(ref _documentIdentification, value); }

        /// <summary>
        /// EFolderSetupRights Documents
        /// </summary>
        public bool? Documents { get => _documents; set => SetField(ref _documents, value); }

        /// <summary>
        /// EFolderSetupRights DocumentStackingTemplates
        /// </summary>
        public bool? DocumentStackingTemplates { get => _documentStackingTemplates; set => SetField(ref _documentStackingTemplates, value); }

        /// <summary>
        /// EFolderSetupRights DocumentTraining
        /// </summary>
        public bool? DocumentTraining { get => _documentTraining; set => SetField(ref _documentTraining, value); }

        /// <summary>
        /// EFolderSetupRights HTMLEmailTemplates
        /// </summary>
        public bool? HTMLEmailTemplates { get => _hTMLEmailTemplates; set => SetField(ref _hTMLEmailTemplates, value); }

        /// <summary>
        /// EFolderSetupRights PostClosingConditionSets
        /// </summary>
        [JsonProperty("post-ClosingConditionSets")]
        public bool? PostClosingConditionSets { get => _postClosingConditionSets; set => SetField(ref _postClosingConditionSets, value); }

        /// <summary>
        /// EFolderSetupRights PostClosingConditions
        /// </summary>
        public bool? PostClosingConditions { get => _postClosingConditions; set => SetField(ref _postClosingConditions, value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditionOptions
        /// </summary>
        public bool? PurchaseConditionOptions { get => _purchaseConditionOptions; set => SetField(ref _purchaseConditionOptions, value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditions
        /// </summary>
        public bool? PurchaseConditions { get => _purchaseConditions; set => SetField(ref _purchaseConditions, value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditionSets
        /// </summary>
        public bool? PurchaseConditionSets { get => _purchaseConditionSets; set => SetField(ref _purchaseConditionSets, value); }

        /// <summary>
        /// EFolderSetupRights WebCenterConfiguration
        /// </summary>
        public bool? WebCenterConfiguration { get => _webCenterConfiguration; set => SetField(ref _webCenterConfiguration, value); }
    }
}