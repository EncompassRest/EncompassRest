namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// SortTerm
    /// </summary>
    public sealed class SortTerm : ExtensibleObject
    {
        /// <summary>
        /// SortTerm FieldName
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// SortTerm UseNull
        /// </summary>
        public bool UseNull { get; set; }
    }
}