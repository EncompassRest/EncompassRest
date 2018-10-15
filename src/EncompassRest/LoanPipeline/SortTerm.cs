namespace EncompassRest.LoanPipeline
{
    public sealed class SortTerm : ExtensibleObject
    {
        public string FieldName { get; set; }

        public bool UseNull { get; set; }
    }
}