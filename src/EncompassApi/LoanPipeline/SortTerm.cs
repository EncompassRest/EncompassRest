namespace EncompassApi.LoanPipeline
{
    /// <summary>
    /// SortTerm
    /// </summary>
    public sealed class SortTerm : ExtensibleObject
    {
        /// <summary>
        /// SortTerm FieldName
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public string FieldName { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// SortTerm UseNull
        /// </summary>
        public bool UseNull { get; set; }
    }
}