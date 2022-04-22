using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DigitalClosingRights
    /// </summary>
    public sealed class DigitalClosingRights : DirtyExtensibleObject
    {
        /// <summary>
        /// DigitalClosingRights ClosingPackageManagmentDigitalClosing
        /// </summary>
        [AllowNull]
        public ClosingPackageManagmentDigitalClosingRights ClosingPackageManagmentDigitalClosing { get => GetEntity<ClosingPackageManagmentDigitalClosingRights>(); set => SetEntity(value); }

        /// <summary>
        /// DigitalClosingRights ClosingPackageManagmentDigitalClosingValue
        /// </summary>
        [JsonProperty("closingPackageManagmentDigitalClosing_")]
        public bool? ClosingPackageManagmentDigitalClosingValue { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DigitalClosingRights ConfigureClosingOptionsDigitalClosing
        /// </summary>
        public bool? ConfigureClosingOptionsDigitalClosing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DigitalClosingRights OrderClosingDocsDigitalClosing
        /// </summary>
        [AllowNull]
        public OrderClosingDocsDigitalClosingRights OrderClosingDocsDigitalClosing { get => GetEntity<OrderClosingDocsDigitalClosingRights>(); set => SetEntity(value); }

        /// <summary>
        /// DigitalClosingRights OrderClosingDocsDigitalClosingValue
        /// </summary>
        [JsonProperty("orderClosingDocsDigitalClosing_")]
        public bool? OrderClosingDocsDigitalClosingValue { get => GetValue<bool?>(); set => SetValue(value); }
    }
}