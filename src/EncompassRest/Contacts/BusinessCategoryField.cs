namespace EncompassRest.Contacts
{
    /// <summary>
    /// BusinessCategoryField
    /// </summary>
    public sealed class BusinessCategoryField : DirtyExtensibleObject
    {
        private DirtyValue<int?>? _fieldId;
        private DirtyValue<string?>? _fieldValue;

        /// <summary>
        /// BusinessCategoryField FieldId
        /// </summary>
        public int? FieldId { get => _fieldId; set => SetField(ref _fieldId, value); }

        /// <summary>
        /// BusinessCategoryField FieldValue
        /// </summary>
        public string? FieldValue { get => _fieldValue; set => SetField(ref _fieldValue, value); }
    }
}