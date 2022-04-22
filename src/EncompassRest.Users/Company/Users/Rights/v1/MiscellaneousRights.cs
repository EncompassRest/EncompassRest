using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MiscellaneousRights
    /// </summary>
    public sealed class MiscellaneousRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MiscellaneousRights EFolderAccess
        /// </summary>
        [JsonProperty("eFolder_Access")]
        public bool? EFolderAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderArchive
        /// </summary>
        [JsonProperty("eFolder_Archive")]
        public bool? EFolderArchive { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderAssignAs
        /// </summary>
        [JsonProperty("eFolder_AssignAs")]
        public bool? EFolderAssignAs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderAttachDoc
        /// </summary>
        [JsonProperty("eFolder_AttachDoc")]
        public bool? EFolderAttachDoc { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderConditionsAddBusinessRuleUnderwriting
        /// </summary>
        [JsonProperty("eFolder_Conditions_AddBusinessRuleUnderwriting")]
        public bool? EFolderConditionsAddBusinessRuleUnderwriting { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderDeleteDoc
        /// </summary>
        [JsonProperty("eFolder_DeleteDoc")]
        public bool? EFolderDeleteDoc { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderDownloadFaxes
        /// </summary>
        [JsonProperty("eFolder_DownloadFaxes")]
        public bool? EFolderDownloadFaxes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderRequestDoc
        /// </summary>
        [JsonProperty("eFolder_RequestDoc")]
        public bool? EFolderRequestDoc { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderSendDoc
        /// </summary>
        [JsonProperty("eFolder_SendDoc")]
        public bool? EFolderSendDoc { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights EFolderUFApprover
        /// </summary>
        [JsonProperty("eFolder_UF_Approver")]
        public bool? EFolderUFApprover { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights ExternalSettingsTPOWCDocs
        /// </summary>
        [JsonProperty("externalSettings_TPOWCDocs")]
        public bool? ExternalSettingsTPOWCDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights ExternalSettingsTPOWCSiteManagement
        /// </summary>
        [JsonProperty("externalSettings_TPOWCSiteManagement")]
        public bool? ExternalSettingsTPOWCSiteManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights FannieMaeUCDTransfer
        /// </summary>
        [JsonProperty("fannie_Mae_UCD_Transfer")]
        public bool? FannieMaeUCDTransfer { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights FreddieMacCAC
        /// </summary>
        [JsonProperty("freddie_Mac_CAC")]
        public bool? FreddieMacCAC { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights FreddieMacLPABatch
        /// </summary>
        [JsonProperty("freddie_Mac_LPA_Batch")]
        public bool? FreddieMacLPABatch { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights GlobalTabNews
        /// </summary>
        [JsonProperty("globalTab_News")]
        public bool? GlobalTabNews { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights InputFormsShowAllFormsCheckBox
        /// </summary>
        [JsonProperty("inputForms_ShowAllFormsCheckBox")]
        public bool? InputFormsShowAllFormsCheckBox { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights InstantMessenger
        /// </summary>
        public bool? InstantMessenger { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtDownload
        /// </summary>
        [JsonProperty("loanMgmt_Download")]
        public bool? LoanMgmtDownload { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtDuplicateBlank
        /// </summary>
        [JsonProperty("loanMgmt_Duplicate_Blank")]
        public bool? LoanMgmtDuplicateBlank { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtUpload
        /// </summary>
        [JsonProperty("loanMgmt_Upload")]
        public bool? LoanMgmtUpload { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanTabeFolderDTModifyProtectedDocAndFiles
        /// </summary>
        [JsonProperty("loanTab_eFolder_DT_ModifyProtectedDocAndFiles")]
        public bool? LoanTabeFolderDTModifyProtectedDocAndFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanTabeFolderDTNewEditFiles
        /// </summary>
        [JsonProperty("loanTab_eFolder_DT_NewEditFiles")]
        public bool? LoanTabeFolderDTNewEditFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights LoanTabOtherExclusiveLock
        /// </summary>
        [JsonProperty("loanTab_Other_ExclusiveLock")]
        public bool? LoanTabOtherExclusiveLock { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights PlatFormAccess
        /// </summary>
        [JsonProperty("platForm_Access")]
        public bool? PlatFormAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAffiliatedBusinessArrangementTemplates
        /// </summary>
        [JsonProperty("settingsTab_AffiliatedBusinessArrangementTemplates")]
        public bool? SettingsTabAffiliatedBusinessArrangementTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAllTPOContactInformation
        /// </summary>
        [JsonProperty("settingsTab_AllTPOContactInformation")]
        public bool? SettingsTabAllTPOContactInformation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAutomatedDisclosures
        /// </summary>
        [JsonProperty("settingsTab_AutomatedDisclosures")]
        public bool? SettingsTabAutomatedDisclosures { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingCosts
        /// </summary>
        [JsonProperty("settingsTab_ClosingCosts")]
        public bool? SettingsTabClosingCosts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingPlanCodes
        /// </summary>
        [JsonProperty("settingsTab_ClosingPlanCodes")]
        public bool? SettingsTabClosingPlanCodes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingStackingTemplates
        /// </summary>
        [JsonProperty("settingsTab_ClosingStackingTemplates")]
        public bool? SettingsTabClosingStackingTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyDetails
        /// </summary>
        [JsonProperty("settingsTab_CompanyDetails")]
        public bool? SettingsTabCompanyDetails { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyCompanySettingsObsolete
        /// </summary>
        [JsonProperty("settingsTab_Company_CompanySettings_Obsolete")]
        public bool? SettingsTabCompanyCompanySettingsObsolete { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyConditionSetup
        /// </summary>
        [JsonProperty("settingsTab_Company_ConditionSetup")]
        public bool? SettingsTabCompanyConditionSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyConfigurableKeyDates
        /// </summary>
        [JsonProperty("settingsTab_Company_ConfigurableKeyDates")]
        public bool? SettingsTabCompanyConfigurableKeyDates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyDocumentSetup
        /// </summary>
        [JsonProperty("settingsTab_Company_DocumentSetup")]
        public bool? SettingsTabCompanyDocumentSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabComplianceReviewSetup
        /// </summary>
        [JsonProperty("settingsTab_ComplianceReviewSetup")]
        public bool? SettingsTabComplianceReviewSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabConditionForms
        /// </summary>
        [JsonProperty("settingsTab_ConditionForms")]
        public bool? SettingsTabConditionForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCurrentLogins
        /// </summary>
        [JsonProperty("settingsTab_CurrentLogins")]
        public bool? SettingsTabCurrentLogins { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCustomPrintForms
        /// </summary>
        [JsonProperty("settingsTab_CustomPrintForms")]
        public bool? SettingsTabCustomPrintForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabDataTemplates
        /// </summary>
        [JsonProperty("settingsTab_DataTemplates")]
        public bool? SettingsTabDataTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabDocumentSets
        /// </summary>
        [JsonProperty("settingsTab_DocumentSets")]
        public bool? SettingsTabDocumentSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabEDisclosurePlanCodes
        /// </summary>
        [JsonProperty("settingsTab_EDisclosurePlanCodes")]
        public bool? SettingsTabEDisclosurePlanCodes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabEDisclosureStackingTemplates
        /// </summary>
        [JsonProperty("settingsTab_EDisclosureStackingTemplates")]
        public bool? SettingsTabEDisclosureStackingTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabExtCompany
        /// </summary>
        [JsonProperty("settingsTab_ExtCompany")]
        public bool? SettingsTabExtCompany { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabInputFormSets
        /// </summary>
        [JsonProperty("settingsTab_InputFormSets")]
        public bool? SettingsTabInputFormSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRightsSettingsTabInsightsSetup
        /// </summary>
        [JsonProperty("settingsTab_InsightsSetup")]
        public bool? SettingsTabInsightsSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabItemizationFeeManagement
        /// </summary>
        [JsonProperty("settingsTab_ItemizationFeeManagement")]
        public bool? SettingsTabItemizationFeeManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanCustomFields
        /// </summary>
        [JsonProperty("settingsTab_LoanCustomFields")]
        public bool? SettingsTabLoanCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanErrorInformation
        /// </summary>
        [JsonProperty("settingsTab_LoanErrorInformation")]
        public bool? SettingsTabLoanErrorInformation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanPrograms
        /// </summary>
        [JsonProperty("settingsTab_LoanPrograms")]
        public bool? SettingsTabLoanPrograms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanReassignment
        /// </summary>
        [JsonProperty("settingsTab_LoanReassignment")]
        public bool? SettingsTabLoanReassignment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanTemplateSets
        /// </summary>
        [JsonProperty("settingsTab_LoanTemplateSets")]
        public bool? SettingsTabLoanTemplateSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabPrintFormGroups
        /// </summary>
        [JsonProperty("settingsTab_PrintFormGroups")]
        public bool? SettingsTabPrintFormGroups { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabPublicBusinessContactGroups
        /// </summary>
        [JsonProperty("settingsTab_PublicBusinessContactGroups")]
        public bool? SettingsTabPublicBusinessContactGroups { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabRebuildPipeline
        /// </summary>
        [JsonProperty("settingsTab_RebuildPipeline")]
        public bool? SettingsTabRebuildPipeline { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSecondaryRoot
        /// </summary>
        [JsonProperty("settingsTab_SecondaryRoot")]
        public bool? SettingsTabSecondaryRoot { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSettingsReport
        /// </summary>
        [JsonProperty("settingsTab_SettingsReport")]
        public bool? SettingsTabSettingsReport { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSettlementServiceProviders
        /// </summary>
        [JsonProperty("settingsTab_SettlementServiceProviders")]
        public bool? SettingsTabSettlementServiceProviders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSystemAuditTrail
        /// </summary>
        [JsonProperty("settingsTab_SystemAuditTrail")]
        public bool? SettingsTabSystemAuditTrail { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTablesFees
        /// </summary>
        [JsonProperty("settingsTab_TablesFees")]
        public bool? SettingsTabTablesFees { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTaskSets
        /// </summary>
        [JsonProperty("settingsTab_TaskSets")]
        public bool? SettingsTabTaskSets { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoCustomFields
        /// </summary>
        [JsonProperty("settingsTab_TpoCustomFields")]
        public bool? SettingsTabTpoCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoFees
        /// </summary>
        [JsonProperty("settingsTab_TpoFees")]
        public bool? SettingsTabTpoFees { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoReassignment
        /// </summary>
        [JsonProperty("settingsTab_TpoReassignment")]
        public bool? SettingsTabTpoReassignment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoSettings
        /// </summary>
        [JsonProperty("settingsTab_TpoSettings")]
        public bool? SettingsTabTpoSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoWebCenterDocs
        /// </summary>
        [JsonProperty("settingsTab_TpoWebCenterDocs")]
        public bool? SettingsTabTpoWebCenterDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabUnlockLoanFile
        /// </summary>
        [JsonProperty("settingsTab_UnlockLoanFile")]
        public bool? SettingsTabUnlockLoanFile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights ThinThickPipelineTabAccess
        /// </summary>
        [JsonProperty("thinThick_PipelineTab_Access")]
        public bool? ThinThickPipelineTabAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights ThinThickTradesTabAccess
        /// </summary>
        [JsonProperty("thinThick_TradesTab_Access")]
        public bool? ThinThickTradesTabAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabShowAsMgrAdminInBranchesTab
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ShowAsMgrAdminInBranchesTab")]
        public bool? TPOAdministrationTabShowAsMgrAdminInBranchesTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabShowAsMgrAdminInCompanyInfoTab
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ShowAsMgrAdminInCompanyInfoTab")]
        public bool? TPOAdministrationTabShowAsMgrAdminInCompanyInfoTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabViewCmtConfirmations
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ViewCmtConfirmations")]
        public bool? TPOAdministrationTabViewCmtConfirmations { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MiscellaneousRights TradeTabEditTrades
        /// </summary>
        [JsonProperty("tradeTab_EditTrades")]
        public bool? TradeTabEditTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}