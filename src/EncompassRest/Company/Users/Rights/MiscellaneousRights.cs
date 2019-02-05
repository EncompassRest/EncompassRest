using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// MiscellaneousRights
    /// </summary>
    public sealed class MiscellaneousRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _eFolderAccess;
        private DirtyValue<bool?> _eFolderArchive;
        private DirtyValue<bool?> _eFolderAssignAs;
        private DirtyValue<bool?> _eFolderAttachDoc;
        private DirtyValue<bool?> _eFolderConditionsAddBusinessRuleUnderwriting;
        private DirtyValue<bool?> _eFolderDeleteDoc;
        private DirtyValue<bool?> _eFolderDownloadFaxes;
        private DirtyValue<bool?> _eFolderRequestDoc;
        private DirtyValue<bool?> _eFolderSendDoc;
        private DirtyValue<bool?> _eFolderUFApprover;
        private DirtyValue<bool?> _externalSettingsTPOWCDocs;
        private DirtyValue<bool?> _externalSettingsTPOWCSiteManagement;
        private DirtyValue<bool?> _fannieMaeUCDTransfer;
        private DirtyValue<bool?> _freddieMacCAC;
        private DirtyValue<bool?> _globalTabNews;
        private DirtyValue<bool?> _inputFormsShowAllFormsCheckBox;
        private DirtyValue<bool?> _instantMessenger;
        private DirtyValue<bool?> _loanMgmtDownload;
        private DirtyValue<bool?> _loanMgmtDuplicateBlank;
        private DirtyValue<bool?> _loanMgmtUpload;
        private DirtyValue<bool?> _loanTabeFolderDTModifyProtectedDocAndFiles;
        private DirtyValue<bool?> _loanTabeFolderDTNewEditFiles;
        private DirtyValue<bool?> _loanTabOtherExclusiveLock;
        private DirtyValue<bool?> _platFormAccess;
        private DirtyValue<bool?> _settingsTabAffiliatedBusinessArrangementTemplates;
        private DirtyValue<bool?> _settingsTabAllTPOContactInformation;
        private DirtyValue<bool?> _settingsTabAutomatedDisclosures;
        private DirtyValue<bool?> _settingsTabClosingCosts;
        private DirtyValue<bool?> _settingsTabClosingPlanCodes;
        private DirtyValue<bool?> _settingsTabClosingStackingTemplates;
        private DirtyValue<bool?> _settingsTabCompanyDetails;
        private DirtyValue<bool?> _settingsTabCompanyCompanySettingsObsolete;
        private DirtyValue<bool?> _settingsTabCompanyConditionSetup;
        private DirtyValue<bool?> _settingsTabCompanyConfigurableKeyDates;
        private DirtyValue<bool?> _settingsTabCompanyDocumentSetup;
        private DirtyValue<bool?> _settingsTabComplianceReviewSetup;
        private DirtyValue<bool?> _settingsTabConditionForms;
        private DirtyValue<bool?> _settingsTabCurrentLogins;
        private DirtyValue<bool?> _settingsTabCustomPrintForms;
        private DirtyValue<bool?> _settingsTabDataTemplates;
        private DirtyValue<bool?> _settingsTabDocumentSets;
        private DirtyValue<bool?> _settingsTabEDisclosurePlanCodes;
        private DirtyValue<bool?> _settingsTabEDisclosureStackingTemplates;
        private DirtyValue<bool?> _settingsTabExtCompany;
        private DirtyValue<bool?> _settingsTabInputFormSets;
        private DirtyValue<bool?> _settingsTabInsightsSetup;
        private DirtyValue<bool?> _settingsTabItemizationFeeManagement;
        private DirtyValue<bool?> _settingsTabLoanCustomFields;
        private DirtyValue<bool?> _settingsTabLoanErrorInformation;
        private DirtyValue<bool?> _settingsTabLoanPrograms;
        private DirtyValue<bool?> _settingsTabLoanReassignment;
        private DirtyValue<bool?> _settingsTabLoanTemplateSets;
        private DirtyValue<bool?> _settingsTabPrintFormGroups;
        private DirtyValue<bool?> _settingsTabPublicBusinessContactGroups;
        private DirtyValue<bool?> _settingsTabRebuildPipeline;
        private DirtyValue<bool?> _settingsTabSecondaryRoot;
        private DirtyValue<bool?> _settingsTabSettingsReport;
        private DirtyValue<bool?> _settingsTabSettlementServiceProviders;
        private DirtyValue<bool?> _settingsTabSystemAuditTrail;
        private DirtyValue<bool?> _settingsTabTablesFees;
        private DirtyValue<bool?> _settingsTabTaskSets;
        private DirtyValue<bool?> _settingsTabTpoCustomFields;
        private DirtyValue<bool?> _settingsTabTpoFees;
        private DirtyValue<bool?> _settingsTabTpoReassignment;
        private DirtyValue<bool?> _settingsTabTpoSettings;
        private DirtyValue<bool?> _settingsTabTpoWebCenterDocs;
        private DirtyValue<bool?> _settingsTabUnlockLoanFile;
        private DirtyValue<bool?> _thinThickPipelineTabAccess;
        private DirtyValue<bool?> _thinThickTradesTabAccess;
        private DirtyValue<bool?> _tPOAdministrationTabShowAsMgrAdminInBranchesTab;
        private DirtyValue<bool?> _tPOAdministrationTabShowAsMgrAdminInCompanyInfoTab;
        private DirtyValue<bool?> _tPOAdministrationTabViewCmtConfirmations;

        /// <summary>
        /// MiscellaneousRights EFolderAccess
        /// </summary>
        [JsonProperty("eFolder_Access")]
        public bool? EFolderAccess { get => _eFolderAccess; set => SetField(ref _eFolderAccess, value); }

        /// <summary>
        /// MiscellaneousRights EFolderArchive
        /// </summary>
        [JsonProperty("eFolder_Archive")]
        public bool? EFolderArchive { get => _eFolderArchive; set => SetField(ref _eFolderArchive, value); }

        /// <summary>
        /// MiscellaneousRights EFolderAssignAs
        /// </summary>
        [JsonProperty("eFolder_AssignAs")]
        public bool? EFolderAssignAs { get => _eFolderAssignAs; set => SetField(ref _eFolderAssignAs, value); }

        /// <summary>
        /// MiscellaneousRights EFolderAttachDoc
        /// </summary>
        [JsonProperty("eFolder_AttachDoc")]
        public bool? EFolderAttachDoc { get => _eFolderAttachDoc; set => SetField(ref _eFolderAttachDoc, value); }

        /// <summary>
        /// MiscellaneousRights EFolderConditionsAddBusinessRuleUnderwriting
        /// </summary>
        [JsonProperty("eFolder_Conditions_AddBusinessRuleUnderwriting")]
        public bool? EFolderConditionsAddBusinessRuleUnderwriting { get => _eFolderConditionsAddBusinessRuleUnderwriting; set => SetField(ref _eFolderConditionsAddBusinessRuleUnderwriting, value); }

        /// <summary>
        /// MiscellaneousRights EFolderDeleteDoc
        /// </summary>
        [JsonProperty("eFolder_DeleteDoc")]
        public bool? EFolderDeleteDoc { get => _eFolderDeleteDoc; set => SetField(ref _eFolderDeleteDoc, value); }

        /// <summary>
        /// MiscellaneousRights EFolderDownloadFaxes
        /// </summary>
        [JsonProperty("eFolder_DownloadFaxes")]
        public bool? EFolderDownloadFaxes { get => _eFolderDownloadFaxes; set => SetField(ref _eFolderDownloadFaxes, value); }

        /// <summary>
        /// MiscellaneousRights EFolderRequestDoc
        /// </summary>
        [JsonProperty("eFolder_RequestDoc")]
        public bool? EFolderRequestDoc { get => _eFolderRequestDoc; set => SetField(ref _eFolderRequestDoc, value); }

        /// <summary>
        /// MiscellaneousRights EFolderSendDoc
        /// </summary>
        [JsonProperty("eFolder_SendDoc")]
        public bool? EFolderSendDoc { get => _eFolderSendDoc; set => SetField(ref _eFolderSendDoc, value); }

        /// <summary>
        /// MiscellaneousRights EFolderUFApprover
        /// </summary>
        [JsonProperty("eFolder_UF_Approver")]
        public bool? EFolderUFApprover { get => _eFolderUFApprover; set => SetField(ref _eFolderUFApprover, value); }

        /// <summary>
        /// MiscellaneousRights ExternalSettingsTPOWCDocs
        /// </summary>
        [JsonProperty("externalSettings_TPOWCDocs")]
        public bool? ExternalSettingsTPOWCDocs { get => _externalSettingsTPOWCDocs; set => SetField(ref _externalSettingsTPOWCDocs, value); }

        /// <summary>
        /// MiscellaneousRights ExternalSettingsTPOWCSiteManagement
        /// </summary>
        [JsonProperty("externalSettings_TPOWCSiteManagement")]
        public bool? ExternalSettingsTPOWCSiteManagement { get => _externalSettingsTPOWCSiteManagement; set => SetField(ref _externalSettingsTPOWCSiteManagement, value); }

        /// <summary>
        /// MiscellaneousRights FannieMaeUCDTransfer
        /// </summary>
        [JsonProperty("fannie_Mae_UCD_Transfer")]
        public bool? FannieMaeUCDTransfer { get => _fannieMaeUCDTransfer; set => SetField(ref _fannieMaeUCDTransfer, value); }

        /// <summary>
        /// MiscellaneousRights FreddieMacCAC
        /// </summary>
        [JsonProperty("freddie_Mac_CAC")]
        public bool? FreddieMacCAC { get => _freddieMacCAC; set => SetField(ref _freddieMacCAC, value); }

        /// <summary>
        /// MiscellaneousRights GlobalTabNews
        /// </summary>
        [JsonProperty("globalTab_News")]
        public bool? GlobalTabNews { get => _globalTabNews; set => SetField(ref _globalTabNews, value); }

        /// <summary>
        /// MiscellaneousRights InputFormsShowAllFormsCheckBox
        /// </summary>
        [JsonProperty("inputForms_ShowAllFormsCheckBox")]
        public bool? InputFormsShowAllFormsCheckBox { get => _inputFormsShowAllFormsCheckBox; set => SetField(ref _inputFormsShowAllFormsCheckBox, value); }

        /// <summary>
        /// MiscellaneousRights InstantMessenger
        /// </summary>
        public bool? InstantMessenger { get => _instantMessenger; set => SetField(ref _instantMessenger, value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtDownload
        /// </summary>
        [JsonProperty("loanMgmt_Download")]
        public bool? LoanMgmtDownload { get => _loanMgmtDownload; set => SetField(ref _loanMgmtDownload, value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtDuplicateBlank
        /// </summary>
        [JsonProperty("loanMgmt_Duplicate_Blank")]
        public bool? LoanMgmtDuplicateBlank { get => _loanMgmtDuplicateBlank; set => SetField(ref _loanMgmtDuplicateBlank, value); }

        /// <summary>
        /// MiscellaneousRights LoanMgmtUpload
        /// </summary>
        [JsonProperty("loanMgmt_Upload")]
        public bool? LoanMgmtUpload { get => _loanMgmtUpload; set => SetField(ref _loanMgmtUpload, value); }

        /// <summary>
        /// MiscellaneousRights LoanTabeFolderDTModifyProtectedDocAndFiles
        /// </summary>
        [JsonProperty("loanTab_eFolder_DT_ModifyProtectedDocAndFiles")]
        public bool? LoanTabeFolderDTModifyProtectedDocAndFiles { get => _loanTabeFolderDTModifyProtectedDocAndFiles; set => SetField(ref _loanTabeFolderDTModifyProtectedDocAndFiles, value); }

        /// <summary>
        /// MiscellaneousRights LoanTabeFolderDTNewEditFiles
        /// </summary>
        [JsonProperty("loanTab_eFolder_DT_NewEditFiles")]
        public bool? LoanTabeFolderDTNewEditFiles { get => _loanTabeFolderDTNewEditFiles; set => SetField(ref _loanTabeFolderDTNewEditFiles, value); }

        /// <summary>
        /// MiscellaneousRights LoanTabOtherExclusiveLock
        /// </summary>
        [JsonProperty("loanTab_Other_ExclusiveLock")]
        public bool? LoanTabOtherExclusiveLock { get => _loanTabOtherExclusiveLock; set => SetField(ref _loanTabOtherExclusiveLock, value); }

        /// <summary>
        /// MiscellaneousRights PlatFormAccess
        /// </summary>
        [JsonProperty("platForm_Access")]
        public bool? PlatFormAccess { get => _platFormAccess; set => SetField(ref _platFormAccess, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAffiliatedBusinessArrangementTemplates
        /// </summary>
        [JsonProperty("settingsTab_AffiliatedBusinessArrangementTemplates")]
        public bool? SettingsTabAffiliatedBusinessArrangementTemplates { get => _settingsTabAffiliatedBusinessArrangementTemplates; set => SetField(ref _settingsTabAffiliatedBusinessArrangementTemplates, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAllTPOContactInformation
        /// </summary>
        [JsonProperty("settingsTab_AllTPOContactInformation")]
        public bool? SettingsTabAllTPOContactInformation { get => _settingsTabAllTPOContactInformation; set => SetField(ref _settingsTabAllTPOContactInformation, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabAutomatedDisclosures
        /// </summary>
        [JsonProperty("settingsTab_AutomatedDisclosures")]
        public bool? SettingsTabAutomatedDisclosures { get => _settingsTabAutomatedDisclosures; set => SetField(ref _settingsTabAutomatedDisclosures, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingCosts
        /// </summary>
        [JsonProperty("settingsTab_ClosingCosts")]
        public bool? SettingsTabClosingCosts { get => _settingsTabClosingCosts; set => SetField(ref _settingsTabClosingCosts, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingPlanCodes
        /// </summary>
        [JsonProperty("settingsTab_ClosingPlanCodes")]
        public bool? SettingsTabClosingPlanCodes { get => _settingsTabClosingPlanCodes; set => SetField(ref _settingsTabClosingPlanCodes, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabClosingStackingTemplates
        /// </summary>
        [JsonProperty("settingsTab_ClosingStackingTemplates")]
        public bool? SettingsTabClosingStackingTemplates { get => _settingsTabClosingStackingTemplates; set => SetField(ref _settingsTabClosingStackingTemplates, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyDetails
        /// </summary>
        [JsonProperty("settingsTab_CompanyDetails")]
        public bool? SettingsTabCompanyDetails { get => _settingsTabCompanyDetails; set => SetField(ref _settingsTabCompanyDetails, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyCompanySettingsObsolete
        /// </summary>
        [JsonProperty("settingsTab_Company_CompanySettings_Obsolete")]
        public bool? SettingsTabCompanyCompanySettingsObsolete { get => _settingsTabCompanyCompanySettingsObsolete; set => SetField(ref _settingsTabCompanyCompanySettingsObsolete, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyConditionSetup
        /// </summary>
        [JsonProperty("settingsTab_Company_ConditionSetup")]
        public bool? SettingsTabCompanyConditionSetup { get => _settingsTabCompanyConditionSetup; set => SetField(ref _settingsTabCompanyConditionSetup, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyConfigurableKeyDates
        /// </summary>
        [JsonProperty("settingsTab_Company_ConfigurableKeyDates")]
        public bool? SettingsTabCompanyConfigurableKeyDates { get => _settingsTabCompanyConfigurableKeyDates; set => SetField(ref _settingsTabCompanyConfigurableKeyDates, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCompanyDocumentSetup
        /// </summary>
        [JsonProperty("settingsTab_Company_DocumentSetup")]
        public bool? SettingsTabCompanyDocumentSetup { get => _settingsTabCompanyDocumentSetup; set => SetField(ref _settingsTabCompanyDocumentSetup, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabComplianceReviewSetup
        /// </summary>
        [JsonProperty("settingsTab_ComplianceReviewSetup")]
        public bool? SettingsTabComplianceReviewSetup { get => _settingsTabComplianceReviewSetup; set => SetField(ref _settingsTabComplianceReviewSetup, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabConditionForms
        /// </summary>
        [JsonProperty("settingsTab_ConditionForms")]
        public bool? SettingsTabConditionForms { get => _settingsTabConditionForms; set => SetField(ref _settingsTabConditionForms, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCurrentLogins
        /// </summary>
        [JsonProperty("settingsTab_CurrentLogins")]
        public bool? SettingsTabCurrentLogins { get => _settingsTabCurrentLogins; set => SetField(ref _settingsTabCurrentLogins, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabCustomPrintForms
        /// </summary>
        [JsonProperty("settingsTab_CustomPrintForms")]
        public bool? SettingsTabCustomPrintForms { get => _settingsTabCustomPrintForms; set => SetField(ref _settingsTabCustomPrintForms, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabDataTemplates
        /// </summary>
        [JsonProperty("settingsTab_DataTemplates")]
        public bool? SettingsTabDataTemplates { get => _settingsTabDataTemplates; set => SetField(ref _settingsTabDataTemplates, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabDocumentSets
        /// </summary>
        [JsonProperty("settingsTab_DocumentSets")]
        public bool? SettingsTabDocumentSets { get => _settingsTabDocumentSets; set => SetField(ref _settingsTabDocumentSets, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabEDisclosurePlanCodes
        /// </summary>
        [JsonProperty("settingsTab_EDisclosurePlanCodes")]
        public bool? SettingsTabEDisclosurePlanCodes { get => _settingsTabEDisclosurePlanCodes; set => SetField(ref _settingsTabEDisclosurePlanCodes, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabEDisclosureStackingTemplates
        /// </summary>
        [JsonProperty("settingsTab_EDisclosureStackingTemplates")]
        public bool? SettingsTabEDisclosureStackingTemplates { get => _settingsTabEDisclosureStackingTemplates; set => SetField(ref _settingsTabEDisclosureStackingTemplates, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabExtCompany
        /// </summary>
        [JsonProperty("settingsTab_ExtCompany")]
        public bool? SettingsTabExtCompany { get => _settingsTabExtCompany; set => SetField(ref _settingsTabExtCompany, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabInputFormSets
        /// </summary>
        [JsonProperty("settingsTab_InputFormSets")]
        public bool? SettingsTabInputFormSets { get => _settingsTabInputFormSets; set => SetField(ref _settingsTabInputFormSets, value); }

        /// <summary>
        /// MiscellaneousRightsSettingsTabInsightsSetup
        /// </summary>
        [JsonProperty("settingsTab_InsightsSetup")]
        public bool? SettingsTabInsightsSetup { get => _settingsTabInsightsSetup; set => SetField(ref _settingsTabInsightsSetup, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabItemizationFeeManagement
        /// </summary>
        [JsonProperty("settingsTab_ItemizationFeeManagement")]
        public bool? SettingsTabItemizationFeeManagement { get => _settingsTabItemizationFeeManagement; set => SetField(ref _settingsTabItemizationFeeManagement, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanCustomFields
        /// </summary>
        [JsonProperty("settingsTab_LoanCustomFields")]
        public bool? SettingsTabLoanCustomFields { get => _settingsTabLoanCustomFields; set => SetField(ref _settingsTabLoanCustomFields, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanErrorInformation
        /// </summary>
        [JsonProperty("settingsTab_LoanErrorInformation")]
        public bool? SettingsTabLoanErrorInformation { get => _settingsTabLoanErrorInformation; set => SetField(ref _settingsTabLoanErrorInformation, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanPrograms
        /// </summary>
        [JsonProperty("settingsTab_LoanPrograms")]
        public bool? SettingsTabLoanPrograms { get => _settingsTabLoanPrograms; set => SetField(ref _settingsTabLoanPrograms, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanReassignment
        /// </summary>
        [JsonProperty("settingsTab_LoanReassignment")]
        public bool? SettingsTabLoanReassignment { get => _settingsTabLoanReassignment; set => SetField(ref _settingsTabLoanReassignment, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabLoanTemplateSets
        /// </summary>
        [JsonProperty("settingsTab_LoanTemplateSets")]
        public bool? SettingsTabLoanTemplateSets { get => _settingsTabLoanTemplateSets; set => SetField(ref _settingsTabLoanTemplateSets, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabPrintFormGroups
        /// </summary>
        [JsonProperty("settingsTab_PrintFormGroups")]
        public bool? SettingsTabPrintFormGroups { get => _settingsTabPrintFormGroups; set => SetField(ref _settingsTabPrintFormGroups, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabPublicBusinessContactGroups
        /// </summary>
        [JsonProperty("settingsTab_PublicBusinessContactGroups")]
        public bool? SettingsTabPublicBusinessContactGroups { get => _settingsTabPublicBusinessContactGroups; set => SetField(ref _settingsTabPublicBusinessContactGroups, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabRebuildPipeline
        /// </summary>
        [JsonProperty("settingsTab_RebuildPipeline")]
        public bool? SettingsTabRebuildPipeline { get => _settingsTabRebuildPipeline; set => SetField(ref _settingsTabRebuildPipeline, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSecondaryRoot
        /// </summary>
        [JsonProperty("settingsTab_SecondaryRoot")]
        public bool? SettingsTabSecondaryRoot { get => _settingsTabSecondaryRoot; set => SetField(ref _settingsTabSecondaryRoot, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSettingsReport
        /// </summary>
        [JsonProperty("settingsTab_SettingsReport")]
        public bool? SettingsTabSettingsReport { get => _settingsTabSettingsReport; set => SetField(ref _settingsTabSettingsReport, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSettlementServiceProviders
        /// </summary>
        [JsonProperty("settingsTab_SettlementServiceProviders")]
        public bool? SettingsTabSettlementServiceProviders { get => _settingsTabSettlementServiceProviders; set => SetField(ref _settingsTabSettlementServiceProviders, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabSystemAuditTrail
        /// </summary>
        [JsonProperty("settingsTab_SystemAuditTrail")]
        public bool? SettingsTabSystemAuditTrail { get => _settingsTabSystemAuditTrail; set => SetField(ref _settingsTabSystemAuditTrail, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTablesFees
        /// </summary>
        [JsonProperty("settingsTab_TablesFees")]
        public bool? SettingsTabTablesFees { get => _settingsTabTablesFees; set => SetField(ref _settingsTabTablesFees, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTaskSets
        /// </summary>
        [JsonProperty("settingsTab_TaskSets")]
        public bool? SettingsTabTaskSets { get => _settingsTabTaskSets; set => SetField(ref _settingsTabTaskSets, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoCustomFields
        /// </summary>
        [JsonProperty("settingsTab_TpoCustomFields")]
        public bool? SettingsTabTpoCustomFields { get => _settingsTabTpoCustomFields; set => SetField(ref _settingsTabTpoCustomFields, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoFees
        /// </summary>
        [JsonProperty("settingsTab_TpoFees")]
        public bool? SettingsTabTpoFees { get => _settingsTabTpoFees; set => SetField(ref _settingsTabTpoFees, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoReassignment
        /// </summary>
        [JsonProperty("settingsTab_TpoReassignment")]
        public bool? SettingsTabTpoReassignment { get => _settingsTabTpoReassignment; set => SetField(ref _settingsTabTpoReassignment, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoSettings
        /// </summary>
        [JsonProperty("settingsTab_TpoSettings")]
        public bool? SettingsTabTpoSettings { get => _settingsTabTpoSettings; set => SetField(ref _settingsTabTpoSettings, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabTpoWebCenterDocs
        /// </summary>
        [JsonProperty("settingsTab_TpoWebCenterDocs")]
        public bool? SettingsTabTpoWebCenterDocs { get => _settingsTabTpoWebCenterDocs; set => SetField(ref _settingsTabTpoWebCenterDocs, value); }

        /// <summary>
        /// MiscellaneousRights SettingsTabUnlockLoanFile
        /// </summary>
        [JsonProperty("settingsTab_UnlockLoanFile")]
        public bool? SettingsTabUnlockLoanFile { get => _settingsTabUnlockLoanFile; set => SetField(ref _settingsTabUnlockLoanFile, value); }

        /// <summary>
        /// MiscellaneousRights ThinThickPipelineTabAccess
        /// </summary>
        [JsonProperty("thinThick_PipelineTab_Access")]
        public bool? ThinThickPipelineTabAccess { get => _thinThickPipelineTabAccess; set => SetField(ref _thinThickPipelineTabAccess, value); }

        /// <summary>
        /// MiscellaneousRights ThinThickTradesTabAccess
        /// </summary>
        [JsonProperty("thinThick_TradesTab_Access")]
        public bool? ThinThickTradesTabAccess { get => _thinThickTradesTabAccess; set => SetField(ref _thinThickTradesTabAccess, value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabShowAsMgrAdminInBranchesTab
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ShowAsMgrAdminInBranchesTab")]
        public bool? TPOAdministrationTabShowAsMgrAdminInBranchesTab { get => _tPOAdministrationTabShowAsMgrAdminInBranchesTab; set => SetField(ref _tPOAdministrationTabShowAsMgrAdminInBranchesTab, value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabShowAsMgrAdminInCompanyInfoTab
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ShowAsMgrAdminInCompanyInfoTab")]
        public bool? TPOAdministrationTabShowAsMgrAdminInCompanyInfoTab { get => _tPOAdministrationTabShowAsMgrAdminInCompanyInfoTab; set => SetField(ref _tPOAdministrationTabShowAsMgrAdminInCompanyInfoTab, value); }

        /// <summary>
        /// MiscellaneousRights TPOAdministrationTabViewCmtConfirmations
        /// </summary>
        [JsonProperty("tPOAdministrationTab_ViewCmtConfirmations")]
        public bool? TPOAdministrationTabViewCmtConfirmations { get => _tPOAdministrationTabViewCmtConfirmations; set => SetField(ref _tPOAdministrationTabViewCmtConfirmations, value); }
    }
}