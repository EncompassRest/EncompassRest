namespace EncompassRest.Schema
{
    public sealed class FieldOption : ExtensibleObject
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string ReportingDatabaseValue { get; set; }
    }
}