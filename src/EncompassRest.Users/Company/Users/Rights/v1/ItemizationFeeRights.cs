using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ItemizationFeeRights
    /// </summary>
    public sealed class ItemizationFeeRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ItemizationFeeRights FeeAmounts
        /// </summary>
        [AllowNull]
        public FeeAmountsRights FeeAmounts { get => GetEntity<FeeAmountsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ItemizationFeeRights FeeDescription
        /// </summary>
        public bool? FeeDescription { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ItemizationFeeRights FeeOptions
        /// </summary>
        [AllowNull]
        public FeeOptionsRights FeeOptions { get => GetEntity<FeeOptionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ItemizationFeeRights PaidToName
        /// </summary>
        public bool? PaidToName { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ItemizationFeeRights PaidToType
        /// </summary>
        public bool? PaidToType { get => GetValue<bool?>(); set => SetValue(value); }
    }
}