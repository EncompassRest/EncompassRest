using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UserEFolderRights
    /// </summary>
    public sealed class UserEFolderRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _historyTab;
        private PostClosingConditionRights? _postClosingCondition;
        private PostClosingConditionsTabRights? _postClosingConditionsTab;
        private PreliminaryConditionsRights? _preliminaryConditions;
        private PreliminaryConditionsTabRights? _preliminaryConditionsTab;
        private PurchaseConditionsRights? _purchaseConditions;
        private SellConditionsRights? _sellConditions;
        private UnderwritingConditionsRights? _underwritingConditions;
        private UnderwritingConditionsTabRights? _underwritingConditionsTab;

        /// <summary>
        /// UserEFolderRights HistoryTab
        /// </summary>
        public bool? HistoryTab { get => _historyTab; set => SetField(ref _historyTab, value); }

        /// <summary>
        /// UserEFolderRights PostClosingCondition
        /// </summary>
        [AllowNull]
        public PostClosingConditionRights PostClosingCondition { get => GetField(ref _postClosingCondition); set => SetField(ref _postClosingCondition, value); }

        /// <summary>
        /// UserEFolderRights PostClosingConditionsTab
        /// </summary>
        [JsonProperty("post-ClosingConditionsTab")]
        [AllowNull]
        public PostClosingConditionsTabRights PostClosingConditionsTab { get => GetField(ref _postClosingConditionsTab); set => SetField(ref _postClosingConditionsTab, value); }

        /// <summary>
        /// UserEFolderRights PreliminaryConditions
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsRights PreliminaryConditions { get => GetField(ref _preliminaryConditions); set => SetField(ref _preliminaryConditions, value); }

        /// <summary>
        /// UserEFolderRights PreliminaryConditionsTab
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsTabRights PreliminaryConditionsTab { get => GetField(ref _preliminaryConditionsTab); set => SetField(ref _preliminaryConditionsTab, value); }

        /// <summary>
        /// UserEFolderRights PurchaseConditions
        /// </summary>
        [AllowNull]
        public PurchaseConditionsRights PurchaseConditions { get => GetField(ref _purchaseConditions); set => SetField(ref _purchaseConditions, value); }

        /// <summary>
        /// UserEFolderRights SellConditions
        /// </summary>
        [AllowNull]
        public SellConditionsRights SellConditions { get => GetField(ref _sellConditions); set => SetField(ref _sellConditions, value); }

        /// <summary>
        /// UserEFolderRights UnderwritingConditions
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsRights UnderwritingConditions { get => GetField(ref _underwritingConditions); set => SetField(ref _underwritingConditions, value); }

        /// <summary>
        /// UserEFolderRights UnderwritingConditionsTab
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsTabRights UnderwritingConditionsTab { get => GetField(ref _underwritingConditionsTab); set => SetField(ref _underwritingConditionsTab, value); }
    }
}