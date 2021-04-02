using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// DigitalClosingRights
    /// </summary>
    public sealed class DigitalClosingRights : DirtyExtensibleObject
    {
        private ClosingPackageManagmentDigitalClosingRights? _closingPackageManagmentDigitalClosing;
        private DirtyValue<bool?>? _closingPackageManagmentDigitalClosingValue;
        private OrderClosingDocsDigitalClosingRights? _orderClosingDocsDigitalClosing;
        private DirtyValue<bool?>? _orderClosingDocsDigitalClosingValue;

        /// <summary>
        /// DigitalClosingRights ClosingPackageManagmentDigitalClosing
        /// </summary>
        [AllowNull]
        public ClosingPackageManagmentDigitalClosingRights ClosingPackageManagmentDigitalClosing { get => GetField(ref _closingPackageManagmentDigitalClosing); set => SetField(ref _closingPackageManagmentDigitalClosing, value); }

        /// <summary>
        /// DigitalClosingRights ClosingPackageManagmentDigitalClosingValue
        /// </summary>
        [JsonProperty("closingPackageManagmentDigitalClosing_")]
        public bool? ClosingPackageManagmentDigitalClosingValue { get => _closingPackageManagmentDigitalClosingValue; set => SetField(ref _closingPackageManagmentDigitalClosingValue, value); }

        /// <summary>
        /// DigitalClosingRights OrderClosingDocsDigitalClosing
        /// </summary>
        [AllowNull]
        public OrderClosingDocsDigitalClosingRights OrderClosingDocsDigitalClosing { get => GetField(ref _orderClosingDocsDigitalClosing); set => SetField(ref _orderClosingDocsDigitalClosing, value); }

        /// <summary>
        /// DigitalClosingRights OrderClosingDocsDigitalClosingValue
        /// </summary>
        [JsonProperty("orderClosingDocsDigitalClosing_")]
        public bool? OrderClosingDocsDigitalClosingValue { get => _orderClosingDocsDigitalClosingValue; set => SetField(ref _orderClosingDocsDigitalClosingValue, value); }
    }
}