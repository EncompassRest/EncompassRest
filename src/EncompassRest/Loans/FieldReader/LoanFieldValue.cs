namespace EncompassRest.Loans.FieldReader
{
    internal sealed class LoanFieldValue : ExtensibleObject
    {
        public string FieldId { get; set; }

        public string Value { get; set; }
    }
}