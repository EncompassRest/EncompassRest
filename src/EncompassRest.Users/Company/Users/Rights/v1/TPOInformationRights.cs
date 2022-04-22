using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOInformationRights
    /// </summary>
    public sealed class TPOInformationRights : ParentAccessRights
    {
        /// <summary>
        /// TPOInformationRights AttachmentsTab
        /// </summary>
        public bool? AttachmentsTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights BasicInfoTab
        /// </summary>
        public bool? BasicInfoTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights CommitmentsTab
        /// </summary>
        public bool? CommitmentsTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights CustomFieldsTab
        /// </summary>
        [AllowNull]
        public CustomFieldsTabRights CustomFieldsTab { get => GetEntity<CustomFieldsTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOInformationRights DBATab
        /// </summary>
        public bool? DBATab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights FeesTab
        /// </summary>
        public bool? FeesTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights KeyContactsTab
        /// </summary>
        public bool? KeyContactsTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights LenderContacts
        /// </summary>
        public bool? LenderContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights LicenseTab
        /// </summary>
        public bool? LicenseTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights LoanCriteriaTab
        /// </summary>
        public bool? LoanCriteriaTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights LOCompTab
        /// </summary>
        public bool? LOCompTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights NotesTab
        /// </summary>
        public bool? NotesTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights ONRPTab
        /// </summary>
        public bool? ONRPTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights SalesRepsAETab
        /// </summary>
        [JsonProperty("salesReps/AETab")]
        public bool? SalesRepsAETab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights TPOWebCenterDocsTab
        /// </summary>
        public bool? TPOWebCenterDocsTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights TPOWebCenterSetupTab
        /// </summary>
        public bool? TPOWebCenterSetupTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights TradeMgmtTab
        /// </summary>
        public bool? TradeMgmtTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOInformationRights WarehouseTab
        /// </summary>
        public bool? WarehouseTab { get => GetValue<bool?>(); set => SetValue(value); }
    }
}