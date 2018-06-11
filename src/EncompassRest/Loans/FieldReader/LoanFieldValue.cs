namespace EncompassRest.Loans.FieldReader
{
    public sealed class LoanFieldValue : ExtensibleObject
    {
        public string FieldId { get; set; }

        public string Value { get; set; }
    }
}