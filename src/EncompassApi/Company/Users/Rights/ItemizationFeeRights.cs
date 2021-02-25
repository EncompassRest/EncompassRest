using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ItemizationFeeRights
    /// </summary>
    public sealed class ItemizationFeeRights : DirtyExtensibleObject
    {
        private FeeAmountsRights? _feeAmounts;
        private DirtyValue<bool?>? _feeDescription;
        private FeeOptionsRights? _feeOptions;
        private DirtyValue<bool?>? _paidToName;
        private DirtyValue<bool?>? _paidToType;

        /// <summary>
        /// ItemizationFeeRights FeeAmounts
        /// </summary>
        [AllowNull]
        public FeeAmountsRights FeeAmounts { get => GetField(ref _feeAmounts); set => SetField(ref _feeAmounts, value); }

        /// <summary>
        /// ItemizationFeeRights FeeDescription
        /// </summary>
        public bool? FeeDescription { get => _feeDescription; set => SetField(ref _feeDescription, value); }

        /// <summary>
        /// ItemizationFeeRights FeeOptions
        /// </summary>
        [AllowNull]
        public FeeOptionsRights FeeOptions { get => GetField(ref _feeOptions); set => SetField(ref _feeOptions, value); }

        /// <summary>
        /// ItemizationFeeRights PaidToName
        /// </summary>
        public bool? PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }

        /// <summary>
        /// ItemizationFeeRights PaidToType
        /// </summary>
        public bool? PaidToType { get => _paidToType; set => SetField(ref _paidToType, value); }
    }
}