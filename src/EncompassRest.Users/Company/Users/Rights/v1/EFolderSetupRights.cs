using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EFolderSetupRights
    /// </summary>
    public sealed class EFolderSetupRights : ParentAccessRights
    {
        /// <summary>
        /// EFolderSetupRights ActivateDeactivateConditions
        /// </summary>
        public bool? ActivateDeactivateConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights AddEditCopyConditions
        /// </summary>
        public bool? AddEditCopyConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights ADR
        /// </summary>
        public bool? ADR { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights Conditions
        /// </summary>
        public bool? Conditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights ConditionSets
        /// </summary>
        public bool? ConditionSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights ConditionTypeSettings
        /// </summary>
        public bool? ConditionTypeSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DeleteConditions
        /// </summary>
        public bool? DeleteConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentConversion
        /// </summary>
        public bool? DocumentConversion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentExportTemplates
        /// </summary>
        public bool? DocumentExportTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentGroups
        /// </summary>
        public bool? DocumentGroups { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentIdentification
        /// </summary>
        public bool? DocumentIdentification { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights Documents
        /// </summary>
        public bool? Documents { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentStackingTemplates
        /// </summary>
        public bool? DocumentStackingTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights DocumentTraining
        /// </summary>
        public bool? DocumentTraining { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights EnhancedConditions
        /// </summary>
        public bool? EnhancedConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights EnhancedConditionSets
        /// </summary>
        public bool? EnhancedConditionSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights HTMLEmailTemplates
        /// </summary>
        public bool? HTMLEmailTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights NotificationTemplates
        /// </summary>
        public bool? NotificationTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights PostClosingConditionSets
        /// </summary>
        [JsonProperty("post-ClosingConditionSets")]
        public bool? PostClosingConditionSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights PostClosingConditions
        /// </summary>
        public bool? PostClosingConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditionOptions
        /// </summary>
        public bool? PurchaseConditionOptions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditions
        /// </summary>
        public bool? PurchaseConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights PurchaseConditionSets
        /// </summary>
        public bool? PurchaseConditionSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderSetupRights WebCenterConfiguration
        /// </summary>
        public bool? WebCenterConfiguration { get => GetValue<bool?>(); set => SetValue(value); }
    }
}