namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// SubjectProperty
    /// </summary>
    public sealed partial class SubjectProperty : DirtyExtensibleObject
    {
        /// <summary>
        /// Address of the subject property.
        /// </summary>
        public string? Address { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// City of the subject property.
        /// </summary>
        public string? City { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// State of the subject property.
        /// </summary>
        public string? State { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Postal code of the subject property.
        /// </summary>
        public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// County of the subject property.
        /// </summary>
        public string? County { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Estimated Amount of the subject property.
        /// </summary>
        public int? EstimatedAmount { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Appraised Amount of the subject property.
        /// </summary>
        public int? AppraisedAmount { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Purchase Price of the subject property.
        /// </summary>
        public decimal? PurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Usage Type of the subject property.
        /// </summary>
        public string? UsageType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Number Of Units in the subject property.
        /// </summary>
        public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// GSE property type.
        /// </summary>
        public string? GsePropertyType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the subject property is a Condotel Property.
        /// </summary>
        public bool? IsCondotelProperty { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the subject property is a Non-Warrantable Project Property.
        /// </summary>
        public bool? IsNonWarrantableProjectProperty { get => GetValue<bool?>(); set => SetValue(value); }
    }
}