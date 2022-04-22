namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// BusinessCategoryField
    /// </summary>
    public sealed class BusinessCategoryField : DirtyExtensibleObject
    {
        /// <summary>
        /// BusinessCategoryField FieldId
        /// </summary>
        public int? FieldId { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// BusinessCategoryField FieldValue
        /// </summary>
        public string? FieldValue { get => GetValue<string?>(); set => SetValue(value); }
    }
}