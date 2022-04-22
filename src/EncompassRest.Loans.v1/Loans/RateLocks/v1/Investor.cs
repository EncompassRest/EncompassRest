using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// Rate Lock Investor
    /// </summary>
    public sealed partial class Investor : DirtyExtensibleObject
    {
        /// <summary>
        /// Investor Locked Date
        /// </summary>
        public DateTime? LockedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Delivery Date
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? DeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Target Delivery Date
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? TargetDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Name
        /// </summary>
        public string? Name { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact
        /// </summary>
        public string? Contact { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact Phone
        /// </summary>
        public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact Email
        /// </summary>
        public string? Email { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact City
        /// </summary>
        public string? City { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact State
        /// </summary>
        public string? State { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact PostalCode
        /// </summary>
        public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Contact Website
        /// </summary>
        public string? Website { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Lock type. Possible values are Mandatory or Best Efforts
        /// </summary>
        public StringEnumValue<CommitmentType> LockType { get => GetValue<StringEnumValue<CommitmentType>>(); set => SetValue(value); }

        /// <summary>
        /// Investor status
        /// </summary>
        public string? Status { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Status Date
        /// </summary>
        public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Investor Commitment Identifier
        /// </summary>
        public string? Commitment { get => GetValue<string?>(); set => SetValue(value); }
    }
}