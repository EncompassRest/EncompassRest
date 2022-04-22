using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UserEFolderRights
    /// </summary>
    public sealed class UserEFolderRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UserEFolderRights HistoryTab
        /// </summary>
        public bool? HistoryTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserEFolderRights PostClosingCondition
        /// </summary>
        [AllowNull]
        public PostClosingConditionRights PostClosingCondition { get => GetEntity<PostClosingConditionRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights PostClosingConditionsTab
        /// </summary>
        [JsonProperty("post-ClosingConditionsTab")]
        [AllowNull]
        public PostClosingConditionsTabRights PostClosingConditionsTab { get => GetEntity<PostClosingConditionsTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights PreliminaryConditions
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsRights PreliminaryConditions { get => GetEntity<PreliminaryConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights PreliminaryConditionsTab
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsTabRights PreliminaryConditionsTab { get => GetEntity<PreliminaryConditionsTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights PurchaseConditions
        /// </summary>
        [AllowNull]
        public PurchaseConditionsRights PurchaseConditions { get => GetEntity<PurchaseConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights SellConditions
        /// </summary>
        [AllowNull]
        public SellConditionsRights SellConditions { get => GetEntity<SellConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights UnderwritingConditions
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsRights UnderwritingConditions { get => GetEntity<UnderwritingConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserEFolderRights UnderwritingConditionsTab
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsTabRights UnderwritingConditionsTab { get => GetEntity<UnderwritingConditionsTabRights>(); set => SetEntity(value); }
    }
}