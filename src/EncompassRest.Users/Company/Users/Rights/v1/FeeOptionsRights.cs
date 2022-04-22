using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FeeOptionsRights
    /// </summary>
    public sealed class FeeOptionsRights : ParentAccessRights
    {
        /// <summary>
        /// FeeOptionsRights BorrowerCanShopFor
        /// </summary>
        public bool? BorrowerCanShopFor { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights BorrwerDidShopFor
        /// </summary>
        public bool? BorrwerDidShopFor { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights Escrowed
        /// </summary>
        public bool? Escrowed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights ImpactAPR
        /// </summary>
        public bool? ImpactAPR { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights Optional13101315
        /// </summary>
        [JsonProperty("optional(1310-1315)")]
        public bool? Optional13101315 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights PropertyTaxesHomeownersInsuranceOther10071009
        /// </summary>
        [JsonProperty("propertyTaxes,Homeowner'sInsurance,Other(1007-1009)")]
        public bool? PropertyTaxesHomeownersInsuranceOther10071009 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// FeeOptionsRights PropertyTaxesHomeownersInsuranceOther907912
        /// </summary>
        [JsonProperty("propertyTaxes,Homeowner'sInsurance,Other(907-912)")]
        public bool? PropertyTaxesHomeownersInsuranceOther907912 { get => GetValue<bool?>(); set => SetValue(value); }
    }
}