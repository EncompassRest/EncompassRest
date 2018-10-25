using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// FeeOptionsRights
    /// </summary>
    public sealed class FeeOptionsRights : ParentAccessRights
    {
        private DirtyValue<bool?> _borrowerCanShopFor;
        private DirtyValue<bool?> _borrwerDidShopFor;
        private DirtyValue<bool?> _escrowed;
        private DirtyValue<bool?> _impactAPR;
        private DirtyValue<bool?> _optional13101315;
        private DirtyValue<bool?> _propertyTaxesHomeownersInsuranceOther10071009;
        private DirtyValue<bool?> _propertyTaxesHomeownersInsuranceOther907912;

        /// <summary>
        /// FeeOptionsRights BorrowerCanShopFor
        /// </summary>
        public bool? BorrowerCanShopFor { get => _borrowerCanShopFor; set => SetField(ref _borrowerCanShopFor, value); }

        /// <summary>
        /// FeeOptionsRights BorrwerDidShopFor
        /// </summary>
        public bool? BorrwerDidShopFor { get => _borrwerDidShopFor; set => SetField(ref _borrwerDidShopFor, value); }

        /// <summary>
        /// FeeOptionsRights Escrowed
        /// </summary>
        public bool? Escrowed { get => _escrowed; set => SetField(ref _escrowed, value); }

        /// <summary>
        /// FeeOptionsRights ImpactAPR
        /// </summary>
        public bool? ImpactAPR { get => _impactAPR; set => SetField(ref _impactAPR, value); }

        /// <summary>
        /// FeeOptionsRights Optional13101315
        /// </summary>
        [JsonProperty("optional(1310-1315)")]
        public bool? Optional13101315 { get => _optional13101315; set => SetField(ref _optional13101315, value); }

        /// <summary>
        /// FeeOptionsRights PropertyTaxesHomeownersInsuranceOther10071009
        /// </summary>
        [JsonProperty("propertyTaxes,Homeowner'sInsurance,Other(1007-1009)")]
        public bool? PropertyTaxesHomeownersInsuranceOther10071009 { get => _propertyTaxesHomeownersInsuranceOther10071009; set => SetField(ref _propertyTaxesHomeownersInsuranceOther10071009, value); }

        /// <summary>
        /// FeeOptionsRights PropertyTaxesHomeownersInsuranceOther907912
        /// </summary>
        [JsonProperty("propertyTaxes,Homeowner'sInsurance,Other(907-912)")]
        public bool? PropertyTaxesHomeownersInsuranceOther907912 { get => _propertyTaxesHomeownersInsuranceOther907912; set => SetField(ref _propertyTaxesHomeownersInsuranceOther907912, value); }
    }
}