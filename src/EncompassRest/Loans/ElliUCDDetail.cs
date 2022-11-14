namespace EncompassRest.Loans
{
    /// <summary>
    /// ElliUCDDetail
    /// </summary>
    public sealed partial class ElliUCDDetail : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _cdFields;
        private DirtyValue<string?>? _leFields;

        /// <summary>
        /// ElliUCDDetail cdFields
        /// </summary>
        public string? cdFields { get => _cdFields; set => SetField(ref _cdFields, value); }

        /// <summary>
        /// ElliUCDDetail leFields
        /// </summary>
        public string? leFields { get => _leFields; set => SetField(ref _leFields, value); }
    }
}