using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// UserEFolderRights
    /// </summary>
    public sealed class UserEFolderRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _historyTab;
        private PostClosingConditionsTabRights _postClosingConditionsTab;
        private PreliminaryConditionsTabRights _preliminaryConditionsTab;
        private PurchaseConditionsRights _purchaseConditions;
        private UnderwritingConditionsTabRights _underwritingConditionsTab;

        /// <summary>
        /// UserEFolderRights HistoryTab
        /// </summary>
        public bool? HistoryTab { get => _historyTab; set => SetField(ref _historyTab, value); }

        /// <summary>
        /// UserEFolderRights PostClosingConditionsTab
        /// </summary>
        [JsonProperty("post-ClosingConditionsTab")]
        public PostClosingConditionsTabRights PostClosingConditionsTab { get => GetField(ref _postClosingConditionsTab); set => SetField(ref _postClosingConditionsTab, value); }

        /// <summary>
        /// UserEFolderRights PreliminaryConditionsTab
        /// </summary>
        public PreliminaryConditionsTabRights PreliminaryConditionsTab { get => GetField(ref _preliminaryConditionsTab); set => SetField(ref _preliminaryConditionsTab, value); }

        /// <summary>
        /// UserEFolderRights PurchaseConditions
        /// </summary>
        public PurchaseConditionsRights PurchaseConditions { get => GetField(ref _purchaseConditions); set => SetField(ref _purchaseConditions, value); }

        /// <summary>
        /// UserEFolderRights UnderwritingConditionsTab
        /// </summary>
        public UnderwritingConditionsTabRights UnderwritingConditionsTab { get => GetField(ref _underwritingConditionsTab); set => SetField(ref _underwritingConditionsTab, value); }
    }
}